using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceT.Weapon
{
    /// <summary>
    /// 무기의 인터페이스(최상위)
    /// </summary>
    interface IWeapon
    {
        /// <summary>
        /// 스텟 초기화
        /// </summary>
        /// <param name="damage">데미지</param>
        /// <param name="durability">내구도</param>
        void Init(int damage, int durability);
    }
}
