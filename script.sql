USE [master]
GO
/****** Object:  Database [ChocolateShop]    Script Date: 16.12.2022 15:46:56 ******/
CREATE DATABASE [ChocolateShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ChocolateShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ChocolateShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ChocolateShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ChocolateShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ChocolateShop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ChocolateShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ChocolateShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ChocolateShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ChocolateShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ChocolateShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ChocolateShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [ChocolateShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ChocolateShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ChocolateShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ChocolateShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ChocolateShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ChocolateShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ChocolateShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ChocolateShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ChocolateShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ChocolateShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ChocolateShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ChocolateShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ChocolateShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ChocolateShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ChocolateShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ChocolateShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ChocolateShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ChocolateShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ChocolateShop] SET  MULTI_USER 
GO
ALTER DATABASE [ChocolateShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ChocolateShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ChocolateShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ChocolateShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ChocolateShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ChocolateShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ChocolateShop] SET QUERY_STORE = OFF
GO
USE [ChocolateShop]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 16.12.2022 15:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IDType] [int] NOT NULL,
	[IDSupplier] [int] NOT NULL,
	[Image] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[CountOnStage] [int] NOT NULL,
	[Cost] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 16.12.2022 15:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 16.12.2022 15:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDUser] [int] NOT NULL,
	[IDProduct] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Count] [int] NOT NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 16.12.2022 15:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IDTown] [int] NOT NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Town]    Script Date: 16.12.2022 15:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Town](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 16.12.2022 15:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 16.12.2022 15:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NULL,
	[Mail] [nvarchar](50) NULL,
	[IDRole] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ID], [Name], [IDType], [IDSupplier], [Image], [Description], [CountOnStage], [Cost]) VALUES (1, N'Alpen Gold', 1, 1, N'alpengold.jpg', N'Вкусно, очень вкусно', 5, 150)
INSERT [dbo].[Product] ([ID], [Name], [IDType], [IDSupplier], [Image], [Description], [CountOnStage], [Cost]) VALUES (2, N'Dove', 1, 2, N'dove.jpg', N'ЫАААА', 5, 150)
INSERT [dbo].[Product] ([ID], [Name], [IDType], [IDSupplier], [Image], [Description], [CountOnStage], [Cost]) VALUES (3, N'Конфета европейская', 2, 2, N'picture.jpg', N'вкусно', 5, 1000)
INSERT [dbo].[Product] ([ID], [Name], [IDType], [IDSupplier], [Image], [Description], [CountOnStage], [Cost]) VALUES (5, N'ghj', 1, 3, N'2-kursyi-testirovaniya-po-qa.jpg', N'ghj', 5, 5000)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID], [Name]) VALUES (1, N'Администратор')
INSERT [dbo].[Role] ([ID], [Name]) VALUES (2, N'Менеджер')
INSERT [dbo].[Role] ([ID], [Name]) VALUES (3, N'Пользователь')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([ID], [Name], [IDTown]) VALUES (1, N'Росфонд', 1)
INSERT [dbo].[Supplier] ([ID], [Name], [IDTown]) VALUES (2, N'Милка интертеймант', 2)
INSERT [dbo].[Supplier] ([ID], [Name], [IDTown]) VALUES (3, N'Михалыч на севере', 2)
SET IDENTITY_INSERT [dbo].[Supplier] OFF
GO
SET IDENTITY_INSERT [dbo].[Town] ON 

INSERT [dbo].[Town] ([ID], [Name]) VALUES (1, N'Москва')
INSERT [dbo].[Town] ([ID], [Name]) VALUES (2, N'Санкт-Петребург')
INSERT [dbo].[Town] ([ID], [Name]) VALUES (3, N'Нижний Новгород')
INSERT [dbo].[Town] ([ID], [Name]) VALUES (4, N'Ижевск')
SET IDENTITY_INSERT [dbo].[Town] OFF
GO
SET IDENTITY_INSERT [dbo].[Type] ON 

INSERT [dbo].[Type] ([ID], [Name]) VALUES (1, N'Шоколадка')
INSERT [dbo].[Type] ([ID], [Name]) VALUES (2, N'Конфеты')
SET IDENTITY_INSERT [dbo].[Type] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Login], [Password], [Surname], [Name], [Phone], [Mail], [IDRole]) VALUES (1, N'admin', N'admin1', N'Иванов', N'Иван', N'89046190855', N'ivan11@mail.ru', 1)
INSERT [dbo].[User] ([ID], [Login], [Password], [Surname], [Name], [Phone], [Mail], [IDRole]) VALUES (2, N'MMManager', N'mmm123', N'Петров', N'Петр', N'894561232323', N'petro@mail.ru', 2)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supplier] FOREIGN KEY([IDSupplier])
REFERENCES [dbo].[Supplier] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Supplier]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Type] FOREIGN KEY([IDType])
REFERENCES [dbo].[Type] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Type]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Product] FOREIGN KEY([IDProduct])
REFERENCES [dbo].[Product] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Product]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_User] FOREIGN KEY([IDUser])
REFERENCES [dbo].[User] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_User]
GO
ALTER TABLE [dbo].[Supplier]  WITH CHECK ADD  CONSTRAINT [FK_Supplier_Town] FOREIGN KEY([IDTown])
REFERENCES [dbo].[Town] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Supplier] CHECK CONSTRAINT [FK_Supplier_Town]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([IDRole])
REFERENCES [dbo].[Role] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [ChocolateShop] SET  READ_WRITE 
GO
