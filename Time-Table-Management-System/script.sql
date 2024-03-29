USE [TimeTable]
GO
/****** Object:  Table [dbo].[Batch]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Batch](
	[Bname] [varchar](10) NOT NULL,
	[Students] [int] NULL,
 CONSTRAINT [PK_Batch] PRIMARY KEY CLUSTERED 
(
	[Bname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CNumber] [varchar](7) NOT NULL,
	[Cname] [varchar](50) NOT NULL,
	[type] [int] NOT NULL,
	[times] [int] NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Day]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Day](
	[Did] [int] IDENTITY(1,1) NOT NULL,
	[Day] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Day] PRIMARY KEY CLUSTERED 
(
	[Did] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[room]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[room](
	[Rname] [varchar](10) NOT NULL,
	[capacity] [int] NULL,
 CONSTRAINT [PK_room] PRIMARY KEY CLUSTERED 
(
	[Rname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[takes]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[takes](
	[Bname] [varchar](10) NOT NULL,
	[CNumber] [varchar](7) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[Tid] [int] IDENTITY(1,1) NOT NULL,
	[Tname] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[Tid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teaches]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teaches](
	[Tid] [int] NOT NULL,
	[Cnumber] [varchar](7) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Time]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Time](
	[tid] [int] IDENTITY(1,1) NOT NULL,
	[start_time] [time](7) NOT NULL,
	[end_time] [time](7) NOT NULL,
 CONSTRAINT [PK_Time] PRIMARY KEY CLUSTERED 
(
	[tid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unavailable]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unavailable](
	[tid] [int] NOT NULL,
	[did] [int] NOT NULL,
	[Time_id] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Batch] ([Bname], [Students]) VALUES (N'DRB1701', 100)
INSERT [dbo].[Batch] ([Bname], [Students]) VALUES (N'DRB1702', 100)
INSERT [dbo].[Batch] ([Bname], [Students]) VALUES (N'DRB1801', 100)
INSERT [dbo].[Batch] ([Bname], [Students]) VALUES (N'DRB1802', 100)
INSERT [dbo].[Batch] ([Bname], [Students]) VALUES (N'DRB1901', 100)
INSERT [dbo].[Batch] ([Bname], [Students]) VALUES (N'DRB1902', 100)
INSERT [dbo].[Batch] ([Bname], [Students]) VALUES (N'DRB2001', 100)
INSERT [dbo].[Batch] ([Bname], [Students]) VALUES (N'DRB2002', 100)
INSERT [dbo].[Batch] ([Bname], [Students]) VALUES (N'DRB2101', 100)
INSERT [dbo].[Batch] ([Bname], [Students]) VALUES (N'DRB2102', 100)
GO
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CC112', N'Logic and Critical Thinking', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CC113', N'General Psychology', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CC121', N'Geog of Ethiopia & the Horn', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CC122', N'History of Ethiopia and the Horn', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CC151', N'Com English Language Skills II', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CC273', N'Ace Principles II', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CC399', N'Entrepreneurship', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS213', N'Intro to Emerging Technologies', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS222', N'Computer Proq II', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS223', N'Windows Proqramminq', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS224', N'Obiect Oriented Proqrarnmlnq', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS262', N'Introduction To UNIX', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS302', N'Comp Orq & As Lang Prag', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS322', N'Web Desiqn & Dev', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS323', N'Web Design & Dev II ', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS341', N'Database Manaqment Systems', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS342', N'Database Proqramminq & Admin', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS343', N'Systems Analysis & Desion', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS415', N'Focusing Areas in ICT ', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS427', N'Compiler Design ', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS446', N'Obj Orient Software Engineering', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS486', N'Comp Systems Security', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS489', N'Computer Graphics ', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS497', N'Geographic Info Systems ', 0, 2)
INSERT [dbo].[Course] ([CNumber], [Cname], [type], [times]) VALUES (N'CS500', N'Senior Project ', 0, 2)
GO
SET IDENTITY_INSERT [dbo].[Day] ON 

INSERT [dbo].[Day] ([Did], [Day]) VALUES (1, N'Monday')
INSERT [dbo].[Day] ([Did], [Day]) VALUES (2, N'Tuesday')
INSERT [dbo].[Day] ([Did], [Day]) VALUES (3, N'Wednesday')
INSERT [dbo].[Day] ([Did], [Day]) VALUES (4, N'Thursday')
INSERT [dbo].[Day] ([Did], [Day]) VALUES (5, N'Friday')
INSERT [dbo].[Day] ([Did], [Day]) VALUES (6, N'Saturday')
SET IDENTITY_INSERT [dbo].[Day] OFF
GO
INSERT [dbo].[room] ([Rname], [capacity]) VALUES (N'LR201', NULL)
INSERT [dbo].[room] ([Rname], [capacity]) VALUES (N'LR202', NULL)
INSERT [dbo].[room] ([Rname], [capacity]) VALUES (N'LR301', NULL)
INSERT [dbo].[room] ([Rname], [capacity]) VALUES (N'LR302', NULL)
INSERT [dbo].[room] ([Rname], [capacity]) VALUES (N'LR303', NULL)
INSERT [dbo].[room] ([Rname], [capacity]) VALUES (N'LR401', NULL)
INSERT [dbo].[room] ([Rname], [capacity]) VALUES (N'LR402', NULL)
INSERT [dbo].[room] ([Rname], [capacity]) VALUES (N'LR501', NULL)
GO
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2101', N'CS341')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2101', N'CS224')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2101', N'CC112')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2101', N'CC122')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2102', N'CS222')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2102', N'CS262')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2102', N'CC113')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2102', N'CS213')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1702', N'CS500')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1801', N'CS486')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1801', N'CS427')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1801', N'CS415')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1802', N'CS323')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1802', N'CS427')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1802', N'CS486')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1802', N'CC399')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1802', N'CS489')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1901', N'CS323')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1901', N'CS446')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1901', N'CS497')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1901', N'CC273')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1902', N'CS322')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1902', N'CS302')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1902', N'CC151')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1902', N'CC121')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2001', N'CS343')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2001', N'CS322')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2001', N'CC151')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2001', N'CC121')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2002', N'CS342')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2002', N'CS223')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2002', N'CC112')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB2002', N'CC122')
INSERT [dbo].[takes] ([Bname], [CNumber]) VALUES (N'DRB1701', N'CS500')
GO
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (1, N'Bisrat')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (2, N'A')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (3, N'b')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (4, N'Ewnetu')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (5, N'Teume')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (6, N'C')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (7, N'D')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (8, N'Abdela')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (9, N'E')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (10, N'Andy')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (11, N'Nesredin')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (12, N'Abebe')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (13, N'F')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (14, N'Zelalem')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (15, N'meh')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (16, N'Mesfin')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (17, N'G')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (18, N'H')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (19, N'I')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (20, N'J')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (21, N'K')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (22, N'L')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (23, N'M')
INSERT [dbo].[Teacher] ([Tid], [Tname]) VALUES (24, N'N')
SET IDENTITY_INSERT [dbo].[Teacher] OFF
GO
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (2, N'CC113')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (3, N'CC121')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (4, N'CC122')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (5, N'CC151')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (6, N'CC273')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (7, N'CC399')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (8, N'CS213')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (9, N'CS222')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (10, N'CS223')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (11, N'CS224')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (12, N'CS262')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (13, N'CS302')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (14, N'CS322')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (15, N'CS323')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (16, N'CS342')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (17, N'CS343')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (18, N'CS415')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (19, N'CS427')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (20, N'CS446')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (21, N'CS486')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (22, N'CS489')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (23, N'CS497')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (24, N'CS500')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (1, N'CC112')
INSERT [dbo].[Teaches] ([Tid], [Cnumber]) VALUES (1, N'CS341')
GO
SET IDENTITY_INSERT [dbo].[Time] ON 

INSERT [dbo].[Time] ([tid], [start_time], [end_time]) VALUES (1, CAST(N'08:20:00' AS Time), CAST(N'10:00:00' AS Time))
INSERT [dbo].[Time] ([tid], [start_time], [end_time]) VALUES (2, CAST(N'10:30:00' AS Time), CAST(N'12:10:00' AS Time))
INSERT [dbo].[Time] ([tid], [start_time], [end_time]) VALUES (3, CAST(N'13:30:00' AS Time), CAST(N'15:10:00' AS Time))
INSERT [dbo].[Time] ([tid], [start_time], [end_time]) VALUES (4, CAST(N'15:30:00' AS Time), CAST(N'17:10:00' AS Time))
SET IDENTITY_INSERT [dbo].[Time] OFF
GO
INSERT [dbo].[unavailable] ([tid], [did], [Time_id]) VALUES (1, 6, 1)
INSERT [dbo].[unavailable] ([tid], [did], [Time_id]) VALUES (1, 6, 2)
INSERT [dbo].[unavailable] ([tid], [did], [Time_id]) VALUES (1, 6, 3)
INSERT [dbo].[unavailable] ([tid], [did], [Time_id]) VALUES (1, 6, 4)
GO
ALTER TABLE [dbo].[takes]  WITH CHECK ADD  CONSTRAINT [FK_takes_Batch] FOREIGN KEY([Bname])
REFERENCES [dbo].[Batch] ([Bname])
GO
ALTER TABLE [dbo].[takes] CHECK CONSTRAINT [FK_takes_Batch]
GO
ALTER TABLE [dbo].[takes]  WITH CHECK ADD  CONSTRAINT [FK_takes_Course] FOREIGN KEY([CNumber])
REFERENCES [dbo].[Course] ([CNumber])
GO
ALTER TABLE [dbo].[takes] CHECK CONSTRAINT [FK_takes_Course]
GO
ALTER TABLE [dbo].[Teaches]  WITH CHECK ADD  CONSTRAINT [FK_Teaches_Course] FOREIGN KEY([Cnumber])
REFERENCES [dbo].[Course] ([CNumber])
GO
ALTER TABLE [dbo].[Teaches] CHECK CONSTRAINT [FK_Teaches_Course]
GO
ALTER TABLE [dbo].[Teaches]  WITH CHECK ADD  CONSTRAINT [FK_Teaches_Teacher] FOREIGN KEY([Tid])
REFERENCES [dbo].[Teacher] ([Tid])
GO
ALTER TABLE [dbo].[Teaches] CHECK CONSTRAINT [FK_Teaches_Teacher]
GO
ALTER TABLE [dbo].[unavailable]  WITH CHECK ADD  CONSTRAINT [FK_unavailable_Day] FOREIGN KEY([did])
REFERENCES [dbo].[Day] ([Did])
GO
ALTER TABLE [dbo].[unavailable] CHECK CONSTRAINT [FK_unavailable_Day]
GO
ALTER TABLE [dbo].[unavailable]  WITH CHECK ADD  CONSTRAINT [FK_unavailable_Teacher] FOREIGN KEY([tid])
REFERENCES [dbo].[Teacher] ([Tid])
GO
ALTER TABLE [dbo].[unavailable] CHECK CONSTRAINT [FK_unavailable_Teacher]
GO
ALTER TABLE [dbo].[unavailable]  WITH CHECK ADD  CONSTRAINT [FK_unavailable_Time] FOREIGN KEY([Time_id])
REFERENCES [dbo].[Time] ([tid])
GO
ALTER TABLE [dbo].[unavailable] CHECK CONSTRAINT [FK_unavailable_Time]
GO
/****** Object:  StoredProcedure [dbo].[AddBatch]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddBatch]
@batchName varchar(50),
@no int
as
begin
	insert into Batch(Bname, Students)
	values (@batchName, @no)
end
GO
/****** Object:  StoredProcedure [dbo].[AddBatchCourse]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddBatchCourse]
@course varchar(50),
@batch varchar(50)
as
begin
	insert  into takes(Bname, CNumber)
	values (@batch, (select CNumber from Course where @course = Cname))
end
GO
/****** Object:  StoredProcedure [dbo].[AddCourse]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddCourse]
@name varchar(50),
@number varchar(50)
as
begin
	insert into Course(CNumber, Cname, type, times)
	values (@number, @name, 1, 2)
end
GO
/****** Object:  StoredProcedure [dbo].[AddTeacher]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddTeacher]
@Tname varchar(50),
@Tid int
as
begin
	insert into Teacher(Tname, Tid)
	values (@Tname, @Tid)
end
GO
/****** Object:  StoredProcedure [dbo].[AddTeacherCourse]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddTeacherCourse]
@course varchar(50),
@teacher varchar(50)
as
begin
	insert  into Teaches(Tid, CNumber)
	values ((select Tid from Teacher where @teacher = Tname),
	(select CNumber from Course where @course = Cname))
end
GO
/****** Object:  StoredProcedure [dbo].[BatchCourses]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[BatchCourses]
As
Begin
select Cname, Course.CNumber, Batch.Bname,Students from Course,Batch,takes where Course.CNumber=takes.Cnumber and Batch.Bname=takes.Bname
End
GO
/****** Object:  StoredProcedure [dbo].[CourseBatchTeacher]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[CourseBatchTeacher]
As
Begin
select Cname, Course.CNumber, Batch.Bname,Students, Teaches.Tid,type, times from Course,Batch,takes, Teaches where Course.CNumber=takes.Cnumber and Batch.Bname=takes.Bname and teaches.Cnumber =Course.CNumber;
End
GO
/****** Object:  StoredProcedure [dbo].[CourseTeacher]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[CourseTeacher]
As
Begin
select Cname, Course.CNumber, Teacher.Tid, Tname from Course,Teacher,Teaches where Course.CNumber=Teaches.Cnumber and Teacher.Tid=Teaches.Tid
End
GO
/****** Object:  StoredProcedure [dbo].[DeleteBatchCourse]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteBatchCourse]
@batch varchar(50)
as
begin
	delete from takes
	where @batch = Bname
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteCourse]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteCourse]
@name varchar(50)
as
begin
	delete from Course
	where Cname = @name
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteTeacherCourse]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteTeacherCourse]
@teacher varchar(50)
as
begin
	delete from Teaches
	where Tid = (select Tid from Teacher where @teacher = Tname)
end
GO
/****** Object:  StoredProcedure [dbo].[GetBatchCourse]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetBatchCourse]
@batch varchar(50)
as
begin
	select Course.Cname from Course, takes
	where takes.Bname = @batch and takes.CNumber = Course.CNumber
end
GO
/****** Object:  StoredProcedure [dbo].[getbatches]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[getbatches]
As
Begin
select * from Batch
End
GO
/****** Object:  StoredProcedure [dbo].[getCourses]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[getCourses]
As
Begin
select * from Course
End
GO
/****** Object:  StoredProcedure [dbo].[getDateTime]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getDateTime]
as
begin
select * from day, time order by Did;
end
GO
/****** Object:  StoredProcedure [dbo].[getRooms]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[getRooms]
As
Begin
select * from Room
End
GO
/****** Object:  StoredProcedure [dbo].[GetTeacherCourse]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetTeacherCourse]
@teacher varchar(50)
as
begin
	select Course.Cname from Course, Teaches
	where Teaches.Tid = (select Tid from Teacher where Tname = @teacher)
	and Teaches.Cnumber = Course.CNumber
end
GO
/****** Object:  StoredProcedure [dbo].[getTeachers]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[getTeachers]
As
Begin
select * from Teacher
End
GO
/****** Object:  StoredProcedure [dbo].[getUnavailable]    Script Date: 5/27/2022 1:00:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getUnavailable]
as
begin
select * from unavailable
end
GO
