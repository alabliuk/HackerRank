-- https://www.hackerrank.com/challenges/draw-the-triangle-2/problem

DECLARE @COUNTER INT = 1;
WHILE @COUNTER <= 20
BEGIN
    PRINT REPLICATE('* ', @COUNTER)
    SET @COUNTER = @COUNTER + 1
END