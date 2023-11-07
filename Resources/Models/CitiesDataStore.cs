namespace Resources.Models
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore() 
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Sarasota",
                    Description = "By the water south",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id = 1,
                            Name = "Bayfront Restaurant",
                            Description = "Fun place to get food"
                        },
                        new PointsOfInterestDto()
                        {
                            Id = 2,
                            Name = "Bayfront Beach",
                            Description = "Fun place with sand"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Tampa",
                    Description = "By the water north",
                    PointsOfInterest= new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id = 2,
                            Name = "Glazers Kids Museum",
                            Description = "Fun place to play for kids"
                        },
                        new PointsOfInterestDto()
                        {
                            Id = 2,
                            Name = "Rays Game",
                            Description = "Fun place to go to a baseball game"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Clearwater",
                    Description = "By the water more north",
                    PointsOfInterest= new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id = 2,
                            Name = "Aquarium",
                            Description = "Fun place for kids to see sea-life"
                        },
                        new PointsOfInterestDto()
                        {
                            Id = 2,
                            Name = "Library",
                            Description = "Fun place to read books"
                        }
                    }
                }
            };
            
        }
    }
}
