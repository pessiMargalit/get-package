

namespace Dal.Models
{
    public class Package
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }
        public string DriverId { get; set; }
        public string DriveId { get; set; }
        public string HostId { get; set; }
        public int PhoneOfdestination { get; set; }
        public Address Source { get; set; }
        public Address Destination { get; set; }
        public Size Size { get; set; }
        public bool IsMatch { get; set; } = false;
        public bool IsTaken { get; set; } = false;
        public Package()
        {

        }
        public Package(string hostId, int phoneOfdestination, Address source, Address destination, Size size)
        {
            HostId = hostId;
            PhoneOfdestination = phoneOfdestination;
            Source = source;
            Destination = destination;
            Size = size;

        }

        public Package(string driverId, string driveId, string hostId, int phoneOfdestination, Address source, Address destination, Size size)
        {
            _Id = "";
            DriverId = driverId;
            DriveId = driveId;
            HostId = hostId;
            PhoneOfdestination = phoneOfdestination;
            Source = source;
            Destination = destination;
            Size = size;
        }


    }
}
