using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Section_1___Introduction___.NET_5.DTOs.Skills;
using Section_1___Introduction___.NET_5.DTOs.Weapon;
using Section_1___Introduction___.NET_5.Migrations;
using Section_1___Introduction___.NET_5.Models;

namespace Section_1___Introduction___.NET_5.DTOs.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
        public GetWeaponDto Weapon { set; get; }
        public List<GetSkillDto> Skills { set; get; }
    }
}