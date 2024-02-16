CREATE TABLE FIR (
	FIR_ID INT Primary Key NOT NULL,
	Incident_Reported VARCHAR(255) NOT NULL,
	ComplainedBy_ID BIGINT NOT NULL, --will be CNIC
	Complainant_Relation VARCHAR(255) NOT NULL,
	DateTime_of_Report DATETIME NOT NULL,
	DateTime_of_Incident DATETIME NOT NULL,
	Location_of_Incident VARCHAR(255) NOT NULL,
	Station_of_Complaint INT,
	Description VARCHAR(255) NOT NULL
);

CREATE TABLE Person (
	CNIC BIGINT NOT NULL,
	Name VARCHAR(255) NOT NULL,
	Gender Bit NOT NULL,
	Date_of_Birth DATETIME NOT NULL,
	Contact BIGINT NOT NULL,
	Residence VARCHAR(255) NOT NULL,
	Marital_Status VARCHAR(255) NOT NULL,
	Number_Plate VARCHAR(255),
	Alive Bit NOT NULL,
	Drivers_license INT NOT NULL,
	Place_of_work VARCHAR(255) NOT NULL,
	PRIMARY KEY (CNIC)
);

CREATE TABLE [Case] (
	Case_ID INT NOT NULL, -- remove autoinc,
	[Type] varchar NOT NULL,
	Open_date DATETIME NOT NULL,
	Close_Date DATETIME NULL,
	PRIMARY KEY (Case_ID)
);

CREATE TABLE is_a_witness (
	CNIC BIGINT NOT NULL,
	Case_ID INT NOT NULL --inc,
	PRIMARY KEY (CNIC,Case_ID)
);

CREATE TABLE Criminal (
	Criminal_ID INT NOT NULL, --remove inc
	CNIC BIGINT NOT NULL,
	[Name] VARCHAR(255) NOT NULL,
	Gender Bit NOT NULL,
	Height BIGINT NOT NULL,
	Skin_Color VARCHAR(255) NOT NULL,
	Eye_Color VARCHAR(255) NOT NULL,
	Identifying_Feature VARCHAR(255) NOT NULL,
	PRIMARY KEY (Criminal_ID)
);

CREATE TABLE associated_with (
	Criminal_1 INT NOT NULL,
	Criminal_2 INT NOT NULL,
	PRIMARY KEY (Criminal_1,Criminal_2)
);

CREATE TABLE filed_by (
	FIR_ID INT NOT NULL,
	Police_ID INT NOT NULL,
	PRIMARY KEY (FIR_ID,Police_ID)
);

CREATE TABLE assigned_to (
	Case_ID INT NOT NULL,
	Police_ID INT NOT NULL,
	Start_Date DATE NOT NULL,
	PRIMARY KEY (Case_ID,Police_ID)
);

CREATE TABLE Accused (
	Accused_ID INT NOT NULL , --remove inc, and accused id is cnic
	FIR_ID INT NOT NULL,
	CNIC BIGINT,
	Name VARCHAR(255),
	Gender Bit,
	Height INT,
	Eye_Color VARCHAR(255),
	Skin_Color VARCHAR(255),
	PRIMARY KEY (Accused_ID,FIR_ID)
);

CREATE TABLE is_a_suspect(
	Accused_ID INT NOT NULL, --
	Case_ID INT NOT NULL,
	Primary key (Accused_ID, Case_ID)
);
CREATE TABLE case_has_FIR (
	Case_ID INT NOT NULL,
	FIR_ID INT NOT NULL,
	PRIMARY KEY (Case_ID,FIR_ID)
);

CREATE TABLE Station (
	Station_ID INT NOT NULL, --remove inc
	Borough VARCHAR(255) NOT NULL,
	City VARCHAR(255) NOT NULL,
	Incharge INT NOT NULL, -- remove??
	No_of_Emp INT NOT NULL,
	PRIMARY KEY (Station_ID)
);

CREATE TABLE has_update (
	Case_ID INT NOT NULL,
	Update_ID INT NOT NULL ,--
	Description VARCHAR(255) NOT NULL,
	Time_of_update DATETIME NOT NULL,
	Updated_by INT NOT NULL,
	PRIMARY KEY (Case_ID,Update_ID)
);

CREATE TABLE Police (
	Police_ID INT NOT NULL,
	CNIC BIGINT NOT NULL,
	Name VARCHAR(255) NOT NULL,
	Designation INT NOT NULL,
	Date_of_App DATE NOT NULL,
	Police_Email VARCHAR(255) NOT NULL,
	Police_Password VARCHAR(255) NOT NULL,
	PRIMARY KEY (Police_ID)
);

CREATE TABLE stationed_at (
	Police_ID INT NOT NULL,--
	Station_ID INT NOT NULL,
	Start_Date DATE NOT NULL,
	End_Date DATE NOT NULL,
	PRIMARY KEY (Police_ID,Station_ID)
);

CREATE TABLE working_on (
	Case_ID INT NOT NULL,
	Police_ID INT NOT NULL,
	Start_Date DATE NOT NULL,
	PRIMARY KEY (Case_ID,Police_ID)
);

CREATE TABLE Crime_Registry (
	Crime_ID INT NOT NULL,
	Date_of_Offence DATETIME NOT NULL,
	FIR_ID INT NOT NULL,
	Under_Section VARCHAR(255) NOT NULL,
	Arrested_Criminal INT NOT NULL,
	Arrested_By INT NOT NULL,
	Description VARCHAR(255) NOT NULL,
	PRIMARY KEY (Crime_ID)
);

CREATE TABLE crime_in_case (
	Case_ID INT NOT NULL,
	Crime_ID INT NOT NULL,
	PRIMARY KEY (Case_ID)
);

CREATE TABLE Victim (
	Victim_ID INT NOT NULL,--
	Crime_ID INT NOT NULL,
	CNIC BIGINT,
	Name VARCHAR(255),
	Gender Bit,
	Height FLOAT,
	Eye_color VARCHAR(255),
	Skin_color VARCHAR(255),
	PRIMARY KEY (Victim_ID,Crime_ID)
);

ALTER TABLE FIR ADD CONSTRAINT FIR_fk0 FOREIGN KEY (ComplainedBy_ID) REFERENCES Person(CNIC);

ALTER TABLE FIR ADD CONSTRAINT FIR_fk1 FOREIGN KEY (Station_of_Complaint) REFERENCES Station(Station_ID);

ALTER TABLE is_a_witness ADD CONSTRAINT is_a_witness_fk0 FOREIGN KEY (CNIC) REFERENCES Person(CNIC);

ALTER TABLE is_a_witness ADD CONSTRAINT is_a_witness_fk1 FOREIGN KEY (Case_ID) REFERENCES "Case" (Case_ID);

ALTER TABLE Criminal ADD CONSTRAINT Criminal_fk0 FOREIGN KEY (CNIC) REFERENCES Person(CNIC);

ALTER TABLE associated_with ADD CONSTRAINT associated_with_fk0 FOREIGN KEY (Criminal_1) REFERENCES Criminal(Criminal_ID);

ALTER TABLE associated_with ADD CONSTRAINT associated_with_fk1 FOREIGN KEY (Criminal_2) REFERENCES Criminal(Criminal_ID);

ALTER TABLE filed_by ADD CONSTRAINT filed_by_fk0 FOREIGN KEY (FIR_ID) REFERENCES FIR(FIR_ID);

ALTER TABLE filed_by ADD CONSTRAINT filed_by_fk1 FOREIGN KEY (Police_ID) REFERENCES Police(Police_ID);

ALTER TABLE assigned_to ADD CONSTRAINT assigned_to_fk0 FOREIGN KEY (Case_ID) REFERENCES "Case"(Case_ID);

ALTER TABLE assigned_to ADD CONSTRAINT assigned_to_fk1 FOREIGN KEY (Police_ID) REFERENCES Police(Police_ID);

ALTER TABLE Accused ADD CONSTRAINT Accused_fk0 FOREIGN KEY (FIR_ID) REFERENCES FIR(FIR_ID);

ALTER TABLE case_has_FIR ADD CONSTRAINT case_has_FIR_fk0 FOREIGN KEY (Case_ID) REFERENCES "Case"(Case_ID);

ALTER TABLE case_has_FIR ADD CONSTRAINT case_has_FIR_fk1 FOREIGN KEY (FIR_ID) REFERENCES FIR(FIR_ID);

ALTER TABLE Station ADD CONSTRAINT Station_fk0 FOREIGN KEY (Incharge) REFERENCES Police(Police_ID);

ALTER TABLE has_update ADD CONSTRAINT has_update_fk0 FOREIGN KEY (Case_ID) REFERENCES "Case"(Case_ID);

ALTER TABLE has_update ADD CONSTRAINT has_update_fk1 FOREIGN KEY (Updated_by) REFERENCES Police(Police_ID);

ALTER TABLE Police ADD CONSTRAINT Police_fk0 FOREIGN KEY (CNIC) REFERENCES Person(CNIC);

ALTER TABLE stationed_at ADD CONSTRAINT stationed_at_fk0 FOREIGN KEY (Police_ID) REFERENCES Police(Police_ID);

ALTER TABLE stationed_at ADD CONSTRAINT stationed_at_fk1 FOREIGN KEY (Station_ID) REFERENCES Station(Station_ID);

ALTER TABLE working_on ADD CONSTRAINT working_on_fk0 FOREIGN KEY (Case_ID) REFERENCES "Case"(Case_ID);

ALTER TABLE working_on ADD CONSTRAINT working_on_fk1 FOREIGN KEY (Police_ID) REFERENCES Police(Police_ID);

ALTER TABLE Crime_Registry ADD CONSTRAINT Crime_Registry_fk0 FOREIGN KEY (FIR_ID) REFERENCES FIR(FIR_ID);

ALTER TABLE Crime_Registry ADD CONSTRAINT Crime_Registry_fk1 FOREIGN KEY (Arrested_Criminal) REFERENCES Criminal(Criminal_ID);

ALTER TABLE Crime_Registry ADD CONSTRAINT Crime_Registry_fk2 FOREIGN KEY (Arrested_By) REFERENCES Police(Police_ID);

ALTER TABLE crime_in_case ADD CONSTRAINT crime_in_case_fk0 FOREIGN KEY (Case_ID) REFERENCES "Case"(Case_ID);

ALTER TABLE crime_in_case ADD CONSTRAINT crime_in_case_fk1 FOREIGN KEY (Crime_ID) REFERENCES Crime_Registry(Crime_ID);

ALTER TABLE Victim ADD CONSTRAINT Victim_fk0 FOREIGN KEY (Crime_ID) REFERENCES "Crime_Registry"(Crime_ID);

ALTER TABLE Victim ADD CONSTRAINT Victim_fk1 FOREIGN KEY (CNIC) REFERENCES Person (CNIC);