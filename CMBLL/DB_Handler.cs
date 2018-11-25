using System;
using System.Collections.Generic;
using System.IO; //imports the I/O namespace
using System.Xml;
using System.Text;
using CMEntities;

namespace CMBLL
{
    public class DB_Handler
    {
        public void SaveDatabase(CMEntities.Databases database)
        {
            //write to xml
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                Encoding = Encoding.UTF8
            };

            XmlWriter xmlwriter;
            xmlwriter = XmlWriter.Create(database.Database_File_Path, settings);
            xmlwriter.WriteStartDocument();
            xmlwriter.WriteStartElement(database.Database_File.ToString());//root element
            xmlwriter.WriteComment("Contacts here");
            xmlwriter.WriteEndElement();
            xmlwriter.Close();
        }
        
        public void SaveContact(CMEntities.Contact contact)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(contact.Full_Path.ToString());
            XmlNode XTop = xmlDocument.CreateElement("contact");
            XmlNode XName = xmlDocument.CreateElement("name");
            XmlNode XEmail = xmlDocument.CreateElement("email");
            XmlNode XMobile = xmlDocument.CreateElement("mobile");
            XmlNode XAltMobile = xmlDocument.CreateElement("alternative");
            XmlNode XAddress = xmlDocument.CreateElement("address");
            XmlNode XNote = xmlDocument.CreateElement("information");

            //fill nodes with text
            XName.InnerText = contact.Name;
            XEmail.InnerText = contact.Email;
            XMobile.InnerText = contact.Mobile;
            XAltMobile.InnerText = contact.Alternative_Mobile;
            XAddress.InnerText = contact.Address;
            XNote.InnerText = contact.Note;

            //append unto the top contact element
            XTop.AppendChild(XName);
            XTop.AppendChild(XEmail);
            XTop.AppendChild(XMobile);
            XTop.AppendChild(XAltMobile);
            XTop.AppendChild(XAddress);
            XTop.AppendChild(XNote);

            //append to db contact element
            xmlDocument.DocumentElement.AppendChild(XTop);

            xmlDocument.Save(Path.GetFullPath(contact.Full_Path));

        }

        //Takes in two parameters: List of Contact class type(CMENtities) and List of ContactInfo Class type
        public void CloneContact(List<Contact> contactList, List<ContactInfo> contactViewList)
        {
            ContactInfo contactInfoObj =new ContactInfo();

            int counter = contactList.Count;
            XmlDocument xmlDocument = new XmlDocument();

            //contactList[0]/[1]/[..] all have common database name and path
            xmlDocument.Load(contactList[0].Full_Path.ToString());
            for (int i = 0; i < counter; i++)
            {
                foreach (XmlNode node in xmlDocument.SelectNodes($"{contactList[i].Contact_Database}/contact"))
                {
                    //Set ContactInfo Properties via contactInfoObj
                    contactInfoObj.Name_View = node.SelectSingleNode("name").InnerText;
                    contactInfoObj.Email_View = node.SelectSingleNode("email").InnerText;
                    contactInfoObj.Mobile_View = node.SelectSingleNode("mobile").InnerText;
                    contactInfoObj.Alternative_Mobile_View = node.SelectSingleNode("alternative").InnerText;
                    contactInfoObj.Address_View = node.SelectSingleNode("address").InnerText;
                    contactInfoObj.Note_View = node.SelectSingleNode("information").InnerText;
                }
                //Add object to list(GridViewList)
                contactViewList.Add(contactInfoObj);
            }
            
        }
    }
}
        //string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //if(!Directory.Exists(path + "\\TestCMDBApp"))
            //    //create the folder
            //Directory.CreateDirectory(path + "\\TestCMDBApp");
            //if (!File.Exists(path + "\\TestCMDBApp\\firstDatabase.xml"))
            //    //Create the file
            //File.Create(path + "\\TestCMDBApp- cole\\firstDatabase.xml");
            
