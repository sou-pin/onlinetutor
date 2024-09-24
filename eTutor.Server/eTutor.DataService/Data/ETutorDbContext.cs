using eTutor.DataService.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace eTutor.DataService.Data
{
    public class eTutorDbContext : DbContext
    {
        //entities
        public DbSet<User> Users { get; set; }
        public DbSet<UserTypes> UserTypes { get; set; }
        public DbSet<TeacherPersonalDetails> TeacherPersonalDetails { get; set; }
        public DbSet<StudentPersonalDetails> StudentPersonalDetails { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Institute> Institutes { get; set; }
        public DbSet<BoardOrUniversity> BoardOrUniversities { get; set; }


        public eTutorDbContext(DbContextOptions<eTutorDbContext> options) : base(options) { }


    }
}
