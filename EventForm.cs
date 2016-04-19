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
        static string CommonPath = Application.StartupPath + @"\..\..\"; // 현재 프로젝트 디렉토리 경로
        string GawiImgPath = CommonPath + "Scissors.png"; // 가위 이미지 경로
        string BawiImgPath = CommonPath + "Rock.png";     // 바위 이미지 경로
        string BoImgPath = CommonPath + "Paper.png";      // 보 이미지 경로
        List<RpsImg> RpsImgList = new List<RpsImg>(); // 사용자나 컴퓨터가 선택한 수와 가위바위보 이미지의 리스트
        List<RpsTxt> RpsTxtList = new List<RpsTxt>(); // 게임 결과와 게임 결과 글자의 목록
        RpsGame RpsGame = new RpsGame(); // 가위바위보 게임 객체

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
            Results GameResult;
            string ResultText;

            public RpsTxt(Results m_GameResult, string m_ResultText)
            {
                GameResult = m_GameResult;
                ResultText = m_ResultText;
            }

            public Results GetGameResult()
            {
                return GameResult;
            }

            public string GetResultText()
            {
                return ResultText;
            }

            public bool Equals(Results m_GameResult)
            {
                bool Res = false;

                if (GameResult == m_GameResult)
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
            Random Random = new Random(); // 컴퓨터가 자동으로 선택하도록 하기 위한 Random 클래스
            
            int UserSelect = -1;               // 사용자가 선택한 값
            int ComSelect = Random.Next(0, 3); // 컴퓨터가 선택한 값

            if (Btn == BtnGawi)
            {
               UserSelect = 0;
            }
            else if (Btn == BtnBawi)
            {
                UserSelect = 1;
            }
            else if (Btn == BtnBo)
            {
                UserSelect = 2;
            }
            
            RpsGame.Run(UserSelect , ComSelect);
        }

        // 게임 결과를 화면에 출력한다.
        private void ShowResult(GameEventArgs GameEventArgs)
        {
            // 화면에 이미지를 불러온다.
            LoadImage(GameEventArgs);

            // 화면에 게임 결과를 불러온다.
            LoadText(GameEventArgs);
        }

        // 가위바위보 게임 결과 글자를 화면에 출력한다.
        private void LoadText(GameEventArgs GameEventArgs)
        {
            // 화면에 게임 결과 글자를 출력한다.
            lb_result.Text = GetResultText(GameEventArgs);
        }

        // 가위바위보 게임 결과 글자를 구한다.
        public string GetResultText(GameEventArgs GameEventArgs)
        {
            string ResultText = ""; // 가위바위보 게임 결과 글자
            
            RpsTxtList.Add(new RpsTxt(Results.Win, "당신은 이겼습니다."));
            RpsTxtList.Add(new RpsTxt(Results.Draw, "당신은 비겼습니다."));
            RpsTxtList.Add(new RpsTxt(Results.Lose, "당신은 졌습니다."));

            // 게임 결과 글자를 고른다.
            for (int i = 0; i < RpsTxtList.Count; i++)
            {
                if (RpsTxtList[i].Equals(GameEventArgs.GameResult))
                {
                    ResultText = RpsTxtList[i].GetResultText();
                }
            }

            return ResultText;
        }

        // 가위바위보 이미지를 화면에 출력한다.
        public void LoadImage(GameEventArgs GameEventArgs)
        {
            string PbLeftImgPath = GetImgPath(GameEventArgs.UserSelect); // 사용자가 선택한 값과 같은 가위바위보 이미지의 경로
            string PbRightImgPath = GetImgPath(GameEventArgs.ComSelect); // 컴퓨터가 선택한 값과 같은 가위바위보 이미지의 경로

            // 화면에 이미지를 출력한다.
            PbLeft.Load(PbLeftImgPath);
            PbRight.Load(PbRightImgPath);
        }

        // 이미지 경로를 구한다.
        public string GetImgPath(int number)
        {
            string ImgPath = ""; // 출력할 가위바위보 이미지의 경로
            
            RpsImgList.Add(new RpsImg(0, GawiImgPath));
            RpsImgList.Add(new RpsImg(1, BawiImgPath));
            RpsImgList.Add(new RpsImg(2, BoImgPath));

            // 사용자나 컴퓨터가 선택한 수에 알맞는 이미지 경로를 찾는다.
            for (int i = 0; i < RpsImgList.Count; i++)
            {
                if (RpsImgList[i].GetIntNumber() == number)
                {
                    ImgPath = RpsImgList[i].GetStrImgPath();
                }
            }

            return ImgPath;
        }
    }



}
