using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Validators
{
    public class DealValidator
    {
        public bool CheckAddition(Deal deal, out List<string> errorList)
        {
            errorList = new List<string>();
            var checkFlag = true;
            if (deal.FuelType == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Тип топлива не выбран!");
            }
            if (deal.FuelAmount <= 0)
            {
                checkFlag = false;
                errorList.Add("Количество топлива введено неверно!");
            }
            if (deal.DealPrice <= 0)
            {
                checkFlag = false;
                errorList.Add("Цена сделки задана неверно!");
            }
            //if (deal.GetDealDate().DayOfYear != DateTime.Now.DayOfYear && deal.GetDealDate().Year != DateTime.Now.Year)
            //{
            //    checkFlag = false;
            //    errorList.Add("Дата задана неверно!");
            //}

            return checkFlag;
        }

        public bool CheckUpdate(int id, Deal deal, out List<string> errorList)
        {
            errorList = new List<string>();
            var checkFlag = true;
            if (deal.CarId < 0)
            {
                checkFlag = false;
                errorList.Add("Покупатель не обнаружен!");
            }
            if (deal.FuelType == String.Empty)
            {
                checkFlag = false;
                errorList.Add("Тип топлива не выбран!");
            }
            if (deal.FuelAmount <= 0)
            {
                checkFlag = false;
                errorList.Add("Количество топлива введено неверно!");
            }
            if (deal.DealPrice <= 0)
            {
                checkFlag = false;
                errorList.Add("Цена сделки задана неверно!");
            }

            return checkFlag;
        }
    }
}
