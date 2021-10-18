USE InfernitasSE_OpenIssueTracker;

CREATE TABLE [dbo].[IssueCategorys]
(
    [ID] INT NOT NULL IDENTITY(1,1),
    [CategoryName] NVARCHAR(15) NOT NULL UNIQUE,
    [CategoryDescription] NVARCHAR(59),
    CONSTRAINT PK_IssueCategory PRIMARY KEY (ID)
) on [primary];