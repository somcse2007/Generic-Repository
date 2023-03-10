using Api.Models;
using Core.Model;
using Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    public class StudentController : ApiController
    {

        private readonly IStudentService _studentService;

        //Test
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpPost]
        [Route(nameof(InsertStudents))]
        public async Task<HttpResponseMessage> InsertStudents(Student model)
        {
            try
            {
                var result = 0;
                await Task.Run(() =>
                {
                    result = _studentService.InsertStudents(model);
                });

                if (result == 0)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { result });

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.Created, new { result });
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandle.Log("End", ExceptionHandle.PageLogType.AppError, ex, JsonConvert.SerializeObject(planInfo), nameof(UpdatePremisePlan));
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }


        }



    }
}
