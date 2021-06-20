using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM8
{
    class Member
    {
        private string job;
        private int registrationFee;

        public string FullName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public void SetJob(string jobName)
        {
            job = jobName;
        }
        public string GetJob()
        {
            return job;
        }
        public int GetFee()
        {
            switch (job)
            {
                case "Student":
                    registrationFee = 1000;
                    break;
                case "Teacher":
                    registrationFee = 1400;
                    break;
                case "Retired":
                    registrationFee = 1500;
                    break;
                case "Others":
                    registrationFee = 2000;
                    break;
            }
            return registrationFee;
        }
    }
}
