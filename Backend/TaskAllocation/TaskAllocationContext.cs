using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using TaskAllocation.Entities;
using TaskAllocation.LookupEntities;

namespace TaskAllocation
{
    public class TaskAllocationContext : DbContext
    {
        public TaskAllocationContext()
            : base("TaskAllocationContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<LookupUserType> LookupUserTypes { get; set; }
        public virtual DbSet<LookupProfile> LookupProfiles { get; set; }
        public virtual DbSet<Conversion> Conversions { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<LookupTaskStatus> LookupTaskStatuses { get; set; }
        public virtual DbSet<LookupBuildType> LookupBuildTypes { get; set; }
        public virtual DbSet<TaskMaster> TaskMasters { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }



    }
}