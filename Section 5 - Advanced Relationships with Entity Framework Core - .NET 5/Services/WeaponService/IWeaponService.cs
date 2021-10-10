using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Section_1___Introduction___.NET_5.DTOs.Character;
using Section_1___Introduction___.NET_5.DTOs.Weapon;
using Section_1___Introduction___.NET_5.Models;

namespace Section_1___Introduction___.NET_5.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeapondDto newWeapon);
    }
}