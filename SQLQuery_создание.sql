create database Gerasimov_course_work
go
use Gerasimov_course_work

create table Color
(
	id_color int primary key identity,
	color_name varchar(20) not null
);
go
create table Material
(
	id_material int primary key identity,
	material_name varchar(20) not null
);
go
create table Form_Factor
(
	id_form_factor int primary key identity,
	form_name varchar(20) not null
);
go
create table [Table]
(
	id_table int primary key identity,
	table_number int not null unique,
	number_of_seats int not null,
	color_id int references Color(id_color) not null,
	material_id int references Material(id_material) not null,
	form_id int references Form_Factor(id_form_factor) not null,
	img varbinary(MAX) not null
);
go
create table Reservation
(
	id_reservation int primary key identity,
	reservation_number int not null unique,
	client_fname varchar(50) not null,
	client_lname varchar(50) not null,
	client_phone varchar(11) not null,
	time_of_reservation Time not null,
	date_of_reservation Date not null,
);
go
create table Table_Reservation
(
	id_table_reservation int primary key identity,
	table_id int references [Table](id_table) not null,
	reservation_id int references Reservation(id_reservation) not null
);