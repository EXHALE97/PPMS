using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Validators
{
    public class StaffValidator
    {

        public bool CheckAddition(Employee wk, out List<string> errorList)
        {
            errorList = new List<string>();
            var checkFlag = true;
            if (wk.StationId <= 0)
            {
                checkFlag = false;
                errorList.Add("Станция не выбрана!");
            }
            if (wk.SurName == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Фамилия не задана!");
            }
            if (wk.Name == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Имя не задано!");
            }
            if (wk.Gender == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Пол не выбран!");
            }
            if (wk.BirthDate.Year > 2000 || wk.BirthDate.Year < 1955)
            {
                checkFlag = false;
                errorList.Add("Возраст указан неверно!");
            }
            if (wk.Position == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Должность не задана!");
            }
            if (wk.Salary < 500)
            {
                checkFlag = false;
                errorList.Add("Зарплата не может быть дробным числом или быть меньше 500 у.е!");
            }

            return checkFlag;
        }

        public bool CheckUpdate(int id, Employee wk, out List<string> errorList)
        {
            errorList = new List<string>();
            var checkFlag = true;
            if (wk.SurName == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Фамилия не задана!");
            }
            if (wk.Name == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Имя не задано!");
            }
            if (wk.Position == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Должность не задана!");
            }
            if (wk.Salary < 500)
            {
                checkFlag = false;
                errorList.Add("Зарплата не может быть меньше 500 у.е!");
            }
            if (id < 0)
            { checkFlag = false; }

            return checkFlag;
        }

        public bool CheckDelete(int id, out List<string> errorList)
        {
            errorList = new List<string>();
            var checkFlag = true;
            if (id < 0)
            {
                checkFlag = false;
                errorList.Add("Сотрудник не обнаружен!");
            }

            return checkFlag;
        }
    }
}
