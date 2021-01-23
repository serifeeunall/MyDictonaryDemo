using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,string> myDictionary = new MyDictionary<string,string>();
            myDictionary.Add("one" , "bir");
            myDictionary.Add("two", "iki");
            myDictionary.Add("three", "üç");
            myDictionary.Add("four", "dört");
            myDictionary.Add("five", "beş");

            myDictionary.Read();
           
        }
    }
}
