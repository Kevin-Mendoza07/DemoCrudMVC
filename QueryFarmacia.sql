
create database FarmaValue

use FarmaValue 
go 

create table Cliente(
Id_Cliente int primary key identity(1,1),
NombreCliente nvarchar(30) not null,
ApellidoCliente nvarchar(30) not null,
Telefono nvarchar(25) not null,
Direccion nvarchar(50) not null
)

select *from Cliente

INSERT INTO Cliente (NombreCliente, ApellidoCliente, Telefono, Direccion)
VALUES
('Juan', 'Perez', '555-1234', 'Barrio El Recreo'),
('Maria', 'Gomez', '555-5678', 'Ciudad Sandino'),
('Carlos', 'Rodriguez', '555-9012', 'Ciudad Sandino'),
('Laura', 'Martinez', '555-3456', 'Residencial Villa Sol'),
('Roberto', 'Lopez', '555-7890', 'Altagracia'),
('Ana', 'Hernandez', '555-2345', 'Villa El Carmen'),
('Pedro', 'Sanchez', '555-6789', 'Villa Venezuela'),
('Isabel', 'Diaz', '555-0123', 'Las Brisas'),
('Fernando', 'Torres', '555-4567', 'Los Arcos'),
('Carmen', 'Ruiz', '555-8901', 'Monseñor Lezcano')
