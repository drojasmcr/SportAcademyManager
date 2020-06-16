using SportAcademyManager.Data;
using SportAcademyManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    private static SportAcademyManagerContext context = new SportAcademyManagerContext();
    static void Main(string[] args)
    {
        context.Database.EnsureCreated();
        GetAcademy();
        var category = AddCategoryAndReturnIt("2008", new DateTime(2008,01,01), new DateTime(2008,12,31));
        var category2 = AddCategoryAndReturnIt("2009", new DateTime(2009, 01, 01), new DateTime(2009, 12, 31));
        var category3 = AddCategoryAndReturnIt("2007", new DateTime(2007, 01, 01), new DateTime(2007, 12, 31));
        var category4 = AddCategoryAndReturnIt("2010", new DateTime(2010, 01, 01), new DateTime(2010, 12, 31));

        var team8A = AddTeamAndReturnIt("2008-A", category);
        var team8B = AddTeamAndReturnIt("2008-B", category);
        var team8C = AddTeamAndReturnIt("2008-C", category);

        var team9A = AddTeamAndReturnIt("2009-A", category2);
        var team9B = AddTeamAndReturnIt("2009-B", category2);
        var team9C = AddTeamAndReturnIt("2009-C", category2);

        var team7A = AddTeamAndReturnIt("2007-A", category3);
        var team7B = AddTeamAndReturnIt("2007-B", category3);
        var team7C = AddTeamAndReturnIt("2007-C", category3);

        var team10A = AddTeamAndReturnIt("2010-A", category4);

        AddAcademy(
            new List<Category> { category, category2, category3, category4}, 
            new List<Team> { team8A, team8B, team8C, team9A, team9B, team9C, team7A, team7B, team7C, team10A });

        GetAcademy();
    }

    
    public static void AddAcademy(List<Category> categories, List<Team> teams)
    {
        var academy = new Academy
        {
            Name = "Velez Jr",
            Address = "Alajuela, Costa Rica",
            Categories = new List<Category>(),
            Teams = new List<Team>()
        };

        var academies = context.Academies.ToList();
        if (academies.Contains(academy))
        {
            Console.WriteLine("Academy {0} already exists", academy.Name);
            return;
        }

        foreach (var category in categories)
        {
            academy.Categories.Add(category);
        }

        foreach (var team in teams)
        {
            academy.Teams.Add(team);
        }
        
        context.Academies.Add(academy);
        context.SaveChanges();
    }

    private static void GetAcademy()
    {
        var academies = context.Academies.ToList();
        foreach (var item in academies)
        {
            if (item.Categories== null) return;

            Console.WriteLine("Academy: {0}", item.Name );
            Console.WriteLine("---Categories---");
            foreach (var category in item.Categories)
            {
                Console.WriteLine("Category: {0}", category.Name);
                Console.WriteLine("Start year: {0}", category.StartYear.ToShortDateString());
                Console.WriteLine("---Teams in category---");
                foreach (var team in item.Teams)
                {
                    if ( team.Category == category )
                    {
                        Console.WriteLine("Team: {0}", team.Name);                        
                    }
                }
            }
        }
    }

    private static Category AddCategoryAndReturnIt(String name, DateTime startYear, DateTime endYear)
    {
        var category = new Category
        {
            Name = name,
            EndYear = endYear,
            StartYear = startYear
        };

        context.Categories.Add(category);
        
        return category;
    }

    public static Team AddTeamAndReturnIt(string name, Category category)
    {
        var team = new Team
        {
            Name = name,
            Category = category
        };
        context.Teams.Add(team);
        return team;
    }

    public static Player AddPlayerAndReturnIt(string identification, StrongFoot strongFoot,
        string name, string lastName, string secondLastName, string homeAddress, string phone) 
    {
        var player = new Player(name, lastName, secondLastName, identification, homeAddress, phone, strongFoot);

        context.Players.Add(player);

        return player;
    }
}