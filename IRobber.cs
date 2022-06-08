using System;

namespace heist2
{
    public interface IRobber
    {
        string Name { get; }
        int SkillLevel { get; }
        int PercentageCute { get; }
        void PerformSkill(Bank bank) { }
    }
}