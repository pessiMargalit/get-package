

namespace BL.DTO
{
    public class DriveDTO
    {
        public string _Id { get; set; }
        public string DriverID { get; set; }
        public AddressDTO Source { get; set; }
        public AddressDTO Destination { get; set; }
        public List<PackageDTO> Packages { get; set; }
        public DriveDTO()
        {
            Packages = new();
        }
        public DriveDTO(string driverID, AddressDTO source, AddressDTO destination)
        {
            _Id = "";
            DriverID = driverID;
            Source = source;
            Destination = destination;
            Packages = new();
        }
    }
}
