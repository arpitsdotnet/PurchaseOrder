CREATE TABLE [dbo].[tblPOMaster]
(
	[POID] INT NOT NULL PRIMARY KEY IDENTITY,
	[PartyID] INT NULL,
	[PONo] NVARCHAR(50) NULL,
	[PODate] DATETIME NULL,
	[Remarks] NVARCHAR(100) NULL,
	[TotalQty] INT NULL,
	[TotalAmount] DECIMAL(18,4) NULL,
	[TotalDiscount] DECIMAL(18,4) NULL,
	[GrandTotal] DECIMAL(18,4) NULL,
	[Terms] NVARCHAR(200) NULL, 
    CONSTRAINT [FK_tblPOMaster_tblPartyMaster] FOREIGN KEY ([PartyID]) REFERENCES [tblPartyMaster]([PartyID]),
)
