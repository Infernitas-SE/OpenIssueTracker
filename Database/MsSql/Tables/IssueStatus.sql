USE InfernitasSE_OpenIssueTracker;

CREATE TABLE [dbo].[IssueStatus] 
(
    [ID] INT NOT NULL IDENTITY(1,1),
    [StatusName] NVARCHAR(15) NOT NULL UNIQUE,
    [StatusDescription] NVARCHAR(50),
    CONSTRAINT PK_IssueStatus PRIMARY KEY (ID)
) on [primary];

CREATE TABLE [dbo].[IssueStatusRestrictions]
(
    [ID] INT NOT NULL IDENTITY(1,1),
    [RestrictionName] NVARCHAR(25) NOT NULL,
    [IssueStatus] INT NOT NULL 
    PRIMARY KEY (ID),
    CONSTRAINT FK_IssueStatus FOREIGN KEY (IssueStatus) REFERENCES [dbo].[IssueStatus](ID)
) on [primary];