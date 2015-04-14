﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TradeSharp.Linq
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class TradeSharpConnection : DbContext
    {
        public TradeSharpConnection()
            : base("name=TradeSharpConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ACCOUNT> ACCOUNT { get; set; }
        public DbSet<ACCOUNT_GROUP> ACCOUNT_GROUP { get; set; }
        public DbSet<ACCOUNT_SHARE> ACCOUNT_SHARE { get; set; }
        public DbSet<ACCOUNT_SHARE_HISTORY> ACCOUNT_SHARE_HISTORY { get; set; }
        public DbSet<BALANCE_CHANGE> BALANCE_CHANGE { get; set; }
        public DbSet<BROKER_ORDER> BROKER_ORDER { get; set; }
        public DbSet<BROKER_RESPONSE> BROKER_RESPONSE { get; set; }
        public DbSet<CHANNEL> CHANNEL { get; set; }
        public DbSet<COMMODITY> COMMODITY { get; set; }
        public DbSet<DEALER> DEALER { get; set; }
        public DbSet<DEALER_GROUP> DEALER_GROUP { get; set; }
        public DbSet<DEALER_PARAMETER> DEALER_PARAMETER { get; set; }
        public DbSet<ENGINE_METADATA> ENGINE_METADATA { get; set; }
        public DbSet<FILE> FILE { get; set; }
        public DbSet<LOT_BY_GROUP> LOT_BY_GROUP { get; set; }
        public DbSet<MARKUP_BY_GROUP> MARKUP_BY_GROUP { get; set; }
        public DbSet<ORDER_BILL> ORDER_BILL { get; set; }
        public DbSet<PAYMENT_SYSTEM_TRANSFER> PAYMENT_SYSTEM_TRANSFER { get; set; }
        public DbSet<PENDING_ORDER> PENDING_ORDER { get; set; }
        public DbSet<PENDING_ORDER_CLOSED> PENDING_ORDER_CLOSED { get; set; }
        public DbSet<PLATFORM_USER> PLATFORM_USER { get; set; }
        public DbSet<PLATFORM_USER_ACCOUNT> PLATFORM_USER_ACCOUNT { get; set; }
        public DbSet<POSITION> POSITION { get; set; }
        public DbSet<POSITION_CLOSED> POSITION_CLOSED { get; set; }
        public DbSet<POSITION_MARKUP> POSITION_MARKUP { get; set; }
        public DbSet<SchemaInfo> SchemaInfo { get; set; }
        public DbSet<SERVICE> SERVICE { get; set; }
        public DbSet<SERVICE_RATE> SERVICE_RATE { get; set; }
        public DbSet<SPOT> SPOT { get; set; }
        public DbSet<SUBSCRIPTION> SUBSCRIPTION { get; set; }
        public DbSet<SUBSCRIPTION_SIGNAL> SUBSCRIPTION_SIGNAL { get; set; }
        public DbSet<TOP_PORTFOLIO> TOP_PORTFOLIO { get; set; }
        public DbSet<TRANSFER> TRANSFER { get; set; }
        public DbSet<USER_EVENT> USER_EVENT { get; set; }
        public DbSet<USER_INFO> USER_INFO { get; set; }
        public DbSet<USER_PAYMENT_SYSTEM> USER_PAYMENT_SYSTEM { get; set; }
        public DbSet<USER_TOP_PORTFOLIO> USER_TOP_PORTFOLIO { get; set; }
        public DbSet<WALLET> WALLET { get; set; }
        public DbSet<SUBSCRIPTION_V> SUBSCRIPTION_V { get; set; }
    
        public virtual int ClearOldUserEvents(Nullable<System.DateTime> staleDate)
        {
            var staleDateParameter = staleDate.HasValue ?
                new ObjectParameter("staleDate", staleDate) :
                new ObjectParameter("staleDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ClearOldUserEvents", staleDateParameter);
        }
    
        public virtual ObjectResult<GetAllAccounts_Result> GetAllAccounts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllAccounts_Result>("GetAllAccounts");
        }
    
        public virtual ObjectResult<GetAllAccountsUserDetail_Result> GetAllAccountsUserDetail()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllAccountsUserDetail_Result>("GetAllAccountsUserDetail");
        }
    
        public virtual ObjectResult<GetDepoTransfers_Result> GetDepoTransfers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDepoTransfers_Result>("GetDepoTransfers");
        }
    
        public virtual ObjectResult<GetGroupsWithAccounts_Result> GetGroupsWithAccounts(string accountGroupCode)
        {
            var accountGroupCodeParameter = accountGroupCode != null ?
                new ObjectParameter("AccountGroupCode", accountGroupCode) :
                new ObjectParameter("AccountGroupCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetGroupsWithAccounts_Result>("GetGroupsWithAccounts", accountGroupCodeParameter);
        }
    
        public virtual ObjectResult<GetOrderBills_Result> GetOrderBills()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetOrderBills_Result>("GetOrderBills");
        }
    
        public virtual ObjectResult<GetPerformers_Result> GetPerformers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPerformers_Result>("GetPerformers");
        }
    
        public virtual ObjectResult<GetPositionList_Result> GetPositionList(Nullable<int> countItemShow, Nullable<int> accountId, Nullable<int> isRealAccount, string symbol, Nullable<int> status, Nullable<int> side, Nullable<System.DateTime> timeOpenFrom, Nullable<System.DateTime> timeOpenTo, Nullable<System.DateTime> timeExitFrom, Nullable<System.DateTime> timeExitTo, ObjectParameter totalItemCount)
        {
            var countItemShowParameter = countItemShow.HasValue ?
                new ObjectParameter("CountItemShow", countItemShow) :
                new ObjectParameter("CountItemShow", typeof(int));
    
            var accountIdParameter = accountId.HasValue ?
                new ObjectParameter("AccountId", accountId) :
                new ObjectParameter("AccountId", typeof(int));
    
            var isRealAccountParameter = isRealAccount.HasValue ?
                new ObjectParameter("IsRealAccount", isRealAccount) :
                new ObjectParameter("IsRealAccount", typeof(int));
    
            var symbolParameter = symbol != null ?
                new ObjectParameter("Symbol", symbol) :
                new ObjectParameter("Symbol", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(int));
    
            var sideParameter = side.HasValue ?
                new ObjectParameter("Side", side) :
                new ObjectParameter("Side", typeof(int));
    
            var timeOpenFromParameter = timeOpenFrom.HasValue ?
                new ObjectParameter("TimeOpenFrom", timeOpenFrom) :
                new ObjectParameter("TimeOpenFrom", typeof(System.DateTime));
    
            var timeOpenToParameter = timeOpenTo.HasValue ?
                new ObjectParameter("TimeOpenTo", timeOpenTo) :
                new ObjectParameter("TimeOpenTo", typeof(System.DateTime));
    
            var timeExitFromParameter = timeExitFrom.HasValue ?
                new ObjectParameter("TimeExitFrom", timeExitFrom) :
                new ObjectParameter("TimeExitFrom", typeof(System.DateTime));
    
            var timeExitToParameter = timeExitTo.HasValue ?
                new ObjectParameter("TimeExitTo", timeExitTo) :
                new ObjectParameter("TimeExitTo", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPositionList_Result>("GetPositionList", countItemShowParameter, accountIdParameter, isRealAccountParameter, symbolParameter, statusParameter, sideParameter, timeOpenFromParameter, timeOpenToParameter, timeExitFromParameter, timeExitToParameter, totalItemCount);
        }
    
        public virtual ObjectResult<GetPositionsToSwap_Result> GetPositionsToSwap()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPositionsToSwap_Result>("GetPositionsToSwap");
        }
    
        public virtual ObjectResult<GetTransfersSummary_Result> GetTransfersSummary(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetTransfersSummary_Result>("GetTransfersSummary", userIdParameter);
        }
    
        public virtual ObjectResult<GetVolumesByTiker_Result> GetVolumesByTiker()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetVolumesByTiker_Result>("GetVolumesByTiker");
        }
    
        public virtual ObjectResult<PopUserEvents_Result> PopUserEvents(Nullable<int> usrId)
        {
            var usrIdParameter = usrId.HasValue ?
                new ObjectParameter("usrId", usrId) :
                new ObjectParameter("usrId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PopUserEvents_Result>("PopUserEvents", usrIdParameter);
        }
    }
}