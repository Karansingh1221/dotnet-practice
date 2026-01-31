USE [SalesDb]
GO

/****** Object:  Table [dbo].[Product_Master]    Script Date: 31-01-2026 15:36:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product_Master](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[unit_price] [int] NOT NULL
) ON [PRIMARY]
GO

