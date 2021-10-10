using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Section_1___Introduction___.NET_5.DTOs.Character;
using Section_1___Introduction___.NET_5.DTOs.Skills;
using Section_1___Introduction___.NET_5.DTOs.Weapon;
using Section_1___Introduction___.NET_5.Models;

namespace Section_1___Introduction___.NET_5
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon,GetWeaponDto>();
            CreateMap<Skill,GetSkillDto>();
        }
    }
}