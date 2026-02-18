// See https://aka.ms/new-console-template for more information

PowerPlant station = new PowerPlant();

station.AddWarning(Alert);
station.AddWarning(NotifyAuthorities);
Console.WriteLine("Varmer op...");
for (int i = 0; i < 5; i++) {
    station.HeatUp();
}
static void Alert() {
    Console.WriteLine("ADVARSEL: Kraftværket er for varmt!");
}

static void NotifyAuthorities() {
    Console.WriteLine("Log: Myndighederne er blevet underrettet om varmen.");
}

public delegate void Warning();


public class PowerPlant 
{
    private Warning? warningCallBack;
    public void AddWarning(Warning callBack) 
    {
        warningCallBack += callBack;
    }

    public void HeatUp() 
    {
        Random random = new Random();
        int randomTal = random.Next(0, 100);
        
        if (randomTal > 50) 
        {
            warningCallBack?.Invoke();
        }
    }
}