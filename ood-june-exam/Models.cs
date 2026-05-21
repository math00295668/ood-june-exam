using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ood_june_exam
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string MembershipType { get; set; }

        
        public virtual List<TrainingSession> TrainingSessions { get; set; }

        public Member()
        {
            TrainingSessions = new List<TrainingSession>();
        }

    }

    public class TrainingSession
    {
        public int SessionId { get; set; }
        public DateTime SessionDate { get; set; }
        public string SessionType { get; set; }
        public int DurationMinutes { get; set; }
        public string CoachNotes { get; set; }

        public int MemberId { get; set; }
        public virtual Member Member { get; set; }

        public override string ToString()
        {
            return $"{SessionDate} \n {SessionType}  \n {DurationMinutes} \n {CoachNotes}";
        }
    }
}
