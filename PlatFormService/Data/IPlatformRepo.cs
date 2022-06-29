

using PlatFormService.Models;
using System.Collections.Generic;

namespace PlatFormService.Data
{
    public interface IPlatformRepo
    {
        bool Savechanges();

        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);


    }
}
