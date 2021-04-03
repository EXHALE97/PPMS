using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Validators
{
    public class CarValidator
    {
        public bool CheckAddition(Client car, out List<string> errorList)
        {
            errorList = new List<string>();
            var checkFlag = true;
            if (car.Mark == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Марка и модель автомобиля не задана!");
            }
            if (car.CardNum == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Номер карты не задан!");
            }

            return checkFlag;
        }
    }
}
