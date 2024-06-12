    SELECT
	q.nextOrderId,
	q.nextProductId,
	q.nextQuantity,
	q.NextUnitPrice,
	q.nextDiscount,

	q.previousOrderId,
	q.previousProductId,
	q.previousQuantity,
	q.previouspPrice,
	q.previousDiscount,
	q.RowNumber,
(SELECT TOP(1) OrderId FROM Product_Ordered ORDER BY OrderId) AS FirstOrderID,
(SELECT TOP(1) ProductId FROM Product_Ordered ORDER BY OrderId) AS FirstProductID,
(SELECT TOP(1) Quantity FROM Product_Ordered ORDER BY OrderId) AS FirstQuantity,
(SELECT TOP(1) UnitPrice FROM Product_Ordered ORDER BY OrderId) AS FirstUnitPrice,
(SELECT TOP(1) Discount FROM Product_Ordered ORDER BY OrderId) AS FirstDiscount,

(SELECT TOP(1) OrderId FROM Product_Ordered ORDER BY OrderId DESC) AS LastOrderID,
(SELECT TOP(1) ProductId FROM Product_Ordered ORDER BY OrderId DESC) AS LastProductID,
(SELECT TOP(1) Quantity FROM Product_Ordered ORDER BY OrderId DESC) AS LastQuantity,
(SELECT TOP(1) UnitPrice FROM Product_Ordered ORDER BY OrderId DESC) AS LastUnitPrice,
(SELECT TOP(1) Discount FROM Product_Ordered ORDER BY OrderId DESC) AS LastDiscount
FROM
(
SELECT OrderId, ProductId, Quantity,UnitPrice,Discount,
LEAD(OrderId) OVER(ORDER BY OrderId) AS nextOrderId,
LEAD(ProductId) OVER(ORDER BY OrderId) AS NextProductId,
LEAD(Quantity) OVER(ORDER BY OrderId) AS NextQuantity,
LEAD(UnitPrice) OVER(ORDER BY OrderId) AS NextUnitPrice,
LEAD(Discount) OVER(ORDER BY OrderId) AS NextDiscount,

LAG(OrderId) OVER(ORDER BY OrderId) AS previousOrderId,
LAG(ProductId) OVER(ORDER BY OrderId) AS previousProductId,
LAG(Quantity) OVER(ORDER BY OrderId) AS previousQuantity,
LAG(UnitPrice) OVER(ORDER BY OrderId) AS previouspPrice,
LAG(Discount) OVER(ORDER BY OrderId) AS previousDiscount,
ROW_NUMBER() OVER(ORDER BY OrderId) AS RowNumber
FROM Product_Ordered) AS q
WHERE 
q.OrderId = 1 
and q.ProductId = 1
and q.Quantity = 0
and q.UnitPrice = 0
and q.Discount = 0
;



---- CRUD
INSERT INTO Product_Ordered
(OrderId, ProductId, Quantity, UnitPrice, Discount)
VALUES
();


--DELETE
DELETE FROM Product_Ordered WHERE OrderId = 0 AND ProductId = 0;

--Update

 UPDATE Product_Ordered
    SET OrderId = 0,
    ProductId = 0,
    Quantity = 0,
    UnitPrice = 0,
	Discount = 0
    WHERE OrderId = 0 
	AND ProductId = 0; 
	
