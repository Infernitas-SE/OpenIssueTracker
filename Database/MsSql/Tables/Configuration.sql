USE InfernitasSE_OpenIssueTracker;

CREATE TABLE [dbo].[Configuration]
(
    [ID] INT NOT NULL IDENTITY(1,1),
    [Key] NVARCHAR(25) NOT NULL,
    [value] NVARCHAR(50) NOT NULL,
    PRIMARY KEY (ID)
) on [primary];