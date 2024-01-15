using System;
using System.Collections.Generic;
namespace DictionaryExample{
    class Test
    {
        static void Main()
        {
        Dictionary<string, object> Dt = new Dictionary<string, object>();
        Dt.Add("Name","Pankaj");
        Dt.Add("Class", "BE");
        Dt.Add("Branch","Comp");
        Dt.Add("Roll No",33);
        Dt.Add("Prn",72027946);

        foreach(string  key in Dt.Keys)
        {
            Console.WriteLine(key + " : " + Dt[key]);
        }
        }

    }
}