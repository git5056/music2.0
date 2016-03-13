using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager.inte;

namespace Manager.impl
{
    public class SongRepository:Repository<Domain.Song>,ISongRepository
    {
        public IList<Domain.Song> LatestSongs(int top)
        {

            HibernateTemplate.MaxResults = top;
            return HibernateTemplate.Find<Domain.Song>("from " + typeof(Domain.Song) + " order by uptime desc");
            //using (var session = HibernateTemplate.SessionFactory.OpenSession())
            //{
            //    var query = session.CreateQuery("from " + typeof(Domain.Song) + " order by uptime desc");
            //    query.SetMaxResults(top);
            //    HibernateTemplate.PrepareQuery(query);
            //    return HibernateTemplate.Find<Domain.Song>("");
            //}
        }
    }
}
