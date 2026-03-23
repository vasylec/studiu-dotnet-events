
--use master
--DROP DATABASE event_db


IF NOT EXISTS (
    SELECT name 
    FROM sys.databases 
    WHERE name = N'event_db'
)
BEGIN
    CREATE DATABASE event_db;
END

GO
USE event_db
GO

CREATE TABLE evenimente(
	id_eveniment INT PRIMARY KEY IDENTITY(1,1),
	denumire NVARCHAR(100) NOT NULL,
	data_ DATE NOT NULL,
	locatie NVARCHAR(100) NOT NULL,
	locuri_disponibile INT NOT NULL,
	tip_eveniment NVARCHAR(100)
)

GO

CREATE TABLE participanti(
	id_participant INT PRIMARY KEY IDENTITY(1,1),
	nume NVARCHAR(100) NOT NULL,
	prenume NVARCHAR(100) NOT NULL,
	email NVARCHAR(100) NOT NULL CHECK (email LIKE '%@%.%')
)

GO

CREATE TABLE inscrieri(
	id_inscriere INT PRIMARY KEY IDENTITY(1,1),
	id_eveniment INT FOREIGN KEY REFERENCES evenimente(id_eveniment),
	id_participant INT FOREIGN KEY REFERENCES participanti(id_participant),
	status_ NVARCHAR(100) NOT NULL
)

GO

INSERT INTO evenimente (denumire, data_, locatie, locuri_disponibile, tip_eveniment) VALUES
(N'Conferința IT', '2026-04-15', N'București', 100, N'Conferință'),
(N'Workshop Marketing', '2026-05-10', N'Cluj-Napoca', 50, N'Workshop'),
(N'Concert Rock', '2026-06-20', N'Iași', 200, N'Concert'),
(N'Târg de Carte', '2026-07-05', N'Brașov', 150, N'Expoziție'),
(N'Hackathon Studențesc', '2026-08-12', N'Timișoara', 80, N'Competiție'),
(N'Festival Gastronomic', '2026-09-01', N'Constanța', 300, N'Festival'),
(N'Training Leadership', '2026-09-15', N'Sibiu', 40, N'Training'),
(N'Expo Auto', '2026-10-03', N'Oradea', 120, N'Expoziție'),
(N'Bal Caritabil', '2026-11-22', N'București', 200, N'Caritate'),
(N'Seminar Siguranța Muncii', '2026-12-05', N'Ploiești', 60, N'Seminar');

GO

INSERT INTO participanti (nume, prenume, email) VALUES
(N'Popescu', N'Andrei', 'andrei.popescu@gmail.com'),
(N'Ionescu', N'Maria', 'maria.ionescu@yahoo.com'),
(N'Georgescu', N'Paul', 'paul.georgescu@outlook.com'),
(N'Dumitrescu', N'Ioana', 'ioana.dumitrescu@gmail.com'),
(N'Stan', N'Mihai', 'mihai.stan@yahoo.com'),
(N'Radu', N'Elena', 'elena.radu@outlook.com'),
(N'Matei', N'Cristian', 'cristian.matei@gmail.com'),
(N'Voicu', N'Ana', 'ana.voicu@yahoo.com'),
(N'Marin', N'Daniel', 'daniel.marin@outlook.com'),
(N'Petrescu', N'Laura', 'laura.petrescu@gmail.com'),
(N'Iliescu', N'George', 'george.iliescu@gmail.com'),
(N'Popa', N'Adriana', 'adriana.popa@yahoo.com'),
(N'Barbu', N'Florin', 'florin.barbu@outlook.com'),
(N'Neagu', N'Raluca', 'raluca.neagu@gmail.com'),
(N'Enache', N'Victor', 'victor.enache@yahoo.com'),
(N'Voinea', N'Gabriela', 'gabriela.voinea@outlook.com'),
(N'Preda', N'Alexandru', 'alexandru.preda@gmail.com'),
(N'Costache', N'Diana', 'diana.costache@yahoo.com'),
(N'Grigore', N'Sorin', 'sorin.grigore@outlook.com'),
(N'Ciobanu', N'Irina', 'irina.ciobanu@gmail.com');

GO

INSERT INTO inscrieri (id_eveniment, id_participant, status_) VALUES
(1, 1, N'Confirmat'),
(1, 2, N'Confirmat'),
(2, 3, N'Confirmat'),
(2, 4, N'În așteptare'),
(3, 5, N'Confirmat'),
(3, 6, N'Confirmat'),
(4, 7, N'Confirmat'),
(4, 8, N'Confirmat'),
(5, 9, N'Confirmat'),
(5, 10, N'În așteptare'),
(6, 11, N'Confirmat'),
(6, 12, N'Confirmat'),
(7, 13, N'Confirmat'),
(7, 14, N'Confirmat'),
(8, 15, N'Confirmat'),
(8, 16, N'În așteptare'),
(9, 17, N'Confirmat'),
(9, 18, N'Confirmat'),
(10, 19, N'Confirmat'),
(10, 20, N'Confirmat');


GO


CREATE PROCEDURE addEvent 
    @denumireParam NVARCHAR(100), 
    @dataParam DATE, 
    @locatieParam NVARCHAR(100), 
    @tip_eveniment NVARCHAR(100), 
    @nrLocuri INT
AS
BEGIN
    IF NOT EXISTS (
        SELECT 1 
        FROM evenimente
        WHERE denumire = @denumireParam
          AND data_ = @dataParam
          AND locatie = @locatieParam
          AND locuri_disponibile = @nrLocuri
          AND tip_eveniment = @tip_eveniment
    )
    BEGIN
        INSERT INTO evenimente (denumire, data_, locatie, locuri_disponibile, tip_eveniment)
        VALUES (@denumireParam, @dataParam, @locatieParam, @nrLocuri, @tip_eveniment)
    END
    ELSE
    BEGIN
        RAISERROR('Evenimentul există deja!', 16, 1)
    END
END;

GO

CREATE PROCEDURE addParticipant @numeParam NVARCHAR(100), @prenumeParam NVARCHAR(100), @emailParam NVARCHAR(100)
AS
BEGIN
	INSERT INTO participanti VALUES(@numeParam,@prenumeParam,@emailParam)
END;


GO

CREATE PROCEDURE regParticipant 
    @idParticipant INT, 
    @idEveniment INT, 
    @status NVARCHAR(100)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        IF NOT EXISTS (
            SELECT 1 
            FROM inscrieri
            WHERE id_participant = @idParticipant
              AND id_eveniment = @idEveniment
        )
        BEGIN
            INSERT INTO inscrieri (id_eveniment, id_participant, status_) 
            VALUES (@idEveniment, @idParticipant, @status);

            UPDATE evenimente
            SET locuri_disponibile = locuri_disponibile - 1
            WHERE id_eveniment = @idEveniment;
        END
        ELSE
        BEGIN
            RAISERROR('Participantul este deja inscris la acest eveniment!', 16, 1);
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT;
        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH;
END;

GO

CREATE VIEW selectParticipantsPerEvent AS
SELECT participanti.id_participant,nume,prenume,email,evenimente.id_eveniment, denumire, data_, locatie, tip_eveniment, inscrieri.status_ FROM inscrieri
INNER JOIN participanti ON inscrieri.id_participant = participanti.id_participant
INNER JOIN evenimente ON evenimente.id_eveniment = inscrieri.id_eveniment


SELECT * FROM evenimente
SELECT * FROM inscrieri
SELECT * FROM participanti

SELECT * FROM selectParticipantsPerEvent



CREATE VIEW nrOfParticipantsByEvents_vw AS
SELECT denumire, locatie, tip_eveniment, locuri_disponibile, COUNT(nume) AS NumarParticipanti FROM inscrieri
INNER JOIN evenimente ON evenimente.id_eveniment = inscrieri.id_eveniment
INNER JOIN participanti ON participanti.id_participant = inscrieri.id_participant
GROUP BY evenimente.denumire, evenimente.locatie, evenimente.tip_eveniment, evenimente.locuri_disponibile



CREATE VIEW participantOnSpecificEvent_vw AS
SELECT inscrieri.id_eveniment ,nume, prenume, email, denumire, locatie, tip_eveniment, locuri_disponibile FROM inscrieri
INNER JOIN evenimente ON evenimente.id_eveniment = inscrieri.id_eveniment
INNER JOIN participanti ON participanti.id_participant = inscrieri.id_participant


SELECT * FROM participantOnSpecificEvent_vw
WHERE id_eveniment = 1














