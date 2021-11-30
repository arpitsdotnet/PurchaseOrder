CREATE PROCEDURE [dbo].[sps_tblPartyMaster_GetByID]
	@PartyID int
AS
BEGIN 
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [PartyID], [PartyName], [City]
	FROM tblPartyMaster
	WHERE [PartyID] = @PartyID
END