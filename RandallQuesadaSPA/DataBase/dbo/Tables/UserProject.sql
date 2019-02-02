CREATE TABLE [dbo].[UserProject] (
    [UserId]       INT      NOT NULL,
    [ProjectId]    INT      NOT NULL,
    [IsActive]     BIT      NULL,
    [AssignedDate] DATETIME NULL,
    CONSTRAINT [PK_UserProject_1] PRIMARY KEY CLUSTERED ([UserId] ASC, [ProjectId] ASC),
    CONSTRAINT [FK_UserProject_Project] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Project] ([Id]),
    CONSTRAINT [FK_UserProject_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);




GO
CREATE NONCLUSTERED INDEX [IX_UserProject]
    ON [dbo].[UserProject]([UserId] ASC);

