/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 07/04/2024 6:31:49 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_DISPENSELOG]    Script Date: 07/04/2024 6:31:49 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_DISPENSELOG](
	[DISPENSELOGID] [uniqueidentifier] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[Unit] [nvarchar](max) NULL,
	[Type] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TBL_DISPENSELOG] PRIMARY KEY CLUSTERED 
(
	[DISPENSELOGID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240405054939_MIGRATION', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240407095607_UPDATE', N'2.1.14-servicing-32113')
GO
INSERT [dbo].[TBL_DISPENSELOG] ([DISPENSELOGID], [Amount], [Unit], [Type], [CreatedDate]) VALUES (N'3ec29ac9-8b57-4d3c-e765-08dc56e92535', CAST(3.00 AS Decimal(18, 2)), N'grams', N'food', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TBL_DISPENSELOG] ([DISPENSELOGID], [Amount], [Unit], [Type], [CreatedDate]) VALUES (N'a3265f4d-df50-47c6-c582-08dc56e94a71', CAST(7.00 AS Decimal(18, 2)), N'grams', N'food', CAST(N'2024-04-07T17:58:35.4395260' AS DateTime2))
GO
USE [master]
GO
ALTER DATABASE [DOGDATA] SET  READ_WRITE 
GO
