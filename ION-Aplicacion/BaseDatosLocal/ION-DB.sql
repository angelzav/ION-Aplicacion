CREATE DATABASE [ION_AplicacionContext-f7169762-73a8-413d-b5c9-62e500e00fc1]
GO

USE [ION_AplicacionContext-f7169762-73a8-413d-b5c9-62e500e00fc1]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/09/2020 ******/
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
/****** Object:  Table [dbo].[Cliente]    Script Date: 11/09/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RFC] [nvarchar](13) NOT NULL,
	[Direccion] [nvarchar](250) NOT NULL,
	[nombre] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 11/09/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](150) NOT NULL,
	[Precio] [real] NOT NULL,
	[Stock] [int] NOT NULL,
	[ProveedorID] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 11/09/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RFC] [nvarchar](13) NOT NULL,
	[Nombre] [nvarchar](150) NOT NULL,
	[Direccion] [nvarchar](250) NOT NULL,
	[Telefono] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 11/09/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descuento] [int] NOT NULL,
	[Total] [real] NOT NULL,
	[ClienteID] [int] NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentaDetalle]    Script Date: 11/09/2020 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaDetalle](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CantidadProducto] [int] NOT NULL,
	[Precio] [real] NOT NULL,
	[ProductoID] [int] NOT NULL,
	[VentaID] [int] NOT NULL,
 CONSTRAINT [PK_VentaDetalle] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200908114832_InitialCreate', N'3.1.7')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200908120543_NombreCliente', N'3.1.7')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200911022136_VentasCliente', N'3.1.7')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200911023451_VentaFecha', N'3.1.7')
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 
GO
INSERT [dbo].[Cliente] ([ID], [RFC], [Direccion], [nombre]) VALUES (1, N'ZARA790127KB5', N'Viaducto No. 316 Col. Asturias', N'Angel Zavala')
GO
INSERT [dbo].[Cliente] ([ID], [RFC], [Direccion], [nombre]) VALUES (2, N'SADA791224DF6', N'Sur 138 Col. America', N'David Salasar')
GO
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 
GO
INSERT [dbo].[Producto] ([ID], [Nombre], [Precio], [Stock], [ProveedorID]) VALUES (1, N'Laptop HP', 25000, 85, 2)
GO
INSERT [dbo].[Producto] ([ID], [Nombre], [Precio], [Stock], [ProveedorID]) VALUES (2, N'Laptop Azuz', 23500, 50, 3)
GO
INSERT [dbo].[Producto] ([ID], [Nombre], [Precio], [Stock], [ProveedorID]) VALUES (3, N'Laptop Dell 3000', 18500, 25, 3)
GO
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 
GO
INSERT [dbo].[Proveedor] ([ID], [RFC], [Nombre], [Direccion], [Telefono]) VALUES (1, N'GSTA901230HD1', N'Materiales SA', N'Periferico Sur No. 3138', N'5566889955')
GO
INSERT [dbo].[Proveedor] ([ID], [RFC], [Nombre], [Direccion], [Telefono]) VALUES (2, N'JYST150294DF3', N'Importadora Carso', N'Insurgentes No. 123', N'5544778855')
GO
INSERT [dbo].[Proveedor] ([ID], [RFC], [Nombre], [Direccion], [Telefono]) VALUES (3, N'ABCA901230HD1', N'MAZAR', N'Contituyentes No. 254', N'5522884466')
GO
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 
GO
INSERT [dbo].[Venta] ([ID], [Descuento], [Total], [ClienteID], [Fecha]) VALUES (1, 0, 73500, 2, CAST(N'2019-10-15T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
SET IDENTITY_INSERT [dbo].[VentaDetalle] ON 
GO
INSERT [dbo].[VentaDetalle] ([ID], [CantidadProducto], [Precio], [ProductoID], [VentaID]) VALUES (1, 2, 50000, 1, 1)
GO
INSERT [dbo].[VentaDetalle] ([ID], [CantidadProducto], [Precio], [ProductoID], [VentaID]) VALUES (2, 1, 23500, 2, 1)
GO
SET IDENTITY_INSERT [dbo].[VentaDetalle] OFF
GO
ALTER TABLE [dbo].[Venta] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Fecha]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Proveedor_ProveedorID] FOREIGN KEY([ProveedorID])
REFERENCES [dbo].[Proveedor] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Proveedor_ProveedorID]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente_ClienteID] FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Cliente] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente_ClienteID]
GO
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentaDetalle_Producto_ProductoID] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Producto] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_VentaDetalle_Producto_ProductoID]
GO
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentaDetalle_Venta_VentaID] FOREIGN KEY([VentaID])
REFERENCES [dbo].[Venta] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_VentaDetalle_Venta_VentaID]
GO
