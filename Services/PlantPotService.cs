using PlantPotDTO;

namespace PlantPotServices
{

    public class PlantPotService
    {
        private static List<PlantPotDto> PlantPotList = new List<PlantPotDto>();
        public static List<PlantPotDto> RetrieveList()
        {
            return PlantPotList;
        }
        public static PlantPotDto Retrieve(string name)
        {
            return PlantPotList.FirstOrDefault(item => item.name == name) ?? new PlantPotDto("", 0);
        }
        public static bool Append(PlantPotDto plantPot)
        {
            PlantPotList.Add(plantPot);
            return true;
        }
        public static bool Update(PlantPotDto plantPot)
        {
            var result = PlantPotList.FirstOrDefault(item => item.name == plantPot.name);
            if (result != null)
            {
                result.temperature = plantPot.temperature;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}