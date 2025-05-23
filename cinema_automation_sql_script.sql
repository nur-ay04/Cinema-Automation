USE [Sinema]
GO
/****** Object:  Table [dbo].[TblBiletler]    Script Date: 20.04.2025 15:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblBiletler](
	[biletID] [smallint] IDENTITY(1,1) NOT NULL,
	[biletKodu] [char](10) NULL,
	[adSoyad] [nvarchar](100) NULL,
	[telNo] [varchar](50) NULL,
	[koltukNo] [nvarchar](50) NULL,
	[filmAdı] [nvarchar](100) NULL,
	[tarih] [nvarchar](20) NULL,
	[saat] [nvarchar](10) NULL,
	[salon] [nvarchar](10) NULL,
	[tur] [nvarchar](20) NULL,
	[islemSaati] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblFilmler]    Script Date: 20.04.2025 15:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblFilmler](
	[filmID] [smallint] IDENTITY(1,1) NOT NULL,
	[filmAdi] [nvarchar](50) NULL,
	[filmTurleri] [nvarchar](150) NULL,
	[filmOzellikleri] [nvarchar](100) NULL,
	[filmBicimleri] [nvarchar](50) NULL,
	[filmYonetmenleri] [nvarchar](max) NULL,
	[filmOyunculari] [nvarchar](max) NULL,
	[filmVizyonTarihi] [varchar](50) NULL,
	[filmPuani] [char](2) NULL,
	[filmAfisi] [nvarchar](max) NULL,
	[filmDetayi] [nvarchar](300) NULL,
	[filmDurum] [char](1) NULL,
 CONSTRAINT [PK_TblFilmler] PRIMARY KEY CLUSTERED 
(
	[filmID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKontrol]    Script Date: 20.04.2025 15:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKontrol](
	[filmAdi] [nchar](100) NULL,
	[tarih] [nvarchar](20) NULL,
	[saat] [nvarchar](20) NULL,
	[salonNo] [nvarchar](10) NULL,
	[koltuklar] [nvarchar](300) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKullanicilar]    Script Date: 20.04.2025 15:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKullanicilar](
	[KullaiciID] [smallint] IDENTITY(1,1) NOT NULL,
	[AD] [nvarchar](50) NULL,
	[KullaniciSifre] [nvarchar](50) NULL,
	[KullaniciFulName] [nvarchar](100) NULL,
 CONSTRAINT [PK_TblKullanicilar] PRIMARY KEY CLUSTERED 
(
	[KullaiciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblOyuncular]    Script Date: 20.04.2025 15:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOyuncular](
	[oyuncuID] [smallint] IDENTITY(1,1) NOT NULL,
	[oyuncuAdSoyad] [nvarchar](50) NULL,
	[oyuncuCinsiyet] [varchar](10) NULL,
	[oyuncuYas] [varchar](2) NULL,
	[oyuncuBio] [nchar](100) NULL,
	[oyuncuResim] [varchar](100) NULL,
 CONSTRAINT [PK_TblOyuncular] PRIMARY KEY CLUSTERED 
(
	[oyuncuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSalonlar]    Script Date: 20.04.2025 15:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSalonlar](
	[salonID] [smallint] IDENTITY(1,1) NOT NULL,
	[salonAd] [nvarchar](50) NULL,
	[salonKoltukSayisi] [varchar](3) NULL,
 CONSTRAINT [PK_TblSalonlar] PRIMARY KEY CLUSTERED 
(
	[salonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSecilenler]    Script Date: 20.04.2025 15:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSecilenler](
	[secilenKisi] [nchar](100) NULL,
	[secilenTur] [nchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblYonetmenler]    Script Date: 20.04.2025 15:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblYonetmenler](
	[yonetmenID] [smallint] IDENTITY(1,1) NOT NULL,
	[yonetmenAdSoyad] [nvarchar](50) NULL,
	[yonetmenCinsiyet] [varchar](50) NULL,
	[yonetmenYas] [char](2) NULL,
	[yonetmenBio] [nvarchar](350) NULL,
	[yonetmenResim] [varchar](100) NULL,
 CONSTRAINT [PK_TblYonetmenler] PRIMARY KEY CLUSTERED 
(
	[yonetmenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
