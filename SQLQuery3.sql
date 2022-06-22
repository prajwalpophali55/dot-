/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id]
      ,[UserID]
      ,[UserName]
  FROM [Ecommerce].[dbo].[User]

  