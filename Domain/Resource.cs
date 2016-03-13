using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Resource
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
        /// dspnmae
        /// </summary>
        public virtual string DspName
        {
            get;
            set;
        }
        /// <summary>
        /// realname
        /// </summary>
        public virtual string RealName
        {
            get;
            set;
        }
        /// <summary>
        /// type
        /// </summary>
        public virtual string Type
        {
            get;
            set;
        }
    }
}
