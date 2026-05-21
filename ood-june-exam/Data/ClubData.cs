using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ood_june_exam;


namespace ood_june_exam.Data
{
    public class ClubData : DbContext
    {
        public ClubData() : base(" OODExam_STUTZMathieu") 
        { }
        public DbSet<Member> Members {  get; set; }
        public DbSet<TrainingSession> TrainingSessions { get; set; }


    }
}
