using System;
namespace Taxi
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }
        public void TaxiInfo()
        {
            Console.WriteLine($"Driver Name: {DriverName}");
            Console.WriteLine($"On Duty: {(OnDuty? "Yes" : "No")}");
            Console.WriteLine($"Number of Passenger: {NumPassenger}");
        }
        public void PickupPassenger()
        {
            Console.WriteLine($"{DriverName} sedang menjemput penumpang");
        }
        public void DropOffPassenger()
        {
            Console.WriteLine($"{DriverName} selesai mengantar penumpang");
        }
    }
}