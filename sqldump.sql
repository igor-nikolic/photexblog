USE [master]
GO
/****** Object:  Database [PhoTexBlog]    Script Date: 01-Jul-20 14:50:08 ******/
CREATE DATABASE [PhoTexBlog]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PhoTexBlog', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\PhoTexBlog.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PhoTexBlog_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\PhoTexBlog_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [PhoTexBlog] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PhoTexBlog].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PhoTexBlog] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PhoTexBlog] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PhoTexBlog] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PhoTexBlog] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PhoTexBlog] SET ARITHABORT OFF 
GO
ALTER DATABASE [PhoTexBlog] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PhoTexBlog] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PhoTexBlog] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PhoTexBlog] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PhoTexBlog] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PhoTexBlog] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PhoTexBlog] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PhoTexBlog] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PhoTexBlog] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PhoTexBlog] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PhoTexBlog] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PhoTexBlog] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PhoTexBlog] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PhoTexBlog] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PhoTexBlog] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PhoTexBlog] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PhoTexBlog] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PhoTexBlog] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PhoTexBlog] SET  MULTI_USER 
GO
ALTER DATABASE [PhoTexBlog] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PhoTexBlog] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PhoTexBlog] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PhoTexBlog] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PhoTexBlog] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PhoTexBlog] SET QUERY_STORE = OFF
GO
USE [PhoTexBlog]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 01-Jul-20 14:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 01-Jul-20 14:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[Visible] [bit] NOT NULL,
	[CommentText] [nvarchar](1000) NOT NULL,
	[UserId] [int] NOT NULL,
	[PostId] [int] NOT NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Posts]    Script Date: 01-Jul-20 14:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[Visible] [bit] NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[PhotoPath] [nvarchar](50) NOT NULL,
	[UserId] [int] NOT NULL,
	[TopicId] [int] NOT NULL,
 CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ratings]    Script Date: 01-Jul-20 14:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ratings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[Visible] [bit] NOT NULL,
	[UserId] [int] NOT NULL,
	[PostId] [int] NOT NULL,
	[Value] [int] NOT NULL,
 CONSTRAINT [PK_Ratings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Topics]    Script Date: 01-Jul-20 14:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topics](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[Visible] [bit] NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Topics] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UseCaseLogs]    Script Date: 01-Jul-20 14:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UseCaseLogs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[UseCaseId] [int] NOT NULL,
	[Data] [nvarchar](max) NOT NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_UseCaseLogs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UseCases]    Script Date: 01-Jul-20 14:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UseCases](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_UseCases] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 01-Jul-20 14:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[Visible] [bit] NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[Email] [nvarchar](450) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserUseCases]    Script Date: 01-Jul-20 14:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserUseCases](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[Visible] [bit] NOT NULL,
	[UserId] [int] NOT NULL,
	[UseCaseId] [int] NOT NULL,
 CONSTRAINT [PK_UserUseCases] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200630195724_initial', N'3.1.5')
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (1, CAST(N'2020-06-30T21:57:23.2999940' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 13)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (2, CAST(N'2020-06-30T21:57:23.3000051' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 6)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (3, CAST(N'2020-06-30T21:57:23.3000067' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 7)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (4, CAST(N'2020-06-30T21:57:23.3000075' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 16)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (5, CAST(N'2020-06-30T21:57:23.3000083' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 4)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (6, CAST(N'2020-06-30T21:57:23.3000095' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 10)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (7, CAST(N'2020-06-30T21:57:23.3000103' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 1)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (8, CAST(N'2020-06-30T21:57:23.3000112' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 23)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (9, CAST(N'2020-06-30T21:57:23.3000120' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 11)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (10, CAST(N'2020-06-30T21:57:23.3000130' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 23)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (11, CAST(N'2020-06-30T21:57:23.3000138' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 8)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (12, CAST(N'2020-06-30T21:57:23.3000146' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 2)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (13, CAST(N'2020-06-30T21:57:23.3000154' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 19)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (14, CAST(N'2020-06-30T21:57:23.3000162' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 1)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (15, CAST(N'2020-06-30T21:57:23.3000169' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 9)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (16, CAST(N'2020-06-30T21:57:23.3000177' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 9)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (17, CAST(N'2020-06-30T21:57:23.3000185' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 13)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (18, CAST(N'2020-06-30T21:57:23.3000195' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 9)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (19, CAST(N'2020-06-30T21:57:23.3000203' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 17)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (20, CAST(N'2020-06-30T21:57:23.3000211' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 2)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (21, CAST(N'2020-06-30T21:57:23.3000219' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 16)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (22, CAST(N'2020-06-30T21:57:23.3000227' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 23)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (23, CAST(N'2020-06-30T21:57:23.3000235' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 16)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (24, CAST(N'2020-06-30T21:57:23.3000352' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 22)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (25, CAST(N'2020-06-30T21:57:23.3000361' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 3)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (26, CAST(N'2020-06-30T21:57:23.3000369' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 23)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (27, CAST(N'2020-06-30T21:57:23.3000377' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 13)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (28, CAST(N'2020-06-30T21:57:23.3000385' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 14)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (29, CAST(N'2020-06-30T21:57:23.3000393' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 17)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (30, CAST(N'2020-06-30T21:57:23.3000400' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 9)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (31, CAST(N'2020-06-30T21:57:23.3000408' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 2)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (32, CAST(N'2020-06-30T21:57:23.3000416' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 16)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (33, CAST(N'2020-06-30T21:57:23.3000424' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 23)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (34, CAST(N'2020-06-30T21:57:23.3000435' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 15)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (35, CAST(N'2020-06-30T21:57:23.3000443' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 20)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (36, CAST(N'2020-06-30T21:57:23.3000451' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 9)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (37, CAST(N'2020-06-30T21:57:23.3000458' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 18)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (38, CAST(N'2020-06-30T21:57:23.3000466' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 4)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (39, CAST(N'2020-06-30T21:57:23.3000474' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 3)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (40, CAST(N'2020-06-30T21:57:23.3000482' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 9)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (41, CAST(N'2020-06-30T21:57:23.3000490' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 22)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (42, CAST(N'2020-06-30T21:57:23.3000497' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 7)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (43, CAST(N'2020-06-30T21:57:23.3000505' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 5)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (44, CAST(N'2020-06-30T21:57:23.3000513' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 4)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (45, CAST(N'2020-06-30T21:57:23.3000521' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 15)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (46, CAST(N'2020-06-30T21:57:23.3000529' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 18)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (47, CAST(N'2020-06-30T21:57:23.3000536' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 1)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (48, CAST(N'2020-06-30T21:57:23.3000544' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 20)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (49, CAST(N'2020-06-30T21:57:23.3000552' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 7)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (50, CAST(N'2020-06-30T21:57:23.3000560' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 1)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (51, CAST(N'2020-06-30T21:57:23.3000568' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 18)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (52, CAST(N'2020-06-30T21:57:23.3000576' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 1)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (53, CAST(N'2020-06-30T21:57:23.3000584' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 18)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (54, CAST(N'2020-06-30T21:57:23.3000591' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 6)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (55, CAST(N'2020-06-30T21:57:23.3000599' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 21)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (56, CAST(N'2020-06-30T21:57:23.3000607' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 10)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (57, CAST(N'2020-06-30T21:57:23.3000615' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 19)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (58, CAST(N'2020-06-30T21:57:23.3000622' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 12)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (59, CAST(N'2020-06-30T21:57:23.3000631' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 1)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (60, CAST(N'2020-06-30T21:57:23.3000638' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 19)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (61, CAST(N'2020-06-30T21:57:23.3000814' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 12)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (62, CAST(N'2020-06-30T21:57:23.3000823' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 5)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (63, CAST(N'2020-06-30T21:57:23.3000831' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 17)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (64, CAST(N'2020-06-30T21:57:23.3000839' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 1)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (65, CAST(N'2020-06-30T21:57:23.3000847' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 4)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (66, CAST(N'2020-06-30T21:57:23.3000858' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 2)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (67, CAST(N'2020-06-30T21:57:23.3000866' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 1)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (68, CAST(N'2020-06-30T21:57:23.3000874' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 16)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (69, CAST(N'2020-06-30T21:57:23.3000882' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 3)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (70, CAST(N'2020-06-30T21:57:23.3000889' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 10)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (71, CAST(N'2020-06-30T21:57:23.3000897' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 3)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (72, CAST(N'2020-06-30T21:57:23.3000905' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 16)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (73, CAST(N'2020-06-30T21:57:23.3000913' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 10)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (74, CAST(N'2020-06-30T21:57:23.3000921' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 18)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (75, CAST(N'2020-06-30T21:57:23.3000929' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 4)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (76, CAST(N'2020-06-30T21:57:23.3000937' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 9)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (77, CAST(N'2020-06-30T21:57:23.3000944' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 5)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (78, CAST(N'2020-06-30T21:57:23.3000952' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 12)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (79, CAST(N'2020-06-30T21:57:23.3000960' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 22)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (80, CAST(N'2020-06-30T21:57:23.3000968' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 21)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (81, CAST(N'2020-06-30T21:57:23.3000976' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 22)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (82, CAST(N'2020-06-30T21:57:23.3000984' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 9)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (83, CAST(N'2020-06-30T21:57:23.3000991' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 5)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (84, CAST(N'2020-06-30T21:57:23.3000999' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 16)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (85, CAST(N'2020-06-30T21:57:23.3001007' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 7)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (86, CAST(N'2020-06-30T21:57:23.3001014' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 19)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (87, CAST(N'2020-06-30T21:57:23.3001023' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 1)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (88, CAST(N'2020-06-30T21:57:23.3001030' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 12)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (89, CAST(N'2020-06-30T21:57:23.3001038' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 10)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (90, CAST(N'2020-06-30T21:57:23.3001046' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 13)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (91, CAST(N'2020-06-30T21:57:23.3001054' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 3)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (92, CAST(N'2020-06-30T21:57:23.3001061' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 22)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (93, CAST(N'2020-06-30T21:57:23.3001069' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 10)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (94, CAST(N'2020-06-30T21:57:23.3001077' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 22)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (95, CAST(N'2020-06-30T21:57:23.3001085' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 21)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (96, CAST(N'2020-06-30T21:57:23.3001093' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 20)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (97, CAST(N'2020-06-30T21:57:23.3001101' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 17)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (98, CAST(N'2020-06-30T21:57:23.3001108' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 8)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (99, CAST(N'2020-06-30T21:57:23.3001116' AS DateTime2), NULL, NULL, 1, N'In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ', 1, 7)
GO
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (100, CAST(N'2020-07-01T14:30:00.1701175' AS DateTime2), NULL, NULL, 1, N'testing commenting ', 14, 12)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (101, CAST(N'2020-07-01T14:30:44.0858559' AS DateTime2), NULL, NULL, 1, N'This is a beautiful post', 14, 26)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (102, CAST(N'2020-07-01T14:35:37.9668528' AS DateTime2), NULL, NULL, 1, N'ugly ugly ugly ugly ugly ugly', 11, 20)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (103, CAST(N'2020-07-01T14:35:43.0051560' AS DateTime2), NULL, NULL, 1, N'ugly ugly ugly ugly ugly ugly', 11, 17)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (104, CAST(N'2020-07-01T14:35:45.9199186' AS DateTime2), NULL, NULL, 1, N'ugly ugly ugly ugly ugly ugly', 11, 10)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (105, CAST(N'2020-07-01T14:35:57.2601872' AS DateTime2), NULL, NULL, 1, N'ugly ugly ugly ugly ugly ugly', 11, 14)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (106, CAST(N'2020-07-01T14:35:57.9419631' AS DateTime2), NULL, NULL, 1, N'ugly ugly ugly ugly ugly ugly', 11, 14)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (107, CAST(N'2020-07-01T14:36:00.8821928' AS DateTime2), NULL, NULL, 1, N'ugly ugly ugly ugly ugly ugly', 11, 18)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (108, CAST(N'2020-07-01T14:36:03.5976888' AS DateTime2), NULL, NULL, 1, N'ugly ugly ugly ugly ugly ugly', 11, 27)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (109, CAST(N'2020-07-01T14:46:55.6761956' AS DateTime2), NULL, NULL, 1, N'wonderful post indeed', 6, 27)
INSERT [dbo].[Comments] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [CommentText], [UserId], [PostId]) VALUES (110, CAST(N'2020-07-01T14:47:05.0153402' AS DateTime2), CAST(N'2020-07-01T14:47:36.4879853' AS DateTime2), CAST(N'2020-07-01T14:47:36.4878785' AS DateTime2), 0, N'another comment on post', 6, 22)
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
SET IDENTITY_INSERT [dbo].[Posts] ON 

INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (1, CAST(N'2020-06-30T21:57:23.2995985' AS DateTime2), NULL, NULL, 1, N'Post 1', N'post1post1post1post1post1post1post1post1post1post1post1post1post1post1', N'images/1.png', 1, 5)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (2, CAST(N'2020-06-30T21:57:23.2996225' AS DateTime2), NULL, NULL, 1, N'Post 2', N'post2post2post2post2post2post2post2post2post2post2post2', N'images/2.png', 1, 4)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (3, CAST(N'2020-06-30T21:57:23.2996244' AS DateTime2), NULL, NULL, 1, N'Post 3', N'post3post3post3post3post3post3post3', N'images/3.png', 1, 4)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (4, CAST(N'2020-06-30T21:57:23.2996256' AS DateTime2), NULL, NULL, 1, N'Post 4', N'post4post4post4post4post4post4post4post4post4post4', N'images/4.png', 1, 2)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (5, CAST(N'2020-06-30T21:57:23.2996269' AS DateTime2), NULL, NULL, 1, N'Post 5', N'post1post1post1post1post1post1post1post1post1post1post1post1post1post1', N'images/5.png', 1, 1)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (6, CAST(N'2020-06-30T21:57:23.2996292' AS DateTime2), NULL, NULL, 1, N'Post 6', N'post2post2post2post2post2post2post2post2post2', N'images/6.png', 1, 2)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (7, CAST(N'2020-06-30T21:57:23.2996306' AS DateTime2), NULL, NULL, 1, N'Post 7', N'post3post3post3post3post3post3post3', N'images/7.png', 1, 2)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (8, CAST(N'2020-06-30T21:57:23.2996319' AS DateTime2), NULL, NULL, 1, N'Post 8', N'post4post4post4post4post4post4post4post4post4', N'images/8.png', 1, 2)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (9, CAST(N'2020-06-30T21:57:23.2996334' AS DateTime2), NULL, NULL, 1, N'Post 9', N'post1post1post1post1post1post1post1post1', N'images/9.png', 1, 1)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (10, CAST(N'2020-06-30T21:57:23.2996351' AS DateTime2), NULL, NULL, 1, N'Post 10', N'post2post2post2post2post2post2post2post2post2', N'images/10.jpg', 1, 6)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (11, CAST(N'2020-06-30T21:57:23.2996363' AS DateTime2), NULL, NULL, 1, N'Post 11', N'post3post3post3post3post3post3post3', N'images/11.jpg', 1, 4)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (12, CAST(N'2020-06-30T21:57:23.2996376' AS DateTime2), NULL, NULL, 1, N'Post 12', N'post3post3post3post3post3post3post3', N'images/12.jpg', 1, 5)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (13, CAST(N'2020-06-30T21:57:23.2996388' AS DateTime2), NULL, NULL, 1, N'Post 13', N'post1post2post3post4', N'images/13.jpg', 1, 2)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (14, CAST(N'2020-06-30T21:57:23.2996401' AS DateTime2), NULL, NULL, 1, N'Post 14', N'post4post4post431', N'images/14.jpg', 1, 1)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (15, CAST(N'2020-06-30T21:57:23.2996413' AS DateTime2), NULL, NULL, 1, N'Post 15', N'post4post4post431', N'images/15.jpg', 1, 3)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (16, CAST(N'2020-06-30T21:57:23.2996429' AS DateTime2), NULL, NULL, 1, N'Post 16', N'post1post1post2post3', N'images/16.jpg', 1, 5)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (17, CAST(N'2020-06-30T21:57:23.2996441' AS DateTime2), NULL, NULL, 1, N'Post 17', N'post1post1post2post3post2', N'images/17.jpg', 1, 1)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (18, CAST(N'2020-06-30T21:57:23.2996456' AS DateTime2), NULL, NULL, 1, N'Post 18', N'post4post4post4post4post4post4post4', N'images/18.jpg', 1, 1)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (19, CAST(N'2020-06-30T21:57:23.2996467' AS DateTime2), NULL, NULL, 1, N'Post 19', N'post2post2post2post2', N'images/19.jpg', 1, 3)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (20, CAST(N'2020-06-30T21:57:23.2996480' AS DateTime2), NULL, NULL, 1, N'Post 20', N'post12post1post1post1post1', N'images/20.jpg', 1, 4)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (21, CAST(N'2020-06-30T21:57:23.2996493' AS DateTime2), NULL, NULL, 1, N'Post 21', N'post12post1post1post1post4', N'images/21.jpg', 1, 1)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (22, CAST(N'2020-06-30T21:57:23.2996504' AS DateTime2), NULL, NULL, 1, N'Post 22', N'post1post2post3post4', N'images/22.jpg', 1, 2)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (23, CAST(N'2020-06-30T21:57:23.2996601' AS DateTime2), NULL, NULL, 1, N'Post 23', N'post1post2post3post4', N'images/23.jpg', 1, 6)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (24, CAST(N'2020-06-30T21:57:23.2996614' AS DateTime2), NULL, NULL, 1, N'Post 24', N'this is a random content', N'images/24.jpg', 1, 6)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (25, CAST(N'2020-07-01T14:28:29.9863340' AS DateTime2), NULL, NULL, 1, N'Beautiful picture nature', N'some content is required when inserting', N'images/1fabd75f-15dd-4951-ba8e-d07d40d084ed.jpg', 14, 15)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (26, CAST(N'2020-07-01T14:28:59.6434447' AS DateTime2), NULL, NULL, 1, N'Beautiful picture nature awd', N'Lorem ipsum lorem lorem lorem', N'images/eb63702e-9558-4d32-8f8c-351e9b9a1623.jpg', 14, 1)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (27, CAST(N'2020-07-01T14:32:38.9453868' AS DateTime2), NULL, NULL, 1, N'This is my first title', N'Can you rate this post please', N'images/7befb5c5-b570-4ee1-adf3-813ca237aa05.jpg', 11, 21)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (28, CAST(N'2020-07-01T14:33:23.3387121' AS DateTime2), NULL, NULL, 1, N'Town in America', N'Town in America test does this work', N'images/a105a368-da25-42fa-8338-af287469329d.jpg', 11, 18)
INSERT [dbo].[Posts] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Title], [Content], [PhotoPath], [UserId], [TopicId]) VALUES (29, CAST(N'2020-07-01T14:38:48.8787446' AS DateTime2), CAST(N'2020-07-01T14:39:16.3211594' AS DateTime2), CAST(N'2020-07-01T14:39:16.3210525' AS DateTime2), 0, N'Kindergarden', N'THis is a post from kinder', N'images/ec2f9142-266a-469f-b0d5-29df3797a9c6.jpg', 19, 12)
SET IDENTITY_INSERT [dbo].[Posts] OFF
GO
SET IDENTITY_INSERT [dbo].[Ratings] ON 

INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (1, CAST(N'2020-06-30T21:57:23.3005005' AS DateTime2), NULL, NULL, 1, 1, 1, 5)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (2, CAST(N'2020-06-30T21:57:23.3005212' AS DateTime2), NULL, NULL, 1, 2, 2, 2)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (3, CAST(N'2020-07-01T14:11:19.8694627' AS DateTime2), NULL, NULL, 1, 1, 15, 1)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (4, CAST(N'2020-07-01T14:33:43.8980304' AS DateTime2), NULL, NULL, 1, 11, 18, 8)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (5, CAST(N'2020-07-01T14:34:10.4983648' AS DateTime2), NULL, NULL, 1, 11, 19, 4)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (6, CAST(N'2020-07-01T14:34:17.6026479' AS DateTime2), NULL, NULL, 1, 11, 1, 1)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (7, CAST(N'2020-07-01T14:34:44.9768049' AS DateTime2), NULL, NULL, 1, 11, 17, 1)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (8, CAST(N'2020-07-01T14:34:48.7367010' AS DateTime2), NULL, NULL, 1, 11, 10, 1)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (9, CAST(N'2020-07-01T14:34:51.4799505' AS DateTime2), NULL, NULL, 1, 11, 8, 1)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (10, CAST(N'2020-07-01T14:39:43.8647030' AS DateTime2), NULL, NULL, 1, 19, 24, 5)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (11, CAST(N'2020-07-01T14:40:08.5290489' AS DateTime2), NULL, NULL, 1, 19, 20, 5)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (12, CAST(N'2020-07-01T14:40:11.7755204' AS DateTime2), NULL, NULL, 1, 19, 2, 5)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (13, CAST(N'2020-07-01T14:40:18.4422525' AS DateTime2), NULL, NULL, 1, 19, 17, 2)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (14, CAST(N'2020-07-01T14:40:23.2530916' AS DateTime2), NULL, NULL, 1, 19, 8, 7)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (15, CAST(N'2020-07-01T14:45:08.8506513' AS DateTime2), NULL, NULL, 1, 6, 8, 7)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (16, CAST(N'2020-07-01T14:45:15.7142887' AS DateTime2), NULL, NULL, 1, 6, 10, 9)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (17, CAST(N'2020-07-01T14:45:21.1693694' AS DateTime2), NULL, NULL, 1, 6, 11, 4)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (18, CAST(N'2020-07-01T14:45:25.8182027' AS DateTime2), NULL, NULL, 1, 6, 16, 3)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (19, CAST(N'2020-07-01T14:45:31.8985823' AS DateTime2), NULL, NULL, 1, 6, 14, 10)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (20, CAST(N'2020-07-01T14:45:36.9256219' AS DateTime2), NULL, NULL, 1, 6, 3, 10)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (21, CAST(N'2020-07-01T14:45:50.9306187' AS DateTime2), NULL, NULL, 1, 6, 25, 1)
INSERT [dbo].[Ratings] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [PostId], [Value]) VALUES (22, CAST(N'2020-07-01T14:45:59.8337930' AS DateTime2), NULL, NULL, 1, 6, 22, 3)
SET IDENTITY_INSERT [dbo].[Ratings] OFF
GO
SET IDENTITY_INSERT [dbo].[Topics] ON 

INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (1, CAST(N'2020-06-30T21:57:23.2867277' AS DateTime2), NULL, NULL, 1, N'Topic 1')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (2, CAST(N'2020-06-30T21:57:23.2928309' AS DateTime2), NULL, NULL, 1, N'Topic 2')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (3, CAST(N'2020-06-30T21:57:23.2928415' AS DateTime2), NULL, NULL, 1, N'Topic 3')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (4, CAST(N'2020-06-30T21:57:23.2928431' AS DateTime2), NULL, NULL, 1, N'Topic 4')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (5, CAST(N'2020-06-30T21:57:23.2928443' AS DateTime2), NULL, NULL, 1, N'Topic 5')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (6, CAST(N'2020-06-30T21:57:23.2928460' AS DateTime2), NULL, NULL, 1, N'Topic 6')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (7, CAST(N'2020-06-30T21:57:23.2928470' AS DateTime2), NULL, NULL, 1, N'Topic 7')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (8, CAST(N'2020-06-30T21:57:23.2928479' AS DateTime2), NULL, NULL, 1, N'Topic 8')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (9, CAST(N'2020-07-01T14:01:25.1000326' AS DateTime2), NULL, NULL, 1, N'Cars')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (10, CAST(N'2020-07-01T14:01:42.7919882' AS DateTime2), NULL, NULL, 1, N'Vacation')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (11, CAST(N'2020-07-01T14:01:54.7328907' AS DateTime2), NULL, NULL, 1, N'Makeup')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (12, CAST(N'2020-07-01T14:02:07.1244415' AS DateTime2), NULL, NULL, 1, N'Clothes')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (13, CAST(N'2020-07-01T14:02:12.7310048' AS DateTime2), NULL, NULL, 1, N'Sports')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (14, CAST(N'2020-07-01T14:02:20.3804698' AS DateTime2), NULL, NULL, 1, N'Computers')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (15, CAST(N'2020-07-01T14:02:25.0621717' AS DateTime2), NULL, NULL, 1, N'Politics')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (16, CAST(N'2020-07-01T14:02:39.6137778' AS DateTime2), NULL, NULL, 1, N'Health')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (17, CAST(N'2020-07-01T14:02:46.4766139' AS DateTime2), NULL, NULL, 1, N'Insurance')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (18, CAST(N'2020-07-01T14:03:34.5100010' AS DateTime2), NULL, NULL, 1, N'Skola')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (19, CAST(N'2020-07-01T14:03:38.2437224' AS DateTime2), NULL, NULL, 1, N'Nauka')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (20, CAST(N'2020-07-01T14:03:45.3179430' AS DateTime2), CAST(N'2020-07-01T14:06:23.0731974' AS DateTime2), CAST(N'2020-07-01T14:06:23.0731149' AS DateTime2), 0, N'Proba izmena')
INSERT [dbo].[Topics] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [Name]) VALUES (21, CAST(N'2020-07-01T14:04:27.3251288' AS DateTime2), NULL, NULL, 1, N'nocni zivot')
SET IDENTITY_INSERT [dbo].[Topics] OFF
GO
SET IDENTITY_INSERT [dbo].[UseCaseLogs] ON 

INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (1, CAST(N'2020-07-01T11:37:56.5317172' AS DateTime2), 1, N'{"Id":0,"FirstName":"Petar","LastName":"Petrovic","Email":"test@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (2, CAST(N'2020-07-01T11:38:57.1187054' AS DateTime2), 1, N'{"Id":0,"FirstName":"Mitar","LastName":"Petrovic","Email":"test@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (3, CAST(N'2020-07-01T11:40:22.4806071' AS DateTime2), 1, N'{"Id":0,"FirstName":"Mitar","LastName":"Petrovic","Email":"seed1@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (4, CAST(N'2020-07-01T11:41:08.0116590' AS DateTime2), 1, N'{"Id":0,"FirstName":"Natalija","LastName":"Mirkovic","Email":"seed2@outlook.com.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (5, CAST(N'2020-07-01T11:41:29.4610429' AS DateTime2), 1, N'{"Id":0,"FirstName":"Marija","LastName":"Popovic","Email":"seed2@outlook.com.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (6, CAST(N'2020-07-01T11:42:45.8356423' AS DateTime2), 1, N'{"Id":0,"FirstName":"Marija","LastName":"Popovic","Email":"maja@hotmail.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (7, CAST(N'2020-07-01T11:43:09.5973808' AS DateTime2), 1, N'{"Id":0,"FirstName":"Ivan","LastName":"Ivanovic","Email":"ivo@customdomain.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (8, CAST(N'2020-07-01T11:44:19.2542005' AS DateTime2), 1, N'{"Id":0,"FirstName":"Ljiljana","LastName":"Akovic","Email":"ljiljana@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (9, CAST(N'2020-07-01T11:44:49.0460122' AS DateTime2), 1, N'{"Id":0,"FirstName":"Boris","LastName":"Todorovioc","Email":"boris@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (10, CAST(N'2020-07-01T11:45:10.4900390' AS DateTime2), 1, N'{"Id":0,"FirstName":"Boris","LastName":"Todorovioc","Email":"boris@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (11, CAST(N'2020-07-01T11:45:52.1437403' AS DateTime2), 1, N'{"Id":0,"FirstName":"Radoje","LastName":"Tanasijevic","Email":"rade@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (12, CAST(N'2020-07-01T11:47:08.1467542' AS DateTime2), 1, N'{"Id":0,"FirstName":"Igor","LastName":"Nikolic","Email":"gile@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (13, CAST(N'2020-07-01T11:47:33.9247903' AS DateTime2), 1, N'{"Id":0,"FirstName":"Mitar","LastName":"Mitrovic","Email":"mile@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (14, CAST(N'2020-07-01T11:48:09.3336655' AS DateTime2), 1, N'{"Id":0,"FirstName":"Slobodan","LastName":"Baralic","Email":"slobo@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (15, CAST(N'2020-07-01T11:49:09.5004247' AS DateTime2), 1, N'{"Id":0,"FirstName":"Vladislava","LastName":"Orlic","Email":"vlatka@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (16, CAST(N'2020-07-01T11:50:24.7439694' AS DateTime2), 1, N'{"Id":0,"FirstName":"Predrag","LastName":"Jovicic","Email":"pedja@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (17, CAST(N'2020-07-01T11:50:34.5214178' AS DateTime2), 1, N'{"Id":0,"FirstName":"Jelena","LastName":"Calukovic","Email":"pedja@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (18, CAST(N'2020-07-01T11:50:56.3162509' AS DateTime2), 1, N'{"Id":0,"FirstName":"Jelena","LastName":"Calukovic","Email":"jeka@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (19, CAST(N'2020-07-01T11:51:21.7211960' AS DateTime2), 1, N'{"Id":0,"FirstName":"Donald","LastName":"Duck","Email":"donald@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (20, CAST(N'2020-07-01T11:51:39.2360091' AS DateTime2), 1, N'{"Id":0,"FirstName":"Donald","LastName":"Donald","Email":"donald@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (21, CAST(N'2020-07-01T11:51:56.5439168' AS DateTime2), 1, N'{"Id":0,"FirstName":"Michael","LastName":"Jordan","Email":"michael@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (22, CAST(N'2020-07-01T11:52:37.8938064' AS DateTime2), 1, N'{"Id":0,"FirstName":"Sandy","LastName":"Sandy","Email":"sandy@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (23, CAST(N'2020-07-01T11:53:09.5654471' AS DateTime2), 1, N'{"Id":0,"FirstName":"Elon","LastName":"Musk","Email":"elon@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (24, CAST(N'2020-07-01T11:53:42.2316405' AS DateTime2), 1, N'{"Id":0,"FirstName":"Elton","LastName":"Elton","Email":"elon@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (25, CAST(N'2020-07-01T11:54:11.9296379' AS DateTime2), 1, N'{"Id":0,"FirstName":"Another","LastName":"Users","Email":"another@test.com","Password":"Test_123"}', 0)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (26, CAST(N'2020-07-01T12:00:37.4136358' AS DateTime2), 4, N'{"Id":0,"Name":"Cars"}', 3)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (27, CAST(N'2020-07-01T12:01:25.0253985' AS DateTime2), 4, N'{"Id":0,"Name":"Cars"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (28, CAST(N'2020-07-01T12:01:27.7008520' AS DateTime2), 4, N'{"Id":0,"Name":"Cars"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (29, CAST(N'2020-07-01T12:01:42.7833681' AS DateTime2), 4, N'{"Id":0,"Name":"Vacation"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (30, CAST(N'2020-07-01T12:01:54.7167858' AS DateTime2), 4, N'{"Id":0,"Name":"Makeup"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (31, CAST(N'2020-07-01T12:02:07.1195729' AS DateTime2), 4, N'{"Id":0,"Name":"Clothes"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (32, CAST(N'2020-07-01T12:02:12.7215451' AS DateTime2), 4, N'{"Id":0,"Name":"Sports"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (33, CAST(N'2020-07-01T12:02:20.3741329' AS DateTime2), 4, N'{"Id":0,"Name":"Computers"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (34, CAST(N'2020-07-01T12:02:25.0559792' AS DateTime2), 4, N'{"Id":0,"Name":"Politics"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (35, CAST(N'2020-07-01T12:02:39.6093448' AS DateTime2), 4, N'{"Id":0,"Name":"Health"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (36, CAST(N'2020-07-01T12:02:46.4713911' AS DateTime2), 4, N'{"Id":0,"Name":"Insurance"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (37, CAST(N'2020-07-01T12:03:34.4859724' AS DateTime2), 4, N'{"Id":0,"Name":"Skola"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (38, CAST(N'2020-07-01T12:03:38.2394944' AS DateTime2), 4, N'{"Id":0,"Name":"Nauka"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (39, CAST(N'2020-07-01T12:03:45.3102144' AS DateTime2), 4, N'{"Id":0,"Name":"Jos neka tema"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (40, CAST(N'2020-07-01T12:03:48.2826115' AS DateTime2), 4, N'{"Id":0,"Name":"Jos neka tema"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (41, CAST(N'2020-07-01T12:04:27.3099900' AS DateTime2), 4, N'{"Id":0,"Name":"nocni zivot"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (42, CAST(N'2020-07-01T12:04:49.9855232' AS DateTime2), 16, N'{"Topic":null,"PerPage":5,"Page":1}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (43, CAST(N'2020-07-01T12:05:47.7035257' AS DateTime2), 6, N'{"Id":589,"Name":"Proba izmena"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (44, CAST(N'2020-07-01T12:06:00.5144638' AS DateTime2), 6, N'{"Id":20,"Name":"Proba izmena"}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (45, CAST(N'2020-07-01T12:06:23.0565064' AS DateTime2), 5, N'20', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (46, CAST(N'2020-07-01T12:06:26.6875372' AS DateTime2), 5, N'20', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (47, CAST(N'2020-07-01T12:10:45.0883199' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":0,"PostId":15}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (48, CAST(N'2020-07-01T12:11:19.8398530' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":1,"PostId":15}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (49, CAST(N'2020-07-01T12:11:38.1038554' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":1,"PostId":15}', 1)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (50, CAST(N'2020-07-01T12:28:29.9112723' AS DateTime2), 7, N'{"Id":0,"Title":"Beautiful picture nature","Content":"some content is required when inserting","PhotoPath":"images/1fabd75f-15dd-4951-ba8e-d07d40d084ed.jpg","TopicId":15,"UserId":14}', 14)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (51, CAST(N'2020-07-01T12:28:59.6317607' AS DateTime2), 7, N'{"Id":0,"Title":"Beautiful picture nature awd","Content":"Lorem ipsum lorem lorem lorem","PhotoPath":"images/eb63702e-9558-4d32-8f8c-351e9b9a1623.jpg","TopicId":1,"UserId":14}', 14)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (52, CAST(N'2020-07-01T12:30:00.1347964' AS DateTime2), 12, N'{"Id":0,"CommentText":"testing commenting ","PostId":12}', 14)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (53, CAST(N'2020-07-01T12:30:13.1301777' AS DateTime2), 12, N'{"Id":0,"CommentText":"another comment","PostId":1000}', 14)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (54, CAST(N'2020-07-01T12:30:37.2488729' AS DateTime2), 12, N'{"Id":0,"CommentText":"This is a beautiful post","PostId":27}', 14)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (55, CAST(N'2020-07-01T12:30:44.0821479' AS DateTime2), 12, N'{"Id":0,"CommentText":"This is a beautiful post","PostId":26}', 14)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (56, CAST(N'2020-07-01T12:32:17.1851049' AS DateTime2), 7, N'{"Id":0,"Title":"This is my first title","Content":"Can you rate this post please","PhotoPath":"images/15122674-b67f-43ae-b650-5ddcfd818268.jpg","TopicId":20,"UserId":11}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (57, CAST(N'2020-07-01T12:32:38.9126030' AS DateTime2), 7, N'{"Id":0,"Title":"This is my first title","Content":"Can you rate this post please","PhotoPath":"images/7befb5c5-b570-4ee1-adf3-813ca237aa05.jpg","TopicId":21,"UserId":11}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (58, CAST(N'2020-07-01T12:33:04.4903774' AS DateTime2), 7, N'{"Id":0,"Title":"Town in America","Content":"Town in America","PhotoPath":"images/c076874f-d5ed-4410-aae3-98b4de7e9a8c.jpg","TopicId":18,"UserId":11}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (59, CAST(N'2020-07-01T12:33:23.3267595' AS DateTime2), 7, N'{"Id":0,"Title":"Town in America","Content":"Town in America test does this work","PhotoPath":"images/a105a368-da25-42fa-8338-af287469329d.jpg","TopicId":18,"UserId":11}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (60, CAST(N'2020-07-01T12:33:43.8801096' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":8,"PostId":18}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (61, CAST(N'2020-07-01T12:33:44.7681056' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":8,"PostId":18}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (62, CAST(N'2020-07-01T12:34:10.4937597' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":4,"PostId":19}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (63, CAST(N'2020-07-01T12:34:17.5952071' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":1,"PostId":1}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (64, CAST(N'2020-07-01T12:34:19.6235184' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":1,"PostId":1}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (65, CAST(N'2020-07-01T12:34:44.9501583' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":1,"PostId":17}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (66, CAST(N'2020-07-01T12:34:48.7118974' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":1,"PostId":10}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (67, CAST(N'2020-07-01T12:34:51.4653844' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":1,"PostId":8}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (68, CAST(N'2020-07-01T12:35:24.5013697' AS DateTime2), 12, N'{"Id":0,"CommentText":"ugly","PostId":20}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (69, CAST(N'2020-07-01T12:35:37.9623237' AS DateTime2), 12, N'{"Id":0,"CommentText":"ugly ugly ugly ugly ugly ugly","PostId":20}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (70, CAST(N'2020-07-01T12:35:42.9955563' AS DateTime2), 12, N'{"Id":0,"CommentText":"ugly ugly ugly ugly ugly ugly","PostId":17}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (71, CAST(N'2020-07-01T12:35:45.9106679' AS DateTime2), 12, N'{"Id":0,"CommentText":"ugly ugly ugly ugly ugly ugly","PostId":10}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (72, CAST(N'2020-07-01T12:35:57.2504773' AS DateTime2), 12, N'{"Id":0,"CommentText":"ugly ugly ugly ugly ugly ugly","PostId":14}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (73, CAST(N'2020-07-01T12:35:57.9364941' AS DateTime2), 12, N'{"Id":0,"CommentText":"ugly ugly ugly ugly ugly ugly","PostId":14}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (74, CAST(N'2020-07-01T12:36:00.8743194' AS DateTime2), 12, N'{"Id":0,"CommentText":"ugly ugly ugly ugly ugly ugly","PostId":18}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (75, CAST(N'2020-07-01T12:36:03.5927345' AS DateTime2), 12, N'{"Id":0,"CommentText":"ugly ugly ugly ugly ugly ugly","PostId":27}', 11)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (76, CAST(N'2020-07-01T12:37:15.5129804' AS DateTime2), 20, N'{"Comment":null,"UserEmail":null,"PostTitle":null,"PerPage":5,"Page":1}', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (77, CAST(N'2020-07-01T12:37:28.4338281' AS DateTime2), 13, N'15', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (78, CAST(N'2020-07-01T12:38:48.8601366' AS DateTime2), 7, N'{"Id":0,"Title":"Kindergarden","Content":"THis is a post from kinder","PhotoPath":"images/ec2f9142-266a-469f-b0d5-29df3797a9c6.jpg","TopicId":12,"UserId":19}', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (79, CAST(N'2020-07-01T12:39:11.4358716' AS DateTime2), 8, N'29', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (80, CAST(N'2020-07-01T12:39:43.8388566' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":5,"PostId":24}', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (81, CAST(N'2020-07-01T12:39:50.6720186' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":5,"PostId":24}', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (82, CAST(N'2020-07-01T12:39:59.8171281' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":5,"PostId":29}', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (83, CAST(N'2020-07-01T12:40:08.5247590' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":5,"PostId":20}', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (84, CAST(N'2020-07-01T12:40:11.7628811' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":5,"PostId":2}', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (85, CAST(N'2020-07-01T12:40:18.4225131' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":2,"PostId":17}', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (86, CAST(N'2020-07-01T12:40:23.2262543' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":7,"PostId":8}', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (87, CAST(N'2020-07-01T12:42:12.1587232' AS DateTime2), 3, N'{"Id":19,"FirstName":"updated sandy","LastName":"updated","Email":"pedja@test.com","Password":"string"}', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (88, CAST(N'2020-07-01T12:42:22.1854107' AS DateTime2), 3, N'{"Id":20,"FirstName":"updated sandy","LastName":"updated","Email":"pedja@test.com","Password":"string"}', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (89, CAST(N'2020-07-01T12:42:43.7108238' AS DateTime2), 3, N'{"Id":20,"FirstName":"updated sandy","LastName":"updated","Email":"pedja2@test.com","Password":"string"}', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (90, CAST(N'2020-07-01T12:42:55.6896499' AS DateTime2), 3, N'{"Id":19,"FirstName":"updated sandy","LastName":"updated","Email":"sandy2@test.com","Password":"string"}', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (91, CAST(N'2020-07-01T12:43:28.6218308' AS DateTime2), 3, N'{"Id":19,"FirstName":"updated sandy","LastName":"awdawdawd","Email":"sandy2@test.com","Password":"string"}', 19)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (92, CAST(N'2020-07-01T12:45:08.8300818' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":7,"PostId":8}', 6)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (93, CAST(N'2020-07-01T12:45:15.7074194' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":9,"PostId":10}', 6)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (94, CAST(N'2020-07-01T12:45:21.1637256' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":4,"PostId":11}', 6)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (95, CAST(N'2020-07-01T12:45:25.8064327' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":3,"PostId":16}', 6)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (96, CAST(N'2020-07-01T12:45:31.8931780' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":10,"PostId":14}', 6)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (97, CAST(N'2020-07-01T12:45:36.9204285' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":10,"PostId":3}', 6)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (98, CAST(N'2020-07-01T12:45:38.3384962' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":10,"PostId":3}', 6)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (99, CAST(N'2020-07-01T12:45:50.9172502' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":1,"PostId":25}', 6)
GO
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (100, CAST(N'2020-07-01T12:45:59.8278390' AS DateTime2), 10, N'{"Id":0,"UserId":15,"Value":3,"PostId":22}', 6)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (101, CAST(N'2020-07-01T12:46:55.6298230' AS DateTime2), 12, N'{"Id":0,"CommentText":"wonderful post indeed","PostId":27}', 6)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (102, CAST(N'2020-07-01T12:47:05.0118586' AS DateTime2), 12, N'{"Id":0,"CommentText":"another comment on post","PostId":22}', 6)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (103, CAST(N'2020-07-01T12:47:13.5328231' AS DateTime2), 13, N'15', 6)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (104, CAST(N'2020-07-01T12:47:36.4818411' AS DateTime2), 13, N'110', 6)
INSERT [dbo].[UseCaseLogs] ([Id], [Date], [UseCaseId], [Data], [UserId]) VALUES (105, CAST(N'2020-07-01T12:47:45.7996607' AS DateTime2), 20, N'{"Comment":null,"UserEmail":null,"PostTitle":null,"PerPage":20,"Page":6}', 6)
SET IDENTITY_INSERT [dbo].[UseCaseLogs] OFF
GO
SET IDENTITY_INSERT [dbo].[UseCases] ON 

INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (12, N'Create Comment')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (7, N'Create Post')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (10, N'Create Rating')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (4, N'Create Topic')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (26, N'Create UseCase')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (1, N'Create User')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (30, N'Create UserUseCase')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (21, N'Get One Comment')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (19, N'Get One Post')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (25, N'Get One Rating')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (18, N'Get One Topic')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (29, N'Get One UseCase')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (23, N'Get One User')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (20, N'Search Comments')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (17, N'Search Posts')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (24, N'Search Ratings')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (16, N'Search Topics')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (15, N'Search UseCaseLog')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (28, N'Search UseCases')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (22, N'Search Users')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (31, N'Search UserUseCases')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (13, N'Soft Delete Comment')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (8, N'Soft Delete Post')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (5, N'Soft Delete Topic')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (2, N'Soft Delete User')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (14, N'Update Comment')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (9, N'Update Post')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (11, N'Update Rating')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (6, N'Update Topic')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (27, N'Update UseCase')
INSERT [dbo].[UseCases] ([Id], [Name]) VALUES (3, N'Update User')
SET IDENTITY_INSERT [dbo].[UseCases] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (1, CAST(N'2020-06-30T21:57:23.2988945' AS DateTime2), NULL, NULL, 1, N'Admin', N'Admin', N'admin@gmail.com', N'7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (2, CAST(N'2020-06-30T21:57:23.2989305' AS DateTime2), NULL, NULL, 1, N'User', N'User', N'User@gmail.com', N'7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (3, CAST(N'2020-07-01T13:38:04.0406660' AS DateTime2), NULL, NULL, 1, N'Petar', N'Petrovic', N'test@test.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (4, CAST(N'2020-07-01T13:40:22.5267512' AS DateTime2), NULL, NULL, 1, N'Mitar', N'Petrovic', N'seed1@test.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (5, CAST(N'2020-07-01T13:41:08.0460604' AS DateTime2), NULL, NULL, 1, N'Natalija', N'Mirkovic', N'seed2@outlook.com.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (6, CAST(N'2020-07-01T13:42:45.9012461' AS DateTime2), NULL, NULL, 1, N'Marija', N'Popovic', N'maja@hotmail.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (7, CAST(N'2020-07-01T13:43:09.6316682' AS DateTime2), NULL, NULL, 1, N'Ivan', N'Ivanovic', N'ivo@customdomain.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (8, CAST(N'2020-07-01T13:44:19.3025947' AS DateTime2), NULL, NULL, 1, N'Ljiljana', N'Akovic', N'ljiljana@test.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (9, CAST(N'2020-07-01T13:44:49.0691024' AS DateTime2), NULL, NULL, 1, N'Boris', N'Todorovioc', N'boris@test.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (10, CAST(N'2020-07-01T13:45:52.1747288' AS DateTime2), NULL, NULL, 1, N'Radoje', N'Tanasijevic', N'rade@test.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (11, CAST(N'2020-07-01T13:47:08.1806214' AS DateTime2), NULL, NULL, 1, N'Igor', N'Nikolic', N'gile@test.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (12, CAST(N'2020-07-01T13:47:33.9519644' AS DateTime2), NULL, NULL, 1, N'Mitar', N'Mitrovic', N'mile@test.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (13, CAST(N'2020-07-01T13:48:09.3571438' AS DateTime2), NULL, NULL, 1, N'Slobodan', N'Baralic', N'slobo@test.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (14, CAST(N'2020-07-01T13:49:09.5297016' AS DateTime2), NULL, NULL, 1, N'Vladislava', N'Orlic', N'vlatka@test.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (15, CAST(N'2020-07-01T13:50:24.7778812' AS DateTime2), NULL, NULL, 1, N'Predrag', N'Jovicic', N'pedja@test.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (16, CAST(N'2020-07-01T13:50:56.3421022' AS DateTime2), NULL, NULL, 1, N'Jelena', N'Calukovic', N'jeka@test.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (17, CAST(N'2020-07-01T13:51:39.2551646' AS DateTime2), NULL, NULL, 1, N'Donald', N'Donald', N'donald@test.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (18, CAST(N'2020-07-01T13:51:56.5930888' AS DateTime2), NULL, NULL, 1, N'Michael', N'Jordan', N'michael@test.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (19, CAST(N'2020-07-01T13:52:37.9227576' AS DateTime2), CAST(N'2020-07-01T14:43:28.6650073' AS DateTime2), NULL, 1, N'updated sandy', N'awdawdawd', N'sandy2@test.com', N'KtnmthfNE8gojJHQdYBq3ex9kgM8CAQmIYO31v7T+vo=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (20, CAST(N'2020-07-01T13:53:42.2479012' AS DateTime2), NULL, NULL, 1, N'Elton', N'Elton', N'elon@test.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
INSERT [dbo].[Users] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [FirstName], [LastName], [Email], [Password]) VALUES (21, CAST(N'2020-07-01T13:54:11.9577581' AS DateTime2), NULL, NULL, 1, N'Another', N'Users', N'another@test.com', N'BSYkzTQr7y49hi5r76JHlzBg2O9++jrAIdbHkzxB/9U=')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[UserUseCases] ON 

INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (1, CAST(N'2020-06-30T21:57:23.3011568' AS DateTime2), NULL, NULL, 1, 1, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (2, CAST(N'2020-06-30T21:57:23.3011681' AS DateTime2), NULL, NULL, 1, 1, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (3, CAST(N'2020-06-30T21:57:23.3011698' AS DateTime2), NULL, NULL, 1, 1, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (4, CAST(N'2020-06-30T21:57:23.3011705' AS DateTime2), NULL, NULL, 1, 1, 4)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (5, CAST(N'2020-06-30T21:57:23.3011713' AS DateTime2), NULL, NULL, 1, 1, 5)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (6, CAST(N'2020-06-30T21:57:23.3011723' AS DateTime2), NULL, NULL, 1, 1, 6)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (7, CAST(N'2020-06-30T21:57:23.3011731' AS DateTime2), NULL, NULL, 1, 1, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (8, CAST(N'2020-06-30T21:57:23.3011738' AS DateTime2), NULL, NULL, 1, 1, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (9, CAST(N'2020-06-30T21:57:23.3011745' AS DateTime2), NULL, NULL, 1, 1, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (10, CAST(N'2020-06-30T21:57:23.3011820' AS DateTime2), NULL, NULL, 1, 1, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (11, CAST(N'2020-06-30T21:57:23.3011828' AS DateTime2), NULL, NULL, 1, 1, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (12, CAST(N'2020-06-30T21:57:23.3011835' AS DateTime2), NULL, NULL, 1, 1, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (13, CAST(N'2020-06-30T21:57:23.3011842' AS DateTime2), NULL, NULL, 1, 1, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (14, CAST(N'2020-06-30T21:57:23.3011849' AS DateTime2), NULL, NULL, 1, 1, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (15, CAST(N'2020-06-30T21:57:23.3011856' AS DateTime2), NULL, NULL, 1, 1, 15)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (16, CAST(N'2020-06-30T21:57:23.3011863' AS DateTime2), NULL, NULL, 1, 1, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (17, CAST(N'2020-06-30T21:57:23.3011871' AS DateTime2), NULL, NULL, 1, 1, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (18, CAST(N'2020-06-30T21:57:23.3011880' AS DateTime2), NULL, NULL, 1, 1, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (19, CAST(N'2020-06-30T21:57:23.3011887' AS DateTime2), NULL, NULL, 1, 1, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (20, CAST(N'2020-06-30T21:57:23.3011895' AS DateTime2), NULL, NULL, 1, 1, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (21, CAST(N'2020-06-30T21:57:23.3011902' AS DateTime2), NULL, NULL, 1, 1, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (22, CAST(N'2020-06-30T21:57:23.3011909' AS DateTime2), NULL, NULL, 1, 1, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (23, CAST(N'2020-06-30T21:57:23.3011916' AS DateTime2), NULL, NULL, 1, 1, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (24, CAST(N'2020-06-30T21:57:23.3011923' AS DateTime2), NULL, NULL, 1, 1, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (25, CAST(N'2020-06-30T21:57:23.3011930' AS DateTime2), NULL, NULL, 1, 1, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (26, CAST(N'2020-06-30T21:57:23.3011937' AS DateTime2), NULL, NULL, 1, 1, 26)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (27, CAST(N'2020-06-30T21:57:23.3011945' AS DateTime2), NULL, NULL, 1, 1, 27)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (28, CAST(N'2020-06-30T21:57:23.3011952' AS DateTime2), NULL, NULL, 1, 1, 28)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (29, CAST(N'2020-06-30T21:57:23.3011959' AS DateTime2), NULL, NULL, 1, 1, 29)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (30, CAST(N'2020-06-30T21:57:23.3011966' AS DateTime2), NULL, NULL, 1, 1, 30)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (31, CAST(N'2020-06-30T21:57:23.3011973' AS DateTime2), NULL, NULL, 1, 1, 31)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (32, CAST(N'2020-06-30T21:57:23.3011985' AS DateTime2), NULL, NULL, 1, 2, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (33, CAST(N'2020-06-30T21:57:23.3011995' AS DateTime2), NULL, NULL, 1, 2, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (34, CAST(N'2020-06-30T21:57:23.3012003' AS DateTime2), NULL, NULL, 1, 2, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (35, CAST(N'2020-06-30T21:57:23.3012010' AS DateTime2), NULL, NULL, 1, 2, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (36, CAST(N'2020-06-30T21:57:23.3012018' AS DateTime2), NULL, NULL, 1, 2, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (37, CAST(N'2020-06-30T21:57:23.3012028' AS DateTime2), NULL, NULL, 1, 2, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (38, CAST(N'2020-06-30T21:57:23.3012036' AS DateTime2), NULL, NULL, 1, 2, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (39, CAST(N'2020-06-30T21:57:23.3012044' AS DateTime2), NULL, NULL, 1, 2, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (40, CAST(N'2020-06-30T21:57:23.3012052' AS DateTime2), NULL, NULL, 1, 2, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (41, CAST(N'2020-06-30T21:57:23.3012062' AS DateTime2), NULL, NULL, 1, 2, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (42, CAST(N'2020-06-30T21:57:23.3012069' AS DateTime2), NULL, NULL, 1, 2, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (43, CAST(N'2020-06-30T21:57:23.3012077' AS DateTime2), NULL, NULL, 1, 2, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (44, CAST(N'2020-06-30T21:57:23.3012085' AS DateTime2), NULL, NULL, 1, 2, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (45, CAST(N'2020-06-30T21:57:23.3012094' AS DateTime2), NULL, NULL, 1, 2, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (46, CAST(N'2020-06-30T21:57:23.3012101' AS DateTime2), NULL, NULL, 1, 2, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (47, CAST(N'2020-06-30T21:57:23.3012109' AS DateTime2), NULL, NULL, 1, 2, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (48, CAST(N'2020-06-30T21:57:23.3012117' AS DateTime2), NULL, NULL, 1, 2, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (49, CAST(N'2020-06-30T21:57:23.3012127' AS DateTime2), NULL, NULL, 1, 2, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (50, CAST(N'2020-06-30T21:57:23.3012135' AS DateTime2), NULL, NULL, 1, 2, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (51, CAST(N'2020-06-30T21:57:23.3012143' AS DateTime2), NULL, NULL, 1, 2, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (52, CAST(N'2020-07-01T13:38:04.1278400' AS DateTime2), NULL, NULL, 1, 3, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (53, CAST(N'2020-07-01T13:38:04.1278672' AS DateTime2), NULL, NULL, 1, 3, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (54, CAST(N'2020-07-01T13:38:04.1278663' AS DateTime2), NULL, NULL, 1, 3, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (55, CAST(N'2020-07-01T13:38:04.1278655' AS DateTime2), NULL, NULL, 1, 3, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (56, CAST(N'2020-07-01T13:38:04.1278646' AS DateTime2), NULL, NULL, 1, 3, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (57, CAST(N'2020-07-01T13:38:04.1278638' AS DateTime2), NULL, NULL, 1, 3, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (58, CAST(N'2020-07-01T13:38:04.1278629' AS DateTime2), NULL, NULL, 1, 3, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (59, CAST(N'2020-07-01T13:38:04.1278620' AS DateTime2), NULL, NULL, 1, 3, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (60, CAST(N'2020-07-01T13:38:04.1278611' AS DateTime2), NULL, NULL, 1, 3, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (61, CAST(N'2020-07-01T13:38:04.1278680' AS DateTime2), NULL, NULL, 1, 3, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (62, CAST(N'2020-07-01T13:38:04.1278603' AS DateTime2), NULL, NULL, 1, 3, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (63, CAST(N'2020-07-01T13:38:04.1278585' AS DateTime2), NULL, NULL, 1, 3, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (64, CAST(N'2020-07-01T13:38:04.1278576' AS DateTime2), NULL, NULL, 1, 3, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (65, CAST(N'2020-07-01T13:38:04.1278567' AS DateTime2), NULL, NULL, 1, 3, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (66, CAST(N'2020-07-01T13:38:04.1278558' AS DateTime2), NULL, NULL, 1, 3, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (67, CAST(N'2020-07-01T13:38:04.1278545' AS DateTime2), NULL, NULL, 1, 3, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (68, CAST(N'2020-07-01T13:38:04.1278536' AS DateTime2), NULL, NULL, 1, 3, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (69, CAST(N'2020-07-01T13:38:04.1278526' AS DateTime2), NULL, NULL, 1, 3, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (70, CAST(N'2020-07-01T13:38:04.1278516' AS DateTime2), NULL, NULL, 1, 3, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (71, CAST(N'2020-07-01T13:38:04.1278593' AS DateTime2), NULL, NULL, 1, 3, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (72, CAST(N'2020-07-01T13:38:04.1278689' AS DateTime2), NULL, NULL, 1, 3, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (73, CAST(N'2020-07-01T13:40:22.5352684' AS DateTime2), NULL, NULL, 1, 4, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (74, CAST(N'2020-07-01T13:40:22.5353375' AS DateTime2), NULL, NULL, 1, 4, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (75, CAST(N'2020-07-01T13:40:22.5353366' AS DateTime2), NULL, NULL, 1, 4, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (76, CAST(N'2020-07-01T13:40:22.5353357' AS DateTime2), NULL, NULL, 1, 4, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (77, CAST(N'2020-07-01T13:40:22.5353349' AS DateTime2), NULL, NULL, 1, 4, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (78, CAST(N'2020-07-01T13:40:22.5353340' AS DateTime2), NULL, NULL, 1, 4, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (79, CAST(N'2020-07-01T13:40:22.5353332' AS DateTime2), NULL, NULL, 1, 4, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (80, CAST(N'2020-07-01T13:40:22.5353322' AS DateTime2), NULL, NULL, 1, 4, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (81, CAST(N'2020-07-01T13:40:22.5352920' AS DateTime2), NULL, NULL, 1, 4, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (82, CAST(N'2020-07-01T13:40:22.5353383' AS DateTime2), NULL, NULL, 1, 4, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (83, CAST(N'2020-07-01T13:40:22.5352910' AS DateTime2), NULL, NULL, 1, 4, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (84, CAST(N'2020-07-01T13:40:22.5352894' AS DateTime2), NULL, NULL, 1, 4, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (85, CAST(N'2020-07-01T13:40:22.5352885' AS DateTime2), NULL, NULL, 1, 4, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (86, CAST(N'2020-07-01T13:40:22.5352877' AS DateTime2), NULL, NULL, 1, 4, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (87, CAST(N'2020-07-01T13:40:22.5352868' AS DateTime2), NULL, NULL, 1, 4, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (88, CAST(N'2020-07-01T13:40:22.5352859' AS DateTime2), NULL, NULL, 1, 4, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (89, CAST(N'2020-07-01T13:40:22.5352850' AS DateTime2), NULL, NULL, 1, 4, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (90, CAST(N'2020-07-01T13:40:22.5352840' AS DateTime2), NULL, NULL, 1, 4, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (91, CAST(N'2020-07-01T13:40:22.5352830' AS DateTime2), NULL, NULL, 1, 4, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (92, CAST(N'2020-07-01T13:40:22.5352902' AS DateTime2), NULL, NULL, 1, 4, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (93, CAST(N'2020-07-01T13:40:22.5353392' AS DateTime2), NULL, NULL, 1, 4, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (94, CAST(N'2020-07-01T13:41:08.0589812' AS DateTime2), NULL, NULL, 1, 5, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (95, CAST(N'2020-07-01T13:41:08.0590536' AS DateTime2), NULL, NULL, 1, 5, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (96, CAST(N'2020-07-01T13:41:08.0590526' AS DateTime2), NULL, NULL, 1, 5, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (97, CAST(N'2020-07-01T13:41:08.0590489' AS DateTime2), NULL, NULL, 1, 5, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (98, CAST(N'2020-07-01T13:41:08.0590480' AS DateTime2), NULL, NULL, 1, 5, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (99, CAST(N'2020-07-01T13:41:08.0590469' AS DateTime2), NULL, NULL, 1, 5, 19)
GO
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (100, CAST(N'2020-07-01T13:41:08.0590460' AS DateTime2), NULL, NULL, 1, 5, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (101, CAST(N'2020-07-01T13:41:08.0590450' AS DateTime2), NULL, NULL, 1, 5, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (102, CAST(N'2020-07-01T13:41:08.0590440' AS DateTime2), NULL, NULL, 1, 5, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (103, CAST(N'2020-07-01T13:41:08.0590546' AS DateTime2), NULL, NULL, 1, 5, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (104, CAST(N'2020-07-01T13:41:08.0590429' AS DateTime2), NULL, NULL, 1, 5, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (105, CAST(N'2020-07-01T13:41:08.0590408' AS DateTime2), NULL, NULL, 1, 5, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (106, CAST(N'2020-07-01T13:41:08.0590398' AS DateTime2), NULL, NULL, 1, 5, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (107, CAST(N'2020-07-01T13:41:08.0590387' AS DateTime2), NULL, NULL, 1, 5, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (108, CAST(N'2020-07-01T13:41:08.0590372' AS DateTime2), NULL, NULL, 1, 5, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (109, CAST(N'2020-07-01T13:41:08.0590361' AS DateTime2), NULL, NULL, 1, 5, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (110, CAST(N'2020-07-01T13:41:08.0590338' AS DateTime2), NULL, NULL, 1, 5, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (111, CAST(N'2020-07-01T13:41:08.0589975' AS DateTime2), NULL, NULL, 1, 5, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (112, CAST(N'2020-07-01T13:41:08.0589963' AS DateTime2), NULL, NULL, 1, 5, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (113, CAST(N'2020-07-01T13:41:08.0590419' AS DateTime2), NULL, NULL, 1, 5, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (114, CAST(N'2020-07-01T13:41:08.0590555' AS DateTime2), NULL, NULL, 1, 5, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (115, CAST(N'2020-07-01T13:42:45.9342170' AS DateTime2), NULL, NULL, 1, 6, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (116, CAST(N'2020-07-01T13:42:45.9342722' AS DateTime2), NULL, NULL, 1, 6, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (117, CAST(N'2020-07-01T13:42:45.9342713' AS DateTime2), NULL, NULL, 1, 6, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (118, CAST(N'2020-07-01T13:42:45.9342705' AS DateTime2), NULL, NULL, 1, 6, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (119, CAST(N'2020-07-01T13:42:45.9342696' AS DateTime2), NULL, NULL, 1, 6, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (120, CAST(N'2020-07-01T13:42:45.9342688' AS DateTime2), NULL, NULL, 1, 6, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (121, CAST(N'2020-07-01T13:42:45.9342679' AS DateTime2), NULL, NULL, 1, 6, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (122, CAST(N'2020-07-01T13:42:45.9342671' AS DateTime2), NULL, NULL, 1, 6, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (123, CAST(N'2020-07-01T13:42:45.9342662' AS DateTime2), NULL, NULL, 1, 6, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (124, CAST(N'2020-07-01T13:42:45.9342730' AS DateTime2), NULL, NULL, 1, 6, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (125, CAST(N'2020-07-01T13:42:45.9342654' AS DateTime2), NULL, NULL, 1, 6, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (126, CAST(N'2020-07-01T13:42:45.9342637' AS DateTime2), NULL, NULL, 1, 6, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (127, CAST(N'2020-07-01T13:42:45.9342629' AS DateTime2), NULL, NULL, 1, 6, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (128, CAST(N'2020-07-01T13:42:45.9342620' AS DateTime2), NULL, NULL, 1, 6, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (129, CAST(N'2020-07-01T13:42:45.9342611' AS DateTime2), NULL, NULL, 1, 6, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (130, CAST(N'2020-07-01T13:42:45.9342600' AS DateTime2), NULL, NULL, 1, 6, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (131, CAST(N'2020-07-01T13:42:45.9342592' AS DateTime2), NULL, NULL, 1, 6, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (132, CAST(N'2020-07-01T13:42:45.9342582' AS DateTime2), NULL, NULL, 1, 6, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (133, CAST(N'2020-07-01T13:42:45.9342572' AS DateTime2), NULL, NULL, 1, 6, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (134, CAST(N'2020-07-01T13:42:45.9342645' AS DateTime2), NULL, NULL, 1, 6, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (135, CAST(N'2020-07-01T13:42:45.9342738' AS DateTime2), NULL, NULL, 1, 6, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (136, CAST(N'2020-07-01T13:43:09.6456679' AS DateTime2), NULL, NULL, 1, 7, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (137, CAST(N'2020-07-01T13:43:09.6456953' AS DateTime2), NULL, NULL, 1, 7, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (138, CAST(N'2020-07-01T13:43:09.6456945' AS DateTime2), NULL, NULL, 1, 7, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (139, CAST(N'2020-07-01T13:43:09.6456936' AS DateTime2), NULL, NULL, 1, 7, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (140, CAST(N'2020-07-01T13:43:09.6456928' AS DateTime2), NULL, NULL, 1, 7, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (141, CAST(N'2020-07-01T13:43:09.6456920' AS DateTime2), NULL, NULL, 1, 7, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (142, CAST(N'2020-07-01T13:43:09.6456911' AS DateTime2), NULL, NULL, 1, 7, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (143, CAST(N'2020-07-01T13:43:09.6456903' AS DateTime2), NULL, NULL, 1, 7, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (144, CAST(N'2020-07-01T13:43:09.6456895' AS DateTime2), NULL, NULL, 1, 7, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (145, CAST(N'2020-07-01T13:43:09.6456961' AS DateTime2), NULL, NULL, 1, 7, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (146, CAST(N'2020-07-01T13:43:09.6456886' AS DateTime2), NULL, NULL, 1, 7, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (147, CAST(N'2020-07-01T13:43:09.6456870' AS DateTime2), NULL, NULL, 1, 7, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (148, CAST(N'2020-07-01T13:43:09.6456861' AS DateTime2), NULL, NULL, 1, 7, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (149, CAST(N'2020-07-01T13:43:09.6456853' AS DateTime2), NULL, NULL, 1, 7, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (150, CAST(N'2020-07-01T13:43:09.6456845' AS DateTime2), NULL, NULL, 1, 7, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (151, CAST(N'2020-07-01T13:43:09.6456837' AS DateTime2), NULL, NULL, 1, 7, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (152, CAST(N'2020-07-01T13:43:09.6456828' AS DateTime2), NULL, NULL, 1, 7, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (153, CAST(N'2020-07-01T13:43:09.6456819' AS DateTime2), NULL, NULL, 1, 7, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (154, CAST(N'2020-07-01T13:43:09.6456809' AS DateTime2), NULL, NULL, 1, 7, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (155, CAST(N'2020-07-01T13:43:09.6456878' AS DateTime2), NULL, NULL, 1, 7, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (156, CAST(N'2020-07-01T13:43:09.6456970' AS DateTime2), NULL, NULL, 1, 7, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (157, CAST(N'2020-07-01T13:44:19.3469397' AS DateTime2), NULL, NULL, 1, 8, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (158, CAST(N'2020-07-01T13:44:19.3472936' AS DateTime2), NULL, NULL, 1, 8, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (159, CAST(N'2020-07-01T13:44:19.3472796' AS DateTime2), NULL, NULL, 1, 8, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (160, CAST(N'2020-07-01T13:44:19.3472688' AS DateTime2), NULL, NULL, 1, 8, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (161, CAST(N'2020-07-01T13:44:19.3472575' AS DateTime2), NULL, NULL, 1, 8, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (162, CAST(N'2020-07-01T13:44:19.3472463' AS DateTime2), NULL, NULL, 1, 8, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (163, CAST(N'2020-07-01T13:44:19.3472352' AS DateTime2), NULL, NULL, 1, 8, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (164, CAST(N'2020-07-01T13:44:19.3472240' AS DateTime2), NULL, NULL, 1, 8, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (165, CAST(N'2020-07-01T13:44:19.3472072' AS DateTime2), NULL, NULL, 1, 8, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (166, CAST(N'2020-07-01T13:44:19.3473032' AS DateTime2), NULL, NULL, 1, 8, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (167, CAST(N'2020-07-01T13:44:19.3471954' AS DateTime2), NULL, NULL, 1, 8, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (168, CAST(N'2020-07-01T13:44:19.3471546' AS DateTime2), NULL, NULL, 1, 8, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (169, CAST(N'2020-07-01T13:44:19.3471365' AS DateTime2), NULL, NULL, 1, 8, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (170, CAST(N'2020-07-01T13:44:19.3471182' AS DateTime2), NULL, NULL, 1, 8, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (171, CAST(N'2020-07-01T13:44:19.3470995' AS DateTime2), NULL, NULL, 1, 8, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (172, CAST(N'2020-07-01T13:44:19.3470817' AS DateTime2), NULL, NULL, 1, 8, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (173, CAST(N'2020-07-01T13:44:19.3470633' AS DateTime2), NULL, NULL, 1, 8, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (174, CAST(N'2020-07-01T13:44:19.3470410' AS DateTime2), NULL, NULL, 1, 8, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (175, CAST(N'2020-07-01T13:44:19.3469955' AS DateTime2), NULL, NULL, 1, 8, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (176, CAST(N'2020-07-01T13:44:19.3471725' AS DateTime2), NULL, NULL, 1, 8, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (177, CAST(N'2020-07-01T13:44:19.3473126' AS DateTime2), NULL, NULL, 1, 8, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (178, CAST(N'2020-07-01T13:44:49.0735135' AS DateTime2), NULL, NULL, 1, 9, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (179, CAST(N'2020-07-01T13:44:49.0735377' AS DateTime2), NULL, NULL, 1, 9, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (180, CAST(N'2020-07-01T13:44:49.0735368' AS DateTime2), NULL, NULL, 1, 9, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (181, CAST(N'2020-07-01T13:44:49.0735361' AS DateTime2), NULL, NULL, 1, 9, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (182, CAST(N'2020-07-01T13:44:49.0735353' AS DateTime2), NULL, NULL, 1, 9, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (183, CAST(N'2020-07-01T13:44:49.0735346' AS DateTime2), NULL, NULL, 1, 9, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (184, CAST(N'2020-07-01T13:44:49.0735338' AS DateTime2), NULL, NULL, 1, 9, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (185, CAST(N'2020-07-01T13:44:49.0735331' AS DateTime2), NULL, NULL, 1, 9, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (186, CAST(N'2020-07-01T13:44:49.0735324' AS DateTime2), NULL, NULL, 1, 9, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (187, CAST(N'2020-07-01T13:44:49.0735384' AS DateTime2), NULL, NULL, 1, 9, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (188, CAST(N'2020-07-01T13:44:49.0735317' AS DateTime2), NULL, NULL, 1, 9, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (189, CAST(N'2020-07-01T13:44:49.0735303' AS DateTime2), NULL, NULL, 1, 9, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (190, CAST(N'2020-07-01T13:44:49.0735296' AS DateTime2), NULL, NULL, 1, 9, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (191, CAST(N'2020-07-01T13:44:49.0735289' AS DateTime2), NULL, NULL, 1, 9, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (192, CAST(N'2020-07-01T13:44:49.0735281' AS DateTime2), NULL, NULL, 1, 9, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (193, CAST(N'2020-07-01T13:44:49.0735274' AS DateTime2), NULL, NULL, 1, 9, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (194, CAST(N'2020-07-01T13:44:49.0735267' AS DateTime2), NULL, NULL, 1, 9, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (195, CAST(N'2020-07-01T13:44:49.0735260' AS DateTime2), NULL, NULL, 1, 9, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (196, CAST(N'2020-07-01T13:44:49.0735252' AS DateTime2), NULL, NULL, 1, 9, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (197, CAST(N'2020-07-01T13:44:49.0735310' AS DateTime2), NULL, NULL, 1, 9, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (198, CAST(N'2020-07-01T13:44:49.0735391' AS DateTime2), NULL, NULL, 1, 9, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (199, CAST(N'2020-07-01T13:45:52.1896889' AS DateTime2), NULL, NULL, 1, 10, 1)
GO
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (200, CAST(N'2020-07-01T13:45:52.1897128' AS DateTime2), NULL, NULL, 1, 10, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (201, CAST(N'2020-07-01T13:45:52.1897121' AS DateTime2), NULL, NULL, 1, 10, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (202, CAST(N'2020-07-01T13:45:52.1897113' AS DateTime2), NULL, NULL, 1, 10, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (203, CAST(N'2020-07-01T13:45:52.1897105' AS DateTime2), NULL, NULL, 1, 10, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (204, CAST(N'2020-07-01T13:45:52.1897098' AS DateTime2), NULL, NULL, 1, 10, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (205, CAST(N'2020-07-01T13:45:52.1897091' AS DateTime2), NULL, NULL, 1, 10, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (206, CAST(N'2020-07-01T13:45:52.1897083' AS DateTime2), NULL, NULL, 1, 10, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (207, CAST(N'2020-07-01T13:45:52.1897076' AS DateTime2), NULL, NULL, 1, 10, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (208, CAST(N'2020-07-01T13:45:52.1897134' AS DateTime2), NULL, NULL, 1, 10, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (209, CAST(N'2020-07-01T13:45:52.1897069' AS DateTime2), NULL, NULL, 1, 10, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (210, CAST(N'2020-07-01T13:45:52.1897053' AS DateTime2), NULL, NULL, 1, 10, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (211, CAST(N'2020-07-01T13:45:52.1897046' AS DateTime2), NULL, NULL, 1, 10, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (212, CAST(N'2020-07-01T13:45:52.1897039' AS DateTime2), NULL, NULL, 1, 10, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (213, CAST(N'2020-07-01T13:45:52.1897030' AS DateTime2), NULL, NULL, 1, 10, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (214, CAST(N'2020-07-01T13:45:52.1897023' AS DateTime2), NULL, NULL, 1, 10, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (215, CAST(N'2020-07-01T13:45:52.1897014' AS DateTime2), NULL, NULL, 1, 10, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (216, CAST(N'2020-07-01T13:45:52.1897007' AS DateTime2), NULL, NULL, 1, 10, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (217, CAST(N'2020-07-01T13:45:52.1896998' AS DateTime2), NULL, NULL, 1, 10, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (218, CAST(N'2020-07-01T13:45:52.1897061' AS DateTime2), NULL, NULL, 1, 10, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (219, CAST(N'2020-07-01T13:45:52.1897141' AS DateTime2), NULL, NULL, 1, 10, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (220, CAST(N'2020-07-01T13:47:08.1881796' AS DateTime2), NULL, NULL, 1, 11, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (221, CAST(N'2020-07-01T13:47:08.1882000' AS DateTime2), NULL, NULL, 1, 11, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (222, CAST(N'2020-07-01T13:47:08.1881993' AS DateTime2), NULL, NULL, 1, 11, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (223, CAST(N'2020-07-01T13:47:08.1881986' AS DateTime2), NULL, NULL, 1, 11, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (224, CAST(N'2020-07-01T13:47:08.1881978' AS DateTime2), NULL, NULL, 1, 11, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (225, CAST(N'2020-07-01T13:47:08.1881954' AS DateTime2), NULL, NULL, 1, 11, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (226, CAST(N'2020-07-01T13:47:08.1881945' AS DateTime2), NULL, NULL, 1, 11, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (227, CAST(N'2020-07-01T13:47:08.1881938' AS DateTime2), NULL, NULL, 1, 11, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (228, CAST(N'2020-07-01T13:47:08.1881931' AS DateTime2), NULL, NULL, 1, 11, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (229, CAST(N'2020-07-01T13:47:08.1882007' AS DateTime2), NULL, NULL, 1, 11, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (230, CAST(N'2020-07-01T13:47:08.1881924' AS DateTime2), NULL, NULL, 1, 11, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (231, CAST(N'2020-07-01T13:47:08.1881910' AS DateTime2), NULL, NULL, 1, 11, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (232, CAST(N'2020-07-01T13:47:08.1881902' AS DateTime2), NULL, NULL, 1, 11, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (233, CAST(N'2020-07-01T13:47:08.1881895' AS DateTime2), NULL, NULL, 1, 11, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (234, CAST(N'2020-07-01T13:47:08.1881888' AS DateTime2), NULL, NULL, 1, 11, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (235, CAST(N'2020-07-01T13:47:08.1881881' AS DateTime2), NULL, NULL, 1, 11, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (236, CAST(N'2020-07-01T13:47:08.1881874' AS DateTime2), NULL, NULL, 1, 11, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (237, CAST(N'2020-07-01T13:47:08.1881866' AS DateTime2), NULL, NULL, 1, 11, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (238, CAST(N'2020-07-01T13:47:08.1881858' AS DateTime2), NULL, NULL, 1, 11, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (239, CAST(N'2020-07-01T13:47:08.1881917' AS DateTime2), NULL, NULL, 1, 11, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (240, CAST(N'2020-07-01T13:47:08.1882015' AS DateTime2), NULL, NULL, 1, 11, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (241, CAST(N'2020-07-01T13:47:33.9633275' AS DateTime2), NULL, NULL, 1, 12, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (242, CAST(N'2020-07-01T13:47:33.9633461' AS DateTime2), NULL, NULL, 1, 12, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (243, CAST(N'2020-07-01T13:47:33.9633454' AS DateTime2), NULL, NULL, 1, 12, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (244, CAST(N'2020-07-01T13:47:33.9633447' AS DateTime2), NULL, NULL, 1, 12, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (245, CAST(N'2020-07-01T13:47:33.9633440' AS DateTime2), NULL, NULL, 1, 12, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (246, CAST(N'2020-07-01T13:47:33.9633433' AS DateTime2), NULL, NULL, 1, 12, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (247, CAST(N'2020-07-01T13:47:33.9633426' AS DateTime2), NULL, NULL, 1, 12, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (248, CAST(N'2020-07-01T13:47:33.9633420' AS DateTime2), NULL, NULL, 1, 12, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (249, CAST(N'2020-07-01T13:47:33.9633413' AS DateTime2), NULL, NULL, 1, 12, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (250, CAST(N'2020-07-01T13:47:33.9633468' AS DateTime2), NULL, NULL, 1, 12, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (251, CAST(N'2020-07-01T13:47:33.9633406' AS DateTime2), NULL, NULL, 1, 12, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (252, CAST(N'2020-07-01T13:47:33.9633392' AS DateTime2), NULL, NULL, 1, 12, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (253, CAST(N'2020-07-01T13:47:33.9633385' AS DateTime2), NULL, NULL, 1, 12, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (254, CAST(N'2020-07-01T13:47:33.9633378' AS DateTime2), NULL, NULL, 1, 12, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (255, CAST(N'2020-07-01T13:47:33.9633371' AS DateTime2), NULL, NULL, 1, 12, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (256, CAST(N'2020-07-01T13:47:33.9633364' AS DateTime2), NULL, NULL, 1, 12, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (257, CAST(N'2020-07-01T13:47:33.9633356' AS DateTime2), NULL, NULL, 1, 12, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (258, CAST(N'2020-07-01T13:47:33.9633349' AS DateTime2), NULL, NULL, 1, 12, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (259, CAST(N'2020-07-01T13:47:33.9633341' AS DateTime2), NULL, NULL, 1, 12, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (260, CAST(N'2020-07-01T13:47:33.9633399' AS DateTime2), NULL, NULL, 1, 12, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (261, CAST(N'2020-07-01T13:47:33.9633475' AS DateTime2), NULL, NULL, 1, 12, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (262, CAST(N'2020-07-01T13:48:09.3618856' AS DateTime2), NULL, NULL, 1, 13, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (263, CAST(N'2020-07-01T13:48:09.3619690' AS DateTime2), NULL, NULL, 1, 13, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (264, CAST(N'2020-07-01T13:48:09.3619683' AS DateTime2), NULL, NULL, 1, 13, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (265, CAST(N'2020-07-01T13:48:09.3619676' AS DateTime2), NULL, NULL, 1, 13, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (266, CAST(N'2020-07-01T13:48:09.3619669' AS DateTime2), NULL, NULL, 1, 13, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (267, CAST(N'2020-07-01T13:48:09.3619662' AS DateTime2), NULL, NULL, 1, 13, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (268, CAST(N'2020-07-01T13:48:09.3619655' AS DateTime2), NULL, NULL, 1, 13, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (269, CAST(N'2020-07-01T13:48:09.3619648' AS DateTime2), NULL, NULL, 1, 13, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (270, CAST(N'2020-07-01T13:48:09.3619638' AS DateTime2), NULL, NULL, 1, 13, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (271, CAST(N'2020-07-01T13:48:09.3619697' AS DateTime2), NULL, NULL, 1, 13, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (272, CAST(N'2020-07-01T13:48:09.3618989' AS DateTime2), NULL, NULL, 1, 13, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (273, CAST(N'2020-07-01T13:48:09.3618975' AS DateTime2), NULL, NULL, 1, 13, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (274, CAST(N'2020-07-01T13:48:09.3618968' AS DateTime2), NULL, NULL, 1, 13, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (275, CAST(N'2020-07-01T13:48:09.3618961' AS DateTime2), NULL, NULL, 1, 13, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (276, CAST(N'2020-07-01T13:48:09.3618954' AS DateTime2), NULL, NULL, 1, 13, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (277, CAST(N'2020-07-01T13:48:09.3618947' AS DateTime2), NULL, NULL, 1, 13, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (278, CAST(N'2020-07-01T13:48:09.3618941' AS DateTime2), NULL, NULL, 1, 13, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (279, CAST(N'2020-07-01T13:48:09.3618933' AS DateTime2), NULL, NULL, 1, 13, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (280, CAST(N'2020-07-01T13:48:09.3618924' AS DateTime2), NULL, NULL, 1, 13, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (281, CAST(N'2020-07-01T13:48:09.3618982' AS DateTime2), NULL, NULL, 1, 13, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (282, CAST(N'2020-07-01T13:48:09.3619704' AS DateTime2), NULL, NULL, 1, 13, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (283, CAST(N'2020-07-01T13:49:09.5372774' AS DateTime2), NULL, NULL, 1, 14, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (284, CAST(N'2020-07-01T13:49:09.5372994' AS DateTime2), NULL, NULL, 1, 14, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (285, CAST(N'2020-07-01T13:49:09.5372987' AS DateTime2), NULL, NULL, 1, 14, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (286, CAST(N'2020-07-01T13:49:09.5372980' AS DateTime2), NULL, NULL, 1, 14, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (287, CAST(N'2020-07-01T13:49:09.5372973' AS DateTime2), NULL, NULL, 1, 14, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (288, CAST(N'2020-07-01T13:49:09.5372966' AS DateTime2), NULL, NULL, 1, 14, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (289, CAST(N'2020-07-01T13:49:09.5372959' AS DateTime2), NULL, NULL, 1, 14, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (290, CAST(N'2020-07-01T13:49:09.5372952' AS DateTime2), NULL, NULL, 1, 14, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (291, CAST(N'2020-07-01T13:49:09.5372945' AS DateTime2), NULL, NULL, 1, 14, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (292, CAST(N'2020-07-01T13:49:09.5373001' AS DateTime2), NULL, NULL, 1, 14, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (293, CAST(N'2020-07-01T13:49:09.5372938' AS DateTime2), NULL, NULL, 1, 14, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (294, CAST(N'2020-07-01T13:49:09.5372923' AS DateTime2), NULL, NULL, 1, 14, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (295, CAST(N'2020-07-01T13:49:09.5372916' AS DateTime2), NULL, NULL, 1, 14, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (296, CAST(N'2020-07-01T13:49:09.5372909' AS DateTime2), NULL, NULL, 1, 14, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (297, CAST(N'2020-07-01T13:49:09.5372901' AS DateTime2), NULL, NULL, 1, 14, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (298, CAST(N'2020-07-01T13:49:09.5372893' AS DateTime2), NULL, NULL, 1, 14, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (299, CAST(N'2020-07-01T13:49:09.5372885' AS DateTime2), NULL, NULL, 1, 14, 7)
GO
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (300, CAST(N'2020-07-01T13:49:09.5372878' AS DateTime2), NULL, NULL, 1, 14, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (301, CAST(N'2020-07-01T13:49:09.5372870' AS DateTime2), NULL, NULL, 1, 14, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (302, CAST(N'2020-07-01T13:49:09.5372931' AS DateTime2), NULL, NULL, 1, 14, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (303, CAST(N'2020-07-01T13:49:09.5373008' AS DateTime2), NULL, NULL, 1, 14, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (304, CAST(N'2020-07-01T13:50:24.7867179' AS DateTime2), NULL, NULL, 1, 15, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (305, CAST(N'2020-07-01T13:50:24.7867425' AS DateTime2), NULL, NULL, 1, 15, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (306, CAST(N'2020-07-01T13:50:24.7867418' AS DateTime2), NULL, NULL, 1, 15, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (307, CAST(N'2020-07-01T13:50:24.7867411' AS DateTime2), NULL, NULL, 1, 15, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (308, CAST(N'2020-07-01T13:50:24.7867403' AS DateTime2), NULL, NULL, 1, 15, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (309, CAST(N'2020-07-01T13:50:24.7867395' AS DateTime2), NULL, NULL, 1, 15, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (310, CAST(N'2020-07-01T13:50:24.7867388' AS DateTime2), NULL, NULL, 1, 15, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (311, CAST(N'2020-07-01T13:50:24.7867381' AS DateTime2), NULL, NULL, 1, 15, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (312, CAST(N'2020-07-01T13:50:24.7867374' AS DateTime2), NULL, NULL, 1, 15, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (313, CAST(N'2020-07-01T13:50:24.7867432' AS DateTime2), NULL, NULL, 1, 15, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (314, CAST(N'2020-07-01T13:50:24.7867366' AS DateTime2), NULL, NULL, 1, 15, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (315, CAST(N'2020-07-01T13:50:24.7867351' AS DateTime2), NULL, NULL, 1, 15, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (316, CAST(N'2020-07-01T13:50:24.7867344' AS DateTime2), NULL, NULL, 1, 15, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (317, CAST(N'2020-07-01T13:50:24.7867336' AS DateTime2), NULL, NULL, 1, 15, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (318, CAST(N'2020-07-01T13:50:24.7867328' AS DateTime2), NULL, NULL, 1, 15, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (319, CAST(N'2020-07-01T13:50:24.7867320' AS DateTime2), NULL, NULL, 1, 15, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (320, CAST(N'2020-07-01T13:50:24.7867313' AS DateTime2), NULL, NULL, 1, 15, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (321, CAST(N'2020-07-01T13:50:24.7867305' AS DateTime2), NULL, NULL, 1, 15, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (322, CAST(N'2020-07-01T13:50:24.7867297' AS DateTime2), NULL, NULL, 1, 15, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (323, CAST(N'2020-07-01T13:50:24.7867358' AS DateTime2), NULL, NULL, 1, 15, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (324, CAST(N'2020-07-01T13:50:24.7867439' AS DateTime2), NULL, NULL, 1, 15, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (325, CAST(N'2020-07-01T13:50:56.3504713' AS DateTime2), NULL, NULL, 1, 16, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (326, CAST(N'2020-07-01T13:50:56.3504898' AS DateTime2), NULL, NULL, 1, 16, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (327, CAST(N'2020-07-01T13:50:56.3504891' AS DateTime2), NULL, NULL, 1, 16, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (328, CAST(N'2020-07-01T13:50:56.3504884' AS DateTime2), NULL, NULL, 1, 16, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (329, CAST(N'2020-07-01T13:50:56.3504877' AS DateTime2), NULL, NULL, 1, 16, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (330, CAST(N'2020-07-01T13:50:56.3504870' AS DateTime2), NULL, NULL, 1, 16, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (331, CAST(N'2020-07-01T13:50:56.3504863' AS DateTime2), NULL, NULL, 1, 16, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (332, CAST(N'2020-07-01T13:50:56.3504856' AS DateTime2), NULL, NULL, 1, 16, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (333, CAST(N'2020-07-01T13:50:56.3504849' AS DateTime2), NULL, NULL, 1, 16, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (334, CAST(N'2020-07-01T13:50:56.3504905' AS DateTime2), NULL, NULL, 1, 16, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (335, CAST(N'2020-07-01T13:50:56.3504842' AS DateTime2), NULL, NULL, 1, 16, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (336, CAST(N'2020-07-01T13:50:56.3504829' AS DateTime2), NULL, NULL, 1, 16, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (337, CAST(N'2020-07-01T13:50:56.3504822' AS DateTime2), NULL, NULL, 1, 16, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (338, CAST(N'2020-07-01T13:50:56.3504815' AS DateTime2), NULL, NULL, 1, 16, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (339, CAST(N'2020-07-01T13:50:56.3504808' AS DateTime2), NULL, NULL, 1, 16, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (340, CAST(N'2020-07-01T13:50:56.3504801' AS DateTime2), NULL, NULL, 1, 16, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (341, CAST(N'2020-07-01T13:50:56.3504794' AS DateTime2), NULL, NULL, 1, 16, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (342, CAST(N'2020-07-01T13:50:56.3504787' AS DateTime2), NULL, NULL, 1, 16, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (343, CAST(N'2020-07-01T13:50:56.3504779' AS DateTime2), NULL, NULL, 1, 16, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (344, CAST(N'2020-07-01T13:50:56.3504836' AS DateTime2), NULL, NULL, 1, 16, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (345, CAST(N'2020-07-01T13:50:56.3504912' AS DateTime2), NULL, NULL, 1, 16, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (346, CAST(N'2020-07-01T13:51:39.2650992' AS DateTime2), NULL, NULL, 1, 17, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (347, CAST(N'2020-07-01T13:51:39.2651505' AS DateTime2), NULL, NULL, 1, 17, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (348, CAST(N'2020-07-01T13:51:39.2651495' AS DateTime2), NULL, NULL, 1, 17, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (349, CAST(N'2020-07-01T13:51:39.2651174' AS DateTime2), NULL, NULL, 1, 17, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (350, CAST(N'2020-07-01T13:51:39.2651167' AS DateTime2), NULL, NULL, 1, 17, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (351, CAST(N'2020-07-01T13:51:39.2651160' AS DateTime2), NULL, NULL, 1, 17, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (352, CAST(N'2020-07-01T13:51:39.2651153' AS DateTime2), NULL, NULL, 1, 17, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (353, CAST(N'2020-07-01T13:51:39.2651146' AS DateTime2), NULL, NULL, 1, 17, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (354, CAST(N'2020-07-01T13:51:39.2651139' AS DateTime2), NULL, NULL, 1, 17, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (355, CAST(N'2020-07-01T13:51:39.2651512' AS DateTime2), NULL, NULL, 1, 17, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (356, CAST(N'2020-07-01T13:51:39.2651132' AS DateTime2), NULL, NULL, 1, 17, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (357, CAST(N'2020-07-01T13:51:39.2651119' AS DateTime2), NULL, NULL, 1, 17, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (358, CAST(N'2020-07-01T13:51:39.2651112' AS DateTime2), NULL, NULL, 1, 17, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (359, CAST(N'2020-07-01T13:51:39.2651105' AS DateTime2), NULL, NULL, 1, 17, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (360, CAST(N'2020-07-01T13:51:39.2651098' AS DateTime2), NULL, NULL, 1, 17, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (361, CAST(N'2020-07-01T13:51:39.2651091' AS DateTime2), NULL, NULL, 1, 17, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (362, CAST(N'2020-07-01T13:51:39.2651083' AS DateTime2), NULL, NULL, 1, 17, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (363, CAST(N'2020-07-01T13:51:39.2651076' AS DateTime2), NULL, NULL, 1, 17, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (364, CAST(N'2020-07-01T13:51:39.2651068' AS DateTime2), NULL, NULL, 1, 17, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (365, CAST(N'2020-07-01T13:51:39.2651125' AS DateTime2), NULL, NULL, 1, 17, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (366, CAST(N'2020-07-01T13:51:39.2651519' AS DateTime2), NULL, NULL, 1, 17, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (367, CAST(N'2020-07-01T13:51:56.6004147' AS DateTime2), NULL, NULL, 1, 18, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (368, CAST(N'2020-07-01T13:51:56.6004376' AS DateTime2), NULL, NULL, 1, 18, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (369, CAST(N'2020-07-01T13:51:56.6004369' AS DateTime2), NULL, NULL, 1, 18, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (370, CAST(N'2020-07-01T13:51:56.6004362' AS DateTime2), NULL, NULL, 1, 18, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (371, CAST(N'2020-07-01T13:51:56.6004355' AS DateTime2), NULL, NULL, 1, 18, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (372, CAST(N'2020-07-01T13:51:56.6004348' AS DateTime2), NULL, NULL, 1, 18, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (373, CAST(N'2020-07-01T13:51:56.6004341' AS DateTime2), NULL, NULL, 1, 18, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (374, CAST(N'2020-07-01T13:51:56.6004333' AS DateTime2), NULL, NULL, 1, 18, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (375, CAST(N'2020-07-01T13:51:56.6004326' AS DateTime2), NULL, NULL, 1, 18, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (376, CAST(N'2020-07-01T13:51:56.6004383' AS DateTime2), NULL, NULL, 1, 18, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (377, CAST(N'2020-07-01T13:51:56.6004318' AS DateTime2), NULL, NULL, 1, 18, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (378, CAST(N'2020-07-01T13:51:56.6004303' AS DateTime2), NULL, NULL, 1, 18, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (379, CAST(N'2020-07-01T13:51:56.6004296' AS DateTime2), NULL, NULL, 1, 18, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (380, CAST(N'2020-07-01T13:51:56.6004288' AS DateTime2), NULL, NULL, 1, 18, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (381, CAST(N'2020-07-01T13:51:56.6004281' AS DateTime2), NULL, NULL, 1, 18, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (382, CAST(N'2020-07-01T13:51:56.6004274' AS DateTime2), NULL, NULL, 1, 18, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (383, CAST(N'2020-07-01T13:51:56.6004265' AS DateTime2), NULL, NULL, 1, 18, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (384, CAST(N'2020-07-01T13:51:56.6004258' AS DateTime2), NULL, NULL, 1, 18, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (385, CAST(N'2020-07-01T13:51:56.6004249' AS DateTime2), NULL, NULL, 1, 18, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (386, CAST(N'2020-07-01T13:51:56.6004311' AS DateTime2), NULL, NULL, 1, 18, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (387, CAST(N'2020-07-01T13:51:56.6004390' AS DateTime2), NULL, NULL, 1, 18, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (388, CAST(N'2020-07-01T13:52:37.9290911' AS DateTime2), NULL, NULL, 1, 19, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (389, CAST(N'2020-07-01T13:52:37.9291097' AS DateTime2), NULL, NULL, 1, 19, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (390, CAST(N'2020-07-01T13:52:37.9291091' AS DateTime2), NULL, NULL, 1, 19, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (391, CAST(N'2020-07-01T13:52:37.9291084' AS DateTime2), NULL, NULL, 1, 19, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (392, CAST(N'2020-07-01T13:52:37.9291077' AS DateTime2), NULL, NULL, 1, 19, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (393, CAST(N'2020-07-01T13:52:37.9291070' AS DateTime2), NULL, NULL, 1, 19, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (394, CAST(N'2020-07-01T13:52:37.9291063' AS DateTime2), NULL, NULL, 1, 19, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (395, CAST(N'2020-07-01T13:52:37.9291056' AS DateTime2), NULL, NULL, 1, 19, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (396, CAST(N'2020-07-01T13:52:37.9291050' AS DateTime2), NULL, NULL, 1, 19, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (397, CAST(N'2020-07-01T13:52:37.9291104' AS DateTime2), NULL, NULL, 1, 19, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (398, CAST(N'2020-07-01T13:52:37.9291043' AS DateTime2), NULL, NULL, 1, 19, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (399, CAST(N'2020-07-01T13:52:37.9291029' AS DateTime2), NULL, NULL, 1, 19, 12)
GO
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (400, CAST(N'2020-07-01T13:52:37.9291022' AS DateTime2), NULL, NULL, 1, 19, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (401, CAST(N'2020-07-01T13:52:37.9291015' AS DateTime2), NULL, NULL, 1, 19, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (402, CAST(N'2020-07-01T13:52:37.9291008' AS DateTime2), NULL, NULL, 1, 19, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (403, CAST(N'2020-07-01T13:52:37.9291001' AS DateTime2), NULL, NULL, 1, 19, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (404, CAST(N'2020-07-01T13:52:37.9290994' AS DateTime2), NULL, NULL, 1, 19, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (405, CAST(N'2020-07-01T13:52:37.9290987' AS DateTime2), NULL, NULL, 1, 19, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (406, CAST(N'2020-07-01T13:52:37.9290979' AS DateTime2), NULL, NULL, 1, 19, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (407, CAST(N'2020-07-01T13:52:37.9291036' AS DateTime2), NULL, NULL, 1, 19, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (408, CAST(N'2020-07-01T13:52:37.9291111' AS DateTime2), NULL, NULL, 1, 19, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (409, CAST(N'2020-07-01T13:53:42.2550274' AS DateTime2), NULL, NULL, 1, 20, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (410, CAST(N'2020-07-01T13:53:42.2550456' AS DateTime2), NULL, NULL, 1, 20, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (411, CAST(N'2020-07-01T13:53:42.2550449' AS DateTime2), NULL, NULL, 1, 20, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (412, CAST(N'2020-07-01T13:53:42.2550442' AS DateTime2), NULL, NULL, 1, 20, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (413, CAST(N'2020-07-01T13:53:42.2550435' AS DateTime2), NULL, NULL, 1, 20, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (414, CAST(N'2020-07-01T13:53:42.2550428' AS DateTime2), NULL, NULL, 1, 20, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (415, CAST(N'2020-07-01T13:53:42.2550421' AS DateTime2), NULL, NULL, 1, 20, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (416, CAST(N'2020-07-01T13:53:42.2550414' AS DateTime2), NULL, NULL, 1, 20, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (417, CAST(N'2020-07-01T13:53:42.2550407' AS DateTime2), NULL, NULL, 1, 20, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (418, CAST(N'2020-07-01T13:53:42.2550463' AS DateTime2), NULL, NULL, 1, 20, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (419, CAST(N'2020-07-01T13:53:42.2550400' AS DateTime2), NULL, NULL, 1, 20, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (420, CAST(N'2020-07-01T13:53:42.2550386' AS DateTime2), NULL, NULL, 1, 20, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (421, CAST(N'2020-07-01T13:53:42.2550379' AS DateTime2), NULL, NULL, 1, 20, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (422, CAST(N'2020-07-01T13:53:42.2550372' AS DateTime2), NULL, NULL, 1, 20, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (423, CAST(N'2020-07-01T13:53:42.2550366' AS DateTime2), NULL, NULL, 1, 20, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (424, CAST(N'2020-07-01T13:53:42.2550359' AS DateTime2), NULL, NULL, 1, 20, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (425, CAST(N'2020-07-01T13:53:42.2550351' AS DateTime2), NULL, NULL, 1, 20, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (426, CAST(N'2020-07-01T13:53:42.2550344' AS DateTime2), NULL, NULL, 1, 20, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (427, CAST(N'2020-07-01T13:53:42.2550337' AS DateTime2), NULL, NULL, 1, 20, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (428, CAST(N'2020-07-01T13:53:42.2550393' AS DateTime2), NULL, NULL, 1, 20, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (429, CAST(N'2020-07-01T13:53:42.2550470' AS DateTime2), NULL, NULL, 1, 20, 25)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (430, CAST(N'2020-07-01T13:54:11.9671736' AS DateTime2), NULL, NULL, 1, 21, 1)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (431, CAST(N'2020-07-01T13:54:11.9671979' AS DateTime2), NULL, NULL, 1, 21, 23)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (432, CAST(N'2020-07-01T13:54:11.9671972' AS DateTime2), NULL, NULL, 1, 21, 22)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (433, CAST(N'2020-07-01T13:54:11.9671965' AS DateTime2), NULL, NULL, 1, 21, 21)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (434, CAST(N'2020-07-01T13:54:11.9671958' AS DateTime2), NULL, NULL, 1, 21, 20)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (435, CAST(N'2020-07-01T13:54:11.9671952' AS DateTime2), NULL, NULL, 1, 21, 19)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (436, CAST(N'2020-07-01T13:54:11.9671945' AS DateTime2), NULL, NULL, 1, 21, 18)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (437, CAST(N'2020-07-01T13:54:11.9671938' AS DateTime2), NULL, NULL, 1, 21, 17)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (438, CAST(N'2020-07-01T13:54:11.9671931' AS DateTime2), NULL, NULL, 1, 21, 16)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (439, CAST(N'2020-07-01T13:54:11.9671986' AS DateTime2), NULL, NULL, 1, 21, 24)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (440, CAST(N'2020-07-01T13:54:11.9671923' AS DateTime2), NULL, NULL, 1, 21, 14)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (441, CAST(N'2020-07-01T13:54:11.9671908' AS DateTime2), NULL, NULL, 1, 21, 12)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (442, CAST(N'2020-07-01T13:54:11.9671901' AS DateTime2), NULL, NULL, 1, 21, 11)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (443, CAST(N'2020-07-01T13:54:11.9671894' AS DateTime2), NULL, NULL, 1, 21, 10)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (444, CAST(N'2020-07-01T13:54:11.9671887' AS DateTime2), NULL, NULL, 1, 21, 9)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (445, CAST(N'2020-07-01T13:54:11.9671879' AS DateTime2), NULL, NULL, 1, 21, 8)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (446, CAST(N'2020-07-01T13:54:11.9671872' AS DateTime2), NULL, NULL, 1, 21, 7)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (447, CAST(N'2020-07-01T13:54:11.9671865' AS DateTime2), NULL, NULL, 1, 21, 3)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (448, CAST(N'2020-07-01T13:54:11.9671857' AS DateTime2), NULL, NULL, 1, 21, 2)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (449, CAST(N'2020-07-01T13:54:11.9671916' AS DateTime2), NULL, NULL, 1, 21, 13)
INSERT [dbo].[UserUseCases] ([Id], [CreatedAt], [ModifiedAt], [DeletedAt], [Visible], [UserId], [UseCaseId]) VALUES (450, CAST(N'2020-07-01T13:54:11.9671993' AS DateTime2), NULL, NULL, 1, 21, 25)
SET IDENTITY_INSERT [dbo].[UserUseCases] OFF
GO
/****** Object:  Index [IX_Comments_PostId]    Script Date: 01-Jul-20 14:50:09 ******/
CREATE NONCLUSTERED INDEX [IX_Comments_PostId] ON [dbo].[Comments]
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Comments_UserId]    Script Date: 01-Jul-20 14:50:09 ******/
CREATE NONCLUSTERED INDEX [IX_Comments_UserId] ON [dbo].[Comments]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Posts_TopicId]    Script Date: 01-Jul-20 14:50:09 ******/
CREATE NONCLUSTERED INDEX [IX_Posts_TopicId] ON [dbo].[Posts]
(
	[TopicId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Posts_UserId]    Script Date: 01-Jul-20 14:50:09 ******/
CREATE NONCLUSTERED INDEX [IX_Posts_UserId] ON [dbo].[Posts]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Ratings_PostId]    Script Date: 01-Jul-20 14:50:09 ******/
CREATE NONCLUSTERED INDEX [IX_Ratings_PostId] ON [dbo].[Ratings]
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Ratings_UserId_PostId]    Script Date: 01-Jul-20 14:50:09 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Ratings_UserId_PostId] ON [dbo].[Ratings]
(
	[UserId] ASC,
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Topics_Name]    Script Date: 01-Jul-20 14:50:09 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Topics_Name] ON [dbo].[Topics]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UseCaseLogs_UseCaseId]    Script Date: 01-Jul-20 14:50:09 ******/
CREATE NONCLUSTERED INDEX [IX_UseCaseLogs_UseCaseId] ON [dbo].[UseCaseLogs]
(
	[UseCaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UseCases_Name]    Script Date: 01-Jul-20 14:50:09 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_UseCases_Name] ON [dbo].[UseCases]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Users_Email]    Script Date: 01-Jul-20 14:50:09 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Users_Email] ON [dbo].[Users]
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserUseCases_UseCaseId_UserId]    Script Date: 01-Jul-20 14:50:09 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_UserUseCases_UseCaseId_UserId] ON [dbo].[UserUseCases]
(
	[UseCaseId] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserUseCases_UserId]    Script Date: 01-Jul-20 14:50:09 ******/
CREATE NONCLUSTERED INDEX [IX_UserUseCases_UserId] ON [dbo].[UserUseCases]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Posts_PostId] FOREIGN KEY([PostId])
REFERENCES [dbo].[Posts] ([Id])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Posts_PostId]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Users_UserId]
GO
ALTER TABLE [dbo].[Posts]  WITH CHECK ADD  CONSTRAINT [FK_Posts_Topics_TopicId] FOREIGN KEY([TopicId])
REFERENCES [dbo].[Topics] ([Id])
GO
ALTER TABLE [dbo].[Posts] CHECK CONSTRAINT [FK_Posts_Topics_TopicId]
GO
ALTER TABLE [dbo].[Posts]  WITH CHECK ADD  CONSTRAINT [FK_Posts_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Posts] CHECK CONSTRAINT [FK_Posts_Users_UserId]
GO
ALTER TABLE [dbo].[Ratings]  WITH CHECK ADD  CONSTRAINT [FK_Ratings_Posts_PostId] FOREIGN KEY([PostId])
REFERENCES [dbo].[Posts] ([Id])
GO
ALTER TABLE [dbo].[Ratings] CHECK CONSTRAINT [FK_Ratings_Posts_PostId]
GO
ALTER TABLE [dbo].[Ratings]  WITH CHECK ADD  CONSTRAINT [FK_Ratings_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Ratings] CHECK CONSTRAINT [FK_Ratings_Users_UserId]
GO
ALTER TABLE [dbo].[UseCaseLogs]  WITH CHECK ADD  CONSTRAINT [FK_UseCaseLogs_UseCases_UseCaseId] FOREIGN KEY([UseCaseId])
REFERENCES [dbo].[UseCases] ([Id])
GO
ALTER TABLE [dbo].[UseCaseLogs] CHECK CONSTRAINT [FK_UseCaseLogs_UseCases_UseCaseId]
GO
ALTER TABLE [dbo].[UserUseCases]  WITH CHECK ADD  CONSTRAINT [FK_UserUseCases_UseCases_UseCaseId] FOREIGN KEY([UseCaseId])
REFERENCES [dbo].[UseCases] ([Id])
GO
ALTER TABLE [dbo].[UserUseCases] CHECK CONSTRAINT [FK_UserUseCases_UseCases_UseCaseId]
GO
ALTER TABLE [dbo].[UserUseCases]  WITH CHECK ADD  CONSTRAINT [FK_UserUseCases_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserUseCases] CHECK CONSTRAINT [FK_UserUseCases_Users_UserId]
GO
USE [master]
GO
ALTER DATABASE [PhoTexBlog] SET  READ_WRITE 
GO
