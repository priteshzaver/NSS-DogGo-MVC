using System.Collections.Generic;
using DogGo.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DogGo.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly IConfiguration _config;
        public OwnerRepository(IConfiguration config)
        {
            _config = config;
        }
        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }
        public List<Owner> GetAllOwners()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT Id, Email, [Name], [Address], NeighborhoodId, Phone
                                        FROM Owner";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Owner> owners = new List<Owner>();
                        while (reader.Read())
                        {
                            Owner owner = new Owner
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),
                                NeighborhoodId = reader.GetInt32(reader.GetOrdinal("NeighborhoodId")),
                                Phone = reader.GetString(reader.GetOrdinal("Phone"))
                            };
                            owners.Add(owner);
                        }
                        return owners;
                    }
                }
            }
        }
        public Owner GetOwnerById(int id)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT o.Id, o.Email, o.[Name], o.[Address], o.NeighborhoodId, o.Phone, d.Id as DogId, d.OwnerId, d.Name as DogName
                                        FROM Owner o
                                        JOIN Dog d ON o.Id = d.OwnerId
                                        WHERE o.Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    Owner owner = null;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        if (owner == null)
                        {
                            owner = new Owner
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),
                                NeighborhoodId = reader.GetInt32(reader.GetOrdinal("NeighborhoodId")),
                                Phone = reader.GetString(reader.GetOrdinal("Phone"))                                
                            };                            
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("DogId")))
                        {
                                owner.Dogs.Add(new Dog()
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("DogId")),
                                    Name = reader.GetString(reader.GetOrdinal("DogName"))
                                });
                        }
                    }
                    return owner;
                }
            }
        }
    }
}
