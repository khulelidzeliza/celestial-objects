namespace WebApplication5.DTO
{
    public class LocationDTO
    {
        public int Id { get; set; }

        // ზოგადი ინფორმაცია
        public string Name { get; set; }
        public string Constellation { get; set; }
        public double RightAscension { get; set; } // Hours
        public double Declination { get; set; } // Degrees
        public double DistanceFromEarth { get; set; }
        public string Type { get; set; } // Planet, Star, Galaxy, Nebula, BlackHole, etc.
    }
}
