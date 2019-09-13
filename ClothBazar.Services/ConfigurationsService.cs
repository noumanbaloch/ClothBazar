using ClothBazar.Database;
using ClothBazar.Entites;

namespace ClothBazar.Services
{
    public class ConfigurationsService
    {
        public static ConfigurationsService Instance
        {
            get
            {
                if (instance == null) instance = new ConfigurationsService();

                return instance;

            }
        }
        private static ConfigurationsService instance { get; set; }

        private ConfigurationsService()
        {

        }
        public Config GetConfig(string Key)
        {
            using (var context = new CBContext())
            {
                return context.Configurations.Find(Key);
            }
        }
    }
}
