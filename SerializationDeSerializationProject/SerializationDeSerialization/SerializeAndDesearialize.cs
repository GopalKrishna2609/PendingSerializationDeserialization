using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace SerializationDeSerialization
{
    public class SerializeAndDesearialize
    {
        EB_bill ebBill = new EB_bill();
        public void SerialIzationBinaryWithString()
        {
            string name = "My Name Is Gopal Krishna Banger";

            FileStream fileStream = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\Serialization&Deserialization\stringmyfile1.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, name);
            fileStream.Close();

        }
        public void DeSerializationBinaryWithString()
        {
            FileStream fs = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\Serialization&Deserialization\stringmyfile1.txt", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            string name = (string)binaryFormatter.Deserialize(fs);
            Console.WriteLine(name);
        }
        public void SerialIzationBinaryWithObject()
        {
            ebBill.CustId = 1001;
            ebBill.CustName = "Ajeet Mishra";
            ebBill.ProductName = "Soap";
            ebBill.NoOfItems = 420;
            ebBill.UnitPerCost = 20;
            FileStream fileStream = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\Serialization&Deserialization\objectmyfile1.txt", FileMode.Create);
            BinaryFormatter binFormatter = new BinaryFormatter();
            binFormatter.Serialize(fileStream, ebBill);
            fileStream.Close();

        }
        public void DeSerializationBinaryWithObject()
        {
            FileStream fileStream = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\Serialization&Deserialization\objectmyfile1.txt", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            EB_bill eB = (EB_bill)binaryFormatter.Deserialize(fileStream);
            Console.WriteLine(eB.CustId);
            Console.WriteLine(eB.CustName);
            Console.WriteLine(eB.ProductName);
            Console.WriteLine(eB.NoOfItems);
            Console.WriteLine(eB.UnitPerCost);
            fileStream.Close();




        }
        public void ListOfSerialIzationBinaryWithObject()
        {
            List<EB_bill> eB_Bills = new List<EB_bill>();
            EB_bill bill1 = new EB_bill();
            bill1.CustId = 1002;
            bill1.CustName = "Rahul Singh";
            bill1.ProductName = "T-Shirt" ;
            bill1.NoOfItems = 4;
            bill1.UnitPerCost = 200;
            eB_Bills.Add(bill1);
            EB_bill bill2 = new EB_bill();
            bill2.CustId = 1003;
            bill2.CustName = "Rakesh Singh";
            bill2.ProductName = "Mobile";
            bill2.NoOfItems = 1;
            bill2.UnitPerCost = 20000;
            eB_Bills.Add(bill2);

            FileStream fileStream = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\Serialization&Deserialization\listmyfile1.txt", FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, eB_Bills);
            fileStream.Close();
        }

        public void ListOfDeSerialIzationBinaryWithObject()
        {

            FileStream fileStream = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\Serialization&Deserialization\listmyfile1.txt", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            List<EB_bill> eB_Bills = (List<EB_bill>)binaryFormatter.Deserialize(fileStream);
            foreach (EB_bill eB in eB_Bills)
            {
                Console.WriteLine(eB.CustId);
                Console.WriteLine(eB.CustName);
                Console.WriteLine(eB.ProductName);
                Console.WriteLine(eB.NoOfItems);
                Console.WriteLine(eB.UnitPerCost);

            }
            fileStream.Close();
        }
        public void UsingXmlSerialiZation()
        {
            EB_bill eB_Bill = new EB_bill();
            eB_Bill.CustId = 1001;
            eB_Bill.CustName = "Umang Ahuja";
            eB_Bill.ProductName ="Water Bag";
            eB_Bill.NoOfItems = 45;
            eB_Bill.UnitPerCost = 2;
            FileStream fileStream = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\Serialization&Deserialization\xmlmyfile1.txt", FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(EB_bill));
            xmlSerializer.Serialize(fileStream, eB_Bill);
            fileStream.Close();


        }
        public void UsingXmlDeSerialiZation()
        {
            FileStream fileStream = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\Serialization&Deserialization\xmlmyfile1.txt", FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(EB_bill));
            EB_bill eB_Bill = (EB_bill)xmlSerializer.Deserialize(fileStream);
            Console.WriteLine(eB_Bill.CustId);
            Console.WriteLine(eB_Bill.CustName);
            Console.WriteLine(eB_Bill.ProductName);
            Console.WriteLine(eB_Bill.NoOfItems);
            Console.WriteLine(eB_Bill.UnitPerCost);

        }



    }
}