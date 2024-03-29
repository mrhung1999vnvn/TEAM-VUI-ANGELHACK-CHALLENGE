USE [EnglishDB]
GO
/****** Object:  UserDefinedFunction [dbo].[auto_idDictionary]    Script Date: 6/23/2019 12:49:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[auto_idDictionary]()
returns varchar(5)
as
begin
	declare @id varchar(5)
	if(select COUNT(ID) FROM tbl_Dictionary)=0
		set @id='0'
	else
		select @id = max(RIGHT(ID,3)) from tbl_Dictionary
		select @id = case
					when @id>=0 and @id<9 then 'W00' + CONVERT(CHAR, CONVERT(INT,@id)+1)
					when @id>9 then 'W0' + convert(char, CONVERT(int,@id)+1)
		end
		return @id
end

GO
/****** Object:  Table [dbo].[tbl_Baitap]    Script Date: 6/23/2019 12:49:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Baitap](
	[ID] [varchar](10) NOT NULL,
	[BAITAP] [varchar](500) NULL,
	[DANGBAI] [varchar](50) NULL,
	[IDDIC] [varchar](10) NULL,
	[IDUSER] [varchar](10) NOT NULL,
	[DAPAN] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Baitap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Dictionary]    Script Date: 6/23/2019 12:49:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Dictionary](
	[ID] [varchar](10) NOT NULL CONSTRAINT [df_id]  DEFAULT ([dbo].[auto_idDictionary]()),
	[WORD] [varchar](50) NOT NULL,
	[TYPE] [varchar](30) NOT NULL,
	[DEFINE] [varchar](100) NOT NULL,
	[VD] [varchar](300) NULL,
 CONSTRAINT [pk_dicid] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_TuChuaHoc]    Script Date: 6/23/2019 12:49:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_TuChuaHoc](
	[ID] [varchar](10) NULL,
	[IDDIC] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_TuDaHoc]    Script Date: 6/23/2019 12:49:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_TuDaHoc](
	[ID] [varchar](10) NULL,
	[IDDICTION] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 6/23/2019 12:49:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_User](
	[ID] [varchar](10) NOT NULL,
	[USERNAME] [varchar](30) NULL,
	[PASSWORD] [varchar](30) NULL,
 CONSTRAINT [PK_tbl_USER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tbl_Baitap]  WITH CHECK ADD  CONSTRAINT [fk_iddic] FOREIGN KEY([IDDIC])
REFERENCES [dbo].[tbl_Dictionary] ([ID])
GO
ALTER TABLE [dbo].[tbl_Baitap] CHECK CONSTRAINT [fk_iddic]
GO
ALTER TABLE [dbo].[tbl_Baitap]  WITH CHECK ADD  CONSTRAINT [fk_iduser] FOREIGN KEY([IDUSER])
REFERENCES [dbo].[tbl_User] ([ID])
GO
ALTER TABLE [dbo].[tbl_Baitap] CHECK CONSTRAINT [fk_iduser]
GO
ALTER TABLE [dbo].[tbl_TuChuaHoc]  WITH CHECK ADD  CONSTRAINT [fk_iddicc] FOREIGN KEY([IDDIC])
REFERENCES [dbo].[tbl_Dictionary] ([ID])
GO
ALTER TABLE [dbo].[tbl_TuChuaHoc] CHECK CONSTRAINT [fk_iddicc]
GO
ALTER TABLE [dbo].[tbl_TuChuaHoc]  WITH CHECK ADD  CONSTRAINT [pk_idChuaHoc] FOREIGN KEY([ID])
REFERENCES [dbo].[tbl_User] ([ID])
GO
ALTER TABLE [dbo].[tbl_TuChuaHoc] CHECK CONSTRAINT [pk_idChuaHoc]
GO
ALTER TABLE [dbo].[tbl_TuDaHoc]  WITH CHECK ADD  CONSTRAINT [fk_iddicDH] FOREIGN KEY([IDDICTION])
REFERENCES [dbo].[tbl_Dictionary] ([ID])
GO
ALTER TABLE [dbo].[tbl_TuDaHoc] CHECK CONSTRAINT [fk_iddicDH]
GO
ALTER TABLE [dbo].[tbl_TuDaHoc]  WITH CHECK ADD  CONSTRAINT [pk_idDaHoc] FOREIGN KEY([ID])
REFERENCES [dbo].[tbl_User] ([ID])
GO
ALTER TABLE [dbo].[tbl_TuDaHoc] CHECK CONSTRAINT [pk_idDaHoc]
GO
