INSERT INTO `attendance`.`student`
(`Code`,
`Name`,
`DepartmentId`,
`ClassId`,
`Gender`,
`BirthDate`,
`Native`,
`Mobile`,
`PhotoPath`,
`IsDeleted`)
VALUES
('10097',
'刘德华',
1,
1,
'男',
'1998-3-2',
'山东威海',
'13880801380',
'10097.jpg',
0);


alter user 'root'@'localhost' identified by '111111' password expire never;
alter user 'root'@'localhost' identified with mysql_native_password by '111111';

flush privileges;


alter user 'root'@'localhost' identified by '111111';






