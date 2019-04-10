using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceT.Weapon
{
    class WoodSword : MeleeWeapon<ISwordWeapon>
    {
        Object.FireableObject fireableObject;
        public WoodSword(int damage, int durability) : base(damage, durability)
        {
            damage = 5;
            durability = 20;
            fireableObject = new Object.FireableObject();
        }

        public void Fire()
        {
            fireableObject.Fire();
        }
    }
}
