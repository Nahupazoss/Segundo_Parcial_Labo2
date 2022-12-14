USE [master]
GO
/****** Object:  Database [dtbase_generala]    Script Date: 7/12/2022 02:35:03 ******/
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
/****** Object:  Table [dbo].[historialPartidas]    Script Date: 7/12/2022 02:35:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historialPartidas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[jugador1] [varchar](50) NOT NULL,
	[jugador2] [varchar](50) NOT NULL,
	[puntaje1] [int] NOT NULL,
	[puntaje2] [int] NOT NULL,
	[ganador] [varchar](50) NOT NULL,
 CONSTRAINT [PK_historialPartidas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tabla_jugadores]    Script Date: 7/12/2022 02:35:03 ******/
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
SET IDENTITY_INSERT [dbo].[historialPartidas] ON 

INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (1, N'Nahuel', N'BotMauro', 0, 0, N'Empate')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (2, N'Nahuel', N'BotValery', 20, 0, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (3, N'Nahuel', N'BotMauro', 0, 0, N'Empate')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (4, N'Nahuel', N'BotMauro', 0, 0, N'Empate')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (5, N'Nahuel', N'BotMauro', 0, 0, N'Empate')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (6, N'Nahuel', N'BotMauro', 0, 40, N'BotMauro')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (7, N'Maximiliano', N'BotNathan', 0, 0, N'Empate')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (8, N'Nahuel', N'Pazos', 1, 0, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (9, N'Nahuel', N'Pazos', 1, 0, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (10, N'Nahuel', N'Pazos', 1, 0, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (11, N'Nahuel', N'Pazos', 1, 0, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (12, N'Nahuel', N'Pazos', 1, 0, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (13, N'Nahuel', N'Pazos', 1, 0, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (14, N'Nahuel', N'Pazos', 1, 0, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (15, N'Nahuel', N'Pazos', 1, 0, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (16, N'Nahuel', N'Pazos', 1, 0, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (17, N'Nahuel', N'Pazos', 1, 0, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (18, N'Nahuel', N'Pazos', 1, 0, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (19, N'Nahuel', N'Pazos', 1, 0, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (20, N'Nahuel', N'Pazos', 1, 0, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (21, N'Nahuel', N'Pazos', 1, 0, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (22, N'Maximiliano', N'BotMauro', 50, 50, N'Empate')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (23, N'Maximiliano', N'BotNahuel', 80, 75, N'Maximiliano')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (24, N'Maximiliano', N'BotNathan', 50, 65, N'BotNathan')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (25, N'Maximiliano', N'BotMauro', 50, 80, N'BotMauro')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (26, N'Nahuel', N'BotMauro', 85, 65, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (27, N'Nahuel', N'BotMica', 100, 105, N'BotMica')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (28, N'Nahuel', N'BotMauro', 80, 100, N'BotMauro')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (29, N'Nahuel', N'BotMica', 65, 50, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (30, N'Nahuel', N'BotMauro', 130, 65, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (31, N'Maximiliano', N'BotMauro', 90, 120, N'BotMauro')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (32, N'Maximiliano', N'BotValery', 50, 115, N'BotValery')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (33, N'Maximiliano', N'BotValery', 130, 65, N'Maximiliano')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (34, N'Maximiliano', N'BotMauro', 100, 65, N'Maximiliano')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (35, N'Maximiliano', N'BotValery', 90, 65, N'Maximiliano')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (36, N'Maximiliano', N'BotMica', 65, 100, N'BotMica')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (37, N'Maximiliano', N'BotNeiner', 50, 90, N'BotNeiner')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (38, N'Maximiliano', N'BotNahuel', 50, 80, N'BotNahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (39, N'Maximiliano', N'BotMica', 100, 50, N'Maximiliano')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (40, N'Nahuel', N'BotNahuel', 90, 90, N'Empate')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (41, N'Nahuel', N'BotNahuel', 50, 135, N'BotNahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (42, N'Nahuel', N'BotNahuel', 140, 65, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (43, N'Nahuel', N'BotNahuel', 105, 50, N'Nahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (44, N'Nacho', N'BotNahuel', 80, 65, N'Nacho')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (45, N'Nacho', N'BotNeiner', 150, 100, N'Nacho')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (46, N'Nacho', N'BotMauro', 50, 65, N'BotMauro')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (47, N'Nacho', N'BotMauro', 105, 50, N'Nacho')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (48, N'Nacho', N'BotNahuel', 65, 115, N'BotNahuel')
INSERT [dbo].[historialPartidas] ([id], [jugador1], [jugador2], [puntaje1], [puntaje2], [ganador]) VALUES (49, N'Nacho', N'BotMauro', 50, 65, N'BotMauro')
SET IDENTITY_INSERT [dbo].[historialPartidas] OFF
GO
SET IDENTITY_INSERT [dbo].[tabla_jugadores] ON 

INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (1, N'Noah', N'Beckmann', N'nbeckmann0', N'DUDxLVraIuA', 1, 1, 1)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (2, N'Bax', N'Bogeys', N'bbogeys1', N'MPwNMUW1j', 2, 2, 2)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (3, N'Warde', N'Worcs', N'wworcs2', N'o7D8VbnKd', 3, 3, 3)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (4, N'Jannel', N'Campos', N'jcampos3', N'jk1klqmPYS', 4, 4, 4)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (5, N'Gib', N'Hanaby', N'ghanaby4', N't4MTE8uznI3i', 5, 5, 5)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (6, N'Robin', N'Asey', N'rasey5', N'AoovTKMSi', 6, 6, 6)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (7, N'Rodrigo', N'Pazos', N'NahuPazos', N'123Nn', 7, 1, 2)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (8, N'Clio', N'Wilcinskis', N'cwilcinskis7', N'jpMqlI', 8, 8, 8)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (9, N'Cirilo', N'Kinneally', N'ckinneally8', N'aajkg9hFSSt', 9, 9, 9)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (10, N'Consuela', N'Ankrett', N'cankrett9', N'JzmSGA', 10, 10, 10)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (11, N'Tom', N'Dinzey', N'tdinzeya', N'pWvbxubdz', 11, 11, 11)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (12, N'Darbie', N'Sausman', N'dsausmanb', N'22ROJoCAmB', 12, 12, 12)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (13, N'Haydon', N'Benoix', N'hbenoixc', N'dkHEy38WzPi', 13, 13, 13)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (14, N'Tadeo', N'Adamovitch', N'tadamovitchd', N'H0X7uklcPba', 14, 14, 14)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (15, N'Cathrine', N'Rolstone', N'crolstonee', N'j0CuCDza', 15, 15, 15)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (16, N'Euphemia', N'Mufford', N'emuffordf', N'GgW8xFJ4QA', 16, 16, 16)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (17, N'Gib', N'Marquis', N'gmarquisg', N'SIl58O', 17, 17, 17)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (18, N'Chaddie', N'Taunton', N'ctauntonh', N'Por0jySouQ', 18, 18, 18)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (19, N'Edsel', N'Page', N'epagei', N'8oDJsQNsesOB', 19, 19, 19)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (20, N'Donall', N'Darrington', N'ddarringtonj', N'c7tyhwo', 20, 20, 20)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (21, N'Geoffry', N'Sreenan', N'gsreenank', N't4sYXyFn7', 21, 21, 21)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (22, N'Sunny', N'Iacopetti', N'siacopettil', N'pUTDcKC19', 22, 22, 22)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (23, N'Anastassia', N'Jenson', N'ajensonm', N'lv0m0sdVpKwU', 23, 23, 23)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (24, N'Beverley', N'Gegg', N'bgeggn', N'ULlmmfiwoq', 24, 24, 24)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (25, N'Alonso', N'Calvey', N'acalveyo', N'L6ukLPAHcVcG', 25, 25, 25)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (26, N'Huntlee', N'Northfield', N'hnorthfieldp', N'V29u4RchALa', 26, 26, 26)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (27, N'Raymond', N'Dursley', N'rdursleyq', N'EydG7tAS', 27, 27, 27)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (28, N'Cyrillus', N'Mulcock', N'cmulcockr', N'KIGK44Lz7iNR', 28, 28, 28)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (29, N'Piotr', N'Thomel', N'pthomels', N'FbbUjy3Q', 29, 29, 29)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (30, N'Hermine', N'Salmon', N'hsalmont', N'9DZS2Eaoj4sp', 30, 30, 30)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (31, N'Zarla', N'Pedden', N'zpeddenu', N'dTFPUcnR7', 31, 31, 31)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (32, N'Bing', N'Riche', N'brichev', N'rUKGUXy1bY1y', 32, 32, 32)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (33, N'Deirdre', N'Beckers', N'dbeckersw', N'hMRTvT', 33, 33, 33)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (34, N'Ogden', N'Pickard', N'opickardx', N'3Rqc9CX', 34, 34, 34)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (35, N'Winnie', N'Bourtoumieux', N'wbourtoumieuxy', N'v5GaYn', 35, 35, 35)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (36, N'Daphene', N'Chrichton', N'dchrichtonz', N'1Yfc1ueoq', 36, 36, 36)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (37, N'Amaleta', N'Tenaunt', N'atenaunt10', N'qr4YLHg3D', 37, 37, 37)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (38, N'Anne-corinne', N'Simonsson', N'asimonsson11', N'QpnYFzB', 38, 38, 38)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (39, N'Cointon', N'Sommer', N'csommer12', N'pCnJaEr', 39, 39, 39)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (40, N'Neda', N'Durand', N'ndurand13', N'ReIrMRO', 40, 40, 40)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (41, N'Antonina', N'Deaconson', N'adeaconson14', N'1lTTqLtj', 41, 41, 41)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (42, N'Zacharie', N'Sigfrid', N'zsigfrid15', N'FucXN1', 42, 42, 42)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (43, N'Andromache', N'Nare', N'anare16', N'7tTaJvZA', 43, 43, 43)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (44, N'Ellis', N'MacLice', N'emaclice17', N'ww6Xxb', 44, 44, 44)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (45, N'Clarabelle', N'Raun', N'craun18', N'G1IeMfgOBH', 45, 45, 45)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (46, N'Jocelyne', N'McCalister', N'jmccalister19', N'tdaRqzo2TXK', 46, 46, 46)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (47, N'Darcey', N'Galland', N'dgalland1a', N'5i8SiNbT', 47, 47, 47)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (48, N'Wernher', N'Pell', N'wpell1b', N'CA1LYr', 48, 48, 48)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (49, N'Blaire', N'Goodee', N'bgoodee1c', N'wuQSNspq5', 49, 49, 49)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (50, N'Symon', N'Badman', N'sbadman1d', N'peBp11SK1PS', 50, 50, 50)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (51, N'Arch', N'Sells', N'asells1e', N'LeipGMZwG7', 51, 51, 51)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (52, N'Mychal', N'Duigan', N'mduigan1f', N'21X98j', 52, 52, 52)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (53, N'Garey', N'McKeggie', N'gmckeggie1g', N'aWyDbB8tx', 53, 53, 53)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (54, N'Valery', N'Nieass', N'vnieass1h', N'0Vic9M23orB', 54, 54, 54)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (55, N'Robin', N'Malpas', N'rmalpas1i', N'jxyzvW0o', 55, 55, 55)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (56, N'Erica', N'Greguol', N'egreguol1j', N'DSMElBNOMYX', 56, 56, 56)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (57, N'Tonya', N'Newbegin', N'tnewbegin1k', N'sATWvk7k8WX', 57, 57, 57)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (58, N'Ralina', N'Brehat', N'rbrehat1l', N'lFtSflrUH7wp', 58, 58, 58)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (59, N'Rora', N'Tupling', N'rtupling1m', N'EuwH5rl1Ssk', 59, 59, 59)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (60, N'Ashlin', N'Earp', N'aearp1n', N'MNpIQPrxQV2', 60, 60, 60)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (61, N'Tobie', N'Bilbery', N'tbilbery1o', N't8iyYpg', 61, 61, 61)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (62, N'Bili', N'Laurant', N'blaurant1p', N'gS3nLp', 62, 62, 62)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (63, N'Romeo', N'Pickhaver', N'rpickhaver1q', N'gG6Fk3ygw', 63, 63, 63)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (64, N'Minor', N'Saw', N'msaw1r', N'QSylv0hk', 64, 64, 64)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (65, N'Emilia', N'Thorald', N'ethorald1s', N'xXE7RJms', 65, 65, 65)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (66, N'Reube', N'McKeand', N'rmckeand1t', N'fitTaW', 66, 66, 66)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (67, N'Zebedee', N'Lyster', N'zlyster1u', N'LgAP4Ilo3', 67, 67, 67)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (68, N'Tish', N'Lewnden', N'tlewnden1v', N'Z2vqsmr', 68, 68, 68)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (69, N'Corabella', N'Snead', N'csnead1w', N'kgC2osAp', 69, 69, 69)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (70, N'Kelsy', N'Haycraft', N'khaycraft1x', N'dqtkren6t4', 70, 70, 70)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (71, N'Perri', N'Chiverstone', N'pchiverstone1y', N'uAZJ3k5wx', 71, 71, 71)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (72, N'Kesley', N'Bartomeu', N'kbartomeu1z', N'AAcfPmXUo', 72, 72, 72)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (73, N'Aviva', N'Carrier', N'acarrier20', N'l1h7GI', 73, 73, 73)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (74, N'Dar', N'Betteriss', N'dbetteriss21', N'9QLwcuEXod', 74, 74, 74)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (75, N'Lucy', N'Chamberlayne', N'lchamberlayne22', N'xRfd8g1ZGpF', 75, 75, 75)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (76, N'Minny', N'McElmurray', N'mmcelmurray23', N'xsD7OwpUR74V', 76, 76, 76)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (77, N'Lutero', N'Clayal', N'lclayal24', N'UhCKUE61', 77, 77, 77)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (78, N'Abigail', N'Trapp', N'atrapp25', N'bPFMtM5', 78, 78, 78)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (79, N'Wallis', N'Lettuce', N'wlettuce26', N'E3U390x4do', 79, 79, 79)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (80, N'Patric', N'Rawlins', N'prawlins27', N'4ePwpDk0h3', 80, 80, 80)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (81, N'Berty', N'Allanby', N'ballanby28', N'xwyAY1', 81, 81, 81)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (82, N'Natal', N'Powell', N'npowell29', N'24HOYjL', 82, 82, 82)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (83, N'Dorri', N'Wagstaffe', N'dwagstaffe2a', N'Q9Jl09QdQSdU', 83, 83, 83)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (84, N'Rhody', N'Blanning', N'rblanning2b', N'k4zAC6P', 84, 84, 84)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (85, N'Cyb', N'Cestard', N'ccestard2c', N'bS1Y6brxUn', 85, 85, 85)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (86, N'Loren', N'Danis', N'ldanis2d', N'aHqUEgb', 86, 86, 86)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (87, N'Chauncey', N'Zamora', N'czamora2e', N'3ycmbQf', 87, 87, 87)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (88, N'Cristen', N'Rushby', N'crushby2f', N'yalzwm', 88, 88, 88)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (89, N'Dody', N'Blamphin', N'dblamphin2g', N'Q1Fy10', 89, 89, 89)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (90, N'Sofie', N'Peart', N'speart2h', N'Pw8YUQE', 90, 90, 90)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (91, N'Frances', N'Hall-Gough', N'fhallgough2i', N'Oqutpa', 91, 91, 91)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (92, N'Peter', N'Clappison', N'pclappison2j', N'HiETtOfDl', 92, 92, 92)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (93, N'Jenelle', N'Ceeley', N'jceeley2k', N'wwEyyV', 93, 93, 93)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (94, N'Constancy', N'Tarrier', N'ctarrier2l', N'4obpk3uyWVW', 94, 94, 94)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (95, N'Siouxie', N'Kolodziejski', N'skolodziejski2m', N'bdPZ8FOyWSTz', 95, 95, 95)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (96, N'Casar', N'Sink', N'csink2n', N'jJ3TzsKh0', 96, 96, 96)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (97, N'Niccolo', N'Woodruff', N'nwoodruff2o', N'OkuQuFX', 97, 97, 97)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (98, N'Mariele', N'Shrive', N'mshrive2p', N'RPyz2c', 98, 98, 98)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (99, N'Brit', N'Woodham', N'bwoodham2q', N'gohX9qAo', 99, 99, 99)
GO
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (100, N'Lorrie', N'Skones', N'lskones2r', N'C9oX4C9', 100, 100, 100)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (102, N'Maximiliano', N'Neiner', N'NeinerProfe', N'123a', 0, 2, 10)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (108, N'Nahuel', N'Pazos', N'NahuPazos', N'123N', 0, 0, 0)
INSERT [dbo].[tabla_jugadores] ([id], [nombre], [apellido], [usuario], [password], [partidasGanadas], [partidasPerdidas], [partidasJugadas]) VALUES (117, N'Nacho', N'Gerla', N'NachoAKD', N'123a', 3, 3, 6)
SET IDENTITY_INSERT [dbo].[tabla_jugadores] OFF
GO
USE [master]
GO
ALTER DATABASE [dtbase_generala] SET  READ_WRITE 
GO
