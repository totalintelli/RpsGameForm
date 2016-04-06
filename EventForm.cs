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
    public enum Status
    {
        /// <summary>
        /// 가위
        /// </summary>
        Gawi = 0,

        /// <summary>
        /// 바위
        /// </summary>
        Bawi = 1,

        /// <summary>
        /// 보
        /// </summary>
        Bo = 2,

        /// <summary>
        /// 아직 정하지 않은 상태
        /// </summary>
        None = -1
    }

    public enum Results
    {
        /// <summary>
        /// 승리
        /// </summary>
        Win = 0,
        
        /// <summary>
        /// 무승부
        /// </summary>
        Draw = 1,

        /// <summary>
        /// 패배
        /// </summary>
        Lose = 2,

        /// <summary>
        /// 아직 결정되지 않은 상태
        /// </summary>
        None = -1
    }

    public partial class EventForm : Form
    {
        RpsGame RpsGame = new RpsGame();
        string GawiImgPath = "E:\\Projects\\RpsGameForm\\RpsGameForm\\Scissors.png";
        string BawiImgPath = "E:\\Projects\\RpsGameForm\\RpsGameForm\\Rock.png";
        string BoImgPath = "E:\\Projects\\RpsGameForm\\RpsGameForm\\Paper.png";

        public EventForm()
        {
            InitializeComponent();
            leftPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            rightPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RpsGame.GameResultEvent += ShowResult;
        }

        private void btn_clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(btn == btn_gawi)
            {
                RpsGame.UserSelect = 0;
                leftPicBox.Load(GawiImgPath);
            }
            else if(btn == btn_bawi)
            {
                RpsGame.UserSelect = 1;
                leftPicBox.Load(BawiImgPath);
            }
            else if(btn == btn_bo)
            {
                RpsGame.UserSelect = 2;
                leftPicBox.Load(BoImgPath);
            }

            RpsGame.DoSomething(RpsGame);
        }

        public void ShowResult(Expression Expression)
        {
            // 컴퓨터 선택의 변환값을 화면에 표시한다.
            switch (RpsGame.ComSelect)
            {
                case 0:
                    rightPicBox.Load(GawiImgPath);
                    break;
                case 1:
                    rightPicBox.Load(BawiImgPath);
                    break;
                case 2:
                    rightPicBox.Load(BoImgPath);
                    break;
                default:
                    break;
            }

            if(Expression.GameResult == Results.Win)
            {
                lb_result.Text = "당신은 이겼습니다.";
            }
            else if(Expression.GameResult == Results.Draw)
            {
                lb_result.Text = "당신은 비겼습니다.";
            }
            else if(Expression.GameResult == Results.Lose)
            {
                lb_result.Text = "당신은 졌습니다.";
            }
        }
    }

    public class RpsGame
    {
        // 입력 값
        public int UserSelect; // 사용자의 선택값

        // 처리 값
        public int ComSelect;    // 컴퓨터의 선택값

        public int SetComputerChoice()
        {
            // 컴퓨터의 선택을 구한다.
            Random Random = new Random();
            ComSelect = Random.Next(0, 3);

            return ComSelect;
        }

        public Expression Play(int UserChoice, int ComputerChoice)
        {
            Expression Expression = new Expression();
            Expression.GameResult = Results.None;    // 게임 결과

            if(UserSelect == ComSelect)
            {
                Expression.GameResult = Results.Draw;
            }
            else
            {
                switch(UserSelect)
                {
                    case 0: Expression.GameResult = (ComSelect == 2) ? Results.Win : Results.Lose; break;
                    case 1: Expression.GameResult = (ComSelect == 0) ? Results.Win : Results.Lose; break;
                    case 2: Expression.GameResult = (ComSelect == 1) ? Results.Win : Results.Lose; break;
                }
            }

            return Expression;
        }


        public delegate void GameEventHandler(Expression Expression);
        public event GameEventHandler GameResultEvent;
        public void DoSomething(RpsGame RpsGame)
        {
            SetComputerChoice();

            Expression Expression = new Expression();
            Expression = Play(UserSelect, ComSelect);

            if (GameResultEvent != null)
                GameResultEvent(Expression);
        }
        
        public class GameEventArgs : System.EventArgs
        {
            public string gameEvent; // 이벤트 변수 설정

            public GameEventArgs(string e_gameEvent)
            {
                gameEvent = e_gameEvent;
            }
        }

    }

    public class Expression
    {
        public Results GameResult;

    }

}
