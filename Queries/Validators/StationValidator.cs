using System.Collections.Generic;
using Queries.Entities;
using System.Text.RegularExpressions;

namespace Queries.Validators
{
    public class StationValidator
    {
        public bool CheckAddition(Station st, out List<string> errorList)
        {
            const string pattern = "^[А-ЯA-Z]{1}[а-яa-z]+ ?([А-ЯA-Z]{1}[а-яa-z]+ )?[0-9]+$";
            var rgx = new Regex(pattern);
            errorList = new List<string>();
            var checkFlag = true;
            if (st.OrgName == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Название организации не задано!");
            }
            if (st.Country == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Страна не задана!");
            }
            if (st.City == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Город не задан!");
            }
            if (st.Street == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Улица не задана!");
            }
            if (st.Street != string.Empty)
            {
                var matches = rgx.Match(st.Street);
                if (!matches.Success)
                {
                    checkFlag = false;
                    errorList.Add("Улица задана неверно!");
                }
            }
            if (st.StarageCap < 300)
            {
                checkFlag = false;
                errorList.Add("Хранилище топлива должно хранить минимум 300 литров!");
            }

            return checkFlag;
        }
    }
}
