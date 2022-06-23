namespace SerializationDeSerialization
{
    [Serializable]
    public class EB_bill
    {
        public int CustId { get; set; }
        public string? CustName { get; set; }
        public string? ProductName { get; set; }

        public int NoOfItems { get; set; }
        public int UnitPerCost { get; set; }
       
       
    }
}
