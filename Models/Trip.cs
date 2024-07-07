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
        public decimal TotalPay { get; set; }
        public int Pallets { get; set; }
        public bool IsTeamRoute { get; set; }
        public decimal SuperStop { get; set; }
        public decimal DelayPay { get; set; }
        public decimal PerDiem { get; set; }
        public decimal CrossDock { get; set; }
        public decimal ShuttleStop { get; set; }
        public decimal BackHaul { get; set; }
        public decimal HourlyPay { get; set; }
        public decimal ChainUp { get; set; }
        public decimal Doubles { get; set; }
        public decimal PreTrip { get; set; }
        public decimal PostTrip { get; set; }
    }
}