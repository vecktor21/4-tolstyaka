CREATE VIEW StaffPred
AS
SELECT s.FullName AS '��� ����������', p.PositionName AS '���������', p.Salary AS '��������' 
FROM Staff s INNER JOIN Positions p ON s.PositionID=p.PositionID