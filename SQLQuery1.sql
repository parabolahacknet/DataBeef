USE [DBDataBeef];
GO

-- Crear la tabla de Usuarios
CREATE TABLE [dbo].[Usuarios] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Usuario]    NVARCHAR (50) NOT NULL,
    [Contrasena] NVARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

-- Insertar un usuario de prueba (usuario: admin, contraseña: 1234)
INSERT INTO [dbo].[Usuarios] ([Usuario], [Contrasena]) VALUES ('admin', '1234');
GO