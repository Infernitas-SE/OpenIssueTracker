USE InfernitasSE_OpenIssueTracker;

CREATE TABLE [dbo].[Issues]
(
    [ID] INT NOT NULL IDENTITY(1,1),
    [Title] NVARCHAR(25) NOT NULL,
    [AuthorUN] NVARCHAR(25) NOT NULL,
    [CreatedAt] DATETIME NOT NULL,
    [LastEdited] DATETIME,
    [Status] INT NOT NULL,
    [Category] INT NOT NULL,
    CONSTRAINT PK_Issues PRIMARY KEY (ID),
    CONSTRAINT FK_Status FOREIGN KEY (Status) REFERENCES [dbo].[IssueStatus](ID),
    CONSTRAINT FK_Category FOREIGN KEY (Category) REFERENCES [dbo].[IssueCategorys](ID)
) on [primary];