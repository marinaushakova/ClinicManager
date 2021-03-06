USE [master]
GO
/****** Object:  Database [cs6232-g1]    Script Date: 04/04/2015 16:14:54 ******/
CREATE DATABASE [cs6232-g1] ON  PRIMARY 
( NAME = N'cs6232-g1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\cs6232-g1.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'cs6232-g1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\cs6232-g1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [cs6232-g1] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cs6232-g1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cs6232-g1] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [cs6232-g1] SET ANSI_NULLS OFF
GO
ALTER DATABASE [cs6232-g1] SET ANSI_PADDING OFF
GO
ALTER DATABASE [cs6232-g1] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [cs6232-g1] SET ARITHABORT OFF
GO
ALTER DATABASE [cs6232-g1] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [cs6232-g1] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [cs6232-g1] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [cs6232-g1] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [cs6232-g1] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [cs6232-g1] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [cs6232-g1] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [cs6232-g1] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [cs6232-g1] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [cs6232-g1] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [cs6232-g1] SET  DISABLE_BROKER
GO
ALTER DATABASE [cs6232-g1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [cs6232-g1] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [cs6232-g1] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [cs6232-g1] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [cs6232-g1] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [cs6232-g1] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [cs6232-g1] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [cs6232-g1] SET  READ_WRITE
GO
ALTER DATABASE [cs6232-g1] SET RECOVERY FULL
GO
ALTER DATABASE [cs6232-g1] SET  MULTI_USER
GO
ALTER DATABASE [cs6232-g1] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [cs6232-g1] SET DB_CHAINING OFF
GO
USE [cs6232-g1]
GO
/****** Object:  Table [dbo].[test]    Script Date: 04/04/2015 16:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[test](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Description] [text] NOT NULL,
	[is_active] [bit] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_test] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[test] ON
INSERT [dbo].[test] ([id], [Name], [Description], [is_active]) VALUES (1, N'HIV', N'Test for HIV', 1)
INSERT [dbo].[test] ([id], [Name], [Description], [is_active]) VALUES (2, N'Hepatitis A', N'Test for Hepatitis A', 1)
INSERT [dbo].[test] ([id], [Name], [Description], [is_active]) VALUES (3, N'Hepatitis B', N'Test for Hepatitis B', 1)
INSERT [dbo].[test] ([id], [Name], [Description], [is_active]) VALUES (4, N'Amylase', N'Your doctor may request this test if you have symptoms of a pancreatic disorder, such as severe abdominal pain, fever, loss of appetite, or nausea.', 1)
INSERT [dbo].[test] ([id], [Name], [Description], [is_active]) VALUES (5, N'ANA', N'This test helps to diagnose lupus and to rule out certain other autoimmune diseases.', 1)
INSERT [dbo].[test] ([id], [Name], [Description], [is_active]) VALUES (6, N'AIC', N'Used to monitor a person’s diabetes and to aid in treatment decisions, this test is usually performed with the first diagnosis and then 2 to 4 times per year.', 1)
INSERT [dbo].[test] ([id], [Name], [Description], [is_active]) VALUES (7, N'CBC', N'Complete Blood Count. Determines general health and screens for disorders such as anemia or infections, as well as nutritional status and toxic substance exposure.', 1)
INSERT [dbo].[test] ([id], [Name], [Description], [is_active]) VALUES (8, N'Electrolytes', N'This test can be requested as part of routine exam, and when your doctor suspects an excess or deficit of electrolytes (sodium or potassium) or an acid-base imbalance.', 1)
INSERT [dbo].[test] ([id], [Name], [Description], [is_active]) VALUES (9, N'ESR', N'Sedimentation Rate. Your doctor may order this test to determine the cause of inflammation, or to help diagnose and follow the course of joint or muscle pain.', 1)
INSERT [dbo].[test] ([id], [Name], [Description], [is_active]) VALUES (10, N'Flu tests', N'Used to determine whether flu-like symptoms are due to influenza A or B, or to other causes. Testing may be done using a nasopharyngeal swab, nasal aspirate or wash, or a throat swab.', 1)
INSERT [dbo].[test] ([id], [Name], [Description], [is_active]) VALUES (11, N'Glucose', N'Used to identify blood glucose level, and to screen for, diagnose, and monitor diabetes, pre-diabetes, and hypoglycemia. If you are diabetic, glucose levels should be monitored up to several times a day.', 1)
INSERT [dbo].[test] ([id], [Name], [Description], [is_active]) VALUES (12, N'Lyme Disease', N'If you show symptoms of Lyme disease, your doctor may order this test to see if you have been exposed to the bacterium that causes Lyme disease.', 1)
SET IDENTITY_INSERT [dbo].[test] OFF
/****** Object:  Table [dbo].[person]    Script Date: 04/04/2015 16:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[person](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ssn] [varchar](11) NOT NULL,
	[fname] [varchar](255) NOT NULL,
	[minit] [varchar](1) NOT NULL,
	[lname] [varchar](255) NOT NULL,
	[birth_date] [date] NOT NULL,
	[is_male] [bit] NOT NULL,
	[street_address] [varchar](255) NOT NULL,
	[city] [varchar](255) NOT NULL,
	[state] [varchar](25) NOT NULL,
	[zip] [varchar](10) NOT NULL,
	[phone] [varchar](12) NOT NULL,
	[is_patient] [bit] NOT NULL,
	[is_nurse] [bit] NOT NULL,
	[is_admin] [bit] NOT NULL,
	[is_doctor] [bit] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_person] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_ssn] ON [dbo].[person] 
(
	[ssn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[person] ON
INSERT [dbo].[person] ([id], [ssn], [fname], [minit], [lname], [birth_date], [is_male], [street_address], [city], [state], [zip], [phone], [is_patient], [is_nurse], [is_admin], [is_doctor]) VALUES (1, N'999-99-9999', N'default', N'a', N'user', CAST(0x3AF90A00 AS Date), 1, N'''''', N'''''', N'''''', N'''''', N'''''', 0, 0, 1, 0)
SET IDENTITY_INSERT [dbo].[person] OFF
/****** Object:  Table [dbo].[visit]    Script Date: 04/04/2015 16:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[visit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date] [smalldatetime] NOT NULL,
	[patient_id] [int] NOT NULL,
	[nurse_id] [int] NOT NULL,
	[doctor_id] [int] NOT NULL,
	[blood_pressure] [varchar](45) NOT NULL,
	[temperature] [decimal](5, 1) NOT NULL,
	[pulse_rate] [int] NOT NULL,
	[symptoms] [text] NOT NULL,
	[initial_diagnosis] [text] NOT NULL,
	[final_diagnosis] [text] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_visit] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[user]    Script Date: 04/04/2015 16:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[person_id] [int] NOT NULL,
	[username] [varchar](45) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[user] ON
INSERT [dbo].[user] ([id], [person_id], [username], [password]) VALUES (1, 1, N'defaultuser', N'fee6405eae6be5fbaa182495101721d5dbd39e4ad15cd82d04954c0bb443b5dc')
SET IDENTITY_INSERT [dbo].[user] OFF
/****** Object:  Table [dbo].[orderedtest]    Script Date: 04/04/2015 16:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderedtest](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[visit_id] [int] NOT NULL,
	[test_id] [int] NOT NULL,
	[order_date] [smalldatetime] NOT NULL,
	[result_date] [smalldatetime] NULL,
	[result] [bit] NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_orderedtest] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_test_is_active]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[test] ADD  CONSTRAINT [DF_test_is_active]  DEFAULT ((1)) FOR [is_active]
GO
/****** Object:  Default [DF_person_minit]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[person] ADD  CONSTRAINT [DF_person_minit]  DEFAULT ('') FOR [minit]
GO
/****** Object:  Default [DF_person_is_male]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[person] ADD  CONSTRAINT [DF_person_is_male]  DEFAULT ((1)) FOR [is_male]
GO
/****** Object:  Default [DF_person_street_address]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[person] ADD  CONSTRAINT [DF_person_street_address]  DEFAULT ('') FOR [street_address]
GO
/****** Object:  Default [DF_person_city]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[person] ADD  CONSTRAINT [DF_person_city]  DEFAULT ('') FOR [city]
GO
/****** Object:  Default [DF_person_state]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[person] ADD  CONSTRAINT [DF_person_state]  DEFAULT ('') FOR [state]
GO
/****** Object:  Default [DF_person_zip]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[person] ADD  CONSTRAINT [DF_person_zip]  DEFAULT ('') FOR [zip]
GO
/****** Object:  Default [DF_person_phone]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[person] ADD  CONSTRAINT [DF_person_phone]  DEFAULT ('') FOR [phone]
GO
/****** Object:  Default [DF_person_is_patient]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[person] ADD  CONSTRAINT [DF_person_is_patient]  DEFAULT ((1)) FOR [is_patient]
GO
/****** Object:  Default [DF_person_is_nurse]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[person] ADD  CONSTRAINT [DF_person_is_nurse]  DEFAULT ((0)) FOR [is_nurse]
GO
/****** Object:  Default [DF_person_is_admin]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[person] ADD  CONSTRAINT [DF_person_is_admin]  DEFAULT ((0)) FOR [is_admin]
GO
/****** Object:  Default [DF_person_is_doctor]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[person] ADD  CONSTRAINT [DF_person_is_doctor]  DEFAULT ((0)) FOR [is_doctor]
GO
/****** Object:  Default [DF_visit_date]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[visit] ADD  CONSTRAINT [DF_visit_date]  DEFAULT (getdate()) FOR [date]
GO
/****** Object:  Default [DF_visit_blood_pressure]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[visit] ADD  CONSTRAINT [DF_visit_blood_pressure]  DEFAULT ((120)/(80)) FOR [blood_pressure]
GO
/****** Object:  Default [DF_visit_temperature]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[visit] ADD  CONSTRAINT [DF_visit_temperature]  DEFAULT ((98.6)) FOR [temperature]
GO
/****** Object:  Default [DF_visit_pulse_rate]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[visit] ADD  CONSTRAINT [DF_visit_pulse_rate]  DEFAULT ((90)) FOR [pulse_rate]
GO
/****** Object:  Default [DF_visit_symptoms]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[visit] ADD  CONSTRAINT [DF_visit_symptoms]  DEFAULT ('') FOR [symptoms]
GO
/****** Object:  Default [DF_visit_initial_diagnosis]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[visit] ADD  CONSTRAINT [DF_visit_initial_diagnosis]  DEFAULT ('') FOR [initial_diagnosis]
GO
/****** Object:  Default [DF_visit_final_diagnosis]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[visit] ADD  CONSTRAINT [DF_visit_final_diagnosis]  DEFAULT ('') FOR [final_diagnosis]
GO
/****** Object:  Default [DF_orderedtest_order_date]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[orderedtest] ADD  CONSTRAINT [DF_orderedtest_order_date]  DEFAULT (getdate()) FOR [order_date]
GO
/****** Object:  ForeignKey [FK_visit_dr]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[visit]  WITH CHECK ADD  CONSTRAINT [FK_visit_dr] FOREIGN KEY([doctor_id])
REFERENCES [dbo].[person] ([id])
GO
ALTER TABLE [dbo].[visit] CHECK CONSTRAINT [FK_visit_dr]
GO
/****** Object:  ForeignKey [FK_visit_nurse]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[visit]  WITH CHECK ADD  CONSTRAINT [FK_visit_nurse] FOREIGN KEY([nurse_id])
REFERENCES [dbo].[person] ([id])
GO
ALTER TABLE [dbo].[visit] CHECK CONSTRAINT [FK_visit_nurse]
GO
/****** Object:  ForeignKey [FK_visit_paitent]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[visit]  WITH CHECK ADD  CONSTRAINT [FK_visit_paitent] FOREIGN KEY([patient_id])
REFERENCES [dbo].[person] ([id])
GO
ALTER TABLE [dbo].[visit] CHECK CONSTRAINT [FK_visit_paitent]
GO
/****** Object:  ForeignKey [FK_user_person]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [FK_user_person] FOREIGN KEY([person_id])
REFERENCES [dbo].[person] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [FK_user_person]
GO
/****** Object:  ForeignKey [FK_orderedtest_test]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[orderedtest]  WITH CHECK ADD  CONSTRAINT [FK_orderedtest_test] FOREIGN KEY([test_id])
REFERENCES [dbo].[test] ([id])
GO
ALTER TABLE [dbo].[orderedtest] CHECK CONSTRAINT [FK_orderedtest_test]
GO
/****** Object:  ForeignKey [FK_orderedtest_visit]    Script Date: 04/04/2015 16:14:55 ******/
ALTER TABLE [dbo].[orderedtest]  WITH CHECK ADD  CONSTRAINT [FK_orderedtest_visit] FOREIGN KEY([visit_id])
REFERENCES [dbo].[visit] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[orderedtest] CHECK CONSTRAINT [FK_orderedtest_visit]
GO
