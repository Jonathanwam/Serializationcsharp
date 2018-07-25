using System;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.id = 5;
            c.info = "First Customer!";
            BinarySerialization(c);
        }
        static Customer BinarySerialization(Customer customer){
            IFormatter formatter = new BinaryFormatter();
            Console.WriteLine("");
            Console.WriteLine("Serializing...");

            // write to file
            Stream streamWrite = new FileStream("C:\\Users\\Jonathan\\Documents\\test.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(streamWrite, customer);
            streamWrite.Close();
            Console.WriteLine("Serializing... done!");

            // read from file
            Console.WriteLine();
            Console.WriteLine("Deserializing");
            Stream streamRead = new FileStream("C:\\Users\\Jonathan\\Documents\\test.txt", FileMode.Open, FileAccess.Read);
            Customer newCustomer = (Customer) formatter.Deserialize(streamRead);
            streamRead.Close();
            Console.WriteLine("Deserializing... done!");
            return newCustomer;
        }
        
    }
}
