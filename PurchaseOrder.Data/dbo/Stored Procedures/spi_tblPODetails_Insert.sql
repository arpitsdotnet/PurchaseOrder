CREATE PROCEDURE [dbo].[spi_tblPODetails_Insert]
	@ID INT = 0 OUTPUT,
	@POID INT,
	@ItemID INT,
	@Details NVARCHAR(50),
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
			
		INSERT INTO [dbo].[tblPODetails]([POID],[ItemID],[Details],[Qty],[Rate],[Amount],[DiscPer],[Discount],[TotalAmt])
			 VALUES(@POID,@ItemID,@Details,@Qty,@Rate,@Amount,@DiscPer,@Discount,@TotalAmt);
			 
		SELECT @ID = SCOPE_IDENTITY();

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH		
		
		ROLLBACK TRANSACTION		

	END CATCH 
END
