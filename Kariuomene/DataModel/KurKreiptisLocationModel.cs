namespace Kariuomene.DataModel
{
    public class KurKreiptisLocationModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string[] Phone { get; set; }
        public string Other { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}