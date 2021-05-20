using CTOBusinessLogic.BindingModels;
using CTOBusinessLogic.Interfaces;
using CTOBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTOBusinessLogic.BusinessLogics
{
    public class WorkerBusinessLogic
    {
        private readonly IWorkerStorage storage;

        public WorkerBusinessLogic(IWorkerStorage storage)
        {
            this.storage = storage;
        }

        public List<WorkerViewModel> Read(WorkerBindingModel model)
        {
            if (model == null)
            {
                return storage.GetFullList();
            }

            if (model.Id.HasValue)
            {
                return new List<WorkerViewModel> { storage.GetElement(model) };
            }

            return storage.GetFilteredList(model);
        }

        public void CreateOrUpdate(WorkerBindingModel model)
        {
            var worker = storage.GetElement(
                new WorkerBindingModel
                {
                    Login = model.Login
                });

            if (worker != null && worker.Id != model.Id)
            {
                throw new Exception("Данная почта для работника  зарегестрирована!");
            }

            if (model.Id.HasValue)
            {
                storage.Update(model);
            }
            else
            {
                storage.Insert(model);
            }
        }

        public void Delete(WorkerBindingModel model)
        {
            var waiter = storage.GetElement(
                new WorkerBindingModel
                {
                    Id = model.Id
                });

            if (waiter == null)
            {
                throw new Exception("Работник не найден");
            }

            storage.Delete(model);
        }

        public bool Login(WorkerBindingModel model)
        {
            var worker = storage.GetElement(
                new WorkerBindingModel
                {
                    Login = model.Login
                });

            if (worker == null || !worker.Password.Equals(model.Password))
            {
                throw new Exception("Работник c такими данными не найден");
            }
            return true;
        }
    }
}
