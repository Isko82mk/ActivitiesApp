using Domain.DTO.ActivityDTO;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_Activities.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }


        [HttpGet("getAll")]
        public ActionResult<IEnumerable<GetAllActivityDto>> GetAll()
        {
            return Ok(_activityService.GetAll().ToList());
        }

        [HttpGet("getById")]
        public ActionResult<Activity> GetById(Guid Id)
        {
            return _activityService.GetById(Id);
        }


        [HttpPost("addActivity")]
        public ActionResult<Activity> AddActivity(AddActivityDto model)
        {
            return _activityService.Add(model);
        }

        [HttpPut("updateActivity")]
        public ActionResult<Activity> Update(EditActivityDto model)
        {
            return _activityService.Update(model);
        }

        [HttpDelete("delete")]
        public ActionResult<bool> Delete(Guid Id)
        {
           return Ok(_activityService.Delete(Id));
        }
    }
}
