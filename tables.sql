CREATE TABLE [dbo].[users]
(
	[user_id] INT NOT NULL PRIMARY KEY, 
	[username] VARCHAR(MAX) NOT NULL,
    [password] VARCHAR(MAX) NOT NULL, 
    [firstname] VARCHAR(MAX) NOT NULL, 
    [lastname] VARCHAR(MAX) NOT NULL, 
    [email] VARCHAR(MAX) NOT NULL, 
    [image] VARCHAR(MAX) NULL DEFAULT null, 
    [reputation] INT NULL DEFAULT 0
)

CREATE TABLE [dbo].[threads]
(
	[thread_id] INT NOT NULL PRIMARY KEY, 
    [user_id] INT NOT NULL, 
    [title] VARCHAR(MAX) NOT NULL, 
    [date] DATE NOT NULL, 
    [tags] VARCHAR(MAX) NULL DEFAULT null, 
    [views] INT NULL DEFAULT 0, 
    [upvotes] INT NULL DEFAULT 0, 
    [content] TEXT NOT NULL, 
    CONSTRAINT [FK_threads_users] FOREIGN KEY ([user_id]) REFERENCES [users]([user_id]) 
)

CREATE TABLE [dbo].[comments]
(
	[comment_id] INT NOT NULL PRIMARY KEY, 
    [target_thread_id] INT NOT NULL , 
    [target_comment_id] INT NULL DEFAULT null, 
    [user_id] INT NOT NULL, 
    [date] DATE NOT NULL, 
    [upvotes] INT NULL DEFAULT 0, 
    [content] TEXT NOT NULL, 
    CONSTRAINT [FK_comments_threads] FOREIGN KEY ([target_thread_id]) REFERENCES [threads]([thread_id]), 
    CONSTRAINT [FK_comments_comments] FOREIGN KEY ([target_comment_id]) REFERENCES [comments]([comment_id]), 
    CONSTRAINT [FK_comments_users] FOREIGN KEY ([user_id]) REFERENCES [users]([user_id]) 
)

CREATE TABLE [dbo].[blacklist]
(
	[user_id] INT NOT NULL PRIMARY KEY, 
    [expiry] DATE NOT NULL, 
    CONSTRAINT [FK_blacklist_users] FOREIGN KEY ([user_id]) REFERENCES [users]([user_id])
)