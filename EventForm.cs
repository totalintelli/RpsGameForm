﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RpsGameForm
{
   

    public partial class EventForm : Form
    {
        RpsGame RpsGame = new RpsGame();

        static string CommonPath = Application.StartupPath + @"\..\..\"; // 현재 프로젝트 디렉토리 경로
        string GawiImgPath = CommonPath + "Scissors.png"; // 가위 이미지 경로
        string BawiImgPath = CommonPath + "Rock.png";     // 바위 이미지 경로
        string BoImgPath = CommonPath + "Paper.png";      // 보 이미지 경로

        struct RpsImg
        {
            int m_Number;
            string m_ImgPath;

            public RpsImg(int Number, string ImgPath)
            {
                m_Number = Number;
                m_ImgPath = ImgPath;
            }

            public int GetNumber()
            {
                return m_Number;
            }

            public string GetImgPath()
            {
                return m_ImgPath;
            }
        }

        public EventForm()
        {
            InitializeComponent();
            PbLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            PbRight.SizeMode = PictureBoxSizeMode.StretchImage;
            RpsGame.GameResultEvent += ShowResult;
           
        }

     

        // 사용자의 선택 값을 입력받는다.
        private void btn_clicked(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;

            if(Btn == BtnGawi)
            {
                RpsGame.UserSelect = 0;
            }
            else if(Btn == BtnBawi)
            {
                RpsGame.UserSelect = 1;
            }
            else if(Btn == BtnBo)
            {
                RpsGame.UserSelect = 2;
            }

            RpsGame.Run();
        }



        // 게임 결과를 화면에 출력한다.
        private void ShowResult(Results GameResult)
        {
            // 화면에 이미지를 불러온다.
            LoadImage();

            // 화면에 게임 결과 글자를 불러온다.
            LoadText(GameResult);
        }

        private void LoadText(Results GameResult)
        {
            string ResultText = "";
            switch (GameResult)
            {
                case Results.Win:
                    {
                        ResultText = "당신은 이겼습니다.";
                        break;
                    }
                case Results.Draw:
                    {
                        ResultText = "당신은 비겼습니다.";
                        break;
                    }
                case Results.Lose:
                    {
                        ResultText = "당신은 졌습니다.";
                        break;
                    }
                case Results.None:
                    {
                        ResultText = "컴퓨터가 고민하고 있습니다.";
                        break;
                    }
                default:
                    break;
            }

            lb_result.Text = ResultText;
        }



        // 가위바위보 이미지를 화면에 출력한다.
        public void LoadImage()
        {
            string PbLeftImgPath = GetImgPath(RpsGame.UserSelect); //사용자가 선택한 값과 같은가위바위보 이미지의 경로
            string PbRightImgPath = GetImgPath(RpsGame.ComSelect); // 컴퓨터의 선택 값과 같은 가위바위보 이미지의 경로
            
            PbLeft.Load(PbLeftImgPath);
            PbRight.Load(PbRightImgPath);
        }

        // 이미지 경로를 구한다.
        public string GetImgPath(int number)
        {
            string ImgPath = ""; // 출력할 가위바위보 이미지의 경로
            List<RpsImg> RpsImgList = new List<RpsImg>(); // 사용자나 컴퓨터가 선택한 수와 가위바위보 이미지의 리스트
            RpsImgList.Add(new RpsImg(0, GawiImgPath));
            RpsImgList.Add(new RpsImg(1, BawiImgPath));
            RpsImgList.Add(new RpsImg(2, BoImgPath));

            for(int i = 0; i < RpsImgList.Count; i++)
            {
                if(RpsImgList[i].GetNumber() == number)
                {
                    ImgPath = RpsImgList[i].GetImgPath();
                }
            }

            return ImgPath;
        }
    }



}
