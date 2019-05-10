CREATE TABLE [Admin] (
	[ID] guid NOT NULL PRIMARY KEY, 
	[Code] varchar(254), 
	[Name] varchar(254)
)
GO

CREATE TABLE [Attendance] (
	[ID] guid NOT NULL PRIMARY KEY, 
	[ScheduleId] guid, 
	[Date] date, 
	[StudentId] guid, 
	[State] int, 
	[ClientId] guid
)
GO

CREATE TABLE [Class] (
	[ID] guid NOT NULL PRIMARY KEY, 
	[Code] varchar(254), 
	[Name] varchar(254), 
	[DepartmentId] varchar(254), 
	[IsDeleted] int
)
GO

CREATE TABLE [Course] (
	[ID] guid NOT NULL PRIMARY KEY, 
	[Code] varchar(254), 
	[Name] varchar(254), 
	[Category] varchar(254), 
	[TotalHours] int, 
	[Credit] decimal(15, 0), 
	[Semester] int, 
	[AssessmentMethod] varchar(254), 
	[IsDeleted] int
)
GO

CREATE TABLE [Department] (
	[ID] guid NOT NULL PRIMARY KEY, 
	[Code] varchar(254), 
	[Name] varchar(254), 
	[IsDeleted] int
)
GO

CREATE TABLE [LeaveApplication] (
	[ID] guid NOT NULL PRIMARY KEY, 
	[ScheduleId] guid, 
	[StudentId] guid, 
	[ApplyDate] date, 
	[LeaveDate] date, 
	[Reason] varchar(254), 
	[Approval] int
)
GO

CREATE TABLE [Login] (
	[ID] guid NOT NULL PRIMARY KEY, 
	[UserId] guid, 
	[Password] varchar(254), 
	[LoginType] int, 
	[LastLoginTime] datetime, 
	[ClientIP] varchar(254), 
	[IsDeleted] nvarchar(254)
)
GO

CREATE TABLE [Schedule] (
	[ID] guid NOT NULL PRIMARY KEY, 
	[StartWeek] int, 
	[EndWeek] int, 
	[Day] int, 
	[SemesterId] guid, 
	[ClassPeriod] int, 
	[LocationId] guid, 
	[TeacherId] guid, 
	[ClassId] varchar(254), 
	[CourseId] guid
)
GO

CREATE TABLE [Semester] (
	[ID] guid NOT NULL PRIMARY KEY, 
	[Code] varchar(254), 
	[Name] varchar(254), 
	[StartDate] date, 
	[Weeks] int
)
GO

CREATE TABLE [Student] (
	[ID] guid NOT NULL PRIMARY KEY, 
	[Code] varchar(254), 
	[Name] varchar(254), 
	[DepartmentId] guid, 
	[ClassId] guid, 
	[Gender] varchar(254), 
	[BirthDate] date, 
	[Native] varchar(254), 
	[Mobile] varchar(254), 
	[Photo] blob, 
	[IsDeleted] int
)
GO

CREATE TABLE [StudentClass] (
	[ID] guid NOT NULL PRIMARY KEY, 
	[StudentId] guid, 
	[ClassId] guid
)
GO

CREATE TABLE [Teacher] (
	[ID] guid NOT NULL PRIMARY KEY, 
	[Code] varchar(254), 
	[Name] varchar(254), 
	[ProfessionalTitle] varchar(254), 
	[Gender] varchar(254), 
	[BirthDate] date, 
	[Mobile] varchar(254), 
	[Major] varchar(254), 
	[DepartmentId] guid, 
	[Photo] blob, 
	[IsDeleted] int
)
GO

CREATE TABLE [TeacherDepartment] (
	[ID] guid NOT NULL PRIMARY KEY, 
	[TeacherId] guid, 
	[DepartmentId] guid
)
