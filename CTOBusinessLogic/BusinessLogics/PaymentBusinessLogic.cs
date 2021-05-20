using CTOBusinessLogic.BindingModels;
using CTOBusinessLogic.Interfaces;
using CTOBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTOBusinessLogic.BusinessLogics
{
    public class PaymentBusinessLogic
    {
        private readonly IPaymentStorage paymentStorage;

        public PaymentBusinessLogic(IPaymentStorage paymentStorage)
        {
            this.paymentStorage = paymentStorage;
        }

        public List<PaymentViewModel> Read(PaymentBindingModel model)
        {
            if (model == null)
            {
                return paymentStorage.GetFullList();
            }

            if (model.Id.HasValue)
            {
                return new List<PaymentViewModel> { paymentStorage.GetElement(model) };
            }

            return paymentStorage.GetFilteredList(model);
        }
        //public void CreateOrUpdate(CreatePaymentBindingModel model)
        //{
        //    var payment = new PaymentBindingModel
        //    {
        //        Id = model.Id,
        //        Prepayment = model.Prepayment,
        //        ClientId = model.ClientId,
        //        DishId = model.DishId,
        //        DateCreate = model.DateCreate
        //    };

        //    if (model.Id.HasValue)
        //    {
        //        paymentStorage.Update(payment);
        //    }
        //    else
        //    {
        //        paymentStorage.Insert(payment);
        //    }
        //}

        public void Delete(PaymentBindingModel model)
        {
            var payment = paymentStorage.GetElement(
                new PaymentBindingModel
                {
                    Id = model.Id
                });

            if (payment == null)
            {
                throw new Exception("Оплата не внесена");
            }

            paymentStorage.Delete(model);
        }
    }
}
