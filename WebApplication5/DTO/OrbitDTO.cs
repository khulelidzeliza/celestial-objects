namespace WebApplication5.DTO
{
    public class OrbitDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string OrbitingBody { get; set; }
        public double? OrbitalPeriod { get; set; } 
        public double? OrbitalEccentricity { get; set; }
        public double? RotationPeriod { get; set; }
    }
}
