using System;

namespace Queries.Entities
{
    public class Accounting
    {
        public int StationId { get; }
        public string AccountRole { get; }
        public string FuelType { get; }
        public int AccountAmount { get; }
        public DateTime Date { get; }

        public Accounting(int stationId, string accountRole, string fuelAccountType, int fuelAccountAmount, DateTime accountDate)
        {
            StationId = stationId;
            AccountRole = accountRole;
            FuelType = fuelAccountType;
            AccountAmount = fuelAccountAmount;
            Date = accountDate;
        }
    }
}
