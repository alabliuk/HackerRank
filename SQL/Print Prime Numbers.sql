-- https://www.hackerrank.com/challenges/print-prime-numbers/problem

DECLARE @X INT
DECLARE @P INT
DECLARE @AUX INT
DECLARE @S VARCHAR(MAX)
SET @X = (SELECT 3)
SET @P = (SELECT 1)
SET @AUX = (SELECT 1)
SET @S = (SELECT 2)

WHILE(@X <= 1000)
BEGIN
    WHILE(@P <= @X)
    BEGIN
        SET @AUX = (SELECT @X % @P)
        
        --SELECT @X, @P, @AUX
        IF(@AUX = 0 AND @X = @P)
        BEGIN
            SET @S = CONCAT(@S, '&') + CAST(@P AS VARCHAR)
        END
        
        IF(@AUX = 0 AND @P <> 1)
        BEGIN
            SET @P = @X +1
        END
        ELSE
        BEGIN
            SET @P = (SELECT @P + 1)
        END
    END

    --SELECT @X
    SET @P = (SELECT 1)
    SET @X = (SELECT @X + 1)
END

PRINT @S