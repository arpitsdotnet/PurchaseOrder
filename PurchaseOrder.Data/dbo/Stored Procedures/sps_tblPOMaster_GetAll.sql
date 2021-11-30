CREATE PROCEDURE [dbo].[sps_tblPOMaster_GetAll]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [POID],[PONo],[PODate],[PartyID],[Remarks],[TotalQty],[TotalAmount],[TotalDiscount],[GrandTotal],[Terms]
	FROM tblPOMaster
	ORDER BY [PODate] DESC
END