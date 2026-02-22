use college;
GO

CREATE TABLE dbo.fees
(
fid INT IDENTITY (1,1) PRIMARY KEY,
NAID INT NOT NULL,
fees INT NOT NULL
);

SELECT * FROM fees;