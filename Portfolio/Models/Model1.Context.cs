﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portfolio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyAcademyPortfolioProjectEntities : DbContext
    {
        public MyAcademyPortfolioProjectEntities()
            : base("name=MyAcademyPortfolioProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblAbouts> TblAbouts { get; set; }
        public virtual DbSet<TblAdmins> TblAdmins { get; set; }
        public virtual DbSet<TblCategories> TblCategories { get; set; }
        public virtual DbSet<TblContacts> TblContacts { get; set; }
        public virtual DbSet<TblExperiences> TblExperiences { get; set; }
        public virtual DbSet<TblFeatures> TblFeatures { get; set; }
        public virtual DbSet<TblMessages> TblMessages { get; set; }
        public virtual DbSet<TblProjects> TblProjects { get; set; }
        public virtual DbSet<TblServices> TblServices { get; set; }
        public virtual DbSet<TblSkills> TblSkills { get; set; }
        public virtual DbSet<TblSocialMedias> TblSocialMedias { get; set; }
        public virtual DbSet<TblTeams> TblTeams { get; set; }
        public virtual DbSet<TblTestimonials> TblTestimonials { get; set; }
    }
}
