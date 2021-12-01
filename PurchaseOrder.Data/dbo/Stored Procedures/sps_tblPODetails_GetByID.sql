CREATE PROCEDURE [dbo].[sps_tblPODetails_GetByID]
	@PODetailsID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [PODetailsID],[POID],[ItemID],[Details],[Qty],[Rate],[Amount],[DiscPer],[Discount],[TotalAmt]
	FROM tblPODetails
	WHERE [PODetailsID] = @PODetailsID
END