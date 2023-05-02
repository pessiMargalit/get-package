
namespace BL.BLImplementation
{
    public class PackageSrviceBL : IPackageSrviceBL
    {
        private IPackageSrvice packageService;
        IMapper mapper;
        public PackageSrviceBL(IPackageSrvice package, IMapper mapper)
        {
            packageService = package;
            this.mapper = mapper;
        }

        #region Create functions
        /// <summary>
        /// Call the Create function on Dal to create a new package.
        /// </summary>
        /// <param name="package"></param>
        /// <returns>
        /// Boolean, true if success to create a new package, false otherwise.
        /// </returns>
        public async Task<bool> CreateAsync(PackageDTO package)
        {
            try
            {
                if (package != null)
                {
                    Package p = mapper.Map<PackageDTO, Package>(package);
                    if (p != null)
                    {
                        return await packageService.CreateAsync(p);
                    }

                    else
                        throw new ArgumentNullException("The action failed, please try again later");
                }
                else throw new ArgumentNullException("The action failed, please try again later");
            }
            catch (ArgumentNullException ex) { throw ex; }
            catch (TimeoutException ex) { throw ex; }
            catch (Exception) { throw; }
        }
        #endregion

        public async Task<List<DriverDTO>?> CreateWithMatch(PackageDTO package)
        {
            List<DriverDTO> drivers = await MatchPackageToDriver.Match(package);

            if (package != null)
            {
                bool isCreate = await CreateAsync(package);
                if (isCreate && drivers.Any())
                {
                    package.IsMatch = true;
                    bool isUpdate = await UpdateAsync(package);
                    return drivers;

                }
                   
            }
            return null;
        }


        #region Get functions
        /// <summary>
        /// Call the GetAll function on Dal to get all packages.
        /// </summary>
        /// <returns>
        /// The list of all packages.
        /// </returns>
        public async Task<List<PackageDTO>> GetAllAsync()
        {
            try
            {
                List<PackageDTO> packageBL = new();
                var packages = await packageService.GetAllAsync();
                if (packages == null)
                    throw new ArgumentNullException("The action failed, please try again later");
                foreach (var package in packages)
                {
                    packageBL.Add(mapper.Map<Package, PackageDTO>(package));

                }
                return packageBL;
            }
            catch (ArgumentNullException ex) { throw ex; }
            catch (TimeoutException ex) { throw ex; }
            catch (Exception) { throw; }
        }
        /// <summary>
        /// Call the GetByIdAsync function on Dal to get a package from the DB according to the id it received
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// A package object.
        /// </returns>
        public async Task<List<PackageDTO>> GetByIdAsync(string id)
        {
            try
            {
                List<Package> packages = await packageService.GetByIdAsync(id);
                if (packages == null)
                    throw new ArgumentNullException("The package does'nt exist in our system");
                return mapper.Map<List<Package>, List<PackageDTO>>(packages);
            }
            catch (ArgumentNullException ex) { throw ex; }
            catch (TimeoutException ex) { throw ex; }
            catch (Exception) { throw; }

        }

        /// <summary>
        /// Call the GetByDriverIdAsync function on Dal to get a package from the DB according to the driver id it received
        /// </summary>
        /// <param name="driverId"></param>
        /// <returns>
        /// A package object.
        /// </returns>
        public async Task<List<PackageDTO>> GetByDriverIdAsync(string driverId)
        {
            try
            {
                List<Package> packages = await packageService.GetByDriverIdAsync(driverId);
                if (packages == null)
                    throw new ArgumentNullException("The package does'nt exist in our system");
                return mapper.Map<List<Package>, List<PackageDTO>>(packages);
            }
            catch (ArgumentNullException ex) { throw ex; }
            catch (TimeoutException ex) { throw ex; }
            catch (Exception) { throw; }

        }

        /// <summary>
        /// Call the GetByDriveIdAsync function on Dal to get a package from the DB according to the drive id it received
        /// </summary>
        /// <param name="driveId"></param>
        /// <returns>
        /// A package object.
        /// </returns>
        public async Task<List<PackageDTO>> GetByDriveIdAsync(string driveId)
        {
            try
            {
                List<Package> packages = await packageService.GetByDriveIdAsync(driveId);
                if (packages == null)
                    throw new ArgumentNullException("The package does'nt exist in our system");
                return mapper.Map<List<Package>, List<PackageDTO>>(packages);
            }
            catch (ArgumentNullException ex) { throw ex; }
            catch (TimeoutException ex) { throw ex; }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Call the GetByClientIdAsync function on Dal to get a package from the DB according to the client id it received
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns>
        /// A package object.
        /// </returns>
        public async Task<List<PackageDTO>> GetByClientIdAsync(string clientId)
        {
            try
            {
                List<Package> packages = await packageService.GetByClientIdAsync(clientId);
                if (packages == null)
                    throw new ArgumentNullException("The package does'nt exist in our system");
                return mapper.Map<List<Package>, List<PackageDTO>>(packages);
            }
            catch (ArgumentNullException ex) { throw ex; }
            catch (TimeoutException ex) { throw ex; }
            catch (Exception) { throw; }

        }
        #endregion

        #region Update functions
        /// <summary>
        /// Call the Update function on Dal to update a package.
        /// </summary>
        /// <param name="package"></param>
        /// <returns>
        /// Boolean, true if success to update the package details, false otherwise.
        /// </returns>
        public async Task<bool> UpdateAsync(PackageDTO package)
        {
            try
            {
                if (package != null)
                {
                    return await packageService.UpdateAsync(mapper.Map<PackageDTO, Package>(package));
                }
                else throw new ArgumentNullException("Failed to update package information, please try again later");
            }
            catch (ArgumentNullException ex) { throw ex; }
            catch (TimeoutException ex) { throw ex; }
            catch (Exception) { throw; }
        }
        #endregion

        #region Delete functions
        /// <summary>
        /// Call the Delete function on Dal to delete a package.
        /// </summary>
        /// <param name="details"></param>
        /// <returns>
        /// Boolean, true if success to delete a package, false otherwise.
        /// </returns>

        public async Task<bool> DeleteAsync(params string[] details)
        {
            try
            {
                if (details != null)
                {
                    return await packageService.DeleteAsync(details);
                }
                return false;
            }
            catch (ArgumentNullException ex) { throw ex; }
            catch (TimeoutException ex) { throw ex; }
            catch (Exception) { throw; }
        }



        #endregion
    }
}
