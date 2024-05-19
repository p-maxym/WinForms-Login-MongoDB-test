using MongoDB.Driver;
using MongoDB.Bson;
using System.Text.Json;
using System.Diagnostics;

namespace WinFormsLoginka
{
    public partial class LoginWindow : Form
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<BsonDocument> _collection;

        public LoginWindow()
        {
            InitializeComponent();
            _client = new MongoClient("mongodb+srv://maxymdb:maxymdb@datab.0sego7m.mongodb.net/\r\n");
            _database = _client.GetDatabase("DataB");
            _collection = _database.GetCollection<BsonDocument>("WinFormLoginUsers");

            ConnectToDataBase();

        }

        protected void ConnectToDataBase()
        {
            const string connectionUri = "mongodb+srv://maxymdb:maxymdb@datab.0sego7m.mongodb.net/?retryWrites=true&w=majority&appName=DataB";
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to set the version of the Stable API on the client
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            var client = new MongoClient(settings);
            // Send a ping to confirm a successful connection
            try
            {
                var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Debug.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}