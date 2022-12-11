using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<EmailSetting> emailList = ConfigurationManager.GetSection("emailList") as List<EmailSetting>;
            foreach (EmailSetting emailSetting in emailList)
                Console.WriteLine($"emailAddress : {emailSetting.address}, and displayName: {emailSetting.displayName}");
            Console.ReadKey();

        }
    }
}
