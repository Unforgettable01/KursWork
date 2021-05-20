using CTOBusinessLogic.BindingModels;
using CTOBusinessLogic.BusinessLogics;
using CTOBusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly WorkerBusinessLogic _logic;
        public WorkerController(WorkerBusinessLogic logic)
        {
            _logic = logic;
        }
        [HttpGet]
        public WorkerViewModel Login(string login, string password) => _logic.Read(new
       WorkerBindingModel
        { Login = login, Password = password })?[0];
        [HttpPost]
        public void Register(WorkerBindingModel model) => _logic.CreateOrUpdate(model);
        [HttpPost]
        public void UpdateData(WorkerBindingModel model) => _logic.CreateOrUpdate(model);
    }
}
