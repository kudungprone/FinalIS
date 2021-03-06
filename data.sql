USE [IS]
GO
/****** Object:  Table [dbo].[QR]    Script Date: 11/17/2020 10:48:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QR](
	[Personid] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [varchar](255) NOT NULL,
	[FirstName] [varchar](255) NULL,
	[Age] [int] NULL,
	[Department] [varchar](255) NULL,
	[Hashid] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Personid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[QR] ON 

INSERT [dbo].[QR] ([Personid], [LastName], [FirstName], [Age], [Department], [Hashid]) VALUES (1, N'dung', N'dung', 40, N'IT', N'9d0a13e47e7e44e55b6e92db7872e823e2358c04f33f271025f022ec2942bfe8')
INSERT [dbo].[QR] ([Personid], [LastName], [FirstName], [Age], [Department], [Hashid]) VALUES (2, N'dung2', N'dung1', 40, N'IT1', N'02b85d4738301b0903af37d03d6bb30cc5af585dc34a912a0851f86248942a3d')
INSERT [dbo].[QR] ([Personid], [LastName], [FirstName], [Age], [Department], [Hashid]) VALUES (3, N'dung', N'dung', 21, N'IT', N'9d0a13e47e7e44e55b6e92db7872e823e2358c04f33f271025f022ec2942bfe8')
INSERT [dbo].[QR] ([Personid], [LastName], [FirstName], [Age], [Department], [Hashid]) VALUES (4, N'1', N'dung', 1, N'1', N'1a2f41aaf092a36bc339f961def719f15af512ba31187c0073ba87d70d144dc9')
INSERT [dbo].[QR] ([Personid], [LastName], [FirstName], [Age], [Department], [Hashid]) VALUES (5, N'dung', N'dung123', 21, N'IT', N'5bd9ccaa2f6b21c9f24273eb68fb1d201ff096bc03091908af6aa560c589a78e')
INSERT [dbo].[QR] ([Personid], [LastName], [FirstName], [Age], [Department], [Hashid]) VALUES (6, N'dung1', N'dung1233', 21, N'IT', N'92a8923a05921a8bd7da625413f0a6df0e1e87cc3cfe32c28f7138657c9dab62')
SET IDENTITY_INSERT [dbo].[QR] OFF
GO
