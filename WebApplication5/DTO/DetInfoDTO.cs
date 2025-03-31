namespace WebApplication5.DTO
{
    public class DetInfoDTO
    {
        public int Id { get; set; }

        // ზოგადი ინფორმაცია
        public string Name { get; set; }
        public string AlternateDesignation { get; set; }
        public string Type { get; set; } // Planet, Star, Galaxy, Nebula, BlackHole, etc.
        public string Constellation { get; set; }
        public double DistanceFromEarth { get; set; } // In light years
        public double Magnitude { get; set; }
        public double Mass { get; set; } // In solar masses
        public double Radius { get; set; } // In km
        public double? Temperature { get; set; } // In Kelvin
        public double Age { get; set; } // In billion years
        public string Composition { get; set; }
        public string SpectralType { get; set; }
        public string Classification { get; set; }
        public string Characteristics { get; set; }
        public string InterestingFacts { get; set; }
        public string ImageUrl { get; set; }
    }
}
