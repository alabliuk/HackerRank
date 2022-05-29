# https://www.hackerrank.com/challenges/the-report/problem

SELECT
    IF(grade < 8, null, name),
    grade, marks
FROM 
    students 
JOIN
    grades
WHERE
    marks BETWEEN min_mark AND max_mark
ORDER BY 
    grade DESC,
    name ASC