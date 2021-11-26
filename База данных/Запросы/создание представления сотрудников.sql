CREATE VIEW StaffPred
AS
SELECT s.FullName AS 'Имя сотрудника', p.PositionName AS 'Должность', p.Salary AS 'Зарплата' 
FROM Staff s INNER JOIN Positions p ON s.PositionID=p.PositionID