USE [master]
GO
/****** Object:  Database [application_gestion_Y]    Script Date: 24/10/2022 14:43:31 ******/
CREATE DATABASE [application_gestion_Y]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'application_gestion_Y', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\application_gestion_Y.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'application_gestion_Y_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\application_gestion_Y_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [application_gestion_Y] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [application_gestion_Y].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [application_gestion_Y] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [application_gestion_Y] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [application_gestion_Y] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [application_gestion_Y] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [application_gestion_Y] SET ARITHABORT OFF 
GO
ALTER DATABASE [application_gestion_Y] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [application_gestion_Y] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [application_gestion_Y] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [application_gestion_Y] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [application_gestion_Y] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [application_gestion_Y] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [application_gestion_Y] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [application_gestion_Y] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [application_gestion_Y] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [application_gestion_Y] SET  ENABLE_BROKER 
GO
ALTER DATABASE [application_gestion_Y] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [application_gestion_Y] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [application_gestion_Y] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [application_gestion_Y] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [application_gestion_Y] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [application_gestion_Y] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [application_gestion_Y] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [application_gestion_Y] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [application_gestion_Y] SET  MULTI_USER 
GO
ALTER DATABASE [application_gestion_Y] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [application_gestion_Y] SET DB_CHAINING OFF 
GO
ALTER DATABASE [application_gestion_Y] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [application_gestion_Y] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [application_gestion_Y] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [application_gestion_Y] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [application_gestion_Y] SET QUERY_STORE = OFF
GO
USE [application_gestion_Y]
GO
/****** Object:  Table [dbo].[Username]    Script Date: 24/10/2022 14:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Username](
	[username] [varchar](30) NOT NULL,
	[password_user] [varchar](30) NULL,
	[email] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[verification]    Script Date: 24/10/2022 14:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[verification]
@user VARCHAR (30), @pass VARCHAR (30), @rus VARCHAR (5) OUTPUT
AS
BEGIN
    IF EXISTS (SELECT U.*
               FROM   Username AS U
               WHERE  U.username = @user
                      AND U.password_user = @pass)
        BEGIN
            RETURN '1';
        END
    ELSE
        RETURN '0';
END

GO
USE [master]
GO
ALTER DATABASE [application_gestion_Y] SET  READ_WRITE 
GO
