--crear la base de datos

create database dbHospital;
go 

--use la base de datos
use dbHospital;
go

--tabla doctores
create table doctores(
id_doctor  int primary key identity (1,1),
nombre varchar (50) NOT NULL,
apellido varchar (50) NOT NULL,
especialidad varchar (50) NOT NULL,
cargo varchar (50) NOT NULL
);
go

--tabla pacientes 
create table pacientes (
id_paciente  int primary key identity (1,1),
num_iss varchar (20) NOT NULL unique,
nombre varchar (50) NOT NULL,
apellido varchar (50) NOT NULL,
domicilio varchar  (150) NOT NULL,
telefgono varchar (15)NOT NULL,
sexo varchar(1) NOT NULL,
costo_tratamiento decimal (10,2) NOT NULL Default 0.00
);
go

--tabla ingresos (sin default en fecha_ingresis)
create table ingresos (
id_ingresos int primary key identity  (1,1),
id_paciente int not null,
feche_ingreso datetime not null, --ahora es obligatorio ingresarlas manualmente 
id_doctor int not null,
diagnostico text not null,
constraint fk_ingresos_pacientes foreign key (id_paciente) references pacientes(id_paciente),
constraint fk_ingresos_doctores foreign key (id_paciente) references doctores (id_doctor)
);
go

--insertar datos iniciales en doctores 
insert into doctores (nombre,apellido,especialidad,cargo)
values 
('juan carlos', 'mendoza', 'cardiología', 'jefe de cardiología'),
('maría teresa', 'ramírez', 'pediatría', 'pediatra senior'),
('roberto antonio', 'hernández', 'neurología', 'neurólogo'),
('laura patricia', 'sánchez', 'ginecología', 'ginecóloga'),
('carlos eduardo', 'lópez', 'traumatología', 'cirujano ortopédico'),
('ana isabel', 'rodríguez', 'dermatología', 'dermatóloga'),
('josé manuel', 'pérez', 'oftalmología', 'oftalmólogo');

go 

select nombre,apellido,especialidad,cargo from Doctores;
select *from doctores

select *from pacientes
select *from ingresos









