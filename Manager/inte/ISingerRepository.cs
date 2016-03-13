using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;
using Spring.Data.NHibernate.Generic.Support;

namespace Manager.inte
{
    public interface ISingerRepository : IRepository<Singer>
    {
        void AddSong(object singerId, Song song);

        void UpdateSong(object singerId, Song song);

        //object Register();
    }
}
