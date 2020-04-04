use s17470


Insert INTO Studies (IdStudy, Name) Values (10, 'Logistics')
Insert INTO Studies (IdStudy, Name) Values (11, 'Information Tech.')
Insert INTO Studies (IdStudy, Name) Values (12, 'History')
Insert INTO Studies (IdStudy, Name) Values (13, 'Politology')
Select * FROM Studies

Insert INTO Enrollment (IdEnrollment, Semester, IdStudy, StartDate) Values (1, 1, 10, '2019-09-01')
Insert INTO Enrollment (IdEnrollment, Semester, IdStudy, StartDate) Values (2, 1, 10, '2019-09-01')
Insert INTO Enrollment (IdEnrollment, Semester, IdStudy, StartDate) Values (3, 2, 11, '2020-02-10')
Insert INTO Enrollment (IdEnrollment, Semester, IdStudy, StartDate) Values (4, 2, 11, '2020-02-10')
Insert INTO Enrollment (IdEnrollment, Semester, IdStudy, StartDate) Values (5, 2, 10, '2019-09-01')
Insert INTO Enrollment (IdEnrollment, Semester, IdStudy, StartDate) Values (6, 1, 10, '2019-09-01')
Insert INTO Enrollment (IdEnrollment, Semester, IdStudy, StartDate) Values (7, 1, 10, '2019-09-01')
Insert INTO Enrollment (IdEnrollment, Semester, IdStudy, StartDate) Values (8, 4, 13, '2019-09-01')
Insert INTO Enrollment (IdEnrollment, Semester, IdStudy, StartDate) Values (9, 4, 13, '2019-09-01')
Insert INTO Enrollment (IdEnrollment, Semester, IdStudy, StartDate) Values (10, 4, 10, '2019-09-01')
Select * FROM Enrollment

Insert INTO Student (IndexNumber, FirstName, LastName, BirthDate, IdEnrollment) Values (1001, 'Adrzej', 'Boguslawski' , '1990-05-01', 1)
Insert INTO Student (IndexNumber, FirstName, LastName, BirthDate, IdEnrollment) Values (1002, 'Adrzej', 'Boguslawski' , '1990-05-01', 2)
Insert INTO Student (IndexNumber, FirstName, LastName, BirthDate, IdEnrollment) Values (1533, 'Robert', 'Jankowski' , '1990-05-01', 3)
Insert INTO Student (IndexNumber, FirstName, LastName, BirthDate, IdEnrollment) Values (1244, 'Anita', 'Wlodarczyk' , '1990-05-01', 4)
Insert INTO Student (IndexNumber, FirstName, LastName, BirthDate, IdEnrollment) Values (1015, 'Takasawa', 'Tikitaki' , '1990-05-01', 5)
Insert INTO Student (IndexNumber, FirstName, LastName, BirthDate, IdEnrollment) Values (1066, 'Moron', 'Irycko' , '1990-05-01', 6)
Insert INTO Student (IndexNumber, FirstName, LastName, BirthDate, IdEnrollment) Values (1027, 'Kafel', 'Dzban' , '1990-05-01', 7)
Insert INTO Student (IndexNumber, FirstName, LastName, BirthDate, IdEnrollment) Values (1028, 'Masmoudi', 'Jokohama' , '1990-05-01', 8)
Insert INTO Student (IndexNumber, FirstName, LastName, BirthDate, IdEnrollment) Values (1059, 'Belef', 'Krohotko' , '1990-05-01', 9)
Insert INTO Student (IndexNumber, FirstName, LastName, BirthDate, IdEnrollment) Values (1020, 'Jan', 'Dumbledore' , '1990-05-01', 10)
Select * FROM Student

Select Enrollment.IdEnrollment, Semester, IndexNumber, Studies.Name From Enrollment, Student, Studies WHERE Enrollment.IdEnrollment = Student.IdEnrollment AND Enrollment.IdStudy = Studies.IdStudy AND IndexNumber = 1059

