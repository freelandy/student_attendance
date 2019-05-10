use attendance;

﻿CREATE TABLE `Admin` (
	`ID` int NOT NULL auto_increment,
	`Code` varchar(254),
	`Name` varchar(254),
    PRIMARY KEY(`ID`)
);


CREATE TABLE `Attendance` (
	`ID` int NOT NULL auto_increment, 
	`ScheduleId` int, 
	`Date` date, 
	`StudentId` int, 
	`State` int, 
	`ClientId` int,
    PRIMARY KEY(`ID`)
);


CREATE TABLE `Class` (
	`ID` int NOT NULL auto_increment, 
	`Code` varchar(254), 
	`Name` varchar(254), 
	`DepartmentId` varchar(254), 
	`IsDeleted` int,
    PRIMARY KEY(`ID`)
);


CREATE TABLE `Course` (
	`ID` int NOT NULL auto_increment, 
	`Code` varchar(254), 
	`Name` varchar(254), 
	`Category` varchar(254), 
	`TotalHours` int, 
	`Credit` decimal(15, 0), 
	`Semester` int, 
	`AssessmentMethod` varchar(254), 
	`IsDeleted` int,
    PRIMARY KEY(`ID`)
);


CREATE TABLE `Department` (
	`ID` int NOT NULL auto_increment, 
	`Code` varchar(254), 
	`Name` varchar(254), 
	`IsDeleted` int,
    PRIMARY KEY(`ID`)
);


CREATE TABLE `LeaveApplication` (
	`ID` int NOT NULL auto_increment, 
	`ScheduleId` int, 
	`StudentId` int, 
	`ApplyDate` date, 
	`LeaveDate` date, 
	`Reason` varchar(254), 
	`Approval` int,
    PRIMARY KEY(`ID`)
);


CREATE TABLE `Login` (
	`ID` int NOT NULL auto_increment, 
	`UserId` int, 
	`Password` varchar(254), 
	`LoginType` int, 
	`LastLoginTime` datetime, 
	`ClientIP` varchar(254), 
	`IsDeleted` varchar(254),
    PRIMARY KEY(`ID`)
);


CREATE TABLE `Schedule` (
	`ID` int NOT NULL auto_increment, 
	`StartWeek` int, 
	`EndWeek` int, 
	`Day` int, 
	`SemesterId` int, 
	`ClassPeriod` int, 
	`LocationId` int, 
	`TeacherId` int, 
	`ClassId` varchar(254), 
	`CourseId` int,
    PRIMARY KEY(`ID`)
);


CREATE TABLE `Semester` (
	`ID` int NOT NULL auto_increment, 
	`Code` varchar(254), 
	`Name` varchar(254), 
	`StartDate` date, 
	`Weeks` int,
    PRIMARY KEY(`ID`)
);


CREATE TABLE `Student` (
	`ID` int NOT NULL auto_increment, 
	`Code` varchar(254), 
	`Name` varchar(254), 
	`DepartmentId` int, 
	`ClassId` int, 
	`Gender` varchar(254), 
	`BirthDate` date, 
	`Native` varchar(254), 
	`Mobile` varchar(254), 
	`PhotoPath` varchar(254), 
	`IsDeleted` int,
    PRIMARY KEY(`ID`)
);


CREATE TABLE `StudentClass` (
	`ID` int NOT NULL auto_increment, 
	`StudentId` int, 
	`ClassId` int,
    PRIMARY KEY(`ID`)
);


CREATE TABLE `Teacher` (
	`ID` int NOT NULL auto_increment, 
	`Code` varchar(254), 
	`Name` varchar(254), 
	`ProfessionalTitle` varchar(254), 
	`Gender` varchar(254), 
	`BirthDate` date, 
	`Mobile` varchar(254), 
	`Major` varchar(254), 
	`DepartmentId` int, 
	`Photo` blob, 
	`IsDeleted` int,
    PRIMARY KEY(`ID`)
);


CREATE TABLE `TeacherDepartment` (
	`ID` int NOT NULL auto_increment, 
	`TeacherId` int, 
	`DepartmentId` int,
    PRIMARY KEY(`ID`)
);


create table `Location` (
	`ID` int not null auto_increment,
    `Name` varchar(254),
    `Capacity` int,
    `Type` varchar(254),
    `IsDeleted` int,
    PRIMARY KEY(`ID`)
);
