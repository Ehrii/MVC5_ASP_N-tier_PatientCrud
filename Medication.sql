
/*  Queries seperated into batches using the GO special command. */
CREATE TABLE Medication (
    Id INT IDENTITY(1,1) PRIMARY KEY, 
    Dosage DECIMAL(7,4) NOT NULL, 
    Drug NVARCHAR(50) NOT NULL, 
    Patient NVARCHAR(50) NOT NULL, 
    ModifiedDate DATETIME NOT NULL DEFAULT GETDATE() 
);
/* Create a Medication Table.*/

SELECT * FROM Medication;
GO
/* Display the medication table.*/

CREATE PROCEDURE InsertMedication
	@Dosage DECIMAL(7,4),
	@Drug NVARCHAR(MAX),
	@Patient NVARCHAR(MAX)
AS
BEGIN 
	INSERT INTO Medication(Dosage, Drug, Patient,ModifiedDate)
	VALUES (@Dosage, @Drug, @Patient, GETDATE());
END;
GO
/* Create a stored procedure called "InsertMedication" for storing values. */


EXEC InsertMedication 
    @Dosage = 5.5, 
    @Drug = 'Aspirin', 
    @Patient = 'John Doe';
GO
/* Create a sample execution query to add a values in the DB. */


CREATE PROCEDURE UpdateMedication
	@id INT,
	@Dosage DECIMAL(7,4),
	@Drug NVARCHAR(MAX),
	@Patient NVARCHAR(MAX)
AS
BEGIN
	UPDATE Medication	
	SET Dosage = @Dosage,
		Drug = @Drug,
		Patient = @Patient,
		ModifiedDate = GETDATE()
	WHERE Id = @id
END;
GO
/* Create a stored procedure called "UpdateMedication" for updating values. */


CREATE PROCEDURE DeleteMedication
	@id INT
AS 
BEGIN
	DELETE FROM Medication WHERE Id = @Id;
END;
GO
/* Create a stored procedure called "DeleteMedication" for deleting values. */

CREATE VIEW MedicationView AS
SELECT
	Dosage,
	Drug,
	Patient,
	FORMAT(ModifiedDate, 'MMMM dd yyy') AS FormattedDate
FROM Medication;
GO
/* Create a view called "Medication" for displaying the records. */



