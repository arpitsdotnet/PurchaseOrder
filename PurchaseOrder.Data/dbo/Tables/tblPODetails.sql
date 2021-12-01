CREATE TABLE [dbo].[tblPODetails]
(
	[PODetailsID] INT NOT NULL PRIMARY KEY IDENTITY,
	[POID] INT NULL,
	[ItemID] INT NULL,
	[Details] NVARCHAR(50),
	[Qty] INT NULL,
	[Rate] DECIMAL(18,4) NULL,
	[Amount] DECIMAL(18,4) NULL,
	[DiscPer] DECIMAL(2,2) NULL,
	[Discount] DECIMAL(18,4) NULL,
	[TotalAmt] DECIMAL(18,4) NULL, 
    CONSTRAINT [FK_tblPODetails_tblPOMaster] FOREIGN KEY ([POID]) REFERENCES [tblPOMaster]([POID]),
    CONSTRAINT [FK_tblPODetails_tblItemMaster] FOREIGN KEY ([ItemID]) REFERENCES [tblItemMaster]([ItemID]),
)
