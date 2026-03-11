namespace Parking.Models;

public class ParkingTicketMachine {
    public int AmountInserted { get; set; }
    public DateTime TimeNow { get;}
    public string TimeNowString => TimeNow.ToString("HH:mm");
    public DateTime PaidUntil => TimeNow.AddMinutes(AmountInserted / 2 * 6);
    public string PaidUntilString => PaidUntil.ToString("HH:mm");


    public ParkingTicketMachine() {
        AmountInserted = 0;
        TimeNow = DateTime.Now;
    }

    public void InsertCoin(int kr) {
        AmountInserted += kr;
    }
}