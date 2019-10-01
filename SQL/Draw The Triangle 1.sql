-- https://www.hackerrank.com/challenges/draw-the-triangle-1/problem

DECLARE @l INT
DECLARE @p VARCHAR(50)
DECLARE @y VARCHAR(50)

SET @l = 20

while(@l>=1)
BEGIN
    SET @p = REPLICATE('* ', @l)
    print @p
    set @l=@l-1;
END