﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DekanatSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DekanatEkzEntities : DbContext
    {
        public DekanatEkzEntities()
            : base("name=DekanatEkzEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GroupsSet> GroupsSet { get; set; }
        public virtual DbSet<PointsSet> PointsSet { get; set; }
        public virtual DbSet<StudentsSet> StudentsSet { get; set; }
        public virtual DbSet<SubjectsSet> SubjectsSet { get; set; }
    }
}
