CREATE TABLE [dbo].[Products] (
    [ProductId]   INT          IDENTITY (1, 1) NOT NULL,
    [CategoryId]  INT          NOT NULL,
    [ProductName] VARCHAR (50) NOT NULL,
    [Price]       DECIMAL (18) DEFAULT ((0.0)) NOT NULL,
    [OHQuantity]  INT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductId] ASC),
    CONSTRAINT [FK_Products_ToCategories] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([CategoryId])
);

