-- https://www.hackerrank.com/challenges/binary-search-tree-1/problem

SELECT DISTINCT A.N, --A.P, B.N, B.P,
    CASE
        WHEN (A.P IS NULL AND B.P IS NOT NULL) THEN 'Root'
        WHEN (B.P IS NULL) THEN 'Leaf'
        ELSE 'Inner'
    END
FROM BST A
LEFT JOIN BST B ON A.N = B.P 
ORDER BY A.N ASC