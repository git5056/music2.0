using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.inte;
using Manager.inte;

namespace Service.impl
{
    public class SongService : Service<Domain.Song>, ISongService
    {
        public IList<Domain.Song> LatestSongs(int top)
        {
            if (_repository is ISongRepository)
            {
                return ((ISongRepository)_repository).LatestSongs(top); 
            }
            else
            {
                throw new Exception("配置错误");
            }
            //using (var session = OpenSession())
            //{
            //    var query = session.CreateQuery("from " + typeof(IMusic.PO.songs) + " order by uptime desc");
            //    query.SetMaxResults(top);
            //    return query.List<PO.songs>();
            //}
        }
    }
}
