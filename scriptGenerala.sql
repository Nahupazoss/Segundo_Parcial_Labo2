USE [master]
GO
/****** Object:  Database [dtbase_generala]    Script Date: 15/11/2022 21:47:08 ******/
CREATE DATABASE [dtbase_generala]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dtbase_generala', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dtbase_generala.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dtbase_generala_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dtbase_generala_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dtbase_generala] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dtbase_generala].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dtbase_generala] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dtbase_generala] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dtbase_generala] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dtbase_generala] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dtbase_generala] SET ARITHABORT OFF 
GO
ALTER DATABASE [dtbase_generala] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dtbase_generala] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dtbase_generala] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dtbase_generala] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dtbase_generala] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dtbase_generala] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dtbase_generala] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dtbase_generala] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dtbase_generala] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dtbase_generala] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dtbase_generala] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dtbase_generala] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dtbase_generala] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dtbase_generala] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dtbase_generala] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dtbase_generala] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dtbase_generala] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dtbase_generala] SET RECOVERY FULL 
GO
ALTER DATABASE [dtbase_generala] SET  MULTI_USER 
GO
ALTER DATABASE [dtbase_generala] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dtbase_generala] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dtbase_generala] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dtbase_generala] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dtbase_generala] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dtbase_generala] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dtbase_generala', N'ON'
GO
ALTER DATABASE [dtbase_generala] SET QUERY_STORE = OFF
GO
USE [dtbase_generala]
GO
/****** Object:  Table [dbo].[tabla_jugadores]    Script Date: 15/11/2022 21:47:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tabla_jugadores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[partidasGanadas] [int] NOT NULL,
	[partidasPerdidas] [int] NOT NULL,
	[partidasJugadas] [int] NOT NULL,
 CONSTRAINT [PK_tabla_jugadores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tabla_jugadores] ON 

INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (1, N'aaa', N'aaa', N'aaa', N'aa1', 0, 0, 0)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (2, N'Milagros', N'Luna', N'Mili890m', N'123m', 0, 0, 0)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (3, N'Mica', N'Vazquez', N'miquina22', N'contraseña123', 0, 0, 0)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (4, N'Mauro', N'Luciano', N'Mauricio', N'Maurito123', 0, 0, 0)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (5, N'Maximiliano', N'Neiner', N'NeinerProfe', N'contra2244', 0, 0, 0)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (6, N'Facundo', N'Rocha', N'FacuRocha', N'rocha1234', 0, 0, 0)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (7, N'Nathan', N'Sulivan', N'Nathanfit', N'calistenia22', 0, 0, 0)
SET IDENTITY_INSERT [dbo].[tabla_jugadores] OFF
GO
USE [master]
GO
ALTER DATABASE [dtbase_generala] SET  READ_WRITE 
GO
