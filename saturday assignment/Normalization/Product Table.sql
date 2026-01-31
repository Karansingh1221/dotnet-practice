USE [SalesDb]
GO

/****** Object:  Table [dbo].[Product_Tb]    Script Date: 31-01-2026 15:36:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product_Tb](
	[id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Product_Tb] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

