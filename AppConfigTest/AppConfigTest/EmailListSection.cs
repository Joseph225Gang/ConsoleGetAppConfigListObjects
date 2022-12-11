using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AppConfigTest
{
    public class EmailListSection : IConfigurationSectionHandler
    {
        public object Create(object parent, object configContext, XmlNode section)
        {
            List<EmailSetting> myConfigObject = new List<EmailSetting>();

            foreach (XmlNode childNode in section.ChildNodes)
            {
                var emailSetting = new EmailSetting();
                foreach (XmlAttribute attrib in childNode.Attributes)
                {
                    if(attrib.Name == "address")
                        emailSetting.address = attrib.Value;
                    else if(attrib.Name == "displayName")
                        emailSetting.displayName = attrib.Value;
                }
                myConfigObject.Add(emailSetting);
            }
            return myConfigObject;
        }
    }

    public class EmailSetting
    {
        public string address { get; set; }
        public string displayName { get; set; }
    }
}
