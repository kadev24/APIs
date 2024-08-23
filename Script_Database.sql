USE master
GO

CREATE DATABASE [IncaFC]
GO

USE [IncaFC]
GO
/****** Object:  Schema [Seguridad]    Script Date: 23/08/2024 18:32:11 ******/
CREATE SCHEMA [Seguridad]
GO
/****** Object:  Schema [Ventas]    Script Date: 23/08/2024 18:32:11 ******/
CREATE SCHEMA [Ventas]
GO
/****** Object:  Table [Seguridad].[RolUsuario]    Script Date: 23/08/2024 18:32:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Seguridad].[RolUsuario](
	[IdUsuarioRol] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[Rol] [varchar](50) NULL,
	[Activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuarioRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Seguridad].[Usuario]    Script Date: 23/08/2024 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Seguridad].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Clave] [varchar](50) NULL,
	[Correo] [varchar](100) NULL,
	[Activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Ventas].[Almacen]    Script Date: 23/08/2024 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ventas].[Almacen](
	[IdAlmacen] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Direccion] [varchar](300) NULL,
	[Activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdAlmacen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Ventas].[Articulo]    Script Date: 23/08/2024 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ventas].[Articulo](
	[IdArticulo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](200) NULL,
	[IdMarca] [int] NULL,
	[IdCategoria] [int] NULL,
	[Activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Ventas].[ArticuloAlmacen]    Script Date: 23/08/2024 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ventas].[ArticuloAlmacen](
	[IdAlmacen] [int] NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[Precio] [decimal](10, 2) NULL,
	[FechaActualizacion] [datetime] NULL,
	[UsuarioActualizacion] [varchar](50) NULL,
	[Estado] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdAlmacen] ASC,
	[IdArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Ventas].[ArticuloCategoria]    Script Date: 23/08/2024 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ventas].[ArticuloCategoria](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Ventas].[ArticuloMarca]    Script Date: 23/08/2024 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ventas].[ArticuloMarca](
	[IdMarca] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Ventas].[Cliente]    Script Date: 23/08/2024 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ventas].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[RUC] [varchar](50) NULL,
	[RazonSocial] [varchar](100) NULL,
	[DireccionFiscal] [varchar](300) NULL,
	[Ubigeo] [varchar](20) NULL,
	[Telefono] [varchar](20) NULL,
	[TipoCliente] [char](1) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK__Cliente__D594664285F728AA] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Ventas].[CondicionPago]    Script Date: 23/08/2024 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ventas].[CondicionPago](
	[IdCondicionPago] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](300) NULL,
	[Activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCondicionPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Ventas].[Factura]    Script Date: 23/08/2024 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ventas].[Factura](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NULL,
	[IdVendedor] [int] NULL,
	[IdCondicionPago] [int] NULL,
	[PedidoAsociado] [int] NULL,
	[FechaRequerida] [date] NULL,
	[FechaFactura] [datetime] NULL,
	[TotalDescuento] [decimal](10, 2) NULL,
	[Total] [decimal](10, 2) NULL,
	[EstadoFactura] [char](1) NULL,
	[UsuarioRegistro] [varchar](50) NULL,
	[FechaRegistro] [datetime] NULL,
	[UsuarioModifica] [varchar](50) NULL,
	[FechaModifica] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Ventas].[FacturaLinea]    Script Date: 23/08/2024 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ventas].[FacturaLinea](
	[IdFacturaLinea] [int] IDENTITY(1,1) NOT NULL,
	[IdFactura] [int] NULL,
	[IdArticulo] [int] NULL,
	[IdAlmacen] [int] NULL,
	[PrecioLista] [decimal](10, 2) NULL,
	[Cantidad] [int] NULL,
	[Moneda] [varchar](5) NULL,
	[ImpuestoIgv] [decimal](10, 2) NULL,
	[Descuento] [decimal](10, 2) NULL,
	[Subtotal] [decimal](10, 2) NULL,
	[UsuarioRegistro] [varchar](50) NULL,
	[FechaRegistro] [datetime] NULL,
	[UsuarioModifica] [varchar](50) NULL,
	[FechaModifica] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFacturaLinea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Ventas].[Pedido]    Script Date: 23/08/2024 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ventas].[Pedido](
	[IdPedido] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NULL,
	[IdVendedor] [int] NULL,
	[IdCondicionPago] [int] NULL,
	[FechaRequerida] [date] NULL,
	[FechaPedido] [datetime] NULL,
	[TotalDescuento] [decimal](10, 2) NULL,
	[Total] [decimal](10, 2) NULL,
	[EstadoPedido] [char](1) NULL,
	[UsuarioRegistro] [varchar](50) NULL,
	[FechaRegistro] [datetime] NULL,
	[UsuarioModifica] [varchar](50) NULL,
	[FechaModifica] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Ventas].[PedidoLinea]    Script Date: 23/08/2024 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ventas].[PedidoLinea](
	[IdPedidoLinea] [int] IDENTITY(1,1) NOT NULL,
	[IdPedido] [int] NULL,
	[IdArticulo] [int] NULL,
	[IdAlmacen] [int] NULL,
	[PrecioLista] [decimal](10, 2) NULL,
	[Cantidad] [int] NULL,
	[Moneda] [varchar](5) NULL,
	[ImpuestoIgv] [decimal](10, 2) NULL,
	[Descuento] [decimal](10, 2) NULL,
	[Subtotal] [decimal](10, 2) NULL,
	[UsuarioRegistro] [varchar](50) NULL,
	[FechaRegistro] [datetime] NULL,
	[UsuarioModifica] [varchar](50) NULL,
	[FechaModifica] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPedidoLinea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Ventas].[Vendedor]    Script Date: 23/08/2024 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ventas].[Vendedor](
	[IdVendedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVendedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [Seguridad].[RolUsuario] ON 
GO
INSERT [Seguridad].[RolUsuario] ([IdUsuarioRol], [IdUsuario], [Rol], [Activo]) VALUES (1, 1, N'admin', 1)
GO
INSERT [Seguridad].[RolUsuario] ([IdUsuarioRol], [IdUsuario], [Rol], [Activo]) VALUES (2, 2, N'user', 1)
GO
SET IDENTITY_INSERT [Seguridad].[RolUsuario] OFF
GO
SET IDENTITY_INSERT [Seguridad].[Usuario] ON 
GO
INSERT [Seguridad].[Usuario] ([IdUsuario], [Usuario], [Clave], [Correo], [Activo]) VALUES (1, N'kevin', N'123456', N'kevin@gmail.com', 1)
GO
INSERT [Seguridad].[Usuario] ([IdUsuario], [Usuario], [Clave], [Correo], [Activo]) VALUES (2, N'jose', N'abcdefg', N'jose@gmail.com', 1)
GO
SET IDENTITY_INSERT [Seguridad].[Usuario] OFF
GO
SET IDENTITY_INSERT [Ventas].[Almacen] ON 
GO
INSERT [Ventas].[Almacen] ([IdAlmacen], [Nombre], [Direccion], [Activo]) VALUES (1, N'Almacen Ica', N'Av. Simon Bolivar 23122', 1)
GO
SET IDENTITY_INSERT [Ventas].[Almacen] OFF
GO
SET IDENTITY_INSERT [Ventas].[Articulo] ON 
GO
INSERT [Ventas].[Articulo] ([IdArticulo], [Descripcion], [IdMarca], [IdCategoria], [Activo]) VALUES (1, N'Leche Gloria Lata', 1, 1, 1)
GO
INSERT [Ventas].[Articulo] ([IdArticulo], [Descripcion], [IdMarca], [IdCategoria], [Activo]) VALUES (2, N'Jamon Entero', 2, 2, 1)
GO
INSERT [Ventas].[Articulo] ([IdArticulo], [Descripcion], [IdMarca], [IdCategoria], [Activo]) VALUES (3, N'Aceite Botella', 3, 2, 1)
GO
SET IDENTITY_INSERT [Ventas].[Articulo] OFF
GO
INSERT [Ventas].[ArticuloAlmacen] ([IdAlmacen], [IdArticulo], [Precio], [FechaActualizacion], [UsuarioActualizacion], [Estado]) VALUES (1, 1, CAST(5.00 AS Decimal(10, 2)), CAST(N'2024-08-23T14:48:13.613' AS DateTime), N'JSOLIS', N'1')
GO
SET IDENTITY_INSERT [Ventas].[ArticuloCategoria] ON 
GO
INSERT [Ventas].[ArticuloCategoria] ([IdCategoria], [Descripcion]) VALUES (1, N'Lácteos')
GO
INSERT [Ventas].[ArticuloCategoria] ([IdCategoria], [Descripcion]) VALUES (2, N'Abarrotes')
GO
SET IDENTITY_INSERT [Ventas].[ArticuloCategoria] OFF
GO
SET IDENTITY_INSERT [Ventas].[ArticuloMarca] ON 
GO
INSERT [Ventas].[ArticuloMarca] ([IdMarca], [Descripcion]) VALUES (1, N'Gloria')
GO
INSERT [Ventas].[ArticuloMarca] ([IdMarca], [Descripcion]) VALUES (2, N'Braedt')
GO
INSERT [Ventas].[ArticuloMarca] ([IdMarca], [Descripcion]) VALUES (3, N'Primor')
GO
SET IDENTITY_INSERT [Ventas].[ArticuloMarca] OFF
GO
SET IDENTITY_INSERT [Ventas].[Cliente] ON 
GO
INSERT [Ventas].[Cliente] ([IdCliente], [RUC], [RazonSocial], [DireccionFiscal], [Ubigeo], [Telefono], [TipoCliente], [Activo]) VALUES (1, N'32100092312', N'DISTRIBUIDORA SANTA ROSA E.R.L', N'Jr.Camana 323123', N'32122', N'983220012', N'J', 1)
GO
INSERT [Ventas].[Cliente] ([IdCliente], [RUC], [RazonSocial], [DireccionFiscal], [Ubigeo], [Telefono], [TipoCliente], [Activo]) VALUES (2, N'20552103816', N'AGROLIGHT PERU S.A.C.	', N'Jr.Camana 323123', N'32122', N'983220012', N'J', 1)
GO
INSERT [Ventas].[Cliente] ([IdCliente], [RUC], [RazonSocial], [DireccionFiscal], [Ubigeo], [Telefono], [TipoCliente], [Activo]) VALUES (3, N'20538856674', N'ARTROSCOPICTRAUMA S.A.C.', N'Jr.Camana 323123', N'32122', N'322122231', N'J', 1)
GO
INSERT [Ventas].[Cliente] ([IdCliente], [RUC], [RazonSocial], [DireccionFiscal], [Ubigeo], [Telefono], [TipoCliente], [Activo]) VALUES (4, N'20553856451', N'BI GRAND CONFECCIONES S.A.C.', N'Jr.Camana 323123', N'32122', N'944411003', N'J', 1)
GO
INSERT [Ventas].[Cliente] ([IdCliente], [RUC], [RazonSocial], [DireccionFiscal], [Ubigeo], [Telefono], [TipoCliente], [Activo]) VALUES (5, N'20480316259', N'D AROMAS E.I.R.L.', N'Jr.Camana 323123', N'32122', N'900022133', N'J', 1)
GO
INSERT [Ventas].[Cliente] ([IdCliente], [RUC], [RazonSocial], [DireccionFiscal], [Ubigeo], [Telefono], [TipoCliente], [Activo]) VALUES (6, N'20547825781', N'DMG DRILLING E.I.R.L.', N'Jr.Camana 323123', N'32122', N'900088731', N'J', 1)
GO
SET IDENTITY_INSERT [Ventas].[Cliente] OFF
GO
SET IDENTITY_INSERT [Ventas].[CondicionPago] ON 
GO
INSERT [Ventas].[CondicionPago] ([IdCondicionPago], [Descripcion], [Activo]) VALUES (1, N'CONTADO', 1)
GO
SET IDENTITY_INSERT [Ventas].[CondicionPago] OFF
GO
SET IDENTITY_INSERT [Ventas].[Pedido] ON 
GO
INSERT [Ventas].[Pedido] ([IdPedido], [IdCliente], [IdVendedor], [IdCondicionPago], [FechaRequerida], [FechaPedido], [TotalDescuento], [Total], [EstadoPedido], [UsuarioRegistro], [FechaRegistro], [UsuarioModifica], [FechaModifica]) VALUES (3, 2, 1, 1, CAST(N'2024-04-28' AS Date), CAST(N'2024-08-23T16:43:08.450' AS DateTime), CAST(0.00 AS Decimal(10, 2)), CAST(150.00 AS Decimal(10, 2)), N'R', N'JSOLIS', CAST(N'2024-08-23T16:43:08.450' AS DateTime), N'', NULL)
GO
INSERT [Ventas].[Pedido] ([IdPedido], [IdCliente], [IdVendedor], [IdCondicionPago], [FechaRequerida], [FechaPedido], [TotalDescuento], [Total], [EstadoPedido], [UsuarioRegistro], [FechaRegistro], [UsuarioModifica], [FechaModifica]) VALUES (4, 1, 2, 1, CAST(N'2024-05-28' AS Date), CAST(N'2024-08-23T17:41:28.103' AS DateTime), CAST(0.00 AS Decimal(10, 2)), CAST(400.00 AS Decimal(10, 2)), N'R', N'KTELLO', CAST(N'2024-08-23T17:41:28.103' AS DateTime), N'', NULL)
GO
SET IDENTITY_INSERT [Ventas].[Pedido] OFF
GO
SET IDENTITY_INSERT [Ventas].[PedidoLinea] ON 
GO
INSERT [Ventas].[PedidoLinea] ([IdPedidoLinea], [IdPedido], [IdArticulo], [IdAlmacen], [PrecioLista], [Cantidad], [Moneda], [ImpuestoIgv], [Descuento], [Subtotal], [UsuarioRegistro], [FechaRegistro], [UsuarioModifica], [FechaModifica]) VALUES (1, 3, 2, 1, CAST(5.00 AS Decimal(10, 2)), 10, N'PEN', CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'JSOLIS', CAST(N'2024-08-23T16:43:08.453' AS DateTime), N'', NULL)
GO
INSERT [Ventas].[PedidoLinea] ([IdPedidoLinea], [IdPedido], [IdArticulo], [IdAlmacen], [PrecioLista], [Cantidad], [Moneda], [ImpuestoIgv], [Descuento], [Subtotal], [UsuarioRegistro], [FechaRegistro], [UsuarioModifica], [FechaModifica]) VALUES (2, 4, 2, 1, CAST(100.00 AS Decimal(10, 2)), 4, N'PEN', CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(400.00 AS Decimal(10, 2)), N'JSOLIS', CAST(N'2024-08-23T17:41:28.103' AS DateTime), N'', NULL)
GO
SET IDENTITY_INSERT [Ventas].[PedidoLinea] OFF
GO
SET IDENTITY_INSERT [Ventas].[Vendedor] ON 
GO
INSERT [Ventas].[Vendedor] ([IdVendedor], [Nombre], [Activo]) VALUES (1, N'Luis Sanchez Maldonado', 1)
GO
INSERT [Ventas].[Vendedor] ([IdVendedor], [Nombre], [Activo]) VALUES (2, N'CONTADO', 1)
GO
SET IDENTITY_INSERT [Ventas].[Vendedor] OFF
GO
ALTER TABLE [Seguridad].[RolUsuario]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [Seguridad].[Usuario] ([IdUsuario])
GO
ALTER TABLE [Ventas].[Articulo]  WITH CHECK ADD FOREIGN KEY([IdCategoria])
REFERENCES [Ventas].[ArticuloCategoria] ([IdCategoria])
GO
ALTER TABLE [Ventas].[Articulo]  WITH CHECK ADD FOREIGN KEY([IdMarca])
REFERENCES [Ventas].[ArticuloMarca] ([IdMarca])
GO
ALTER TABLE [Ventas].[ArticuloAlmacen]  WITH CHECK ADD FOREIGN KEY([IdAlmacen])
REFERENCES [Ventas].[Almacen] ([IdAlmacen])
GO
ALTER TABLE [Ventas].[ArticuloAlmacen]  WITH CHECK ADD FOREIGN KEY([IdArticulo])
REFERENCES [Ventas].[Articulo] ([IdArticulo])
GO
ALTER TABLE [Ventas].[Factura]  WITH CHECK ADD  CONSTRAINT [FK__Factura__IdClien__06CD04F7] FOREIGN KEY([IdCliente])
REFERENCES [Ventas].[Cliente] ([IdCliente])
GO
ALTER TABLE [Ventas].[Factura] CHECK CONSTRAINT [FK__Factura__IdClien__06CD04F7]
GO
ALTER TABLE [Ventas].[Factura]  WITH CHECK ADD FOREIGN KEY([IdCondicionPago])
REFERENCES [Ventas].[CondicionPago] ([IdCondicionPago])
GO
ALTER TABLE [Ventas].[Factura]  WITH CHECK ADD FOREIGN KEY([IdVendedor])
REFERENCES [Ventas].[Vendedor] ([IdVendedor])
GO
ALTER TABLE [Ventas].[Factura]  WITH CHECK ADD FOREIGN KEY([PedidoAsociado])
REFERENCES [Ventas].[Pedido] ([IdPedido])
GO
ALTER TABLE [Ventas].[FacturaLinea]  WITH CHECK ADD FOREIGN KEY([IdAlmacen])
REFERENCES [Ventas].[Almacen] ([IdAlmacen])
GO
ALTER TABLE [Ventas].[FacturaLinea]  WITH CHECK ADD FOREIGN KEY([IdArticulo])
REFERENCES [Ventas].[Articulo] ([IdArticulo])
GO
ALTER TABLE [Ventas].[FacturaLinea]  WITH CHECK ADD FOREIGN KEY([IdFactura])
REFERENCES [Ventas].[Factura] ([IdFactura])
GO
ALTER TABLE [Ventas].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK__Pedido__IdClient__46E78A0C] FOREIGN KEY([IdCliente])
REFERENCES [Ventas].[Cliente] ([IdCliente])
GO
ALTER TABLE [Ventas].[Pedido] CHECK CONSTRAINT [FK__Pedido__IdClient__46E78A0C]
GO
ALTER TABLE [Ventas].[Pedido]  WITH CHECK ADD FOREIGN KEY([IdCondicionPago])
REFERENCES [Ventas].[CondicionPago] ([IdCondicionPago])
GO
ALTER TABLE [Ventas].[Pedido]  WITH CHECK ADD FOREIGN KEY([IdVendedor])
REFERENCES [Ventas].[Vendedor] ([IdVendedor])
GO
ALTER TABLE [Ventas].[PedidoLinea]  WITH CHECK ADD FOREIGN KEY([IdAlmacen])
REFERENCES [Ventas].[Almacen] ([IdAlmacen])
GO
ALTER TABLE [Ventas].[PedidoLinea]  WITH CHECK ADD FOREIGN KEY([IdArticulo])
REFERENCES [Ventas].[Articulo] ([IdArticulo])
GO
ALTER TABLE [Ventas].[PedidoLinea]  WITH CHECK ADD FOREIGN KEY([IdPedido])
REFERENCES [Ventas].[Pedido] ([IdPedido])
GO
