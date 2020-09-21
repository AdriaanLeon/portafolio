using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Dtos.Character;
using WebApi.Models;

namespace WebApi.Services.CharacterServices
{
    public interface ICharacterServices
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updateCharacterDto);
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
    }
}