/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
SELECT TOP (1000) [ID]
      ,[Title]
      ,[Cost]
      ,[DurationInSeconds]
      ,[Description]
      ,[Discount]
      ,[MainImagePath]
  FROM [DataBase].[dbo].[Service]