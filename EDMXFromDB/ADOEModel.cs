namespace EDMXFromDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;


    //See we have DbContect class. Create DbSets of the entities. 
     
    public partial class ADOEModel : DbContext
    {
        public ADOEModel()
            : base("name=ADOEModel")
        {
        }

        public virtual DbSet<ZDemoRole> ZDemoRoles { get; set; }
        public virtual DbSet<ZDemoUser> ZDemoUsers { get; set; }
        public virtual DbSet<ZDemoUserRole> ZDemoUserRoles { get; set; }
        /*
        public virtual DbSet<AccountAlertDef> AccountAlertDefs { get; set; }
        public virtual DbSet<AccountClassDef> AccountClassDefs { get; set; }
        public virtual DbSet<AccountDocumentChanx> AccountDocumentChanges { get; set; }
        public virtual DbSet<AccountDocument> AccountDocuments { get; set; }
        public virtual DbSet<AccountMemo> AccountMemos { get; set; }
        public virtual DbSet<AccountPhoneNumber> AccountPhoneNumbers { get; set; }
        public virtual DbSet<AccountRate> AccountRates { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<AdminManagement> AdminManagements { get; set; }
        public virtual DbSet<AdminSetting> AdminSettings { get; set; }
        public virtual DbSet<ApiLog> ApiLogs { get; set; }
        public virtual DbSet<AutoTaskRule> AutoTaskRules { get; set; }
        public virtual DbSet<BillingGroup> BillingGroups { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<Chemical> Chemicals { get; set; }
        public virtual DbSet<ChemicalDetail> ChemicalDetails { get; set; }
        public virtual DbSet<Commission> Commissions { get; set; }
        public virtual DbSet<CommissionType> CommissionTypes { get; set; }
        public virtual DbSet<Condition> Conditions { get; set; }
        public virtual DbSet<CustomViewColumn> CustomViewColumns { get; set; }
        public virtual DbSet<CustomViewRestriction> CustomViewRestrictions { get; set; }
        public virtual DbSet<CustomView> CustomViews { get; set; }
        public virtual DbSet<ELMAH_Error> ELMAH_Error { get; set; }
        public virtual DbSet<EmailCampaign> EmailCampaigns { get; set; }
        public virtual DbSet<EmailTemplateInsert> EmailTemplateInserts { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<EquipmentAttribute> EquipmentAttributes { get; set; }
        public virtual DbSet<EquipmentAttributeTypeChoice> EquipmentAttributeTypeChoices { get; set; }
        public virtual DbSet<EquipmentAttributeType> EquipmentAttributeTypes { get; set; }
        public virtual DbSet<EquipmentManufacturer> EquipmentManufacturers { get; set; }
        public virtual DbSet<EquipmentModel> EquipmentModels { get; set; }
        public virtual DbSet<EquipmentType> EquipmentTypes { get; set; }
        public virtual DbSet<EstimateLineItem> EstimateLineItems { get; set; }
        public virtual DbSet<Estimate> Estimates { get; set; }
        public virtual DbSet<FeedbackRespons> FeedbackResponses { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Finish> Finishes { get; set; }
        public virtual DbSet<Ideal> Ideals { get; set; }
        public virtual DbSet<ImportedPayment> ImportedPayments { get; set; }
        public virtual DbSet<InterfaceException> InterfaceExceptions { get; set; }
        public virtual DbSet<InterfaceSetting> InterfaceSettings { get; set; }
        public virtual DbSet<INVENTORY> INVENTORies { get; set; }
        public virtual DbSet<InventoryCategory> InventoryCategories { get; set; }
        public virtual DbSet<InventoryDepartment> InventoryDepartments { get; set; }
        public virtual DbSet<InventoryIcon> InventoryIcons { get; set; }
        public virtual DbSet<InventoryItemLog> InventoryItemLogs { get; set; }
        public virtual DbSet<InventoryItem> InventoryItems { get; set; }
        public virtual DbSet<InventoryLocationItem> InventoryLocationItems { get; set; }
        public virtual DbSet<InventoryLocation> InventoryLocations { get; set; }
        public virtual DbSet<InventoryPurchaseOrderItem> InventoryPurchaseOrderItems { get; set; }
        public virtual DbSet<InventoryPurchaseOrder> InventoryPurchaseOrders { get; set; }
        public virtual DbSet<InventorySupplierItem> InventorySupplierItems { get; set; }
        public virtual DbSet<InventorySupplierPhoneNumber> InventorySupplierPhoneNumbers { get; set; }
        public virtual DbSet<InventorySupplier> InventorySuppliers { get; set; }
        public virtual DbSet<LaborEstimate> LaborEstimates { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MeasureDetail> MeasureDetails { get; set; }
        public virtual DbSet<Measure> Measures { get; set; }
        public virtual DbSet<MeasureType> MeasureTypes { get; set; }
        public virtual DbSet<OfficeAlert> OfficeAlerts { get; set; }
        public virtual DbSet<OfficePhoneNumber> OfficePhoneNumbers { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<OneLetterCode> OneLetterCodes { get; set; }
        public virtual DbSet<PageRequestLog> PageRequestLogs { get; set; }
        public virtual DbSet<PaymentAuthorization> PaymentAuthorizations { get; set; }
        public virtual DbSet<PaymentInfo> PaymentInfoes { get; set; }
        public virtual DbSet<PaymentTerm> PaymentTerms { get; set; }
        public virtual DbSet<PCPVerDetail> PCPVerDetails { get; set; }
        public virtual DbSet<PCPVersion> PCPVersions { get; set; }
        public virtual DbSet<Pdftemplate> Pdftemplates { get; set; }
        public virtual DbSet<PendingOnlinePayment> PendingOnlinePayments { get; set; }
        public virtual DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }
        public virtual DbSet<PoolEquipment> PoolEquipments { get; set; }
        public virtual DbSet<QuickBooksAccount> QuickBooksAccounts { get; set; }
        public virtual DbSet<QuickBooksAccountsTranCode> QuickBooksAccountsTranCodes { get; set; }
        public virtual DbSet<RateDetail> RateDetails { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<RecentlyAccessedRecord> RecentlyAccessedRecords { get; set; }
        public virtual DbSet<RecurringPayment> RecurringPayments { get; set; }
        public virtual DbSet<RecurringService> RecurringServices { get; set; }
        public virtual DbSet<ReferralType> ReferralTypes { get; set; }
        public virtual DbSet<Repair> Repairs { get; set; }
        public virtual DbSet<RepairTechAvailability> RepairTechAvailabilities { get; set; }
        public virtual DbSet<RepairVisit> RepairVisits { get; set; }
        public virtual DbSet<ReportParameter> ReportParameters { get; set; }
        public virtual DbSet<ReportParameterSavedValue> ReportParameterSavedValues { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SalesTax> SalesTaxes { get; set; }
        public virtual DbSet<SalesTaxGroupMember> SalesTaxGroupMembers { get; set; }
        public virtual DbSet<SaltChlorinator> SaltChlorinators { get; set; }
        public virtual DbSet<SaltChlorinatorIdeal> SaltChlorinatorIdeals { get; set; }
        public virtual DbSet<ScheduledServiceChecklistItem> ScheduledServiceChecklistItems { get; set; }
        public virtual DbSet<ScheduledService> ScheduledServices { get; set; }
        public virtual DbSet<ScheduledTask> ScheduledTasks { get; set; }
        public virtual DbSet<ServiceCommissionRule> ServiceCommissionRules { get; set; }
        public virtual DbSet<ServiceDefChecklistItem> ServiceDefChecklistItems { get; set; }
        public virtual DbSet<ServiceDef> ServiceDefs { get; set; }
        public virtual DbSet<ServiceLog> ServiceLogs { get; set; }
        public virtual DbSet<ServicePhoto> ServicePhotoes { get; set; }
        public virtual DbSet<ServiceWindowDef> ServiceWindowDefs { get; set; }
        public virtual DbSet<SiteOptimalRoute> SiteOptimalRoutes { get; set; }
        public virtual DbSet<SitePhoto> SitePhotos { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<StandardizationCode> StandardizationCodes { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Sync> Syncs { get; set; }
        public virtual DbSet<SyncSendingQueue> SyncSendingQueues { get; set; }
        public virtual DbSet<SyncWith> SyncWiths { get; set; }
        public virtual DbSet<SystemSettingDef> SystemSettingDefs { get; set; }
        public virtual DbSet<SystemSetting> SystemSettings { get; set; }
        public virtual DbSet<TaskDef> TaskDefs { get; set; }
        public virtual DbSet<TaskLog> TaskLogs { get; set; }
        public virtual DbSet<TerminationType> TerminationTypes { get; set; }
        public virtual DbSet<TranCodeGroup> TranCodeGroups { get; set; }
        public virtual DbSet<TranCode> TranCodes { get; set; }
        public virtual DbSet<TransactionBatch> TransactionBatches { get; set; }
        public virtual DbSet<TransactionCCDetail> TransactionCCDetails { get; set; }
        public virtual DbSet<TransactionCCRecurringPaymentDef> TransactionCCRecurringPaymentDefs { get; set; }
        public virtual DbSet<TransactionDetail> TransactionDetails { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TransferInfo> TransferInfoes { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }
        public virtual DbSet<TreatmentType> TreatmentTypes { get; set; }
        public virtual DbSet<UserDefinedAccountDef> UserDefinedAccountDefs { get; set; }
        public virtual DbSet<UserDefinedAccountInfo> UserDefinedAccountInfoes { get; set; }
        public virtual DbSet<UserDefinedSiteDef> UserDefinedSiteDefs { get; set; }
        public virtual DbSet<UserDefinedSiteInfo> UserDefinedSiteInfoes { get; set; }
        public virtual DbSet<UserGeoLocationLog> UserGeoLocationLogs { get; set; }
        public virtual DbSet<UserGroupRole> UserGroupRoles { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UserGroupUser> UserGroupUsers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSetting> UserSettings { get; set; }
        
        public virtual DbSet<AccountPhoneNumbers_bk> AccountPhoneNumbers_bk { get; set; }
        public virtual DbSet<Accounts_151> Accounts_151 { get; set; }
        public virtual DbSet<Accounts_217> Accounts_217 { get; set; }
        public virtual DbSet<Accounts_252> Accounts_252 { get; set; }
        public virtual DbSet<Addresses_151> Addresses_151 { get; set; }
        public virtual DbSet<Addresses_217> Addresses_217 { get; set; }
        public virtual DbSet<Addresses_226> Addresses_226 { get; set; }
        public virtual DbSet<Addresses_252> Addresses_252 { get; set; }
        public virtual DbSet<AddressesPools_151> AddressesPools_151 { get; set; }
        public virtual DbSet<AddressesPools_217> AddressesPools_217 { get; set; }
        public virtual DbSet<AddressesPools_252> AddressesPools_252 { get; set; }
        public virtual DbSet<Analysis> Analyses { get; set; }
        public virtual DbSet<AnalysisDetail> AnalysisDetails { get; set; }
        public virtual DbSet<CognosOwnerStoreInfo> CognosOwnerStoreInfoes { get; set; }
        public virtual DbSet<customer_151> customer_151 { get; set; }
        public virtual DbSet<customer_252> customer_252 { get; set; }
        public virtual DbSet<Equipment_151> Equipment_151 { get; set; }
        public virtual DbSet<Equipment_217> Equipment_217 { get; set; }
        public virtual DbSet<Equipment_252> Equipment_252 { get; set; }
        public virtual DbSet<LinePrinterDetailField> LinePrinterDetailFields { get; set; }
        public virtual DbSet<LinePrinterHeaderField> LinePrinterHeaderFields { get; set; }
        public virtual DbSet<LinePrinterReportDetail> LinePrinterReportDetails { get; set; }
        public virtual DbSet<LinePrinterReportHeader> LinePrinterReportHeaders { get; set; }
        public virtual DbSet<LinePrinterReport> LinePrinterReports { get; set; }
        public virtual DbSet<MemoLetter> MemoLetters { get; set; }
        public virtual DbSet<MonthTotalInventoryCount> MonthTotalInventoryCounts { get; set; }
        public virtual DbSet<MonthTotalRateCount> MonthTotalRateCounts { get; set; }
        public virtual DbSet<MonthTotalReferralCount> MonthTotalReferralCounts { get; set; }
        public virtual DbSet<MonthTotal> MonthTotals { get; set; }
        public virtual DbSet<MonthTotalsPerTranCode> MonthTotalsPerTranCodes { get; set; }
        public virtual DbSet<MonthTotalTerminationCount> MonthTotalTerminationCounts { get; set; }
        public virtual DbSet<PCP_FA> PCP_FA { get; set; }
        public virtual DbSet<PCP_FA_JDE> PCP_FA_JDE { get; set; }
        public virtual DbSet<PoolEquipment_09092020> PoolEquipment_09092020 { get; set; }
        public virtual DbSet<PoolEquipment_151> PoolEquipment_151 { get; set; }
        public virtual DbSet<PoolEquipment_252> PoolEquipment_252 { get; set; }
        public virtual DbSet<Pools_151> Pools_151 { get; set; }
        public virtual DbSet<Pools_217> Pools_217 { get; set; }
        public virtual DbSet<Pools_252> Pools_252 { get; set; }
        public virtual DbSet<Reccommendation> Reccommendations { get; set; }
        public virtual DbSet<RecommendedIdeal> RecommendedIdeals { get; set; }
        public virtual DbSet<Sites_217> Sites_217 { get; set; }
        public virtual DbSet<TipsBank> TipsBanks { get; set; }
        public virtual DbSet<Tran_Del_Save> Tran_Del_Save { get; set; }
        public virtual DbSet<TransactionCCDetails_Deleted> TransactionCCDetails_Deleted { get; set; }
        public virtual DbSet<TransactionDetails_Deleted> TransactionDetails_Deleted { get; set; }
        public virtual DbSet<Transactions_Deleted> Transactions_Deleted { get; set; }
        public virtual DbSet<UserRoleOverride> UserRoleOverrides { get; set; }
        public virtual DbSet<AccountsAgingAdjusted> AccountsAgingAdjusteds { get; set; }
        public virtual DbSet<Pool> Pools { get; set; }
        public virtual DbSet<UserDefinedPoolDef> UserDefinedPoolDefs { get; set; }
        public virtual DbSet<UserDefinedPoolInfo> UserDefinedPoolInfoes { get; set; }
        */

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*Here we can see some contraint with some property like 
             * IsFixedLength
             * WillCascadeOnDelete
             * 
             */

            /*This called Fluent configuration which is present here in DbContext class. 
             * In addition to this for property we can have data annotation as well
             * Which we can apply in class which is generated(infer) from DB.
             */

            modelBuilder.Entity<ZDemoRole>()
                .Property(e => e.RoleDescription)
                .IsFixedLength();

            modelBuilder.Entity<ZDemoRole>()
                .HasMany(e => e.ZDemoUserRoles)
                .WithRequired(e => e.ZDemoRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ZDemoUser>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<ZDemoUser>()
                .Property(e => e.Pwd)
                .IsFixedLength();

            modelBuilder.Entity<ZDemoUser>()
                .HasMany(e => e.ZDemoUserRoles)
                .WithRequired(e => e.ZDemoUser)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);


            /*

            modelBuilder.Entity<AccountAlertDef>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<AccountAlertDef>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AccountClassDef>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<AccountClassDef>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AccountDocument>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AccountDocument>()
                .Property(e => e.FileLocation)
                .IsUnicode(false);

            modelBuilder.Entity<AccountDocument>()
                .Property(e => e.OriginalFileName)
                .IsUnicode(false);

            modelBuilder.Entity<AccountDocument>()
                .HasMany(e => e.AccountDocumentChanges)
                .WithRequired(e => e.AccountDocument)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccountMemo>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<AccountMemo>()
                .Property(e => e.MemoType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AccountMemo>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<AccountPhoneNumber>()
                .Property(e => e.PhoneNumberType)
                .IsUnicode(false);

            modelBuilder.Entity<AccountPhoneNumber>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<AccountPhoneNumber>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<AccountPhoneNumber>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<AccountPhoneNumber>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AccountPhoneNumber>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Account>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.ReferralInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.TerminationInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Account>()
                .Property(e => e.AccountType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.PasswordQuestion)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.PasswordAnswer)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.AgingCurrent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Account>()
                .Property(e => e.Aging30)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Account>()
                .Property(e => e.Aging60)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Account>()
                .Property(e => e.Aging90)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Account>()
                .Property(e => e.AgingCR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Account>()
                .Property(e => e.AccountAlertText)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.AccountDocuments)
                .WithOptional(e => e.Account)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Account>()
                .HasMany(e => e.AccountMemos)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.AccountPhoneNumbers)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.AccountRates)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Estimates)
                .WithOptional(e => e.Account)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Account>()
                .HasMany(e => e.PaymentAuthorizations)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.RecurringPayments)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.ScheduledTasks)
                .WithOptional(e => e.Account)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Sites)
                .WithOptional(e => e.Account)
                .HasForeignKey(e => e.AccountId);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Sites1)
                .WithOptional(e => e.Account1)
                .HasForeignKey(e => e.MgrAccountId);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.TransactionCCDetails)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.TransactionCCRecurringPaymentDefs)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.AddressType)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.StandardizationCode)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Address>()
                .Property(e => e.ZipBarCode)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Sites)
                .WithRequired(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.AdminName)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.HashedPassword)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.PasswordHint)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .HasMany(e => e.AdminManagements)
                .WithRequired(e => e.Administrator)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminSetting>()
                .Property(e => e.SettingName)
                .IsUnicode(false);

            modelBuilder.Entity<AdminSetting>()
                .Property(e => e.SettingData)
                .IsUnicode(false);

            modelBuilder.Entity<AdminSetting>()
                .Property(e => e.LargeData)
                .IsUnicode(false);

            modelBuilder.Entity<AutoTaskRule>()
                .Property(e => e.ActionType)
                .IsUnicode(false);

            modelBuilder.Entity<AutoTaskRule>()
                .Property(e => e.ActionParams)
                .IsUnicode(false);

            modelBuilder.Entity<AutoTaskRule>()
                .Property(e => e.TaskComments)
                .IsUnicode(false);

            modelBuilder.Entity<BillingGroup>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<BillingGroup>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.BillingGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Campaign>()
                .HasMany(e => e.EmailCampaigns)
                .WithRequired(e => e.Campaign)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Chemical>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Chemical>()
                .Property(e => e.ChemicalForm)
                .IsUnicode(false);

            modelBuilder.Entity<Chemical>()
                .Property(e => e.dbTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<ChemicalDetail>()
                .Property(e => e.ChemicalType)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalDetail>()
                .Property(e => e.StructureType)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalDetail>()
                .Property(e => e.ChemicalAmount)
                .HasPrecision(18, 10);

            modelBuilder.Entity<ChemicalDetail>()
                .Property(e => e.ChemicalUOM)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalDetail>()
                .Property(e => e.WaterAmount)
                .HasPrecision(18, 10);

            modelBuilder.Entity<ChemicalDetail>()
                .Property(e => e.WaterUOM)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalDetail>()
                .Property(e => e.ConditionAmount)
                .HasPrecision(18, 10);

            modelBuilder.Entity<ChemicalDetail>()
                .Property(e => e.MinAmount)
                .HasPrecision(18, 10);

            modelBuilder.Entity<ChemicalDetail>()
                .Property(e => e.EnglishInst)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalDetail>()
                .Property(e => e.SpanishInst)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalDetail>()
                .Property(e => e.dbTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<ChemicalDetail>()
                .Property(e => e.Dosage)
                .IsUnicode(false);

            modelBuilder.Entity<Commission>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Commission>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<CommissionType>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<CommissionType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CommissionType>()
                .HasMany(e => e.Commissions)
                .WithRequired(e => e.CommissionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CommissionType>()
                .HasMany(e => e.ServiceCommissionRules)
                .WithRequired(e => e.CommissionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Condition>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Condition>()
                .Property(e => e.TestName)
                .IsUnicode(false);

            modelBuilder.Entity<Condition>()
                .Property(e => e.Step)
                .HasPrecision(18, 1);

            modelBuilder.Entity<Condition>()
                .Property(e => e.Measurement)
                .IsUnicode(false);

            modelBuilder.Entity<Condition>()
                .Property(e => e.dbTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<CustomViewColumn>()
                .Property(e => e.ColumnName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomViewRestriction>()
                .Property(e => e.ColumnName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomViewRestriction>()
                .Property(e => e.Comparator)
                .IsUnicode(false);

            modelBuilder.Entity<CustomViewRestriction>()
                .Property(e => e.CompareValue)
                .IsUnicode(false);

            modelBuilder.Entity<CustomView>()
                .Property(e => e.RowFilter)
                .IsUnicode(false);

            modelBuilder.Entity<CustomView>()
                .Property(e => e.LargeRowFilter)
                .IsUnicode(false);

            modelBuilder.Entity<CustomView>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CustomView>()
                .Property(e => e.FormName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomView>()
                .Property(e => e.ControlName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomView>()
                .HasMany(e => e.CustomViewColumns)
                .WithRequired(e => e.CustomView)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomView>()
                .HasMany(e => e.CustomViewRestrictions)
                .WithRequired(e => e.CustomView)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmailTemplateInsert>()
                .Property(e => e.InsertName)
                .IsUnicode(false);

            modelBuilder.Entity<EmailTemplateInsert>()
                .Property(e => e.InsertText)
                .IsUnicode(false);

            modelBuilder.Entity<EmailTemplate>()
                .Property(e => e.EmailEvent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmailTemplate>()
                .Property(e => e.TemplateName)
                .IsUnicode(false);

            modelBuilder.Entity<EmailTemplate>()
                .Property(e => e.EmailBCC)
                .IsUnicode(false);

            modelBuilder.Entity<EmailTemplate>()
                .Property(e => e.EmailSubject)
                .IsUnicode(false);

            modelBuilder.Entity<EmailTemplate>()
                .Property(e => e.EmailBody)
                .IsUnicode(false);

            modelBuilder.Entity<EmailTemplate>()
                .HasMany(e => e.EmailCampaigns)
                .WithRequired(e => e.EmailTemplate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.SerialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.PartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.LargeNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Equipment>()
                .HasMany(e => e.Equipment1)
                .WithOptional(e => e.Equipment2)
                .HasForeignKey(e => e.ParentEquipmentId);

            modelBuilder.Entity<EquipmentAttribute>()
                .Property(e => e.AttributeData)
                .IsUnicode(false);

            modelBuilder.Entity<EquipmentAttribute>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<EquipmentAttributeTypeChoice>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EquipmentAttributeType>()
                .Property(e => e.AttributeChoiceStyle)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EquipmentAttributeType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EquipmentAttributeType>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<EquipmentManufacturer>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EquipmentManufacturer>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<EquipmentModel>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EquipmentModel>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<EquipmentType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EquipmentType>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<EquipmentType>()
                .HasMany(e => e.Equipments)
                .WithRequired(e => e.EquipmentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EquipmentType>()
                .HasMany(e => e.EquipmentModels)
                .WithRequired(e => e.EquipmentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstimateLineItem>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EstimateLineItem>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EstimateLineItem>()
                .Property(e => e.Details)
                .IsUnicode(false);

            modelBuilder.Entity<EstimateLineItem>()
                .Property(e => e.SerialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Estimate>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Estimate>()
                .Property(e => e.EstimateNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Estimate>()
                .Property(e => e.Details)
                .IsUnicode(false);

            modelBuilder.Entity<Estimate>()
                .Property(e => e.TermsAndConditions)
                .IsUnicode(false);

            modelBuilder.Entity<Estimate>()
                .Property(e => e.InvoiceNumber)
                .IsUnicode(false);

            modelBuilder.Entity<FeedbackRespons>()
                .Property(e => e.Response)
                .IsUnicode(false);

            modelBuilder.Entity<FeedbackRespons>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.MessageType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<Finish>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Finish>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Finish>()
                .Property(e => e.StructureType)
                .IsUnicode(false);

            modelBuilder.Entity<Finish>()
                .Property(e => e.dbTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<Ideal>()
                .Property(e => e.StructureType)
                .IsUnicode(false);

            modelBuilder.Entity<Ideal>()
                .Property(e => e.Min)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Ideal>()
                .Property(e => e.Max)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Ideal>()
                .Property(e => e.Ideal1)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Ideal>()
                .Property(e => e.dbTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<ImportedPayment>()
                .Property(e => e.ImportSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ImportedPayment>()
                .Property(e => e.PaymentType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ImportedPayment>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ImportedPayment>()
                .Property(e => e.PaymentSurcharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ImportedPayment>()
                .Property(e => e.TranReference)
                .IsUnicode(false);

            modelBuilder.Entity<ImportedPayment>()
                .Property(e => e.PaymentReference)
                .IsUnicode(false);

            modelBuilder.Entity<ImportedPayment>()
                .Property(e => e.AccountCode)
                .IsUnicode(false);

            modelBuilder.Entity<ImportedPayment>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<ImportedPayment>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<InterfaceException>()
                .Property(e => e.ErrorCode)
                .IsUnicode(false);

            modelBuilder.Entity<InterfaceException>()
                .Property(e => e.ErrorMessage)
                .IsUnicode(false);

            modelBuilder.Entity<InterfaceSetting>()
                .Property(e => e.Interface)
                .IsUnicode(false);

            modelBuilder.Entity<InterfaceSetting>()
                .Property(e => e.SettingType)
                .IsUnicode(false);

            modelBuilder.Entity<InterfaceSetting>()
                .Property(e => e.SettingName)
                .IsUnicode(false);

            modelBuilder.Entity<InterfaceSetting>()
                .Property(e => e.SettingValue)
                .IsUnicode(false);

            modelBuilder.Entity<InterfaceSetting>()
                .Property(e => e.SettingLargeValue)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryCategory>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryDepartment>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryDepartment>()
                .HasMany(e => e.InventoryCategories)
                .WithRequired(e => e.InventoryDepartment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InventoryDepartment>()
                .HasMany(e => e.InventoryItems)
                .WithRequired(e => e.InventoryDepartment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InventoryIcon>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryItemLog>()
                .Property(e => e.ActivityType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InventoryItemLog>()
                .Property(e => e.Reference)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryItemLog>()
                .Property(e => e.Quantity)
                .HasPrecision(10, 3);

            modelBuilder.Entity<InventoryItemLog>()
                .Property(e => e.SalesPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InventoryItemLog>()
                .Property(e => e.SerialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryItem>()
                .Property(e => e.PartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryItem>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryItem>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InventoryItem>()
                .Property(e => e.DefaultCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InventoryItem>()
                .Property(e => e.ExternalSystemId)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryItem>()
                .Property(e => e.ExtendedDescription)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryItem>()
                .Property(e => e.SubDescription1)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryItem>()
                .Property(e => e.SubDescription2)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryItem>()
                .Property(e => e.SubDescription3)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryItem>()
                .Property(e => e.UnitOfMeasure)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryItem>()
                .HasMany(e => e.InventoryLocationItems)
                .WithRequired(e => e.InventoryItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InventoryItem>()
                .HasMany(e => e.InventorySupplierItems)
                .WithRequired(e => e.InventoryItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InventoryLocationItem>()
                .Property(e => e.QuantityOnHand)
                .HasPrecision(10, 3);

            modelBuilder.Entity<InventoryLocationItem>()
                .Property(e => e.OptimalQuantity)
                .HasPrecision(10, 3);

            modelBuilder.Entity<InventoryLocationItem>()
                .Property(e => e.ReorderPoint)
                .HasPrecision(10, 3);

            modelBuilder.Entity<InventoryLocationItem>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryLocation>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryLocation>()
                .Property(e => e.LocationType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InventoryLocation>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InventoryLocation>()
                .HasMany(e => e.InventoryItemLogs)
                .WithOptional(e => e.InventoryLocation)
                .WillCascadeOnDelete();

            modelBuilder.Entity<InventoryLocation>()
                .HasMany(e => e.InventoryLocationItems)
                .WithRequired(e => e.InventoryLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InventoryLocation>()
                .HasMany(e => e.InventoryPurchaseOrders)
                .WithRequired(e => e.InventoryLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InventoryPurchaseOrderItem>()
                .Property(e => e.QuantityOrdered)
                .HasPrecision(10, 3);

            modelBuilder.Entity<InventoryPurchaseOrderItem>()
                .Property(e => e.QuantityReceived)
                .HasPrecision(10, 3);

            modelBuilder.Entity<InventoryPurchaseOrderItem>()
                .Property(e => e.CostEach)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InventoryPurchaseOrderItem>()
                .Property(e => e.QuantityBackordered)
                .HasPrecision(10, 3);

            modelBuilder.Entity<InventoryPurchaseOrder>()
                .Property(e => e.PurchaseOrderNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryPurchaseOrder>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InventoryPurchaseOrder>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryPurchaseOrder>()
                .Property(e => e.ShipVia)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryPurchaseOrder>()
                .Property(e => e.ShippingCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InventoryPurchaseOrder>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InventoryPurchaseOrder>()
                .HasMany(e => e.InventoryPurchaseOrderItems)
                .WithRequired(e => e.InventoryPurchaseOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InventorySupplierItem>()
                .Property(e => e.PartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InventorySupplierItem>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<InventorySupplierItem>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InventorySupplierItem>()
                .Property(e => e.ItemCount)
                .HasPrecision(10, 3);

            modelBuilder.Entity<InventorySupplierItem>()
                .HasMany(e => e.InventoryPurchaseOrderItems)
                .WithRequired(e => e.InventorySupplierItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InventorySupplierPhoneNumber>()
                .Property(e => e.PhoneNumberType)
                .IsUnicode(false);

            modelBuilder.Entity<InventorySupplierPhoneNumber>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<InventorySupplierPhoneNumber>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InventorySupplierPhoneNumber>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<InventorySupplierPhoneNumber>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<InventorySupplier>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<InventorySupplier>()
                .Property(e => e.ContactName)
                .IsUnicode(false);

            modelBuilder.Entity<InventorySupplier>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InventorySupplier>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<InventorySupplier>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<InventorySupplier>()
                .Property(e => e.AutoOrderParms)
                .IsUnicode(false);

            modelBuilder.Entity<InventorySupplier>()
                .HasMany(e => e.InventoryPurchaseOrders)
                .WithRequired(e => e.InventorySupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InventorySupplier>()
                .HasMany(e => e.InventorySupplierItems)
                .WithRequired(e => e.InventorySupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InventorySupplier>()
                .HasMany(e => e.InventorySupplierPhoneNumbers)
                .WithRequired(e => e.InventorySupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LaborEstimate>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<LaborEstimate>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<LaborEstimate>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Log>()
                .Property(e => e.Thread)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Level)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Logger)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Exception)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.CallStack)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.ComputerName)
                .IsUnicode(false);

            modelBuilder.Entity<MeasureDetail>()
                .Property(e => e.Value)
                .HasPrecision(10, 3);

            modelBuilder.Entity<Measure>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Measure>()
                .HasMany(e => e.MeasureDetails)
                .WithRequired(e => e.Measure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MeasureType>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<MeasureType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<MeasureType>()
                .Property(e => e.LowValue)
                .HasPrecision(10, 3);

            modelBuilder.Entity<MeasureType>()
                .Property(e => e.HighValue)
                .HasPrecision(10, 3);

            modelBuilder.Entity<MeasureType>()
                .Property(e => e.StepValue)
                .HasPrecision(10, 3);

            modelBuilder.Entity<MeasureType>()
                .Property(e => e.NormalLowValue)
                .HasPrecision(10, 3);

            modelBuilder.Entity<MeasureType>()
                .Property(e => e.NormalHighValue)
                .HasPrecision(10, 3);

            modelBuilder.Entity<MeasureType>()
                .Property(e => e.AlertLowValue)
                .HasPrecision(10, 3);

            modelBuilder.Entity<MeasureType>()
                .Property(e => e.AlertHighValue)
                .HasPrecision(10, 3);

            modelBuilder.Entity<MeasureType>()
                .HasMany(e => e.MeasureDetails)
                .WithRequired(e => e.MeasureType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OfficeAlert>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<OfficeAlert>()
                .Property(e => e.AlertType)
                .IsUnicode(false);

            modelBuilder.Entity<OfficePhoneNumber>()
                .Property(e => e.PhoneNumberType)
                .IsUnicode(false);

            modelBuilder.Entity<OfficePhoneNumber>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<OfficePhoneNumber>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<OfficePhoneNumber>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<OfficePhoneNumber>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.OfficeName)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.AdminEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.WebTheme)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.ServerUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.MonthlyFee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Office>()
                .Property(e => e.Options)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.ReferralCode)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.EmailFromAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.TimeZoneId)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.PaymentLinkUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.ActivationCode)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.AgingCurrent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Office>()
                .Property(e => e.Aging30)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Office>()
                .Property(e => e.Aging60)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Office>()
                .Property(e => e.Aging90)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Office>()
                .Property(e => e.OutgoingSMTP)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.EmailUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.EmailPassword)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .Property(e => e.ServerName)
                .IsUnicode(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.AccountAlertDefs)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.AccountClassDefs)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.BillingGroups)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.Commissions)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.CustomViews)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.ImportedPayments)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.InterfaceSettings)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.InventoryDepartments)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.InventoryItems)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.InventoryLocations)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.InventoryPurchaseOrders)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.InventorySuppliers)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.MeasureTypes)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.OfficePhoneNumbers)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.PaymentInfoes)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.PaymentTerms)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.Pdftemplates)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.QuickBooksAccounts)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.ReferralTypes)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.Repairs)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.ReportParameterSavedValues)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.ScheduledTasks)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.ServiceCommissionRules)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.SiteOptimalRoutes)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.SystemSettings)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.TerminationTypes)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.TranCodes)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.TransactionBatches)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.TransactionCCDetails)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.UserDefinedAccountDefs)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.UserGroups)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OneLetterCode>()
                .Property(e => e.CodeType)
                .IsUnicode(false);

            modelBuilder.Entity<OneLetterCode>()
                .Property(e => e.OneLetterCode1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OneLetterCode>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PageRequestLog>()
                .Property(e => e.ClientHostIP)
                .IsUnicode(false);

            modelBuilder.Entity<PageRequestLog>()
                .Property(e => e.PageRequested)
                .IsUnicode(false);

            modelBuilder.Entity<PageRequestLog>()
                .Property(e => e.UrlQuery)
                .IsUnicode(false);

            modelBuilder.Entity<PageRequestLog>()
                .Property(e => e.PreviousPage)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentAuthorization>()
                .Property(e => e.AuthorizationLocation)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentAuthorization>()
                .Property(e => e.PaymentLastFour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PaymentAuthorization>()
                .Property(e => e.Reference)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentAuthorization>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PaymentAuthorization>()
                .Property(e => e.AuthorizationCode)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentInfo>()
                .Property(e => e.ReferenceNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentInfo>()
                .Property(e => e.Info)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTerm>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTerm>()
                .HasMany(e => e.InventoryPurchaseOrders)
                .WithRequired(e => e.PaymentTerm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PCPVerDetail>()
                .Property(e => e.CodeChange)
                .IsFixedLength();

            modelBuilder.Entity<Pdftemplate>()
                .Property(e => e.FormName)
                .IsUnicode(false);

            modelBuilder.Entity<Pdftemplate>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<Pdftemplate>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<PendingOnlinePayment>()
                .Property(e => e.OnlinePaymentToken)
                .IsUnicode(false);

            modelBuilder.Entity<PendingOnlinePayment>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PendingOnlinePayment>()
                .Property(e => e.TranType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PendingOnlinePayment>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PendingOnlinePayment>()
                .Property(e => e.Source)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhoneNumberType>()
                .Property(e => e.PhoneNumberType1)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Depth)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.PoolVolume)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.SpaVolume)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Condition)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Surface)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Appearance)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Tile)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Coping)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Mastic)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.SkimCover)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.SkimBasket)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.MainDrain)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.TimeClock)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.TCVolts)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.PoolPump)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.PumpBasket)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.PoolMotor)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.PoolHP)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.ConduitCondition)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Filter)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Backwash)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.AirRelief)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Gauge)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Heater)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.CleanerStyle)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.CleanerPump)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.CleanerClock)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.CleanerVolts)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.SpaBoosterStyle)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.SpaBoosterHP)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.ControlValve)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.ValveSize)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Piping)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.SpaBrand)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.SpaModel)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.SpaSerialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.CoverType)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Sanitizer)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.PoolType)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.SaltChlorinator)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.FilterPressure)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.TimerBrandModel)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.OtherEquipment)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.AutomaticControls)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.WaterFeature)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.AutomaticChlorinator)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.AlgaeType)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.Stains)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.PoolFinish)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment>()
                .Property(e => e.AdditionalRecommendations)
                .IsUnicode(false);

            modelBuilder.Entity<QuickBooksAccount>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<QuickBooksAccount>()
                .Property(e => e.ListID)
                .IsUnicode(false);

            modelBuilder.Entity<QuickBooksAccount>()
                .HasMany(e => e.QuickBooksAccountsTranCodes)
                .WithRequired(e => e.QuickBooksAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RateDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Rate>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Rate>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Rate>()
                .Property(e => e.MonthsApply)
                .IsUnicode(false);

            modelBuilder.Entity<Rate>()
                .HasMany(e => e.AccountRates)
                .WithRequired(e => e.Rate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rate>()
                .HasMany(e => e.RateDetails)
                .WithRequired(e => e.Rate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecentlyAccessedRecord>()
                .Property(e => e.RecordType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RecentlyAccessedRecord>()
                .Property(e => e.HowAccessed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RecurringPayment>()
                .Property(e => e.PaymentInfoLocation)
                .IsUnicode(false);

            modelBuilder.Entity<RecurringPayment>()
                .Property(e => e.PaymentLastFour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RecurringPayment>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RecurringService>()
                .Property(e => e.RecurPeriod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RecurringService>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<RecurringService>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<RecurringService>()
                .Property(e => e.AmountToCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RecurringService>()
                .Property(e => e.Commission)
                .HasPrecision(19, 4);

            modelBuilder.Entity<RecurringService>()
                .HasMany(e => e.ScheduledServices)
                .WithOptional(e => e.RecurringService)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ReferralType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ReferralType>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Repair>()
                .Property(e => e.ProblemDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Repair>()
                .Property(e => e.RepairNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Repair>()
                .Property(e => e.RepairStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Repair>()
                .Property(e => e.RoughEstimate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Repair>()
                .Property(e => e.RoughEstimateNote)
                .IsUnicode(false);

            modelBuilder.Entity<Repair>()
                .Property(e => e.Pump)
                .IsUnicode(false);

            modelBuilder.Entity<Repair>()
                .Property(e => e.Filter)
                .IsUnicode(false);

            modelBuilder.Entity<Repair>()
                .Property(e => e.SaltChlorinator)
                .IsUnicode(false);

            modelBuilder.Entity<Repair>()
                .Property(e => e.Heater)
                .IsUnicode(false);

            modelBuilder.Entity<Repair>()
                .Property(e => e.LaborFeesType)
                .IsUnicode(false);

            modelBuilder.Entity<Repair>()
                .Property(e => e.FixedLaborRate)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Repair>()
                .Property(e => e.InitialLaborFees)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Repair>()
                .Property(e => e.AdditionalLaborFees)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Repair>()
                .Property(e => e.InitialLaborFeesDuration)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Repair>()
                .Property(e => e.EstimatedLaborDuration)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Repair>()
                .Property(e => e.EstimatedMaterialCost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Repair>()
                .Property(e => e.ChargedLaborAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Repair>()
                .Property(e => e.ChargedLaborDuration)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Repair>()
                .HasMany(e => e.RepairVisits)
                .WithRequired(e => e.Repair)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RepairTechAvailability>()
                .Property(e => e.DaysAvailable)
                .IsUnicode(false);

            modelBuilder.Entity<RepairVisit>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<ReportParameter>()
                .Property(e => e.ParameterName)
                .IsUnicode(false);

            modelBuilder.Entity<ReportParameter>()
                .Property(e => e.ParameterType)
                .IsUnicode(false);

            modelBuilder.Entity<ReportParameter>()
                .Property(e => e.ParameterTypeAttributes)
                .IsUnicode(false);

            modelBuilder.Entity<ReportParameter>()
                .Property(e => e.PromptText)
                .IsUnicode(false);

            modelBuilder.Entity<ReportParameter>()
                .Property(e => e.DefaultValue)
                .IsUnicode(false);

            modelBuilder.Entity<ReportParameterSavedValue>()
                .Property(e => e.SavedValue)
                .IsUnicode(false);

            modelBuilder.Entity<Report>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Report>()
                .Property(e => e.Layout)
                .IsUnicode(false);

            modelBuilder.Entity<Report>()
                .Property(e => e.SqlQuery)
                .IsUnicode(false);

            modelBuilder.Entity<Report>()
                .Property(e => e.MenuPath)
                .IsUnicode(false);

            modelBuilder.Entity<Report>()
                .HasMany(e => e.Reports1)
                .WithOptional(e => e.Report1)
                .HasForeignKey(e => e.BasedOnReportId);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Reports)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.RoleId);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Reports1)
                .WithOptional(e => e.Role1)
                .HasForeignKey(e => e.RoleId);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.UserGroupRoles)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.UserGroupRoles1)
                .WithRequired(e => e.Role1)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesTax>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<SalesTax>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SalesTax>()
                .HasMany(e => e.SalesTaxGroupMembers)
                .WithRequired(e => e.SalesTax)
                .HasForeignKey(e => e.GroupSalesTaxId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesTax>()
                .HasMany(e => e.SalesTaxGroupMembers1)
                .WithRequired(e => e.SalesTax1)
                .HasForeignKey(e => e.MemberSalesTaxId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SaltChlorinator>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SaltChlorinator>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SaltChlorinator>()
                .Property(e => e.dbTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<SaltChlorinatorIdeal>()
                .Property(e => e.Min)
                .HasPrecision(18, 10);

            modelBuilder.Entity<SaltChlorinatorIdeal>()
                .Property(e => e.Max)
                .HasPrecision(18, 10);

            modelBuilder.Entity<SaltChlorinatorIdeal>()
                .Property(e => e.Ideal)
                .HasPrecision(18, 10);

            modelBuilder.Entity<SaltChlorinatorIdeal>()
                .Property(e => e.dbTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<ScheduledServiceChecklistItem>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledService>()
                .Property(e => e.CompletionType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledService>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledService>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<ScheduledService>()
                .Property(e => e.AmountToCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ScheduledService>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledService>()
                .Property(e => e.CompletionNotes)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledService>()
                .Property(e => e.Commission)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ScheduledService>()
                .Property(e => e.Psi)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ScheduledService>()
                .HasMany(e => e.Commissions)
                .WithOptional(e => e.ScheduledService)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ScheduledService>()
                .HasMany(e => e.ScheduledServiceChecklistItems)
                .WithRequired(e => e.ScheduledService)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ScheduledService>()
                .HasMany(e => e.ServicePhotoes)
                .WithRequired(e => e.ScheduledService)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ScheduledService>()
                .HasMany(e => e.UserGeoLocationLogs)
                .WithOptional(e => e.ScheduledService)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ScheduledTask>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTask>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<ScheduledTask>()
                .Property(e => e.CompletionNotes)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduledTask>()
                .Property(e => e.SourceUrl)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceCommissionRule>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ServiceCommissionRule>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceCommissionRule>()
                .Property(e => e.PayTo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ServiceDefChecklistItem>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceDef>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceDef>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceDef>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceDef>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<ServiceDef>()
                .Property(e => e.ReportLayout)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceDef>()
                .Property(e => e.DefaultAmountToCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ServiceDef>()
                .Property(e => e.DefaultCommission)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ServiceDef>()
                .HasMany(e => e.RecurringServices)
                .WithRequired(e => e.ServiceDef)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceDef>()
                .HasMany(e => e.ScheduledServices)
                .WithRequired(e => e.ServiceDef)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceDef>()
                .HasMany(e => e.ServiceCommissionRules)
                .WithRequired(e => e.ServiceDef)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceDef>()
                .HasMany(e => e.ServiceDefChecklistItems)
                .WithRequired(e => e.ServiceDef)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceLog>()
                .Property(e => e.LogEntry)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceLog>()
                .Property(e => e.ServiceLogType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ServiceLog>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<ServicePhoto>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<ServicePhoto>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ServicePhoto>()
                .Property(e => e.PhotoLocation)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceWindowDef>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceWindowDef>()
                .Property(e => e.WindowStartTime)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceWindowDef>()
                .Property(e => e.WindowEndTime)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceWindowDef>()
                .HasMany(e => e.RepairVisits)
                .WithRequired(e => e.ServiceWindowDef)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SitePhoto>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<SitePhoto>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SitePhoto>()
                .Property(e => e.PhotoLocation)
                .IsUnicode(false);

            modelBuilder.Entity<SitePhoto>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Site>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Site>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Site>()
                .HasMany(e => e.Equipments)
                .WithRequired(e => e.Site)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Site>()
                .HasMany(e => e.Measures)
                .WithRequired(e => e.Site)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Site>()
                .HasMany(e => e.RecurringServices)
                .WithRequired(e => e.Site)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Site>()
                .HasMany(e => e.ScheduledServices)
                .WithRequired(e => e.Site)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Site>()
                .HasMany(e => e.SiteOptimalRoutes)
                .WithOptional(e => e.Site)
                .HasForeignKey(e => e.PreviousSiteId);

            modelBuilder.Entity<Site>()
                .HasMany(e => e.SiteOptimalRoutes1)
                .WithOptional(e => e.Site1)
                .HasForeignKey(e => e.NextSiteId);

            modelBuilder.Entity<Site>()
                .HasMany(e => e.Treatments)
                .WithRequired(e => e.Site)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StandardizationCode>()
                .Property(e => e.StandardizationCode1)
                .IsUnicode(false);

            modelBuilder.Entity<StandardizationCode>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.StateCode)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.StateName)
                .IsUnicode(false);

            modelBuilder.Entity<Sync>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<Sync>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Sync>()
                .Property(e => e.RemoteKey)
                .IsUnicode(false);

            modelBuilder.Entity<Sync>()
                .Property(e => e.RemoteVersion)
                .IsUnicode(false);

            modelBuilder.Entity<SyncSendingQueue>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<SyncSendingQueue>()
                .Property(e => e.RowState)
                .IsUnicode(false);

            modelBuilder.Entity<SyncSendingQueue>()
                .Property(e => e.RecordRowVersion)
                .IsFixedLength();

            modelBuilder.Entity<SyncWith>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SystemSettingDef>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SystemSettingDef>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<SystemSettingDef>()
                .Property(e => e.DefaultValue)
                .IsUnicode(false);

            modelBuilder.Entity<SystemSettingDef>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<SystemSettingDef>()
                .HasMany(e => e.SystemSettings)
                .WithRequired(e => e.SystemSettingDef)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SystemSetting>()
                .Property(e => e.SettingData)
                .IsUnicode(false);

            modelBuilder.Entity<TaskDef>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<TaskDef>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TaskDef>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<TaskLog>()
                .Property(e => e.LogEntry)
                .IsUnicode(false);

            modelBuilder.Entity<TaskLog>()
                .Property(e => e.TaskLogType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaskLog>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<TerminationType>()
                .Property(e => e.Description)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TerminationType>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<TranCodeGroup>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<TranCodeGroup>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TranCode>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TranCode>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<TranCode>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<TranCode>()
                .Property(e => e.DefaultAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TranCode>()
                .HasMany(e => e.EstimateLineItems)
                .WithRequired(e => e.TranCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TranCode>()
                .HasMany(e => e.InventoryDepartments)
                .WithRequired(e => e.TranCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TranCode>()
                .HasMany(e => e.PendingOnlinePayments)
                .WithOptional(e => e.TranCode)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TranCode>()
                .HasMany(e => e.QuickBooksAccountsTranCodes)
                .WithRequired(e => e.TranCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TranCode>()
                .HasMany(e => e.ServiceDefs)
                .WithOptional(e => e.TranCode)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TranCode>()
                .HasMany(e => e.TransactionDetails)
                .WithRequired(e => e.TranCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TranCode>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.TranCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransactionBatch>()
                .Property(e => e.BatchType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransactionBatch>()
                .Property(e => e.BatchStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransactionBatch>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionBatch>()
                .Property(e => e.Reference)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCCDetail>()
                .Property(e => e.AuthDesc)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCCDetail>()
                .Property(e => e.AuthCode)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCCDetail>()
                .Property(e => e.TranReference)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCCDetail>()
                .Property(e => e.PaymentLastFour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCCDetail>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCCRecurringPaymentDef>()
                .Property(e => e.BillingStreet)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCCRecurringPaymentDef>()
                .Property(e => e.BillingZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCCRecurringPaymentDef>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCCRecurringPaymentDef>()
                .Property(e => e.PaymentLastFour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCCRecurringPaymentDef>()
                .Property(e => e.BankName)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCCRecurringPaymentDef>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransactionDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransactionDetail>()
                .Property(e => e.Reference)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionDetail>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransactionDetail>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<TransactionDetail>()
                .Property(e => e.Source)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransactionDetail>()
                .Property(e => e.ApplicableTaxes)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransactionDetail>()
                .Property(e => e.SerialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Quantity)
                .HasPrecision(14, 4);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Reference)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.InvoiceNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Source)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Details)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Transaction>()
                .HasMany(e => e.Repairs)
                .WithOptional(e => e.Transaction)
                .HasForeignKey(e => e.InvoiceId);

            modelBuilder.Entity<Transaction>()
                .HasMany(e => e.Repairs1)
                .WithOptional(e => e.Transaction1)
                .HasForeignKey(e => e.LastTransactionId);

            modelBuilder.Entity<TransferInfo>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<Treatment>()
                .Property(e => e.UnitsAdded)
                .HasPrecision(10, 3);

            modelBuilder.Entity<TreatmentType>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<TreatmentType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TreatmentType>()
                .Property(e => e.UnitDescription)
                .IsUnicode(false);

            modelBuilder.Entity<TreatmentType>()
                .Property(e => e.UsualUnitsToAdd)
                .HasPrecision(10, 3);

            modelBuilder.Entity<TreatmentType>()
                .Property(e => e.PricePerUnit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UserDefinedAccountDef>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<UserDefinedAccountDef>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<UserDefinedAccountDef>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<UserDefinedAccountInfo>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<UserDefinedAccountInfo>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<UserDefinedAccountInfo>()
                .HasOptional(e => e.UserDefinedAccountInfo1)
                .WithRequired(e => e.UserDefinedAccountInfo2);

            modelBuilder.Entity<UserDefinedSiteDef>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<UserDefinedSiteDef>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<UserDefinedSiteDef>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<UserDefinedSiteDef>()
                .HasMany(e => e.UserDefinedSiteInfoes)
                .WithRequired(e => e.UserDefinedSiteDef)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserDefinedSiteInfo>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<UserDefinedSiteInfo>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<UserGeoLocationLog>()
                .Property(e => e.Activity)
                .IsUnicode(false);

            modelBuilder.Entity<UserGroup>()
                .Property(e => e.UserGroupName)
                .IsUnicode(false);

            modelBuilder.Entity<UserGroup>()
                .HasMany(e => e.UserGroupRoles)
                .WithRequired(e => e.UserGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserGroup>()
                .HasMany(e => e.UserGroupUsers)
                .WithRequired(e => e.UserGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.HashedPassword)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PasswordHint)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.AccountMemos)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Estimates)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Feedbacks)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryItemLogs)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryPurchaseOrders)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.ApprovedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryPurchaseOrders1)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.CreatedByUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryPurchaseOrders2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.ReceivedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.PaymentAuthorizations)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.RecentlyAccessedRecords)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.RecurringServices)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Repairs)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.AssignedToUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Repairs1)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.CreatedByUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.RepairTechAvailabilities)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.RepairVisits)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.TechnicianId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ScheduledServices)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ScheduledServices1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ScheduledTasks)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedByUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ScheduledTasks1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ServiceLogs)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SiteOptimalRoutes)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.TaskLogs)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.TransactionBatches)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserGeoLocationLogs)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserGroupUsers)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserSettings)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserSetting>()
                .Property(e => e.SettingName)
                .IsUnicode(false);

            modelBuilder.Entity<UserSetting>()
                .Property(e => e.SettingData)
                .IsUnicode(false);

            

            modelBuilder.Entity<AccountPhoneNumbers_bk>()
                .Property(e => e.PhoneNumberType)
                .IsUnicode(false);

            modelBuilder.Entity<AccountPhoneNumbers_bk>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<AccountPhoneNumbers_bk>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<AccountPhoneNumbers_bk>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<AccountPhoneNumbers_bk>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AccountPhoneNumbers_bk>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Accounts_151>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_151>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_151>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_151>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_217>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_217>()
                .Property(e => e.OfficeId)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_217>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_217>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_217>()
                .Property(e => e.ReferralTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_217>()
                .Property(e => e.AccountType)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_217>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_217>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_217>()
                .Property(e => e.AgingCurrent)
                .HasPrecision(2, 2);

            modelBuilder.Entity<Accounts_217>()
                .Property(e => e.Aging30)
                .HasPrecision(2, 2);

            modelBuilder.Entity<Accounts_217>()
                .Property(e => e.Aging60)
                .HasPrecision(2, 2);

            modelBuilder.Entity<Accounts_217>()
                .Property(e => e.Aging90)
                .HasPrecision(2, 2);

            modelBuilder.Entity<Accounts_217>()
                .Property(e => e.AgingCR)
                .HasPrecision(2, 2);

            modelBuilder.Entity<Accounts_217>()
                .Property(e => e.BillingGroupId)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_252>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_252>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_252>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts_252>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_151>()
                .Property(e => e.AddressType)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_151>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_151>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_151>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_151>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_151>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_151>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_217>()
                .Property(e => e.AddressType)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_217>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_217>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_217>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_217>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_217>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_217>()
                .Property(e => e.StandardizationCode)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_217>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_217>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_217>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_217>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_226>()
                .Property(e => e.AddressType)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_226>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_226>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_226>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_226>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_226>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_226>()
                .Property(e => e.StandardizationCode)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_226>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_226>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_226>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_226>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_252>()
                .Property(e => e.AddressType)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_252>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_252>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_252>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_252>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_252>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Addresses_252>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_151>()
                .Property(e => e.AddressType)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_151>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_151>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_151>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_151>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_217>()
                .Property(e => e.AddressType)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_217>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_217>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_217>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_217>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_217>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_252>()
                .Property(e => e.AddressType)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_252>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_252>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_252>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<AddressesPools_252>()
                .Property(e => e.PostCode)
                .IsUnicode(false);

            modelBuilder.Entity<AnalysisDetail>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<CognosOwnerStoreInfo>()
                .Property(e => e.StoreName)
                .IsUnicode(false);

            modelBuilder.Entity<CognosOwnerStoreInfo>()
                .Property(e => e.OwnerName)
                .IsUnicode(false);

            modelBuilder.Entity<CognosOwnerStoreInfo>()
                .Property(e => e.ExternalName)
                .IsUnicode(false);

            modelBuilder.Entity<CognosOwnerStoreInfo>()
                .Property(e => e.InternalName)
                .IsUnicode(false);

            modelBuilder.Entity<CognosOwnerStoreInfo>()
                .Property(e => e.BusAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<CognosOwnerStoreInfo>()
                .Property(e => e.BusCity)
                .IsUnicode(false);

            modelBuilder.Entity<CognosOwnerStoreInfo>()
                .Property(e => e.BusCounty)
                .IsUnicode(false);

            modelBuilder.Entity<CognosOwnerStoreInfo>()
                .Property(e => e.BusState)
                .IsUnicode(false);

            modelBuilder.Entity<CognosOwnerStoreInfo>()
                .Property(e => e.BusZip)
                .IsUnicode(false);

            modelBuilder.Entity<CognosOwnerStoreInfo>()
                .Property(e => e.BusPhone1)
                .IsUnicode(false);

            modelBuilder.Entity<CognosOwnerStoreInfo>()
                .Property(e => e.BusFax1)
                .IsUnicode(false);

            modelBuilder.Entity<CognosOwnerStoreInfo>()
                .Property(e => e.RecognitionByMil)
                .IsFixedLength();

            modelBuilder.Entity<customer_151>()
                .Property(e => e.Cust_No)
                .IsUnicode(false);

            modelBuilder.Entity<customer_151>()
                .Property(e => e.Cust_StructureType)
                .IsUnicode(false);

            modelBuilder.Entity<customer_151>()
                .Property(e => e.Cust_LName)
                .IsUnicode(false);

            modelBuilder.Entity<customer_151>()
                .Property(e => e.Cust_FName)
                .IsUnicode(false);

            modelBuilder.Entity<customer_151>()
                .Property(e => e.Cust_MI)
                .IsUnicode(false);

            modelBuilder.Entity<customer_151>()
                .Property(e => e.Cust_SpouseFName)
                .IsUnicode(false);

            modelBuilder.Entity<customer_151>()
                .Property(e => e.Cust_Address1)
                .IsUnicode(false);

            modelBuilder.Entity<customer_151>()
                .Property(e => e.Cust_Address2)
                .IsUnicode(false);

            modelBuilder.Entity<customer_151>()
                .Property(e => e.Cust_City)
                .IsUnicode(false);

            modelBuilder.Entity<customer_151>()
                .Property(e => e.Cust_Zip)
                .IsUnicode(false);

            modelBuilder.Entity<customer_151>()
                .Property(e => e.Cust_PAPCredit)
                .IsUnicode(false);

            modelBuilder.Entity<customer_151>()
                .Property(e => e.Cust_Email)
                .IsUnicode(false);

            modelBuilder.Entity<customer_252>()
                .Property(e => e.Cust_No)
                .IsUnicode(false);

            modelBuilder.Entity<customer_252>()
                .Property(e => e.Cust_StructureType)
                .IsUnicode(false);

            modelBuilder.Entity<customer_252>()
                .Property(e => e.Cust_LName)
                .IsUnicode(false);

            modelBuilder.Entity<customer_252>()
                .Property(e => e.Cust_FName)
                .IsUnicode(false);

            modelBuilder.Entity<customer_252>()
                .Property(e => e.Cust_MI)
                .IsUnicode(false);

            modelBuilder.Entity<customer_252>()
                .Property(e => e.Cust_SpouseFName)
                .IsUnicode(false);

            modelBuilder.Entity<customer_252>()
                .Property(e => e.Cust_Address1)
                .IsUnicode(false);

            modelBuilder.Entity<customer_252>()
                .Property(e => e.Cust_Address2)
                .IsUnicode(false);

            modelBuilder.Entity<customer_252>()
                .Property(e => e.Cust_City)
                .IsUnicode(false);

            modelBuilder.Entity<customer_252>()
                .Property(e => e.Cust_Zip)
                .IsUnicode(false);

            modelBuilder.Entity<customer_252>()
                .Property(e => e.Cust_PAPCredit)
                .IsUnicode(false);

            modelBuilder.Entity<customer_252>()
                .Property(e => e.Cust_Email)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_151>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_151>()
                .Property(e => e.Size)
                .HasPrecision(37, 2);

            modelBuilder.Entity<Equipment_151>()
                .Property(e => e.Depth)
                .HasPrecision(18, 1);

            modelBuilder.Entity<Equipment_151>()
                .Property(e => e.PoolVolume)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_151>()
                .Property(e => e.Surface)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_151>()
                .Property(e => e.Sanitizer)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_151>()
                .Property(e => e.PoolPump)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_151>()
                .Property(e => e.PoolMotor)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_151>()
                .Property(e => e.CleanerPump)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_151>()
                .Property(e => e.Filter)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_151>()
                .Property(e => e.Heater)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_217>()
                .Property(e => e.PoolEquipmentID)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_217>()
                .Property(e => e.PoolID)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_217>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_217>()
                .Property(e => e.Depth)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_217>()
                .Property(e => e.PoolVolume)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_217>()
                .Property(e => e.Surface)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_217>()
                .Property(e => e.Sanitizer)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_217>()
                .Property(e => e.PoolPump)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_217>()
                .Property(e => e.PoolMotor)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_217>()
                .Property(e => e.CleanerPump)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_217>()
                .Property(e => e.Filter)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_217>()
                .Property(e => e.Heater)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_217>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_252>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_252>()
                .Property(e => e.Size)
                .HasPrecision(37, 2);

            modelBuilder.Entity<Equipment_252>()
                .Property(e => e.Depth)
                .HasPrecision(18, 1);

            modelBuilder.Entity<Equipment_252>()
                .Property(e => e.PoolVolume)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_252>()
                .Property(e => e.Surface)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_252>()
                .Property(e => e.Sanitizer)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_252>()
                .Property(e => e.PoolPump)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_252>()
                .Property(e => e.PoolMotor)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_252>()
                .Property(e => e.CleanerPump)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_252>()
                .Property(e => e.Filter)
                .IsUnicode(false);

            modelBuilder.Entity<Equipment_252>()
                .Property(e => e.Heater)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterDetailField>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterHeaderField>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.ReportName)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.Overdue30)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.Overdue60)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.Overdue90)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.UserLine1)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.UserLine2)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.UserLine3)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.UserLine4)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.UserLine5)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.BegAccountCode)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.EndAccountCode)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.BegPoolName)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.EndPoolName)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.BegPoolCity)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.EndPoolCity)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.BegPoolPostCode)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.EndPoolPostcode)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.BegAccountName)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.EndAccountName)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.BegAccountCity)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.EndAccountCity)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.BegAccountPostCode)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.EndAccountPostcode)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.BegUser1)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.EndUser1)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.BegUser2)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.EndUser2)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.BegUser3)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.EndUser3)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.RefCode)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.TermCode)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.BegRouteCode)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.EndRouteCode)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.PlanCode)
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.Status1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.Status2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.Status3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LinePrinterReport>()
                .Property(e => e.Status4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MemoLetter>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<MemoLetter>()
                .Property(e => e.MemoLetterType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MemoLetter>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<MonthTotal>()
                .Property(e => e.AgingCurrent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MonthTotal>()
                .Property(e => e.Aging30)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MonthTotal>()
                .Property(e => e.Aging60)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MonthTotal>()
                .Property(e => e.Aging90)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MonthTotalsPerTranCode>()
                .Property(e => e.NetPostedAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PCP_FA>()
                .Property(e => e.StoreID)
                .IsUnicode(false);

            modelBuilder.Entity<PCP_FA>()
                .Property(e => e.Month)
                .IsUnicode(false);

            modelBuilder.Entity<PCP_FA>()
                .Property(e => e.Day)
                .IsUnicode(false);

            modelBuilder.Entity<PCP_FA>()
                .Property(e => e.DepartmentID)
                .IsUnicode(false);

            modelBuilder.Entity<PCP_FA>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<PCP_FA>()
                .Property(e => e.TotalAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PCP_FA_JDE>()
                .Property(e => e.STORE)
                .IsUnicode(false);

            modelBuilder.Entity<PCP_FA_JDE>()
                .Property(e => e.Month)
                .IsUnicode(false);

            modelBuilder.Entity<PCP_FA_JDE>()
                .Property(e => e.Day)
                .IsUnicode(false);

            modelBuilder.Entity<PCP_FA_JDE>()
                .Property(e => e.DEPT)
                .IsUnicode(false);

            modelBuilder.Entity<PCP_FA_JDE>()
                .Property(e => e.AMOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<PCP_FA_JDE>()
                .Property(e => e.SIGN)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Depth)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.PoolVolume)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.SpaVolume)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Condition)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Surface)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Appearance)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Tile)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Coping)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Mastic)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.SkimCover)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.SkimBasket)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.MainDrain)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.TimeClock)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.TCVolts)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.PoolPump)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.PumpBasket)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.PoolMotor)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.PoolHP)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.ConduitCondition)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Filter)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Backwash)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.AirRelief)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Gauge)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Heater)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.CleanerStyle)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.CleanerPump)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.CleanerClock)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.CleanerVolts)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.SpaBoosterStyle)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.SpaBoosterHP)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.ControlValve)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.ValveSize)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Piping)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.SpaBrand)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.SpaModel)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.SpaSerialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.CoverType)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Sanitizer)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.PoolType)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.SaltChlorinator)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.FilterPressure)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.TimerBrandModel)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.OtherEquipment)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.AutomaticControls)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.WaterFeature)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.AutomaticChlorinator)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.AlgaeType)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.Stains)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.PoolFinish)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_09092020>()
                .Property(e => e.AdditionalRecommendations)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_151>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_151>()
                .Property(e => e.Size)
                .HasPrecision(37, 2);

            modelBuilder.Entity<PoolEquipment_151>()
                .Property(e => e.Depth)
                .HasPrecision(18, 1);

            modelBuilder.Entity<PoolEquipment_151>()
                .Property(e => e.PoolVolume)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_151>()
                .Property(e => e.Surface)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_151>()
                .Property(e => e.Sanitizer)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_151>()
                .Property(e => e.PoolPump)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_151>()
                .Property(e => e.PoolMotor)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_151>()
                .Property(e => e.CleanerPump)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_151>()
                .Property(e => e.Filter)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_151>()
                .Property(e => e.Heater)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_252>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_252>()
                .Property(e => e.Size)
                .HasPrecision(37, 2);

            modelBuilder.Entity<PoolEquipment_252>()
                .Property(e => e.Depth)
                .HasPrecision(18, 1);

            modelBuilder.Entity<PoolEquipment_252>()
                .Property(e => e.PoolVolume)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_252>()
                .Property(e => e.Surface)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_252>()
                .Property(e => e.Sanitizer)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_252>()
                .Property(e => e.PoolPump)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_252>()
                .Property(e => e.PoolMotor)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_252>()
                .Property(e => e.CleanerPump)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_252>()
                .Property(e => e.Filter)
                .IsUnicode(false);

            modelBuilder.Entity<PoolEquipment_252>()
                .Property(e => e.Heater)
                .IsUnicode(false);

            modelBuilder.Entity<Pools_151>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Pools_217>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Pools_252>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Reccommendation>()
                .Property(e => e.ChemicalAmount)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Reccommendation>()
                .Property(e => e.ChemicalUOM)
                .IsUnicode(false);

            modelBuilder.Entity<Sites_217>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TipsBank>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TipsBank>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Tran_Del_Save>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<Tran_Del_Save>()
                .Property(e => e.Quantity)
                .HasPrecision(14, 4);

            modelBuilder.Entity<Tran_Del_Save>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tran_Del_Save>()
                .Property(e => e.Reference)
                .IsUnicode(false);

            modelBuilder.Entity<Tran_Del_Save>()
                .Property(e => e.InvoiceNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Tran_Del_Save>()
                .Property(e => e.Source)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tran_Del_Save>()
                .Property(e => e.Details)
                .IsUnicode(false);

            modelBuilder.Entity<Tran_Del_Save>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<TransactionCCDetails_Deleted>()
                .Property(e => e.AuthDesc)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCCDetails_Deleted>()
                .Property(e => e.AuthCode)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCCDetails_Deleted>()
                .Property(e => e.TranReference)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCCDetails_Deleted>()
                .Property(e => e.PaymentLastFour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransactionDetails_Deleted>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransactionDetails_Deleted>()
                .Property(e => e.Reference)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionDetails_Deleted>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TransactionDetails_Deleted>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<TransactionDetails_Deleted>()
                .Property(e => e.Source)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransactionDetails_Deleted>()
                .Property(e => e.ApplicableTaxes)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transactions_Deleted>()
                .Property(e => e.Quantity)
                .HasPrecision(14, 4);

            modelBuilder.Entity<Transactions_Deleted>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transactions_Deleted>()
                .Property(e => e.Reference)
                .IsUnicode(false);

            modelBuilder.Entity<Transactions_Deleted>()
                .Property(e => e.InvoiceNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Transactions_Deleted>()
                .Property(e => e.Source)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Transactions_Deleted>()
                .Property(e => e.Details)
                .IsUnicode(false);

            modelBuilder.Entity<Transactions_Deleted>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<AccountsAgingAdjusted>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountsAgingAdjusted>()
                .Property(e => e.AgingCurrent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountsAgingAdjusted>()
                .Property(e => e.Aging30)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountsAgingAdjusted>()
                .Property(e => e.Aging60)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AccountsAgingAdjusted>()
                .Property(e => e.Aging90)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Pool>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Pool>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<UserDefinedPoolDef>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<UserDefinedPoolDef>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<UserDefinedPoolDef>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<UserDefinedPoolInfo>()
                .Property(e => e.Value)
                .IsUnicode(false);
            */
        }
    }
}
