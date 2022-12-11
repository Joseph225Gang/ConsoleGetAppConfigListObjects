
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
                .SetBasePath(@"D:\Visual Studio 2022\AppConfigTest\AppSettingTest")
                .AddJsonFile("appsettings.json")
                .Build();
var emailList = builder.GetSection("EmailList:ToEmails").Get<List<AppSettingTest.EmailSetting>>() ?? new List<AppSettingTest.EmailSetting>();

foreach (AppSettingTest.EmailSetting emailSetting in emailList)
    Console.WriteLine($"emailAddress : {emailSetting.address}, and displayName: {emailSetting.displayName}");
Console.ReadKey();