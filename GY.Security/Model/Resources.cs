using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GY.Security.Model
{
    /// <summary>
    ///  
    /// </summary>
    [Serializable]
    public class Resources
    {

        /// <summary>
        /// 
        /// <summary>
        public Guid ResourceId
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// <summary>
        public Guid ParentId
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// <summary>
        public String ResourceName
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// <summary>
        public Int32 SortIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// <summary>
        public String Describe
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// <summary>
        public String UrlLink
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// <summary>
        public Int32 Status
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// <summary>
        public String CreatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// <summary>
        public String CreatedByName
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// <summary>
        public DateTime CreatedTime
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// <summary>
        public String ModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// <summary>
        public String ModifiedByName
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// <summary>
        public DateTime ModifiedTime
        {
            get;
            set;
        }



    }
}