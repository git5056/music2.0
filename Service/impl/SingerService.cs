using Service.inte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager.inte;
using Spring.Util;

namespace Service.impl
{
    public class SingerService : Service<Domain.Singer>, ISingerService
    {
        public void AddSong(object singedId, Domain.Song song)
        {
            AssertUtils.ArgumentNotNull(song, "song");
            if (song.ID > 0)
            {
                throw new Exception("song_id不能大于0");
            }
            if (_repository is ISingerRepository)
            {
                ((ISingerRepository)_repository).AddSong(singedId, song);
            }
            else
            {
                throw new Exception("请检查配置信息");
            }
        }

        public void UpdateSong(object singerId, Domain.Song song)
        {
            ((ISingerRepository)_repository).UpdateSong(singerId, song);
        }

        public void LoadChild()
        {

        }
    }
}
