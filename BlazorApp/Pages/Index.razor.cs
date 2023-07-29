namespace PortfolioWebsite.Client.Pages
{
    public partial class Index
    {
        public class Technology
        {
            public string Name { get; set; }
            public int Delay { get; set; }
        }

        List<Technology> technologies = new List<Technology>()
        {
            new Technology { Name = "C#", Delay = 500 },
            new Technology { Name = "Model View Controller", Delay = 700 },
            new Technology { Name = "MS SQL Server", Delay = 700 },
            new Technology { Name = "NHibernate", Delay = 700 },
            new Technology { Name = ".NET FRAMEWORK", Delay = 600 },
            new Technology { Name = ".NET MAUI", Delay = 700 },
            new Technology { Name = "Blazor WebAssembly", Delay = 800 },
            new Technology { Name = "JavaScript", Delay = 1100 },
            new Technology { Name = "HTML", Delay = 1200 },
            new Technology { Name = "Tailwind CSS", Delay = 1200 },
            new Technology { Name = "IoT", Delay = 1200 },
            new Technology { Name = "Azure", Delay = 900 }
        };
    }
}
