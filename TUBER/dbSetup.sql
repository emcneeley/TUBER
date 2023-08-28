-- Active: 1693253606889@@13.52.235.253@3306@TUBER

CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture',
        isTutor TINYINT NOT NULL DEFAULT 0,
        isStudent TINYINT NOT NULL DEFAULT 1
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS session(
        id INT NOT NULL AUTO_INCREMENT primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        studentId VARCHAR (255),
        tutorId VARCHAR (255),
        topicId INT NOT NULL,
        date VARCHAR (20),
        isCompleted TINYINT NOT NULL DEFAULT 0,
        isConfirmed VARCHAR(100),
        topic VARCHAR (200),
        description VARCHAR (300),
        FOREIGN KEY(studentId) REFERENCES accounts(id) ON DELETE CASCADE,
        FOREIGN KEY (tutorId) REFERENCES accounts(id) ON DELETE CASCADE,
        FOREIGN KEY (topicId) REFERENCES topic(id) ON DELETE CASCADE
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS topic(
        id INT NOT NULL AUTO_INCREMENT primary key COMMENT 'primary key',
        subject VARCHAR (100),
        hourlyRate INT NOT NULL,
        accountId VARCHAR(255),
        level VARCHAR (100),
        FOREIGN KEY (accountId) REFERENCES accounts(id) ON DELETE CASCADE
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS reviews(
        id INT NOT NULL AUTO_INCREMENT primary key COMMENT 'primary key',
        ratingCount INT NOT NULL,
        studentID VARCHAR(255),
        tutorId VARCHAR(255),
        FOREIGN KEY(studentId) REFERENCES accounts(id) ON DELETE CASCADE,
        FOREIGN KEY (tutorId) REFERENCES accounts(id) ON DELETE CASCADE
    ) default charset utf8 COMMENT '';