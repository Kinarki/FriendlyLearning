using FriendlyLearning.Models.cs.Domain;
using System.Collections.Generic;

namespace FriendlyLearning.Services.Interfaces
{
    public interface IScraperService
    {
        List<AnimalModels> GetAll();
    }
}