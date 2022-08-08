using System.Threading.Tasks;
using PlatFormService.Dtos;

namespace PlatFormService.SyncDataServices.Http
{
    public interface ICommadDataClient
    {
        Task SendPlatformToCommad(PlatformReadDto plat);
    }
}