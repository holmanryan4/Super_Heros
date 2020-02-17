CREATE TABLE [dbo].[Superheroes] (
    [Id]                        INT            IDENTITY (1, 1) NOT NULL,
    [Name]                      NVARCHAR (MAX) NULL  ,
    [AlterEgo]                  NVARCHAR (MAX) NULL  ,
    [primarySuperheroAbility]   NVARCHAR (MAX) NULL  ,
    [SecondarySuperheroAbility] NVARCHAR (MAX) NULL  ,
    [Catchphrase]               NVARCHAR (MAX) NULL  ,
    CONSTRAINT [PK_Superheroes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

