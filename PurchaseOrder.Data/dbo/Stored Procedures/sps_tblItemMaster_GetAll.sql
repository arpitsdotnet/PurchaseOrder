CREATE PROCEDURE [dbo].[sps_tblItemMaster_GetAll]
AS
BEGIN 
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [ItemID], [ItemName]
	FROM tblItemMaster
	ORDER BY [ItemName] ASC
END