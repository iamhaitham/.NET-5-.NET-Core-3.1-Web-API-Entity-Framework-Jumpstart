using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section_1___Introduction___.NET_5.DTOs.Weapon
{
    public class AddWeapondDto
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int CharacterId { set; get; }
    }
}