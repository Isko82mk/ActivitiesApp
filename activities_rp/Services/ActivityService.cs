using Domain.DTO.ActivityDTO;
using Domain.Model;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }


        public IEnumerable<GetAllActivityDto> GetAll()
        {
            var activities = _activityRepository.GetAll().Select(x => new GetAllActivityDto
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Category = x.Category,
                City = x.City,
                Date = x.Date,
                Venue = x.Venue,
            }).AsEnumerable();

            return activities;
        }

        public Activity GetById(Guid Id)
        {
            return _activityRepository.GetById(Id);
        }

        public Activity Add(AddActivityDto model)
        {
            return _activityRepository.Add(new Activity
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                Category = model.Category,
                City = model.City,
                Date = model.Date,
                Venue = model.Venue,
            });


        }

        public Activity Update(EditActivityDto model)
        {
           return  _activityRepository.Update(model);
        }

        public bool Delete(Guid Id)
        {
          return  _activityRepository.Delete(Id);
        }

    }
}
