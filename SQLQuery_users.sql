use  Gerasimov_course_work
go

create login GNS_first
	with password = '123';

create user GNS_first
	for login GNS_first

create role Manager authorization GNS_first
create login GNS_second
	with password = '123';

create user GNS_second
	for login GNS_second

create role Hostes authorization GNS_second

deny delete 
	to GNS_second;
