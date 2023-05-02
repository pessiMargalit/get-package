

namespace BL.BLImplementation
{
    internal class MatchPackageToDriver
    {
        private static IDriveServiceBL driveService;
        private static IDriverServiceBL driverService;

        public MatchPackageToDriver(IDriveServiceBL drive,IDriverServiceBL driver)
        {
            driveService = drive;
            driverService = driver;
        }

        public static async Task<List<DriverDTO>> Match(PackageDTO package)
        {
            List<DriveDTO> drives = await driveService.GetAllAsync();
            List<DriverDTO> drivers = new();
            DriverDTO driver;
            drives.ForEach(d =>
            {
                if (d.Source.City == package.Source.City && d.Destination.City == package.Destination.City)
                {
                    package.IsMatch = true;
                    driver = driverService.GetByIdAsync(d.DriverID).Result;
                    drivers.Add(driver);
                }
            });
            return drivers;
        }
    }
}
