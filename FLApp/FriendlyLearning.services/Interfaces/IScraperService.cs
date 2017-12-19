using FriendlyLearning.Models.cs.Domain;
using System.Collections.Generic;

namespace FriendlyLearning.services
{
    public interface IScraperService
    {
        AnimalModels GetAll();
    }
}