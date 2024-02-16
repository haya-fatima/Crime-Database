--FIR
insert into FIR (FIR_ID, Incident_Reported, ComplainedBy_ID, Complainant_Relation, DateTime_of_Report, DateTime_of_Incident, Location_of_Incident, Station_of_Complaint, Description)
values (1, 'Theft', 2440044662965, 'Self', GETDATE(), GETDATE(), 'Street 17, Block 4, Gulshan e Iqbal', 'Jail Town','He stole my phone on gunpoint and ran away'),
 ( 2, 'Murder', 5440012649307, 'Husband', GETDATE(), GETDATE(), 'Street 1, Block 14, Nazimabad', 'Jinnah Town', 'He stabbed my wife in the chest 57 times'),
 ( 3, 'Arson', 5330087768924, 'Friend', GETDATE(), GETDATE(), 'Street 4, Block 8, Satellite Town', 'Jail Town', 'He set the university on fire after the DB project demo'),
 ( 4, 'Aggravated Assault', 3220073783023, 'Son', GETDATE(), GETDATE(), 'Street 16, Block 16, North Town', 'Jail Town', 'He groped my mother in a public transport bus'),
 (5, 'Murder', 1440084668924, 'Mother', GETDATE(), GETDATE(), 'Street 13, Block 31, Clifton', 'Jinnah Town', 'He killed our daughter when she over salted his food');


--Person
insert into Person(CNIC, Name, Gender, Date_of_Birth, Contact, Residence, Marital_Status, Number_Plate, Alive, Drivers_License, Place_of_Work)
values (5440086668924, 'Sameen Arshad', 1, '2001-03-03', 03008274260, 'B-25, Jauhar', 'Single', 'AAA-111',1, 1, 'Instagram Influencer'),
 (4220137659466, 'Haya Adnan', 1, '2003-03-30', 03353757464, 'A-75/1, Gulshan', 'Married', 'BBB-222', 1,2, 'Nobel Prize Scientist'),
 (4220148844089, 'Shahzaib Nadeem', 0, '1999-02-09', 03363657624, 'E-13, Gulshan', 'Married', 'BUN-069',1, 3, 'Game tester'),
 (7255394871627, 'Ayila Emad', 1, '2002-08-20', 03041490445, 'A-1, PECHS', 'Its Complicated', 'DDD-444',1, 4, 'NBA player'),
 (1565656326624, 'Ali Faisal', 0, '1979-05-02', 03335672412, 'A-92, PECHS', 'Married', 'CIR-131', 1, 5, 'Janitor'),
 (5330087768924, 'Zainab Raza', 1, '2002-05-13', 03018383097, 'E-55, Gulshan', 'Single', 'BHR-917', 1, 6, 'Student'),
 (5440012649307, 'Iqra Azfar', 1, '2003-01-12', 030274538634, 'C-134, Tariq Road', 'Married', 'OOE-127', 1, 7, 'Student'),
 (3220073783023, 'Ammar Ahmed', 0, '2002-12-06', 03009386609, 'L-990, DHA', 'Single', 'BEE-923', 1,  8, 'Student'),
 (1551056956624, 'Sardar Butt', 0, '1968-04-23', 03335672412, 'B-32, Jauhar', 'Married', 'CEQ-123', 1,  9, 'Plumber'),
 (2440044662965, 'Michael Scott', 0, '1965-05-03', 03117394642, 'B22, Nazimabad', 'Single', 'BAB-069', 1, 10, 'Dunder Mifflin'),
 (1550056954624, 'Sherlock Holmes', 0, '1970-01-06', 035528215421, '221B, Baker Street', 'Single', 'AAA-111', 1, 11, 'Detective Agency'),
 (1668379389924, 'Hasbullah Sheikh', 0, '1980-01-19', 03023286012, 'C-12, North Nazimabad', 'Married', 'BBB-911', 1, 12, 'Plumber'),
 (2255003994384, 'Shaheryar Raheem', 0, '1986-07-24', 03334688419, 'A-199, F.B. Area', 'Married', 'DBZ-121', 1, 13, 'Electrician'),
 (1529562256624, 'Ahmed Faisal', 0, '1971-05-02', 03311112123, 'A-9, PECHS', 'Married', 'CIR-181', 1, 14, 'Actor'),
 (1558556525554, 'Abdullah Ibrahim', 0, '1967-01-02', 03312342499, 'A-01, Lyari', 'Single', 'LUN-000', 1, 15, 'Guard'),
 (8237533456128, 'Ali Akbar', 0, '1988-09-02', 03363904988, 'H-22, Gulshan', 'Married', 'BUN-321', 1, 16, 'Police'),
 (2365162154922, 'Ram Singham', 0, '1984-06-22', 03002018860, 'D-91, Jauhar', 'Single', 'CMC-786', 1, 17, 'Police'),
 (1953034321419, 'John Abraham', 0, '1986-11-21', 03327665167, 'C-12, DHA', 'Married', 'MII-919', 1, 18, 'Police'),
 (1282318264824, 'Salman Khan', 0, '1991-12-30', 03237921000, 'A-61, DHA', 'Single', 'ERC-828', 1, 19, 'Police'),
 (1237027788629, 'Ajay Devgun', 0, '1994-10-11', 03111118765, 'F-28, KDA', 'Single', 'DCD-044', 1, 20, 'Police'),
 (1440084668924, 'Simal Anjum', 1, '2001-11-02', 03008482749, 'Z-45, Jauhar', 'Single', 'AFT-141', 0, 21, 'Student');


--Case
insert into [Case] (Case_ID, [Type], Open_Date, Close_Date)
values( 1, 'Theft', '2019-12-12', '2020-01-02'),
( 2, 'Murder', '2020-01-24', '2020-03-14'),
(3, 'Arson', '2020-03-17', '2020-04-02'),
(4, 'Aggravated Assault', '2020-04-29', '2020-06-03'),
(5, 'Murder', '2020-10-11', '2020-12-25');


--Criminal
insert into Criminal (Criminal_ID, CNIC, [Name], Gender, Height, Skin_Color, Eye_Color, Identifying_Feature)
values (1, 1551056956624, 'Sardar Butt', 0, 150, 'Olive', 'Brown', 'mole under chin'),
 (2, 1668379389924, 'Hasbullah Sheikh', 0, 165, 'Pale White', 'Black', 'None'),
 (3, 2255003994384, 'Shaheryar Raheem', 0, 167, 'Brown', 'Green', 'None'),
 (4, 1565656326624, 'Ali Faisal', 0, 155, 'Olive', 'Brown', 'Scar on right eye'),
 (5, 1558556525554, 'Abdullah Ibrahim', 0, 169, 'Olive', 'Brown', 'Burn mark on right arm');

--Accused
insert into Accused (Accused_ID, FIR_ID, [Name], Gender, Height, Eye_Color, Skin_Color)
values (1, 1,  'Bahadur Shah', 0, 156, 'Brown', 'Brown'),
 (2, 2, 'Shoaib Salman', 0, 156, 'Brown', 'Brown'),
 (3, 3, 'Hira Ali', 1, 152, 'Brown', 'Olive'),
 (4, 4, 'Sarah Salman', 1, 152, 'Blue', 'Olive'),
 (5, 5, 'Junaid Memon', 1, 150, 'Black', 'Brown');


--Victim
insert into Victim (Victim_ID, Crime_ID, CNIC, [Name], Gender, Height, Eye_Color, Skin_Color)
values (1, 1, 4220148844089, 'Shahzaib Nadeem', 0, 158, 'Brown', 'Olive'),
 (2, 2, 4220137659466, 'Haya Adnan', 1, 157, 'Brown', 'Brown'),
 (3, 3, 5440086668924, 'Sameen Arshad', 1, 156, 'Brown', 'Brown'),
 (4, 4, 7255394871627, 'Ayila Emad', 1, 162, 'Black', 'Brown'),
 (5, 5, 1550056954624, 'Sherlock Holmes', 0, 161, 'Hazel', 'Olive');

--Station
insert into Station (Station_ID, Borough, City, Incharge, No_of_Emp)
values (1,'Jail Town', 'Karachi', 'Mohammad Salman', 40),
 (2,'Jinnah Town', 'Karachi', 'Ahmed Sheikh', 50);
 

--Police
insert into Police (Police_ID, CNIC, [Name], Designation, Date_of_App, Police_Email, Police_Password)
values (200, 1237027788629, 'Ajay Devgun', 12, '2011-01-12', 'lectus.a@outlook.org', '123421Aa'),
 (201, 2365162154922, 'Ram Singham', 20, '2009-01-01', 'eu@gmail.com', 'abc123!@#'),
 (202, 1953034321419, 'John Abraham', 20, '2005-08-04', 'haseeb@gmail.com', 'poopdi232@'),
 (203, 1550056954624,'Sherlock Holmes', 15,'2020-05-03', 'jan@gmail.com', 'plloodada123@@'),
 (204, 4220137659466, 'Haya Adnan',17, '2022-01-16', 'muhammad@gmail.com', 'idandna123@@');

--Crime Reg
insert into Crime_Registry(Crime_ID, Date_of_Offence, FIR_ID, Under_Section, Arrested_Criminal, Arrested_By, [Description])
values (1, '2019-12-04', 1, '36-B', 1, 204, 'Theft'),
(2, '2020-01-09', 2, '33-C', 2, 202, 'Murder'),
(3, '2020-03-10', 3, '42-E', 3, 203, 'Arson'),
(4, '2020-04-20', 4, '33-F', 2, 204, 'Aggravated Assault'),
(5, '2020-10-01', 5, '12-A', 3, 201, 'Murder');

--Witnesses
insert into is_a_witness (CNIC, Case_ID)
values(5330087768924, 3),
      (3220073783023, 4);

--Suspect
insert into is_a_suspect(Accused_ID, Case_ID)
values(1, 1),
(2, 2);

--filed by
insert into filed_by (FIR_ID, Police_ID)
values (1, 200),
 (2, 203);

--assigned to
insert into assigned_to (Case_ID, Police_ID, [Start_Date])
values (2, 202, '2020-01-24' ),
 (1, 204, '2019-12-12');

--case has FIR
insert into case_has_FIR (Case_ID, FIR_ID)
values (1, 1),
 (2, 2);

--has update
insert into has_update (Case_ID, Update_ID, Description, Time_of_update, Updated_by)
values (1, 1, 'New evidence found', '2019-12-30 00:00:00’', 201),
 (1, 1, 'Arrested suspect, case closed', '2020-01-02 00:00:00’', 201),
 (2, 2, 'New suspect added', '2020-02-30 00:00:00', 202);

--crime in case
insert into crime_in_case (Case_ID, Crime_ID)
values (1,1),
 (2,2),
 (3,3),
 (4,4),
 (5,5);