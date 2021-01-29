using System;

namespace The_Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("Enter a Team Members Name");
            var teamName = Console.ReadLine();

            Console.WriteLine("Enter The Team members skill level 0-100");
            var skillLevel = Console.ReadLine();
            var convertedSkillLevel = int.Parse(skillLevel);

            Console.WriteLine("Enter the team members courage level 0.0 - 2.0");
            var courageLevel = Console.ReadLine();
            var convertedCourageLevel = double.Parse(courageLevel);

            var firstTeamMember = new TeamMember(teamName, convertedSkillLevel, convertedCourageLevel);

            firstTeamMember.ShowInfo();
        }
    }
}
