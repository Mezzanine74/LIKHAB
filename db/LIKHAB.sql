USE [master]
GO
/****** Object:  Database [LIHKAB_db]    Script Date: 22/02/2019 18:10:13 ******/
CREATE DATABASE [LIHKAB_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LIHKAB_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LIHKAB_db.mdf' , SIZE = 16384KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LIHKAB_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LIHKAB_db_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LIHKAB_db] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LIHKAB_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LIHKAB_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LIHKAB_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LIHKAB_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LIHKAB_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LIHKAB_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [LIHKAB_db] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LIHKAB_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LIHKAB_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LIHKAB_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LIHKAB_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LIHKAB_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LIHKAB_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LIHKAB_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LIHKAB_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LIHKAB_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LIHKAB_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LIHKAB_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LIHKAB_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LIHKAB_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LIHKAB_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LIHKAB_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LIHKAB_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LIHKAB_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LIHKAB_db] SET  MULTI_USER 
GO
ALTER DATABASE [LIHKAB_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LIHKAB_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LIHKAB_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LIHKAB_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LIHKAB_db] SET DELAYED_DURABILITY = DISABLED 
GO
USE [LIHKAB_db]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
	[Note] [nchar](10) NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[AdiSoyadi] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BankaBilgileri]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankaBilgileri](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Banka] [nvarchar](50) NOT NULL,
	[Iban] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BankaBilgileri] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmailKayitlari]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailKayitlari](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Kime] [nvarchar](1000) NULL,
	[Subject] [nvarchar](255) NULL,
	[Body] [nvarchar](max) NULL,
	[NeZaman] [datetime] NULL,
 CONSTRAINT [PK_EmailKayitlari] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ilce]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ilce](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Il] [int] NOT NULL,
	[Ilce] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Ilce] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ili]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ili](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Il] [nvarchar](100) NOT NULL,
	[IlKatsayisi] [numeric](15, 2) NOT NULL,
 CONSTRAINT [PK_Ili] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IsAsamalari]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IsAsamalari](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[IsId] [int] NOT NULL,
	[OnayaGidisZamani] [datetime] NULL,
	[Onaylanmis] [bit] NOT NULL CONSTRAINT [DF_IsAsamalari_Onaylanmis]  DEFAULT ((0)),
	[OnayZamani] [datetime] NULL,
	[Fatura] [bit] NOT NULL CONSTRAINT [DF_IsAsamalari_Fatura]  DEFAULT ((0)),
	[FaturaWhen] [datetime] NULL,
	[Olcum] [bit] NOT NULL CONSTRAINT [DF_IsAsamalari_Olcum]  DEFAULT ((0)),
	[OlcumWhen] [datetime] NULL,
	[Kontrol] [bit] NOT NULL CONSTRAINT [DF_IsAsamalari_Kontrol]  DEFAULT ((0)),
	[KontrolWhen] [datetime] NULL,
	[BeldEvrGeldi] [bit] NOT NULL CONSTRAINT [DF_IsAsamalari_BeldEvrGeldi]  DEFAULT ((0)),
	[BeldEvrGeldiWhen] [datetime] NULL,
	[BeldEvrGitti] [bit] NOT NULL CONSTRAINT [DF_IsAsamalari_BeldEvrGitti]  DEFAULT ((0)),
	[BeldEvrGittiWhen] [datetime] NULL,
	[KadEvrGeldi] [bit] NOT NULL CONSTRAINT [DF_IsAsamalari_KadEvrGeldi]  DEFAULT ((0)),
	[KadEvrGeldiWhen] [datetime] NULL,
	[KadEvrGitti] [bit] NOT NULL CONSTRAINT [DF_IsAsamalari_KadEvrGitti]  DEFAULT ((0)),
	[KadEvrGittiWhen] [datetime] NULL,
	[ProjeYapildi] [bit] NOT NULL CONSTRAINT [DF_IsAsamalari_ProjeYapildi]  DEFAULT ((0)),
	[ProjeYapildiWhen] [datetime] NULL,
	[OdemeAlindi] [bit] NOT NULL CONSTRAINT [DF_IsAsamalari_OdemeAlindi]  DEFAULT ((0)),
	[OdemeAlindiWhen] [datetime] NULL,
	[IsKapandi] [bit] NOT NULL CONSTRAINT [DF_IsAsamalari_IsKapandi]  DEFAULT ((0)),
	[IsKapandiWhen] [datetime] NULL,
	[MusteriyiBilgilendir] [bit] NOT NULL CONSTRAINT [DF_IsAsamalari_MusteriyiBilgilendir]  DEFAULT ((0)),
	[MusteriyiBilgilendirWhen] [datetime] NULL,
	[WhoCreated] [nvarchar](50) NULL,
	[WhoUpdated] [nvarchar](50) NULL,
	[WhenCreated] [datetime] NULL,
	[WhenUpdated] [datetime] NULL,
 CONSTRAINT [PK_IsAsamalari] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IsBilgileri]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IsBilgileri](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Is] [int] NOT NULL,
	[Yili] [int] NOT NULL,
	[FenKayitNo] [int] NOT NULL,
	[FenKayitTarihi] [smalldatetime] NULL,
	[PaftaNo] [nvarchar](100) NULL,
	[AdaNo] [nvarchar](100) NULL,
	[ParselNo] [nvarchar](100) NULL,
	[Takipci] [nvarchar](100) NULL,
	[Maliki] [nvarchar](200) NOT NULL,
	[Aciklama] [nvarchar](200) NOT NULL,
	[Cinsi] [nvarchar](100) NOT NULL,
	[Ilgilenen] [nvarchar](200) NULL,
	[FaturaNo] [nvarchar](200) NULL,
	[WhenUpdated] [datetime] NULL,
	[WhoCreated] [nvarchar](50) NULL,
	[WhoUpdated] [nvarchar](50) NULL,
	[WhenCreated] [datetime] NULL,
 CONSTRAINT [PK_IsBilgileri] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IsinCinsi]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IsinCinsi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Tanim] [nvarchar](256) NOT NULL,
	[FenKayitNoSifirMi] [bit] NOT NULL CONSTRAINT [DF_IsinCinsi_FenKayitNoSifir]  DEFAULT ((0)),
 CONSTRAINT [PK_IsinCinsi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Isler]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Isler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[IsinCinsi] [int] NOT NULL,
	[Koyu_Mahallesi] [int] NOT NULL,
	[IsinTuru] [int] NULL,
	[KadastroyaAsliGibiVerilecek] [bit] NULL,
	[Stopaj] [bit] NULL,
	[Tevkifatli] [bit] NULL,
	[KentselDonusum] [bit] NULL,
	[YolKilometre] [numeric](10, 2) NULL,
	[YolUcretiniElleGir] [bit] NULL,
	[Musteri] [int] NOT NULL,
	[MusteriTemsilDurumu] [nvarchar](100) NULL,
	[WhoCreated] [nvarchar](50) NULL,
	[WhoUpdated] [nvarchar](50) NULL,
	[WhenCreated] [datetime] NULL,
	[WhenUpdated] [datetime] NULL,
 CONSTRAINT [PK_IS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IsParametreleri]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IsParametreleri](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Is] [int] NOT NULL,
	[YuzOlcumu] [numeric](12, 2) NULL,
	[AplikasyonKrokisiSayisi] [int] NULL,
	[ParselSayisi] [int] NULL,
	[NoktaSayisi] [int] NULL,
	[ParselAlani] [numeric](12, 2) NULL,
	[BinaTabanAlani] [numeric](12, 2) NULL,
	[InsaatAlani] [numeric](12, 2) NULL,
	[BagimsizBolumSayisi] [int] NULL,
	[BinaSayisi] [int] NULL,
	[PlanOrnegi] [int] NULL,
	[KatSayisi] [int] NULL,
	[B_Bolum] [int] NULL,
	[OdaKatsayi] [numeric](12, 2) NULL,
	[AraziyeGidilecekmi] [bit] NULL,
	[AyniKisiyeAit] [bit] NULL,
	[OdaBirimFiyatlariniKullan] [bit] NULL,
	[Yuzde50CarpanUygula] [bit] NULL,
	[YolUcreti] [numeric](12, 2) NULL,
	[WhenUpdated] [datetime] NULL,
	[WhoCreated] [nvarchar](50) NULL,
	[WhoUpdated] [nvarchar](50) NULL,
	[WhenCreated] [datetime] NULL,
 CONSTRAINT [PK_IsParametreleri] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IsTurleri]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IsTurleri](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Tanim] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_IsTurleri] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Koy_Mahalle]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Koy_Mahalle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ilce] [int] NOT NULL,
	[Koy_Mahalle] [nvarchar](100) NOT NULL,
	[YolKilometre] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_Koy] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LisansliBuroBilgileri]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LisansliBuroBilgileri](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[KimlikNo] [nvarchar](50) NULL,
	[AdiSoyadi] [nvarchar](200) NULL,
	[Unvani] [nvarchar](200) NULL,
	[LisansliBuroNo] [nvarchar](50) NULL,
	[LisansliBelgeNo] [nvarchar](50) NULL,
	[OdaSicilNo] [nvarchar](50) NULL,
	[VergiNo] [nvarchar](50) NULL,
	[Ili] [nvarchar](100) NULL,
	[Adresi] [nvarchar](256) NULL,
	[Tel] [nvarchar](50) NULL,
	[Faks] [nvarchar](50) NULL,
	[Eposta] [nvarchar](50) NULL,
	[Websayfasi] [nvarchar](50) NULL,
	[VergiDairesi] [nvarchar](50) NULL,
	[Ilcesi] [nvarchar](100) NULL,
 CONSTRAINT [PK_LisansliBuroBilgileri] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[AdiSoyadi] [nvarchar](200) NOT NULL,
	[TCkimlik_VergiNo] [nvarchar](50) NOT NULL,
	[VergiDairesi] [nvarchar](50) NULL,
	[Telefon1] [nvarchar](50) NULL,
	[Telefon2] [nvarchar](50) NULL,
	[Faks] [nvarchar](50) NULL,
	[Eposta] [nvarchar](50) NULL,
	[TemsilDurumu] [int] NOT NULL,
	[Adress] [nvarchar](256) NULL,
	[WhenUpdated] [datetime] NULL,
	[WhoCreated] [nvarchar](50) NULL,
	[WhoUpdated] [nvarchar](50) NULL,
	[WhenCreated] [datetime] NULL,
 CONSTRAINT [PK_Musteri] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MusteriTemsilDurumu]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriTemsilDurumu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Tanim] [nvarchar](100) NOT NULL,
	[StopajdaGoster] [bit] NOT NULL,
	[IsBilgilerindeZorunluTip] [bit] NOT NULL,
 CONSTRAINT [PK_MusteriTemsilDurumu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Onaylar]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Onaylar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[OnayKodu] [int] NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[OnaylananSatirId] [int] NOT NULL,
	[OnayZamani] [datetime] NULL,
 CONSTRAINT [PK_Onaylar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OnayTuru]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OnayTuru](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[OnayKodu] [int] NOT NULL,
	[Tanim] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_OnayTuru_1] PRIMARY KEY CLUSTERED 
(
	[OnayKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OnayTuruOnayVerecekKisi]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OnayTuruOnayVerecekKisi](
	[OnayKodu] [int] NOT NULL,
	[OnayVerecekUserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_OnayTuruOnayVerecekKisi_1] PRIMARY KEY CLUSTERED 
(
	[OnayKodu] ASC,
	[OnayVerecekUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OnayVerecekKisi]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OnayVerecekKisi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_OnayVerecekKisi_1] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Randevu]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Randevu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Is] [int] NOT NULL,
	[Title] [nvarchar](200) NULL,
	[Description] [nvarchar](max) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Location] [nvarchar](200) NULL,
	[AllDay] [bit] NULL,
	[Type] [int] NULL,
	[Subject] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[Label] [int] NULL,
	[WhenUpdated] [datetime] NULL,
	[WhoCreated] [nvarchar](50) NULL,
	[WhoUpdated] [nvarchar](50) NULL,
	[WhenCreated] [datetime] NULL,
 CONSTRAINT [PK_Randevu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RandevuIlkHali]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RandevuIlkHali](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Is] [int] NOT NULL,
	[Title] [nvarchar](200) NULL,
	[Description] [nvarchar](max) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Location] [nvarchar](200) NULL,
	[AllDay] [bit] NULL,
	[Type] [int] NULL,
	[Subject] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[Label] [int] NULL,
	[VerilisZamani] [datetime] NULL,
	[AdiSoyadi] [nvarchar](256) NULL,
	[WhenUpdated] [datetime] NULL,
	[WhoCreated] [nvarchar](50) NULL,
	[WhoUpdated] [nvarchar](50) NULL,
	[WhenCreated] [datetime] NULL,
 CONSTRAINT [PK_RandevuIlkVerilen] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UcretAyarlari]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UcretAyarlari](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[IsDetayi] [nvarchar](256) NOT NULL,
	[UcretKodu] [nvarchar](50) NOT NULL,
	[Aciklama] [nvarchar](256) NOT NULL,
	[Kullan] [bit] NOT NULL CONSTRAINT [DF_UcretAyarlari_Kullan]  DEFAULT ((0)),
	[Parametre] [numeric](18, 6) NOT NULL,
 CONSTRAINT [PK_UcretAyarlari] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UcretDokumu]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UcretDokumu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Is] [int] NULL,
	[YolUcreti] [numeric](12, 2) NULL,
	[DenetimUcreti] [numeric](12, 2) NULL,
	[DamgaVergisi] [numeric](12, 2) NULL,
	[BelgeUcreti] [numeric](12, 2) NULL,
	[KontrolUcreti] [numeric](12, 2) NULL,
	[Toplam] [numeric](12, 2) NULL,
	[ToplamBrutUcret] [numeric](12, 2) NULL,
	[Stopaj20percent] [numeric](12, 2) NULL,
	[KesintilerToplami] [numeric](12, 2) NULL,
	[GenelToplam] [numeric](12, 2) NULL,
	[KDV18percent] [numeric](12, 2) NULL,
	[TevkifEdilenKDV] [numeric](12, 2) NULL,
	[TahsilEdilenKDV] [numeric](12, 2) NULL,
	[NetAlinan] [numeric](12, 2) NULL,
	[AlinacakGenelToplam] [numeric](12, 2) NULL,
	[WhenUpdated] [datetime] NULL,
	[WhoCreated] [nvarchar](50) NULL,
	[WhoUpdated] [nvarchar](50) NULL,
	[WhenCreated] [datetime] NULL,
 CONSTRAINT [PK_UcretDokumu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Yillar]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yillar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Yil] [int] NOT NULL,
 CONSTRAINT [PK_Yillar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[ViewRandevuOnayDurumu]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [dbo].[ViewRandevuOnayDurumu]
AS

SELECT ROW_NUMBER() OVER(ORDER BY Source.RandevuId ASC) AS UniqueId, RandevuId, id as OnayId, OnayKodu, OnayVerecekUserId, UserName, AdiSoyadi, OnayZamani
FROM (
-- ONAYLANAN
SELECT     RandevuOnayMatriksi.RandevuId, RandevuOnayMatriksi.OnayKodu, RandevuOnayMatriksi.OnayVerecekUserId, Onaylar.OnayZamani, 
                      Onaylar.id
FROM         (SELECT     Randevu.id AS RandevuId, OnayTuruOnayVerecekKisi.OnayKodu, OnayTuruOnayVerecekKisi.OnayVerecekUserId
                       FROM          OnayTuruOnayVerecekKisi CROSS JOIN
                                              Randevu) AS RandevuOnayMatriksi INNER JOIN
                      Onaylar ON RandevuOnayMatriksi.RandevuId = Onaylar.OnaylananSatirId AND RandevuOnayMatriksi.OnayKodu = Onaylar.OnayKodu AND 
                      RandevuOnayMatriksi.OnayVerecekUserId = Onaylar.UserId

UNION ALL

-- ONAYLANMAYAN
SELECT     RandevuOnayMatriksi.RandevuId, RandevuOnayMatriksi.OnayKodu, RandevuOnayMatriksi.OnayVerecekUserId, NULL AS OnayZamani, NULL AS id
FROM         (SELECT     Randevu.id AS RandevuId, OnayTuruOnayVerecekKisi.OnayKodu, OnayTuruOnayVerecekKisi.OnayVerecekUserId
                       FROM          OnayTuruOnayVerecekKisi CROSS JOIN
                                              Randevu) AS RandevuOnayMatriksi LEFT OUTER JOIN
                      Onaylar ON RandevuOnayMatriksi.RandevuId = Onaylar.OnaylananSatirId AND RandevuOnayMatriksi.OnayKodu = Onaylar.OnayKodu AND 
                      RandevuOnayMatriksi.OnayVerecekUserId = Onaylar.UserId
WHERE     (Onaylar.id IS NULL)
) AS Source INNER JOIN dbo.AspNetUsers U ON Source.OnayVerecekUserId = U.Id 

GO
/****** Object:  View [dbo].[ViewRandevuGenelOnayDurumu]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewRandevuGenelOnayDurumu]
AS
Select Randevu.id AS RandevuId, 
RandevuGerekenOnaySayisiOuter.GerekenOnaySayisi, 
RandevuOnaylananSayiOuter.OnaySayisi  ,
CASE WHEN RandevuGerekenOnaySayisiOuter.GerekenOnaySayisi - RandevuOnaylananSayiOuter.OnaySayisi = 0 THEN
 1
ELSE
0
END AS Onaylanmis

FROM Randevu

INNER JOIN 

(
	SELECT * FROM (
	SELECT     RandevuId, COUNT(UniqueId) AS GerekenOnaySayisi
	FROM         ViewRandevuOnayDurumu
	GROUP BY RandevuId
	) AS RandevuGerekenOnaySayisi
) AS RandevuGerekenOnaySayisiOuter ON Randevu.id = RandevuGerekenOnaySayisiOuter.RandevuId

INNER JOIN 

(
SELECT     Randevu.id, ISNULL(RandevuOnaylananSayisi.OnaySayisi, 0) AS OnaySayisi
FROM         Randevu LEFT OUTER JOIN
                          (SELECT     RandevuId, COUNT(UniqueId) AS OnaySayisi
                            FROM          ViewRandevuOnayDurumu
                            WHERE      (OnayId IS NOT NULL)
                            GROUP BY RandevuId) AS RandevuOnaylananSayisi ON Randevu.id = RandevuOnaylananSayisi.RandevuId
) AS RandevuOnaylananSayiOuter ON Randevu.id = RandevuOnaylananSayiOuter.id
GO
/****** Object:  View [dbo].[View_IsAsamalari]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_IsAsamalari]
AS
SELECT     ISNULL(NEWID(), N'918E809E-EA7A-44B5-B230-776C42594D91') AS UniqueId, dbo.IsAsamalari.id, dbo.IsAsamalari.IsId, dbo.IsAsamalari.OnayaGidisZamani, 
                      dbo.IsAsamalari.Onaylanmis, dbo.IsAsamalari.OnayZamani, CONVERT(bit, ISNULL(dbo.Randevu.id, 0)) AS Randevu, dbo.Randevu.StartDate AS RandevuWhen, 
                      dbo.IsAsamalari.Fatura, dbo.IsAsamalari.FaturaWhen, dbo.IsAsamalari.Olcum, dbo.IsAsamalari.OlcumWhen, dbo.IsAsamalari.Kontrol, dbo.IsAsamalari.KontrolWhen, 
                      dbo.IsAsamalari.BeldEvrGeldi, dbo.IsAsamalari.BeldEvrGeldiWhen, dbo.IsAsamalari.BeldEvrGitti, dbo.IsAsamalari.BeldEvrGittiWhen, dbo.IsAsamalari.KadEvrGeldi, 
                      dbo.IsAsamalari.KadEvrGeldiWhen, dbo.IsAsamalari.KadEvrGitti, dbo.IsAsamalari.KadEvrGittiWhen, dbo.IsAsamalari.ProjeYapildi, 
                      dbo.IsAsamalari.ProjeYapildiWhen, dbo.IsAsamalari.OdemeAlindi, dbo.IsAsamalari.OdemeAlindiWhen, dbo.IsAsamalari.IsKapandi, dbo.IsAsamalari.IsKapandiWhen, 
                      dbo.IsAsamalari.MusteriyiBilgilendir, dbo.IsAsamalari.MusteriyiBilgilendirWhen, dbo.IsAsamalari.WhoCreated, dbo.IsAsamalari.WhoUpdated, 
                      dbo.IsAsamalari.WhenCreated, dbo.IsAsamalari.WhenUpdated
FROM         dbo.IsAsamalari INNER JOIN
                      dbo.Isler ON dbo.IsAsamalari.IsId = dbo.Isler.id LEFT OUTER JOIN
                      dbo.Randevu ON dbo.Isler.id = dbo.Randevu.[Is]

GO
/****** Object:  View [dbo].[View_RaporSozlesme]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[View_RaporSozlesme]

AS

SELECT  Isler.id AS IsId, Ili.Il AS IlinAdi, Ilce.Ilce, Koy_Mahalle.Koy_Mahalle, 
					  Musteri.AdiSoyadi AS IsSahibi, 
					  RTRIM(Musteri.AdiSoyadi) + N'/' + ISNULL(RTRIM(Isler.MusteriTemsilDurumu), N'-') AS IsSahibiVeUnvani, 
					  Isler.MusteriTemsilDurumu AS MusteriTemsilDurumuIsler, 
                      IsinCinsi.Tanim AS IsinCinsiTanim, ISNULL(CONVERT(nvarchar(MAX), Format( Randevu.StartDate ,'dd/MM/yyyy HH:mm:ss','tr-TR' ), 21), N'-') AS RandevuZamani, 

					  Format( UcretDokumu.ToplamBrutUcret ,'N','en-US') AS Toplam, 
					  Format( UcretDokumu.KDV18percent ,'N','en-US') AS KDV, 
					  Format( ISNULL(UcretDokumu.ToplamBrutUcret,0) + ISNULL(UcretDokumu.KDV18percent,0) ,'N','en-US') AS GenelToplam, 

					  IsBilgileri.Maliki AS MalikiIBAdiSoyadi, 

                      Musteri.TCkimlik_VergiNo AS IsSahibiTCkimlik_VergiNo, 
					  Musteri.Telefon1 AS IsSahibiTelefon1, 
					  Musteri.Adress AS IsSahibiAdress, 

                      LisansliBuroBilgileri.AdiSoyadi AS LisansSahibi_AdiSoyadi, LisansliBuroBilgileri.LisansliBuroNo, LisansliBuroBilgileri.LisansliBelgeNo, 
                      LisansliBuroBilgileri.OdaSicilNo, LisansliBuroBilgileri.Ili AS LisansSahibiIli, ISNULL(RTRIM(IsBilgileri.AdaNo),N'') + N'/' + ISNULL(RTRIM(IsBilgileri.ParselNo), N'') as AdaParselNo, 
					  IsBilgileri.PaftaNo,

					  ISNULL(convert(nvarchar(MAX), IsBilgileri.FenKayitTarihi, 104), N'') + N'/' + ISNULL(RTRIM(Convert(nvarChar(20), IsBilgileri.FenKayitNo)), N'') AS FenKayitTarihiNo, 
					  ISNULL(convert(nvarchar(MAX), IsBilgileri.FenKayitTarihi, 104), N'') AS FenKayitTarihi,
					  ISNULL(Format( IsBilgileri.FenKayitTarihi - 6 ,'dd','tr-TR' ), N'?') AS FenKayitTarihiGUN,
					  ISNULL(Format( IsBilgileri.FenKayitTarihi - 6 ,'MM','tr-TR' ), N'?') AS FenKayitTarihiAY,
					  ISNULL(Format( IsBilgileri.FenKayitTarihi - 6 ,'yy','tr-TR' ), N'?') AS FenKayitTarihiYIL,


                      Format( IsParametreleri.YuzOlcumu ,'N','en-US') + N' m2' AS Yuzolcumu , Isler.IsinCinsi AS IsinCinsiId
FROM         IsBilgileri INNER JOIN
                      Isler ON IsBilgileri.[Is] = Isler.id INNER JOIN
                      Koy_Mahalle ON Isler.Koyu_Mahallesi = Koy_Mahalle.id INNER JOIN
                      Ilce ON Koy_Mahalle.Ilce = Ilce.id INNER JOIN
                      Ili ON Ilce.Il = Ili.id INNER JOIN
                      Musteri ON Isler.Musteri = Musteri.id INNER JOIN
                      IsinCinsi ON Isler.IsinCinsi = IsinCinsi.id INNER JOIN
                      UcretDokumu ON Isler.id = UcretDokumu.[Is] INNER JOIN
                      IsParametreleri ON Isler.id = IsParametreleri.[Is] LEFT OUTER JOIN
                      Randevu ON Isler.id = Randevu.[Is] CROSS JOIN
                      LisansliBuroBilgileri


GO
/****** Object:  View [dbo].[ViewFenKayitSonrakiNumara]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[ViewFenKayitSonrakiNumara]
	   AS
Select UniqueId, IlcelerYillar.Yil, IlcelerYillar.IlceId, ISNULL(TableMaxFenKaytNo.MaxFenKayitNo, 0) + 1 AS VerilecekFenKayitNo
 FROM ( Select ISNULL(NEWID(), N'918E809E-EA7A-44B5-B230-776C42594D91') AS UniqueId, Yillar.Yil, Ilce.id as IlceId  from Ilce cross join dbo.Yillar ) IlcelerYillar
LEFT OUTER JOIN (
	   select I.Yil, I.IlceId, MAX(Table_IsBilgileri.FenKayitNo) AS MaxFenKayitNo 
	   from (Select Yillar.Yil, Ilce.id as IlceId  from Ilce cross join dbo.Yillar) as I
	   inner join 
	   (
		Select Ilce.id AS IlceId, Yili, FenKayitNo 
		from Isler 
		inner join Koy_Mahalle on Isler.Koyu_Mahallesi = Koy_Mahalle.id 
		inner join Ilce on Ilce.id = Koy_Mahalle.Ilce 
		inner join IsBilgileri on IsBilgileri.[Is] = Isler.id
	   ) as Table_IsBilgileri
	   
	    on I.IlceId = Table_IsBilgileri.IlceId and I.Yil = Table_IsBilgileri.Yili
		group by I.IlceId, I.Yil
)
AS TableMaxFenKaytNo ON IlcelerYillar.IlceId = TableMaxFenKaytNo.IlceId AND IlcelerYillar.Yil = TableMaxFenKaytNo.Yil

GO
/****** Object:  View [dbo].[ViewIsinKucukDetayi]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewIsinKucukDetayi]
AS
SELECT     ISNULL(NEWID(), N'918E809E-EA7A-44B5-B230-776C42594D91') AS UniqueId, dbo.Isler.id, dbo.IsinCinsi.Tanim AS IsinCinsi, dbo.Musteri.AdiSoyadi, 
                      dbo.Isler.MusteriTemsilDurumu, dbo.UcretDokumu.AlinacakGenelToplam
FROM         dbo.Isler INNER JOIN
                      dbo.IsinCinsi ON dbo.Isler.IsinCinsi = dbo.IsinCinsi.id INNER JOIN
                      dbo.Musteri ON dbo.Isler.Musteri = dbo.Musteri.id INNER JOIN
                      dbo.UcretDokumu ON dbo.Isler.id = dbo.UcretDokumu.[Is]

GO
/****** Object:  View [dbo].[ViewRandevularIsBilgisiOlmayan]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[ViewRandevularIsBilgisiOlmayan]
AS

SELECT ISNULL(NEWID(), N'918E809E-EA7A-44B5-B230-776C42594D91') AS UniqueId, Randevu.id
FROM         Isler INNER JOIN
                      Randevu ON Isler.id = Randevu.[Is] LEFT OUTER JOIN
                      IsBilgileri ON Isler.id = IsBilgileri.[Is]
WHERE     (IsBilgileri.[Is] IS NULL)
GO
/****** Object:  View [dbo].[ViewRandevuTalebiReportDetail]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewRandevuTalebiReportDetail]
AS
SELECT     ISNULL(NEWID(), N'918E809E-EA7A-44B5-B230-776C42594D91') AS UniqueId, dbo.IsinCinsi.Tanim, dbo.Musteri.AdiSoyadi, dbo.Ili.Il, dbo.Ilce.Ilce, 
                      dbo.Koy_Mahalle.Koy_Mahalle, dbo.Randevu.Location, dbo.Randevu.StartDate, dbo.Randevu.EndDate, dbo.Randevu.Description, dbo.Isler.id AS isId, 
                      ISNULL(dbo.Randevu.id, 0) AS RandevuId, dbo.Isler.WhoCreated AS IsiOlusturan, dbo.Randevu.WhoCreated AS RandevuyuVeren
FROM         dbo.Ilce INNER JOIN
                      dbo.Ili ON dbo.Ilce.Il = dbo.Ili.id INNER JOIN
                      dbo.Isler INNER JOIN
                      dbo.Musteri ON dbo.Isler.Musteri = dbo.Musteri.id INNER JOIN
                      dbo.IsinCinsi ON dbo.Isler.IsinCinsi = dbo.IsinCinsi.id INNER JOIN
                      dbo.Koy_Mahalle ON dbo.Isler.Koyu_Mahallesi = dbo.Koy_Mahalle.id ON dbo.Ilce.id = dbo.Koy_Mahalle.Ilce LEFT OUTER JOIN
                      dbo.Randevu ON dbo.Isler.id = dbo.Randevu.[Is]

GO
/****** Object:  View [dbo].[ViewTeslimSenedi]    Script Date: 22/02/2019 18:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewTeslimSenedi]
AS

SELECT dbo.Isler.id as isId, N'Teknik Bilgi Belge' AS Cinsi,  Koy_Mahalle.Koy_Mahalle, IsBilgileri.PaftaNo, IsBilgileri.AdaNo, IsBilgileri.ParselNo, 
	Format( IsParametreleri.YuzOlcumu ,'N','en-US') AS YuzOlcumu, IsinCinsi.Tanim, 
	Format( IsBilgileri.FenKayitTarihi ,'dd/MM/yyyy','tr-TR' ) AS FenKayitTarihi , 
	ISNULL(Format( IsBilgileri.FenKayitTarihi - 6 ,'dd','tr-TR' ), N'?') AS FenKayitTarihiGUN,
	ISNULL(Format( IsBilgileri.FenKayitTarihi - 6 ,'MM','tr-TR' ), N'?') AS FenKayitTarihiAY,
	ISNULL(Format( IsBilgileri.FenKayitTarihi - 6 ,'yy','tr-TR' ), N'?') AS FenKayitTarihiYIL,
	LisansliBuroBilgileri.AdiSoyadi AS LisansliBuroSahibi, LisansliBuroBilgileri.Unvani AS LisansliBuroSahibiUnvani,
	Musteri.AdiSoyadi AS isSahibi, 
	Format( UcretDokumu.GenelToplam ,'N','en-US') + N' × ' + Format( BelgeUcretKatsayisi.Parametre ,'N','en-US') AS BirimFiyati,
	Format( UcretDokumu.GenelToplam * BelgeUcretKatsayisi.Parametre ,'N','en-US') AS ToplamFiyat
FROM         Isler INNER JOIN
                      Koy_Mahalle ON Isler.Koyu_Mahallesi = Koy_Mahalle.id INNER JOIN
                      IsBilgileri ON Isler.id = IsBilgileri.[Is] INNER JOIN
                      IsParametreleri ON Isler.id = IsParametreleri.[Is] INNER JOIN
                      IsinCinsi ON Isler.IsinCinsi = IsinCinsi.id INNER JOIN
                      Musteri ON Isler.Musteri = Musteri.id INNER JOIN
                      UcretDokumu ON Isler.id = UcretDokumu.[Is] CROSS JOIN
                      LisansliBuroBilgileri CROSS JOIN
					  (SELECT [Parametre] FROM [dbo].[UcretAyarlari] WHERE UcretKodu = N'ucrt_20_05') BelgeUcretKatsayisi



GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 22/02/2019 18:10:13 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 22/02/2019 18:10:13 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 22/02/2019 18:10:13 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_RoleId]    Script Date: 22/02/2019 18:10:13 ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 22/02/2019 18:10:13 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 22/02/2019 18:10:13 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_IsAsamalari]    Script Date: 22/02/2019 18:10:13 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_IsAsamalari] ON [dbo].[IsAsamalari]
(
	[IsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_IsBilgileri]    Script Date: 22/02/2019 18:10:13 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_IsBilgileri] ON [dbo].[IsBilgileri]
(
	[Is] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_IsParametreleri]    Script Date: 22/02/2019 18:10:13 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_IsParametreleri] ON [dbo].[IsParametreleri]
(
	[Is] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Onaylar]    Script Date: 22/02/2019 18:10:13 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Onaylar] ON [dbo].[Onaylar]
(
	[OnayKodu] ASC,
	[OnaylananSatirId] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OnayTuru]    Script Date: 22/02/2019 18:10:13 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_OnayTuru] ON [dbo].[OnayTuru]
(
	[OnayKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_OnayTuruOnayVerecekKisi]    Script Date: 22/02/2019 18:10:13 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_OnayTuruOnayVerecekKisi] ON [dbo].[OnayTuruOnayVerecekKisi]
(
	[OnayKodu] ASC,
	[OnayVerecekUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_OnayVerecekKisi]    Script Date: 22/02/2019 18:10:13 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_OnayVerecekKisi] ON [dbo].[OnayVerecekKisi]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Randevu]    Script Date: 22/02/2019 18:10:13 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Randevu] ON [dbo].[Randevu]
(
	[Is] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UcretAyarlari]    Script Date: 22/02/2019 18:10:13 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_UcretAyarlari] ON [dbo].[UcretAyarlari]
(
	[UcretKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UcretDokumu]    Script Date: 22/02/2019 18:10:13 ******/
CREATE NONCLUSTERED INDEX [IX_UcretDokumu] ON [dbo].[UcretDokumu]
(
	[Is] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Yillar]    Script Date: 22/02/2019 18:10:13 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Yillar] ON [dbo].[Yillar]
(
	[Yil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Ilce]  WITH CHECK ADD  CONSTRAINT [FK_Ilce_Ili] FOREIGN KEY([Il])
REFERENCES [dbo].[Ili] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Ilce] CHECK CONSTRAINT [FK_Ilce_Ili]
GO
ALTER TABLE [dbo].[IsAsamalari]  WITH CHECK ADD  CONSTRAINT [FK_IsAsamalari_Isler] FOREIGN KEY([IsId])
REFERENCES [dbo].[Isler] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[IsAsamalari] CHECK CONSTRAINT [FK_IsAsamalari_Isler]
GO
ALTER TABLE [dbo].[IsBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_IsBilgileri_Is] FOREIGN KEY([Is])
REFERENCES [dbo].[Isler] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[IsBilgileri] CHECK CONSTRAINT [FK_IsBilgileri_Is]
GO
ALTER TABLE [dbo].[Isler]  WITH CHECK ADD  CONSTRAINT [FK_Is_IsinCinsi] FOREIGN KEY([IsinCinsi])
REFERENCES [dbo].[IsinCinsi] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Isler] CHECK CONSTRAINT [FK_Is_IsinCinsi]
GO
ALTER TABLE [dbo].[Isler]  WITH CHECK ADD  CONSTRAINT [FK_Is_IsTurleri] FOREIGN KEY([IsinTuru])
REFERENCES [dbo].[IsTurleri] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Isler] CHECK CONSTRAINT [FK_Is_IsTurleri]
GO
ALTER TABLE [dbo].[Isler]  WITH CHECK ADD  CONSTRAINT [FK_Is_Koy_Mahalle] FOREIGN KEY([Koyu_Mahallesi])
REFERENCES [dbo].[Koy_Mahalle] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Isler] CHECK CONSTRAINT [FK_Is_Koy_Mahalle]
GO
ALTER TABLE [dbo].[Isler]  WITH CHECK ADD  CONSTRAINT [FK_Is_Musteri] FOREIGN KEY([Musteri])
REFERENCES [dbo].[Musteri] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Isler] CHECK CONSTRAINT [FK_Is_Musteri]
GO
ALTER TABLE [dbo].[IsParametreleri]  WITH CHECK ADD  CONSTRAINT [FK_IsParametreleri_Isler] FOREIGN KEY([Is])
REFERENCES [dbo].[Isler] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[IsParametreleri] CHECK CONSTRAINT [FK_IsParametreleri_Isler]
GO
ALTER TABLE [dbo].[Koy_Mahalle]  WITH CHECK ADD  CONSTRAINT [FK_Koy_Mahalle_Ilce] FOREIGN KEY([Ilce])
REFERENCES [dbo].[Ilce] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Koy_Mahalle] CHECK CONSTRAINT [FK_Koy_Mahalle_Ilce]
GO
ALTER TABLE [dbo].[Musteri]  WITH CHECK ADD  CONSTRAINT [FK_Musteri_MusteriTemsilDurumu] FOREIGN KEY([TemsilDurumu])
REFERENCES [dbo].[MusteriTemsilDurumu] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Musteri] CHECK CONSTRAINT [FK_Musteri_MusteriTemsilDurumu]
GO
ALTER TABLE [dbo].[Onaylar]  WITH CHECK ADD  CONSTRAINT [FK_Onaylar_OnayTuruOnayVerecekKisi] FOREIGN KEY([OnayKodu], [UserId])
REFERENCES [dbo].[OnayTuruOnayVerecekKisi] ([OnayKodu], [OnayVerecekUserId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Onaylar] CHECK CONSTRAINT [FK_Onaylar_OnayTuruOnayVerecekKisi]
GO
ALTER TABLE [dbo].[OnayTuruOnayVerecekKisi]  WITH CHECK ADD  CONSTRAINT [FK_OnayTuruOnayVerecekKisi_OnayTuru] FOREIGN KEY([OnayKodu])
REFERENCES [dbo].[OnayTuru] ([OnayKodu])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[OnayTuruOnayVerecekKisi] CHECK CONSTRAINT [FK_OnayTuruOnayVerecekKisi_OnayTuru]
GO
ALTER TABLE [dbo].[OnayTuruOnayVerecekKisi]  WITH CHECK ADD  CONSTRAINT [FK_OnayTuruOnayVerecekKisi_OnayVerecekKisi] FOREIGN KEY([OnayVerecekUserId])
REFERENCES [dbo].[OnayVerecekKisi] ([UserId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[OnayTuruOnayVerecekKisi] CHECK CONSTRAINT [FK_OnayTuruOnayVerecekKisi_OnayVerecekKisi]
GO
ALTER TABLE [dbo].[OnayVerecekKisi]  WITH CHECK ADD  CONSTRAINT [FK_OnayVerecekKisi_AspNetUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[OnayVerecekKisi] CHECK CONSTRAINT [FK_OnayVerecekKisi_AspNetUsers]
GO
ALTER TABLE [dbo].[Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Randevu_Isler] FOREIGN KEY([Is])
REFERENCES [dbo].[Isler] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Randevu] CHECK CONSTRAINT [FK_Randevu_Isler]
GO
ALTER TABLE [dbo].[UcretDokumu]  WITH CHECK ADD  CONSTRAINT [FK_UcretDokumu_Isler] FOREIGN KEY([Is])
REFERENCES [dbo].[Isler] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UcretDokumu] CHECK CONSTRAINT [FK_UcretDokumu_Isler]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[49] 4[32] 2[6] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "IsAsamalari"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 418
               Right = 206
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "Isler"
            Begin Extent = 
               Top = 38
               Left = 340
               Bottom = 146
               Right = 550
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Randevu"
            Begin Extent = 
               Top = 71
               Left = 790
               Bottom = 367
               Right = 941
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 33
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 4065
 ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_IsAsamalari'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'        Alias = 1695
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_IsAsamalari'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_IsAsamalari'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Isler"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 173
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "IsinCinsi"
            Begin Extent = 
               Top = 146
               Left = 757
               Bottom = 264
               Right = 908
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Musteri"
            Begin Extent = 
               Top = 169
               Left = 341
               Bottom = 322
               Right = 551
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "UcretDokumu"
            Begin Extent = 
               Top = 6
               Left = 673
               Bottom = 136
               Right = 853
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 3090
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2310
         Alias = 1320
         Table = 1680
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      E' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewIsinKucukDetayi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'nd
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewIsinKucukDetayi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewIsinKucukDetayi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[44] 4[21] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Ilce"
            Begin Extent = 
               Top = 48
               Left = 1043
               Bottom = 141
               Right = 1194
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ili"
            Begin Extent = 
               Top = 40
               Left = 1268
               Bottom = 133
               Right = 1419
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Isler"
            Begin Extent = 
               Top = 58
               Left = 386
               Bottom = 281
               Right = 596
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "Musteri"
            Begin Extent = 
               Top = 211
               Left = 129
               Bottom = 319
               Right = 289
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "IsinCinsi"
            Begin Extent = 
               Top = 12
               Left = 125
               Bottom = 90
               Right = 276
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Koy_Mahalle"
            Begin Extent = 
               Top = 41
               Left = 777
               Bottom = 149
               Right = 928
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Randevu"
            Begin Extent = 
               Top = 159
               Left = 733
               Bottom = 332
               Right = 884
            End
            DisplayFlags = 28' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewRandevuTalebiReportDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'0
            TopColumn = 6
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 3885
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2715
         Alias = 2010
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewRandevuTalebiReportDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewRandevuTalebiReportDetail'
GO
USE [master]
GO
ALTER DATABASE [LIHKAB_db] SET  READ_WRITE 
GO
