using System;

namespace PubOOChallenge;
public class Bill
{
    public char Gender;
    public int Beer = 0;
    public int Barbecue = 0;
    public int SoftDrink = 0;

    public double Feeding()
    {
        return Beer * 5.0 + Barbecue * 7.0 + SoftDrink * 3.0;
    }

    public double Cover()
    {
        if ( Feeding() < 30.0)
        {
            return 4.0;
        }
        else
        {
            return 0.0;
        }
    }

    public double Ticket()
    {
        if ( Gender == 'F')
        {
            return 8.0;
        }
        else
        {
            return 10.0;
        }
    }

    public double Total()
    {
        return Cover() + Feeding() + Ticket();
    }
}
