using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpsGameForm
{

    public class RpsGame
    {
        // 입력 값(사용자가 선택한 값)
        public int UserSelect;

        // 처리 값(컴퓨터가 선택한 값)
        public int ComSelect;

        // 가위바위보 게임의 결과를 구한다.
        public Results Play(int UserSelect, int ComSelect)
        {
            Results GameResult = Results.None;    // 가위바위보 게임 결과

            if (UserSelect == ComSelect)
            {
                GameResult = Results.Draw;
            }
            else
            {
                switch (UserSelect)
                {
                    case 0: GameResult = (ComSelect == 2) ? Results.Win : Results.Lose; break;
                    case 1: GameResult = (ComSelect == 0) ? Results.Win : Results.Lose; break;
                    case 2: GameResult = (ComSelect == 1) ? Results.Win : Results.Lose; break;
                }
            }

            return GameResult;
        }

        // 가위바위보 게임 이벤트
        public delegate void GameEventHandler(GameEventArgs GameEventArgs);
        public event GameEventHandler GameResultEvent;
        private void FireGameResultEvent(Results Value)
        {
            if (GameResultEvent != null)
                GameResultEvent(new GameEventArgs(UserSelect, ComSelect , Value));
        }

        // 가위바위보 게임 이벤트를 실행한다.
        public void Run(int a ,int b)
        {
            UserSelect = a;
            ComSelect = b;

            Results GameResult = Play(a, b);
            FireGameResultEvent(GameResult);
        }
    }

    public class GameEventArgs
    {
        public int UserSelect { get; private set; }
        public int ComSelect { get; private set; }
        public Results GameResult { get; private set; }

        public GameEventArgs(int m_UserSelect, int m_ComSelect, Results m_GameResult)
        {
            UserSelect = m_UserSelect;
            ComSelect = m_ComSelect;
            GameResult = m_GameResult;
        }

    }
}
