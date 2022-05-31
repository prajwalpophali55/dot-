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

	