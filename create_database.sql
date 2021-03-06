
IF OBJECT_ID('dbChamCong', 'P')IS NOT NULL
	DROP PROC dbChamCong
GO

IF DB_ID('dbChamCong') IS NULL 
	CREATE DATABASE dbChamCong
GO
/****** Object:  Database [dbChamCong]    Script Date: 04/01/2018 12:30:28 PM ******/

ALTER DATABASE [dbChamCong] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbChamCong] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbChamCong] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbChamCong] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbChamCong] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbChamCong] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbChamCong] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbChamCong] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbChamCong] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbChamCong] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbChamCong] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbChamCong] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbChamCong] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbChamCong] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbChamCong] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbChamCong] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbChamCong] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbChamCong] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbChamCong] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbChamCong] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbChamCong] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbChamCong] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbChamCong] SET RECOVERY FULL 
GO
ALTER DATABASE [dbChamCong] SET  MULTI_USER 
GO
ALTER DATABASE [dbChamCong] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbChamCong] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbChamCong] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbChamCong] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbChamCong] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbChamCong', N'ON'
GO
USE [dbChamCong]
GO
/****** Object:  Table [dbo].[tbChamCong_ChucVu]    Script Date: 04/01/2018 12:30:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChamCong_ChucVu](
	[MaCV] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_tbChamCong_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbChamCong_DangNhap]    Script Date: 04/01/2018 12:30:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbChamCong_DangNhap](
	[MaDN] [int] IDENTITY(1,1) NOT NULL,
	[UserName] int NULL,
	[Password] [char](20) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_tbChamCong_DangNhap] PRIMARY KEY CLUSTERED 
(
	[MaDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbChamCong_Datetime]    Script Date: 04/01/2018 12:30:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChamCong_Datetime](
	[MaNgay] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[NgayLe] [bit] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_tbChamCong_Datetime] PRIMARY KEY CLUSTERED 
(
	[MaNgay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbChamCong_Datetime_Check_Fulltime]    Script Date: 04/01/2018 12:30:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChamCong_Datetime_Check_Fulltime](
	[MaCheck] [int] NOT NULL,
	[MaNVFT] [int] NULL,
	[MaNgay] [int] NULL,
	[CheckIn] [time](7) NULL,
	[CheckOut] [time](7) NULL,
	[FullDay] [bit] NULL,
	[HalfDay] [bit] NULL,
	[TangCa] [bit] NULL,
	[SoGio] [float] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_tbChamCong_Datetime_Check] PRIMARY KEY CLUSTERED 
(
	[MaCheck] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbChamCong_Datetime_Check_Parttime]    Script Date: 04/01/2018 12:30:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChamCong_Datetime_Check_Parttime](
	[MaCheck] [int] IDENTITY(1,1) NOT NULL,
	[MaNVPT] [int] NULL,
	[MaNgay] [datetime] NULL,
	[SoGioLam] [int] NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbChamCong_NgayNghi]    Script Date: 04/01/2018 12:30:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChamCong_NgayNghi](
	[MaNN] [int] IDENTITY(1,1) NOT NULL,
	[MaNVFT] [int] NULL,
	[MaNgay] [int] NULL,
	[CoPhep] [bit] NULL,
	[LyDo] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_tbChamCong_NgayNghi] PRIMARY KEY CLUSTERED 
(
	[MaNN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbChamCong_NhanVien_Fulltime]    Script Date: 04/01/2018 12:30:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbChamCong_NhanVien_Fulltime](
	[MaNVFT] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [date] NULL,
	[DienThoai] [char](15) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_tbChamCong_NhanVien_Fulltime] PRIMARY KEY CLUSTERED 
(
	[MaNVFT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbChamCong_NhanVien_Fulltime_ChiTiet]    Script Date: 04/01/2018 12:30:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChamCong_NhanVien_Fulltime_ChiTiet](
	[MaNVFT] [int] NOT NULL,
	[MaPB] [int] NOT NULL,
	[MaCV] [int] NOT NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
 CONSTRAINT [PK_tbChamCong_NhanVien_Fulltime_ChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaNVFT] ASC,
	[MaPB] ASC,
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbChamCong_NhanVien_Parttime]    Script Date: 04/01/2018 12:30:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbChamCong_NhanVien_Parttime](
	[MaNVPT] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[DienThoai] [char](15) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_tbChamCong_NhanVien_Parttime] PRIMARY KEY CLUSTERED 
(
	[MaNVPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbChamCong_PhongBan]    Script Date: 04/01/2018 12:30:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChamCong_PhongBan](
	[MaPB] [int] IDENTITY(1,1) NOT NULL,
	[TenPhongBan] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_tbChamCong_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

