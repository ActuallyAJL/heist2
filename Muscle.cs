using System;

namespace heist2
{
    public class Muscle : IRobber
    {
      public string Name { get; set;}
      public int SkillLevel { get; set;}
      public int PercentageCut { get; set;}
      public void PerformSkill(Bank bank) 
        { 
          bank.SecurityGuardScore -= SkillLevel;
          
          Console.WriteLine($"{Name} is hacking the guard system. Decreased security 50 points!");
          
          if (bank.SecurityGuardScore <= 0) 
          {
            Console.WriteLine($"{Name} has disabled the guard system!");
          }
        }
    }
}