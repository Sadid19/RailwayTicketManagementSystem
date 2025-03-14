USE [master]
GO
/****** Object:  Database [RailwayTicketManagement]    Script Date: 1/23/2025 2:43:59 PM ******/
CREATE DATABASE [RailwayTicketManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RailwayTicketManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\RailwayTicketManagement.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RailwayTicketManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\RailwayTicketManagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RailwayTicketManagement] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RailwayTicketManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RailwayTicketManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [RailwayTicketManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RailwayTicketManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RailwayTicketManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RailwayTicketManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RailwayTicketManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RailwayTicketManagement] SET  MULTI_USER 
GO
ALTER DATABASE [RailwayTicketManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RailwayTicketManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RailwayTicketManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RailwayTicketManagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [RailwayTicketManagement]
GO
/****** Object:  Table [dbo].[AdminTable]    Script Date: 1/23/2025 2:43:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AdminTable](
	[UserId] [varchar](10) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Role] [varchar](50) NOT NULL,
 CONSTRAINT [PK_AdminTable] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CartView]    Script Date: 1/23/2025 2:43:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CartView](
	[InvoiceNumber] [int] IDENTITY(1,1) NOT NULL,
	[TrainIdCart] [varchar](10) NULL,
	[TrainNameCart] [varchar](50) NOT NULL,
	[FromStationCart] [varchar](50) NOT NULL,
	[ToStationCart] [varchar](50) NOT NULL,
	[PriceCart] [float] NOT NULL,
	[UserId] [varchar](10) NOT NULL,
 CONSTRAINT [PK_CartView] PRIMARY KEY CLUSTERED 
(
	[InvoiceNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmployeeTable]    Script Date: 1/23/2025 2:43:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployeeTable](
	[UserId] [varchar](10) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Role] [varchar](50) NOT NULL,
	[Salary] [int] NOT NULL,
 CONSTRAINT [PK_EmployeeTable] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TrainInfo]    Script Date: 1/23/2025 2:43:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TrainInfo](
	[TrainId] [varchar](10) NOT NULL,
	[TrainName] [varchar](50) NOT NULL,
	[FromStation] [varchar](50) NOT NULL,
	[ToStation] [varchar](50) NOT NULL,
	[Available] [varchar](30) NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_TrainInfo] PRIMARY KEY CLUSTERED 
(
	[TrainId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[AdminTable] ([UserId], [UserName], [Password], [Role]) VALUES (N'u-001', N'Sadid', N'123', N'Admin')
SET IDENTITY_INSERT [dbo].[CartView] ON 

INSERT [dbo].[CartView] ([InvoiceNumber], [TrainIdCart], [TrainNameCart], [FromStationCart], [ToStationCart], [PriceCart], [UserId]) VALUES (14, N'tr-104', N'Porjotok Express', N'Dhaka', N'Cox_s Bazar', 1600, N'u-001')
INSERT [dbo].[CartView] ([InvoiceNumber], [TrainIdCart], [TrainNameCart], [FromStationCart], [ToStationCart], [PriceCart], [UserId]) VALUES (15, N'tr-102', N'Sonar Bangla Express', N'Dhaka', N'Chittagonj', 1200, N'u-001')
INSERT [dbo].[CartView] ([InvoiceNumber], [TrainIdCart], [TrainNameCart], [FromStationCart], [ToStationCart], [PriceCart], [UserId]) VALUES (16, N'tr-104', N'Porjotok Express', N'Dhaka', N'Cox_s Bazar', 1600, N'u-001')
INSERT [dbo].[CartView] ([InvoiceNumber], [TrainIdCart], [TrainNameCart], [FromStationCart], [ToStationCart], [PriceCart], [UserId]) VALUES (18, N'tr-104', N'Porjotok Express', N'Dhaka', N'Cox_s Bazar', 1600, N'u-001')
INSERT [dbo].[CartView] ([InvoiceNumber], [TrainIdCart], [TrainNameCart], [FromStationCart], [ToStationCart], [PriceCart], [UserId]) VALUES (19, N'tr-104', N'Porjotok Express', N'Dhaka', N'Cox_s Bazar', 1600, N'u-001')
SET IDENTITY_INSERT [dbo].[CartView] OFF
INSERT [dbo].[EmployeeTable] ([UserId], [UserName], [Password], [Role], [Salary]) VALUES (N'u-002', N'Touhid', N'456', N'Employee', 5000)
INSERT [dbo].[EmployeeTable] ([UserId], [UserName], [Password], [Role], [Salary]) VALUES (N'u-003', N'Foisal', N'789', N'Employee', 5000)
INSERT [dbo].[TrainInfo] ([TrainId], [TrainName], [FromStation], [ToStation], [Available], [Price]) VALUES (N'tr-101', N'Padma Express', N'Dhaka', N'Rajshahi', N'Yes', 400)
INSERT [dbo].[TrainInfo] ([TrainId], [TrainName], [FromStation], [ToStation], [Available], [Price]) VALUES (N'tr-102', N'Sonar Bangla Express', N'Dhaka', N'Chittagonj', N'Yes', 600)
INSERT [dbo].[TrainInfo] ([TrainId], [TrainName], [FromStation], [ToStation], [Available], [Price]) VALUES (N'tr-103', N'Upoban Express', N'Dhaka', N'Sylhet', N'No', 500)
INSERT [dbo].[TrainInfo] ([TrainId], [TrainName], [FromStation], [ToStation], [Available], [Price]) VALUES (N'tr-104', N'Porjotok Express', N'Dhaka', N'Cox_s Bazar', N'Yes', 800)
USE [master]
GO
ALTER DATABASE [RailwayTicketManagement] SET  READ_WRITE 
GO
