namespace SerializationDeSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SerializeAndDesearialize sd = new SerializeAndDesearialize();
            sd.SerialIzationBinaryWithString();
            Console.WriteLine("\n");
            sd.DeSerializationBinaryWithString();
            sd.SerialIzationBinaryWithObject();
            Console.WriteLine("\n");
            sd.DeSerializationBinaryWithObject();
            sd.ListOfSerialIzationBinaryWithObject();
            Console.WriteLine("\n");
            sd.ListOfDeSerialIzationBinaryWithObject();
            sd.UsingXmlSerialiZation();
            Console.WriteLine("\n");
            sd.UsingXmlDeSerialiZation();
            Console.ReadLine();
        }
    }
}