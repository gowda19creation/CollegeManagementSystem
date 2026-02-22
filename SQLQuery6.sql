CREATE TABLE teacher
(
tid INT NOT NULL IDENTITY(1,1) primary key,
fname varchar(250) NOT NULL,
gender varchar(10) NOT NULL,
dob varchar (50) NOT NULL,
mobile BIGINT NOT NULL,
email varchar (250)NOT NULL,
semester varchar (250) NOT NULL,
prog varchar (100) NOT NULL,
yer varchar (250) NOT NULL,
adr varchar (300) NOT NULL
)

SELECT * FROM teacher
