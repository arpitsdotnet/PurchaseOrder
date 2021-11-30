﻿CREATE PROCEDURE [dbo].[sps_tblPODetails_GetByPOID]
	@POID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [PODetailsID],[POID],[ItemID],[Qty],[Rate],[Amount],[DiscPer],[Discount],[TotalAmt]
	FROM tblPODetails
	WHERE [POID] = @POID
END