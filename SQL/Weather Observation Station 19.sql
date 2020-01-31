-- https://www.hackerrank.com/challenges/weather-observation-station-19/

-- Euclidean distance

DECLARE @A FLOAT
DECLARE @B FLOAT
DECLARE @C FLOAT
DECLARE @D FLOAT

SET @A = (SELECT MIN(LAT_N) FROM STATION)
SET @B = (SELECT MAX(LAT_N) FROM STATION)
SET @C = (SELECT MIN(LONG_W) FROM STATION)
SET @D = (SELECT MAX(LONG_W) FROM STATION)

SELECT 
    CAST(
        ROUND(
            SQRT(
                (POWER(
                    ABS(@A - @B)
                        , 2)
                    +
                 POWER(
                     ABS(@C - @D)
                        , 2)
                )
            )
        , 4)
    AS DECIMAL(10,4))