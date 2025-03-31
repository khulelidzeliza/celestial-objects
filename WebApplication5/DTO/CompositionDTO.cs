namespace WebApplication5.DTO
{
    public class CompositionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Composition { get; set; }
        public string SpectralType { get; set; }
        public double Mass { get; set; } // In solar masses
        public double Radius { get; set; } // In km
        public double? Temperature { get; set; } // In Kelvin
    }
}
