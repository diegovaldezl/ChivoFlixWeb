--create database CHIVOFLIX
--USE [CHIVOFLIX]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 9/5/2022 21:11:56 ******/
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
/****** Object:  Table [dbo].[duracionPlanes]    Script Date: 9/5/2022 21:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[duracionPlanes](
	[idDuracionPlanes] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](200) NOT NULL,
 CONSTRAINT [PK__duracion__812FA85D4DDDD2A5] PRIMARY KEY CLUSTERED 
(
	[idDuracionPlanes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[facturaciones]    Script Date: 9/5/2022 21:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[facturaciones](
	[idFacturaciones] [int] IDENTITY(1,1) NOT NULL,
	[idUsuarios] [int] NOT NULL,
	[idPlanes] [int] NOT NULL,
	[plann] [varchar](15) NOT NULL,
	[fechaAdquirido] [datetime] NULL,
	[tipo] [varchar](30) NOT NULL,
	[precio] [float] NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [PK__facturac__85C535F2A8D79B67] PRIMARY KEY CLUSTERED 
(
	[idFacturaciones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[generos]    Script Date: 9/5/2022 21:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[generos](
	[idGeneros] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NULL,
 CONSTRAINT [PK__generos__525F69B817391CE1] PRIMARY KEY CLUSTERED 
(
	[idGeneros] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[listados]    Script Date: 9/5/2022 21:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[listados](
	[idListado] [int] IDENTITY(1,1) NOT NULL,
	[idPeliculas] [int] NOT NULL,
	[idUsuarios] [int] NOT NULL,
 CONSTRAINT [PK__listados__EEA3B4650814573D] PRIMARY KEY CLUSTERED 
(
	[idListado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[peliculas]    Script Date: 9/5/2022 21:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[peliculas](
	[idPeliculas] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](500) NOT NULL,
	[anioEstreno] [int] NOT NULL,
	[categoriaEdad] [varchar](3) NOT NULL,
	[descripcion] [varchar](500) NOT NULL,
	[calidad] [varchar](5) NOT NULL,
	[director] [varchar](20) NOT NULL,
	[banner] [varchar](max) NOT NULL,
	[idGeneros] [int] NOT NULL,
	[Pelicula] [nvarchar](max) NULL,
 CONSTRAINT [PK__pelicula__71DB443F16B1CBF9] PRIMARY KEY CLUSTERED 
(
	[idPeliculas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[planes]    Script Date: 9/5/2022 21:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[planes](
	[idPlanes] [int] IDENTITY(1,1) NOT NULL,
	[plann] [varchar](15) NOT NULL,
	[precioPlan] [float] NOT NULL,
	[idDuracionPlanes] [int] NOT NULL,
	[idUsuarios] [int] NOT NULL,
 CONSTRAINT [PK__planes__31C4681E538E7E4D] PRIMARY KEY CLUSTERED 
(
	[idPlanes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[roles]    Script Date: 9/5/2022 21:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[roles](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[rol] [varchar](20) NULL,
 CONSTRAINT [PK__roles__3C872F76AB588757] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 9/5/2022 21:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[idUsuarios] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](15) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[perfiles] [int] NULL,
	[imagen] [varchar](max) NULL,
	[idRol] [int] NULL,
	[idPlanes] [int] NULL,
 CONSTRAINT [PK__usuarios__3940559A7C6EFA46] PRIMARY KEY CLUSTERED 
(
	[idUsuarios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[facturaciones]  WITH CHECK ADD  CONSTRAINT [fk_Facturaciones_Usuarios] FOREIGN KEY([idUsuarios])
REFERENCES [dbo].[usuarios] ([idUsuarios])
GO
ALTER TABLE [dbo].[facturaciones] CHECK CONSTRAINT [fk_Facturaciones_Usuarios]
GO
ALTER TABLE [dbo].[facturaciones]  WITH CHECK ADD  CONSTRAINT [fk_Facuraciones_Planes] FOREIGN KEY([idPlanes])
REFERENCES [dbo].[planes] ([idPlanes])
GO
ALTER TABLE [dbo].[facturaciones] CHECK CONSTRAINT [fk_Facuraciones_Planes]
GO
ALTER TABLE [dbo].[listados]  WITH CHECK ADD  CONSTRAINT [fk_Listado_Peliculas] FOREIGN KEY([idPeliculas])
REFERENCES [dbo].[peliculas] ([idPeliculas])
GO
ALTER TABLE [dbo].[listados] CHECK CONSTRAINT [fk_Listado_Peliculas]
GO
ALTER TABLE [dbo].[listados]  WITH CHECK ADD  CONSTRAINT [fk_Listado_Usuarios] FOREIGN KEY([idUsuarios])
REFERENCES [dbo].[usuarios] ([idUsuarios])
GO
ALTER TABLE [dbo].[listados] CHECK CONSTRAINT [fk_Listado_Usuarios]
GO
ALTER TABLE [dbo].[peliculas]  WITH CHECK ADD  CONSTRAINT [fk_Peliculas_Generos] FOREIGN KEY([idGeneros])
REFERENCES [dbo].[generos] ([idGeneros])
GO
ALTER TABLE [dbo].[peliculas] CHECK CONSTRAINT [fk_Peliculas_Generos]
GO
ALTER TABLE [dbo].[planes]  WITH CHECK ADD  CONSTRAINT [fk_Planes_DuracionP] FOREIGN KEY([idDuracionPlanes])
REFERENCES [dbo].[duracionPlanes] ([idDuracionPlanes])
GO
ALTER TABLE [dbo].[planes] CHECK CONSTRAINT [fk_Planes_DuracionP]
GO
ALTER TABLE [dbo].[planes]  WITH CHECK ADD  CONSTRAINT [fk_Planes_Usuarios] FOREIGN KEY([idUsuarios])
REFERENCES [dbo].[usuarios] ([idUsuarios])
GO
ALTER TABLE [dbo].[planes] CHECK CONSTRAINT [fk_Planes_Usuarios]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD FOREIGN KEY([idPlanes])
REFERENCES [dbo].[planes] ([idPlanes])
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [fk_Usuarios_Roles] FOREIGN KEY([idRol])
REFERENCES [dbo].[roles] ([idRol])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [fk_Usuarios_Roles]
GO
