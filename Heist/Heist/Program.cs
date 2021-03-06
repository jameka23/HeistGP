﻿using Heist.Classes;
using System;

namespace Heist
{
    class Program
    {
        static public TeamMember CreateSingleTeamMember()
        {
            Console.WriteLine("Enter your team member's name:");
            var memberName = Console.ReadLine();
            Console.WriteLine($"Enter {memberName}'s skill level (must be a positive integer 0 - 50)");
            var memberSkill = int.Parse(Console.ReadLine());

            //validation
            if (memberSkill < 0)
            {
                Console.WriteLine($"Please enter a positive integer 0 - 50");
                memberSkill = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Enter {memberName}'s skill level (must be between 0.0 - 2.0)");
            var memberCourage = decimal.Parse(Console.ReadLine());


            if (memberCourage < 0.0m || memberCourage > 2.0m)
            {
                Console.WriteLine($"Please enter a decimal: ");
                memberCourage = decimal.Parse(Console.ReadLine());
            }

            TeamMember teamMember = new TeamMember(memberName, memberSkill, memberCourage);

            return teamMember;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            TeamMember teamMate = CreateSingleTeamMember();
           

            Console.WriteLine($"Here is your new member: Name: {teamMate.Name}, Skill Level: {teamMate.SkillLevel}, Courage Factor: {teamMate.CourageFactor}! ");
        }
        
        
    }
}
