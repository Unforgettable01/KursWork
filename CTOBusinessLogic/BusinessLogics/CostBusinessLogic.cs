using CTOBusinessLogic.BindingModels;
using CTOBusinessLogic.Interfaces;
using CTOBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTOBusinessLogic.BusinessLogics
{
    public class CostBusinessLogic
    {
        private readonly ICostStorage costStorage;

        public CostBusinessLogic(ICostStorage costStorage)
        {
            this.costStorage = costStorage;
        }

        public List<CostViewModel> Read(CostBindingModel model)
        {
            if (model == null)
            {
                return costStorage.GetFullList();
            }

            if (model.Id.HasValue)
            {
                return new List<CostViewModel> { costStorage.GetElement(model) };
            }

            return costStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(CostBindingModel model)
        {
            var costItem = costStorage.GetElement(
                new CostBindingModel
                {
                    Name = model.Name
                });

            if (costItem != null && costItem.Id != model.Id)
            {
                throw new Exception("Статья расходов с таким названием уже существует");
            }

            if (model.Id.HasValue)
            {
                costStorage.Update(model);
            }
            else
            {
                costStorage.Insert(model);
            }
        }

        public void Delete(CostBindingModel model)
        {
            var cost = costStorage.GetElement(
                new CostBindingModel
                {
                    Id = model.Id
                });

            if (cost == null)
            {
                throw new Exception("Статья расходов не найдена");
            }

            costStorage.Delete(model);
        }
    }
}
