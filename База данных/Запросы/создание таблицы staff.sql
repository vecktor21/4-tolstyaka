USE BakeryDB
CREATE TABLE Staff(
StaffID INT NOT NULL IDENTITY(1, 1),
FullName NVARCHAR(50) NOT NULL,
Gender CHAR(1) NULL,
PositionID INT NOT NULL,
Salary Money
CONSTRAINT primary_staffID PRIMARY KEY (StaffID),
CONSTRAINT foreign_posID FOREIGN KEY(PositionID) REFERENCES Positions (PositionID)
)
