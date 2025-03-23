using System;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace Program
{
    class NameCard
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            //p652
            var fileName = "a.json";
            using (Stream ws = new FileStream(fileName, FileMode.Create))
            {
                NameCard nc = new NameCard()
                {
                    Name = "Park",
                    Phone = "010-123-4567",
                    Age = 33
                };
                string jsonString=JsonSerializer.Serialize<NameCard>(nc);
                byte[] jsonBytes=System.Text.Encoding.UTF8.GetBytes(jsonString);
                ws.Write(jsonBytes,0,jsonBytes.Length);
            }
            //p653
            using (Stream rs =new FileStream(fileName, FileMode.Open))
            {
                byte[] jsonBytes=new byte[rs.Length];
                rs.Read(jsonBytes,0,jsonBytes.Length);
                string jsonString = System.Text.Encoding.UTF8.GetString(jsonBytes);

                NameCard nc2 = JsonSerializer.Deserialize<NameCard>(jsonString);

                WriteLine($"Name : {nc2.Name}");
                WriteLine($"Phone : {nc2.Phone}");
                WriteLine($"Age : {nc2.Age}");
            }

            ReadLine();
        }
    }
}