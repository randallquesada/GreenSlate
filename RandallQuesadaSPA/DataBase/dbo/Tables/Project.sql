CREATE TABLE [dbo].[Project] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [StartDate] DATETIME NULL,
    [EndDate]   DATETIME NULL,
    [Credits]   INT      NULL,
    CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED ([Id] ASC)
);

