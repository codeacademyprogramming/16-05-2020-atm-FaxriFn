class Card
{

    public string PAN;
    public string PIN { get; set; }
    public string CVC;
    public string ExpireDate;
    public decimal Balans;

    public Card(string pAN, string pIN, string cVC, string expireDate, int balans)
    {
        PAN = pAN;
        PIN = pIN;
        CVC = cVC;
        ExpireDate = expireDate;
        Balans = balans;
    }
}
