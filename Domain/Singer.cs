using Iesi.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Singer
    {

        /// <summary>
        /// singer_id
        /// </summary>
        public virtual int ID
        {
            get;
            set;
        }

        /// <summary>
        /// singer_name
        /// </summary>
        public virtual string Name
        {
            get;
            set;
        }


        ///// <summary>
        ///// headimg_res_id
        ///// </summary>
        //public virtual int HeadImgResId
        //{
        //    get;
        //    set;
        //}

        public virtual Resource HeadImg
        {
            get;
            set;
        }


        /// <summary>
        /// birthday
        /// </summary>
        public virtual DateTime Birthday
        {
            get;
            set;
        }
        /// <summary>
        /// fav
        /// </summary>
        public virtual int Fav
        {
            get;
            set;
        }
        /// <summary>
        /// introduce
        /// </summary>
        public virtual string Introduce
        {
            get;
            set;
        }
        /// <summary>
        /// weight
        /// </summary>
        public virtual int Weight
        {
            get;
            set;
        }
        /// <summary>
        /// tall
        /// </summary>
        public virtual int Tall
        {
            get;
            set;
        }
        /// <summary>
        /// address
        /// </summary>
        public virtual string Address
        {
            get;
            set;
        }
        /// <summary>
        /// tag_id
        /// </summary>
        public virtual int TagId
        {
            get;
            set;
        }
        /// <summary>
        /// type_id
        /// </summary>
        public virtual string TypeIds
        {
            get;
            set;
        }
        /// <summary>
        /// reviewenabled
        /// </summary>
        public virtual bool ReviewEnabled { get; set; }

        /// <summary>
        /// visitorreviewenabled
        /// </summary>
        public virtual bool VisitorReviewEnabled { get; set; }

        #region exp

        /* 这里用ISet集合
         * 命名空间Iesi.Collections.Generic;
         */
        private Iesi.Collections.Generic.ISet<Song> songs;

        /// <summary>
        /// SongsCollection
        /// </summary>
        public virtual Iesi.Collections.Generic.ISet<Song> Songs
        {
            get
            {
                if (songs == null)
                {
                    songs = new HashedSet<Song>();
                }
                return songs;
            }
            set
            {
                songs = value;
            }
        }

        #endregion

        #region Method

        public virtual void AddSong(Song song)
        {
            if (song == null)
            {
                throw new ArgumentNullException("song");
            }
            Songs.Add(song);
        }

        private static void CopyAToB(Song A, Song B)
        {
            B.ID = A.ID;
            B.Hot = A.Hot;
            B.LrcId = A.LrcId;
            B.PubTime = A.PubTime;
            B.Tags = A.Tags;
            B.WriteWords = B.WriteWords;
            B.Name = A.Name;
            //.....
        }

        public virtual void UpdateSong(Song song)
        {
            if (song == null)
            {
                throw new ArgumentNullException("song");
            }
            foreach (var item in Songs)
            {
                if (item.ID == song.ID)
                {
                    CopyAToB(song, item);
                    return;
                }
            }
            throw new Exception("歌手歌曲不匹配");
        }

        #endregion
    }

}
