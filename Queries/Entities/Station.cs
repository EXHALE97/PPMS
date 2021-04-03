namespace Queries.Entities
{
    public class Station
    {
        public int StationId { private set; get; }
        public string OrgName { private set; get; }
        public string Country { private set; get; }
        public string City { private set; get; }
        public string Street { private set; get; }
        public int StarageCap { private set; get; }

        public Station(int stationId, string orgname, string country, string city, string street, int storagecap)
        {
            StationId = stationId;
            OrgName = orgname;
            Country = country;
            City = city;
            Street = street;
            StarageCap = storagecap;
        }

        public Station(string orgname, string country, string city, string street, int storagecap)
        {
            OrgName = orgname;
            Country = country;
            City = city;
            Street = street;
            StarageCap = storagecap;
        }
    }
}
