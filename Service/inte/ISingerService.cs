using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.inte
{
    public interface ISingerService:IService<Domain.Singer>
    {
      //ex
        void AddSong(object singedId, Domain.Song song);

        void UpdateSong(object singerId, Domain.Song song);
    }
}
