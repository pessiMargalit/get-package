

namespace Dal.Models
{
    public class Drive
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }
        public string DriverID { get; set; }
        public Address Source { get; set; }
        public Address Destination { get; set; }
        public Drive()
        {

        }

        public Drive(string driverID, Address source, Address destination)
        {
            _Id = "";
            DriverID = driverID;
            Source = source;
            Destination = destination;
        }
    }
}
