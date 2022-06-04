using Cms.DataAccess.Dtos;
using Cms.Entities.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.DataAccess.DataContext
{
    public class DatabaseContext: DbContext
    {
        private readonly bool IsMigration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=cmsdb;User Id=postgres;Password=37363736;");
            optionsBuilder.UseNpgsql(@"User ID=postgres;Password=37363736;Server=localhost;Port=5432;Database=crmdb;Integrated Security=true;Pooling=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ContentContainer>().HasKey(c => new { c.contentid, c.containerid });
            modelBuilder.Entity<TitleContent>().HasKey(c => new { c.ContentId, c.MenuId });
            //modelBuilder.Entity<Vw_TitleContent>().HasKey(c => new { c.titleid, c.contentid });
            if (IsMigration)
            {
                modelBuilder.Ignore<Vw_TitleContainer>();
                modelBuilder.Ignore<Vw_TitleContent>();
            }

        }
        public DbSet<ContactForm> contactforms { get; set; }
        public DbSet<Language> languages { get; set; }
        public DbSet<PageContainer> pagecontainers { get; set; }
        public DbSet<PageContent> pagecontents { get; set; }
        public DbSet<PageTitle> pagetitles { get; set; }
        public DbSet<PanelUser> panelusers { get; set; }
        public DbSet<Setting> settings { get; set; }
        public DbSet<TitleContent> titlecontents { get; set; }
        public DbSet<UploadFile> uploadfiles { get; set; }
        public DbSet<ContentContainer> contentcontainers { get; set; }
        //public DbSet<Vw_TitleContent> vw_titlecontents { get; set; }
        //public DbSet<Vw_TitleContainer> vw_titlecontainer { get; set; }
    }
}
