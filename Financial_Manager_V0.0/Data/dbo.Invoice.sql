CREATE TABLE [dbo].[Invoice]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [InvoiceNo] INT NOT NULL PRIMARY KEY,
	[Client] VARCHAR(50) NOT NULL,
	[AccountType] VARCHAR(50) NOT NULL, 
	[Quantity] INT NOT NULL, 
	[UnitPrice] INT NOT NULL,
	[Item] VARCHAR(50) NOT NULL
)
