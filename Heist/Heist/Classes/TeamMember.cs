using System;
using System.Collections.Generic;
using System.Text;

namespace Heist.Classes
{
    class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public float CourageFactor { get; set; }
        public TeamMember(string name, int skill, float courage)
        {
            Name = name;
            SkillLevel = skill;
            CourageFactor = courage;
        }
    }
}
