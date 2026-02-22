CREATE TABLE NewAdmissionS
(
	NAID INT IDENTITY (1,1) NOT NULL ,
	fname varchar (250) NOT NULL ,
	mname varchar (250) NOT NULL ,
	gender varchar(10) NOT NULL ,
	dob date   ,
	 mobile varchar (15),
	 email varchar(250) NOT NULL ,
	 semester varchar(100) NOT NULL  ,
	 prog varchar(150) NOT NULL  ,
	 sname varchar (150) NOT NULL ,
	 duration varchar(120) NOT NULL ,
	 address  varchar (250) NOT NULL ,
	 PRIMARY KEY(NAID)
);
SELECT * FROM NewAdmission;