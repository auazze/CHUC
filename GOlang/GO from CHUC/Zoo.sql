DROP TABLE IF EXISTS Animals, Human, Aviary CASCADE;

CREATE TABLE IF NOT EXISTS Aviary
(
    Aviary_ID SERIAL PRIMARY KEY,
    Type TEXT
);
INSERT INTO Aviary (Type) VALUES ('Animals'), ('Human');

CREATE TABLE IF NOT EXISTS Animals
(
    id SERIAL PRIMARY KEY,
    A_Name TEXT,
    A_Age INT,
    Aviary_ID INT,
    CONSTRAINT fk_Aviary_Animals FOREIGN KEY (Aviary_ID) REFERENCES Aviary(Aviary_ID)
);

INSERT INTO Animals (A_Name, A_Age, Aviary_ID) VALUES 
('Zeus', 5000, 1),
('Oppenheimer', 40, 1),
('Your bestie', 20, 1);

CREATE TABLE IF NOT EXISTS Human
(
    id SERIAL PRIMARY KEY,
    H_Name TEXT,
    H_Age INT,  
    Aviary_ID INT,
    CONSTRAINT fk_Aviary_Human FOREIGN KEY (Aviary_ID) REFERENCES Aviary(Aviary_ID)
);

INSERT INTO Human (H_Name, H_Age, Aviary_ID) VALUES
('Monkey', 3, 2),
('Donkey', 5, 2);

SELECT * FROM Animals
UNION ALL
SELECT * FROM Human
UNION ALL
SELECT Aviary_ID, Type, NULL, NULL FROM Aviary;
