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

            Console.WriteLine($"Current number of operatives in the Rolodex: {rolodex.Count}");

            AddNewMember()
            
            void AddNewMember()
            {
                Console.WriteLine("Please enter the name of a new crew member");
                string newMemName = Console.ReadLine();
                
                if(newMemName != "")
                {
                Console.WriteLine(@"Please enter the member's specialty
                Enter 1 for Hacker
                Enter 2 for Muscle
                Enter 3 for LockSpecialist")
                int newMemSpecialty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the new member's skill level (1-100)");
                int newMemSkillLevel = int.Parse(Console.Readline());
                Console.WriteLine("Enter the percentage cut for the new member");
                int newMemPercentageCut = int.Parse(Console.Readline());

                    switch (newMemSpecialty)
                    {
                        case 1:
                        {
                            rolodex.Add(new Hacker {Name = newMemName, PercentageCut = newMemPercentageCut, SkillLevel = newMemSkillLevel});
                            break;
                        }
                        case 2:
                        {
                            rolodex.Add(new Muscle {Name = newMemName, PercentageCut = newMemPercentageCut, SkillLevel = newMemSkillLevel});
                            break;
                        }
                        case 3:
                        {
                            rolodex.Add(new LockSpecialist {Name = newMemName, PercentageCut = newMemPercentageCut, SkillLevel = newMemSkillLevel});
                            break;
                        }
                    }

                    Console.WriteLine("Do you want to add another member? (Y/N)");
                    string userResponse - Console.ReadLine();
                    if(userResponse.ToLower() == "y")
                    {
                        AddNewMember();
                    }
                }
        
            }
    }   }
}
