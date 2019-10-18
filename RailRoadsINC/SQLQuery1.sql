create table Train(
Id int primary key identity(1,1),
DeparturePoint varchar(200) not null,
ArrivalPoint varchar(200) not null,
DepartureTime time(7) not null,
ArrivalTime time(7) not null,
NumberOfSeats int
)
create table Tickets
(
Id int primary key identity(1,1),
TrainID int foreign key references Train(ID),
PassportNumber int not null,
FIO varchar(200) not null,
SeatNumber int not null
)