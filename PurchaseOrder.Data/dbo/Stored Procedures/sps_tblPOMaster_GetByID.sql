CREATE PROCEDURE [dbo].[sps_tblPOMaster_GetByID]
	@POID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [POID],[PONo],[PODate],[PartyID],[Remarks],[TotalQty],[TotalAmount],[TotalDiscount],[GrandTotal],[Terms]
	FROM tblPOMaster
	WHERE [POID] = @POID
END