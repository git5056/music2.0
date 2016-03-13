using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager.inte
{
    public interface ISongRepository : IRepository<Domain.Song>
    {
        IList<Domain.Song> LatestSongs(int top);
    }
}
