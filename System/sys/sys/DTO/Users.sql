-- Create a new database called 'Users'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = N'Users'
)
CREATE DATABASE Users
GO

-- Create a new table called 'users' in schema 'Users'
-- Drop the table if it already exists
IF OBJECT_ID('Users.users', 'U') IS NOT NULL
DROP TABLE Users.users
GO
-- Create the table in the specified schema
CREATE TABLE Users.users
(
    usersID INT NOT NULL PRIMARY KEY, -- primary key column
    Registro [NVARCHAR] (50) NOT NULL,
    Usuario [NVARCHAR](50) NOT NULL,
    Senha [NVARCHAR](50) NOT NULL,
    Nivel BINARY NOT NULL -- um valor binário, 1 para administrador e 0 para funcionário
);
GO

-- Insert rows into table 'users'
INSERT INTO users
( -- columns to insert data into
 [usersID],[Registro], [Usuario], [Senha], [Nivel]
)
VALUES
( 1, "F01", "Atendente", "12345",0 ),
( 2, "A01", "Asistente Social", "12345",1)
GO