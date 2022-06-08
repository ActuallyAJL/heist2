using System;
using System.Collections.Generic;

namespace heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<IRobber> rolodex = new List<IRobber>()
            {
                new Muscle()
                {
                    Name = "Alex",
                    SkillLevel = 100,
                    PercentageCut = 30
                },
                 new LockSpecialist()
                {
                    Name = "Houston",
                    SkillLevel = 100,
                    PercentageCut = 30
                },
                 new Hacker()
                {
                    Name = "Nathan",
                    SkillLevel = 100,
                    PercentageCut = 30
                },
                 new Muscle()
                {
                    Name = "Olivia",
                    SkillLevel = 100,
                    PercentageCut = 30
                },
                 new Hacker()
                {
                    Name = "Jordan",
                    SkillLevel = 100,
                    PercentageCut = 30
                },
                 new LockSpecialist()
                {
                    Name = "Steve",
                    SkillLevel = 100,
                    PercentageCut = 30
                }
            };
        }
    }
}
