using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character>GetCharacters();
        Character GetCharactersById(int id);
        
        List<Character>AddCharacter(Character newCharacters);
        object? GetAllCharacters();
    }
}