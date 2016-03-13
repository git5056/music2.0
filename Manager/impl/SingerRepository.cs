using Spring.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager.impl
{
    class SingerRepository : Repository<Domain.Singer>, inte.ISingerRepository
    {
        public void AddSong(object singedId, Domain.Song song)
        {
            AssertUtils.ArgumentNotNull(singedId,"singerId");
            var singer = FindById(singedId);
            if (singer == null)
            {
                throw new Exception("歌手不存在");
            }
            singer.AddSong(song);
        }
        public void UpdateSong(object singerId, Domain.Song song)
        {
            
            AssertUtils.ArgumentNotNull(song, "song");
            if (song.ID < 1)
            {
                throw new Exception("song_id不能小于1");
            }
            var singer = FindById(singerId);
            if (null == singer)
            {
                throw new Exception(singer + " 歌手不存在");
            }
            singer.UpdateSong(song);
        }

    }

}
