CREATE TABLE FlowerShopCart
 (Id int NOT NULL　 IDENTITY(1,1) ,
 [UsersId] int NULL ,
 [FlowerId] [varchar](300) NULL,
 Num int NULL ,
 [Status] int NULL ,
 CreateTime datetime NULL ,
 UpdateTime datetime NULL );

 ----
 CREATE TABLE FlowerActive
 (Id int NOT NULL　 IDENTITY(1,1) ,
 [UsersId] int NULL ,
 [FlowerId]　varchar(300),
 [Content] nvarchar(500) NULL , 
 CreateTime datetime NULL ,
 UpdateTime datetime NULL );
