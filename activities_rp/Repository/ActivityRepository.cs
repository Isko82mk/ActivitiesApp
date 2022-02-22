using DataAccess;
using Domain.DTO.ActivityDTO;
using Domain.Model;
using Repository.Interfaces;
using System;
using System.Linq;

namespace Repository
{
    public class ActivityRepository : IActivityRepository
    {

        private readonly DataContext _context;

        public ActivityRepository(DataContext context)
        {
            _context = context;
        }

        public IQueryable<Activity> GetAll()
        {
            var activitesDb = _context.Activities;
            return activitesDb;
        }
        public Activity GetById(Guid Id)
        {
            var activityDb = _context.Activities.Find(Id);

            return activityDb;
        }
        public Activity Add(Activity activity)
        {
            _context.Activities.Add(activity);
            _context.SaveChanges();

            return activity;
        }
        public Activity Update(EditActivityDto model)
        {
            var activity = _context.Activities.Find(model.Id);


            activity.Title = model.Title;
            activity.Description = model.Description;
            activity.Category = model.Category;
            activity.City = model.City;
            activity.Venue = model.Venue;

            _context.SaveChanges();

            return activity;

        }
        public bool Delete(Guid Id)
        {
            var activity = _context.Activities.Find(Id);
            if (activity != null)
            {
                _context.Activities.Remove(activity);
                _context.SaveChanges();

                return true;
            }

            return false;
        }

    }
}
