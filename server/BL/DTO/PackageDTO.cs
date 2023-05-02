

namespace BL.DTO
{
    public class PackageDTO
    {
        public string _Id { get; set; }
        public string DriverId { get; set; }
        public string DriveId { get; set; }
        public string HostId { get; set; }
        public int PhoneOfdestination { get; set; }
        public AddressDTO Source { get; set; }
        public AddressDTO Destination { get; set; }
        public Size Size { get; set; }
        public bool IsMatch { get; set; } = false;
        public bool IsTaken { get; set; } = false;
        public PackageDTO()
        {

        }
        public PackageDTO(string hostId, int phoneOfdestination, AddressDTO source, AddressDTO destination, Size size)
        {
            HostId = hostId;
            PhoneOfdestination = phoneOfdestination;
            Source = source;
            Destination = destination;
            Size = size;

        }

        public PackageDTO(string driverId, string driveId, string hostId, int phoneOfdestination, AddressDTO source, AddressDTO destination, Size size)
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
