using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Song
    {
        /// <summary>
        /// _id
        /// </summary>
        public virtual int ID
        {
            get;
            set;
        }

        /// <summary>
        /// song_name
        /// </summary>
        public virtual string Name
        {
            get;
            set;
        }

        /// <summary>
        /// cover_res_id
        /// </summary>
        public virtual int CoverResId
        {
            get;
            set;
        }

        ///// <summary>
        ///// singer_id
        ///// </summary>
        //public virtual int SingerId
        //{
        //    get;
        //    set;
        //}

        /// <summary>
        /// uptime
        /// </summary>
        public virtual DateTime UpTime
        {
            get;
            set;
        }
        /// <summary>
        /// pubtime
        /// </summary>
        public virtual DateTime PubTime
        {
            get;
            set;
        }
        /// <summary>
        /// hot
        /// </summary>
        public virtual int Hot
        {
            get;
            set;
        }
        /// <summary>
        /// song_res_id
        /// </summary>
        public virtual int SongResId
        {
            get;
            set;
        }
        /// <summary>
        /// album_id
        /// </summary>
        public virtual int AlbumId
        {
            get;
            set;
        }
        /// <summary>
        /// time
        /// </summary>
        public virtual decimal Time
        {
            get;
            set;
        }
        /// <summary>
        /// lrc_id
        /// </summary>
        public virtual int LrcId
        {
            get;
            set;
        }
        /// <summary>
        /// compose
        /// </summary>
        public virtual string Compose
        {
            get;
            set;
        }
        /// <summary>
        /// writewords
        /// </summary>
        public virtual string WriteWords
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
        /// tags
        /// </summary>
        public virtual string Tags
        {
            get;
            set;
        }

        #region exp

        public virtual Singer Singer { get; set; }

        #endregion
    }
}
