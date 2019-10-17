CREATE TABLE [dbo].[tbl_employees] (
    [Id]         INT           NOT NULL,
    [first_name] NVARCHAR (50) NULL,
    [last_name]  NVARCHAR (50) NULL,
    [job_title]  NVARCHAR (50) NULL,
    [department] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

