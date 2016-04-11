using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpsGameForm
{
   

    public partial class EventForm : Form
    {
        RpsGame RpsGame = new RpsGame();

        static string CommonPath = "E:\\Projects\\RpsGameForm\\RpsGameForm\\"; // 공통 경로
        string GawiImgPath = CommonPath + "Scissors.png"; // 가위 이미지 경로
        string BawiImgPath = CommonPath + "Rock.png";     // 바위 이미지 경로
        string BoImgPath = CommonPath + "Paper.png";      // 보 이미지 경로

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

            RpsGame.Run(RpsGame);
        }



        // 게임 결과를 화면에 출력한다.
        private void ShowResult(Results GameResult)
        {
            LoadImage();
                        
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
            string PbLeftImgPath = ""; //사용자의 선택 값과 같은 가위바위보 이미지의 경로
            switch (RpsGame.UserSelect)
            {
                case 0:
                    {
                        PbLeftImgPath = GawiImgPath;
                        break;
                    }
                case 1:
                    {
                        PbLeftImgPath = BawiImgPath;
                        break;
                    }
                case 2:
                    {
                        PbLeftImgPath = BoImgPath;
                        break;
                    }
                default:
                    break;
            }
            PbLeft.Load(PbLeftImgPath);

            string PbRightImgPath = ""; // 컴퓨터의 선택 값과 같은 가위바위보 이미지의 경로
            // 컴퓨터 선택의 변환값을 화면에 표시한다.
            switch (RpsGame.ComSelect)
            {
                case 0:
                    {
                        PbRightImgPath = GawiImgPath;
                        break;
                    }
                case 1:
                    {
                        PbRightImgPath = BawiImgPath;
                        break;
                    }
                case 2:
                    {
                        PbRightImgPath = BoImgPath;
                        break;
                    }
                default:
                    break;
            }
            PbRight.Load(PbRightImgPath);
        }
    }
}
