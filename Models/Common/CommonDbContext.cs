using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.Common;

public partial class CommonDbContext : DbContext
{
    public CommonDbContext()
    {
    }

    public CommonDbContext(DbContextOptions<CommonDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AttendanceDt> AttendanceDt { get; set; }

    public virtual DbSet<AttendanceHd> AttendanceHd { get; set; }

    public virtual DbSet<CommunityPatient> CommunityPatient { get; set; }

    public virtual DbSet<CustomerContractConsidalitionDt> CustomerContractConsidalitionDt { get; set; }

    public virtual DbSet<Dashboard> Dashboard { get; set; }

    public virtual DbSet<FaskesReferralSisruteHd> FaskesReferralSisruteHd { get; set; }

    public virtual DbSet<FilterMCUItem> FilterMCUItem { get; set; }

    public virtual DbSet<HelpLink> HelpLink { get; set; }

    public virtual DbSet<ICPenundaanPelayanan> ICPenundaanPelayanan { get; set; }

    public virtual DbSet<InfeksiPPI> InfeksiPPI { get; set; }

    public virtual DbSet<InformedConsent> InformedConsent { get; set; }

    public virtual DbSet<LaporanKegiatanAlatKelengkapanDewan> LaporanKegiatanAlatKelengkapanDewan { get; set; }

    public virtual DbSet<MonthlyHospitalPerformance> MonthlyHospitalPerformance { get; set; }

    public virtual DbSet<NotaDinasTable> NotaDinasTable { get; set; }

    public virtual DbSet<PatientNotesSignature> PatientNotesSignature { get; set; }

    public virtual DbSet<PrescriptionIterationDt> PrescriptionIterationDt { get; set; }

    public virtual DbSet<PrescriptionIterationHd> PrescriptionIterationHd { get; set; }

    public virtual DbSet<PurchaseRequestDt> PurchaseRequestDt { get; set; }

    public virtual DbSet<ReferToSisruteHd> ReferToSisruteHd { get; set; }

    public virtual DbSet<ReportHistoryPatient> ReportHistoryPatient { get; set; }

    public virtual DbSet<ReportTemplate> ReportTemplate { get; set; }

    public virtual DbSet<RevenueByAnciliariesSupport> RevenueByAnciliariesSupport { get; set; }

    public virtual DbSet<RevenueByDepartmentServiceUnit> RevenueByDepartmentServiceUnit { get; set; }

    public virtual DbSet<RevenueByServiceUnitItem> RevenueByServiceUnitItem { get; set; }

    public virtual DbSet<RevenueBySpecialistPhysician> RevenueBySpecialistPhysician { get; set; }

    public virtual DbSet<RiwayatPenyakitKeluargaPasien> RiwayatPenyakitKeluargaPasien { get; set; }

    public virtual DbSet<SysReportInReportTemplate> SysReportInReportTemplate { get; set; }

    public virtual DbSet<TotalRow> TotalRow { get; set; }

    public virtual DbSet<ViewPdf> ViewPdf { get; set; }

    public virtual DbSet<_bak_sysMenuInUser> _bak_sysMenuInUser { get; set; }

    public virtual DbSet<_bak_sysParameter> _bak_sysParameter { get; set; }

    public virtual DbSet<_bak_sysParameterPerSite> _bak_sysParameterPerSite { get; set; }

    public virtual DbSet<_bak_sysUser> _bak_sysUser { get; set; }

    public virtual DbSet<_bak_sysUserInServiceUnit> _bak_sysUserInServiceUnit { get; set; }

    public virtual DbSet<_tmpForPublish> _tmpForPublish { get; set; }

    public virtual DbSet<_tmp_sysAutoPageItem> _tmp_sysAutoPageItem { get; set; }

    public virtual DbSet<aspnet_Applications> aspnet_Applications { get; set; }

    public virtual DbSet<aspnet_Membership> aspnet_Membership { get; set; }

    public virtual DbSet<aspnet_Paths> aspnet_Paths { get; set; }

    public virtual DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }

    public virtual DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }

    public virtual DbSet<aspnet_Profile> aspnet_Profile { get; set; }

    public virtual DbSet<aspnet_Roles> aspnet_Roles { get; set; }

    public virtual DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }

    public virtual DbSet<aspnet_Users> aspnet_Users { get; set; }

    public virtual DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }

    public virtual DbSet<sysAutoPage> sysAutoPage { get; set; }

    public virtual DbSet<sysAutoPageItem> sysAutoPageItem { get; set; }

    public virtual DbSet<sysEntityAddressType> sysEntityAddressType { get; set; }

    public virtual DbSet<sysGroupRole> sysGroupRole { get; set; }

    public virtual DbSet<sysLicense> sysLicense { get; set; }

    public virtual DbSet<sysLicenseHist> sysLicenseHist { get; set; }

    public virtual DbSet<sysMatrixPage> sysMatrixPage { get; set; }

    public virtual DbSet<sysMenu> sysMenu { get; set; }

    public virtual DbSet<sysMenuEntryMode> sysMenuEntryMode { get; set; }

    public virtual DbSet<sysMenuFavorite> sysMenuFavorite { get; set; }

    public virtual DbSet<sysMenuFavoriteTemplate> sysMenuFavoriteTemplate { get; set; }

    public virtual DbSet<sysMenuInRole> sysMenuInRole { get; set; }

    public virtual DbSet<sysMenuInUser> sysMenuInUser { get; set; }

    public virtual DbSet<sysMenuRelated> sysMenuRelated { get; set; }

    public virtual DbSet<sysMessage> sysMessage { get; set; }

    public virtual DbSet<sysMessageTemp> sysMessageTemp { get; set; }

    public virtual DbSet<sysModule> sysModule { get; set; }

    public virtual DbSet<sysModuleDt> sysModuleDt { get; set; }

    public virtual DbSet<sysReport> sysReport { get; set; }

    public virtual DbSet<sysReportParameter> sysReportParameter { get; set; }

    public virtual DbSet<sysReportPivot> sysReportPivot { get; set; }

    public virtual DbSet<sysRoleInGroupRole> sysRoleInGroupRole { get; set; }

    public virtual DbSet<sysRolePersonalization> sysRolePersonalization { get; set; }

    public virtual DbSet<sysRoles> sysRoles { get; set; }

    public virtual DbSet<sysServiceUnitInRole> sysServiceUnitInRole { get; set; }

    public virtual DbSet<sysServiceUnitInUser> sysServiceUnitInUser { get; set; }

    public virtual DbSet<sysSite> sysSite { get; set; }

    public virtual DbSet<sysSurrogateID> sysSurrogateID { get; set; }

    public virtual DbSet<sysUserRoleInSite> sysUserRoleInSite { get; set; }

    public virtual DbSet<tblList> tblList { get; set; }

    public virtual DbSet<temp_sysmenu> temp_sysmenu { get; set; }

    public virtual DbSet<vw_aspnet_Applications> vw_aspnet_Applications { get; set; }

    public virtual DbSet<vw_aspnet_MembershipUsers> vw_aspnet_MembershipUsers { get; set; }

    public virtual DbSet<vw_aspnet_Profiles> vw_aspnet_Profiles { get; set; }

    public virtual DbSet<vw_aspnet_Roles> vw_aspnet_Roles { get; set; }

    public virtual DbSet<vw_aspnet_Users> vw_aspnet_Users { get; set; }

    public virtual DbSet<vw_aspnet_UsersInRoles> vw_aspnet_UsersInRoles { get; set; }

    public virtual DbSet<vw_aspnet_WebPartState_Paths> vw_aspnet_WebPartState_Paths { get; set; }

    public virtual DbSet<vw_aspnet_WebPartState_Shared> vw_aspnet_WebPartState_Shared { get; set; }

    public virtual DbSet<vw_aspnet_WebPartState_User> vw_aspnet_WebPartState_User { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dashboard>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_Dashboard_IsActive");
        });

        modelBuilder.Entity<FilterMCUItem>(entity =>
        {
            entity.Property(e => e.ItemID).ValueGeneratedNever();
        });

        modelBuilder.Entity<InformedConsent>(entity =>
        {
            entity.HasOne(d => d.Menu).WithOne(p => p.InformedConsent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InformedConsent_sysMenu");
        });

        modelBuilder.Entity<MonthlyHospitalPerformance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MonthlyH__3214EC07D0E65132");
        });

        modelBuilder.Entity<NotaDinasTable>(entity =>
        {
            entity.HasKey(e => e.NomorNota).HasName("PK_NotaDinas");
        });

        modelBuilder.Entity<PrescriptionIterationDt>(entity =>
        {
            entity.Property(e => e.LastUpdatedBy).HasDefaultValueSql("((0))", "DF_PrescriptionIterationDt_LastUpdatedBy");
        });

        modelBuilder.Entity<PrescriptionIterationHd>(entity =>
        {
            entity.Property(e => e.IsDeleted).HasDefaultValue(false, "DF_PrescriptionIterationHd_IsDeleted");
        });

        modelBuilder.Entity<ReferToSisruteHd>(entity =>
        {
            entity.HasKey(e => e.RegistrationNo).HasName("PK_ReferToSisrute");
        });

        modelBuilder.Entity<ReportHistoryPatient>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.MedicalNo, e.ItemId, e.ItemGroupCode, e.GCItemType, e.TransactionDate }).HasName("PK__ReportHi__9FB0147F332D160F");
        });

        modelBuilder.Entity<ReportTemplate>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_ReportTemplate_IsActive");
        });

        modelBuilder.Entity<RevenueByAnciliariesSupport>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.ItemId, e.TransactionDate }).HasName("PK__RevenueB__B490440BE81B67B1");
        });

        modelBuilder.Entity<RevenueByDepartmentServiceUnit>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.DepartmentCode, e.ServiceUnitCode, e.MedicalNo, e.TransactionDate }).HasName("PK__RevenueB__CCC91E46482C1712");
        });

        modelBuilder.Entity<RevenueByServiceUnitItem>(entity =>
        {
            entity.HasKey(e => new { e.DepartmentCode, e.ServiceUnitCode, e.ItemID, e.RegistrationNo, e.TransactionDate }).HasName("PK__RevenueB__BD7FCC3AF0FA3D2C");
        });

        modelBuilder.Entity<RevenueBySpecialistPhysician>(entity =>
        {
            entity.HasKey(e => new { e.RegistrationNo, e.SpecialtyCode, e.ParamedicID, e.ServiceUnitCode, e.TransactionDate }).HasName("PK__RevenueB__AF57811ECDC0EBF4");
        });

        modelBuilder.Entity<SysReportInReportTemplate>(entity =>
        {
            entity.HasOne(d => d.Menu).WithMany(p => p.SysReportInReportTemplate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SysReportInReportTemplate_sysReport");

            entity.HasOne(d => d.ReportTemplateCodeNavigation).WithMany(p => p.SysReportInReportTemplate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SysReportInReportTemplate_ReportTemplate");
        });

        modelBuilder.Entity<_bak_sysMenuInUser>(entity =>
        {
            entity.Property(e => e.SiteCode).IsFixedLength();
        });

        modelBuilder.Entity<_bak_sysParameter>(entity =>
        {
            entity.HasKey(e => e.ParameterCode).HasName("PK_sysParameter");

            entity.Property(e => e.ParameterValue).HasDefaultValue("", "DF_sysParamater_ParameterValue");
        });

        modelBuilder.Entity<_bak_sysParameterPerSite>(entity =>
        {
            entity.HasKey(e => new { e.ParameterCode, e.SiteCode }).HasName("PK_sysParameterPerSite");

            entity.Property(e => e.ParameterValue).HasDefaultValue("", "DF_sysParameterPerSite_ParameterValue");
        });

        modelBuilder.Entity<_bak_sysUser>(entity =>
        {
            entity.HasKey(e => e.UserName).HasName("PK_sysUser");
        });

        modelBuilder.Entity<_bak_sysUserInServiceUnit>(entity =>
        {
            entity.HasKey(e => new { e.SiteCode, e.UserId, e.ServiceUnitID }).HasName("PK_sysUserInServiceUnit_1");

            entity.Property(e => e.ServiceUnitID).HasComment("Link ke DepartmentServiceUnit");
        });

        modelBuilder.Entity<aspnet_Applications>(entity =>
        {
            entity.HasKey(e => e.ApplicationId)
                .HasName("PK__aspnet_A__C93A4C980F975522")
                .IsClustered(false);

            entity.HasIndex(e => e.LoweredApplicationName, "aspnet_Applications_Index").IsClustered();

            entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<aspnet_Membership>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK__aspnet_M__1788CC4D68487DD7")
                .IsClustered(false);

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail }, "aspnet_Membership_index").IsClustered();

            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.HasOne(d => d.Application).WithMany(p => p.aspnet_Membership)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Me__Appli__6FB49575");

            entity.HasOne(d => d.User).WithOne(p => p.aspnet_Membership)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Me__UserI__70A8B9AE");
        });

        modelBuilder.Entity<aspnet_Paths>(entity =>
        {
            entity.HasKey(e => e.PathId)
                .HasName("PK__aspnet_P__CD67DC585DCAEF64")
                .IsClustered(false);

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath }, "aspnet_Paths_index")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Application).WithMany(p => p.aspnet_Paths)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pa__Appli__6DCC4D03");
        });

        modelBuilder.Entity<aspnet_PersonalizationAllUsers>(entity =>
        {
            entity.HasKey(e => e.PathId).HasName("PK__aspnet_P__CD67DC596C190EBB");

            entity.Property(e => e.PathId).ValueGeneratedNever();

            entity.HasOne(d => d.Path).WithOne(p => p.aspnet_PersonalizationAllUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pe__PathI__719CDDE7");
        });

        modelBuilder.Entity<aspnet_PersonalizationPerUser>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK__aspnet_P__3214EC066FE99F9F")
                .IsClustered(false);

            entity.HasIndex(e => new { e.PathId, e.UserId }, "aspnet_PersonalizationPerUser_index1")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Path).WithMany(p => p.aspnet_PersonalizationPerUser).HasConstraintName("FK__aspnet_Pe__PathI__72910220");

            entity.HasOne(d => d.User).WithMany(p => p.aspnet_PersonalizationPerUser).HasConstraintName("FK__aspnet_Pe__UserI__73852659");
        });

        modelBuilder.Entity<aspnet_Profile>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__aspnet_P__1788CC4C73BA3083");

            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithOne(p => p.aspnet_Profile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pr__UserI__74794A92");
        });

        modelBuilder.Entity<aspnet_Roles>(entity =>
        {
            entity.HasKey(e => e.RoleId)
                .HasName("PK__aspnet_R__8AFACE1B619B8048")
                .IsClustered(false);

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName }, "aspnet_Roles_index1")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Application).WithMany(p => p.aspnet_Roles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Ro__Appli__6EC0713C");
        });

        modelBuilder.Entity<aspnet_SchemaVersions>(entity =>
        {
            entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion }).HasName("PK__aspnet_S__5A1E6BC115502E78");
        });

        modelBuilder.Entity<aspnet_Users>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK__aspnet_U__1788CC4D571DF1D5")
                .IsClustered(false);

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName }, "aspnet_Users_Index")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.MobileAlias).HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.Application).WithMany(p => p.aspnet_Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Us__Appli__6CD828CA");

            entity.HasMany(d => d.Role).WithMany(p => p.User)
                .UsingEntity<Dictionary<string, object>>(
                    "aspnet_UsersInRoles",
                    r => r.HasOne<aspnet_Roles>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__aspnet_Us__RoleI__756D6ECB"),
                    l => l.HasOne<aspnet_Users>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__aspnet_Us__UserI__76619304"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK__aspnet_U__AF2760AD7A672E12");
                        j.HasIndex(new[] { "RoleId" }, "aspnet_UsersInRoles_index");
                    });
        });

        modelBuilder.Entity<aspnet_WebEvent_Events>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__aspnet_W__7944C8103F466844");

            entity.Property(e => e.EventId).IsFixedLength();
        });

        modelBuilder.Entity<sysAutoPageItem>(entity =>
        {
            entity.Property(e => e.FieldName).HasComment("Nama field hasil query");
            entity.Property(e => e.GridColumnSortExp).HasComment("Diisi bila Field disusun dari beberapa field (Composite Field)");
            entity.Property(e => e.IsFilterAvailable).HasDefaultValue(true, "DF_sysAutoPageItem_IsFilterAvailable");
            entity.Property(e => e.SourceFieldName).HasComment("Diisi nama field bila nama alias berbeda dgn nama field");
        });

        modelBuilder.Entity<sysGroupRole>(entity =>
        {
            entity.Property(e => e.GroupRoleCode).HasDefaultValueSql("(newid())", "DF_sysGroupRole_RoleId");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_sysGroupRole_IsActive");
        });

        modelBuilder.Entity<sysMenu>(entity =>
        {
            entity.Property(e => e.CRUDMode).HasDefaultValue("C,R,U,D", "DF_sysMenu_CRUDMode");
            entity.Property(e => e.GCMenuType).HasDefaultValue("Entry", "DF_sysMenu_GCMenuType");
            entity.Property(e => e.HelpLinkID).HasDefaultValue("", "DF_sysMenu_HelpLinkIDForList");
            entity.Property(e => e.ImageUrl).HasDefaultValue("", "DF_sysMenu_ImageUrl");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_sysMenu_IsActive");
            entity.Property(e => e.IsShownInMenu).HasDefaultValue(true, "DF_sysMenu_IsShownInMenu");
            entity.Property(e => e.MenuIndex).HasDefaultValueSql("('000')", "DF_sysMenu_MenuIndex");
            entity.Property(e => e.MenuTooltip).HasDefaultValue("", "DF_sysMenu_MenuTooltip");
        });

        modelBuilder.Entity<sysMenuEntryMode>(entity =>
        {
            entity.HasKey(e => new { e.SiteCode, e.UserID, e.RoleId, e.MenuID }).HasName("PK_sysMenuAddMode");

            entity.HasOne(d => d.Menu).WithMany(p => p.sysMenuEntryMode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysMenuEntryMode_sysMenu");

            entity.HasOne(d => d.Role).WithMany(p => p.sysMenuEntryMode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysMenuEntryMode_aspnet_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.sysMenuEntryMode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysMenuEntryMode_aspnet_Users");
        });

        modelBuilder.Entity<sysMenuFavorite>(entity =>
        {
            entity.HasOne(d => d.Menu).WithMany(p => p.sysMenuFavorite)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysMenuFavorite_sysMenu");

            entity.HasOne(d => d.User).WithMany(p => p.sysMenuFavorite)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysMenuFavorite_aspnet_Users");
        });

        modelBuilder.Entity<sysMenuInRole>(entity =>
        {
            entity.HasOne(d => d.Menu).WithMany(p => p.sysMenuInRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysMenuInRole_sysMenu1");

            entity.HasOne(d => d.Role).WithMany(p => p.sysMenuInRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysMenuInRole_aspnet_Roles1");
        });

        modelBuilder.Entity<sysMenuInUser>(entity =>
        {
            entity.HasIndex(e => e.UserID, "IX_sysMenuInUser_UserID").HasFillFactor(60);

            entity.HasOne(d => d.Menu).WithMany(p => p.sysMenuInUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysMenuInUser_sysMenu1");

            entity.HasOne(d => d.User).WithMany(p => p.sysMenuInUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysMenuInUser_aspnet_Users1");
        });

        modelBuilder.Entity<sysMenuRelated>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_sysMenuRelated_IsActive");
        });

        modelBuilder.Entity<sysMessage>(entity =>
        {
            entity.Property(e => e.GCMessageType).IsFixedLength();
        });

        modelBuilder.Entity<sysMessageTemp>(entity =>
        {
            entity.Property(e => e.GCMessageType).IsFixedLength();
        });

        modelBuilder.Entity<sysModule>(entity =>
        {
            entity.Property(e => e.DefaultUrl).HasDefaultValue("", "DF_sysModule_DefaultUrl");
            entity.Property(e => e.DisabledImageUrl).HasDefaultValue("", "DF_sysModule_DisabledImageUrl");
            entity.Property(e => e.ImageUrl).HasDefaultValue("", "DF_sysModule_ImageUrl");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_sysModule_IsActive");
            entity.Property(e => e.ModuleShortName).HasDefaultValue("", "DF_sysModule_ModuleShortName");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_sysModule_Description");
            entity.Property(e => e.ToolTip).HasDefaultValue("", "DF_sysModule_ToolTip");
        });

        modelBuilder.Entity<sysModuleDt>(entity =>
        {
            entity.Property(e => e.DefaultUrl).HasDefaultValue("", "DF_sysModuleDt_DefaultUrl");
            entity.Property(e => e.DisabledImageUrl).HasDefaultValue("", "DF_sysModuleDt_DisabledImageUrl");
            entity.Property(e => e.ImageUrl).HasDefaultValue("", "DF_sysModuleDt_ImageUrl");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_sysModuleDt_IsActive");
            entity.Property(e => e.ModuleShortName).HasDefaultValue("", "DF_sysModuleDt_ModuleShortName");
            entity.Property(e => e.Remarks).HasDefaultValue("", "DF_sysModuleDt_Remarks");
            entity.Property(e => e.ToolTip).HasDefaultValue("", "DF_sysModuleDt_ToolTip");
        });

        modelBuilder.Entity<sysReport>(entity =>
        {
            entity.Property(e => e.IndexNo).HasDefaultValue(0, "DF_sysReport_IndexNo");

            entity.HasOne(d => d.Menu).WithOne(p => p.sysReport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysReport_sysMenu");
        });

        modelBuilder.Entity<sysReportParameter>(entity =>
        {
            entity.Property(e => e.CaptionOrMessage).HasDefaultValue("", "DF_sysReportParameter_ParameterCaption");
        });

        modelBuilder.Entity<sysReportPivot>(entity =>
        {
            entity.Property(e => e.FormatString).HasDefaultValue("", "DF_sysReportPivot_CellFormatFormatString");
            entity.Property(e => e.SummaryType).HasDefaultValue(1, "DF_sysReportPivot_SummaryType");
        });

        modelBuilder.Entity<sysRoleInGroupRole>(entity =>
        {
            entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())", "DF_sysRoleInGroupRole_RoleId");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_sysRoleInGroupRole_IsActive");

            entity.HasOne(d => d.GroupRoleCodeNavigation).WithMany(p => p.sysRoleInGroupRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysRoleInGroupRole_sysGroupRole");

            entity.HasOne(d => d.Role).WithOne(p => p.sysRoleInGroupRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysRoleInGroupRole_sysRoles");
        });

        modelBuilder.Entity<sysRolePersonalization>(entity =>
        {
            entity.Property(e => e.RoleID).ValueGeneratedNever();

            entity.HasOne(d => d.Role).WithOne(p => p.sysRolePersonalization)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sysRolePersonalization_aspnet_Roles1");
        });

        modelBuilder.Entity<sysRoles>(entity =>
        {
            entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())", "DF_sysRoles_RoleId");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_sysRoles_IsActive");
            entity.Property(e => e.RoleShortID)
                .ValueGeneratedOnAdd()
                .HasComment("Untuk keperluan penamaan checkbox pada entry User Profiles");
        });

        modelBuilder.Entity<sysServiceUnitInRole>(entity =>
        {
            entity.Property(e => e.ServiceUnitCode).HasComment("Link ke DepartmentServiceUnit");
        });

        modelBuilder.Entity<sysServiceUnitInUser>(entity =>
        {
            entity.Property(e => e.ServiceUnitID).HasComment("Link ke DepartmentServiceUnit");
        });

        modelBuilder.Entity<sysSite>(entity =>
        {
            entity.Property(e => e.Gmt).HasComment("Greenwich Mean Time");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_sysSite_IsActive");
            entity.Property(e => e.LicenseNo).HasDefaultValue("", "DF_sysSite_LicenseNo");
            entity.Property(e => e.ShortName).HasDefaultValue("", "DF_sysSite_ShortName");
        });

        modelBuilder.Entity<vw_aspnet_Applications>(entity =>
        {
            entity.ToView("vw_aspnet_Applications");
        });

        modelBuilder.Entity<vw_aspnet_MembershipUsers>(entity =>
        {
            entity.ToView("vw_aspnet_MembershipUsers");
        });

        modelBuilder.Entity<vw_aspnet_Profiles>(entity =>
        {
            entity.ToView("vw_aspnet_Profiles");
        });

        modelBuilder.Entity<vw_aspnet_Roles>(entity =>
        {
            entity.ToView("vw_aspnet_Roles");
        });

        modelBuilder.Entity<vw_aspnet_Users>(entity =>
        {
            entity.ToView("vw_aspnet_Users");
        });

        modelBuilder.Entity<vw_aspnet_UsersInRoles>(entity =>
        {
            entity.ToView("vw_aspnet_UsersInRoles");
        });

        modelBuilder.Entity<vw_aspnet_WebPartState_Paths>(entity =>
        {
            entity.ToView("vw_aspnet_WebPartState_Paths");
        });

        modelBuilder.Entity<vw_aspnet_WebPartState_Shared>(entity =>
        {
            entity.ToView("vw_aspnet_WebPartState_Shared");
        });

        modelBuilder.Entity<vw_aspnet_WebPartState_User>(entity =>
        {
            entity.ToView("vw_aspnet_WebPartState_User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
