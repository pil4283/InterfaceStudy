using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceT.Weapon
{
    /// <summary>
    /// 근접무기 베이스 클래스
    /// </summary>
    class MeleeWeapon<T> where T : IMeleeWeapon
    {
        /// <summary>
        /// 근접무기의 데미지
        /// </summary>
        int damage;
        /// <summary>
        /// 내구도
        /// </summary>
        int durability;

        public MeleeWeapon(int damage, int durability)
        {
            this.damage = damage;
            this.durability = durability;
        }

        public void Fire<T>() where T : IFireable
        {

        }
    }
}
