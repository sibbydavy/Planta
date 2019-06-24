namespace Planta.Repository
{
    public class DatabaseConfiguration
    {
        public string DatabaseName { get; set; }

        public string ConnectionString { get; set; }

        public bool EnableMongoQueryLogging { get; set; }

    }
}