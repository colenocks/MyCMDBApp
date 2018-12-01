﻿using System;
using System.Collections.Generic;
using System.IO; //imports the I/O namespace
using System.Xml;
using System.Text;
using CMEntities;

namespace CMBLL
{
    public class DB_Handler
    {
        public string UsersFolderPath {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\users lists";
            }
        }

        public List<Database> List_All_Databases = new List<Database>();

        public void CreateDatabase(Database database)
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

            //add to list
            List_All_Databases.Add(database);
        }
        
        public void AddContact(Contact contact)
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

            //append contact element to db 
            xmlDocument.DocumentElement.AppendChild(XTop);

            xmlDocument.Save(Path.GetFullPath(contact.Full_Path));
           
        }

        //this method is called on sign in button click
        public void CreateUser(User user)
        {
            //on click of Register button
            //create a directory once user signs in, and create an xml file with username as root element
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                Encoding = Encoding.UTF8
            };
            XmlWriter xmlwriter;
            xmlwriter = XmlWriter.Create(user.User_Full_Path, settings);
            xmlwriter.WriteStartDocument();
            //root element
            xmlwriter.WriteStartElement(user.Username);
            xmlwriter.WriteAttributeString("password", user.Password);
            xmlwriter.WriteComment("----------Database List--------------");
            //close root element
            xmlwriter.WriteEndElement();
            xmlwriter.Close();
            
        }

        //add to list of users folder
        public void SaveUsersAccount(string username, string userpath)
        {
            string usersFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!Directory.Exists(usersFolderPath + "\\users lists"))
            {
                Directory.CreateDirectory(usersFolderPath + "\\users lists");
            }
            if(!File.Exists(usersFolderPath + "\\users lists\\users.xml"))
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true,
                    Encoding = Encoding.UTF8
                };

                XmlWriter xmlwriter;//create and write to the file
                xmlwriter = XmlWriter.Create(usersFolderPath+ "\\users lists\\users.xml", settings);
                xmlwriter.WriteStartDocument();
                //
                xmlwriter.WriteStartElement("user");
                xmlwriter.WriteStartElement("username");
                xmlwriter.WriteString(username);
                xmlwriter.WriteEndElement();
                xmlwriter.WriteStartElement("path");
                xmlwriter.WriteString(userpath);
                xmlwriter.WriteEndElement();
                //end root element
                xmlwriter.WriteEndElement();
                //
                xmlwriter.Close();
            }
            else
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(usersFolderPath + "\\users lists\\users.xml");
                XmlNode XTop = xmlDocument.CreateElement("user");
                XmlNode Xusername = xmlDocument.CreateElement("username");
                XmlNode XUpath = xmlDocument.CreateElement("path");

                Xusername.InnerText = userpath;
                XUpath.InnerText = userpath;

                XTop.AppendChild(Xusername);
                XTop.AppendChild(XUpath);

                xmlDocument.DocumentElement.AppendChild(XTop);

                xmlDocument.Save(usersFolderPath + "\\users lists\\users.xml");
            }
        }

        //this method is called on finish button in the create database form
        public void AddUserFiles(User user)
        {
            //load the xml file and add all created databases and alerts
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(user.User_Full_Path);
            XmlNode XTop = xmlDocument.CreateElement("Files");
            XmlNode Xname = xmlDocument.CreateElement("database_name");
            XmlNode XDpath = xmlDocument.CreateElement("database_path");
            //XmlNode Xalert = xmlDocument.CreateElement("alert_name");
            //XmlNode XApath = xmlDocument.CreateElement("alert_path");

            Xname.InnerText = user.Database_Name;
            XDpath.InnerText = user.Database_Path;

            XTop.AppendChild(Xname);
            XTop.AppendChild(XDpath);
            xmlDocument.AppendChild(XTop);
        }

        public void ShowUserFiles(User user)
        {
            //load the xml file and display all created databases and alerts
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(user.User_Full_Path);
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
/* 
 * 
             // Saving empty file in directory chosen already)
            SaveFileDialog saveFile = new SaveFileDialog
            {
                InitialDirectory = InitialPath,
                Filter = "XML File | *.xml",
                Title = "Create Empty Xml File",
                FileName = Txt_Database_Name.Text //automatically adds the name to the dialog
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Rtb_Database_Directory.Text = saveFile.FileName;
                if(Txt_Database_Name.Text == "" || Txt_Database_Name.Text != Path.GetFileNameWithoutExtension(saveFile.FileName))
                {
                    Txt_Database_Name.Text = Path.GetFileNameWithoutExtension(saveFile.FileName);
                }

                MessageBox.Show("Database file created succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                Txt_Database_Name.Enabled = false;
                Btn_Create.Enabled = false;
                //Enable the add Contacts and Create Alert Button
                Btn_Add_Contacts.Enabled = true;
                Btn_Create_Alert.Enabled = true;

                //instantiate database constructor
                Databases databaseObj = new Databases(Path.GetFileNameWithoutExtension(saveFile.FileName), Rtb_Database_Directory.Text);

                DB_Handler _Handler = new DB_Handler();
                _Handler.SaveDatabase(databaseObj);
            }
            else
            {
                MessageBox.Show("File not saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
     */
