using DogGo.Models;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IWalkerRepository
    {
        List<Walker> GetAllWalkers();
        Walker GetWalkerById(int id);
        Walker GetWalkerByEmail(string email);
        void AddWalker(Walker walker);
        void UpdateWalker (Walker walker);
        void DeleteWalker(int walkerId);
        List<Walker> GetWalkersInNeighborhood(int neighborhoodId);
    }
}
