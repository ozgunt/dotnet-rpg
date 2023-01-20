using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    
    public class CharacterService : ICharacterService
    {    private static List<Character> Characters = new List<Character>
      {

        new Character(),
        new Character{Id=1, Name="sam"}


      };
        public List<Character> AddCharacter(Character newCharacters)
        {
         Characters.Add(newCharacters);
        return Characters;

        }

        public object? GetAllCharacters()
        {
            throw new NotImplementedException();
        }

        public List<Character> GetCharacters()
        {
               return Characters;
        }

        public Character GetCharactersById(int id)
        {

            var character=Characters.FirstOrDefault(c=>c.Id==id);
            if(character is not null)
              return character;

              throw Exception ("Character Not Found");
              
        }
    }
}