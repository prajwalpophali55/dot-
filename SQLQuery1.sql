/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id]
      ,[CustomerCode]
      ,[CustomerName]
      ,[CustomerAmount]
  FROM [CustomerDB1].[dbo].[Customer]

  drop table customer;
  create table Customer(id int Primary key identity (1,1), CustomerCode varchar(50), CustomerName varchar(50), CustomerAmount varchar(50));
  select * from Customer;