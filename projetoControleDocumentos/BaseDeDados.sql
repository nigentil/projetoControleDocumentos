USE [master]
GO
/****** Object:  Database [DB_ConDoc]    Script Date: 01/09/2017 00:58:55 ******/
CREATE DATABASE [DB_ConDoc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_ConDoc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DB_ConDoc.mdf' , SIZE = 12480KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB_ConDoc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DB_ConDoc_log.ldf' , SIZE = 7040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB_ConDoc] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_ConDoc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_ConDoc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_ConDoc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_ConDoc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_ConDoc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_ConDoc] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_ConDoc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_ConDoc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_ConDoc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_ConDoc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_ConDoc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_ConDoc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_ConDoc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_ConDoc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_ConDoc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_ConDoc] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_ConDoc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_ConDoc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_ConDoc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_ConDoc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_ConDoc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_ConDoc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_ConDoc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_ConDoc] SET RECOVERY FULL 
GO
ALTER DATABASE [DB_ConDoc] SET  MULTI_USER 
GO
ALTER DATABASE [DB_ConDoc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_ConDoc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_ConDoc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_ConDoc] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DB_ConDoc] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DB_ConDoc', N'ON'
GO
USE [DB_ConDoc]
GO
/****** Object:  User [admin]    Script Date: 01/09/2017 00:58:55 ******/
CREATE USER [admin] FOR LOGIN [admin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[arquivo_enviado]    Script Date: 01/09/2017 00:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[arquivo_enviado](
	[codigo_envio] [int] IDENTITY(1,1) NOT NULL,
	[tipo_Arquivo] [int] NOT NULL,
	[descricao_arquivo] [varchar](255) NOT NULL,
	[nome_Arquivo] [varchar](255) NULL,
	[tamanho_arquivo] [int] NULL,
	[arquivo] [image] NULL,
	[codigo_usuario_envio] [varchar](20) NULL,
	[data_envio] [datetime] NOT NULL,
	[protocolo_envio] [bigint] NOT NULL,
	[codigo_usuario_aprov] [varchar](20) NULL,
	[data_aprov] [datetime] NULL,
	[protocolo_aut] [bigint] NULL,
	[codigo_usuario_reprov] [varchar](20) NULL,
	[data_reprov] [datetime] NULL,
	[motivo_reprov] [text] NULL,
 CONSTRAINT [pk_arquivo_enviado] PRIMARY KEY CLUSTERED 
(
	[codigo_envio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[empresa]    Script Date: 01/09/2017 00:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empresa](
	[codigo_empresa] [int] NOT NULL,
	[razao_social] [varchar](50) NOT NULL,
	[protocolo_envio] [int] NULL,
	[protocolo_autorizacao] [int] NULL,
 CONSTRAINT [pk_empresa] PRIMARY KEY CLUSTERED 
(
	[codigo_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_documento]    Script Date: 01/09/2017 00:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_documento](
	[codigo_tipo] [int] IDENTITY(1,1) NOT NULL,
	[descricao_tipo] [varchar](100) NOT NULL,
 CONSTRAINT [pk_tipo_arquivo] PRIMARY KEY CLUSTERED 
(
	[codigo_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 01/09/2017 00:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[codigo_usuario] [varchar](20) NOT NULL,
	[nome_usuario] [varchar](50) NOT NULL,
	[senha_usuario] [varchar](20) NOT NULL,
	[email_usuario] [varchar](100) NULL,
	[tipo_usuario] [tinyint] NULL,
	[usuario_ativo] [bit] NULL,
 CONSTRAINT [pk_usuario] PRIMARY KEY CLUSTERED 
(
	[codigo_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_Relatorio_ArquivoEnviado]    Script Date: 01/09/2017 00:58:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_Relatorio_ArquivoEnviado]
(
	@CodigoEnvio int
)
AS

Select 
	data_envio 'DataEnvio', 
	nome_usuario 'NomeUsuario', 
	nome_Arquivo 'NomeArquivo', 
    descricao_tipo 'TipoArquivo',
    tamanho_arquivo 'TamanhoArquivo',
    descricao_arquivo 'DescricaoArquivo', 
    data_aprov 'DataAprovacao',
    data_reprov 'DataReprovacao', 
    motivo_reprov 'MotivoReprovação',
	protocolo_envio 'Potocolo'
From arquivo_enviado arq 
    inner join usuario usuEnv 
        on arq.codigo_usuario_envio = usuEnv.codigo_usuario 
    inner join tipo_documento tipo 
        on arq.tipo_Arquivo = tipo.codigo_tipo 
where arq.codigo_envio = @CodigoEnvio
order by data_envio, nome_usuario
GO
USE [master]
GO
ALTER DATABASE [DB_ConDoc] SET  READ_WRITE 
GO
