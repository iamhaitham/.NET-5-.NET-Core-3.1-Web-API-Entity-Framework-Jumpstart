using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Section_1___Introduction___.NET_5.DTOs.Character;
using Section_1___Introduction___.NET_5.Models;

namespace Section_1___Introduction___.NET_5.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
    }
}