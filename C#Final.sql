USE [Code_Academy]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 1/29/2018 1:36:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[gender_name] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group_schedule]    Script Date: 1/29/2018 1:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group_schedule](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[group_schedule_name] [nvarchar](max) NOT NULL,
	[group_begin_time] [datetime] NOT NULL,
	[group_end_time] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group_types]    Script Date: 1/29/2018 1:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group_types](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[group_type_name] [nvarchar](max) NOT NULL,
	[group_schedule_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 1/29/2018 1:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[group_name] [nvarchar](max) NOT NULL,
	[group_type_id] [int] NOT NULL,
	[group_techer_id] [int] NOT NULL,
	[group_mentor_id] [int] NOT NULL,
	[group_start_date] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mentors]    Script Date: 1/29/2018 1:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mentors](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mentor_name] [nvarchar](max) NOT NULL,
	[mentor_surname] [nvarchar](max) NOT NULL,
	[mentor_email] [nvarchar](max) NOT NULL,
	[mentor_phone] [nvarchar](max) NOT NULL,
	[mentor_photo] [nvarchar](max) NOT NULL,
	[mentor_info] [nvarchar](max) NOT NULL,
	[mentor_gender_id] [int] NOT NULL,
	[mentor_password] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 1/29/2018 1:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[student_surname] [nvarchar](max) NOT NULL,
	[student_name] [nvarchar](max) NOT NULL,
	[student_email] [nvarchar](max) NOT NULL,
	[student_phone] [nvarchar](max) NOT NULL,
	[student_github_account] [nvarchar](max) NOT NULL,
	[student_info] [nvarchar](max) NOT NULL,
	[student_photo] [nvarchar](max) NOT NULL,
	[student_cap_point] [float] NOT NULL,
	[student_group_id] [int] NOT NULL,
	[student_gender_id] [int] NOT NULL,
	[student_password] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Task_types]    Script Date: 1/29/2018 1:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task_types](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[task_type_name] [nvarchar](max) NOT NULL,
	[task_type_rate] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 1/29/2018 1:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasks](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[task_type_id] [int] NOT NULL,
	[task_start_date] [datetime] NOT NULL,
	[task_end_date] [datetime] NOT NULL,
	[task_point] [float] NOT NULL,
	[task_source] [nvarchar](max) NOT NULL,
	[task_note] [nvarchar](max) NOT NULL,
	[task_group_id] [int] NULL,
	[task_student_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 1/29/2018 1:36:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[teacher_name] [nvarchar](max) NOT NULL,
	[teacher_surname] [nvarchar](max) NOT NULL,
	[teacher_email] [nvarchar](max) NOT NULL,
	[teacher_phone] [nvarchar](max) NOT NULL,
	[teacher_photo] [nvarchar](max) NOT NULL,
	[teacher_info] [nvarchar](max) NOT NULL,
	[teacher_gender_id] [int] NOT NULL,
	[teacher_password] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Group_types]  WITH CHECK ADD  CONSTRAINT [FK_Group_types_Group_schedule] FOREIGN KEY([group_schedule_id])
REFERENCES [dbo].[Group_schedule] ([id])
GO
ALTER TABLE [dbo].[Group_types] CHECK CONSTRAINT [FK_Group_types_Group_schedule]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [FK_Groups_Group_types] FOREIGN KEY([group_type_id])
REFERENCES [dbo].[Group_types] ([id])
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [FK_Groups_Group_types]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [FK_Groups_Mentors] FOREIGN KEY([group_mentor_id])
REFERENCES [dbo].[Mentors] ([id])
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [FK_Groups_Mentors]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [FK_Groups_Teachers] FOREIGN KEY([group_techer_id])
REFERENCES [dbo].[Teachers] ([id])
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [FK_Groups_Teachers]
GO
ALTER TABLE [dbo].[Mentors]  WITH CHECK ADD  CONSTRAINT [FK_Mentors_Gender] FOREIGN KEY([mentor_gender_id])
REFERENCES [dbo].[Gender] ([id])
GO
ALTER TABLE [dbo].[Mentors] CHECK CONSTRAINT [FK_Mentors_Gender]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Gender] FOREIGN KEY([student_gender_id])
REFERENCES [dbo].[Gender] ([id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Gender]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Groups] FOREIGN KEY([student_group_id])
REFERENCES [dbo].[Groups] ([id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Groups]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Groups] FOREIGN KEY([task_group_id])
REFERENCES [dbo].[Groups] ([id])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_Groups]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Students] FOREIGN KEY([task_student_id])
REFERENCES [dbo].[Students] ([id])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_Students]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tasks_Task_types] FOREIGN KEY([task_type_id])
REFERENCES [dbo].[Task_types] ([id])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_Tasks_Task_types]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_Gender] FOREIGN KEY([teacher_gender_id])
REFERENCES [dbo].[Gender] ([id])
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [FK_Teachers_Gender]
GO
