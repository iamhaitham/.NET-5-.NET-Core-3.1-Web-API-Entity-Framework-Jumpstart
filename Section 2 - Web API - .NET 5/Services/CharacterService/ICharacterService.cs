using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Section_1___Introduction___.NET_5.Models;

namespace Section_1___Introduction___.NET_5.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById(int id);
        List<Character> AddCharacter(Character newCharacter);
    }
}