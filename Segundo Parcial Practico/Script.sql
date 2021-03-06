USE [master]
GO
/****** Object:  Database [FacturacionLUG]    Script Date: 27/11/2018 17:31:25 ******/
CREATE DATABASE [FacturacionLUG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FacturacionLUG', FILENAME = N'C:\Segundo Parcial Practico\FacturacionLUG.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FacturacionLUG_log', FILENAME = N'C:\Segundo Parcial Practico\FacturacionLUG_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FacturacionLUG] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FacturacionLUG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FacturacionLUG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FacturacionLUG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FacturacionLUG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FacturacionLUG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FacturacionLUG] SET ARITHABORT OFF 
GO
ALTER DATABASE [FacturacionLUG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FacturacionLUG] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [FacturacionLUG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FacturacionLUG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FacturacionLUG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FacturacionLUG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FacturacionLUG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FacturacionLUG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FacturacionLUG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FacturacionLUG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FacturacionLUG] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FacturacionLUG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FacturacionLUG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FacturacionLUG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FacturacionLUG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FacturacionLUG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FacturacionLUG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FacturacionLUG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FacturacionLUG] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FacturacionLUG] SET  MULTI_USER 
GO
ALTER DATABASE [FacturacionLUG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FacturacionLUG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FacturacionLUG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FacturacionLUG] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [FacturacionLUG]
GO
/****** Object:  StoredProcedure [dbo].[ClienteDelete]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ClienteDelete]
(
	@intId int
)

as

set nocount on

delete from [Cliente]
where [intId] = @intId


GO
/****** Object:  StoredProcedure [dbo].[ClienteInsert]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ClienteInsert]
(
	@varNombre nvarchar(50),
	@varApellido nvarchar(50),
	@varDireccion nvarchar(50),
	@varTelefono nvarchar(50)
)

as

set nocount on

insert into [Cliente]
(
	[varNombre],
	[varApellido],
	[varDireccion],
	[varTelefono]
)
values
(
	@varNombre,
	@varApellido,
	@varDireccion,
	@varTelefono
)

select scope_identity()


GO
/****** Object:  StoredProcedure [dbo].[ClienteSelect]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ClienteSelect]
(
	@intId int
)

as

set nocount on

select [intId],
	[varNombre],
	[varApellido],
	[varDireccion],
	[varTelefono]
from [Cliente]
where [intId] = @intId


GO
/****** Object:  StoredProcedure [dbo].[ClienteSelectAll]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ClienteSelectAll]

as

set nocount on

select [intId],
	[varNombre],
	[varApellido],
	[varDireccion],
	[varTelefono]
from [Cliente]


GO
/****** Object:  StoredProcedure [dbo].[ClienteUpdate]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ClienteUpdate]
(
	@intId int,
	@varNombre nvarchar(50),
	@varApellido nvarchar(50),
	@varDireccion nvarchar(50),
	@varTelefono nvarchar(50)
)

as

set nocount on

update [Cliente]
set [varNombre] = @varNombre,
	[varApellido] = @varApellido,
	[varDireccion] = @varDireccion,
	[varTelefono] = @varTelefono
where [intId] = @intId


GO
/****** Object:  StoredProcedure [dbo].[DetalleFacturaDelete]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DetalleFacturaDelete]
(
	@intId int
)

as

set nocount on

delete from [DetalleFactura]
where [intId] = @intId


GO
/****** Object:  StoredProcedure [dbo].[DetalleFacturaDeleteAllByIntIdFactura]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DetalleFacturaDeleteAllByIntIdFactura]
(
	@intIdFactura int
)

as

set nocount on

delete from [DetalleFactura]
where [intIdFactura] = @intIdFactura


GO
/****** Object:  StoredProcedure [dbo].[DetalleFacturaDeleteAllByIntIdProducto]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DetalleFacturaDeleteAllByIntIdProducto]
(
	@intIdProducto int
)

as

set nocount on

delete from [DetalleFactura]
where [intIdProducto] = @intIdProducto


GO
/****** Object:  StoredProcedure [dbo].[DetalleFacturaInsert]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DetalleFacturaInsert]
(
	@intIdProducto int,
	@intIdFactura int,
	@intCantidad int
)

as

set nocount on

insert into [DetalleFactura]
(
	[intIdProducto],
	[intIdFactura],
	[intCantidad]
)
values
(
	@intIdProducto,
	@intIdFactura,
	@intCantidad
)

select scope_identity()


GO
/****** Object:  StoredProcedure [dbo].[DetalleFacturaSelect]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DetalleFacturaSelect]
(
	@intId int
)

as

set nocount on

select [intId],
	[intIdProducto],
	[intIdFactura],
	[intCantidad]
from [DetalleFactura]
where [intId] = @intId


GO
/****** Object:  StoredProcedure [dbo].[DetalleFacturaSelectAll]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DetalleFacturaSelectAll]

as

set nocount on

select [intId],
	[intIdProducto],
	[intIdFactura],
	[intCantidad]
from [DetalleFactura]


GO
/****** Object:  StoredProcedure [dbo].[DetalleFacturaSelectAllByIntIdFactura]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DetalleFacturaSelectAllByIntIdFactura]
(
	@intIdFactura int
)

as

set nocount on

select [intId],
	[intIdProducto],
	[intIdFactura],
	[intCantidad]
from [DetalleFactura]
where [intIdFactura] = @intIdFactura


GO
/****** Object:  StoredProcedure [dbo].[DetalleFacturaSelectAllByIntIdProducto]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DetalleFacturaSelectAllByIntIdProducto]
(
	@intIdProducto int
)

as

set nocount on

select [intId],
	[intIdProducto],
	[intIdFactura],
	[intCantidad]
from [DetalleFactura]
where [intIdProducto] = @intIdProducto


GO
/****** Object:  StoredProcedure [dbo].[DetalleFacturaUpdate]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DetalleFacturaUpdate]
(
	@intId int,
	@intIdProducto int,
	@intIdFactura int,
	@intCantidad int
)

as

set nocount on

update [DetalleFactura]
set [intIdProducto] = @intIdProducto,
	[intIdFactura] = @intIdFactura,
	[intCantidad] = @intCantidad
where [intId] = @intId


GO
/****** Object:  StoredProcedure [dbo].[FacturaDelete]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[FacturaDelete]
(
	@intId int
)

as

set nocount on

delete from [Factura]
where [intId] = @intId


GO
/****** Object:  StoredProcedure [dbo].[FacturaDeleteAllByIntIdCliente]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[FacturaDeleteAllByIntIdCliente]
(
	@intIdCliente int
)

as

set nocount on

delete from [Factura]
where [intIdCliente] = @intIdCliente


GO
/****** Object:  StoredProcedure [dbo].[FacturaInsert]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[FacturaInsert]
(
	@datFecha datetime,
	@intIdCliente int
)

as

set nocount on

insert into [Factura]
(
	[datFecha],
	[intIdCliente]
)
values
(
	@datFecha,
	@intIdCliente
)

select scope_identity()


GO
/****** Object:  StoredProcedure [dbo].[FacturaSelect]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[FacturaSelect]
(
	@intId int
)

as

set nocount on

select [intId],
	[datFecha],
	[intIdCliente]
from [Factura]
where [intId] = @intId


GO
/****** Object:  StoredProcedure [dbo].[FacturaSelectAll]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[FacturaSelectAll]

as

set nocount on

select [intId],
	[datFecha],
	[intIdCliente]
from [Factura]


GO
/****** Object:  StoredProcedure [dbo].[FacturaSelectAllByIntIdCliente]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[FacturaSelectAllByIntIdCliente]
(
	@intIdCliente int
)

as

set nocount on

select [intId],
	[datFecha],
	[intIdCliente]
from [Factura]
where [intIdCliente] = @intIdCliente


GO
/****** Object:  StoredProcedure [dbo].[FacturaUpdate]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[FacturaUpdate]
(
	@intId int,
	@datFecha datetime,
	@intIdCliente int
)

as

set nocount on

update [Factura]
set [datFecha] = @datFecha,
	[intIdCliente] = @intIdCliente
where [intId] = @intId


GO
/****** Object:  StoredProcedure [dbo].[ProductoDelete]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ProductoDelete]
(
	@intId int
)

as

set nocount on

delete from [Producto]
where [intId] = @intId


GO
/****** Object:  StoredProcedure [dbo].[ProductoInsert]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ProductoInsert]
(
	@varNombre nvarchar(50),
	@decPrecio decimal(18, 2),
	@intStock int
)

as

set nocount on

insert into [Producto]
(
	[varNombre],
	[decPrecio],
	[intStock]
)
values
(
	@varNombre,
	@decPrecio,
	@intStock
)

select scope_identity()


GO
/****** Object:  StoredProcedure [dbo].[ProductoSelect]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ProductoSelect]
(
	@intId int
)

as

set nocount on

select [intId],
	[varNombre],
	[decPrecio],
	[intStock]
from [Producto]
where [intId] = @intId


GO
/****** Object:  StoredProcedure [dbo].[ProductoSelectAll]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ProductoSelectAll]

as

set nocount on

select [intId],
	[varNombre],
	[decPrecio],
	[intStock]
from [Producto]


GO
/****** Object:  StoredProcedure [dbo].[ProductoUpdate]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ProductoUpdate]
(
	@intId int,
	@varNombre nvarchar(50),
	@decPrecio decimal(18, 2),
	@intStock int
)

as

set nocount on

update [Producto]
set [varNombre] = @varNombre,
	[decPrecio] = @decPrecio,
	[intStock] = @intStock
where [intId] = @intId


GO
/****** Object:  StoredProcedure [dbo].[sp_get_all_clientes]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create  procedure [dbo].[sp_get_all_clientes]
as

set nocount on

select  * from [dbo].[Cliente];


GO
/****** Object:  StoredProcedure [dbo].[sp_get_all_productos]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create  procedure [dbo].[sp_get_all_productos]
as

set nocount on

select  * from Producto;


GO
/****** Object:  StoredProcedure [dbo].[sp_get_max_id]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create  procedure [dbo].[sp_get_max_id]
as

set nocount on

select  max(intId) from [dbo].[Factura];


GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[intId] [int] IDENTITY(1,1) NOT NULL,
	[varNombre] [nvarchar](50) NOT NULL,
	[varApellido] [nvarchar](50) NOT NULL,
	[varDireccion] [nvarchar](50) NOT NULL,
	[varTelefono] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[intId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[intId] [int] IDENTITY(1,1) NOT NULL,
	[intIdProducto] [int] NOT NULL,
	[intIdFactura] [int] NOT NULL,
	[intCantidad] [int] NULL,
 CONSTRAINT [PK_DetalleFactura_1] PRIMARY KEY CLUSTERED 
(
	[intId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Factura]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[intId] [int] IDENTITY(1,1) NOT NULL,
	[datFecha] [datetime] NOT NULL,
	[intIdCliente] [int] NOT NULL,
 CONSTRAINT [PK_DetalleFactura] PRIMARY KEY CLUSTERED 
(
	[intId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 27/11/2018 17:31:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[intId] [int] IDENTITY(1,1) NOT NULL,
	[varNombre] [nvarchar](50) NOT NULL,
	[decPrecio] [decimal](18, 2) NOT NULL,
	[intStock] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[intId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Factura] FOREIGN KEY([intIdFactura])
REFERENCES [dbo].[Factura] ([intId])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Factura]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Producto] FOREIGN KEY([intIdProducto])
REFERENCES [dbo].[Producto] ([intId])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Producto]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Cliente] FOREIGN KEY([intIdCliente])
REFERENCES [dbo].[Cliente] ([intId])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Cliente]
GO
USE [master]
GO
ALTER DATABASE [FacturacionLUG] SET  READ_WRITE 
GO
