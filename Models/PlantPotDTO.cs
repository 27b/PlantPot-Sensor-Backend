namespace PlantPotDTO
{
    public class PlantPotDto
    {
        public string name {get; set;}
        public double temperature {get; set;}
        public PlantPotDto(string name, double temperature)
        {
            this.name = name;
            this.temperature = temperature;
        }
    }
}