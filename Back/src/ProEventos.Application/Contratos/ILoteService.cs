using System.Threading.Tasks;
using ProEventos.Application.Dtos;

namespace ProEventos.Application.Contratos
{
    public interface ILoteService
    {
         Task<LoteDto[]> SaveLotes(int eventoId, LoteDto[] models);
         Task<bool> DeleteLote(int eventoId, int lodeId);


        Task<LoteDto[]> GetLotesByEventoIdAsync(int eventoid);
        Task<LoteDto> GetLoteByIdsAsync(int eventoId, int loteId);
    }
}