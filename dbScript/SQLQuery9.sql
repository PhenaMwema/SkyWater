USE [master]
GO
/****** Object:  Database [SkyWater]    Script Date: 08/13/2018 10:07:59 AM ******/
CREATE DATABASE [SkyWater] 
go

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SkyWater].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SkyWater] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SkyWater] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SkyWater] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SkyWater] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SkyWater] SET ARITHABORT OFF 
GO
ALTER DATABASE [SkyWater] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SkyWater] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SkyWater] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SkyWater] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SkyWater] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SkyWater] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SkyWater] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SkyWater] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SkyWater] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SkyWater] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SkyWater] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SkyWater] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SkyWater] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SkyWater] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SkyWater] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SkyWater] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SkyWater] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SkyWater] SET RECOVERY FULL 
GO
ALTER DATABASE [SkyWater] SET  MULTI_USER 
GO
ALTER DATABASE [SkyWater] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SkyWater] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SkyWater', N'ON'
GO
USE [SkyWater]
GO
/****** Object:  Schema [settings]    Script Date: 08/13/2018 10:07:59 AM ******/
CREATE SCHEMA [settings]
GO
/****** Object:  Table [dbo].[HH_baseline]    Script Date: 08/13/2018 10:07:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HH_baseline](
	[VID] [int] NULL,
	[HHID] [varchar](20) NOT NULL,
	[HHeadName] [varchar](70) NULL,
	[VisitNo] [varchar](20) NULL,
	[School_child] [int] NULL,
	[sleeprooms] [int] NULL,
	[rec_date] [date] NULL,
	[Officer] [varchar](20) NULL,
 CONSTRAINT [PK_HH_baseline] PRIMARY KEY CLUSTERED 
(
	[HHID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HH_Followup]    Script Date: 08/13/2018 10:07:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HH_Followup](
	[VID] [int] NOT NULL,
	[HHID] [nchar](20) NOT NULL,
	[h2o_obtain] [varchar](100) NULL,
	[h2o_obtain2] [varchar](100) NULL,
	[cont_see] [varchar](100) NULL,
	[cont_observe] [varchar](100) NULL,
	[cont_type] [varchar](100) NULL,
	[cont_covered] [varchar](100) NULL,
	[d_pour] [varchar](100) NULL,
	[d_scoopcup] [varchar](100) NULL,
	[d_scoopladle] [varchar](100) NULL,
	[d_empty] [varchar](100) NULL,
	[store_dur] [varchar](100) NULL,
	[h2o_treat] [varchar](100) NULL,
	[method_treat] [varchar](100) NULL,
	[treat_otherchem] [varchar](100) NULL,
	[treat_othermthd] [varchar](100) NULL,
	[cl_aqua] [varchar](100) NULL,
	[Cl_certeza] [varchar](100) NULL,
	[Cl_na] [varchar](100) NULL,
	[Cl_waterguard] [varchar](100) NULL,
	[Cl_watermaker] [varchar](100) NULL,
	[Cl_unk] [varchar](100) NULL,
	[Cl_other] [varchar](100) NULL,
	[Cl_PG] [varchar](100) NULL,
	[p_handwash] [varchar](100) NULL,
	[p_pipewater] [varchar](100) NULL,
	[P_nopipe_notap] [varchar](100) NULL,
	[p_nopipe_tap] [varchar](100) NULL,
	[p_basin] [varchar](100) NULL,
	[p_soap] [varchar](100) NULL,
	[p_amc] [varchar](100) NULL,
	[main_defeac] [varchar](100) NULL,
	[defeac_other] [varchar](100) NULL,
	[toilet_type] [varchar](100) NULL,
	[toilet_othertype] [varchar](100) NULL,
	[slab_material] [varchar](100) NULL,
	[door] [varchar](100) NULL,
	[use_cost] [int] NULL,
	[use_timeunit] [varchar](100) NULL,
	[sharing] [int] NULL,
	[toilet_emptied] [varchar](100) NULL,
	[toilet_full] [varchar](100) NULL,
	[child_defeac] [varchar](100) NULL,
	[feac_dispose] [varchar](100) NULL,
	[feac_disposeOther] [varchar](100) NULL,
	[feac_observed] [varchar](100) NULL,
	[feac_elsewhere] [varchar](100) NULL,
	[rec_date] [date] NOT NULL,
	[Officer] [varchar](50) NOT NULL,
 CONSTRAINT [PK_HH_Followup] PRIMARY KEY CLUSTERED 
(
	[VID] ASC,
	[HHID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IND_Baseline]    Script Date: 08/13/2018 10:07:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IND_Baseline](
	[VID] [int] NULL,
	[DSS_ID] [varchar](20) NOT NULL,
	[Full_Names] [varchar](70) NOT NULL,
	[DOB] [date] NOT NULL,
	[Sex] [varchar](6) NOT NULL,
	[RelHH] [varchar](100) NOT NULL,
	[Education] [varchar](200) NULL,
	[Occupation] [varchar](200) NULL,
	[Breastfeeding] [varchar](10) NULL,
	[VisitCode] [int] NULL,
	[Officer] [varchar](20) NOT NULL,
	[rec_date] [date] NOT NULL,
 CONSTRAINT [PK_IND_Baseline] PRIMARY KEY CLUSTERED 
(
	[DSS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IND_Followup]    Script Date: 08/13/2018 10:07:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IND_Followup](
	[VID] [int] NOT NULL,
	[DSS_ID] [varchar](20) NOT NULL,
	[HHID] [varchar](20) NULL,
	[Names] [varchar](20) NULL,
	[Sick] [varchar](20) NULL,
	[Sick_Dur] [int] NULL,
	[LooseStool] [varchar](20) NULL,
	[OtherSymptoms] [varchar](200) NULL,
	[TreatmentPlace] [varchar](100) NULL,
	[Treatmentgiven] [varchar](200) NULL,
	[Refered] [varchar](20) NULL,
	[Comments] [varchar](200) NULL,
	[Officer] [nchar](10) NULL,
	[Rec_date] [nchar](10) NULL,
 CONSTRAINT [PK_IND_Followup] PRIMARY KEY CLUSTERED 
(
	[VID] ASC,
	[DSS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [settings].[groups]    Script Date: 08/13/2018 10:07:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [settings].[groups](
	[groupID] [int] NOT NULL,
	[group] [varchar](50) NOT NULL,
	[description] [varchar](150) NOT NULL,
	[date] [datetime] NOT NULL,
	[status] [varchar](3) NOT NULL,
	[officer] [varchar](15) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [settings].[rights]    Script Date: 08/13/2018 10:07:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [settings].[rights](
	[accessID] [int] NOT NULL,
	[groupID] [int] NOT NULL,
	[modID] [int] NOT NULL,
	[access] [varchar](3) NOT NULL,
	[date] [datetime] NOT NULL,
	[status] [varchar](3) NOT NULL,
	[officer] [varchar](15) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [settings].[users]    Script Date: 08/13/2018 10:07:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [settings].[users](
	[userID] [int] NOT NULL,
	[groupID] [int] NOT NULL,
	[fname] [varchar](50) NOT NULL,
	[onames] [varchar](50) NOT NULL,
	[code] [varchar](2) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[logged] [int] NOT NULL,
	[email] [varchar](100) NOT NULL,
	[destination] [varchar](50) NULL,
	[date] [datetime] NOT NULL,
	[status] [varchar](3) NOT NULL,
	[officer] [varchar](15) NOT NULL,
	[DATEE] [datetime] NULL,
	[rReceive] [varchar](15) NULL,
	[rPrint] [varchar](15) NULL,
	[rQC] [varchar](15) NULL,
	[rDirector] [varchar](15) NULL,
	[rEnterResults] [varchar](15) NULL,
	[rDeleteOwn] [varchar](15) NULL,
	[rDeleteOther] [varchar](15) NULL,
	[rDownloadData] [varchar](15) NULL,
	[rSearch] [varchar](15) NULL,
	[rImportData] [varchar](15) NULL,
	[LastSuccessfulLogin] [date] NULL,
	[UserStatus] [nvarchar](9) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HH_baseline] ADD  CONSTRAINT [DF_baseline_HH_rec_date]  DEFAULT (getdate()) FOR [rec_date]
GO
ALTER TABLE [dbo].[HH_Followup] ADD  CONSTRAINT [DF_HH_Followups_rec_date]  DEFAULT (getdate()) FOR [rec_date]
GO
ALTER TABLE [dbo].[IND_Baseline] ADD  CONSTRAINT [DF_IND_Baseline_rec_date]  DEFAULT (getdate()) FOR [rec_date]
GO
/****** Object:  StoredProcedure [dbo].[HHBaseline]    Script Date: 08/13/2018 10:07:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =======================================================
-- Author:nagumba
-- Create date: 01/07/2018
-- Description:  INSERT/UPDATE [dbo].[HHBaseline]
-- ========================================================

CREATE PROCEDURE [dbo].[HHBaseline] -- paremeters to be passed
@VID AS int,
@HHID AS varchar(100),
@HHeadName AS varchar(100),
@VisitNo AS varchar(100),
@School_child AS int,
@sleeprooms AS int,
@rec_date AS varchar(100),
@Officer AS varchar(100),
@type tinyint
AS
BEGIN
  SET NOCOUNT ON; -- type options 1- insert,2-update
  IF (@type = 1)
  BEGIN -- start database insert code here

    INSERT INTO SkyWater.dbo.HH_baseline (VID, HHID, HHeadName, VisitNo, School_child, sleeprooms, Officer)
      VALUES (@VID, @HHID, @HHeadName, @VisitNo, @School_child, @sleeprooms, @Officer)
  END
  ELSE
  IF (@type = 2)
  BEGIN -- begin the update code based on rec_num

    UPDATE SkyWater.dbo.HH_baseline
    SET VID = @VID,
        HHID = @HHID,
        HHeadName = @HHeadName,
        VisitNo = @VisitNo,
        School_child = @School_child,
        sleeprooms = @sleeprooms,
        Officer = @Officer
    WHERE HHID = @HHID
  END
  ELSE
  IF (@type = 9999)
  BEGIN
    DELETE FROM SkyWater.dbo.HH_baseline
    WHERE HHID = @HHID
  END
  ELSE
  BEGIN -- report on error
    RAISERROR ('Invalid action choice -SkyWater  Baseline)!', 10, 1)
  END -- return select @@IDENTITY
END
GO
/****** Object:  StoredProcedure [dbo].[HHFollowup]    Script Date: 08/13/2018 10:07:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =======================================================
-- Author:nagumba
-- Create date: 22/04/2011
-- Description:	INSERT/UPDATE [seetings].[vitalsigns]
-- ========================================================

CREATE PROCEDURE [dbo].[HHFollowup] -- paremeters to be passed
@VID AS int,
@HHID AS varchar(100),
@h2o_obtain AS varchar(100),
@h2o_obtain2 AS varchar(100),
@cont_see AS varchar(100),
@cont_observe AS varchar(100),
@cont_type AS varchar(100),
@cont_covered AS varchar(100),
@d_pour AS varchar(100),
@d_scoopcup AS varchar(100),
@d_scoopladle AS varchar(100),
@d_empty AS varchar(100),
@store_dur AS varchar(100),
@h2o_treat AS varchar(100),
@method_treat AS varchar(100),
@treat_otherchem AS varchar(100),
@treat_othermthd AS varchar(100),
@cl_aqua AS varchar(100),
@Cl_certeza AS varchar(100),
@Cl_na AS varchar(100),
@Cl_waterguard AS varchar(100),
@Cl_watermaker AS varchar(100),
@Cl_unk AS varchar(100),
@Cl_other AS varchar(100),
@Cl_PG AS varchar(100),
@p_handwash AS varchar(100),
@p_pipewater AS varchar(100),
@P_nopipe_notap AS varchar(100),
@p_nopipe_tap AS varchar(100),
@p_basin AS varchar(100),
@p_soap AS varchar(100),
@p_amc AS varchar(100),
@main_defeac AS varchar(100),
@defeac_other AS varchar(100),
@toilet_type AS varchar(100),
@toilet_othertype AS varchar(100),
@slab_material AS varchar(100),
@door AS varchar(100),
@use_cost AS varchar(100),
@use_timeunit AS varchar(100),
@sharing AS varchar(100),
@toilet_emptied AS varchar(100),
@toilet_full AS varchar(100),
@child_defeac AS varchar(100),
@feac_dispose AS varchar(100),
@feac_disposeOther AS varchar(100),
@feac_observed AS varchar(100),
@feac_elsewhere AS varchar(100),
@rec_date AS varchar(100),
@Officer AS varchar(100),
@type tinyint
AS
BEGIN
  SET NOCOUNT ON; -- type options 1- insert,2-update
  IF (@type = 1)
  BEGIN -- start database insert code here

    INSERT INTO SkyWater.dbo.HH_Followup (VID, HHID, h2o_obtain, h2o_obtain2, cont_see, cont_observe, cont_type, cont_covered, d_pour, d_scoopcup, d_scoopladle, d_empty, store_dur, h2o_treat, method_treat, treat_otherchem, treat_othermthd, cl_aqua, Cl_certeza, Cl_na, Cl_waterguard, Cl_watermaker, Cl_unk, Cl_other, Cl_PG, p_handwash, p_pipewater, P_nopipe_notap, p_nopipe_tap, p_basin, p_soap, p_amc, main_defeac, defeac_other, toilet_type, toilet_othertype, slab_material, door, use_cost, use_timeunit, sharing, toilet_emptied, toilet_full, child_defeac, feac_dispose, feac_disposeOther, feac_observed, feac_elsewhere, rec_date, Officer)
      VALUES (@VID, @HHID, @h2o_obtain, @h2o_obtain2, @cont_see, @cont_observe, @cont_type, @cont_covered, @d_pour, @d_scoopcup, @d_scoopladle, @d_empty, @store_dur, @h2o_treat, @method_treat, @treat_otherchem, @treat_othermthd, @cl_aqua, @Cl_certeza, @Cl_na, @Cl_waterguard, @Cl_watermaker, @Cl_unk, @Cl_other, @Cl_PG, @p_handwash, @p_pipewater, @P_nopipe_notap, @p_nopipe_tap, @p_basin, @p_soap, @p_amc, @main_defeac, @defeac_other, @toilet_type, @toilet_othertype, @slab_material, @door, @use_cost, @use_timeunit, @sharing, @toilet_emptied, @toilet_full, @child_defeac, @feac_dispose, @feac_disposeOther, @feac_observed, @feac_elsewhere, @rec_date, @Officer)
  END
  ELSE
  IF (@type = 2)
  BEGIN -- begin the update code based on rec_num

    UPDATE SkyWater.dbo.HH_Followup
    SET VID = @VID,
        HHID = @HHID,
        h2o_obtain = @h2o_obtain,
        h2o_obtain2 = @h2o_obtain2,
        cont_see = @cont_see,
        cont_observe = @cont_observe,
        cont_type = @cont_type,
        cont_covered = @cont_covered,
        d_pour = @d_pour,
        d_scoopcup = @d_scoopcup,
        d_scoopladle = @d_scoopladle,
        d_empty = @d_empty,
        store_dur = @store_dur,
        h2o_treat = @h2o_treat,
        method_treat = @method_treat,
        treat_otherchem = @treat_otherchem,
        treat_othermthd = @treat_othermthd,
        cl_aqua = @cl_aqua,
        Cl_certeza = @Cl_certeza,
        Cl_na = @Cl_na,
        Cl_waterguard = @Cl_waterguard,
        Cl_watermaker = @Cl_watermaker,
        Cl_unk = @Cl_unk,
        Cl_other = @Cl_other,
        Cl_PG = @Cl_PG,
        p_handwash = @p_handwash,
        p_pipewater = @p_pipewater,
        P_nopipe_notap = @P_nopipe_notap,
        p_nopipe_tap = @p_nopipe_tap,
        p_basin = @p_basin,
        p_soap = @p_soap,
        p_amc = @p_amc,
        main_defeac = @main_defeac,
        defeac_other = @defeac_other,
        toilet_type = @toilet_type,
        toilet_othertype = @toilet_othertype,
        slab_material = @slab_material,
        door = @door,
        use_cost = @use_cost,
        use_timeunit = @use_timeunit,
        sharing = @sharing,
        toilet_emptied = @toilet_emptied,
        toilet_full = @toilet_full,
        child_defeac = @child_defeac,
        feac_dispose = @feac_dispose,
        feac_disposeOther = @feac_disposeOther,
        feac_observed = @feac_observed,
        feac_elsewhere = @feac_elsewhere,
        Officer = @Officer
    WHERE HHID = @HHID
    AND VID = @VID
  END
  ELSE
  IF (@type = 9999)
  BEGIN
    DELETE FROM SkyWater.dbo.HH_baseline
    WHERE HHID = @HHID
      AND VID = @VID
  END
  ELSE
  BEGIN -- report on error
    RAISERROR ('Invalid action choice -SkyWater  FollowUp)!', 10, 1)
  END -- return select @@IDENTITY
END
GO
/****** Object:  StoredProcedure [dbo].[manage_indBaseline]    Script Date: 08/13/2018 10:07:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- ========================================================
-- Author:nagumba
-- Create date: 07/08/2018
-- Description:	INSERT/UPDATE [dbo].[manage_indBaseline]
-- ========================================================

CREATE PROCEDURE [dbo].[manage_indBaseline] -- paremeters to be passed
@VID AS int,
@DSS_ID AS varchar(100),
@Full_Names AS varchar(100),
@DOB AS varchar(100),
@Sex AS varchar(100),
@RelHH AS varchar(100),
@Education AS varchar(100),
@Occupation AS varchar(100),
@Breastfeeding AS varchar(100),
@VisitCode AS varchar(100),
@Officer AS varchar(100),
@type tinyint
AS
BEGIN
  SET NOCOUNT ON; -- type options 1- insert,2-update
  IF (@type = 1)
  BEGIN -- start database insert code here

    INSERT INTO SkyWater.dbo.IND_Baseline 
	(VID, DSS_ID, Full_Names, DOB, Sex, RelHH, Education, Occupation, Breastfeeding, VisitCode, Officer)
      VALUES 
	(@VID, @DSS_ID, @Full_Names, @DOB, @Sex, @RelHH, @Education, @Occupation, @Breastfeeding, @VisitCode, @Officer)
  END
  ELSE
  IF (@type = 2)
  BEGIN -- begin the update code based on rec_num

    UPDATE SkyWater.dbo.IND_Baseline
		SET DSS_ID = @DSS_ID,
			Full_Names = @Full_Names,
			DOB = @DOB,
			Sex = @Sex,
			RelHH = @RelHH,
			Education = @Education,
			Occupation = @Occupation,
			Breastfeeding = @Breastfeeding,
			VisitCode = @VisitCode,
			Officer = @Officer
    WHERE	VID = @VID
  END
  ELSE
  IF (@type = 9999)
  BEGIN
    DELETE FROM SkyWater.dbo.IND_Baseline
    WHERE VID = @VID
  END
  ELSE
  BEGIN -- report on error
    RAISERROR ('Invalid action choice -SkyWater  Individual Follow up)!', 10, 1)
  END -- return select @@IDENTITY
END
GO
/****** Object:  StoredProcedure [dbo].[manage_indFollowUp]    Script Date: 08/13/2018 10:07:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- ========================================================
-- Author:nagumba
-- Create date: 07/08/2018
-- Description:	INSERT/UPDATE indFollowUp
-- ========================================================

CREATE PROCEDURE [dbo].[manage_indFollowUp] -- paremeters to be passed
@VID AS int,
@DSS_ID AS varchar(100),
@HHID AS varchar(100),
@Names AS varchar(100),
@Sick AS varchar(100),
@Sick_Dur AS varchar(100),
@LooseStool AS varchar(100),
@OtherSymptoms AS varchar(100),
@TreatmentPlace AS varchar(100),
@Treatmentgiven AS varchar(100),
@Refered AS varchar(100),
@Comments AS varchar(100),
@Officer AS varchar(100),
@type AS tinyint
AS
BEGIN
  SET NOCOUNT ON; -- type options 1- insert,2-update
  IF (@type = 1)
  BEGIN -- start database insert code here

    INSERT INTO SkyWater.dbo.IND_Followup (VID, DSS_ID, HHID, NAMES, Sick, Sick_Dur, LooseStool, OtherSymptoms, TreatmentPlace, Treatmentgiven, Refered, Comments, Officer)
      VALUES (@VID, @DSS_ID, @HHID, @Names, @Sick, @Sick_Dur, @LooseStool, @OtherSymptoms, @TreatmentPlace, @Treatmentgiven, @Refered, @Comments, @Officer)
  END
  ELSE
  IF (@type = 2)
  BEGIN -- begin the update code based on rec_num

    UPDATE SkyWater.dbo.IND_Followup
    SET Sick = @Sick,
        Sick_Dur = @Sick_Dur,
        LooseStool = @LooseStool,
        OtherSymptoms = @OtherSymptoms,
        TreatmentPlace = @TreatmentPlace,
        Treatmentgiven = @Treatmentgiven,
        Refered = @Refered,
        Comments = @Comments,
        Officer = @Officer
    WHERE VID = @VID
    AND DSS_ID = @DSS_ID
  END
  ELSE
  IF (@type = 9999)
  BEGIN
    DELETE FROM SkyWater.dbo.IND_Followup
    WHERE VID = @VID
      AND DSS_ID = @DSS_ID
  END
  ELSE
  BEGIN -- report on error
    RAISERROR ('Invalid action choice -SkyWater  Individual Follow up)!', 10, 1)
  END -- return select @@IDENTITY
END
GO
/****** Object:  StoredProcedure [settings].[manageUsers]    Script Date: 08/13/2018 10:07:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =======================================================
-- Author:sosewe
-- Create date: 22/04/2011
-- Description:	INSERT/UPDATE [seetings].[users]
-- ========================================================

create PROCEDURE [settings].[manageUsers]

   -- paremeters to be passed
    @userID INT ,
    @groupID INT ,
    @fname VARCHAR(50) ,
    @onames VARCHAR(50) ,
    @code VARCHAR(2) ,
    @username VARCHAR(50) ,
    @password VARCHAR(50) ,
    @logged INT ,
    @email NVARCHAR(100) ,
    @date DATETIME ,
    @status VARCHAR(3) ,
    @officer VARCHAR(15) ,
    @type TINYINT
AS
    BEGIN

        SET NOCOUNT ON;
    
    -- type options 1- insert,2-update
    
        IF ( @type = 1 )
            BEGIN
     -- start database insert code here
                INSERT  INTO eLab.[settings].[users]
                        ( [groupID] ,
                          [fname] ,
                          [onames] ,
                          [code] ,
                          [username] ,
                          [password] ,
                          [logged] ,
                          [email] ,
                          [date] ,
                          [status] ,
                          [officer]
                        )
                VALUES  ( @groupID ,
                          @fname ,
                          @onames ,
                          @code ,
                          @username ,
                          @password ,
                          @logged ,
                          @email ,
                          @date ,
                          @status ,
                          @officer
                        )
            END
     
        ELSE
            IF ( @type = 2 )
                BEGIN
         -- begin the update code based on rec_num
                    UPDATE  eLab.[settings].[users]
                    SET     [groupID] = @groupID ,
                            [fname] = @fname ,
                            [onames] = @onames ,
                            [code] = @code ,
                            [username] = @username ,
                            [email] = @email
                    WHERE   userID = @userID
                            AND officer = @officer
                END
            ELSE
                IF ( @type = 3 )
                    BEGIN
                        DELETE  FROM eLab.[settings].[users]
                        WHERE   userID = @userID
                    END
                ELSE
                    BEGIN
         -- report on error
                        RAISERROR('Invalid action choice - users(PCS)!',10,1)
                    END
      --return select @@IDENTITY 
      
    END







GO
USE [master]
GO
ALTER DATABASE [SkyWater] SET  READ_WRITE 
GO
