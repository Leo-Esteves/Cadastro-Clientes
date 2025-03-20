CREATE DATABASE ClientesErp ;
Use ClientesErp;

Create table Clientes(

id int primary key not null,
nome varchar(200)not null,
rg varchar(50)not null,
cpf varchar(50)not null,
endereco varchar(255),
bairro varchar(255),
cidade varchar(255),
numero char(6),
estado char(2),
telefones char(11),
email varchar(50)

);

drop table Clientes