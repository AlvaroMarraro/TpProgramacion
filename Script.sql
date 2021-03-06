USE [master]
GO
/****** Object:  Database [FERREMANIA3]    Script Date: 17/11/2021 19:09:59 ******/
CREATE DATABASE [FERREMANIA3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FERREMANIA3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\FERREMANIA3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FERREMANIA3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\FERREMANIA3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FERREMANIA3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FERREMANIA3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FERREMANIA3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FERREMANIA3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FERREMANIA3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FERREMANIA3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FERREMANIA3] SET ARITHABORT OFF 
GO
ALTER DATABASE [FERREMANIA3] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [FERREMANIA3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FERREMANIA3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FERREMANIA3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FERREMANIA3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FERREMANIA3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FERREMANIA3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FERREMANIA3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FERREMANIA3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FERREMANIA3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FERREMANIA3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FERREMANIA3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FERREMANIA3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FERREMANIA3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FERREMANIA3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FERREMANIA3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FERREMANIA3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FERREMANIA3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FERREMANIA3] SET  MULTI_USER 
GO
ALTER DATABASE [FERREMANIA3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FERREMANIA3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FERREMANIA3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FERREMANIA3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FERREMANIA3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FERREMANIA3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [FERREMANIA3] SET QUERY_STORE = OFF
GO
USE [FERREMANIA3]
GO
/****** Object:  Table [dbo].[articulos]    Script Date: 17/11/2021 19:09:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[articulos](
	[cod_articulo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NULL,
	[pre_unitario] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_articulos] PRIMARY KEY CLUSTERED 
(
	[cod_articulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 17/11/2021 19:09:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[cod_cliente] [int] IDENTITY(1,1) NOT NULL,
	[doc_cliente] [int] NOT NULL,
	[nom_cliente] [nvarchar](50) NOT NULL,
	[ape_cliente] [nvarchar](50) NOT NULL,
	[calle] [nvarchar](50) NOT NULL,
	[altura] [int] NULL,
	[nro_tel] [bigint] NULL,
	[e-mail] [nvarchar](50) NULL,
	[FechaBaja] [date] NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[cod_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_facturas]    Script Date: 17/11/2021 19:09:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_facturas](
	[nro_factura] [int] NOT NULL,
	[cod_articulo] [int] NOT NULL,
	[pre_unitario] [numeric](18, 2) NOT NULL,
	[cantidad] [smallint] NOT NULL,
 CONSTRAINT [PK_detalle] PRIMARY KEY CLUSTERED 
(
	[nro_factura] ASC,
	[cod_articulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[facturas]    Script Date: 17/11/2021 19:09:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[facturas](
	[nro_factura] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_formaPago] [int] NOT NULL,
	[cod_cliente] [int] NOT NULL,
 CONSTRAINT [PK_facturas] PRIMARY KEY CLUSTERED 
(
	[nro_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[formaPagos]    Script Date: 17/11/2021 19:09:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formaPagos](
	[id_formaPago] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_formasPagos] PRIMARY KEY CLUSTERED 
(
	[id_formaPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 17/11/2021 19:09:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Pass] [nvarchar](1000) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[articulos] ON 

INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (1, N'Martillo uña mango madera', CAST(1600.00 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (2, N'Martillo encofrador mango fibra vidrio', CAST(5000.00 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (3, N'Maza goma negra', CAST(900.00 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (4, N'Tenazas rusas eco', CAST(720.50 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (5, N'Pala punta mango anilla', CAST(1245.30 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (6, N'Pala cuadrada mango muleta 509', CAST(1300.00 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (7, N'Cortacables profesional 1 mano', CAST(285.70 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (8, N'Talocha negra esponja mango redondo', CAST(202.90 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (9, N'Espátula mango sintético', CAST(550.90 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (10, N'Adhesivo sintético 30 gr', CAST(156.00 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (11, N'Cinta métrica 20mts', CAST(452.70 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (12, N'Cinta métrica  Grip-Specialist con freno', CAST(552.70 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (13, N'Calibre inox profesional alta precisión', CAST(641.00 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (14, N'Serrucho carpintero mango', CAST(941.00 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (15, N'Arco sierra junior con hoja', CAST(185.90 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (16, N'Formón mango bimaterial', CAST(565.50 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (17, N'Juego formones mango bimateria', CAST(262.60 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (18, N'Grapadora metal regulable', CAST(81.40 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (19, N'Grapa punta cabeza plana', CAST(75.90 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (20, N'Pistola termocolante profesional', CAST(1585.00 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (21, N'Silicona en barra Bolsa 1 kg.', CAST(448.90 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (22, N'Cinta embalar rollo 66 mts.', CAST(165.50 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (23, N'Cinta aislante 20 mts. x 19 mm.', CAST(87.50 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (24, N'Blister anclaje metálico tornillo', CAST(199.50 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (25, N'Blister tuerca autoblocante din 985', CAST(478.99 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (26, N'Blister arandela zincada din 125A', CAST(254.99 AS Decimal(10, 2)))
INSERT [dbo].[articulos] ([cod_articulo], [descripcion], [pre_unitario]) VALUES (27, N'CBrocha profesional techos', CAST(702.99 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[articulos] OFF
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 

INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (1, 33598885, N'Rodolfo', N'Perez', N'San Martín', 120, 123456, N'prueba@gmail.com', NULL)
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (2, 87654321, N'Marta Analía', N'Castillo', N'Pedro Lozano', 1450, 123456, N'prueba@gmail.com', NULL)
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (3, 65432187, N'Héctor', N'Abarca', N'Luis Gongora', 160, 123456, N'prueba@gmail.com', NULL)
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (4, 65478123, N'Santiago', N'Morales', N'León y Pizarro', 60, 123456, N'prueba@gmail.com', NULL)
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (5, 23165487, N'Carlos Antonio', N'Perez', N'A. Garzón', 580, 123456, N'prueba@gmail.com', NULL)
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (6, 13642578, N'Pilar', N'Morales', N'León y Pizarro', 55, 123456, N'prueba@gmail.com', NULL)
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (7, 85263741, N'Roque', N'Paez', N'Humberto Primo', 79, 123456, N'prueba@gmail.com', CAST(N'2021-11-15' AS Date))
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (8, 36251748, N'Elvira Josefa', N'Luque', N'Mariano Usandivaras', 360, 123456, N'prueba@gmail.com', NULL)
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (9, 8235147, N'Marcos', N'Ruiz', N'Rivera Indarte', 780, 123456, N'prueba@gmail.com', NULL)
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (10, 65874123, N'Roberto', N'Moriel', N'Santa Rosa', 73, 123456, N'prueba@gmail.com', NULL)
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (11, 36521487, N'Ana María', N'Perez', N'Av. Colón', 1655, 123456, N'prueba@gmail.com', NULL)
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (12, 65416328, N'Adriana', N'Gonzalez', N'San Jerónimo', 763, 123456, N'prueba@gmail.com', NULL)
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (13, 36852147, N'Juana', N'Moralez', N'Salamanca', 2345, 123456, N'prueba@gmail.com', NULL)
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (14, 25863187, N'Sofía', N'Ariza', N'Derqui', 876, 123456, N'prueba@gmail.com', NULL)
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (15, 65874123, N'Matias', N'Angellozzi', N'Ituzaingó', 1127, 123456, N'prueba@gmail.com', NULL)
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (16, 59852011, N'Lucas', N'Luraschi', N'ia tu sabe ', 666, 25895647, N'LL@gmail.com', CAST(N'2021-11-16' AS Date))
INSERT [dbo].[clientes] ([cod_cliente], [doc_cliente], [nom_cliente], [ape_cliente], [calle], [altura], [nro_tel], [e-mail], [FechaBaja]) VALUES (17, 58522141, N'Bruno', N'M', N'ia tu sabe ', 666, 25895647, N'LL@gmail.com', NULL)
SET IDENTITY_INSERT [dbo].[clientes] OFF
GO
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (1, 3, CAST(100.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (1, 5, CAST(500.50 AS Numeric(18, 2)), 2)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (2, 6, CAST(200.50 AS Numeric(18, 2)), 3)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (3, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (4, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (5, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (6, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (7, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (8, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (9, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (10, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (11, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (12, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (13, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (14, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (15, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (16, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (17, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (18, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (19, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (20, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (21, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (22, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (23, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (24, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (25, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (26, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (27, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (28, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (29, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (30, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (31, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (32, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (33, 5, CAST(500.50 AS Numeric(18, 2)), 2)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (34, 3, CAST(100.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (35, 6, CAST(200.50 AS Numeric(18, 2)), 3)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (36, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (37, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (38, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (39, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (40, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (41, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (42, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (43, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (44, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (45, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (46, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (47, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (48, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (49, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (50, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (51, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (52, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (53, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (54, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (55, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (56, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (57, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (58, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (59, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (60, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (61, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (62, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (63, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (64, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (65, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (66, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (67, 5, CAST(500.50 AS Numeric(18, 2)), 2)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (68, 3, CAST(100.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (69, 6, CAST(200.50 AS Numeric(18, 2)), 3)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (70, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (71, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (72, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (73, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (74, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (75, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (76, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (77, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (78, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (79, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (80, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (81, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (82, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (83, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (84, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (85, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (86, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (87, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (88, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (89, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (90, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (91, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (92, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (93, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (94, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (95, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (96, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (97, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (98, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (99, 4, CAST(150.00 AS Numeric(18, 2)), 1)
GO
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (100, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (101, 5, CAST(500.50 AS Numeric(18, 2)), 2)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (102, 3, CAST(100.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (103, 6, CAST(200.50 AS Numeric(18, 2)), 3)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (104, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (105, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (106, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (107, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (108, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (109, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (110, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (111, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (112, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (113, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (114, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (115, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (116, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (117, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (118, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (119, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (120, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (121, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (122, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (123, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (124, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (125, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (126, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (128, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (129, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (130, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (131, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (132, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (133, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (134, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (135, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (136, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (137, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (138, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (139, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (140, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (141, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (142, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (143, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (144, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (145, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (146, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (147, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (148, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (149, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (150, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (151, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (152, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (153, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (154, 5, CAST(500.50 AS Numeric(18, 2)), 2)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (155, 3, CAST(100.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (156, 6, CAST(200.50 AS Numeric(18, 2)), 3)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (157, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (158, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (159, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (160, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (161, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (162, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (163, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (164, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (165, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (166, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (167, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (168, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (169, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (170, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (171, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (172, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (173, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (174, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (175, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (176, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (177, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (178, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (179, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (180, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (181, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (182, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (183, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (184, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (185, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (186, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (187, 6, CAST(550.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (188, 10, CAST(250.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (189, 25, CAST(160.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (190, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (191, 3, CAST(340.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (192, 2, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (193, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (193, 10, CAST(200.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (194, 4, CAST(150.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (194, 15, CAST(750.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (195, 6, CAST(250.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (195, 20, CAST(350.00 AS Numeric(18, 2)), 1)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (196, 17, CAST(60.00 AS Numeric(18, 2)), 2)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (204, 23, CAST(0.00 AS Numeric(18, 2)), 1)
GO
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (206, 25, CAST(0.00 AS Numeric(18, 2)), 2)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (210, 25, CAST(0.00 AS Numeric(18, 2)), 2)
INSERT [dbo].[detalle_facturas] ([nro_factura], [cod_articulo], [pre_unitario], [cantidad]) VALUES (212, 24, CAST(0.00 AS Numeric(18, 2)), 2)
GO
SET IDENTITY_INSERT [dbo].[facturas] ON 

INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (1, CAST(N'2015-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (2, CAST(N'2015-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (3, CAST(N'2015-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (4, CAST(N'2015-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (5, CAST(N'2015-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (6, CAST(N'2015-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (7, CAST(N'2015-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (8, CAST(N'2015-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (9, CAST(N'2015-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (10, CAST(N'2015-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (11, CAST(N'2015-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (12, CAST(N'2015-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (13, CAST(N'2015-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (14, CAST(N'2015-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (15, CAST(N'2015-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (16, CAST(N'2015-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (17, CAST(N'2015-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (18, CAST(N'2015-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (19, CAST(N'2015-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (20, CAST(N'2015-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (21, CAST(N'2015-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (22, CAST(N'2015-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (23, CAST(N'2015-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (24, CAST(N'2015-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (25, CAST(N'2015-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (26, CAST(N'2015-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (27, CAST(N'2015-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (28, CAST(N'2015-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (29, CAST(N'2015-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (30, CAST(N'2015-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (31, CAST(N'2015-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (32, CAST(N'2015-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (33, CAST(N'2015-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (34, CAST(N'2015-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (35, CAST(N'2015-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (36, CAST(N'2015-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (37, CAST(N'2015-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (38, CAST(N'2015-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (39, CAST(N'2015-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (40, CAST(N'2015-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (41, CAST(N'2015-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (42, CAST(N'2015-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (43, CAST(N'2015-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (44, CAST(N'2015-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (45, CAST(N'2015-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (46, CAST(N'2016-01-16T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (47, CAST(N'2016-03-16T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (48, CAST(N'2016-05-16T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (49, CAST(N'2016-06-16T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (50, CAST(N'2016-08-16T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (51, CAST(N'2016-09-16T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (52, CAST(N'2016-10-16T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (53, CAST(N'2016-11-16T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (54, CAST(N'2016-12-16T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (55, CAST(N'2017-01-17T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (56, CAST(N'2017-03-17T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (57, CAST(N'2017-05-17T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (58, CAST(N'2017-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (59, CAST(N'2017-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (60, CAST(N'2017-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (61, CAST(N'2017-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (62, CAST(N'2017-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (63, CAST(N'2017-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (64, CAST(N'2018-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (65, CAST(N'2018-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (66, CAST(N'2018-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (67, CAST(N'2018-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (68, CAST(N'2018-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (69, CAST(N'2018-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (70, CAST(N'2018-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (71, CAST(N'2018-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (72, CAST(N'2018-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (73, CAST(N'2019-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (74, CAST(N'2019-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (75, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (76, CAST(N'2019-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (77, CAST(N'2019-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (78, CAST(N'2019-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (79, CAST(N'2019-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (80, CAST(N'2019-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (81, CAST(N'2019-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (82, CAST(N'2020-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (83, CAST(N'2020-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (84, CAST(N'2020-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (85, CAST(N'2020-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (86, CAST(N'2020-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (87, CAST(N'2020-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (88, CAST(N'2020-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (89, CAST(N'2020-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (90, CAST(N'2020-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (91, CAST(N'2021-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (92, CAST(N'2021-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (93, CAST(N'2021-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (94, CAST(N'2021-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (95, CAST(N'2021-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (96, CAST(N'2021-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (97, CAST(N'2021-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (98, CAST(N'2021-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (99, CAST(N'2015-01-15T00:00:00.000' AS DateTime), 1, 3)
GO
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (100, CAST(N'2015-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (101, CAST(N'2015-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (102, CAST(N'2015-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (103, CAST(N'2015-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (104, CAST(N'2015-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (105, CAST(N'2015-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (106, CAST(N'2015-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (107, CAST(N'2015-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (108, CAST(N'2015-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (109, CAST(N'2015-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (110, CAST(N'2015-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (111, CAST(N'2015-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (112, CAST(N'2015-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (113, CAST(N'2015-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (114, CAST(N'2015-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (115, CAST(N'2015-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (116, CAST(N'2015-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (117, CAST(N'2015-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (118, CAST(N'2015-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (119, CAST(N'2015-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (120, CAST(N'2015-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (121, CAST(N'2015-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (122, CAST(N'2015-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (123, CAST(N'2015-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (124, CAST(N'2015-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (125, CAST(N'2015-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (126, CAST(N'2015-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (127, CAST(N'2015-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (128, CAST(N'2015-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (129, CAST(N'2015-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (130, CAST(N'2015-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (131, CAST(N'2015-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (132, CAST(N'2015-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (133, CAST(N'2015-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (134, CAST(N'2015-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (135, CAST(N'2015-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (136, CAST(N'2015-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (137, CAST(N'2015-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (138, CAST(N'2015-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (139, CAST(N'2015-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (140, CAST(N'2015-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (141, CAST(N'2015-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (142, CAST(N'2015-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (143, CAST(N'2015-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (144, CAST(N'2016-01-16T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (145, CAST(N'2016-03-16T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (146, CAST(N'2016-05-16T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (147, CAST(N'2016-06-16T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (148, CAST(N'2016-08-16T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (149, CAST(N'2016-09-16T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (150, CAST(N'2016-10-16T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (151, CAST(N'2016-11-16T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (152, CAST(N'2016-12-16T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (153, CAST(N'2017-01-17T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (154, CAST(N'2017-03-17T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (155, CAST(N'2017-05-17T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (156, CAST(N'2017-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (157, CAST(N'2017-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (158, CAST(N'2017-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (159, CAST(N'2017-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (160, CAST(N'2017-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (161, CAST(N'2017-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (162, CAST(N'2018-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (163, CAST(N'2018-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (164, CAST(N'2018-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (165, CAST(N'2018-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (166, CAST(N'2018-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (167, CAST(N'2018-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (168, CAST(N'2018-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (169, CAST(N'2018-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (170, CAST(N'2018-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (171, CAST(N'2019-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (172, CAST(N'2019-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (173, CAST(N'2019-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (174, CAST(N'2019-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (175, CAST(N'2019-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (176, CAST(N'2019-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (177, CAST(N'2019-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (178, CAST(N'2019-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (179, CAST(N'2019-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (180, CAST(N'2020-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (181, CAST(N'2020-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (182, CAST(N'2020-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (183, CAST(N'2020-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (184, CAST(N'2020-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (185, CAST(N'2020-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (186, CAST(N'2020-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (187, CAST(N'2020-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (188, CAST(N'2020-12-15T00:00:00.000' AS DateTime), 1, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (189, CAST(N'2021-01-15T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (190, CAST(N'2021-03-15T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (191, CAST(N'2021-05-15T00:00:00.000' AS DateTime), 2, 4)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (192, CAST(N'2021-06-15T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (193, CAST(N'2021-08-15T00:00:00.000' AS DateTime), 3, 5)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (194, CAST(N'2021-09-15T00:00:00.000' AS DateTime), 2, 10)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (195, CAST(N'2021-10-15T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (196, CAST(N'2021-11-15T00:00:00.000' AS DateTime), 1, 15)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (204, CAST(N'2021-11-17T16:01:50.143' AS DateTime), 1, 3)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (206, CAST(N'2021-11-17T16:03:27.677' AS DateTime), 1, 1)
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (210, CAST(N'2021-11-17T17:28:57.623' AS DateTime), 2, 6)
GO
INSERT [dbo].[facturas] ([nro_factura], [fecha], [id_formaPago], [cod_cliente]) VALUES (212, CAST(N'2021-11-17T18:59:39.370' AS DateTime), 1, 5)
SET IDENTITY_INSERT [dbo].[facturas] OFF
GO
SET IDENTITY_INSERT [dbo].[formaPagos] ON 

INSERT [dbo].[formaPagos] ([id_formaPago], [nombre]) VALUES (1, N'Efectivo')
INSERT [dbo].[formaPagos] ([id_formaPago], [nombre]) VALUES (2, N'TarjetaCredito')
INSERT [dbo].[formaPagos] ([id_formaPago], [nombre]) VALUES (3, N'TarjetaDebito')
INSERT [dbo].[formaPagos] ([id_formaPago], [nombre]) VALUES (4, N'Transferencia')
SET IDENTITY_INSERT [dbo].[formaPagos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([IdUsuario], [Usuario], [Pass]) VALUES (1, N'Admin', N'admin')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[detalle_facturas]  WITH CHECK ADD  CONSTRAINT [FK_detalle_articulos] FOREIGN KEY([cod_articulo])
REFERENCES [dbo].[articulos] ([cod_articulo])
GO
ALTER TABLE [dbo].[detalle_facturas] CHECK CONSTRAINT [FK_detalle_articulos]
GO
ALTER TABLE [dbo].[detalle_facturas]  WITH CHECK ADD  CONSTRAINT [FK_detalle_facturas] FOREIGN KEY([nro_factura])
REFERENCES [dbo].[facturas] ([nro_factura])
GO
ALTER TABLE [dbo].[detalle_facturas] CHECK CONSTRAINT [FK_detalle_facturas]
GO
ALTER TABLE [dbo].[facturas]  WITH CHECK ADD  CONSTRAINT [FK_facturas_clientes] FOREIGN KEY([cod_cliente])
REFERENCES [dbo].[clientes] ([cod_cliente])
GO
ALTER TABLE [dbo].[facturas] CHECK CONSTRAINT [FK_facturas_clientes]
GO
ALTER TABLE [dbo].[facturas]  WITH CHECK ADD  CONSTRAINT [FK_facturas_formaPagos] FOREIGN KEY([id_formaPago])
REFERENCES [dbo].[formaPagos] ([id_formaPago])
GO
ALTER TABLE [dbo].[facturas] CHECK CONSTRAINT [FK_facturas_formaPagos]
GO
/****** Object:  StoredProcedure [dbo].[GetFacturasVentas]    Script Date: 17/11/2021 19:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[GetFacturasVentas]
@fechaDesde Date,
@fechaHasta Date
as
select f.nro_factura,
       f.fecha,
       c.ape_cliente+ '  ' +c.nom_cliente as Cliente,
       articulos = stuff((select ' - ' + 'x' + convert(varchar (10),df1.cantidad)+'  '+ a.descripcion
       from detalle_facturas df1 
       join articulos a on df1.cod_articulo = a.cod_articulo 
       where df1.nro_factura = df.nro_factura
	   for xml path('')),1,2, ''),
       sum(cantidad*pre_unitario) as 'Total'
       from facturas f
       join clientes c on c.cod_cliente = f.cod_cliente
       join detalle_facturas df on df.nro_factura = f.nro_factura
       where f.fecha between @fechaDesde and @fechaHasta
       group by f.nro_factura, df.nro_factura,f.fecha,c.ape_cliente,c.nom_cliente
       order by f.nro_factura asc

GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ARTICULOS]    Script Date: 17/11/2021 19:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_CONSULTAR_ARTICULOS]
AS
BEGIN
	
	SELECT * from articulos;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINAR_CLIENTE]    Script Date: 17/11/2021 19:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ELIMINAR_CLIENTE]
@codCliente int
AS
	BEGIN
		update CLIENTES
		set FechaBaja = getdate() 
		where cod_cliente = @codCliente

	END
GO
/****** Object:  StoredProcedure [dbo].[SP_FACTURAS_POR_DIA]    Script Date: 17/11/2021 19:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_FACTURAS_POR_DIA] 

@mes int
AS  
BEGIN  
   
SELECT fecha ,
		COUNT(f.nro_factura) as cantFacturas,
		SUM(df.cantidad) as cantProductos,  
		avg(df.cantidad*df.pre_unitario) as promedioVendido
from facturas f
join detalle_facturas df on df.nro_factura = f.nro_factura
WHERE month(f.fecha) = @mes
group by f.fecha
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_CLIENTE]    Script Date: 17/11/2021 19:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_CLIENTE]
@docCliente int,
@nombre nvarchar(50),
@apellido nvarchar(50),
@calle nvarchar(50),
@altura int,
@nroTel bigint,
@email nvarchar(50)
AS
	BEGIN
		INSERT INTO CLIENTES
		VALUES(@docCliente,@nombre,@apellido,@calle,@altura, @nroTel, @email, null)
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_DETALLE]    Script Date: 17/11/2021 19:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLE] 
	@facturaNro int,
	@codArticulo int, 
	@precio numeric (10,2),
	@cantidad int
AS
BEGIN
	INSERT INTO detalle_facturas(nro_factura,cod_articulo, pre_unitario, cantidad)
    VALUES (@facturaNro, @codArticulo, @precio, @cantidad);
  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_MAESTRO]    Script Date: 17/11/2021 19:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_MAESTRO] 
	@idFormaPago int, 
	@codCliente int,
	@facturaNro int OUTPUT
AS
BEGIN
	INSERT INTO facturas VALUES (GETDATE(), @idFormaPago, @codCliente);
    --Asignamos el valor del último ID autogenerado (obtenido --  
    --mediante la función SCOPE_IDENTITY() de SQLServer)	
    SET @facturaNro = SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_CLIENTE]    Script Date: 17/11/2021 19:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MODIFICAR_CLIENTE]
@codCliente int,
@docCliente int,
@nombre nvarchar(50),
@apellido nvarchar(50),
@calle nvarchar(50),
@altura int,
@nroTel bigint,
@email nvarchar(50)
AS
	BEGIN
		UPDATE CLIENTES
		SET doc_cliente = @docCliente,
		nom_cliente = @nombre,
		ape_cliente = @apellido,
		calle = @calle,
		altura = @altura,
		nro_tel = @nroTel,
		[e-mail] = @email
		where cod_cliente = @codCliente
	END
-------------------------------
GO
/****** Object:  StoredProcedure [dbo].[SP_PROXIMO_ID]    Script Date: 17/11/2021 19:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PROXIMO_ID]
AS
BEGIN
 SELECT MAX(nro_factura) as 'nro_Factura' FROM Facturas
END


GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTE_FORMAS_PAGO]    Script Date: 17/11/2021 19:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_REPORTE_FORMAS_PAGO]  
AS  
BEGIN  
   
 Select COUNT(f.nro_factura) cantidad, fp.nombre
  from facturas f
  join formaPagos fp on fp.id_formaPago = f.id_formaPago
  WHERE f.id_formaPago = 1 
  group by fp.nombre
  union 
    Select COUNT(f.nro_factura) cantidad, fp.nombre
  from facturas f
  join formaPagos fp on fp.id_formaPago = f.id_formaPago
  WHERE f.id_formaPago = 2
  group by fp.nombre
  END
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTE_TRAER_CLIENTES]    Script Date: 17/11/2021 19:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_REPORTE_TRAER_CLIENTES]  
AS  
BEGIN  
   
 Select count(cod_cliente) clientesActivos,
		(  Select count(cod_cliente) from clientes 
  where FechaBaja is  null) clientesBajos
  from clientes 
  where FechaBaja is not null
  END
GO
/****** Object:  StoredProcedure [dbo].[SP_TRAER_CLIENTES]    Script Date: 17/11/2021 19:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TRAER_CLIENTES]  
AS  
BEGIN  
   
 SELECT * FROM clientes ORDER BY cod_cliente;  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TRAER_COMBO_CLIENTES]    Script Date: 17/11/2021 19:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TRAER_COMBO_CLIENTES]  
AS  
BEGIN  
   
SELECT cod_cliente, convert(varchar,doc_cliente) +' '+nom_cliente+' '+ape_cliente as 'Datos' from clientes
END



GO
/****** Object:  StoredProcedure [dbo].[SP_TRAER_FORMA_PAGO]    Script Date: 17/11/2021 19:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TRAER_FORMA_PAGO]  
AS  
BEGIN  
   
 SELECT * FROM formaPagos ORDER BY id_formaPago;  
END
GO
USE [master]
GO
ALTER DATABASE [FERREMANIA3] SET  READ_WRITE 
GO
