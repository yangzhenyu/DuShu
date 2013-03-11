USE [Read]
GO
/****** Object:  Table [dbo].[Read_Update]    Script Date: 03/04/2013 22:24:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Read_Update](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[LastBook] [int] NULL,
	[LastChapter] [int] NULL,
	[LastBookDate] [datetime] NULL,
	[LastChapterDate] [datetime] NULL,
 CONSTRAINT [PK_Read_Update] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Read_Site]    Script Date: 03/04/2013 22:24:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Read_Site](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SiteName] [varchar](50) NULL,
	[SiteUrl] [varchar](500) NULL,
	[SpliderDeep] [int] NULL,
	[IsNotSplideParms] [bit] NULL,
	[IsActive] [bit] NULL,
	[IsSplider] [bit] NULL,
	[LastSplider] [datetime] NULL,
	[BookReg] [varchar](1000) NULL,
	[BookRegIndex] [int] NULL,
	[ChapterReg] [varchar](1000) NULL,
	[ChapterRegIndex] [int] NULL,
	[ContentReg] [varchar](1000) NULL,
	[ContentRegIndex] [int] NULL,
	[IsSeriesReg] [varchar](1000) NULL,
	[BookWriter] [varchar](1000) NULL,
	[ContentUrl] [varchar](500) NULL,
	[ChapterUrl] [varchar](500) NULL,
 CONSTRAINT [PK_read_site] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'扫描层级' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Read_Site', @level2type=N'COLUMN',@level2name=N'SpliderDeep'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否屏蔽带参数URL' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Read_Site', @level2type=N'COLUMN',@level2name=N'IsNotSplideParms'
GO
/****** Object:  Table [dbo].[Read_Chapter]    Script Date: 03/04/2013 22:24:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Read_Chapter](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ChapterName] [varchar](500) NULL,
	[ChapterID] [int] NULL,
	[SiteID] [int] NULL,
	[BookID] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[ChapterUrl] [varchar](500) NULL,
	[ChapterContent] [text] NULL,
	[ChapterContentUrl] [varchar](500) NULL,
	[IsSpilder] [bit] NULL,
 CONSTRAINT [PK_Read_Chapter] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否已经扫描' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Read_Chapter', @level2type=N'COLUMN',@level2name=N'IsSpilder'
GO
/****** Object:  Table [dbo].[Read_Book]    Script Date: 03/04/2013 22:24:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Read_Book](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BookID] [int] NULL,
	[SiteID] [int] NULL,
	[BookName] [varchar](100) NULL,
	[BookWriter] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsSerialize] [bit] NULL,
	[LastChapteID] [int] NULL,
	[BookUrl] [varchar](500) NULL,
	[ChapterUrl] [varchar](500) NULL,
 CONSTRAINT [PK_Read_Book] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_Read_Book_IsSerialize]    Script Date: 03/04/2013 22:24:42 ******/
ALTER TABLE [dbo].[Read_Book] ADD  CONSTRAINT [DF_Read_Book_IsSerialize]  DEFAULT ((1)) FOR [IsSerialize]
GO
/****** Object:  Default [DF_Read_Chapter_IsSpilder]    Script Date: 03/04/2013 22:24:42 ******/
ALTER TABLE [dbo].[Read_Chapter] ADD  CONSTRAINT [DF_Read_Chapter_IsSpilder]  DEFAULT ((0)) FOR [IsSpilder]
GO
/****** Object:  Default [DF_Read_Site_SpliderDeep]    Script Date: 03/04/2013 22:24:42 ******/
ALTER TABLE [dbo].[Read_Site] ADD  CONSTRAINT [DF_Read_Site_SpliderDeep]  DEFAULT ((1)) FOR [SpliderDeep]
GO
/****** Object:  Default [DF_Read_Site_IsNotSplideParms]    Script Date: 03/04/2013 22:24:42 ******/
ALTER TABLE [dbo].[Read_Site] ADD  CONSTRAINT [DF_Read_Site_IsNotSplideParms]  DEFAULT ((1)) FOR [IsNotSplideParms]
GO
