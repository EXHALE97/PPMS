using System;

namespace Queries.Entities
{
    public class Deal
    {
        public int Id { private set; get; }
        public int CarId { private set; get; }
        public int StaffId { private set; get; }
        public string FuelType { private set; get; }
        public int FuelAmount { private set; get; }
        public int DealPrice { private set; get; }
        public DateTime DealDate { private set; get; }


        public Deal(int deadId, int carId, int staffId, string fueltype, int fuelamount, int dealprice, DateTime dealdate)
        {
            Id = deadId;
            CarId = carId;
            StaffId = staffId;
            FuelType = fueltype;
            FuelAmount = fuelamount;
            DealPrice = dealprice;
            DealDate = dealdate;
        }

        public Deal(string fueltype, int fuelamount, int dealprice, DateTime dealdate)
        {
            FuelType = fueltype;
            FuelAmount = fuelamount;
            DealPrice = dealprice;
            DealDate = dealdate;
        }

        public Deal (int carId, string fueltype, int fuelamount, int dealprice, DateTime dealdate)
        {
            CarId = carId;
            FuelType = fueltype;
            FuelAmount = fuelamount;
            DealPrice = dealprice;
            DealDate = dealdate;
        }
    }
}
