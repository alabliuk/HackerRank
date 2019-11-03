-- https://www.hackerrank.com/challenges/weather-observation-station-18/problem

-- https://xlinux.nist.gov/dads/HTML/manhattanDistance.html

DECLARE @A FLOAT
DECLARE @B FLOAT
DECLARE @C FLOAT
DECLARE @D FLOAT

SET @A = (SELECT MIN(LAT_N) FROM STATION)
SET @B = (SELECT MIN(LONG_W) FROM STATION)
SET @C = (SELECT MAX(LAT_N) FROM STATION)
SET @D = (SELECT MAX(LONG_W) FROM STATION)

SELECT ROUND(ABS((@A - @C)) + ABS((@B - @D)), 4)