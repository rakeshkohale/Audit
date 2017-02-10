use BHADRAKALI

CREATE TABLE [dbo].[MsProfile](
    [ProfileID] [int] NOT NULL,
    [Profile] [nvarchar](20) NOT NULL,
    [Comment] [nvarchar](100) NULL,
 CONSTRAINT [PK_MsProfile] PRIMARY KEY CLUSTERED
(
    [ProfileID] ASC
 )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

 GO

-----------log write--------------

CREATE proc sp_writelog

@testid int = null,
@created_by int = null,
@records int = null,
@updated_date datetime = null

with exec as owner
 as
 begin
             Insert into kscs_test_audit(testid, created_by, records, updated_date) --Create logs
                values ((select distinct testid from excel_dump with(nolock)),
                        @created_by,
                        (select count(*) from excel_dump with(nolock)),
                        getdate())
                truncate table excel_dump
 end

------------------------Pooja Type--------------------

CREATE TABLE [dbo].[MsPoojaType](
    [PoojaTypeID] int identity(1,1) NOT NULL primary key,
    [PoojaTypeName] varchar(50) NULL,
	[Description] varchar(50)
 )
 GO

 Select * from [MsPoojaType]
 ---------------------------
 
 CREATE TABLE [dbo].[MsPoojaDetails](
    [PoojaID] int identity(1,1) NOT NULL,
	[PoojaTypeID] int NOT NULL FOREIGN KEY REFERENCES [MsPoojaType]([PoojaTypeID]),
    [PoojaName] varchar(50) NULL,
	[Rate] decimal(8,2),
	[Description] varchar(50)
 )
 GO

 select * from [MsPoojaDetails]
 ---------------------------------

CREATE TABLE [dbo].[MsOfferings](
    [ID] [int] identity(1,1) NOT NULL,
    [ReceiptNo] varchar(max) NOT NULL,
	[DonorName] varchar(50) NOT NULL,
    [PoojaName] varchar(50) NOT NULL,
    [ReceiptDate] datetime NOT NULL,
    [Payment] decimal(10,2) NOT NULL,
    [ModeOfPayment] varchar(20) NOT NULL,
    [DrawnBank] varchar(50) NULL,
	[Branch] varchar(50) NULL,
	[ChequeNo] varchar(50) NULL,
	[ChequeDate] varchar(50) NULL,
    [Remark] [nvarchar](100) NULL,
 )
 GO

----------------------
--table which logs the Update pooja details

CREATE TABLE [dbo].[PoojaDetailsUpdate](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [PoojaTypeID] int,
	[PoojaID] int,
	[PoojaName] varchar(50),
	[OldRate] decimal(8,2),
	[NewRate] decimal(8,2),
    [created_by] varchar(50) NULL,
    [updated_date] [datetime] NULL
) 
 GO

 -------------------

 CREATE TABLE [dbo].[mstUser](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](20) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[createddate] [datetime] NOT NULL,
	[createdBy] [varchar](20) NULL
	)

 -----------------
 
 

alter procedure GenerateReceiptNumber
@ReceiptNo varchar(100) OUTPUT
with exec as owner
As
SET NOCOUNT ON
begin

     Declare @maxdate as date
	 set @maxdate = (select max(receiptdate) from msofferings)
	 declare @currentmonthnumber as int = datepart(m, getdate())	 
	 if(datepart(m, @maxdate) = @currentmonthnumber)
     begin
	 
	 set @ReceiptNo = Convert(varchar(4), (SELECT year(getdate())))  --Gets Year
                            + '\' +
                      (SELECT FORMAT((GETDATE()),'MMM')) --gets Month Name
                            + '\' + Convert(varchar(max), (select count(*) from msOfferings)+1) --get serial number
	 end
	 else
	 begin
		set @ReceiptNo = Convert(varchar(4), (SELECT year(getdate())))  --Gets Year
                            + '\' +
                      (SELECT FORMAT((GETDATE()),'MMM')) --gets Month Name
                            + '\' + '1' --set serial number
        
	 end
	 select @ReceiptNo
end



--exec GenerateReceiptNumber

alter PROCEDURE [dbo].[sp_GetAllPoojaNames]       
--@poojatypeid int 
AS
set nocount on
BEGIN
      SELECT [PoojaID] as PoojaID
      ,[PoojaTypeID] as PoojaTypeID
      ,[PoojaName] as PoojaName
      ,[Rate] as Amount
  FROM [MsPoojaDetails]
  --where [PoojaTypeID] = @poojatypeid
END

----------------
alter PROCEDURE [dbo].[sp_GetPoojaType]       
AS
set nocount on
BEGIN
      SELECT [PoojaTypeID] as PoojaTypeID
      ,[PoojaTypeName] as PoojaType
     FROM [MsPoojatype]
END
----------------------