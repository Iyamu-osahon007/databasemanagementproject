USE [master]

IF EXISTS (
        SELECT *
        FROM sys.databases
        WHERE name = 'InventoryManager'
        )
BEGIN
    DROP Database [InventoryManager]
END
GO

GO
CREATE DATABASE [InventoryManager]
Go

USE [InventoryManager]
GO

/*
	Drop FK Contrains on Many-to-Many
*/
IF (EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'dbo' 
                 AND  TABLE_NAME = 'OrderedProduct'))
BEGIN    
	ALTER TABLE Assignments DROP CONSTRAINT IF EXISTS [FK_OrderedProduct_Order]
	ALTER TABLE Assignments DROP CONSTRAINT IF EXISTS [FK_OrderedProduct_Product]	
	ALTER TABLE Assignments DROP CONSTRAINT IF EXISTS [CK_OrderedProduct_Order_Product]	
END

GO
DROP TABLE IF EXISTS OrderedProduct
GO

/*
Orders Table
*/
IF (EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_SCHEMA = 'dbo' 
                 AND  TABLE_NAME = 'Orders'))
BEGIN   
	
	ALTER TABLE Orders DROP CONSTRAINT IF EXISTS [DF_Orders_freight]
	--ALTER TABLE Courses DROP CONSTRAINT IF EXISTS [CK_Courses_Credits]
END

GO
DROP TABLE IF EXISTS Orders
GO

CREATE TABLE Orders(
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [date] NULL,
	[RequiredDate] [date] NULL,
	[ShippedDate] [date] NULL,
	[ShipName] [nvarchar](40) NULL,
	[ShipAddress] [nvarchar](60) NULL,
	[ShipCity] [nvarchar](15) NULL,
	[ShipRegion] [nvarchar](60) NULL,
	[ShipPostalCode] [nvarchar](10) NULL,
	[ShipCountry] [nvarchar](60) NULL,
	[Freight] [money] NULL

 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [Orders] ADD  CONSTRAINT [DF_Orders_Freight]  DEFAULT ((0)) FOR [Freight]
GO


/*
Product Table
*/

DROP TABLE IF EXISTS Product
GO

CREATE TABLE Product(
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[PricePerUnit] [money] NULL,
	[Quantity] [nvarchar](20) NULL,
	[Stock] [smallint] NULL,
	[UnitOrder] [smallint] NULL,
	[ReOrderLevel] [smallint] NULL,
	[Discontinued] [bit] NOT NULL
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Product]  WITH NOCHECK ADD  CONSTRAINT [CK_Products_UnitPrice] CHECK  (([PricePerUnit]>=(0)))
GO

ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [CK_Products_UnitPrice]
GO

ALTER TABLE [dbo].[Product]  WITH NOCHECK ADD  CONSTRAINT [CK_ReorderLevel] CHECK  (([ReOrderLevel]>=(0)))
GO

ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [CK_ReorderLevel]
GO

ALTER TABLE [dbo].[Product]  WITH NOCHECK ADD  CONSTRAINT [CK_UnitsInStock] CHECK  (([Stock]>=(0)))
GO

ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [CK_UnitsInStock]
GO


--ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_Discontinued]  DEFAULT ((0)) FOR [Discontinued]
--GO



--AWAITING UPDATE
/*
	OrderedProduct Table
*/

CREATE TABLE Product_Ordered(
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [smallint] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Discount] [real] NOT NULL
 CONSTRAINT [PK_Assignments] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
	
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE Product_Ordered  WITH CHECK ADD  CONSTRAINT [FK_Product_Ordered_Order] FOREIGN KEY([OrderId])
REFERENCES Orders ([OrderId])
GO

ALTER TABLE Product_Ordered CHECK CONSTRAINT [FK_Product_Ordered_Order]
GO

ALTER TABLE Product_Ordered WITH CHECK ADD  CONSTRAINT [FK_Product_Ordered_Products] FOREIGN KEY([ProductId])
REFERENCES Product ([ProductId])
GO

ALTER TABLE Product_Ordered CHECK CONSTRAINT [FK_Product_Ordered_Products]
GO



/*
Seed data
*/
SET IDENTITY_INSERT Product ON  
INSERT INTO Product (ProductId,ProductName,PricePerUnit,Quantity,Stock,UnitOrder,ReOrderLevel,Discontinued) VALUES(1,'Chai',18.00,'10 oxes x 20bags',39,0,10,0)
INSERT INTO Product (ProductId,ProductName,PricePerUnit,Quantity,Stock,UnitOrder,ReOrderLevel,Discontinued) VALUES(2,'Chang',19.00,'24 -12 oz bottles',17,40,25,0)
INSERT INTO Product (ProductId,ProductName,PricePerUnit,Quantity,Stock,UnitOrder,ReOrderLevel,Discontinued) VALUES(3,'chef Anton"s" Cajun Seasoning',22.00,'48 -6 oz jars',53,0,0,0)
INSERT INTO Product (ProductId,ProductName,PricePerUnit,Quantity,Stock,UnitOrder,ReOrderLevel,Discontinued) VALUES(4,'Chef Anton"s" Gumbo Mix',21.35,'36 boxes',0,0,0,1)
INSERT INTO Product (ProductId,ProductName,PricePerUnit,Quantity,Stock,UnitOrder,ReOrderLevel,Discontinued) VALUES(5,'Grandma"s" Boysenberry Spread',25.00,'12-8 oz jars',120,0,25,0)
SET IDENTITY_INSERT Product OFF

SET IDENTITY_INSERT Orders ON  
INSERT INTO Orders (OrderId,OrderDate,RequiredDate,ShippedDate,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry,Freight) VALUES(10248,'1996-07-04','1996-08-01','1996-07-16','Vins et alcool Chevalier','59 rue de l"Abbaye','Reims',NULL,5100,'France',41.34)
SET IDENTITY_INSERT Orders OFF

INSERT INTO Product_Ordered VALUES(10248,1,12,14.00,0)


