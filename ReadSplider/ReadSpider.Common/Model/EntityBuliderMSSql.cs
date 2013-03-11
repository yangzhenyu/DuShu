/*
	以下代码为T4自动生成的代码，请不要擅自修改
	生成时间:2013-03-04 15:06:04.9278
	生成机器：WANGJUN
	author：xiaose
*/
using System;
using System.Collections.Generic; 
using System.Text;
using HelloData.FrameWork.Data;

 
	
    /// <summary>
	///	
	/// </summary>
	[Serializable]
    public partial class Read_Chapter: BaseEntity
    {
	  
	    /// <summary>
		///	
		/// </summary>
        [Column(IsKeyProperty = true,AutoIncrement=true)]
		public int ID { get; set; }	
		public  Read_Chapter()
        {
            base.SetIni(this,"GY_Chapter","ID");
        }	
	    /// <summary>
		///	
		/// </summary>
 
		public string ChapterName { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public int? ChapterID { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public int? SiteID { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public int? BookID { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public DateTime? UpdateDate { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public string ChapterUrl { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public string ChapterContent { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public string ChapterContentUrl { get; set; }		
	    /// <summary>
		///	是否已经扫描
		/// </summary>
 
		public bool? IsSpilder { get; set; }		
				
		public static class Columns
		{
			public const string ID="ID";					
			public const string ChapterName="ChapterName";					
			public const string ChapterID="ChapterID";					
			public const string SiteID="SiteID";					
			public const string BookID="BookID";					
			public const string UpdateDate="UpdateDate";					
			public const string ChapterUrl="ChapterUrl";					
			public const string ChapterContent="ChapterContent";					
			public const string ChapterContentUrl="ChapterContentUrl";					
			public const string IsSpilder="IsSpilder";					
		}
				 
	}
					
    /// <summary>
	///	
	/// </summary>
	[Serializable]
    public partial class Read_Update: BaseEntity
    {
	  
	    /// <summary>
		///	
		/// </summary>
        [Column(IsKeyProperty = true,AutoIncrement=true)]
		public int id { get; set; }	
		public  Read_Update()
        {
            base.SetIni(this,"GY_Update","id");
        }	
	    /// <summary>
		///	
		/// </summary>
 
		public int? LastBook { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public int? LastChapter { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public DateTime? LastBookDate { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public DateTime? LastChapterDate { get; set; }		
				
		public static class Columns
		{
			public const string id="id";					
			public const string LastBook="LastBook";					
			public const string LastChapter="LastChapter";					
			public const string LastBookDate="LastBookDate";					
			public const string LastChapterDate="LastChapterDate";					
		}
				 
	}
					
    /// <summary>
	///	
	/// </summary>
	[Serializable]
    public partial class Read_Site: BaseEntity
    {
	  
	    /// <summary>
		///	
		/// </summary>
        [Column(IsKeyProperty = true,AutoIncrement=true)]
		public int ID { get; set; }	
		public  Read_Site()
        {
            base.SetIni(this,"GY_Site","ID");
        }	
	    /// <summary>
		///	
		/// </summary>
 
		public string SiteName { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public string SiteUrl { get; set; }		
	    /// <summary>
		///	扫描层级
		/// </summary>
 
		public int? SpliderDeep { get; set; }		
	    /// <summary>
		///	是否屏蔽带参数URL
		/// </summary>
 
		public bool? IsNotSplideParms { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public bool? IsActive { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public bool? IsSplider { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public DateTime? LastSplider { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public string BookReg { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public int? BookRegIndex { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public string ChapterReg { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public int? ChapterRegIndex { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public string ContentReg { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public int? ContentRegIndex { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public string IsSeriesReg { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public string BookWriter { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public string ContentUrl { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public string ChapterUrl { get; set; }		
				
		public static class Columns
		{
			public const string ID="ID";					
			public const string SiteName="SiteName";					
			public const string SiteUrl="SiteUrl";					
			public const string SpliderDeep="SpliderDeep";					
			public const string IsNotSplideParms="IsNotSplideParms";					
			public const string IsActive="IsActive";					
			public const string IsSplider="IsSplider";					
			public const string LastSplider="LastSplider";					
			public const string BookReg="BookReg";					
			public const string BookRegIndex="BookRegIndex";					
			public const string ChapterReg="ChapterReg";					
			public const string ChapterRegIndex="ChapterRegIndex";					
			public const string ContentReg="ContentReg";					
			public const string ContentRegIndex="ContentRegIndex";					
			public const string IsSeriesReg="IsSeriesReg";					
			public const string BookWriter="BookWriter";					
			public const string ContentUrl="ContentUrl";					
			public const string ChapterUrl="ChapterUrl";					
		}
				 
	}
					
    /// <summary>
	///	
	/// </summary>
	[Serializable]
    public partial class Read_Book: BaseEntity
    {
	  
	    /// <summary>
		///	
		/// </summary>
        [Column(IsKeyProperty = true,AutoIncrement=true)]
		public int ID { get; set; }	
		public  Read_Book()
        {
            base.SetIni(this,"GY_Book","ID");
        }	
	    /// <summary>
		///	
		/// </summary>
 
		public int? BookID { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public int? SiteID { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public string BookName { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public string BookWriter { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public DateTime? UpdateDate { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public bool? IsActive { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public bool? IsSerialize { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public int? LastChapteID { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public string BookUrl { get; set; }		
	    /// <summary>
		///	
		/// </summary>
 
		public string ChapterUrl { get; set; }		
				
		public static class Columns
		{
			public const string ID="ID";					
			public const string BookID="BookID";					
			public const string SiteID="SiteID";					
			public const string BookName="BookName";					
			public const string BookWriter="BookWriter";					
			public const string UpdateDate="UpdateDate";					
			public const string IsActive="IsActive";					
			public const string IsSerialize="IsSerialize";					
			public const string LastChapteID="LastChapteID";					
			public const string BookUrl="BookUrl";					
			public const string ChapterUrl="ChapterUrl";					
		}
				 
	}
				 

