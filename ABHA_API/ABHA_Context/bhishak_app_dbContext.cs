using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class bhishak_app_dbContext : DbContext
    {
        public bhishak_app_dbContext()
        {
        }

        public bhishak_app_dbContext(DbContextOptions<bhishak_app_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbhaHealthidDetail> AbhaHealthidDetails { get; set; }
        public virtual DbSet<Checkingsp> Checkingsps { get; set; }
        public virtual DbSet<Mytb> Mytbs { get; set; }
        public virtual DbSet<TblAccount> TblAccounts { get; set; }
        public virtual DbSet<TblAdmAccountStatus> TblAdmAccountStatuses { get; set; }
        public virtual DbSet<TblAdmAccountType> TblAdmAccountTypes { get; set; }
        public virtual DbSet<TblAdmAdmissionStatus> TblAdmAdmissionStatuses { get; set; }
        public virtual DbSet<TblAdmAppointmentStatus> TblAdmAppointmentStatuses { get; set; }
        public virtual DbSet<TblAdmAppointmentType> TblAdmAppointmentTypes { get; set; }
        public virtual DbSet<TblAdmAppointmentTypeCategory> TblAdmAppointmentTypeCategories { get; set; }
        public virtual DbSet<TblAdmArea> TblAdmAreas { get; set; }
        public virtual DbSet<TblAdmCasualityShiftedType> TblAdmCasualityShiftedTypes { get; set; }
        public virtual DbSet<TblAdmChargeGroup> TblAdmChargeGroups { get; set; }
        public virtual DbSet<TblAdmChargeItem> TblAdmChargeItems { get; set; }
        public virtual DbSet<TblAdmChargeType> TblAdmChargeTypes { get; set; }
        public virtual DbSet<TblAdmCompany> TblAdmCompanies { get; set; }
        public virtual DbSet<TblAdmConsultationChargeGroup> TblAdmConsultationChargeGroups { get; set; }
        public virtual DbSet<TblAdmConsultationType> TblAdmConsultationTypes { get; set; }
        public virtual DbSet<TblAdmDepartment> TblAdmDepartments { get; set; }
        public virtual DbSet<TblAdmDistrict> TblAdmDistricts { get; set; }
        public virtual DbSet<TblAdmEmployeeDepartment> TblAdmEmployeeDepartments { get; set; }
        public virtual DbSet<TblAdmEmployeeDesignation> TblAdmEmployeeDesignations { get; set; }
        public virtual DbSet<TblAdmEmployeeType> TblAdmEmployeeTypes { get; set; }
        public virtual DbSet<TblAdmFacility> TblAdmFacilities { get; set; }
        public virtual DbSet<TblAdmFacilityType> TblAdmFacilityTypes { get; set; }
        public virtual DbSet<TblAdmGender> TblAdmGenders { get; set; }
        public virtual DbSet<TblAdmMaritalStatus> TblAdmMaritalStatuses { get; set; }
        public virtual DbSet<TblAdmNationality> TblAdmNationalities { get; set; }
        public virtual DbSet<TblAdmOccupationMaster> TblAdmOccupationMasters { get; set; }
        public virtual DbSet<TblAdmPatientBillType> TblAdmPatientBillTypes { get; set; }
        public virtual DbSet<TblAdmPatientRelation> TblAdmPatientRelations { get; set; }
        public virtual DbSet<TblAdmPatientStatus> TblAdmPatientStatuses { get; set; }
        public virtual DbSet<TblAdmProviderType> TblAdmProviderTypes { get; set; }
        public virtual DbSet<TblAdmReferralSource> TblAdmReferralSources { get; set; }
        public virtual DbSet<TblAdmReferralSourceName> TblAdmReferralSourceNames { get; set; }
        public virtual DbSet<TblAdmReligion> TblAdmReligions { get; set; }
        public virtual DbSet<TblAdmSpeciality> TblAdmSpecialities { get; set; }
        public virtual DbSet<TblAdmState> TblAdmStates { get; set; }
        public virtual DbSet<TblAdmStatus> TblAdmStatuses { get; set; }
        public virtual DbSet<TblAdmWmRoomType> TblAdmWmRoomTypes { get; set; }
        public virtual DbSet<TblComponentMapping> TblComponentMappings { get; set; }
        public virtual DbSet<TblCorporate> TblCorporates { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }
        public virtual DbSet<TblEncounter> TblEncounters { get; set; }
        public virtual DbSet<TblEncounterBillingEntry> TblEncounterBillingEntries { get; set; }
        public virtual DbSet<TblEncounterBillingEntryHistory> TblEncounterBillingEntryHistories { get; set; }
        public virtual DbSet<TblEncounterBillingPaymentsAgainstCahrgeItemLink> TblEncounterBillingPaymentsAgainstCahrgeItemLinks { get; set; }
        public virtual DbSet<TblFacility> TblFacilities { get; set; }
        public virtual DbSet<TblFacilityDepartment> TblFacilityDepartments { get; set; }
        public virtual DbSet<TblFacilityMapping> TblFacilityMappings { get; set; }
        public virtual DbSet<TblOrganization> TblOrganizations { get; set; }
        public virtual DbSet<TblPatient> TblPatients { get; set; }
        public virtual DbSet<TblPatientAppointment> TblPatientAppointments { get; set; }
        public virtual DbSet<TblPatientAppointmentSecuUserLink> TblPatientAppointmentSecuUserLinks { get; set; }
        public virtual DbSet<TblProvider> TblProviders { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblScheduleProvider> TblScheduleProviders { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblUserrole> TblUserroles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=10.10.20.25;Database=bhishak_app_db; User=root;Password=root@123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbhaHealthidDetail>(entity =>
            {
                entity.HasKey(e => e.HealthIdNumber)
                    .HasName("PRIMARY");

                entity.ToTable("abha_healthid_details");

                entity.Property(e => e.HealthIdNumber)
                    .HasMaxLength(25)
                    .HasColumnName("healthIdNumber");

                entity.Property(e => e.Address)
                    .HasMaxLength(4000)
                    .HasColumnName("address");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(100)
                    .HasColumnName("clientId");

                entity.Property(e => e.DistrictCode)
                    .HasMaxLength(11)
                    .HasColumnName("districtCode");

                entity.Property(e => e.Districtname)
                    .HasMaxLength(250)
                    .HasColumnName("districtname");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(250)
                    .HasColumnName("firstname");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.HealthId)
                    .HasMaxLength(250)
                    .HasColumnName("healthId");

                entity.Property(e => e.KycPhoto)
                    .HasColumnType("longtext")
                    .HasColumnName("kycPhoto");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(250)
                    .HasColumnName("lastname");

                entity.Property(e => e.Middlename)
                    .HasMaxLength(250)
                    .HasColumnName("middlename");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .HasColumnName("mobile");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");

                entity.Property(e => e.PatientId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("Patient_Id");

                entity.Property(e => e.PhrAddress)
                    .HasMaxLength(250)
                    .HasColumnName("phrAddress");

                entity.Property(e => e.ProfilePhoto)
                    .HasColumnType("longtext")
                    .HasColumnName("profilePhoto");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(11)
                    .HasColumnName("stateCode");

                entity.Property(e => e.Statename)
                    .HasMaxLength(250)
                    .HasColumnName("statename");

                entity.Property(e => e.SubDistrictCode)
                    .HasMaxLength(50)
                    .HasColumnName("subDistrictCode");

                entity.Property(e => e.SubdistrictName)
                    .HasMaxLength(250)
                    .HasColumnName("subdistrictName");

                entity.Property(e => e.TownCode)
                    .HasMaxLength(250)
                    .HasColumnName("townCode");

                entity.Property(e => e.TownName)
                    .HasMaxLength(250)
                    .HasColumnName("townName");

                entity.Property(e => e.VillageCode)
                    .HasMaxLength(50)
                    .HasColumnName("villageCode");

                entity.Property(e => e.VillageName)
                    .HasMaxLength(250)
                    .HasColumnName("villageName");
            });

            modelBuilder.Entity<Checkingsp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("checkingsp");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Mytb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mytb");

                entity.Property(e => e.Token)
                    .HasColumnType("longtext")
                    .HasColumnName("token");
            });

            modelBuilder.Entity<TblAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_account");

                entity.HasIndex(e => e.AccountStatusId, "ACCOUNT_STATUS_ID");

                entity.HasIndex(e => e.AccountTypeId, "ACCOUNT_TYPE_ID");

                entity.Property(e => e.AccountId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ACCOUNT_ID");

                entity.Property(e => e.AccountDescription)
                    .HasMaxLength(250)
                    .HasColumnName("ACCOUNT_DESCRIPTION");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .HasColumnName("ACCOUNT_NAME");

                entity.Property(e => e.AccountStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ACCOUNT_STATUS_ID");

                entity.Property(e => e.AccountTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ACCOUNT_TYPE_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.HasOne(d => d.AccountStatus)
                    .WithMany(p => p.TblAccounts)
                    .HasForeignKey(d => d.AccountStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_account_ibfk_1");

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.TblAccounts)
                    .HasForeignKey(d => d.AccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_account_ibfk_2");
            });

            modelBuilder.Entity<TblAdmAccountStatus>(entity =>
            {
                entity.HasKey(e => e.AccountStatusId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_account_status");

                entity.Property(e => e.AccountStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ACCOUNT_STATUS_ID");

                entity.Property(e => e.AccountStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ACCOUNT_STATUS");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");
            });

            modelBuilder.Entity<TblAdmAccountType>(entity =>
            {
                entity.HasKey(e => e.AccountTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_account_type");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.AccountTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ACCOUNT_TYPE_ID");

                entity.Property(e => e.AccountTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ACCOUNT_TYPE_NAME");

                entity.Property(e => e.ApAccount)
                    .HasColumnType("bit(1)")
                    .HasColumnName("AP_ACCOUNT");

                entity.Property(e => e.ArAccount)
                    .HasColumnType("bit(1)")
                    .HasColumnName("AR_ACCOUNT");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmAccountTypes)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_account_type_ibfk_1");
            });

            modelBuilder.Entity<TblAdmAdmissionStatus>(entity =>
            {
                entity.HasKey(e => e.AdmissionStatusId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_admission_status");

                entity.Property(e => e.AdmissionStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ADMISSION_STATUS_ID");

                entity.Property(e => e.AdmissionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("ADMISSION_STATUS");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");
            });

            modelBuilder.Entity<TblAdmAppointmentStatus>(entity =>
            {
                entity.HasKey(e => e.AppointmentStatusId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_appointment_status");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.AppointmentStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("APPOINTMENT_STATUS_ID");

                entity.Property(e => e.AppointmentStatus)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("APPOINTMENT_STATUS");

                entity.Property(e => e.AppointmentStatusCategory)
                    .HasMaxLength(50)
                    .HasColumnName("APPOINTMENT_STATUS_CATEGORY");

                entity.Property(e => e.AppointmentStatusColor)
                    .HasMaxLength(50)
                    .HasColumnName("APPOINTMENT_STATUS_COLOR");

                entity.Property(e => e.AppointmentStatusNotes)
                    .HasMaxLength(250)
                    .HasColumnName("APPOINTMENT_STATUS_NOTES");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmAppointmentStatuses)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_appointment_status_ibfk_1");
            });

            modelBuilder.Entity<TblAdmAppointmentType>(entity =>
            {
                entity.HasKey(e => e.AppointmentTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_appointment_type");

                entity.HasIndex(e => e.AppointmentTypeCategoryId, "APPOINTMENT_TYPE_CATEGORY_ID");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.AppointmentTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("APPOINTMENT_TYPE_ID");

                entity.Property(e => e.AppointmentDuration)
                    .HasColumnType("int(11)")
                    .HasColumnName("APPOINTMENT_DURATION");

                entity.Property(e => e.AppointmentType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("APPOINTMENT_TYPE");

                entity.Property(e => e.AppointmentTypeCategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("APPOINTMENT_TYPE_CATEGORY_ID");

                entity.Property(e => e.AppointmentTypeColor)
                    .HasMaxLength(100)
                    .HasColumnName("APPOINTMENT_TYPE_COLOR");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .HasColumnName("NOTES");

                entity.Property(e => e.ShowPopup)
                    .HasColumnType("bit(1)")
                    .HasColumnName("SHOW_POPUP");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.AppointmentTypeCategory)
                    .WithMany(p => p.TblAdmAppointmentTypes)
                    .HasForeignKey(d => d.AppointmentTypeCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_appointment_type_ibfk_1");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmAppointmentTypes)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_appointment_type_ibfk_2");
            });

            modelBuilder.Entity<TblAdmAppointmentTypeCategory>(entity =>
            {
                entity.HasKey(e => e.AppointmentTypeCategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_appointment_type_category");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.AppointmentTypeCategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("APPOINTMENT_TYPE_CATEGORY_ID");

                entity.Property(e => e.AppointmentTypeCategoryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("APPOINTMENT_TYPE_CATEGORY_NAME");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmAppointmentTypeCategories)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_appointment_type_category_ibfk_1");
            });

            modelBuilder.Entity<TblAdmArea>(entity =>
            {
                entity.HasKey(e => e.AreaId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_area");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.AreaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AREA_ID");

                entity.Property(e => e.AreaName)
                    .HasMaxLength(50)
                    .HasColumnName("AREA_NAME");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate).HasColumnName("CREATED_DATE");

                entity.Property(e => e.MaxDiscountAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("MAX_DISCOUNT_AMOUNT");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmAreas)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("tbl_adm_area_ibfk_1");
            });

            modelBuilder.Entity<TblAdmCasualityShiftedType>(entity =>
            {
                entity.HasKey(e => e.CasualityShiftedTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_casuality_shifted_type");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.CasualityShiftedTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CASUALITY_SHIFTED_TYPE_ID");

                entity.Property(e => e.CasualityShiftedType)
                    .HasMaxLength(50)
                    .HasColumnName("CASUALITY_SHIFTED_TYPE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmCasualityShiftedTypes)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_casuality_shifted_type_ibfk_1");
            });

            modelBuilder.Entity<TblAdmChargeGroup>(entity =>
            {
                entity.HasKey(e => e.ChargeGroupId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_charge_group");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.ChargeGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CHARGE_GROUP_ID");

                entity.Property(e => e.ChargeGroup)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("CHARGE_GROUP");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PARENT_ID");

                entity.Property(e => e.SequenceOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("SEQUENCE_ORDER");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmChargeGroups)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_charge_group_ibfk_1");
            });

            modelBuilder.Entity<TblAdmChargeItem>(entity =>
            {
                entity.HasKey(e => e.ChargeItemId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_charge_item");

                entity.Property(e => e.ChargeItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CHARGE_ITEM_ID");

                entity.Property(e => e.AnesthesianCharges)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("ANESTHESIAN_CHARGES");

                entity.Property(e => e.ChargeGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CHARGE_GROUP_ID");

                entity.Property(e => e.ChargeItem)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("CHARGE_ITEM");

                entity.Property(e => e.ChargeItemDisplayName)
                    .HasMaxLength(50)
                    .HasColumnName("CHARGE_ITEM_DISPLAY_NAME");

                entity.Property(e => e.ChargeTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CHARGE_TYPE_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.DoctorAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("DOCTOR_AMOUNT");

                entity.Property(e => e.FromAccountId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FROM_ACCOUNT_ID");

                entity.Property(e => e.InclusiveCharges)
                    .HasColumnType("bit(1)")
                    .HasColumnName("INCLUSIVE_CHARGES");

                entity.Property(e => e.InclusiveDiscounts)
                    .HasColumnType("bit(1)")
                    .HasColumnName("INCLUSIVE_DISCOUNTS");

                entity.Property(e => e.IsBillable)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_BILLABLE");

                entity.Property(e => e.IsBundle)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_BUNDLE");

                entity.Property(e => e.IsEditable)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_EDITABLE");

                entity.Property(e => e.IsFrequentlyUsedLab)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_FREQUENTLY_USED_LAB");

                entity.Property(e => e.IsLabBill)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_LAB_BILL");

                entity.Property(e => e.IsOpConsultation)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_OP_CONSULTATION");

                entity.Property(e => e.IsPayment)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_PAYMENT");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.NumberOfUnitsPerDay)
                    .HasColumnType("int(11)")
                    .HasColumnName("NUMBER_OF_UNITS_PER_DAY");

                entity.Property(e => e.RadiologyCharges)
                    .HasColumnType("decimal(18,0)")
                    .HasColumnName("RADIOLOGY_CHARGES");

                entity.Property(e => e.RefDoctorAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("REF_DOCTOR_AMOUNT");

                entity.Property(e => e.RefDoctorPercentage)
                    .HasColumnType("decimal(18,0)")
                    .HasColumnName("REF_DOCTOR_PERCENTAGE");

                entity.Property(e => e.RoomTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ROOM_TYPE_ID");

                entity.Property(e => e.ServiceDuration)
                    .HasColumnType("int(11)")
                    .HasColumnName("SERVICE_DURATION");

                entity.Property(e => e.ShortName)
                    .HasColumnType("longtext")
                    .HasColumnName("SHORT_NAME");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.Property(e => e.TaxPercentage)
                    .HasMaxLength(50)
                    .HasColumnName("TAX_PERCENTAGE");

                entity.Property(e => e.ToAccountId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TO_ACCOUNT_ID");

                entity.Property(e => e.UnitCost)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("UNIT_COST");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("UNIT_PRICE");
            });

            modelBuilder.Entity<TblAdmChargeType>(entity =>
            {
                entity.HasKey(e => e.ChargeTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_charge_type");

                entity.Property(e => e.ChargeTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CHARGE_TYPE_ID");

                entity.Property(e => e.ChargeType)
                    .HasMaxLength(250)
                    .HasColumnName("CHARGE_TYPE");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");
            });

            modelBuilder.Entity<TblAdmCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_company");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("COMPANY_ID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .HasColumnName("COMPANY_NAME");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmCompanies)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_company_ibfk_1");
            });

            modelBuilder.Entity<TblAdmConsultationChargeGroup>(entity =>
            {
                entity.HasKey(e => e.ConsultationChargeGroupId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_consultation_charge_group");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.ConsultationChargeGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CONSULTATION_CHARGE_GROUP_ID");

                entity.Property(e => e.ConsultationChargeGroup)
                    .HasMaxLength(50)
                    .HasColumnName("CONSULTATION_CHARGE_GROUP");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmConsultationChargeGroups)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("tbl_adm_consultation_charge_group_ibfk_1");
            });

            modelBuilder.Entity<TblAdmConsultationType>(entity =>
            {
                entity.HasKey(e => e.ConsultationTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_consultation_type");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.ConsultationTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CONSULTATION_TYPE_ID");

                entity.Property(e => e.ConsultationType)
                    .HasMaxLength(50)
                    .HasColumnName("CONSULTATION_TYPE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmConsultationTypes)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("tbl_adm_consultation_type_ibfk_1");
            });

            modelBuilder.Entity<TblAdmDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_department");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.DepartmentDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DEPARTMENT_DESCRIPTION");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .HasColumnName("NOTES");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmDepartments)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_department_ibfk_1");
            });

            modelBuilder.Entity<TblAdmDistrict>(entity =>
            {
                entity.ToTable("tbl_adm_districts");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnName("CREATED_DATE");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .HasColumnName("NAME");

                entity.Property(e => e.StateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATE_ID");

                entity.Property(e => e.UpdatedDate).HasColumnName("UPDATED_DATE");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<TblAdmEmployeeDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_employee_department");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT_NAME");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmEmployeeDepartments)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_employee_department_ibfk_1");
            });

            modelBuilder.Entity<TblAdmEmployeeDesignation>(entity =>
            {
                entity.HasKey(e => e.DesignationId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_employee_designation");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.DesignationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DESIGNATION_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("DESIGNATION");

                entity.Property(e => e.DesignationNotes)
                    .HasMaxLength(2000)
                    .HasColumnName("DESIGNATION_NOTES");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmEmployeeDesignations)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_employee_designation_ibfk_1");
            });

            modelBuilder.Entity<TblAdmEmployeeType>(entity =>
            {
                entity.HasKey(e => e.EmployeeTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_employee_type");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.EmployeeTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("EMPLOYEE_TYPE_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EmployeeType)
                    .HasMaxLength(50)
                    .HasColumnName("EMPLOYEE_TYPE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmEmployeeTypes)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_employee_type_ibfk_1");
            });

            modelBuilder.Entity<TblAdmFacility>(entity =>
            {
                entity.HasKey(e => e.FacilityId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_facility");

                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_ID");

                entity.Property(e => e.CreatedDate).HasColumnName("CREATED_DATE");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.FacilityName)
                    .HasMaxLength(200)
                    .HasColumnName("FACILITY_NAME");
            });

            modelBuilder.Entity<TblAdmFacilityType>(entity =>
            {
                entity.HasKey(e => e.FacilityTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_facility_type");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.FacilityTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_TYPE_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.FacilityType)
                    .HasMaxLength(250)
                    .HasColumnName("FACILITY_TYPE");

                entity.Property(e => e.FacilityTypeDescription)
                    .HasMaxLength(250)
                    .HasColumnName("FACILITY_TYPE_DESCRIPTION");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmFacilityTypes)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_facility_type_ibfk_1");
            });

            modelBuilder.Entity<TblAdmGender>(entity =>
            {
                entity.HasKey(e => e.GenderId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_gender");

                entity.Property(e => e.GenderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("GENDER_ID");

                entity.Property(e => e.CreationBy)
                    .HasMaxLength(200)
                    .HasColumnName("CREATION_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("GENDER");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");
            });

            modelBuilder.Entity<TblAdmMaritalStatus>(entity =>
            {
                entity.HasKey(e => e.MaritalStatusId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_marital_status");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.MaritalStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MARITAL_STATUS_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.MaritalStatusCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MARITAL_STATUS_CODE");

                entity.Property(e => e.MaritalStatusDesc)
                    .HasMaxLength(250)
                    .HasColumnName("MARITAL_STATUS_DESC");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmMaritalStatuses)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_marital_status_ibfk_1");
            });

            modelBuilder.Entity<TblAdmNationality>(entity =>
            {
                entity.HasKey(e => e.NationalityId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_nationality");

                entity.Property(e => e.NationalityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("NATIONALITY_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.NationalityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NATIONALITY_NAME");
            });

            modelBuilder.Entity<TblAdmOccupationMaster>(entity =>
            {
                entity.ToTable("tbl_adm_occupation_master");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("CREATED_DATE");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(100)
                    .HasColumnName("OCCUPATION");
            });

            modelBuilder.Entity<TblAdmPatientBillType>(entity =>
            {
                entity.HasKey(e => e.BillTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_patient_bill_type");

                entity.Property(e => e.BillTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("BILL_TYPE_ID");

                entity.Property(e => e.BillType)
                    .HasMaxLength(50)
                    .HasColumnName("BILL_TYPE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");
            });

            modelBuilder.Entity<TblAdmPatientRelation>(entity =>
            {
                entity.HasKey(e => e.RelationId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_patient_relation");

                entity.Property(e => e.RelationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RELATION_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Relation)
                    .HasMaxLength(250)
                    .HasColumnName("RELATION");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");
            });

            modelBuilder.Entity<TblAdmPatientStatus>(entity =>
            {
                entity.HasKey(e => e.PatientStatusId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_patient_status");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.PatientStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PATIENT_STATUS_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmPatientStatuses)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_patient_status_ibfk_1");
            });

            modelBuilder.Entity<TblAdmProviderType>(entity =>
            {
                entity.HasKey(e => e.ProviderTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_provider_type");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.ProviderTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PROVIDER_TYPE_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.ProviderType)
                    .HasMaxLength(50)
                    .HasColumnName("PROVIDER_TYPE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmProviderTypes)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_provider_type_ibfk_1");
            });

            modelBuilder.Entity<TblAdmReferralSource>(entity =>
            {
                entity.HasKey(e => e.ReferralSourceId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_referral_source");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.ReferralSourceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("REFERRAL_SOURCE_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.ReferralSourceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("REFERRAL_SOURCE_CODE");

                entity.Property(e => e.ReferralSourceDesc)
                    .HasMaxLength(100)
                    .HasColumnName("REFERRAL_SOURCE_DESC");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmReferralSources)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_referral_source_ibfk_1");
            });

            modelBuilder.Entity<TblAdmReferralSourceName>(entity =>
            {
                entity.HasKey(e => e.ReferralSourceNameId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_referral_source_name");

                entity.HasIndex(e => e.ReferralSourceId, "REFERRAL_SOURCE_ID");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.ReferralSourceNameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("REFERRAL_SOURCE_NAME_ID");

                entity.Property(e => e.Address)
                    .HasColumnType("longtext")
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.ReferralSourceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("REFERRAL_SOURCE_ID");

                entity.Property(e => e.ReferralSourceName)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("REFERRAL_SOURCE_NAME");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.ReferralSource)
                    .WithMany(p => p.TblAdmReferralSourceNames)
                    .HasForeignKey(d => d.ReferralSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_referral_source_name_ibfk_1");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmReferralSourceNames)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_referral_source_name_ibfk_2");
            });

            modelBuilder.Entity<TblAdmReligion>(entity =>
            {
                entity.HasKey(e => e.ReligionId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_religion");

                entity.Property(e => e.ReligionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RELIGION_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ReligionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("RELIGION_NAME");
            });

            modelBuilder.Entity<TblAdmSpeciality>(entity =>
            {
                entity.HasKey(e => e.SpecialityId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_speciality");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.SpecialityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SPECIALITY_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Speciality)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SPECIALITY");

                entity.Property(e => e.SpecialityDesc)
                    .HasMaxLength(250)
                    .HasColumnName("SPECIALITY_DESC");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmSpecialities)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_speciality_ibfk_1");
            });

            modelBuilder.Entity<TblAdmState>(entity =>
            {
                entity.ToTable("tbl_adm_states");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnName("CREATED_DATE");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .HasColumnName("NAME");

                entity.Property(e => e.UpdatedDate).HasColumnName("UPDATED_DATE");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<TblAdmStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_status");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<TblAdmWmRoomType>(entity =>
            {
                entity.HasKey(e => e.RoomTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_adm_wm_room_type");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.RoomTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ROOM_TYPE_ID");

                entity.Property(e => e.ConsultationChargeItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CONSULTATION_CHARGE_ITEM_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.RoomType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ROOM_TYPE");

                entity.Property(e => e.RoomTypeDescription)
                    .HasMaxLength(500)
                    .HasColumnName("ROOM_TYPE_DESCRIPTION");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblAdmWmRoomTypes)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_adm_wm_room_type_ibfk_1");
            });

            modelBuilder.Entity<TblComponentMapping>(entity =>
            {
                entity.HasKey(e => e.ComponentMappingId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_component_mapping");

                entity.Property(e => e.ComponentMappingId)
                    .HasColumnType("int(11)")
                    .HasColumnName("COMPONENT_MAPPING_ID");

                entity.Property(e => e.CreatedDate).HasColumnName("CREATED_DATE");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.MappingUrl)
                    .HasMaxLength(300)
                    .HasColumnName("MAPPING_URL");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Roleid)
                    .HasColumnType("int(11)")
                    .HasColumnName("ROLEID");
            });

            modelBuilder.Entity<TblCorporate>(entity =>
            {
                entity.HasKey(e => e.CorporateId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_corporate");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.CorporateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CORPORATE_ID");

                entity.Property(e => e.AllocationSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ALLOCATION_SET_ID");

                entity.Property(e => e.AppNoOfRegMonth)
                    .HasColumnType("int(11)")
                    .HasColumnName("app_no_of_reg_month");

                entity.Property(e => e.AutoReport)
                    .HasMaxLength(1)
                    .HasColumnName("auto_report")
                    .IsFixedLength(true);

                entity.Property(e => e.BankAccNo)
                    .HasMaxLength(15)
                    .HasColumnName("bank_acc_no");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(150)
                    .HasColumnName("billing_address");

                entity.Property(e => e.City)
                    .HasMaxLength(40)
                    .HasColumnName("city");

                entity.Property(e => e.CommPaymentType)
                    .HasMaxLength(1)
                    .HasColumnName("comm_payment_type")
                    .IsFixedLength(true);

                entity.Property(e => e.CommisionState)
                    .HasMaxLength(1)
                    .HasColumnName("commision_state")
                    .IsFixedLength(true);

                entity.Property(e => e.ContractDuration)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("contract_duration");

                entity.Property(e => e.ContractFrom).HasColumnName("contract_from");

                entity.Property(e => e.ContractTo).HasColumnName("contract_to");

                entity.Property(e => e.CorporateName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("CORPORATE_NAME");

                entity.Property(e => e.CorporateState)
                    .HasMaxLength(1)
                    .HasColumnName("corporate_state")
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.CreditLimit)
                    .HasColumnType("decimal(14,2)")
                    .HasColumnName("credit_limit");

                entity.Property(e => e.DiscountPer)
                    .HasColumnType("decimal(5,2)")
                    .HasColumnName("discount_per");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .HasColumnName("email_address");

                entity.Property(e => e.FederalTaxId)
                    .HasMaxLength(50)
                    .HasColumnName("FEDERAL_TAX_ID");

                entity.Property(e => e.FederalTaxIdType)
                    .HasColumnType("int(11)")
                    .HasColumnName("FEDERAL_TAX_ID_TYPE");

                entity.Property(e => e.FinancialClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FINANCIAL_CLASS_ID");

                entity.Property(e => e.GroupNumber)
                    .HasMaxLength(50)
                    .HasColumnName("GROUP_NUMBER");

                entity.Property(e => e.IncludeAllTestsForOrders)
                    .HasColumnType("bit(1)")
                    .HasColumnName("INCLUDE_ALL_TESTS_FOR_ORDERS");

                entity.Property(e => e.InsurBasicSalary)
                    .HasColumnType("decimal(18,0)")
                    .HasColumnName("INSUR_BASIC_SALARY");

                entity.Property(e => e.InsurEmpCode)
                    .HasMaxLength(200)
                    .HasColumnName("INSUR_EMP_CODE");

                entity.Property(e => e.InsurEmpName)
                    .HasMaxLength(200)
                    .HasColumnName("INSUR_EMP_NAME");

                entity.Property(e => e.InsurEmpRelation)
                    .HasMaxLength(200)
                    .HasColumnName("INSUR_EMP_RELATION");

                entity.Property(e => e.InsurRefEndDate).HasColumnName("INSUR_REF_END_DATE");

                entity.Property(e => e.InsurRefLetterDate).HasColumnName("INSUR_REF_LETTER_DATE");

                entity.Property(e => e.InsurRefLetterNo)
                    .HasMaxLength(200)
                    .HasColumnName("INSUR_REF_LETTER_NO");

                entity.Property(e => e.InsurRefStartDate).HasColumnName("INSUR_REF_START_DATE");

                entity.Property(e => e.InsuranceCarrierId)
                    .HasColumnType("int(11)")
                    .HasColumnName("INSURANCE_CARRIER_ID");

                entity.Property(e => e.IsCredit)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_CREDIT");

                entity.Property(e => e.IsFree)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_FREE");

                entity.Property(e => e.IsOverrideCorporate)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_OVERRIDE_CORPORATE");

                entity.Property(e => e.IsSmsRequired)
                    .HasMaxLength(1)
                    .HasColumnName("is_sms_required")
                    .IsFixedLength(true);

                entity.Property(e => e.ListName)
                    .HasMaxLength(250)
                    .HasColumnName("LIST_NAME");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.OtherDetails)
                    .HasMaxLength(200)
                    .HasColumnName("other_details");

                entity.Property(e => e.PaidAmount)
                    .HasColumnType("decimal(14,2)")
                    .HasColumnName("paid_amount");

                entity.Property(e => e.PayVisitwise)
                    .HasMaxLength(1)
                    .HasColumnName("pay_visitwise")
                    .IsFixedLength(true);

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("payment_date");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .HasColumnName("PAYMENT_MODE");

                entity.Property(e => e.PerCommision)
                    .HasColumnType("decimal(5,2)")
                    .HasColumnName("per_commision");

                entity.Property(e => e.PrepaidMinAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("PREPAID_MIN_AMOUNT");

                entity.Property(e => e.PricelistId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("pricelist_id");

                entity.Property(e => e.RegAmount)
                    .HasColumnType("decimal(14,2)")
                    .HasColumnName("reg_amount");

                entity.Property(e => e.ReportType)
                    .HasMaxLength(1)
                    .HasColumnName("report_type")
                    .IsFixedLength(true);

                entity.Property(e => e.SponsorName)
                    .HasMaxLength(200)
                    .HasColumnName("SPONSOR_NAME");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.Property(e => e.TypeOfContract)
                    .HasMaxLength(1)
                    .HasColumnName("type_of_contract")
                    .IsFixedLength(true);

                entity.Property(e => e.WebPassword)
                    .HasMaxLength(20)
                    .HasColumnName("web_password");

                entity.Property(e => e.WebUserid)
                    .HasMaxLength(20)
                    .HasColumnName("web_userid");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblCorporates)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("tbl_corporate_ibfk_1");
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_employee");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.DateOfBirth).HasColumnName("DATE_OF_BIRTH");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.DesignationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DESIGNATION_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EmployeeGroup)
                    .HasMaxLength(50)
                    .HasColumnName("EMPLOYEE_GROUP");

                entity.Property(e => e.EmployeeTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("EMPLOYEE_TYPE_ID");

                entity.Property(e => e.FacilityDepartmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_DEPARTMENT_ID");

                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(250)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.HasFeeTemplates)
                    .HasColumnType("bit(1)")
                    .HasColumnName("HAS_FEE_TEMPLATES");

                entity.Property(e => e.HasLogin)
                    .HasColumnType("bit(1)")
                    .HasColumnName("HAS_LOGIN");

                entity.Property(e => e.HasScheduleTemplates)
                    .HasColumnType("bit(1)")
                    .HasColumnName("HAS_SCHEDULE_TEMPLATES");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(50)
                    .HasColumnName("HOME_PHONE");

                entity.Property(e => e.LastName)
                    .HasMaxLength(250)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.ListName)
                    .HasMaxLength(250)
                    .HasColumnName("LIST_NAME");

                entity.Property(e => e.MaxDiscountAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("MAX_DISCOUNT_AMOUNT");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .HasColumnName("MIDDLE_NAME");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .HasColumnName("PREFIX");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PROVIDER_ID");

                entity.Property(e => e.SearchIndex)
                    .HasColumnType("longtext")
                    .HasColumnName("SEARCH_INDEX");

                entity.Property(e => e.Sex)
                    .HasColumnType("bit(1)")
                    .HasColumnName("SEX");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(50)
                    .HasColumnName("SUFFIX");

                entity.Property(e => e.UserId)
                    .HasMaxLength(38)
                    .HasColumnName("USER_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(50)
                    .HasColumnName("WORK_PHONE");
            });

            modelBuilder.Entity<TblEncounter>(entity =>
            {
                entity.HasKey(e => e.EncounterId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_encounter");

                entity.Property(e => e.EncounterId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ENCOUNTER_ID");

                entity.Property(e => e.AdmissionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ADMISSION_ID");

                entity.Property(e => e.AmbulanceTripId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AMBULANCE_TRIP_ID");

                entity.Property(e => e.AppointmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("APPOINTMENT_ID");

                entity.Property(e => e.ArogyasreeId)
                    .HasMaxLength(50)
                    .HasColumnName("AROGYASREE_ID");

                entity.Property(e => e.BillTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("BILL_TYPE_ID");

                entity.Property(e => e.CasualityDischargeStatusId)
                    .HasColumnType("bit(1)")
                    .HasColumnName("CASUALITY_DISCHARGE_STATUS_ID");

                entity.Property(e => e.CasualityLabEncounterId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("CASUALITY_LAB_ENCOUNTER_ID");

                entity.Property(e => e.CasualityPatShiftedTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CASUALITY_PAT_SHIFTED_TYPE_ID");

                entity.Property(e => e.ChamberNo)
                    .HasMaxLength(50)
                    .HasColumnName("CHAMBER_NO");

                entity.Property(e => e.ClosingDate).HasColumnName("CLOSING_DATE");

                entity.Property(e => e.ConsultationChargeGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CONSULTATION_CHARGE_GROUP_ID");

                entity.Property(e => e.ConsultationDate).HasColumnName("CONSULTATION_DATE");

                entity.Property(e => e.ConsultationTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CONSULTATION_TYPE_ID");

                entity.Property(e => e.ConvertToIp)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("CONVERT_TO_IP");

                entity.Property(e => e.CorporateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CORPORATE_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.CrossRefEncounterId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("CROSS_REF_ENCOUNTER_ID");

                entity.Property(e => e.DateOfVisit).HasColumnName("DATE_OF_VISIT");

                entity.Property(e => e.DischargeConfirmedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("DISCHARGE_CONFIRMED_BY");

                entity.Property(e => e.DischargeDate).HasColumnName("DISCHARGE_DATE");

                entity.Property(e => e.DischargeNotes)
                    .HasMaxLength(4000)
                    .HasColumnName("DISCHARGE_NOTES");

                entity.Property(e => e.DoctorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DOCTOR_ID");

                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_ID");

                entity.Property(e => e.FacilitySpecialityLinkId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_SPECIALITY_LINK_ID");

                entity.Property(e => e.IdFromAmbulance)
                    .HasColumnType("bit(1)")
                    .HasColumnName("ID_FROM_AMBULANCE");

                entity.Property(e => e.InvoiceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("INVOICE_ID");

                entity.Property(e => e.IsAdmission)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_ADMISSION");

                entity.Property(e => e.IsArogyasree)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_AROGYASREE");

                entity.Property(e => e.IsConvertedToAdmission)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_CONVERTED_TO_ADMISSION");

                entity.Property(e => e.IsCoupon)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_COUPON");

                entity.Property(e => e.IsEmergencyRegistration)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_EMERGENCY_REGISTRATION");

                entity.Property(e => e.IsFreeConsultation)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_FREE_CONSULTATION");

                entity.Property(e => e.IsFromCasuality)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_FROM_CASUALITY");

                entity.Property(e => e.IsHealthCheckupDone)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_HEALTH_CHECKUP_DONE");

                entity.Property(e => e.IsLabReportDelivered)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_LAB_REPORT_DELIVERED");

                entity.Property(e => e.IsOpLabBill)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_OP_LAB_BILL");

                entity.Property(e => e.IsReview)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_REVIEW");

                entity.Property(e => e.IsShownInProgressnote)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_SHOWN_IN_PROGRESSNOTE");

                entity.Property(e => e.LabAdmissionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("LAB_ADMISSION_ID");

                entity.Property(e => e.LabId)
                    .HasColumnType("int(11)")
                    .HasColumnName("LAB_ID");

                entity.Property(e => e.LastDateOfChargedVisit).HasColumnName("LAST_DATE_OF_CHARGED_VISIT");

                entity.Property(e => e.MarketingEmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MARKETING_EMPLOYEE_ID");

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .HasColumnName("MODE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasColumnName("NOTES");

                entity.Property(e => e.OpConsultationStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OP_CONSULTATION_STATUS_ID");

                entity.Property(e => e.OpId)
                    .HasMaxLength(20)
                    .HasColumnName("OP_ID");

                entity.Property(e => e.OpLabId)
                    .HasMaxLength(20)
                    .HasColumnName("OP_LAB_ID");

                entity.Property(e => e.OpLabStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OP_LAB_STATUS_ID");

                entity.Property(e => e.OpSpecialityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OP_SPECIALITY_ID");

                entity.Property(e => e.PatientEncounterId)
                    .HasMaxLength(200)
                    .HasColumnName("PATIENT_ENCOUNTER_ID");

                entity.Property(e => e.PatientId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("PATIENT_ID");

                entity.Property(e => e.ReferingPerson)
                    .HasColumnType("longtext")
                    .HasColumnName("REFERING_PERSON");

                entity.Property(e => e.ReferralSourceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("REFERRAL_SOURCE_ID");

                entity.Property(e => e.ReferralSourceNameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("REFERRAL_SOURCE_NAME_ID");

                entity.Property(e => e.ReviewCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("REVIEW_COUNT");

                entity.Property(e => e.SequenceNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("SEQUENCE_NUMBER");

                entity.Property(e => e.ServiceTaxPercentage)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("SERVICE_TAX_PERCENTAGE");

                entity.Property(e => e.SpecialityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SPECIALITY_ID");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.Property(e => e.TotalBilledAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("TOTAL_BILLED_AMOUNT");
            });

            modelBuilder.Entity<TblEncounterBillingEntry>(entity =>
            {
                entity.HasKey(e => e.EncounterEntryId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_encounter_billing_entry");

                entity.Property(e => e.EncounterEntryId)
                    .HasMaxLength(38)
                    .HasColumnName("ENCOUNTER_ENTRY_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.AdmissionTransferId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ADMISSION_TRANSFER_ID");

                entity.Property(e => e.AppointmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("APPOINTMENT_ID");

                entity.Property(e => e.AuthorisedRefundAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("AUTHORISED_REFUND_AMOUNT");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("BATCH_NO");

                entity.Property(e => e.BillNo)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("BILL_NO");

                entity.Property(e => e.BloodInventoryEntryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("BLOOD_INVENTORY_ENTRY_ID");

                entity.Property(e => e.ChargeAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("CHARGE_AMOUNT");

                entity.Property(e => e.ChargeGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CHARGE_GROUP_ID");

                entity.Property(e => e.ChargeItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CHARGE_ITEM_ID");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .HasColumnName("CHEQUE_NO");

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.DateOfService).HasColumnName("DATE_OF_SERVICE");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18,0)")
                    .HasColumnName("DISCOUNT");

                entity.Property(e => e.DiscountPercentage)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("DISCOUNT_PERCENTAGE");

                entity.Property(e => e.DrugId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("DRUG_ID");

                entity.Property(e => e.DueAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("DUE_AMOUNT");

                entity.Property(e => e.EncounterId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ENCOUNTER_ID");

                entity.Property(e => e.EncounterOrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ENCOUNTER_ORDER_ID");

                entity.Property(e => e.ExpiryDate).HasColumnName("EXPIRY_DATE");

                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_ID");

                entity.Property(e => e.FromDate).HasColumnName("FROM_DATE");

                entity.Property(e => e.InvoiceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("INVOICE_ID");

                entity.Property(e => e.IsAuthorisedPayment)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_AUTHORISED_PAYMENT");

                entity.Property(e => e.IsChargeItemDeleted)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_CHARGE_ITEM_DELETED");

                entity.Property(e => e.IsConcessionAuthorised)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_CONCESSION_AUTHORISED");

                entity.Property(e => e.IsCorporatePaymentForLabs)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_CORPORATE_PAYMENT_FOR_LABS");

                entity.Property(e => e.IsFromLabBill)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_FROM_LAB_BILL");

                entity.Property(e => e.IsInitialPayment)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_INITIAL_PAYMENT");

                entity.Property(e => e.IsRefundAuthorised)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_REFUND_AUTHORISED");

                entity.Property(e => e.LabBillComments)
                    .HasMaxLength(4000)
                    .HasColumnName("LAB_BILL_COMMENTS");

                entity.Property(e => e.Mode)
                    .HasMaxLength(50)
                    .HasColumnName("MODE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.NoOfDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("NO_OF_DAYS");

                entity.Property(e => e.NoOfUnits).HasColumnName("NO_OF_UNITS");

                entity.Property(e => e.OnTheHouse)
                    .HasColumnType("bit(1)")
                    .HasColumnName("ON_THE_HOUSE");

                entity.Property(e => e.OverrideComment)
                    .HasMaxLength(1000)
                    .HasColumnName("OVERRIDE_COMMENT");

                entity.Property(e => e.OverrideUser)
                    .HasMaxLength(50)
                    .HasColumnName("OVERRIDE_USER");

                entity.Property(e => e.PaidAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("PAID_AMOUNT");

                entity.Property(e => e.PatientId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("PATIENT_ID");

                entity.Property(e => e.PaymentAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("PAYMENT_AMOUNT");

                entity.Property(e => e.PaymentChargeInd)
                    .HasColumnType("bit(1)")
                    .HasColumnName("PAYMENT_CHARGE_IND");

                entity.Property(e => e.PaymentEntryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PAYMENT_ENTRY_ID");

                entity.Property(e => e.PaymentModeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PAYMENT_MODE_ID");

                entity.Property(e => e.PaymentRefCode)
                    .HasMaxLength(50)
                    .HasColumnName("PAYMENT_REF_CODE");

                entity.Property(e => e.PerOralId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PER_ORAL_ID");

                entity.Property(e => e.ProviderCommissionAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("PROVIDER_COMMISSION_AMOUNT");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PROVIDER_ID");

                entity.Property(e => e.RefBillNo)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("REF_BILL_NO");

                entity.Property(e => e.ReferringPhysicianCommissionAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("REFERRING_PHYSICIAN_COMMISSION_AMOUNT");

                entity.Property(e => e.ReferringPhysicianId)
                    .HasColumnType("int(11)")
                    .HasColumnName("REFERRING_PHYSICIAN_ID");

                entity.Property(e => e.RefundAgainstBillingEntryId)
                    .HasMaxLength(38)
                    .HasColumnName("REFUND_AGAINST_BILLING_ENTRY_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.RegisterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("REGISTER_ID");

                entity.Property(e => e.RoomNo)
                    .HasMaxLength(10)
                    .HasColumnName("ROOM_NO");

                entity.Property(e => e.SequenceNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("SEQUENCE_NUMBER");

                entity.Property(e => e.ToDate).HasColumnName("TO_DATE");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("UNIT_PRICE");
            });

            modelBuilder.Entity<TblEncounterBillingEntryHistory>(entity =>
            {
                entity.HasKey(e => e.EncounterEntryHistoryId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_encounter_billing_entry_history");

                entity.Property(e => e.EncounterEntryHistoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ENCOUNTER_ENTRY_HISTORY_ID");

                entity.Property(e => e.ActionPerformed)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ACTION_PERFORMED");

                entity.Property(e => e.AppointmentId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("APPOINTMENT_ID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("BATCH_NO");

                entity.Property(e => e.ChangedDate).HasColumnName("CHANGED_DATE");

                entity.Property(e => e.ChargeAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("CHARGE_AMOUNT");

                entity.Property(e => e.ChargeItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CHARGE_ITEM_ID");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .HasColumnName("CHEQUE_NO");

                entity.Property(e => e.Comments)
                    .HasMaxLength(4000)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.DateOfService).HasColumnName("DATE_OF_SERVICE");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("DISCOUNT");

                entity.Property(e => e.DiscountPercentage)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("DISCOUNT_PERCENTAGE");

                entity.Property(e => e.DrugId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("DRUG_ID");

                entity.Property(e => e.EncounterEntryId)
                    .IsRequired()
                    .HasMaxLength(38)
                    .HasColumnName("ENCOUNTER_ENTRY_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.EncounterId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ENCOUNTER_ID");

                entity.Property(e => e.ExpiryDate).HasColumnName("EXPIRY_DATE");

                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_ID");

                entity.Property(e => e.FromDate).HasColumnName("FROM_DATE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.NoOfDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("NO_OF_DAYS");

                entity.Property(e => e.NoOfUnits).HasColumnName("NO_OF_UNITS");

                entity.Property(e => e.OverrideComment)
                    .HasMaxLength(1000)
                    .HasColumnName("OVERRIDE_COMMENT");

                entity.Property(e => e.OverrideUser)
                    .HasMaxLength(50)
                    .HasColumnName("OVERRIDE_USER");

                entity.Property(e => e.PatientId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PATIENT_ID");

                entity.Property(e => e.PaymentAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("PAYMENT_AMOUNT");

                entity.Property(e => e.PaymentChargeInd)
                    .HasColumnType("bit(1)")
                    .HasColumnName("PAYMENT_CHARGE_IND");

                entity.Property(e => e.PaymentModeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PAYMENT_MODE_ID");

                entity.Property(e => e.PaymentRefCode)
                    .HasMaxLength(50)
                    .HasColumnName("PAYMENT_REF_CODE");

                entity.Property(e => e.PerOralId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PER_ORAL_ID");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PROVIDER_ID");

                entity.Property(e => e.RoomNo)
                    .HasMaxLength(10)
                    .HasColumnName("ROOM_NO");

                entity.Property(e => e.ToDate).HasColumnName("TO_DATE");

                entity.Property(e => e.UnitCost)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("UNIT_COST");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("UNIT_PRICE");
            });

            modelBuilder.Entity<TblEncounterBillingPaymentsAgainstCahrgeItemLink>(entity =>
            {
                entity.HasKey(e => e.PaymentBillingEntryId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_encounter_billing_payments_against_cahrge_item_link");

                entity.Property(e => e.PaymentBillingEntryId)
                    .HasMaxLength(38)
                    .HasColumnName("PAYMENT_BILLING_ENTRY_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.ChargeItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CHARGE_ITEM_ID");

                entity.Property(e => e.EncounterId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ENCOUNTER_ID");

                entity.Property(e => e.PaidAmount)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("PAID_AMOUNT");

                entity.Property(e => e.PaymentAgainstBillingEntryId)
                    .IsRequired()
                    .HasMaxLength(38)
                    .HasColumnName("PAYMENT_AGAINST_BILLING_ENTRY_ID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblFacility>(entity =>
            {
                entity.HasKey(e => e.FacilityId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_facility");

                entity.HasIndex(e => e.DefaultCompanyId, "DEFAULT_COMPANY_ID");

                entity.HasIndex(e => e.FacilityTypeId, "FACILITY_TYPE_ID");

                entity.HasIndex(e => e.SpecialityId, "SPECIALITY_ID");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_ID");

                entity.Property(e => e.AdditionalLicenseNumber)
                    .HasMaxLength(50)
                    .HasColumnName("ADDITIONAL_LICENSE_NUMBER");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(50)
                    .HasColumnName("COLOR_CODE");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.DefaultCompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DEFAULT_COMPANY_ID");

                entity.Property(e => e.DischargeProcessId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DISCHARGE_PROCESS_ID");

                entity.Property(e => e.FacilityDescription)
                    .HasMaxLength(250)
                    .HasColumnName("FACILITY_DESCRIPTION");

                entity.Property(e => e.FacilityName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("FACILITY_NAME");

                entity.Property(e => e.FacilityTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_TYPE_ID");

                entity.Property(e => e.FederalTaxId)
                    .HasMaxLength(50)
                    .HasColumnName("FEDERAL_TAX_ID");

                entity.Property(e => e.FederalTaxIdType)
                    .HasColumnType("int(11)")
                    .HasColumnName("FEDERAL_TAX_ID_TYPE");

                entity.Property(e => e.IsCentralFacility)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_CENTRAL_FACILITY");

                entity.Property(e => e.Ledger)
                    .HasMaxLength(50)
                    .HasColumnName("LEDGER");

                entity.Property(e => e.ListName)
                    .HasMaxLength(250)
                    .HasColumnName("LIST_NAME");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Npi)
                    .HasMaxLength(50)
                    .HasColumnName("NPI");

                entity.Property(e => e.PlaceOfServiceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PLACE_OF_SERVICE_ID");

                entity.Property(e => e.SpecialityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SPECIALITY_ID");

                entity.Property(e => e.SpecialityLicenseNumber)
                    .HasMaxLength(50)
                    .HasColumnName("SPECIALITY_LICENSE_NUMBER");

                entity.Property(e => e.StateLicenseNumber)
                    .HasMaxLength(50)
                    .HasColumnName("STATE_LICENSE_NUMBER");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.Property(e => e.TaxRate)
                    .HasMaxLength(50)
                    .HasColumnName("TAX_RATE");

                entity.Property(e => e.TicketNumberPrefix)
                    .HasMaxLength(50)
                    .HasColumnName("TICKET_NUMBER_PREFIX");

                entity.Property(e => e.TypeOfBill)
                    .HasMaxLength(50)
                    .HasColumnName("TYPE_OF_BILL");

                entity.HasOne(d => d.DefaultCompany)
                    .WithMany(p => p.TblFacilities)
                    .HasForeignKey(d => d.DefaultCompanyId)
                    .HasConstraintName("tbl_facility_ibfk_2");

                entity.HasOne(d => d.FacilityType)
                    .WithMany(p => p.TblFacilities)
                    .HasForeignKey(d => d.FacilityTypeId)
                    .HasConstraintName("tbl_facility_ibfk_4");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.TblFacilities)
                    .HasForeignKey(d => d.SpecialityId)
                    .HasConstraintName("tbl_facility_ibfk_3");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblFacilities)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_facility_ibfk_1");
            });

            modelBuilder.Entity<TblFacilityDepartment>(entity =>
            {
                entity.HasKey(e => e.FacilityDepartmentId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_facility_department");

                entity.HasIndex(e => e.FacilityId, "FACILITY_ID");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.FacilityDepartmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_DEPARTMENT_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDate).HasColumnName("CREATED_DATE");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .HasColumnName("DEPARTMENT_NAME");

                entity.Property(e => e.Description)
                    .HasColumnType("longtext")
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.TblFacilityDepartments)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_facility_department_ibfk_2");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblFacilityDepartments)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("tbl_facility_department_ibfk_1");
            });

            modelBuilder.Entity<TblFacilityMapping>(entity =>
            {
                entity.HasKey(e => e.FacilityMappingId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_facility_mapping");

                entity.Property(e => e.FacilityMappingId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_MAPPING_ID");

                entity.Property(e => e.CreatedDate).HasColumnName("CREATED_DATE");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_ID");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ORGANIZATION_ID");
            });

            modelBuilder.Entity<TblOrganization>(entity =>
            {
                entity.HasKey(e => e.OrganizationId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_organization");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.CreatedDate).HasColumnName("CREATED_DATE");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.OrganizationName)
                    .HasMaxLength(100)
                    .HasColumnName("ORGANIZATION_NAME");
            });

            modelBuilder.Entity<TblPatient>(entity =>
            {
                entity.HasKey(e => e.PatienTId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_patient");

                entity.HasIndex(e => e.AreaId, "AREA_ID");

                entity.HasIndex(e => e.DoctorId, "DOCTOR_ID");

                entity.HasIndex(e => e.FacilityId, "FACILITY_ID");

                entity.HasIndex(e => e.MaritalStatusId, "MARITAL_STATUS_ID");

                entity.HasIndex(e => e.ReferrinGPhysicianId, "REFERRInG_PHYSICIAn_ID");

                entity.HasIndex(e => e.Religion, "RELIGIOn");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.HasIndex(e => e.NAtionAlity, "nATIOnALITY");

                entity.Property(e => e.PatienTId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("PATIEnT_ID");

                entity.Property(e => e.AadharNO)
                    .HasColumnType("longtext")
                    .HasColumnName("AADHAR_nO");

                entity.Property(e => e.Address)
                    .HasColumnType("longtext")
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Age)
                    .HasColumnType("decimal(18,2)")
                    .HasColumnName("AGE");

                entity.Property(e => e.AgeMode)
                    .HasColumnType("int(11)")
                    .HasColumnName("AGE_MODE");

                entity.Property(e => e.Allergy)
                    .HasColumnType("longtext")
                    .HasColumnName("ALLERGY");

                entity.Property(e => e.AlternAteMobileNUmber)
                    .HasMaxLength(50)
                    .HasColumnName("ALTERnATE_MOBILE_nUMBER");

                entity.Property(e => e.AreaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AREA_ID");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(50)
                    .HasColumnName("BLOOD_GROUP");

                entity.Property(e => e.CorporateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CORPORATE_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATIOn_DATE");

                entity.Property(e => e.CustomerMrn)
                    .HasColumnType("longtext")
                    .HasColumnName("CUSTOMER_MRn");

                entity.Property(e => e.DateOfBirth).HasColumnName("DATE_OF_BIRTH");

                entity.Property(e => e.DoctorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DOCTOR_ID");

                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_ID");

                entity.Property(e => e.FirstNAme)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("FIRST_nAME");

                entity.Property(e => e.HealthId)
                    .HasMaxLength(250)
                    .HasColumnName("healthId");

                entity.Property(e => e.HealthIdNumber)
                    .HasMaxLength(350)
                    .HasColumnName("healthIdNumber");

                entity.Property(e => e.Height)
                    .HasMaxLength(50)
                    .HasColumnName("HEIGHT");

                entity.Property(e => e.IdProofId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID_PROOF_ID");

                entity.Property(e => e.IdProofImagePath)
                    .HasColumnType("longtext")
                    .HasColumnName("ID_PROOF_IMAGE_PATH");

                entity.Property(e => e.IdenTificationMarks)
                    .HasColumnType("longtext")
                    .HasColumnName("IDEnTIFICATIOn_MARKS");

                entity.Property(e => e.IdentificationMarks1)
                    .HasMaxLength(255)
                    .HasColumnName("identificationMarks");

                entity.Property(e => e.ImagePath)
                    .HasColumnType("longtext")
                    .HasColumnName("IMAGE_PATH");

                entity.Property(e => e.IsCustomer)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_CUSTOMER");

                entity.Property(e => e.IsServiceAvailed)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_SERVICE_AVAILED");

                entity.Property(e => e.LastNAme)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("LAST_nAME");

                entity.Property(e => e.MaritalStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MARITAL_STATUS_ID");

                entity.Property(e => e.Middlename)
                    .HasMaxLength(250)
                    .HasColumnName("middlename");

                entity.Property(e => e.MobileNUmber)
                    .HasMaxLength(50)
                    .HasColumnName("MOBILE_nUMBER");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.MotherNAme)
                    .HasColumnType("longtext")
                    .HasColumnName("MOTHER_nAME");

                entity.Property(e => e.NAtionAlity)
                    .HasColumnType("int(11)")
                    .HasColumnName("nATIOnALITY");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(250)
                    .HasColumnName("OCCUPATIOn");

                entity.Property(e => e.OrganDonOr)
                    .HasColumnType("bit(1)")
                    .HasColumnName("ORGAn_DOnOR");

                entity.Property(e => e.OverTheCounTer)
                    .HasMaxLength(10)
                    .HasColumnName("OVER_THE_COUnTER");

                entity.Property(e => e.ParenT)
                    .HasMaxLength(500)
                    .HasColumnName("PAREnT");

                entity.Property(e => e.Passport)
                    .HasMaxLength(100)
                    .HasColumnName("PASSPORT");

                entity.Property(e => e.Password)
                    .HasColumnType("longtext")
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.PatienTEmail)
                    .HasColumnType("longtext")
                    .HasColumnName("PATIEnT_EMAIL");

                entity.Property(e => e.PatienTMrn)
                    .HasMaxLength(50)
                    .HasColumnName("PATIEnT_MRn");

                entity.Property(e => e.PatienTUnIqueId)
                    .HasMaxLength(20)
                    .HasColumnName("PATIEnT_UnIQUE_ID");

                entity.Property(e => e.PersonBroughtinMobilenO)
                    .HasMaxLength(50)
                    .HasColumnName("PERSOnBROUGHTIn_MOBILEnO");

                entity.Property(e => e.PersonBroughtinNAme)
                    .HasMaxLength(50)
                    .HasColumnName("PERSOnBROUGHTIn_nAME");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .HasColumnName("PREFIX");

                entity.Property(e => e.ReferrinGPerson)
                    .HasColumnType("longtext")
                    .HasColumnName("REFERRInG_PERSOn");

                entity.Property(e => e.ReferrinGPhysicianId)
                    .HasColumnType("int(11)")
                    .HasColumnName("REFERRInG_PHYSICIAn_ID");

                entity.Property(e => e.RelationType)
                    .HasColumnType("int(11)")
                    .HasColumnName("RELATIOnTYPE");

                entity.Property(e => e.Religion)
                    .HasColumnType("int(11)")
                    .HasColumnName("RELIGIOn");

                entity.Property(e => e.Remarks)
                    .HasColumnType("longtext")
                    .HasColumnName("REMARKS");

                entity.Property(e => e.RfId)
                    .HasMaxLength(200)
                    .HasColumnName("RF_ID");

                entity.Property(e => e.SearchInDex)
                    .HasColumnType("longtext")
                    .HasColumnName("SEARCH_InDEX");

                entity.Property(e => e.SearchIndex1)
                    .HasMaxLength(255)
                    .HasColumnName("searchIndex");

                entity.Property(e => e.Sex)
                    .HasColumnType("int(11)")
                    .HasColumnName("SEX");

                entity.Property(e => e.SoWoDo)
                    .HasColumnType("longtext")
                    .HasColumnName("SO_WO_DO");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.Property(e => e.TriggerSource)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("TRIGGER_SOURCE");

                entity.Property(e => e.VisitTypeId)
                    .HasMaxLength(50)
                    .HasColumnName("VISIT_TYPE_ID");

                entity.Property(e => e.Weight)
                    .HasMaxLength(50)
                    .HasColumnName("WEIGHT");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.TblPatients)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("tbl_patient_ibfk_1");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.TblPatientDoctors)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("tbl_patient_ibfk_7");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.TblPatients)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("tbl_patient_ibfk_6");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.TblPatients)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("tbl_patient_ibfk_2");

                entity.HasOne(d => d.NAtionAlityNavigation)
                    .WithMany(p => p.TblPatients)
                    .HasForeignKey(d => d.NAtionAlity)
                    .HasConstraintName("tbl_patient_ibfk_3");

                entity.HasOne(d => d.ReferrinGPhysician)
                    .WithMany(p => p.TblPatientReferrinGPhysicians)
                    .HasForeignKey(d => d.ReferrinGPhysicianId)
                    .HasConstraintName("tbl_patient_ibfk_8");

                entity.HasOne(d => d.ReligionNavigation)
                    .WithMany(p => p.TblPatients)
                    .HasForeignKey(d => d.Religion)
                    .HasConstraintName("tbl_patient_ibfk_5");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblPatients)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("tbl_patient_ibfk_4");
            });

            modelBuilder.Entity<TblPatientAppointment>(entity =>
            {
                entity.HasKey(e => e.PatientAppointmentId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_patient_appointment");

                entity.Property(e => e.PatientAppointmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PATIENT_APPOINTMENT_ID");

                entity.Property(e => e.AppointmentDate).HasColumnName("APPOINTMENT_DATE");

                entity.Property(e => e.AppointmentNotes)
                    .HasMaxLength(400)
                    .HasColumnName("APPOINTMENT_NOTES");

                entity.Property(e => e.AppointmentStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("APPOINTMENT_STATUS_ID");

                entity.Property(e => e.AppointmentTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("APPOINTMENT_TYPE_ID");

                entity.Property(e => e.AppointmentTypeNotes)
                    .HasMaxLength(400)
                    .HasColumnName("APPOINTMENT_TYPE_NOTES");

                entity.Property(e => e.CaseId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CASE_ID");

                entity.Property(e => e.CaseNotes)
                    .HasMaxLength(400)
                    .HasColumnName("CASE_NOTES");

                entity.Property(e => e.ChainId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CHAIN_ID");

                entity.Property(e => e.CheckinDate).HasColumnName("CHECKIN_DATE");

                entity.Property(e => e.CheckoutDate).HasColumnName("CHECKOUT_DATE");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("COMPANY_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.DoctorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DOCTOR_ID");

                entity.Property(e => e.EndTime).HasColumnName("END_TIME");

                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_ID");

                entity.Property(e => e.IsMedicoLegalCase)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_MEDICO_LEGAL_CASE");

                entity.Property(e => e.IsProviderAppointment)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_PROVIDER_APPOINTMENT");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.NameOfTheInforment)
                    .HasMaxLength(500)
                    .HasColumnName("NAME_OF_THE_INFORMENT");

                entity.Property(e => e.PatientAppointmentDescription)
                    .HasMaxLength(200)
                    .HasColumnName("PATIENT_APPOINTMENT_DESCRIPTION");

                entity.Property(e => e.PatientId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("PATIENT_ID");

                entity.Property(e => e.PatientSpecificNotes)
                    .HasMaxLength(400)
                    .HasColumnName("PATIENT_SPECIFIC_NOTES");

                entity.Property(e => e.PatientTicketNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("PATIENT_TICKET_NO");

                entity.Property(e => e.PcNo)
                    .HasMaxLength(500)
                    .HasColumnName("PC_NO");

                entity.Property(e => e.PcWhoIsBrought)
                    .HasMaxLength(500)
                    .HasColumnName("PC_WHO_IS_BROUGHT");

                entity.Property(e => e.PoliceStation)
                    .HasMaxLength(500)
                    .HasColumnName("POLICE_STATION");

                entity.Property(e => e.RecallId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RECALL_ID");

                entity.Property(e => e.ReferalsourceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("REFERALSOURCE_ID");

                entity.Property(e => e.ReferringPhysicianId)
                    .HasColumnType("int(11)")
                    .HasColumnName("REFERRING_PHYSICIAN_ID");

                entity.Property(e => e.ResourceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RESOURCE_ID");

                entity.Property(e => e.RoomNo)
                    .HasMaxLength(50)
                    .HasColumnName("ROOM_NO");

                entity.Property(e => e.ScheduleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SCHEDULE_ID");

                entity.Property(e => e.SetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SET_ID");

                entity.Property(e => e.SpecificSource)
                    .HasMaxLength(100)
                    .HasColumnName("SPECIFIC_SOURCE");

                entity.Property(e => e.StartTime).HasColumnName("START_TIME");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.Property(e => e.WaitinglistId)
                    .HasColumnType("int(11)")
                    .HasColumnName("WAITINGLIST_ID");
            });

            modelBuilder.Entity<TblPatientAppointmentSecuUserLink>(entity =>
            {
                entity.HasKey(e => e.AppointmentSecurityUserLinkId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_patient_appointment_secu_user_link");

                entity.Property(e => e.AppointmentSecurityUserLinkId)
                    .HasColumnType("int(11)")
                    .HasColumnName("APPOINTMENT_SECURITY_USER_LINK_ID");

                entity.Property(e => e.AppointmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("APPOINTMENT_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.EncounterId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ENCOUNTER_ID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PROVIDER_ID");

                entity.Property(e => e.ResourceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RESOURCE_ID");

                entity.Property(e => e.SecurityUserId)
                    .HasMaxLength(38)
                    .HasColumnName("SECURITY_USER_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");
            });

            modelBuilder.Entity<TblProvider>(entity =>
            {
                entity.HasKey(e => e.ProviderId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_provider");

                entity.HasIndex(e => e.FacilityTypeId, "FACILITY_TYPE_ID");

                entity.HasIndex(e => e.ProviderTypeId, "PROVIDER_TYPE_ID");

                entity.HasIndex(e => e.SpecialityTypeId, "SPECIALITY_TYPE_ID");

                entity.HasIndex(e => e.StatusId, "STATUS_ID");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PROVIDER_ID");

                entity.Property(e => e.AdditionalLicenseNumber)
                    .HasMaxLength(50)
                    .HasColumnName("ADDITIONAL_LICENSE_NUMBER");

                entity.Property(e => e.AnesthesiologistLicenseNumber)
                    .HasMaxLength(50)
                    .HasColumnName("ANESTHESIOLOGIST_LICENSE_NUMBER");

                entity.Property(e => e.CommissionAmount)
                    .HasMaxLength(50)
                    .HasColumnName("COMMISSION_AMOUNT");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreationDate).HasColumnName("CREATION_DATE");

                entity.Property(e => e.DiscountPercentage)
                    .HasMaxLength(50)
                    .HasColumnName("DISCOUNT_PERCENTAGE");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.FacilityTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_TYPE_ID");

                entity.Property(e => e.FederalTaxId)
                    .HasMaxLength(50)
                    .HasColumnName("FEDERAL_TAX_ID");

                entity.Property(e => e.FederalTaxIdType)
                    .HasMaxLength(50)
                    .HasColumnName("FEDERAL_TAX_ID_TYPE");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(250)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(500)
                    .HasColumnName("IMAGE_PATH");

                entity.Property(e => e.IpReviewConsultationsCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("IP_REVIEW_CONSULTATIONS_COUNT");

                entity.Property(e => e.IpReviewDays)
                    .HasMaxLength(50)
                    .HasColumnName("IP_REVIEW_DAYS");

                entity.Property(e => e.IsNocommissions)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_NOCOMMISSIONS");

                entity.Property(e => e.IsProvider)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_PROVIDER");

                entity.Property(e => e.LastName)
                    .HasMaxLength(250)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.Ledger)
                    .HasMaxLength(50)
                    .HasColumnName("LEDGER");

                entity.Property(e => e.ListName)
                    .HasMaxLength(250)
                    .HasColumnName("LIST_NAME");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .HasColumnName("MIDDLE_NAME");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(50)
                    .HasColumnName("MOBILE_NUMBER");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedDate).HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.NonPaticipatingInsuranceCompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("NON_PATICIPATING_INSURANCE_COMPANY_ID");

                entity.Property(e => e.Npi)
                    .HasMaxLength(50)
                    .HasColumnName("NPI");

                entity.Property(e => e.OrganizationName)
                    .HasMaxLength(250)
                    .HasColumnName("ORGANIZATION_NAME");

                entity.Property(e => e.OverriddenReviewDays)
                    .HasMaxLength(50)
                    .HasColumnName("OVERRIDDEN_REVIEW_DAYS");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .HasColumnName("PREFIX");

                entity.Property(e => e.ProviderCode)
                    .HasColumnType("longtext")
                    .HasColumnName("PROVIDER_CODE");

                entity.Property(e => e.ProviderTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PROVIDER_TYPE_ID");

                entity.Property(e => e.ReviewConsultationsCount)
                    .HasMaxLength(50)
                    .HasColumnName("REVIEW_CONSULTATIONS_COUNT");

                entity.Property(e => e.SearchIndex)
                    .HasColumnType("longtext")
                    .HasColumnName("SEARCH_INDEX");

                entity.Property(e => e.SpecialityLicenseNumber)
                    .HasMaxLength(50)
                    .HasColumnName("SPECIALITY_LICENSE_NUMBER");

                entity.Property(e => e.SpecialityTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SPECIALITY_TYPE_ID");

                entity.Property(e => e.StateLicenseNumber)
                    .HasMaxLength(50)
                    .HasColumnName("STATE_LICENSE_NUMBER");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(50)
                    .HasColumnName("SUFFIX");

                entity.Property(e => e.Upin)
                    .HasMaxLength(50)
                    .HasColumnName("UPIN");

                entity.Property(e => e.UserId)
                    .HasMaxLength(38)
                    .HasColumnName("USER_ID")
                    .IsFixedLength(true);

                entity.HasOne(d => d.FacilityType)
                    .WithMany(p => p.TblProviders)
                    .HasForeignKey(d => d.FacilityTypeId)
                    .HasConstraintName("tbl_provider_ibfk_1");

                entity.HasOne(d => d.ProviderType)
                    .WithMany(p => p.TblProviders)
                    .HasForeignKey(d => d.ProviderTypeId)
                    .HasConstraintName("tbl_provider_ibfk_4");

                entity.HasOne(d => d.SpecialityType)
                    .WithMany(p => p.TblProviders)
                    .HasForeignKey(d => d.SpecialityTypeId)
                    .HasConstraintName("tbl_provider_ibfk_3");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblProviders)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("tbl_provider_ibfk_2");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_roles");

                entity.Property(e => e.RoleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RoleID");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.ModifiedBy).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(200)
                    .HasColumnName("Role_Name");
            });

            modelBuilder.Entity<TblScheduleProvider>(entity =>
            {
                entity.HasKey(e => e.ScheduleProviderId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_schedule_provider");

                entity.Property(e => e.ScheduleProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SCHEDULE_PROVIDER_ID");

                entity.Property(e => e.IsDefaultSchedule)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IS_DEFAULT_SCHEDULE");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PROVIDER_ID");

                entity.Property(e => e.ScheduleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SCHEDULE_ID");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("STATUS_ID");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_users");

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.EncryptedIv)
                    .HasMaxLength(300)
                    .HasColumnName("Encrypted_IV");

                entity.Property(e => e.EncryptedKey)
                    .HasMaxLength(300)
                    .HasColumnName("Encrypted_Key");

                entity.Property(e => e.EncryptedPassword)
                    .HasMaxLength(300)
                    .HasColumnName("Encrypted_Password");

                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FACILITY_ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .HasColumnName("First_Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.MobileNumber)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("Mobile_Number");

                entity.Property(e => e.ModifiedBy).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.OrganizationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ORGANIZATION_ID");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .HasColumnName("User_Name");
            });

            modelBuilder.Entity<TblUserrole>(entity =>
            {
                entity.HasKey(e => e.UserRoleId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_userroles");

                entity.Property(e => e.UserRoleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("UserRoleID");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.ModifiedBy).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.Roleid)
                    .HasColumnType("int(11)")
                    .HasColumnName("roleid");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("UserID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
