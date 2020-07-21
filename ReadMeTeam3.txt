Yasin Habib

 - PackagesDB.cs
 - Package.cs
 - frmPackages.cs
 - frmUpdate_Add.cs
 - mainForm.cs
 - Validation.cs

/***Please run the following code on sql before running the project***/

alter table Packages
add Product nvarchar(500) null;

_____________________________________________________
Gabriel Sofekun: 

 - Products_SupplierDB.cs
 - Products_Supplier.cs
 - Packages_Products_SupplierDB.cs
 - Packages_Products_Supplier.cs
 - frmUpdate_Products_Sup.cs

/***Please run the following code one block by one on sql before running the project***/

alter table Products_Suppliers
add SupName nvarchar (255) null;

Update Products_Suppliers
SET Products_Suppliers.SupName = Suppliers.SupName
from Products_Suppliers
join Suppliers
on Suppliers.SupplierId = Products_Suppliers.SupplierId;

alter table Products_Suppliers
add ProdName nvarchar (255) null;

Update Products_Suppliers
SET Products_Suppliers.ProdName = Products.ProdName
from Products_Suppliers
join Products
on Products.ProductId = Products_Suppliers.ProductId;
_____________________________________________________
Muhammad Suaid Khan: 

 - ProductDB.cs
 - Product.cs
 - frmProducts.cs
 - frmAddProduct.cs
 - frmEdit_Add.cs
 - Code on Validation.cs
_____________________________________________________
Tony Onyeka: 

 - SupplierDB.cs
 - Supplier.cs
 - frmSuppliers.cs
 - Validate.cs

/***Please run the following code on sql before running the project***/

create PROC [dbo].[spInsertSupplier]
           --@productId int,
          @SupplierName  nvarchar(50)


AS
BEGIN TRANSACTION
   DECLARE @SupplierId int;
   SELECT @SupplierId = coalesce((select max(SupplierId) + 1 from Suppliers), 1)
COMMIT
--IF NOT EXISTS(SELECT * FROM Products WHERE ProductId = @ProductId)
INSERT Suppliers
VALUES ( @SupplierId, @SupplierName);
SELECT *
FROM Suppliers
where SupplierId = @SupplierId;
RETURN @SupplierId;
GO 