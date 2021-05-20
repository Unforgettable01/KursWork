﻿using CTOBusinessLogic.BindingModels;
using CTOBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace CTOBusinessLogic.Interfaces
{
    public interface IWorkStorage
    {
        List<WorkViewModel> GetFullList();
        List<WorkViewModel> GetFilteredList(WorkBindingModel model);
        WorkViewModel GetElement(WorkBindingModel model);
        void Insert(WorkBindingModel model);
        void Update(WorkBindingModel model);
        void Delete(WorkBindingModel model);
    }
}
