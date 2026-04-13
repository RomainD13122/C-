namespace MeteoApp.Models
{
    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public City() { }

        public City(string name, string country = "")
        {
            Name = name;
            Country = country;
        }

        public override string ToString()
        {
            return string.IsNullOrEmpty(Country) ? Name : $"{Name}, {Country}";
        }
    }
}
