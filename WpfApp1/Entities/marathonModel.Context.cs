﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class marathonEntities : DbContext
    {
        public marathonEntities()
            : base("name=marathonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Charity> Charity { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventType> EventType { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Marathon> Marathon { get; set; }
        public virtual DbSet<RaceKitOption> RaceKitOption { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<RegistrationEvent> RegistrationEvent { get; set; }
        public virtual DbSet<RegistrationStatus> RegistrationStatus { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Runner> Runner { get; set; }
        public virtual DbSet<Sponsorship> Sponsorship { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Volunteer> Volunteer { get; set; }
    }
}
