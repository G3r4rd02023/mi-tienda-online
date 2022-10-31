using TiendaOnline.Data.Entities;

namespace TiendaOnline.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
            await CheckCategoriesAsync();
        }

        private async Task CheckCategoriesAsync()
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category { Name = "Tecnología" });
                _context.Categories.Add(new Category { Name = "Ropa" });
                _context.Categories.Add(new Category { Name = "Gamer" });
                _context.Categories.Add(new Category { Name = "Belleza" });
                _context.Categories.Add(new Category { Name = "Nutrición" });
            }

            await _context.SaveChangesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country
                {
                    Name = "Honduras",
                    States = new List<State>()
                    {
                        new State()
                        {
                            Name = "Cortés",
                            Cities = new List<City>() {
                                new City() { Name = "San Pedro Sula" },
                                new City() { Name = "Puerto Cortés" },
                                new City() { Name = "Villanueva" },
                                new City() { Name = "San Manuel" },
                                new City() { Name = "Choloma" },
                            }
                        },
                        new State()
                        {
                            Name = "Francisco Morazán",
                            Cities = new List<City>() {
                                new City() { Name = "Tegucigalpa" },
                                new City() { Name = "Santa Lucía" },
                                new City() { Name = "Valle de Angeles" },
                                new City() { Name = "Ojojona" },
                                new City() { Name = "Santa Ana" },
                            }
                        },
                    }
                });
                _context.Countries.Add(new Country
                {
                    Name = "Estados Unidos",
                    States = new List<State>()
                    {
                        new State()
                        {
                            Name = "Florida",
                            Cities = new List<City>() {
                                new City() { Name = "Orlando" },
                                new City() { Name = "Miami" },
                                new City() { Name = "Tampa" },
                                new City() { Name = "Fort Lauderdale" },
                                new City() { Name = "Key West" },
                            }
                        },
                        new State()
                        {
                            Name = "Texas",
                            Cities = new List<City>() {
                                new City() { Name = "Houston" },
                                new City() { Name = "San Antonio" },
                                new City() { Name = "Dallas" },
                                new City() { Name = "Austin" },
                                new City() { Name = "El Paso" },
                            }
                        },
                    }
                });
            }

            await _context.SaveChangesAsync();
        }
    }
}


