CREATE PROCEDURE [dbo].[sps_tblItemMaster_GetByID]
	@ItemID int
AS
BEGIN 
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [ItemID], [ItemName]
	FROM tblItemMaster
	WHERE [ItemID] = @ItemID
END
