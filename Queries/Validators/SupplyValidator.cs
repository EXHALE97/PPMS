using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Validators
{
    public class SupplyValidator
    {

        public bool CheckAddition(Supply sup, out List<string> errorList)
        {
            errorList = new List<string>();
            var checkFlag = !(sup.StationId < 0);
            if (sup.StaffId < 0)
            {
                checkFlag = false;
            }
            if (sup.SupplyType == String.Empty)
            {
                checkFlag = false;
                errorList.Add("Тип топлива не выбран!");
            }
            if (sup.SupplyAount <= 0)
            {
                checkFlag = false;
                errorList.Add("Количество топлива задано неправильно!");
            }

            return checkFlag;
        }
    }
}
