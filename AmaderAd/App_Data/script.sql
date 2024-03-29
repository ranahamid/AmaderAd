USE [master]
GO
/****** Object:  Database [AmaderAd]    Script Date: 4/29/2018 3:12:25 AM ******/
CREATE DATABASE [AmaderAd]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AmaderAd', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\AmaderAd.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AmaderAd_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\AmaderAd_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AmaderAd] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AmaderAd].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AmaderAd] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AmaderAd] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AmaderAd] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AmaderAd] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AmaderAd] SET ARITHABORT OFF 
GO
ALTER DATABASE [AmaderAd] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AmaderAd] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AmaderAd] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AmaderAd] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AmaderAd] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AmaderAd] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AmaderAd] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AmaderAd] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AmaderAd] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AmaderAd] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AmaderAd] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AmaderAd] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AmaderAd] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AmaderAd] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AmaderAd] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AmaderAd] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AmaderAd] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AmaderAd] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AmaderAd] SET  MULTI_USER 
GO
ALTER DATABASE [AmaderAd] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AmaderAd] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AmaderAd] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AmaderAd] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AmaderAd] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AmaderAd] SET QUERY_STORE = OFF
GO
USE [AmaderAd]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [AmaderAd]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 4/29/2018 3:12:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 4/29/2018 3:12:25 AM ******/
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
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 4/29/2018 3:12:25 AM ******/
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
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 4/29/2018 3:12:25 AM ******/
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
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 4/29/2018 3:12:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 4/29/2018 3:12:25 AM ******/
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
	[UserName] [nvarchar](256) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[Address] [nvarchar](256) NULL,
	[IsFakeEmail] [bit] NULL,
	[DoctorName] [nvarchar](256) NULL,
	[HospitalName] [nvarchar](256) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BannerImageTbl]    Script Date: 4/29/2018 3:12:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BannerImageTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[URL] [nvarchar](256) NULL,
	[ImagePath] [nvarchar](256) NOT NULL,
	[Description] [nvarchar](256) NULL,
	[DisplayOrder] [int] NULL,
	[MerchantId] [int] NULL,
	[CategoryId] [int] NULL,
	[BannerGuidId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_BannerImage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BannerTbl]    Script Date: 4/29/2018 3:12:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BannerTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[UpdatedOnUtc] [datetime2](7) NULL,
	[Published] [bit] NULL,
	[GuidId] [uniqueidentifier] NOT NULL,
	[IsHomePageBanner] [bit] NULL,
 CONSTRAINT [PK_Banner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerSearchTbl]    Script Date: 4/29/2018 3:12:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerSearchTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Keyword] [nvarchar](512) NULL,
	[IpAddress] [nvarchar](128) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
 CONSTRAINT [PK_CustomerSearch] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GeoZoneTbl]    Script Date: 4/29/2018 3:12:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GeoZoneTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NULL,
	[Description] [nvarchar](max) NULL,
	[DateAdded] [int] NULL,
	[DateModified] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogTbl]    Script Date: 4/29/2018 3:12:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExceptionMessage] [nvarchar](3050) NULL,
	[ExceptionStackTrace] [nvarchar](max) NULL,
	[ControllerName] [nvarchar](256) NULL,
	[IpAddress] [nvarchar](256) NULL,
	[Browser] [nvarchar](3050) NULL,
	[OS] [nvarchar](256) NULL,
	[UserId] [uniqueidentifier] NULL,
	[ActionName] [nvarchar](256) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
 CONSTRAINT [PK_LogTbl] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewspaperTbl]    Script Date: 4/29/2018 3:12:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewspaperTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NewsGuidId] [uniqueidentifier] NULL,
	[NewspaperName] [nvarchar](255) NULL,
	[AdLocation] [nvarchar](127) NULL,
	[PriceDescription] [int] NULL,
	[AdvertiserName] [nvarchar](255) NULL,
	[AdvertiserAddress] [nvarchar](255) NULL,
	[AdvertiserMobile] [nvarchar](20) NULL,
	[AdvertiserEmail] [nvarchar](100) NULL,
	[DateofPublication] [datetime2](7) NULL,
	[ColumnSize] [int] NULL,
	[Inch] [int] NULL,
	[TotalColumnInch] [int] NULL,
	[TotalPrice] [int] NULL,
	[AdCategoryId] [nvarchar](20) NULL,
	[Description] [nvarchar](4000) NULL,
	[Comments] [nvarchar](255) NULL,
	[MainImagePath] [nvarchar](255) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[UpdatedOnUtc] [datetime2](7) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_NewspaperTbl] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderPaymentMethodTbl]    Script Date: 4/29/2018 3:12:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderPaymentMethodTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](128) NULL,
	[Instructions] [nvarchar](max) NULL,
	[InstructionsImageUrl] [nvarchar](256) NULL,
	[Published] [bit] NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderPaymentStatusTbl]    Script Date: 4/29/2018 3:12:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderPaymentStatusTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DefaultStatus] [bit] NULL,
 CONSTRAINT [PK_OrderPaymentStatusTbl] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentTbl]    Script Date: 4/29/2018 3:12:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PaymentGuidId] [uniqueidentifier] NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[UpdatedOnUtc] [datetime2](7) NULL,
	[OrderId] [int] NULL,
	[PaymentChannel] [nvarchar](255) NULL,
	[PaymentMobile] [nvarchar](20) NULL,
	[PaymentTrxId] [nvarchar](20) NULL,
	[PaymentAmount] [int] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_PaymentTbl] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTbl]    Script Date: 4/29/2018 3:12:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](128) NULL,
	[LastName] [nvarchar](128) NULL,
	[Company] [nvarchar](128) NULL,
	[NoOfVisits] [int] NULL,
	[LastLoginDateUtc] [datetime2](7) NULL,
	[LastLoginIP] [nvarchar](128) NULL,
	[FailedLoginAttempts] [int] NULL,
	[CannotLoginUntilDateUtc] [datetime2](7) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[UpdatedOnUtc] [datetime2](7) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'034c549d-9e78-4037-97d1-07d5c08b2d16', N'Admin')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ddc2287a-910a-4272-8033-58df34cca189', N'Customer')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c76c5ba2-d1b0-49e7-afb0-8ae21b287b0c', N'034c549d-9e78-4037-97d1-07d5c08b2d16')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name], [Address], [IsFakeEmail], [DoctorName], [HospitalName], [Description]) VALUES (N'c76c5ba2-d1b0-49e7-afb0-8ae21b287b0c', N'ranahamid007@gmail.com', 0, N'AFK49j3/ssoLmie6eOUvWUzqj0oQ3EVeeKR4kEORxKMzjngvYNi8s5+ityTfICF4lw==', N'e3ef2094-3d09-4fc8-8656-40095d1447ec', N'87', 1, 0, NULL, 0, 0, N'01717623876', NULL, NULL, 0, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[BannerImageTbl] ON 

INSERT [dbo].[BannerImageTbl] ([Id], [URL], [ImagePath], [Description], [DisplayOrder], [MerchantId], [CategoryId], [BannerGuidId]) VALUES (1, NULL, N'Content/images/banner/Top Banner-Home App.jpg', NULL, 2, 1, 1, N'9aa673b4-1847-4d13-a6b5-e7026195336f')
INSERT [dbo].[BannerImageTbl] ([Id], [URL], [ImagePath], [Description], [DisplayOrder], [MerchantId], [CategoryId], [BannerGuidId]) VALUES (3, NULL, N'Content/images/banner/Medicine.jpg', NULL, 1, 1, 1, N'9aa673b4-1847-4d13-a6b5-e7026195336f')
SET IDENTITY_INSERT [dbo].[BannerImageTbl] OFF
SET IDENTITY_INSERT [dbo].[BannerTbl] ON 

INSERT [dbo].[BannerTbl] ([Id], [Name], [CreatedOnUtc], [UpdatedOnUtc], [Published], [GuidId], [IsHomePageBanner]) VALUES (1, N'HomePageBanner', CAST(N'2017-11-09T14:58:05.9397048' AS DateTime2), CAST(N'2018-02-05T02:40:15.9725228' AS DateTime2), 1, N'9aa673b4-1847-4d13-a6b5-e7026195336f', 1)
SET IDENTITY_INSERT [dbo].[BannerTbl] OFF
SET IDENTITY_INSERT [dbo].[LogTbl] ON 

INSERT [dbo].[LogTbl] ([Id], [ExceptionMessage], [ExceptionStackTrace], [ControllerName], [IpAddress], [Browser], [OS], [UserId], [ActionName], [CreatedOnUtc]) VALUES (14163, N'Object reference not set to an instance of an object.', N'   at AmaderAd.Controllers.PaymentsController.<Index>d__11.MoveNext() in D:\D\Google Drive-DS\Projects_Clients\Amader Ad\AmaderAd\AmaderAd\Controllers\PaymentsController.cs:line 87
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at System.Web.Mvc.Async.TaskAsyncActionDescriptor.EndExecute(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass37.<BeginInvokeAsynchronousActionMethod>b__36(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResult`1.CallEndDelegate(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResultBase`1.End()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethod(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.AsyncInvocationWithFilters.<InvokeActionMethodFilterAsynchronouslyRecursive>b__3d()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.AsyncInvocationWithFilters.<>c__DisplayClass46.<InvokeActionMethodFilterAsynchronouslyRecursive>b__3f()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass33.<BeginInvokeActionMethodWithFilters>b__32(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResult`1.CallEndDelegate(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResultBase`1.End()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethodWithFilters(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass21.<>c__DisplayClass2b.<BeginInvokeAction>b__1c()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass21.<BeginInvokeAction>b__1e(IAsyncResult asyncResult)', N'Payments', N'127.0.0.1', N'Chrome 64.0, 3.0', N'WinNT', N'00000000-0000-0000-0000-000000000000', N'Index', CAST(N'2018-04-26T02:26:21.6713016' AS DateTime2))
INSERT [dbo].[LogTbl] ([Id], [ExceptionMessage], [ExceptionStackTrace], [ControllerName], [IpAddress], [Browser], [OS], [UserId], [ActionName], [CreatedOnUtc]) VALUES (14164, N'Object reference not set to an instance of an object.', N'   at AmaderAd.Controllers.PaymentsController.<Index>d__11.MoveNext() in D:\D\Google Drive-DS\Projects_Clients\Amader Ad\AmaderAd\AmaderAd\Controllers\PaymentsController.cs:line 87
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at System.Web.Mvc.Async.TaskAsyncActionDescriptor.EndExecute(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass37.<BeginInvokeAsynchronousActionMethod>b__36(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResult`1.CallEndDelegate(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResultBase`1.End()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethod(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.AsyncInvocationWithFilters.<InvokeActionMethodFilterAsynchronouslyRecursive>b__3d()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.AsyncInvocationWithFilters.<>c__DisplayClass46.<InvokeActionMethodFilterAsynchronouslyRecursive>b__3f()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass33.<BeginInvokeActionMethodWithFilters>b__32(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResult`1.CallEndDelegate(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResultBase`1.End()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethodWithFilters(IAsyncResult asyncResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass21.<>c__DisplayClass2b.<BeginInvokeAction>b__1c()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass21.<BeginInvokeAction>b__1e(IAsyncResult asyncResult)', N'Payments', N'127.0.0.1', N'Chrome 64.0, 3.0', N'WinNT', N'00000000-0000-0000-0000-000000000000', N'Index', CAST(N'2018-04-26T02:26:28.1709104' AS DateTime2))
INSERT [dbo].[LogTbl] ([Id], [ExceptionMessage], [ExceptionStackTrace], [ControllerName], [IpAddress], [Browser], [OS], [UserId], [ActionName], [CreatedOnUtc]) VALUES (14165, N'D:\D\Google Drive-DS\Projects_Clients\Amader Ad\AmaderAd\AmaderAd\Views\Shared\_PaymentAdminDetails.cshtml(3): error CS1963: An expression tree may not contain a dynamic operation', N'   at System.Web.Compilation.AssemblyBuilder.Compile()
   at System.Web.Compilation.BuildProvidersCompiler.PerformBuild()
   at System.Web.Compilation.BuildManager.CompileWebFile(VirtualPath virtualPath)
   at System.Web.Compilation.BuildManager.GetVPathBuildResultInternal(VirtualPath virtualPath, Boolean noBuild, Boolean allowCrossApp, Boolean allowBuildInPrecompile, Boolean throwIfNotFound, Boolean ensureIsUpToDate)
   at System.Web.Compilation.BuildManager.GetVPathBuildResultWithNoAssert(HttpContext context, VirtualPath virtualPath, Boolean noBuild, Boolean allowCrossApp, Boolean allowBuildInPrecompile, Boolean throwIfNotFound, Boolean ensureIsUpToDate)
   at System.Web.Compilation.BuildManager.GetVirtualPathObjectFactory(VirtualPath virtualPath, HttpContext context, Boolean allowCrossApp, Boolean throwIfNotFound)
   at System.Web.Compilation.BuildManager.GetCompiledType(VirtualPath virtualPath)
   at System.Web.Compilation.BuildManager.GetCompiledType(String virtualPath)
   at System.Web.Mvc.BuildManagerWrapper.System.Web.Mvc.IBuildManager.GetCompiledType(String virtualPath)
   at System.Web.Mvc.BuildManagerCompiledView.Render(ViewContext viewContext, TextWriter writer)
   at System.Web.Mvc.HtmlHelper.RenderPartialInternal(String partialViewName, ViewDataDictionary viewData, Object model, TextWriter writer, ViewEngineCollection viewEngineCollection)
   at System.Web.Mvc.Html.PartialExtensions.Partial(HtmlHelper htmlHelper, String partialViewName, Object model, ViewDataDictionary viewData)
   at System.Web.Mvc.Html.PartialExtensions.Partial(HtmlHelper htmlHelper, String partialViewName, Object model)
   at ASP._Page_Views_Payments_Details_cshtml.Execute() in D:\D\Google Drive-DS\Projects_Clients\Amader Ad\AmaderAd\AmaderAd\Views\Payments\Details.cshtml:line 14
   at System.Web.WebPages.WebPageBase.ExecutePageHierarchy()
   at System.Web.Mvc.WebViewPage.ExecutePageHierarchy()
   at System.Web.WebPages.StartPage.RunPage()
   at System.Web.WebPages.StartPage.ExecutePageHierarchy()
   at System.Web.WebPages.WebPageBase.ExecutePageHierarchy(WebPageContext pageContext, TextWriter writer, WebPageRenderingBase startPage)
   at System.Web.Mvc.RazorView.RenderView(ViewContext viewContext, TextWriter writer, Object instance)
   at System.Web.Mvc.BuildManagerCompiledView.Render(ViewContext viewContext, TextWriter writer)
   at System.Web.Mvc.ViewResultBase.ExecuteResult(ControllerContext context)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionResult(ControllerContext controllerContext, ActionResult actionResult)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionResultFilterRecursive(IList`1 filters, Int32 filterIndex, ResultExecutingContext preContext, ControllerContext controllerContext, ActionResult actionResult)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionResultFilterRecursive(IList`1 filters, Int32 filterIndex, ResultExecutingContext preContext, ControllerContext controllerContext, ActionResult actionResult)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionResultWithFilters(ControllerContext controllerContext, IList`1 filters, ActionResult actionResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass21.<>c__DisplayClass2b.<BeginInvokeAction>b__1c()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass21.<BeginInvokeAction>b__1e(IAsyncResult asyncResult)', N'Payments', N'127.0.0.1', N'Chrome 64.0, 3.0', N'WinNT', N'00000000-0000-0000-0000-000000000000', N'Details', CAST(N'2018-04-26T02:46:43.2060232' AS DateTime2))
INSERT [dbo].[LogTbl] ([Id], [ExceptionMessage], [ExceptionStackTrace], [ControllerName], [IpAddress], [Browser], [OS], [UserId], [ActionName], [CreatedOnUtc]) VALUES (14166, N'D:\D\Google Drive-DS\Projects_Clients\Amader Ad\AmaderAd\AmaderAd\Views\Shared\_PaymentAdminDetails.cshtml(3): error CS1963: An expression tree may not contain a dynamic operation', N'   at System.Web.Compilation.AssemblyBuilder.Compile()
   at System.Web.Compilation.BuildProvidersCompiler.PerformBuild()
   at System.Web.Compilation.BuildManager.CompileWebFile(VirtualPath virtualPath)
   at System.Web.Compilation.BuildManager.GetVPathBuildResultInternal(VirtualPath virtualPath, Boolean noBuild, Boolean allowCrossApp, Boolean allowBuildInPrecompile, Boolean throwIfNotFound, Boolean ensureIsUpToDate)
   at System.Web.Compilation.BuildManager.GetVPathBuildResultWithNoAssert(HttpContext context, VirtualPath virtualPath, Boolean noBuild, Boolean allowCrossApp, Boolean allowBuildInPrecompile, Boolean throwIfNotFound, Boolean ensureIsUpToDate)
   at System.Web.Compilation.BuildManager.GetVirtualPathObjectFactory(VirtualPath virtualPath, HttpContext context, Boolean allowCrossApp, Boolean throwIfNotFound)
   at System.Web.Compilation.BuildManager.GetCompiledType(VirtualPath virtualPath)
   at System.Web.Compilation.BuildManager.GetCompiledType(String virtualPath)
   at System.Web.Mvc.BuildManagerWrapper.System.Web.Mvc.IBuildManager.GetCompiledType(String virtualPath)
   at System.Web.Mvc.BuildManagerCompiledView.Render(ViewContext viewContext, TextWriter writer)
   at System.Web.Mvc.HtmlHelper.RenderPartialInternal(String partialViewName, ViewDataDictionary viewData, Object model, TextWriter writer, ViewEngineCollection viewEngineCollection)
   at System.Web.Mvc.Html.PartialExtensions.Partial(HtmlHelper htmlHelper, String partialViewName, Object model, ViewDataDictionary viewData)
   at System.Web.Mvc.Html.PartialExtensions.Partial(HtmlHelper htmlHelper, String partialViewName, Object model)
   at ASP._Page_Views_Payments_Details_cshtml.Execute() in D:\D\Google Drive-DS\Projects_Clients\Amader Ad\AmaderAd\AmaderAd\Views\Payments\Details.cshtml:line 14
   at System.Web.WebPages.WebPageBase.ExecutePageHierarchy()
   at System.Web.Mvc.WebViewPage.ExecutePageHierarchy()
   at System.Web.WebPages.StartPage.RunPage()
   at System.Web.WebPages.StartPage.ExecutePageHierarchy()
   at System.Web.WebPages.WebPageBase.ExecutePageHierarchy(WebPageContext pageContext, TextWriter writer, WebPageRenderingBase startPage)
   at System.Web.Mvc.RazorView.RenderView(ViewContext viewContext, TextWriter writer, Object instance)
   at System.Web.Mvc.BuildManagerCompiledView.Render(ViewContext viewContext, TextWriter writer)
   at System.Web.Mvc.ViewResultBase.ExecuteResult(ControllerContext context)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionResult(ControllerContext controllerContext, ActionResult actionResult)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionResultFilterRecursive(IList`1 filters, Int32 filterIndex, ResultExecutingContext preContext, ControllerContext controllerContext, ActionResult actionResult)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionResultFilterRecursive(IList`1 filters, Int32 filterIndex, ResultExecutingContext preContext, ControllerContext controllerContext, ActionResult actionResult)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionResultWithFilters(ControllerContext controllerContext, IList`1 filters, ActionResult actionResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass21.<>c__DisplayClass2b.<BeginInvokeAction>b__1c()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass21.<BeginInvokeAction>b__1e(IAsyncResult asyncResult)', N'Payments', N'127.0.0.1', N'Chrome 64.0, 3.0', N'WinNT', N'00000000-0000-0000-0000-000000000000', N'Details', CAST(N'2018-04-26T02:46:53.9757372' AS DateTime2))
INSERT [dbo].[LogTbl] ([Id], [ExceptionMessage], [ExceptionStackTrace], [ControllerName], [IpAddress], [Browser], [OS], [UserId], [ActionName], [CreatedOnUtc]) VALUES (14167, N'D:\D\Google Drive-DS\Projects_Clients\Amader Ad\AmaderAd\AmaderAd\Views\Shared\_PaymentAdminDetails.cshtml(3): error CS1963: An expression tree may not contain a dynamic operation', N'   at System.Web.Compilation.AssemblyBuilder.Compile()
   at System.Web.Compilation.BuildProvidersCompiler.PerformBuild()
   at System.Web.Compilation.BuildManager.CompileWebFile(VirtualPath virtualPath)
   at System.Web.Compilation.BuildManager.GetVPathBuildResultInternal(VirtualPath virtualPath, Boolean noBuild, Boolean allowCrossApp, Boolean allowBuildInPrecompile, Boolean throwIfNotFound, Boolean ensureIsUpToDate)
   at System.Web.Compilation.BuildManager.GetVPathBuildResultWithNoAssert(HttpContext context, VirtualPath virtualPath, Boolean noBuild, Boolean allowCrossApp, Boolean allowBuildInPrecompile, Boolean throwIfNotFound, Boolean ensureIsUpToDate)
   at System.Web.Compilation.BuildManager.GetVirtualPathObjectFactory(VirtualPath virtualPath, HttpContext context, Boolean allowCrossApp, Boolean throwIfNotFound)
   at System.Web.Compilation.BuildManager.GetCompiledType(VirtualPath virtualPath)
   at System.Web.Compilation.BuildManager.GetCompiledType(String virtualPath)
   at System.Web.Mvc.BuildManagerWrapper.System.Web.Mvc.IBuildManager.GetCompiledType(String virtualPath)
   at System.Web.Mvc.BuildManagerCompiledView.Render(ViewContext viewContext, TextWriter writer)
   at System.Web.Mvc.HtmlHelper.RenderPartialInternal(String partialViewName, ViewDataDictionary viewData, Object model, TextWriter writer, ViewEngineCollection viewEngineCollection)
   at System.Web.Mvc.Html.PartialExtensions.Partial(HtmlHelper htmlHelper, String partialViewName, Object model, ViewDataDictionary viewData)
   at System.Web.Mvc.Html.PartialExtensions.Partial(HtmlHelper htmlHelper, String partialViewName, Object model)
   at ASP._Page_Views_Payments_Details_cshtml.Execute() in D:\D\Google Drive-DS\Projects_Clients\Amader Ad\AmaderAd\AmaderAd\Views\Payments\Details.cshtml:line 14
   at System.Web.WebPages.WebPageBase.ExecutePageHierarchy()
   at System.Web.Mvc.WebViewPage.ExecutePageHierarchy()
   at System.Web.WebPages.StartPage.RunPage()
   at System.Web.WebPages.StartPage.ExecutePageHierarchy()
   at System.Web.WebPages.WebPageBase.ExecutePageHierarchy(WebPageContext pageContext, TextWriter writer, WebPageRenderingBase startPage)
   at System.Web.Mvc.RazorView.RenderView(ViewContext viewContext, TextWriter writer, Object instance)
   at System.Web.Mvc.BuildManagerCompiledView.Render(ViewContext viewContext, TextWriter writer)
   at System.Web.Mvc.ViewResultBase.ExecuteResult(ControllerContext context)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionResult(ControllerContext controllerContext, ActionResult actionResult)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionResultFilterRecursive(IList`1 filters, Int32 filterIndex, ResultExecutingContext preContext, ControllerContext controllerContext, ActionResult actionResult)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionResultFilterRecursive(IList`1 filters, Int32 filterIndex, ResultExecutingContext preContext, ControllerContext controllerContext, ActionResult actionResult)
   at System.Web.Mvc.ControllerActionInvoker.InvokeActionResultWithFilters(ControllerContext controllerContext, IList`1 filters, ActionResult actionResult)
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass21.<>c__DisplayClass2b.<BeginInvokeAction>b__1c()
   at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass21.<BeginInvokeAction>b__1e(IAsyncResult asyncResult)', N'Payments', N'127.0.0.1', N'Chrome 64.0, 3.0', N'WinNT', N'00000000-0000-0000-0000-000000000000', N'Details', CAST(N'2018-04-26T02:48:26.5055186' AS DateTime2))
SET IDENTITY_INSERT [dbo].[LogTbl] OFF
SET IDENTITY_INSERT [dbo].[NewspaperTbl] ON 

INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (2003, N'cc93aeb2-2381-4d3f-a629-3d9199c07626', N'Ittefaq', N'Classified Advertisement', NULL, N'3123', N'2131', N'555', N'313@dgdf.c', CAST(N'2018-04-27T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, 828, N'7', N'রাজউক প্লট ক্রয়: রাজউকের উত্তরা ও পূর্বাচলে যে কোন সেক্টরে যে কোন আয়তনের প্লট জরুরী ভিত্তিতে ক্রয়ে ইচ্ছুক। ০১৭১XXXXXXX।', NULL, N'', CAST(N'2018-04-14T17:55:40.9770012' AS DateTime2), CAST(N'2018-04-14T17:55:40.9770012' AS DateTime2), NULL)
INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (2004, N'33df7591-90fd-44ec-bece-c0eb20a4ae5e', N'Ittefaq', N'Classified Advertisement', NULL, N'md. rana hamid', N'H#30', N'01717623876', N'ranahamid007@gmail.com', CAST(N'2018-04-16T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, 828, N'3', N'দোকান ভাড়া: সহজ শর্তে বেইলী রোডে মার্কেটে ৩য় তলায় ৩০০ বর্গফুট (শোরুম, গোডাউন, অফিস ইত্যাদি) ভাড়া হবে। ০১৮১XXXXXXX, ০১৮XXXXXXXX।', NULL, N'', CAST(N'2018-04-14T19:55:30.7566769' AS DateTime2), CAST(N'2018-04-14T19:55:30.7566769' AS DateTime2), NULL)
INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (2005, N'e2d69d7a-a158-419f-be6c-3e239ae529be', N'Ittefaq', N'Classified Advertisement', NULL, N'md. rana hamid', N'H#30', N'01717623876', N'ranahamid007@gmail.com', CAST(N'2018-04-16T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, 828, N'3', N'দোকান ভাড়া: সহজ শর্তে বেইলী রোডে মার্কেটে ৩য় তলায় ৩০০ বর্গফুট (শোরুম, গোডাউন, অফিস ইত্যাদি) ভাড়া হবে। ০১৮১XXXXXXX, ০১৮XXXXXXXX।', NULL, N'', CAST(N'2018-04-14T19:58:56.6687828' AS DateTime2), CAST(N'2018-04-14T19:58:56.6687828' AS DateTime2), NULL)
INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (2006, N'18aebd47-33da-403f-9363-32a09f45ebec', N'Ittefaq', N'Classified Advertisement', NULL, N'md. rana hamid', N'H#30', N'01717623876', N'ranahamid007@gmail.com', CAST(N'2018-04-16T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, 828, N'3', N'দোকান ভাড়া: সহজ শর্তে বেইলী রোডে মার্কেটে ৩য় তলায় ৩০০ বর্গফুট (শোরুম, গোডাউন, অফিস ইত্যাদি) ভাড়া হবে। ০১৮১XXXXXXX, ০১৮XXXXXXXX।', NULL, N'', CAST(N'2018-04-14T19:58:59.6869843' AS DateTime2), CAST(N'2018-04-14T19:58:59.6869843' AS DateTime2), NULL)
INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (2007, N'9c501eea-b703-43b5-b23d-8e2fef28c12b', N'Ittefaq', N'Classified Advertisement', NULL, N'md. rana hamid', N'H#30', N'01717623876', N'klaf@gmail.com', CAST(N'2018-04-16T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, 690, N'6', N'মগবাজার আউটারসার্কুলা২৭ বর্গফুটের নির রোডে ২৭ বর্গফুটের নি(এগোরার) বিপরীতে ১৭৩৯ ও ১৮২৭ বর্গফুটের নির্মাণাধীন ফ্ল্যাট বিক্রয়। ', NULL, N'', CAST(N'2018-04-14T20:30:10.5450435' AS DateTime2), CAST(N'2018-04-14T20:30:10.5450435' AS DateTime2), NULL)
INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (2008, N'8f4e2f42-10c2-4731-9f1d-47211683f4c5', N'Ittefaq', N'Classified Advertisement', NULL, N'mr. abc', N'H#30', N'555', N'abc@ls.com', CAST(N'2018-04-17T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, 690, NULL, N'২৭ বর্গফুটের নি', NULL, N'', CAST(N'2018-04-14T20:32:07.7130041' AS DateTime2), CAST(N'2018-04-14T20:32:07.7130041' AS DateTime2), NULL)
INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (2009, N'12cc6b5b-9ce0-4b98-a8ef-85ab02a3c16e', N'Ittefaq', N'Classified Advertisement', NULL, N'md. rana hamid', N'H#30', N'2234', N'abc@ls.com', CAST(N'2018-04-21T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, 690, N'3', N'পশ্চিম আগারগাঁও ৩ বেড বাথ ড্রয়িং-ডাইনিং, ২য় তলা বাসা ভাড়া দেওয়া হবে। যোগাযোগ ঃ ০১৫xxxxxxxx', NULL, N'', CAST(N'2018-04-17T02:29:56.4864634' AS DateTime2), CAST(N'2018-04-17T02:29:56.4869656' AS DateTime2), NULL)
INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (2010, N'cb545214-1613-44f0-93cc-5ce61b06b29f', N'Ittefaq', N'Classified Advertisement', NULL, N'md. rana hamid', N'234', N'01717623876', N'klaf@s.com', CAST(N'2018-05-02T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, 690, N'13', N'23432', NULL, N'', CAST(N'2018-04-17T02:35:37.2664957' AS DateTime2), CAST(N'2018-04-17T02:35:37.2664957' AS DateTime2), NULL)
INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (3009, N'794ac438-7c3b-4d3a-8ec8-6dc067472e2e', N'Ittefaq', N'Classified Advertisement', NULL, N'md. rana hamid', N'H#30', N'01717623876', N'abc@ls.com', CAST(N'2018-05-03T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, 690, N'10', N'this is my ad. please, publish this', NULL, N'', CAST(N'2018-04-21T01:04:04.1638430' AS DateTime2), CAST(N'2018-04-21T01:04:04.1643448' AS DateTime2), NULL)
INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (3010, N'add060b8-51ab-48a1-b633-307481c61d02', N'Ittefaq', N'Classified Advertisement', NULL, N'mr. abc', N'2131', N'5555', N'313@dgdf.c', CAST(N'2018-04-26T00:00:00.0000000' AS DateTime2), 342, 3423, 4234, 444, N'16', N'hi', NULL, N'Content/images/newspapersfile/35134530/z5oinb4s99f_1468696441_165l.jpg', CAST(N'2018-04-21T01:25:30.2993814' AS DateTime2), CAST(N'2018-04-24T02:14:11.2090920' AS DateTime2), 1)
INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (3011, N'8ce1c918-33a9-4c47-8f8f-6769d45a3c2e', N'Ittefaq', N'Classified Advertisement', NULL, N'md. rana hamid', N'2131', N'01717623876', N'ranahamid007@gmail.com', CAST(N'2018-04-23T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, 828, N'19', N'ডাক্তার ইঙ্গিনিয়ার সিটিজেনশিপ ব্যবসায়িক, ডিভোর্স বয়স্ক ও হিন্দুসহ সকল ধরনের পাত্র পাত্রির সন্ধানে গ্যারান্টি সহকারে কাজ করি। যোগাযোগঃ ০১৭৭xxxxxxx', NULL, N'', CAST(N'2018-04-21T21:43:07.2572494' AS DateTime2), CAST(N'2018-04-21T21:43:07.2572494' AS DateTime2), NULL)
INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (3012, N'144599a5-97ed-4925-ab24-dfbf462bffe6', N'Ittefaq', N'Ittefaq First Page Color', NULL, N'mr. abc', N'234', N'555', N'ranahamid007@gmail.com', CAST(N'2018-05-01T00:00:00.0000000' AS DateTime2), 3, 3, NULL, NULL, NULL, NULL, NULL, N'~/Content/uploads54h27skdekt_1468696441_168l.jpg', CAST(N'2018-04-26T01:55:26.4629759' AS DateTime2), CAST(N'2018-04-26T01:55:26.4649801' AS DateTime2), NULL)
INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (3013, N'1f0cc462-9ab1-4c56-9527-1428ac4c8e7c', N'Ittefaq', N'Ittefaq First Page Color', NULL, N'dfs', N'H#30', N'2234', N'ranahamid007@gmail.com', CAST(N'2018-05-04T00:00:00.0000000' AS DateTime2), NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'~/Content/uploads/AAMRA- Project Plan - Version 1.0 - 20180408.pdf', CAST(N'2018-04-26T02:12:29.5908108' AS DateTime2), CAST(N'2018-04-26T02:12:29.5918132' AS DateTime2), NULL)
INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (3014, N'74df8363-6538-4440-bef0-de153636013c', N'Ittefaq', N'Ittefaq First Page Color', NULL, N'23423', N'4234', N'324', N'23423@fs.c', CAST(N'2018-05-02T00:00:00.0000000' AS DateTime2), 234, 34, NULL, 444, NULL, NULL, NULL, N'~/Content/uploads/2018-04-24_3-12-31.png', CAST(N'2018-04-26T02:51:22.4483948' AS DateTime2), CAST(N'2018-04-26T02:51:22.4483948' AS DateTime2), NULL)
INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (3015, N'f75ba805-b1c8-4b52-8fde-183b57c13240', N'Ittefaq', N'Ittefaq First Page Color', NULL, N'3123', N'2131', N'555', N'klaf@s.com', CAST(N'2018-05-04T00:00:00.0000000' AS DateTime2), 2, 2, NULL, NULL, NULL, NULL, NULL, N'~/Content/uploads/111 Nagaon.pdf', CAST(N'2018-04-26T03:05:00.2396322' AS DateTime2), CAST(N'2018-04-26T03:05:00.2396322' AS DateTime2), NULL)
INSERT [dbo].[NewspaperTbl] ([Id], [NewsGuidId], [NewspaperName], [AdLocation], [PriceDescription], [AdvertiserName], [AdvertiserAddress], [AdvertiserMobile], [AdvertiserEmail], [DateofPublication], [ColumnSize], [Inch], [TotalColumnInch], [TotalPrice], [AdCategoryId], [Description], [Comments], [MainImagePath], [CreatedOnUtc], [UpdatedOnUtc], [Active]) VALUES (4012, N'5a205362-c674-4b0f-a436-77ea941d5a0f', N'Ittefaq', N'Ittefaq Last Page Color', NULL, N'3123', N'234', N'2234', N'ranahamid007@gmail.com', CAST(N'2018-04-30T00:00:00.0000000' AS DateTime2), 2, 2, NULL, NULL, NULL, NULL, NULL, N'Content/uploads/CIR_LETTER_8118.pdf', CAST(N'2018-04-28T20:43:21.0096908' AS DateTime2), CAST(N'2018-04-28T20:43:21.0096908' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[NewspaperTbl] OFF
SET IDENTITY_INSERT [dbo].[OrderPaymentMethodTbl] ON 

INSERT [dbo].[OrderPaymentMethodTbl] ([Id], [Name], [Instructions], [InstructionsImageUrl], [Published]) VALUES (1, N'Bkash', N'01. Go to your bKash Mobile Menu by dialing *247#
02. Choose “Payment”
03. Enter the Merchant bKash Account Number you want to pay to
04. Enter the amount you want to pay
05. Enter a reference* against your payment (you can mention the purpose of the transaction in one word. e.g. Bill)
06. Enter the Counter Number* (the salesperson at the counter will tell you the number)
07. Now enter your bKash Mobile Menu PIN to confirm

 ', N'Content\images\payment\bKash_payment_Process.png', 1)
INSERT [dbo].[OrderPaymentMethodTbl] ([Id], [Name], [Instructions], [InstructionsImageUrl], [Published]) VALUES (2, N'Rocket', N'01. Customer can pay bills of various organizations using this payment option.
02. To make a payment please follow the following instruction.
03. To get this service from Dutch-Bangla Bank Rocket account you just need to dial *322# from any operator except citycell.
04. In case if you are using Citycell mobile phones then just send an empty sms to 16216.
05. Once you dial *322# or send an sms to 16216 you will get the following screen.
From the screen please select the option 1.', N'Content/images/OrderPaymentMethods/78011970/2018-04-14_19-03-50.png', 1)
INSERT [dbo].[OrderPaymentMethodTbl] ([Id], [Name], [Instructions], [InstructionsImageUrl], [Published]) VALUES (3, N'Internet Banking', NULL, N'Content/images/OrderPaymentMethods/67844705/book.jpg', NULL)
INSERT [dbo].[OrderPaymentMethodTbl] ([Id], [Name], [Instructions], [InstructionsImageUrl], [Published]) VALUES (4, N'Card', N'Pay using ssl commerz.
We accept
a) Debit Card
b) Credit Card', N'Content/images/OrderPaymentMethods/61233661/new_mod_pay.png', 1)
SET IDENTITY_INSERT [dbo].[OrderPaymentMethodTbl] OFF
SET IDENTITY_INSERT [dbo].[OrderPaymentStatusTbl] ON 

INSERT [dbo].[OrderPaymentStatusTbl] ([Id], [Name], [DefaultStatus]) VALUES (1, N'InComplete', 1)
INSERT [dbo].[OrderPaymentStatusTbl] ([Id], [Name], [DefaultStatus]) VALUES (2, N'Complete', 0)
SET IDENTITY_INSERT [dbo].[OrderPaymentStatusTbl] OFF
SET IDENTITY_INSERT [dbo].[PaymentTbl] ON 

INSERT [dbo].[PaymentTbl] ([Id], [PaymentGuidId], [CreatedOnUtc], [UpdatedOnUtc], [OrderId], [PaymentChannel], [PaymentMobile], [PaymentTrxId], [PaymentAmount], [Active]) VALUES (1, NULL, CAST(N'2018-04-17T02:35:58.0541398' AS DateTime2), CAST(N'2018-04-17T02:35:58.0546402' AS DateTime2), 3009, N'1', N'01725620123', N'TRX4423554', 850, NULL)
INSERT [dbo].[PaymentTbl] ([Id], [PaymentGuidId], [CreatedOnUtc], [UpdatedOnUtc], [OrderId], [PaymentChannel], [PaymentMobile], [PaymentTrxId], [PaymentAmount], [Active]) VALUES (2, NULL, CAST(N'2018-04-21T01:53:18.2818079' AS DateTime2), CAST(N'2018-04-24T02:14:11.1829830' AS DateTime2), 3010, N'1', N'32423', N'423423', 4234, 1)
INSERT [dbo].[PaymentTbl] ([Id], [PaymentGuidId], [CreatedOnUtc], [UpdatedOnUtc], [OrderId], [PaymentChannel], [PaymentMobile], [PaymentTrxId], [PaymentAmount], [Active]) VALUES (3, NULL, CAST(N'2018-04-21T21:43:52.1192071' AS DateTime2), CAST(N'2018-04-21T21:43:52.1192071' AS DateTime2), 3011, N'1', N'01725620123', N'TRX4423554', 828, NULL)
INSERT [dbo].[PaymentTbl] ([Id], [PaymentGuidId], [CreatedOnUtc], [UpdatedOnUtc], [OrderId], [PaymentChannel], [PaymentMobile], [PaymentTrxId], [PaymentAmount], [Active]) VALUES (4, N'4b09b09e-60b7-4ae6-ae4f-6fca8cf45a8c', CAST(N'2018-04-24T01:52:18.2237814' AS DateTime2), CAST(N'2018-04-24T01:52:18.2242832' AS DateTime2), NULL, N'1', N'32423', N'423423', 4234, 1)
INSERT [dbo].[PaymentTbl] ([Id], [PaymentGuidId], [CreatedOnUtc], [UpdatedOnUtc], [OrderId], [PaymentChannel], [PaymentMobile], [PaymentTrxId], [PaymentAmount], [Active]) VALUES (1004, N'642d60f8-b603-484e-b2dd-2cd71e691b84', CAST(N'2018-04-26T03:05:17.7461562' AS DateTime2), CAST(N'2018-04-26T03:05:17.7461562' AS DateTime2), 3015, N'1', N'01725620123', N'33sdf2354sdf', 850, NULL)
INSERT [dbo].[PaymentTbl] ([Id], [PaymentGuidId], [CreatedOnUtc], [UpdatedOnUtc], [OrderId], [PaymentChannel], [PaymentMobile], [PaymentTrxId], [PaymentAmount], [Active]) VALUES (2004, N'88e24bf8-d505-49e1-9e04-ab36eab54dac', CAST(N'2018-04-28T20:43:46.7993295' AS DateTime2), CAST(N'2018-04-28T20:43:46.8003024' AS DateTime2), 4012, N'1', N'01725620123', N'TRX4423554', 850, NULL)
SET IDENTITY_INSERT [dbo].[PaymentTbl] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 4/29/2018 3:12:25 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 4/29/2018 3:12:25 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 4/29/2018 3:12:25 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleId]    Script Date: 4/29/2018 3:12:25 AM ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 4/29/2018 3:12:25 AM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 4/29/2018 3:12:25 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BannerImageTbl] ADD  CONSTRAINT [DF_BannerImageTbl_DisplayOrder]  DEFAULT ((0)) FOR [DisplayOrder]
GO
ALTER TABLE [dbo].[BannerImageTbl] ADD  CONSTRAINT [DF_BannerImageTbl_MerchantId]  DEFAULT ((0)) FOR [MerchantId]
GO
ALTER TABLE [dbo].[BannerImageTbl] ADD  CONSTRAINT [DF_BannerImageTbl_CategoryId]  DEFAULT ((0)) FOR [CategoryId]
GO
ALTER TABLE [dbo].[CustomerSearchTbl] ADD  CONSTRAINT [DF_CustomerSearchTbl_UserId]  DEFAULT ((0)) FOR [UserId]
GO
ALTER TABLE [dbo].[OrderPaymentStatusTbl] ADD  CONSTRAINT [DF_OrderPaymentStatusTbl_DefaultStatus]  DEFAULT ((0)) FOR [DefaultStatus]
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
USE [master]
GO
ALTER DATABASE [AmaderAd] SET  READ_WRITE 
GO
