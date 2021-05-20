using CTOBusinessLogic.BindingModels;
using CTOBusinessLogic.Enums;
using CTOBusinessLogic.Interfaces;
using CTOBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace CTOBusinessLogic.BusinessLogics
{
    public class RequestBusinessLogic
    {
        private readonly IRequestStorage _requestStorage;
        public RequestBusinessLogic(IRequestStorage requestStorage)
        {
            _requestStorage = requestStorage;
        }
        public List<RequestViewModel> Read(RequestBindingModel model)
        {
            if (model == null)
            {
                return _requestStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<RequestViewModel> { _requestStorage.GetElement(model) };
            }
            return _requestStorage.GetFilteredList(model);
        }
       
        public void TakeRequestInWork(ChangeStatusBindingModel model)
        {
            var request = _requestStorage.GetElement(new RequestBindingModel
            {
                Id =
           model.RequestId
            });
            if (request == null)
            {
                throw new Exception("Заявка не найдена");
            }
            if (request.Status != RequestStatus.Принят)
            {
                throw new Exception("Заявка не в статусе \"Принята\"");
            }
            _requestStorage.Update(new RequestBindingModel
            {
                Id = request.Id,
                WorkId = request.WorkId,
                Sum = request.Sum,
                DatePay = request.DateCreate,
                Status = RequestStatus.Выполняется
            });
        }
        public void FinishRequest(ChangeStatusBindingModel model)
        {
            var request = _requestStorage.GetElement(new RequestBindingModel
            {
                Id = model.RequestId
            });
            if (request == null)
            {
                throw new Exception("Не найдена заявка");
            }
            if (request.Status != RequestStatus.Выполняется)
            {
                throw new Exception("Заявка не в статусе \"Выполняется\"");
            }
            _requestStorage.Update(new RequestBindingModel
            {
                Id = request.Id,
                WorkId = request.WorkId,
                Sum = request.Sum,
                DatePay = request.DateCreate,
                Status = RequestStatus.Готов
            });
        }
        public void PayRequest(ChangeStatusBindingModel model)
        {
            {
                var request = _requestStorage.GetElement(new RequestBindingModel 
                { Id = model.RequestId });

                if (request == null)
                {
                    throw new Exception("Заявка не найдена");
                }

                if (request.Status != RequestStatus.Готов)
                {
                    throw new Exception("Заявка не в статусе \"Готова\"");
                }

                _requestStorage.Update(new RequestBindingModel
                {
                    Id = request.Id,
                    WorkId = request.WorkId,
                    Sum = request.Sum,
                    DatePay = request.DateCreate,
                    Status = RequestStatus.Оплачен
                });
            }
        }
    }
}
