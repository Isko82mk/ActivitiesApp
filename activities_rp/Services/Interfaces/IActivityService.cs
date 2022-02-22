using Domain.DTO.ActivityDTO;
using Domain.Model;
using System;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IActivityService
    {
        IEnumerable<GetAllActivityDto> GetAll();
        Activity GetById(Guid Id);
        Activity Add(AddActivityDto model);
        Activity Update(EditActivityDto model);
        bool Delete(Guid Id);

    }
}
