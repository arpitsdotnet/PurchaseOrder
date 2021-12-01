CREATE PROCEDURE [dbo].[spi_tblPOMaster_Insert]
	@ID INT = 0 OUTPUT,
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
			
		INSERT INTO [dbo].[tblPOMaster]([PONo],[PODate],[PartyID],[Remarks],[TotalQty],[TotalAmount],[TotalDiscount],[GrandTotal],[Terms])
			 VALUES(@PONo,@PODate,@PartyID,@Remarks,@TotalQty,@TotalAmount,@TotalDiscount,@GrandTotal,@Terms);
			 
		SELECT @ID = SCOPE_IDENTITY();

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH		
		
		ROLLBACK TRANSACTION		

	END CATCH 
END