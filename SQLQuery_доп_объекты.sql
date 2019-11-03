use Gerasimov_course_work
go

create procedure TableInfoOnDate
	@idTable int,
	@date date
as
begin
	select
		r.reservation_number,
		r.client_fname,
		r.client_lname,
		r.client_phone,
		r.date_of_reservation,
		r.time_of_reservation
	from
		Table_Reservation tr
		join Reservation r on tr.reservation_id = r.id_reservation
		join [Table] t on tr.table_id = t.id_table
	where
		t.table_number = @idTable 
		and r.date_of_reservation = @date
end
go

create function AmountReservedTableOnDate
(
	@date date
)
returns int
as
begin
	declare @response int

	select
		@response = count(*)
	from
		Reservation r
	where
		r.date_of_reservation = @date

	return @response
end
go

create procedure CallAmounFunction
	@date date
as
begin
	select
		dbo.AmountReservedTableOnDate(@date)
end
go

create trigger Room_D
on [Table]
instead of delete
as
	delete from Table_Reservation where table_id=(select id_table from deleted)
	delete from [Table] where id_table=(select id_table from deleted)
go

create trigger Reservation_D
on Reservation
instead of delete
as
	delete from Table_Reservation where reservation_id=(select id_reservation from deleted)
	delete from Reservation where id_reservation=(select id_reservation from deleted)
go

create trigger Color_D
on Color
instead of delete
as
	delete from [Table] where color_id=(select id_color from deleted)
	delete from Color where id_color=(select id_color from deleted)
go

create trigger Material_D
on Material
instead of delete
as
	delete from [Table] where material_id=(select id_material from deleted)
	delete from Material where id_material=(select id_material from deleted)
go

create trigger Form_Factor_D
on Form_Factor
instead of delete
as
	delete from [Table] where form_id=(select id_form_factor from deleted)
	delete from Form_Factor where id_form_factor=(select id_form_factor from deleted)
go