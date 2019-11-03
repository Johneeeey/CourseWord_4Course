use Gerasimov_course_work

--insert into OPENROWSET('Microsoft.OLEDB.18.3.0', 
--    'Excel 8.0;Database=D:\Exports.xls;','SELECT * FROM[Sheet1$') select * from Reservation
insert into OPENROWSET('Microsoft.Jet.OLEDB.4.0', 
    'Excel 8.0;Database=D:\Exports.xls;', 
    'SELECT * FROM [SheetName$]') select * from Reservation
