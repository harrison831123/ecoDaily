﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ecoBack
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbecoDailyEntities2 : DbContext
    {
        public dbecoDailyEntities2()
            : base("name=dbecoDailyEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tAnnouncement> tAnnouncement { get; set; }
        public virtual DbSet<tCandidate> tCandidate { get; set; }
        public virtual DbSet<tCargo> tCargo { get; set; }
        public virtual DbSet<tEvent> tEvent { get; set; }
        public virtual DbSet<tEventRegister> tEventRegister { get; set; }
        public virtual DbSet<tForum> tForum { get; set; }
        public virtual DbSet<tForumComment> tForumComment { get; set; }
        public virtual DbSet<tIncome> tIncome { get; set; }
        public virtual DbSet<tMail> tMail { get; set; }
        public virtual DbSet<tManagementFee> tManagementFee { get; set; }
        public virtual DbSet<tMemberData> tMemberData { get; set; }
        public virtual DbSet<tNaturalGas> tNaturalGas { get; set; }
        public virtual DbSet<tPay> tPay { get; set; }
        public virtual DbSet<tReservation> tReservation { get; set; }
        public virtual DbSet<tReservationTime> tReservationTime { get; set; }
        public virtual DbSet<tUserVote> tUserVote { get; set; }
        public virtual DbSet<tVote> tVote { get; set; }
    }
}
