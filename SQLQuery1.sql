Create Database SampleDb2
Drop Database sampleDb2



Create table Sample(id int, name varchar (50));


select * from sample 

insert into sample values(1, 'prajwal');
insert into sample values(2, 'rayal');
insert into sample values(3, 'rahul');
insert into sample values(4, 'Mayur');
insert into sample values(5, 'Ayush');

delete from sample
Where id = 2;

 Create table Employe1(id int, name varchar(50), gender varchar(50));
 alter table Employe1 add salary int;
 

 select * from Employe1

 insert into Employe1 values(1001, 'prajwal', 'male', '10000');
 insert into Employe1 values(1002, 'aysuh', 'male', '10000');
 insert into Employe1 values(1003, 'apeksha', 'female', '10000');
 insert into Employe1 values(1004, 'Priya', 'female', '10000');
 insert into Employe1 values(1005, 'mayur', 'male', '10000');
 insert into Employe1 values(1006, 'nilakshi', 'female', '10000');
 insert into Employe1 values(1007, 'prajwal', 'male', '10000');

 select Max(salary) from Employe1;
 select Min(salary) from Employe1;


 create table Department(id int, deptname varchar(20), location varchar(20));

 select * from Department;
  
    insert into Department values(1001, 'IT', 'mumbai');
    insert into Department values(1002, 'HR', 'pune');
    insert into Department values(1003, 'IT', 'mumbai');

	select * from Employe1;

	Select * from Department;

	Select * from Employe1 as emp full outer join Department as dep on emp.id=dep.id;
	
	Select * from Employe1 as emp right outer join Department as dep on emp.id= dep.id;

	Select * from Employe1 as emp left outer join Department as dep on emp.id= dep.id;

	create table Student(id int, rollno int, firstname varchar(50), lastname varchar(50), gender varchar(50), classid int);

	Create table studentclass(id int, classname int);

	select firstname, lastname, rollno, gender, classname from Student as std inner join studentclass as stdclass on std.id = stdclass.id;

	create table Student1(id int, rollno int, firstname varchar(50), lastname varchar(50), gender varchar(50), classid int);

	insert into student1 values(101, 001, 'Prajwal', 'pophali', 'male', 1);
	insert into student1 values(102, 002, 'mayur', 'bodhke', 'male', 1);
	insert into student1 values(103, 003, 'pranali', 'patil', 'female', 1);
	insert into student1 values(104, 004, 'roshni', 'ramchandani', 'female', 1);
	insert into student1 values(105, 005, 'ayush', 'panwelkar', 'male', 1);

	select * from student1;
create table studentclass1(id int, classname varchar(50));

	create table studentclass2(id int, classname varchar(50));

	insert into studentclass1 values(101, 'rahul');
	insert into studentclass1 values(102, 'nandini');
	insert into studentclass1 values(103, 'rayal');
	
	insert into studentclass2 values(101, 'rahul');
	insert into studentclass2 values(102, 'nandini');
	insert into studentclass2 values(103, 'rayal'); 

	select * from studentclass2;

	select rollno, CONCAT(firstname, ' ', lastname) as fullname, gender, classname from student1 as std inner join studentclass2 as std_class on std.id = std_class.id;
	
	 create function Getfullname(@ID int)
     returns int  AS 
     Begin
	  return (select CONCAT(firstname,' ',lastname) as FullName from student1 where id=@ID);
      End
	  select * from student1
      select dbo.(101); 

