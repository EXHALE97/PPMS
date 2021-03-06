USE [master]
GO
/****** Object:  Database [gas_station]    Script Date: 4/3/2021 3:22:20 PM ******/
CREATE DATABASE [gas_station]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gas_station', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\gas_station.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'gas_station_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\gas_station_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [gas_station] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gas_station].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gas_station] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gas_station] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gas_station] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gas_station] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gas_station] SET ARITHABORT OFF 
GO
ALTER DATABASE [gas_station] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gas_station] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gas_station] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gas_station] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gas_station] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gas_station] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gas_station] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gas_station] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gas_station] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gas_station] SET  DISABLE_BROKER 
GO
ALTER DATABASE [gas_station] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gas_station] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gas_station] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gas_station] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gas_station] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gas_station] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gas_station] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gas_station] SET RECOVERY FULL 
GO
ALTER DATABASE [gas_station] SET  MULTI_USER 
GO
ALTER DATABASE [gas_station] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gas_station] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gas_station] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gas_station] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [gas_station] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [gas_station] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'gas_station', N'ON'
GO
ALTER DATABASE [gas_station] SET QUERY_STORE = OFF
GO
USE [gas_station]
GO
/****** Object:  User [Worker]    Script Date: 4/3/2021 3:22:20 PM ******/
CREATE USER [Worker] FOR LOGIN [GasStationWorker] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [User]    Script Date: 4/3/2021 3:22:20 PM ******/
CREATE USER [User] FOR LOGIN [GasStationUser] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Admin]    Script Date: 4/3/2021 3:22:20 PM ******/
CREATE USER [Admin] FOR LOGIN [GasStationAdmin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Worker]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Worker]
GO
ALTER ROLE [db_datareader] ADD MEMBER [User]
GO
ALTER ROLE [db_owner] ADD MEMBER [Admin]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 4/3/2021 3:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[last_name] [nvarchar](50) NULL,
	[middle_name] [nvarchar](50) NULL,
	[card_id] [int] NOT NULL,
	[cred_id] [int] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientCard]    Script Date: 4/3/2021 3:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientCard](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[discount_percent] [int] NOT NULL,
	[activation_date] [date] NOT NULL,
 CONSTRAINT [PK_ClientCard] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Credentials]    Script Date: 4/3/2021 3:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credentials](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Credentials] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deal]    Script Date: 4/3/2021 3:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[client_card_id] [int] NULL,
	[employee_id] [int] NOT NULL,
	[supply_type_id] [int] NOT NULL,
	[supply_type_amount] [float] NOT NULL,
	[price] [float] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_Deal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/3/2021 3:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[middle_name] [nvarchar](50) NULL,
	[position] [nvarchar](50) NOT NULL,
	[date_of_birth] [date] NOT NULL,
	[date_of_employment] [date] NOT NULL,
	[date_of_contract_end] [date] NOT NULL,
	[salary] [float] NOT NULL,
	[address] [nvarchar](max) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[cred_id] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Station]    Script Date: 4/3/2021 3:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Station](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[city] [nvarchar](50) NOT NULL,
	[country] [nvarchar](50) NOT NULL,
	[address] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Station] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supply]    Script Date: 4/3/2021 3:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supply](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[station_id] [int] NOT NULL,
	[employee_id] [int] NOT NULL,
	[supply_type_id] [int] NOT NULL,
	[supply_amount] [int] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_Supply] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplyType]    Script Date: 4/3/2021 3:22:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplyType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[price] [float] NOT NULL,
 CONSTRAINT [PK_SupplyType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_ClientCard] FOREIGN KEY([card_id])
REFERENCES [dbo].[ClientCard] ([id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_ClientCard]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Credentials] FOREIGN KEY([cred_id])
REFERENCES [dbo].[Credentials] ([id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Credentials]
GO
ALTER TABLE [dbo].[Deal]  WITH CHECK ADD  CONSTRAINT [FK_Deal_ClientCard] FOREIGN KEY([client_card_id])
REFERENCES [dbo].[ClientCard] ([id])
GO
ALTER TABLE [dbo].[Deal] CHECK CONSTRAINT [FK_Deal_ClientCard]
GO
ALTER TABLE [dbo].[Deal]  WITH CHECK ADD  CONSTRAINT [FK_Deal_Employee] FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([id])
GO
ALTER TABLE [dbo].[Deal] CHECK CONSTRAINT [FK_Deal_Employee]
GO
ALTER TABLE [dbo].[Deal]  WITH CHECK ADD  CONSTRAINT [FK_Deal_SupplyType] FOREIGN KEY([supply_type_id])
REFERENCES [dbo].[SupplyType] ([id])
GO
ALTER TABLE [dbo].[Deal] CHECK CONSTRAINT [FK_Deal_SupplyType]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Credentials] FOREIGN KEY([cred_id])
REFERENCES [dbo].[Credentials] ([id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Credentials]
GO
ALTER TABLE [dbo].[Supply]  WITH CHECK ADD  CONSTRAINT [FK_Supply_Employee] FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([id])
GO
ALTER TABLE [dbo].[Supply] CHECK CONSTRAINT [FK_Supply_Employee]
GO
ALTER TABLE [dbo].[Supply]  WITH CHECK ADD  CONSTRAINT [FK_Supply_Station] FOREIGN KEY([station_id])
REFERENCES [dbo].[Station] ([id])
GO
ALTER TABLE [dbo].[Supply] CHECK CONSTRAINT [FK_Supply_Station]
GO
ALTER TABLE [dbo].[Supply]  WITH CHECK ADD  CONSTRAINT [FK_Supply_SupplyType] FOREIGN KEY([supply_type_id])
REFERENCES [dbo].[SupplyType] ([id])
GO
ALTER TABLE [dbo].[Supply] CHECK CONSTRAINT [FK_Supply_SupplyType]
GO
USE [master]
GO
ALTER DATABASE [gas_station] SET  READ_WRITE 
GO
