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
        public void SaveDatabase(Databases database)
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
        
        public void SaveContact(Contact contact)
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

        ////Takes in three parameters
        //public List<ContactInfo> CloneContact(List<Contact> contactList , List<ContactInfo> contactInfoList)
        //{
        //    ContactInfo contactInfoObj = new ContactInfo();
        //    XmlDocument xmlDocument = new XmlDocument();
        //    //Note: all contacts in contactList have common database name and path; contactList[0].Full_Path == contactList[1].Full_Path
        //    xmlDocument.Load(contactList[0].Full_Path.ToString());

        //    for(int numberOfContacts = 0; numberOfContacts < contactList.Count; numberOfContacts++)
        //    {
        //        foreach (XmlNode node in xmlDocument.SelectNodes($"{contactList[0].Contact_Database}/contact"))
        //        {
        //            //Set ContactInfo Properties via contactInfoObj
        //            contactInfoObj.Name_View = node.SelectSingleNode("name").InnerText;
        //            contactInfoObj.Email_View = node.SelectSingleNode("email").InnerText;
        //            contactInfoObj.Mobile_View = node.SelectSingleNode("mobile").InnerText;
        //            contactInfoObj.Alternative_Mobile_View = node.SelectSingleNode("alternative").InnerText;
        //            contactInfoObj.Address_View = node.SelectSingleNode("address").InnerText;
        //            contactInfoObj.Note_View = node.SelectSingleNode("information").InnerText;
        //            //Add objects to list(GridViewList)
        //            contactInfoList.Add(contactInfoObj);
        //        } 
        //    }
        //    xmlDocument.Save(contactList[0].Full_Path.ToString());
        //    return contactInfoList;
        //}

    }
}
