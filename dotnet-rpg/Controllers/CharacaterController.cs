global using dotnet_rpg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Services.CharacterService;
namespace dotnet_rpg.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CharacaterController:ControllerBase
    {
      private static List<Character> Characters = new List<Character>
      {

        new Character(),
        new Character{Id=1, Name="sam"}


      };
        private readonly ICharacterService _characterServices;

        public CharacaterController(ICharacterService characterServices)
        {
            _characterServices = characterServices;
        }

      [HttpGet("GetAll")]
      public ActionResult<List<Character>> get()
      {
        return Ok(_characterServices.GetAllCharacters());

      }


      [HttpGet("{id}")]
      public ActionResult<Character> GetSingle(int id)
      {
        return Ok(_characterServices.GetCharactersById(id));

      }

      [HttpPost]
      public ActionResult<List<Character>>AddCharacter(Character newCharacter)
      {

        return Ok(_characterServices.AddCharacter(newCharacter));


      }




    }
}