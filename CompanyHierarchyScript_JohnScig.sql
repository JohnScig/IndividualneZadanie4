CREATE DATABASE CompanyHierarchy
GO
USE CompanyHierarchy

CREATE TABLE Employees (
    EmployeeID int PRIMARY KEY IDENTITY,
	Title nvarchar (10) NOT NULL,
    LastName nvarchar(50) NOT NULL,
    FirstName nvarchar(50) NOT NULL,
    Phone nvarchar (50) NOT NULL,
    Email nvarchar (50) NOT NULL,
	DepartmentID int --FOREIGN KEY REFERENCES Nodes(ID)
);

CREATE TABLE Nodes (
	NodeID int PRIMARY KEY IDENTITY,
	Name nvarchar (50) NOT NULL,
	Code nvarchar (50) NOT NULL,
	HierarchyLevel int NOT NULL,
	DirectorID int FOREIGN KEY REFERENCES Employees(EmployeeID),
	ParentNodeID int FOREIGN KEY REFERENCES Nodes(NodeID)
);

ALTER TABLE Employees
ADD CONSTRAINT FK_EmployedAtNode
FOREIGN KEY (DepartmentID) REFERENCES Nodes(NodeID); 

--------------------------------------
-------- SETTING UP COMPANIES --------
--------------------------------------

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Silverhelm Online Studios', 'SHOGN', 0, NULL)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Electronic Arts', 'EA', 0, NULL)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Ubisoft Entertainment', 'UBISOFT', 0, NULL)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Sony Interactive Entertainment', 'SONY', 0, NULL)


--------------------------------------
-------- SETTING UP DIVISIONS --------
--------------------------------------

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Silverhelm', 'SILVER', 1, 1)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Boxicity', 'BOXI', 1, 1)

----------------- EA DIVISIONS

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Respawn Entertainment', 'EARESPWN', 1, 2)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Bioware', 'EAbio', 1, 2)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('EA Sports', 'EASPORTS', 1, 2)

---------------- UBI DIVISIONS

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Ubisoft Montreal', 'UBIMONT', 1, 3)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Ubisoft Shanghai', 'UBISHANG', 1, 3)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Red Storm', 'UBISTORM', 1, 3)

---------------- SONY DIVISIONS

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Sony Santa Monica', 'SONYSM', 1, 4)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Naughty Dog', 'SONYDOG', 1, 4)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Guerilla Games', 'SONYGUERILLA', 1, 4)

--------------------------------------
-------- SETTING UP PROJECTS ---------
--------------------------------------

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Valiance Online', 'VALIANT', 2, 5)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Legends of Etherell', 'LOE', 2, 5)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Warbox: Camouflage', 'WBCAMO', 2, 6)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Warbox: Frontlines', 'WBFRNT', 2, 6)


---------------- EA Respawn PROJECTS

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Apex Legends', 'APEX', 2, 7)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Star Wars Jedi: Fallen Order', 'SWJEDI', 2, 7)

---------------- EA Bioware PROJECTS

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Anthem', 'ANTHEM', 2, 8)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Mass Effect 5', 'ME5', 2, 8)

---------------- EA Sports PROJECTS

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('NHL', 'EAHOCKEY', 2, 9)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('FIFA', 'EASOCCER', 2, 9)

---------------- Ubisoft Montreal PROJECTS

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Splinter Cell', 'FISHER', 2, 10)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Endwar 2', 'ENDWAR', 2, 10)

---------------- Ubisoft Shanghai PROJECTS

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Ghost Recon', 'GHOST', 2, 11)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('H.A.W.X. 3', 'HAWX', 2, 11)

---------------- Ubisoft Shanghai PROJECTS

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Rainbow Six Siege: 2', 'SIEGE2', 2, 12)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Raven Shield 2', 'RAVENS', 2, 12)

---------------- Sony Santa Monica PROJECTS

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('God of War 6', 'KRATOS6', 2, 13)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Journey 2', 'JOURNEY2', 2, 13)

---------------- Sony Naughty Dog PROJECTS

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Last of Us 2', 'ZOMBIE2', 2, 14)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Uncharted: Lost Legacy 2', 'UNCH6', 2, 14)

---------------- SONY Guerilla Games PROJECTS

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Horizon 2', 'HORIZON2', 2, 15)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Killzone 5', 'KILLZ5', 2, 15)


--------------------------------------
------ SETTING UP DEPARTMENTS --------
--------------------------------------

------- Valiance

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Game Design', 'VODESIGN', 3, 16)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Art', 'VOART', 3, 16)

------- Legends of Etherell

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('World Design', 'LOEWORLD', 3, 17)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Sound', 'LOESOUND', 3, 17)

------- CAMO

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Level Design', 'CAMOLVL', 3, 18)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Microtransactions', 'CAMOMONEY', 3, 18)

------- Frontlines

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Historical Accuracy', 'FRNTLHISTORY', 3, 19)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Graphics & Art', 'FRNTLVISUAL', 3, 19)

------- APEX

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Post Launch', 'APEXPOST', 3, 20)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Marketing', 'APEXMART', 3, 20)

------- Star wars

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Lore Design', 'SWLORE', 3, 21)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Licensing', 'SWLICENCE', 3, 21)

------- Anthem

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Post Launch', 'ANTHEMPOST', 3, 22)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Testing', 'ANTHEMBUGFIX', 3, 22)

------- Mass Effect

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Lore Design', 'MELORE', 3, 23)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Level Design', 'MELVL', 3, 23)

-- EA DEPARTMENTS NHL
INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Game Design', 'NHLDESIGN', 3, 24)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Marketing', 'NHLMARKETING', 3, 24)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Licensing', 'NHLLICENCE', 3, 24)


-- EA DEPARTMENTS FIFA
INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Game Design', 'FIFADESIGN', 3, 25)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Marketing', 'FIFAMARKETING', 3, 25)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Licensing', 'FIFALICENCE', 3, 25)

------- Splinter

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Stealth Design', 'SCSTEALTH', 3, 26)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Art', 'SCART', 3, 26)

------- Endwar 2

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Voice Recognition', 'ENDWARVOICE', 3, 27)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('AI', 'ENDWARAI', 3, 27)

------- Ghost Recon

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Map Design', 'GRMAP', 3, 28)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Weapon Design', 'GRWEAPON', 3, 28)

------- HAWX 3

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Flight Physics', 'HAWXPHYSICS', 3, 29)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Aircraft Design', 'HAWXPLANES', 3, 29)

------- Siege 2

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Level Design', 'SIEGELVL', 3, 30)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Net Code', 'SIEGENETWORKING', 3, 30)

------- Raven Shield 2

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('AI', 'RAVENSAI', 3, 31)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Ballistics', 'RAVENSBULLETS', 3, 31)

------- God of War 6

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Myhology & Monster Design', 'GOWMYTH', 3, 32)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Level Design', 'GOWLVL', 3, 32)

------- Journey 2

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Music', 'JOURNEYMUSIC', 3, 33)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Art', 'JOURNEYART', 3, 33)

------- Last of Us 2

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('MOCAP Performance', 'LOUMOCAP', 3, 34)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Monster Design', 'LOUMONSTER', 3, 34)

------- Uncharted

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Level Design', 'UNCHLVL', 3, 35)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('World Physics', 'UNCHWORLD', 3, 35)

------- Horizon 2

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Story & Lore', 'HORIZONLORE', 3, 36)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Open World Design', 'HORIZONWORLD', 3, 36)

------- Killzone 5

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Art', 'KILLZART', 3, 37)

INSERT INTO Nodes (Name,Code,HierarchyLevel,ParentNodeID)
VALUES ('Game Design', 'KILLZGAMEDES', 3, 37)


--------------------------------------
--------- SETTING UP PEOPLE ----------
--------------------------------------

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, DepartmentID)
VALUES ('Mr.', 'Aaron', 'Victoria', '123', 'aaron.victoria@shogn.com', 1)

UPDATE Nodes
SET DirectorID = 1
WHERE NodeID = 1

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, DepartmentID)
VALUES ('Mr.', 'Larry', 'Probst', '178', 'larry.probst@ea.com', 2)

UPDATE Nodes
SET DirectorID = 2
WHERE NodeID = 2

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, DepartmentID)
VALUES ('Mr.', 'Yves', 'Guillemot', '469', 'yves.guillemot@ubisoft.com', 3)

UPDATE Nodes
SET DirectorID = 3
WHERE NodeID = 3

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, DepartmentID)
VALUES ('Mr.', 'John', 'Kodera', '783', 'john.kodera@sony.com', 4)

UPDATE Nodes
SET DirectorID = 4
WHERE NodeID = 4

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, DepartmentID)
VALUES ('Mr.', 'Chad', 'Dulac', '669', 'chad.dulac@silverhelm.com', 5)

UPDATE Nodes
SET DirectorID = 5
WHERE NodeID = 5

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, DepartmentID)
VALUES ('Mr.', 'Ty', 'Xanders', '336', 'ty.xanders@boxicity.com', 6)

UPDATE Nodes
SET DirectorID = 6
WHERE NodeID = 6

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, DepartmentID)
VALUES ('Mr.', 'Vince', 'Zampella', '006', 'vince.zampella@respawn.com', 7)

UPDATE Nodes
SET DirectorID = 7
WHERE NodeID = 7

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, DepartmentID)
VALUES ('Mr.', 'Ray', 'Muzyka', '089', 'ray.muzyka@bioware.com', 8)

UPDATE Nodes
SET DirectorID = 8
WHERE NodeID = 8

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, DepartmentID)
VALUES ('Mr.', 'Andrew', 'Wilson', '111', 'andrew.wilson@easports.com', 9)

UPDATE Nodes
SET DirectorID = 9
WHERE NodeID = 9

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, DepartmentID)
VALUES ('Mr.', 'Yannis', 'Mallat', '7934', 'yannis.mallat@ubisoft.com', 10)

UPDATE Nodes
SET DirectorID = 10
WHERE NodeID = 10

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, DepartmentID)
VALUES ('Mrs.', 'Corinne', 'Le Roy', '784', 'corinne.leroy@ubisoft.com', 11)

UPDATE Nodes
SET DirectorID = 11
WHERE NodeID = 11

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, DepartmentID)
VALUES ('Mr.', 'Steve', 'Reid', '045', 'steve.reid@redstorm.com', 12)

UPDATE Nodes
SET DirectorID = 12
WHERE NodeID = 12

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, DepartmentID)
VALUES ('Mrs.', 'Shannon', 'Studstill', '7945', 'shannon.studstill@sony.com', 13)

UPDATE Nodes
SET DirectorID = 13
WHERE NodeID = 13

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, DepartmentID)
VALUES ('Mr.', 'Neil', 'Druckman', '001', 'neil.druckman@sony.com', 14)

UPDATE Nodes
SET DirectorID = 14
WHERE NodeID = 14

INSERT INTO Employees (Title, FirstName, LastName, Phone, Email, DepartmentID)
VALUES ('Mr.', 'Hermen', 'Hulst', '7999', 'hermen.hulst@guerilla.com', 15)

UPDATE Nodes
SET DirectorID = 15
WHERE NodeID = 15