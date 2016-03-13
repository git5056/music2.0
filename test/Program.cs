using Manager.inte;
using Spring.Objects.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var context = Spring.Context.Support.ContextRegistry.GetContext();
            var iof = context;
            var te = iof.GetObject("SingerService") as Service.inte.ISingerService;
            var singer = te.FindById(27);
            var song = iof.GetObject("SongService") as Service.inte.ISongService;
            var songs = song.LatestSongs(10);
            string name = songs[0].Name;
            var name2 = songs[1].Singer.ID;
            //te.UpdateSong(27, new Domain.Song() { AlbumId=0,Compose="www",ID=70, CoverResId=6,Hot=555,LrcId=0,Name="123aatsdfsxggfestaa",UpTime=DateTime.Now ,WriteWords="" ,  PubTime=DateTime.Now,SongResId=6 });
            
        }
    }
}
