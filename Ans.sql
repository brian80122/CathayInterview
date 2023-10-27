
WITH ExamWithRank AS (
    SELECT 
        e.StdID, 
        e.Score, 
        s.ClassID, 
        s.StdName,
        ROW_NUMBER() OVER (PARTITION BY s.ClassID ORDER BY e.Score DESC) AS Rank
    FROM (
        SELECT StdID, SUM(Score) AS Score 
        FROM Exam 
        WHERE ExamType = 'FinalExam' 
        GROUP BY StdID
    ) AS e
    LEFT JOIN Students AS s ON e.StdID = s.StdID
)
SELECT StdID, Score, ClassID, StdName, Rank
FROM ExamWithRank
WHERE Rank = 1
ORDER BY ClassID, Score DESC;


WITH ExamWithRank AS (
    SELECT 
        e.StdID, 
        e.Score, 
        s.ClassID, 
        s.StdName,
        ROW_NUMBER() OVER (PARTITION BY s.ClassID ORDER BY e.Score DESC) AS Rank
    FROM (
        SELECT StdID, SUM(Score) AS Score 
        FROM Exam 
        WHERE ExamType = 'FinalExam' 
        GROUP BY StdID
    ) AS e
    LEFT JOIN Students AS s ON e.StdID = s.StdID
)
SELECT StdID, Score, ClassID, StdName, Rank
FROM ExamWithRank
WHERE Rank = 1
ORDER BY ClassID, Score DESC;