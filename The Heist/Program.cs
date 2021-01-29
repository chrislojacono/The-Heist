using System;
using System.Collections.Generic;

namespace The_Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            var yourTeam = new List<TeamMember> { };
            bool askForUserInput = true;
            while (askForUserInput)
            {
                Console.WriteLine("Plan Your Heist!");
                Console.WriteLine("Enter a Team Members Name");
                var teamName = Console.ReadLine();
                if (String.IsNullOrEmpty(teamName))
                {
                    askForUserInput = false;
                    break;
                }

                Console.WriteLine("Enter The Team members skill level 0-100");
                var skillLevel = Console.ReadLine();
                if (String.IsNullOrEmpty(skillLevel))
                {
                    askForUserInput = false;
                    break;
                }
                var convertedSkillLevel = int.Parse(skillLevel);

                Console.WriteLine("Enter the team members courage level 0.0 - 2.0");
                var courageLevel = Console.ReadLine();
                if (String.IsNullOrEmpty(courageLevel))
                {
                    askForUserInput = false;
                    break;
                }
                var convertedCourageLevel = double.Parse(courageLevel);

                var firstTeamMember = new TeamMember(teamName, convertedSkillLevel, convertedCourageLevel);
                yourTeam.Add(firstTeamMember);

                firstTeamMember.ShowInfo();
            }
            
            Console.WriteLine($"There a {yourTeam.Count} skilled members of your team!");
            foreach (var member in yourTeam)
            {
                Console.WriteLine($"You have {member.Name} with a skill level of {member.SkillLevel} and a courage of {member.Courage}");
            }

        }
    }
}
