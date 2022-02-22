using Domain.DTO.ActivityDTO;
using Domain.Model;
using System;
using System.Linq;

namespace Repository.Interfaces
{
    public interface IActivityRepository
    {
        IQueryable<Activity> GetAll();
        Activity GetById(Guid Id);
        Activity Add(Activity activity);
        Activity Update(EditActivityDto model);
        bool Delete(Guid Id);

    }
}
