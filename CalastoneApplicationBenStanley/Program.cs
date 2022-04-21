using CalastoneApplicationLibrary;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CalastoneApplicationBenStanley
{
    public class Program
    {
        private IFilterService _filterService;

        public Program(IFilterService filterService)
        {
            _filterService = filterService;
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddTransient<Program>();
                    services.AddSingleton<IFilterService, FilterService>();
                });
        }

        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<Program>().Run();
        }

        public void Run()
        {
            bool quitApplication = false;
            while (!quitApplication)
            {
                Console.WriteLine("Please type below the text file path or 'Esc' to close the application:");
                var path = Console.ReadLine();
                if (!File.Exists(path))
                {
                    Console.WriteLine("File does not exist");
                    continue;
                }
                Console.WriteLine("Please enter the chacter which the words are separated by");
                var separator = Console.ReadKey().KeyChar;
                Console.WriteLine();
                using (var fileStream = File.OpenRead(path))
                {
                    var words = new List<string>();
                    using (var streamReader = new StreamReader(fileStream))
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            words.AddRange(line.Split(separator, StringSplitOptions.TrimEntries).ToList());
                        }
                        
                        words = _filterService.FilterMiddleVowels(words);
                        words = _filterService.FilterLengthLessThanThree(words);
                        words = _filterService.FilterWordsContainingLetterT(words);
                    }
                    if (words.IsNotNullOrEmpty())
                    {
                        Console.WriteLine("New list of words after filter:");
                        Console.WriteLine(string.Join(' ', words));
                    }
                    else
                    {
                        Console.WriteLine("No words remaining after filter.");
                    }
                }
            }
        }
    }
}