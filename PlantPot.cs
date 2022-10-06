namespace PlantPotDTO
{
    public class PlantPot
    {
        public string name {get; set;}
        public double temperature {get; set;}
        public PlantPot(string name, double temperature)
        {
            this.name = name;
            this.temperature = temperature;
        }
    }
}