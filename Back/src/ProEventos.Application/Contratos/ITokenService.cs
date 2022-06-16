using System;
using System.Threading.Tasks;
using ProEventos.Application.Dtos;

namespace ProEventos.Application.Contratos
{
    public interface ITokenService
    {
        Task<String> CreateToken(UserUpdateDto userUpdateDto);
    }
}