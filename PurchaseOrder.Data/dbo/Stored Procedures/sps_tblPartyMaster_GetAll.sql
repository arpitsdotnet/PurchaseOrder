CREATE PROCEDURE [dbo].[sps_tblPartyMaster_GetAll]
AS
BEGIN 
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [PartyID], [PartyName], [City]
	FROM tblPartyMaster
	ORDER BY [PartyName] ASC
END
