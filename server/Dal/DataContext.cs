
namespace Dal
{
    public class DataContext : IDataContext
    {
        private readonly IMongoDatabase db;
        public IMongoCollection<Client> ClientCollection { get; }
        public IMongoCollection<Driver> DriverCollection { get; }
        public IMongoCollection<Drive> DriveCollection { get; }
        public IMongoCollection<Package> PackageCollection { get; }

        public DataContext(IGetPackageDBSettings settings)
        {
            MongoClient dbClient = new MongoClient(settings.ConnectionString);
            db = dbClient.GetDatabase(settings.DatabaseName);
            ClientCollection = db.GetCollection<Client>(settings.ClientCollectionName);
            DriverCollection = db.GetCollection<Driver>(settings.DriverCollectionName);
            DriveCollection = db.GetCollection<Drive>(settings.DriveCollectionName);
            PackageCollection = db.GetCollection<Package>(settings.PackageCollectionName);
        }
        //public DataContext()
        //{
        //    MongoClient dbClient = new MongoClient("mongodb+srv://finalProject:41214121@getpackage.km4sihj.mongodb.net/?retryWrites=true&w=majority");
        //    db = dbClient.GetDatabase("getPackage");
        //    ClientCollection = db.GetCollection<Client>("clients");
        //    DriverCollection = db.GetCollection<Driver>("drivers");
        //    DriveCollection = db.GetCollection<Drive>("drives");
        //    PackageCollection = db.GetCollection<Package>("packages");
        //}














        //public IClientService Client { get;}
        //public IDriverService Driver { get;}    
        //public IDriveService Drive { get;}
        //public IPackageSrvice Package { get;}

        //public static MongoDatabase getPackageDB;

        //static DataContext myDataContext;

        //static object locker = new();
        //private DataContext(IClientService client, IDriverService driver, IDriveService drive, IPackageSrvice package) {

        //    MongoClient dbClient = new MongoClient("mongodb+srv://finalProject:41214121@getpackage.km4sihj.mongodb.net/?retryWrites=true&w=majority");
        //    MongoServer server = dbClient.GetServer();
        //    getPackageDB = server.GetDatabase("getPackage");
        //    Client = client;
        //    Driver = driver;
        //    Drive = drive;
        //    Package = package;
        //}
        //public static DataContext MyDataContext
        //{
        //    get
        //    {
        //        if (myDataContext == null)
        //        {
        //            lock (locker)
        //            {
        //                if (myDataContext == null)
        //                {
        //                    myDataContext = new DataContext();
        //                }
        //            }
        //        }
        //        return myDataContext;
        //    }
        //}

    }
}
