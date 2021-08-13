namespace TaskAllocation.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TaskAllocation.Entities;
    using TaskAllocation.LookupEntities;

    internal sealed class Configuration : DbMigrationsConfiguration<TaskAllocation.TaskAllocationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TaskAllocation.TaskAllocationContext context)
        {
            IList<LookupUserType> lookupUserTypes = new List<LookupUserType>
            {
                new LookupUserType(){UserType="Dev"},
                new LookupUserType(){UserType="QA/BA"},
                new LookupUserType(){UserType="Lead"},
                new LookupUserType(){UserType="Dev or QA/BA"}

            };
            context.LookupUserTypes.AddRange(lookupUserTypes);

            IList<LookupProfile> lookupProfiles = new List<LookupProfile>
            {
                new LookupProfile(){ProfileName="Lead"},
                new LookupProfile(){ProfileName="Resource"}
               

            };
            context.LookupProfiles.AddRange(lookupProfiles);
            IList<LookupTaskStatus> lookupTaskStatuses = new List<LookupTaskStatus>
            {
                new LookupTaskStatus(){TaskStatus="Ready To be Assigned"},
                new LookupTaskStatus(){TaskStatus="In-Progress"},
                new LookupTaskStatus(){TaskStatus="Assigned"},
                new LookupTaskStatus(){TaskStatus="Completed"},
                new LookupTaskStatus(){TaskStatus="Bloked-Customer"},
                new LookupTaskStatus(){TaskStatus="Blocked-Internal"},
                new LookupTaskStatus(){TaskStatus="On-Hold"},
                new LookupTaskStatus(){TaskStatus="Pending Dependent Task"}

            };
            context.LookupTaskStatuses.AddRange(lookupTaskStatuses);
            IList<LookupBuildType> lookupBuildTypes = new List<LookupBuildType>
            {
                new LookupBuildType(){BuildType="SB"},
                new LookupBuildType(){BuildType="ITL"},
                new LookupBuildType(){BuildType="FinalMig"},



            };
            context.LookupBuildTypes.AddRange(lookupBuildTypes);
            IList<TaskMaster> taskMasters = new List<TaskMaster>
            {
                new TaskMaster(){TaskName="Run SourceValidation",IsPlannerStart=1},
                new TaskMaster(){TaskName="Create a folder in Implementation Vault-> Projects",IsPlannerStart=1},
                new TaskMaster(){TaskName="Verify UI and PMS Access",IsPlannerStart=1},
                new TaskMaster(){TaskName="Create Project Planner and Link it here",IsPlannerStart=1},
                new TaskMaster(){TaskName="Mig & Mig2 Account Creation ",IsPlannerStart=1},

                new TaskMaster(){TaskName="DB Extraction",IsPlannerStart=0},
                new TaskMaster(){TaskName="Excels Completion",IsPlannerStart=0},
                new TaskMaster(){TaskName="Excels Verification",IsPlannerStart=0},
                new TaskMaster(){TaskName="Staging build",IsPlannerStart=0},
                new TaskMaster(){TaskName="Staging DB Testing",IsPlannerStart=0},
                new TaskMaster(){TaskName="Staging DB Bug Fix",IsPlannerStart=0},
                new TaskMaster(){TaskName="Mig Destination Push",IsPlannerStart=0},
                new TaskMaster(){TaskName="Mig UI Comparison",IsPlannerStart=0},
                new TaskMaster(){TaskName="UI Comparison Bug Fix",IsPlannerStart=0}


            };
            context.LookupBuildTypes.AddRange(lookupBuildTypes);
            // context.Database.ExecuteSqlCommand("Alter table Account Add Constraint UK_UniqueName Unique(AccountShortName)");
            context.Database.ExecuteSqlCommand("Alter table Account Add Constraint UK_UniqueAccountId Unique(AccountId)");

        }
    }
}
