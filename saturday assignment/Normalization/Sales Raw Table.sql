USE [SalesDb]
GO

/****** Object:  Table [dbo].[Sales_Raw]    Script Date: 31-01-2026 15:35:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sales_Raw](
	[OrderID] [int] NULL,
	[OrderDate] [varchar](20) NULL,
	[CustomerName] [varchar](100) NULL,
	[CustomerPhone] [varchar](20) NULL,
	[CustomerCity] [varchar](50) NULL,
	[ProductNames] [varchar](200) NULL,
	[Quantities] [varchar](100) NULL,
	[UnitPrices] [varchar](100) NULL,
	[SalesPerson] [varchar](100) NULL
) ON [PRIMARY]
GO

