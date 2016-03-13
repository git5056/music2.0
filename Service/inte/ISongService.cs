using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.inte
{
    public interface ISongService : IService<Domain.Song>
    {
        IList<Domain.Song> LatestSongs(int top);

    }
}
