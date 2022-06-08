using System;

namespace heist2
{
    public class LockSpecialist : IRobber
    {
      public string Name { get; set;}
      public int SkillLevel { get; set;}
      public int PercentageCut { get; set;}
      public void PerformSkill(Bank bank) 
        { 
          bank.VaultScore -= SkillLevel;

          Console.WriteLine($"{Name} is hacking the lock system. Decreased security 50 points!");
          
          if (bank.SecurityGuardScore <= 0) 
          {
            Console.WriteLine($"{Name} has disabled the lock system!");
          }
        }
    }
}