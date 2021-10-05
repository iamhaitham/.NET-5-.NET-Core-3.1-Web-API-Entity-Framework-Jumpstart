using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Section_1___Introduction___.NET_5.Models;

namespace Section_1___Introduction___.NET_5.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static readonly List<Character> characters = new List<Character>
        {
            new Character(),
            new Character(){Id=1,Name="Sam"}
        };
        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}