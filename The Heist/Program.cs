using System;
using System.Collections.Generic;

namespace The_Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("How difficult would you like your bank to be? Enter a number Value");
            var inputOfBank = Console.ReadLine();
            var bankDifficultyLevel = Int32.Parse(inputOfBank);

            var yourTeam = new List<TeamMember> { };
            bool askForUserInput = true;
            while (askForUserInput)
            {
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

                var teamMember = new TeamMember(teamName, convertedSkillLevel, convertedCourageLevel);
                yourTeam.Add(teamMember);

                
            }
            
            Console.WriteLine($"There a {yourTeam.Count} skilled members of your team!");


            Console.WriteLine("How many times would you like to run the scenario?");
            var numOfScenarios = Console.ReadLine();
            var counter = 0;
            var successfulRuns = 0;
            var failedRuns = 0;
            while(Int32.Parse(numOfScenarios) > counter)
            {
                
                var teamSkillLevel = 0;
                var random = new Random();
                int luckValue = random.Next(-10, 10);

                bankDifficultyLevel += luckValue;

                foreach (var member in yourTeam)
                {
                    teamSkillLevel += member.SkillLevel;

                }

                Console.WriteLine($"The teams combined skill level is {teamSkillLevel}");
                Console.WriteLine($"The banks difficulty level is {bankDifficultyLevel}");

                if (teamSkillLevel > bankDifficultyLevel)
                {
                    Console.WriteLine("Your team successfully robbed the bank!!");
                    successfulRuns++;

                }
                else
                {
                    Console.WriteLine("Your team did not have the skills to rob the bank. Have fun in JAIL!");
                    failedRuns++;
                }
                counter++;
            }
            Console.WriteLine($"The bank was robbed {successfulRuns} times and you went to jail {failedRuns} times. Thanks for playing!!");
        }
    }
}
