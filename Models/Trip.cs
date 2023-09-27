namespace ASP.NET_CRUD_APP.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal StartingMiles { get; set; }
        public decimal EndingMiles { get; set; }
        public decimal TotalMiles { get; set; }
        public decimal Stops { get; set; }
        public decimal TotalPay { get; set;}
        public int Pallets { get; set; }
        public bool IsTeamRoute { get; set; }

    }
}
