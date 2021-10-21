/*
This table is not related to the programming section. You do not need to consider that section when reviewing this section.
Below is a table meant to store insurance account information. 
Please do a code review for this schema and come prepared to talk about what changes you would make to this table for optimization, normalization, and consistency.
*/

CREATE TABLE [dbo].[InsuranceAccounts](
	[Id] [nvarchar](10) NOT NULL,
	[AccountOwnerFirstName] [nvarchar](75) NOT NULL,
	[AccountOwnerLastName] [nvarchar](75) NOT NULL,
	[AccountOwnerBirthDay] [nchar(8)] NOT NULL,
	[AccountOwnerAddress] [nvarchar(250)] NOT NULL,
	[AccountOwnerCity] [nvarchar(250)] NOT NULL,
	[AccountOwnerZip] [nvarchar(250)] NOT NULL,	
	[HasHomeInsurance] [bit] NOT NULL,
	[homeInsuranceAccountId] [nvarchar](10) NOT NULL,
	[homeInsurancePremium] [decimal](18, 2) NOT NULL,
	[homeInsuranceDeductible] [decimal](18, 2) NOT NULL,
	[homeInsuranceCoverageStartDate] [datetime] NOT NULL,
	[homeInsuranceCoverageEndDate] [datetime] NOT NULL,	
	[HasAutoInsurance] [bit] NOT NULL,
	[Autoinsurance_AccountId] [nvarchar](10) NOT NULL,
	[Autoinsurance_Premium] [decimal](18, 2) NOT NULL,
	[Autoinsurance_CoverageAmount] [decimal](18, 2) NOT NULL,
	[Autoinsurance_CoverageStartDate] [datetime] NULL,
	[Autoinsurance_CoverageEndDate] [datetime] NULL,	
	[HasRentersInsurance] [bit] NOT NULL,
	[RentersInsurance-AccountId] [nvarchar](10) NOT NULL,
	[RentersInsurance-Premium] [decimal](18, 2) NOT NULL,
	[RentersInsurance-CoverageAmount] [decimal](18, 2) NOT NULL,
	[RentersInsurance-CoverageStartDate] [nvarchar](10) NULL,
	[RentersInsurance-CoverageEndDate] [nvarchar](10) NULL,
 CONSTRAINT [PK_InsuranceAccounts] PRIMARY KEY CLUSTERED 
([Id] ASC)
) ON [PRIMARY]
