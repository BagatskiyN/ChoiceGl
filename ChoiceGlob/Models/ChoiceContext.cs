using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoiceGlob.Models
{
    public class ChoiceContext:DbContext
    {
        private readonly string _conStr= "Data Source =.\\SQLEXPRESS;Initial Catalog = ChoiceDbGl1; Integrated Security = True";

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public ChoiceContext(DbContextOptions<ChoiceContext> options) : base(options) { }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DisciplineStudent>()
                      .HasKey(t => new { t.DisciplineId, t.StudentId });


        }
        //Data Source =.\\SQLEXPRESS;Initial Catalog = ChoiceDbGl1; Integrated Security = True
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_conStr);
        }
        public class DisciplineStudent
        {
            public int DisciplineId { get; set; }
            public Discipline Discipline { get; set; }

            public int StudentId { get; set; }
            public Student Student { get; set; }
        }

    }
}

