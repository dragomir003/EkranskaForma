CREATE DATABASE EkranskaForma;

USE EkranskaForma;

create table Smer(
	id int not null IDENTITY(1, 1),
	naziv nvarchar(256) not null, -- Cisto da budemo sigurni jer IT smer ima stvarno dugacko ime
	trajanje int not null,
	maxUcenika int not null,
	prijemniIspit nvarchar(32) not null, -- Nije mi skroz jasno da li je ovo naziv predmeta ili nesto drugo
);

insert into Smer(naziv, trajanje, maxUcenika, prijemniIspit) values
('Prirodno-Matematicki', 4, 200, 'Mala matura'),
('Drustveno-Jezicki', 4, 100, 'Mala matura'),
('IT', 4, 40, 'Matematika'),
('SI', 4, 60, 'Matematika');