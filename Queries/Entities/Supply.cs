using System;

namespace Queries.Entities
{
    public class Supply
    {
        public int StationId { private set; get; }
        public int StaffId { private set; get; }
        public string SupplyType { private set; get; }
        public int SupplyAount { private set; get; }
        public DateTime SupplyDate { private set; get; }

        public Supply(int stationId, int staffId, string fuelsupplytype, int fuelsupplyamount, DateTime supplydate)
        {
            StationId = stationId;
            StaffId = staffId;
            SupplyType = fuelsupplytype;
            SupplyAount = fuelsupplyamount;
            SupplyDate = supplydate;
        }
    }
}
