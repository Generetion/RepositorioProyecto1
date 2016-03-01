Creación de base de datos
*********************************************************************************************************************
USE [Proyecto]
GO

/****** Object:  Table [dbo].[Article]    Script Date: 29/02/2016 22:38:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Article](
	[Electronic] [nchar](10) NOT NULL,
	[Room] [nchar](10) NOT NULL
) ON [PRIMARY]

GO
********************************************************************************************************************************
USE [Proyecto]
GO

/****** Object:  Table [dbo].[Article_Room]    Script Date: 29/02/2016 22:38:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Article_Room](
	[Room] [nchar](10) NOT NULL,
	[articles] [nchar](10) NULL
) ON [PRIMARY]

GO
********************************************************************************************************************************
USE [Proyecto]
GO

/****** Object:  Table [dbo].[Detail_Request]    Script Date: 29/02/2016 22:39:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Detail_Request](
	[Date] [nchar](10) NOT NULL,
	[Article] [nchar](10) NOT NULL
) ON [PRIMARY]

GO
********************************************************************************************************************************
USE [Proyecto]
GO

/****** Object:  Table [dbo].[Request]    Script Date: 29/02/2016 22:39:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Request](
	[Request] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
(
	[Request] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
********************************************************************************************************************************
USE [Proyecto]
GO

/****** Object:  Table [dbo].[Role]    Script Date: 29/02/2016 22:39:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Professor] [nchar](10) NOT NULL,
	[Student] [nchar](10) NOT NULL,
	[Admin] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
********************************************************************************************************************************
USE [Proyecto]
GO

/****** Object:  Table [dbo].[Room]    Script Date: 29/02/2016 22:40:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Room](
	[Keys] [nchar](10) NOT NULL,
	[Electronic] [nchar](10) NULL
) ON [PRIMARY]

GO
********************************************************************************************************************************
USE [Proyecto]
GO

/****** Object:  Table [dbo].[User_Role]    Script Date: 29/02/2016 22:40:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User_Role](
	[id_User] [int] NOT NULL,
	[id_Role] [int] NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[User_Role]  WITH CHECK ADD  CONSTRAINT [FK_User_Role_Role] FOREIGN KEY([id_Role])
REFERENCES [dbo].[Role] ([ID])
GO

ALTER TABLE [dbo].[User_Role] CHECK CONSTRAINT [FK_User_Role_Role]
GO

ALTER TABLE [dbo].[User_Role]  WITH CHECK ADD  CONSTRAINT [FK_User_Role_Users] FOREIGN KEY([id_User])
REFERENCES [dbo].[Users] ([ID])
GO

ALTER TABLE [dbo].[User_Role] CHECK CONSTRAINT [FK_User_Role_Users]
GO
********************************************************************************************************************************
USE [Proyecto]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 29/02/2016 22:41:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nchar](50) NOT NULL,
	[Password] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
********************************************************************************************************************************
