using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNameGeneratorLibrary;

namespace Support
{
    public static class NameGenerator
    {
        public static string[] GeneratePersonData()
        {
            string[] data = new string[5];
            Random seed = new Random();
            Random random = new Random(seed.Next());
            PersonNameGenerator personNameGenerator = new PersonNameGenerator();
            if (random.Next(0,100) < 50)
            //female name
            {
                data[0] = "Mrs.";
                data[1] = personNameGenerator.GenerateRandomFemaleFirstName();
                data[2] = personNameGenerator.GenerateRandomLastName();
            }
            else
            // male name
            {
                data[0] = "Mr.";
                data[1] = personNameGenerator.GenerateRandomMaleFirstName();
                data[2] = personNameGenerator.GenerateRandomLastName();
            }

            data[3] = random.Next(0, 1000).ToString().PadLeft(4, '0');
            data[4] = $"{data[1].ToLower()}.{data[2].ToLower()}@email.com";

            return data;
        }
    }
}
