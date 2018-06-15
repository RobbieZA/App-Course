namespace RPAPI.Models
{
    public class Store
    {
        public enum Grades { A, B, C, D }
        public int Id { get; set; }
        public string Description { get; set; }
        //public GeoCoordinate Location { get; set; }
        public Grades Grade { get; set; }
    }
}