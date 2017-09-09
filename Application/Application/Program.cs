using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Application
{

    public struct Information
    {
        private int maxAge;

        private int minAge;

        private double averageAge;


        public int MaxAge { get => maxAge; set => maxAge = value; }

        public int MinAge { get => minAge; set => minAge = value; }

        public double AverageAge { get => averageAge; set => averageAge = value; }


        public override string ToString()
        {
            return "Minimal age:" + minAge + "\n" + "Maximal age:" + maxAge + "\n" + "Average age:" + averageAge;
        }




    }

    class Program
    {

        private static List<Person> InputAndGetPersonsInfo()
        {
            Person person = null;
            var listPersons = new List<Person>();
            string str = "";
            string[] personDataArray = new string[3];
            WriteLine("Input information about persons. Type stop to end input...");
            while(true)
            {
                str = ReadLine();
                if(str=="stop")
                {
                    break;
                }
                try
                {
                    personDataArray = str.Split(' ');
                    person = new Person();
                    person.Name = personDataArray[0];
                    person.Sorname = personDataArray[1];
                    int age = 0;
                    if (!int.TryParse(personDataArray[2], out age))
                    {
                        WriteLine("Wrong age format input!");
                        continue;
                    }

                    person.Age = age;
                }

                catch (IndexOutOfRangeException ex)
                {
                    WriteLine("Wrong number of params was inputed! Try again!");
                    continue;
                }

                listPersons.Add(person);
                     
            }
            return listPersons;


        }

        private static void DisplayInfoAboutPersons(List<Person> list)
        {
            var ageArray = new int[list.Count];

            for (int i = 0; i < ageArray.Length; i++)
            {
                ageArray[i] = list[i].Age;
            }

            var information = new Information();
            information.MinAge = ageArray.Min();
            information.MaxAge = ageArray.Max();

            double average = 0;
            int sum = 0;

            foreach(var i in ageArray)
            {
                sum += i;
            }

            information.AverageAge=sum/ageArray.Length;

            WriteLine(information.ToString());


        }
      
     


        static void Main(string[] args)
        {
            try
            {
                var list = InputAndGetPersonsInfo();
                DisplayInfoAboutPersons(list);
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message);
            }

        
         
            ReadKey();
        }
    }
}
