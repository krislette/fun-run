using FunRunRegistration.Models.Entities;
using Microsoft.Data.SqlClient;

namespace FunRunRegistration.Data
{
    public class ApplicationAdo
    {
        private readonly string _connectionString;
        public ApplicationAdo(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("RegistrationPortal")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        }

        // Method to insert an address using ADO.NET with SqlDataReader
        public async Task<int> InsertAddressAsync(Address address)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var query = @"
                    INSERT INTO Addresses (AddressStreet, AddressCity, AddressPostal)
                    VALUES (@AddressStreet, @AddressCity, @AddressPostal);
                    
                    SELECT CAST(SCOPE_IDENTITY() as int) as AddressId;";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AddressStreet", address.AddressStreet);
                    command.Parameters.AddWithValue("@AddressCity", address.AddressCity);
                    command.Parameters.AddWithValue("@AddressPostal", address.AddressPostal);

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return reader.GetInt32(0);
                        }
                        throw new Exception("Failed to insert address");
                    }
                }
            }
        }

        // Method to insert a registrant using ADO.NET with SqlDataReader
        public async Task InsertRegistrantAsync(Registrant registrant)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var query = @"
                    INSERT INTO Registrants (UserFirstName, UserLastName, UserAddressId, UserTelephone, UserBirthday, UserGender)
                    VALUES (@UserFirstName, @UserLastName, @UserAddressId, @UserTelephone, @UserBirthday, @UserGender);
                    
                    SELECT SCOPE_IDENTITY() as Id;";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserFirstName", registrant.UserFirstName);
                    command.Parameters.AddWithValue("@UserLastName", registrant.UserLastName);
                    command.Parameters.AddWithValue("@UserAddressId", registrant.UserAddressId);
                    command.Parameters.AddWithValue("@UserTelephone", registrant.UserTelephone);
                    command.Parameters.AddWithValue("@UserBirthday", registrant.UserBirthday);
                    command.Parameters.AddWithValue("@UserGender", registrant.UserGender);

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        await reader.ReadAsync();
                    }
                }
            }
        }
    }
}
