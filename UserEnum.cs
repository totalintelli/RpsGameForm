using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpsGameForm
{
    // 가위바위보 상태
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

    // 게임 결과
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


}
