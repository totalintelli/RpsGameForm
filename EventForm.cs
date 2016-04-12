using System;
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
            int IntNumber;
            string StrImgPath; 

            public RpsImg(int Number, string ImgPath)
            {
                IntNumber = Number;
                StrImgPath = ImgPath;
            }

            public int GetIntNumber()
            {
                return IntNumber;
            }

            public string GetStrImgPath()
            {
                return StrImgPath;
            }
        }

        struct RpsTxt
        {
            Results m_GameResult;
            string m_ResultText;

            public RpsTxt(Results GameResult, string ResultText)
            {
                m_GameResult = GameResult;
                m_ResultText = ResultText;
            }

            public Results GetGameResult()
            {
                return m_GameResult;
            }

            public string GetResultText()
            {
                return m_ResultText;
            }

            public bool Equals(Results GameResult)
            {
                bool Res = false;

                if(m_GameResult == GameResult)
                {
                    Res = true;
                }

                return Res;
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

        // 가위바위보 게임 결과를 화면에 출력한다.
        private void LoadText(Results GameResult)
        {
            // 화면에 텍스트를 출력한다.
            lb_result.Text = GetResultText(GameResult);
        }

        // 가위바위보 게임 결과 글자를 구한다.
        public string GetResultText(Results GameResult)
        {
            string ResultText = ""; // 게임 결과 글자의 경로

            List<RpsTxt> RpsTxtList = new List<RpsTxt>(); // 게임 결과와 게임 결과 글자의 목록
            RpsTxtList.Add(new RpsTxt(Results.Win, "당신은 이겼습니다."));
            RpsTxtList.Add(new RpsTxt(Results.Draw, "당신은 비겼습니다."));
            RpsTxtList.Add(new RpsTxt(Results.Lose, "당신은 졌습니다."));

            // 게임 결과 글자를 고른다.
            for (int i = 0; i < RpsTxtList.Count; i++)
            {
                if (RpsTxtList[i].Equals(GameResult))
                {
                    ResultText = RpsTxtList[i].GetResultText();
                }
            }

            return ResultText;
        }

        // 가위바위보 이미지를 화면에 출력한다.
        public void LoadImage()
        {
            string PbLeftImgPath = GetImgPath(RpsGame.UserSelect); //사용자가 선택한 값과 같은가위바위보 이미지의 경로
            string PbRightImgPath = GetImgPath(RpsGame.ComSelect); // 컴퓨터의 선택 값과 같은 가위바위보 이미지의 경로
            
            // 화면에 이미지를 출력한다.
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

            // 수에 알맞는 이미지 경로를 찾는다.
            for(int i = 0; i < RpsImgList.Count; i++)
            {
                if(RpsImgList[i].GetIntNumber() == number)
                {
                    ImgPath = RpsImgList[i].GetStrImgPath();
                }
            }

            return ImgPath;
        }
    }



}
