CREATE PROCEDURE [dbo].[spu_tblPOMaster_Update]
	@POID INT,
	@PONo NVARCHAR(50),
	@PODate DATETIME,
	@PartyID INT,
	@Remarks NVARCHAR(100),
	@TotalQty DECIMAL(18,4),
	@TotalAmount DECIMAL(18,4),
	@TotalDiscount DECIMAL(18,4),
	@GrandTotal DECIMAL(18,4),
	@Terms NVARCHAR(200)
AS
BEGIN
	BEGIN TRY		
		BEGIN TRANSACTION			

		UPDATE [dbo].[tblPOMaster]
		SET
			[PONo] = @PONo,
			[PODate] = @PONo,
			[PartyID] = @PartyID,
			[Remarks] = @Remarks,
			[TotalQty] = @TotalQty,
			[TotalAmount] = @TotalAmount,
			[TotalDiscount] = @TotalDiscount,
			[GrandTotal] = @GrandTotal,
			[Terms] = @Terms
		WHERE [POID] = @POID

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH		
		
		ROLLBACK TRANSACTION		

	END CATCH 
END