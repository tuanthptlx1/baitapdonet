CREATE DATABASE SanBay;
GO


USE SanBay;
GO


CREATE TABLE MayBay (
    MaMB INT PRIMARY KEY IDENTITY(1,1),  
    TenMayBay NVARCHAR(100) NOT NULL,   
    NamSX INT NOT NULL,                 
    SoGioBay INT NOT NULL               
);
GO