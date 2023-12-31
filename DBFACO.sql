USE [master]
GO
/****** Object:  Database [DBFACO]    Script Date: 27/11/2023 08:04:16 p. m. ******/
CREATE DATABASE [DBFACO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBFACO', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DBFACO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBFACO_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DBFACO_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DBFACO] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBFACO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBFACO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBFACO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBFACO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBFACO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBFACO] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBFACO] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DBFACO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBFACO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBFACO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBFACO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBFACO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBFACO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBFACO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBFACO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBFACO] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBFACO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBFACO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBFACO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBFACO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBFACO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBFACO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBFACO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBFACO] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBFACO] SET  MULTI_USER 
GO
ALTER DATABASE [DBFACO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBFACO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBFACO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBFACO] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBFACO] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBFACO] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DBFACO] SET QUERY_STORE = ON
GO
ALTER DATABASE [DBFACO] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DBFACO]
GO
/****** Object:  Table [dbo].[FINANZAS]    Script Date: 27/11/2023 08:04:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FINANZAS](
	[Documento] [varchar](10) NULL,
	[Fecha_de_Compra] [date] NULL,
	[Nombre_productos] [varchar](200) NULL,
	[Precio_Total] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOGIN]    Script Date: 27/11/2023 08:04:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOGIN](
	[Documento] [varchar](50) NOT NULL,
	[Nombre_Completo] [varchar](50) NULL,
	[Fecha_Nacimiento] [datetime] NULL,
	[Usuario] [varchar](40) NULL,
	[Contraseña] [varchar](50) NULL,
	[Telefono] [varchar](10) NULL,
 CONSTRAINT [PK__LOGIN__AF73706C6AB76B41] PRIMARY KEY CLUSTERED 
(
	[Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[FINANZAS] ([Documento], [Fecha_de_Compra], [Nombre_productos], [Precio_Total]) VALUES (N'1003266310', CAST(N'2023-11-26' AS Date), N'Fluvis,Biodramina,Viagra,Viagra', 84000)
INSERT [dbo].[FINANZAS] ([Documento], [Fecha_de_Compra], [Nombre_productos], [Precio_Total]) VALUES (N'1003266310', CAST(N'2023-11-26' AS Date), N'Hidroclorotiazida,Fluviral Noire,Fluvis,Biodramina', 74000)
INSERT [dbo].[FINANZAS] ([Documento], [Fecha_de_Compra], [Nombre_productos], [Precio_Total]) VALUES (N'1192769038', CAST(N'2023-11-27' AS Date), N'Mieltertos,Noxpirin,Redoxon', 55000)
INSERT [dbo].[FINANZAS] ([Documento], [Fecha_de_Compra], [Nombre_productos], [Precio_Total]) VALUES (N'1192769038', CAST(N'2023-11-27' AS Date), N'Ventonil', 42000)
INSERT [dbo].[FINANZAS] ([Documento], [Fecha_de_Compra], [Nombre_productos], [Precio_Total]) VALUES (N'1192769038', CAST(N'2023-11-27' AS Date), N'Condones Durex,Amoxicilina,Buscapina', 31500)
INSERT [dbo].[FINANZAS] ([Documento], [Fecha_de_Compra], [Nombre_productos], [Precio_Total]) VALUES (N'1192769038', CAST(N'2023-11-27' AS Date), N'Condones Durex', 10000)
GO
INSERT [dbo].[LOGIN] ([Documento], [Nombre_Completo], [Fecha_Nacimiento], [Usuario], [Contraseña], [Telefono]) VALUES (N'1003266310', N'Julian Santos', CAST(N'2002-08-29T00:00:00.000' AS DateTime), N'TxJULIANxT', N'Juliancho2002', N'3126831113')
INSERT [dbo].[LOGIN] ([Documento], [Nombre_Completo], [Fecha_Nacimiento], [Usuario], [Contraseña], [Telefono]) VALUES (N'1192769038', N'Estebant Daza', CAST(N'2001-06-08T00:00:00.000' AS DateTime), N'edavid', N'estebandavid23', N'3016605205')
GO
USE [master]
GO
ALTER DATABASE [DBFACO] SET  READ_WRITE 
GO
