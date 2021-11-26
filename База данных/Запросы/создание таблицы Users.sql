USE BakeryDB
Create table Users(
userLogin CHAR(20) NOT NULL,
userPassword CHAR(30) NOT NULL,
staffID Int NOT NULL,
CONSTRAINT foreign_user FOREIGN KEY (staffID) references Staff (StaffID)
)