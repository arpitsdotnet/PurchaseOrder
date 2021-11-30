CREATE PROCEDURE [dbo].[spu_tblPODetails_Update]
	@PODetailsID INT,
	@POID INT,
	@ItemID INT,
	@Qty INT,
	@Rate DECIMAL(18,4),
	@Amount DECIMAL(18,4),
	@DiscPer DECIMAL(2,2),
	@Discount DECIMAL(18,4),
	@TotalAmt DECIMAL(18,4)
AS
BEGIN
	BEGIN TRY		
		BEGIN TRANSACTION			

		UPDATE [dbo].[tblPODetails]
		SET
			[POID] = @POID,
			[ItemID] = @ItemID,
			[Qty] = @Qty,
			[Rate] = @Rate,
			[Amount] = @Amount,
			[DiscPer] = @DiscPer,
			[Discount] = @Discount,
			[TotalAmt] = @TotalAmt
		WHERE [PODetailsID] = @PODetailsID

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH		
		
		ROLLBACK TRANSACTION		

	END CATCH 
END
