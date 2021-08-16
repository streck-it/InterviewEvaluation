/*
This table is not related to the programming section. You do not need to consider that section when reviewing this section.

Below is a table meant to store employee information. 
Please examine the table and come prepared to talk about what changes you would make to this table for optimization, normalization, and consistency.
Assumptions:
- All fields are required
*/

CREATE TABLE [dbo].[Consultants](
	[Id] [nvarchar](10) NOT NULL,
	[FirstName] [nvarchar](75) NOT NULL,
	[LastName] [nvarchar](75) NOT NULL,
	[Manager_FirstName] [nvarchar](50) NOT NULL,
	[Manager_LastName] [nvarchar](50) NOT NULL,
	[ContractPrice] [decimal](18, 2) NOT NULL,
	[ContractStartDate] [datetime] NULL,
	[ContractEndDate] [datetime] NULL,
	[Email] [nvarchar](50) NULL,
	[phone_number] [nchar](11) NULL,
	[jobTitleName] [nvarchar](10) NOT NULL,
	[jobTitleDescription] [nvarchar](10) NOT NULL,
	[departmentName] [nvarchar](50) NULL,
	[departmentDescription] [nvarchar](50) NULL,
	[departmentLocation] [nvarchar](50) NULL,
 CONSTRAINT [PK_Consultants] PRIMARY KEY CLUSTERED 
([Id] ASC)
) ON [PRIMARY]
