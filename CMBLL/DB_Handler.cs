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
        //Users List Folder
        public string CMA_UsersFolder => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) /*+ "\\CMA_Users"*/;


        public List<Database> List_All_Databases = new List<Database>();

        public void CreateDatabaseXml(Database database)
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
            xmlwriter.WriteStartElement(database.Database_Name.ToString());//root element
            xmlwriter.WriteComment("Contacts here");
            xmlwriter.WriteEndElement();
            xmlwriter.Close();

            //Add to list
            List_All_Databases.Add(database);
        }

        public string CreateAlertFolder(string username, string userfolder)
        {
            //create Alert Folder inside CMA Folder
            string alertFolderPath = Path.Combine(userfolder, "Alerts", $"{username}_Alerts");
            if (!Directory.Exists(alertFolderPath))
            {
                Directory.CreateDirectory(alertFolderPath);
            }
            return alertFolderPath;
        }

        public void AddAlert(Alert alert, string path)
        {
            //write to xml
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                Encoding = Encoding.UTF8
            };

            //Create the directory
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            //Create Alert file to write to
            string alertFile = Path.Combine(path, alert.Alert_Tag + ".xml");

            if (!File.Exists(alertFile))
            {
                XmlWriter xmlwriter;
                xmlwriter = XmlWriter.Create(path, settings);
                xmlwriter.WriteStartDocument();
                xmlwriter.WriteStartElement($"{alert.Alert_Tag}_alert");//root element
                xmlwriter.WriteStartElement("alert");
                xmlwriter.WriteElementString("title", alert.Title);
                xmlwriter.WriteElementString("date", alert.Date);
                xmlwriter.WriteElementString("time", alert.Time);
                xmlwriter.WriteElementString("reminder", alert.Reminder.ToString());
                xmlwriter.WriteEndElement();
                xmlwriter.WriteEndElement();
                xmlwriter.Flush();
                xmlwriter.Close();
            }
            else
            {
                //load the file and add the nodes
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(Path.GetFullPath(alertFile));

                XmlNode top = xDoc.CreateElement("alert");
                XmlNode Xtitle = xDoc.CreateElement("title");
                XmlNode Xdate = xDoc.CreateElement("date");
                XmlNode Xtime = xDoc.CreateElement("time");
                XmlNode Xrem = xDoc.CreateElement("reminder");

                Xtitle.InnerText = alert.Title;
                Xdate.InnerText = alert.Date;
                Xtime.InnerText = alert.Time;
                Xrem.InnerText = alert.Reminder.ToString();

                top.AppendChild(Xtitle);
                top.AppendChild(Xdate);
                top.AppendChild(Xtime);
                top.AppendChild(Xrem);

                xDoc.DocumentElement.AppendChild(top);
                xDoc.Save(Path.GetFullPath(alertFile));
            }
        }

        public void AddContact(Contact contact, Alert alert = null)
        {
            //add non empty nodes
            int counter = 0; //to resolve duplicate names
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
            foreach (XmlNode node in xmlDocument.SelectNodes($"{contact.Contact_Database}/contact/name"))//look for duplicate names in list of contacts
            {
                if (node.SelectSingleNode("name").InnerText == contact.Name)
                {
                    counter++;
                    XName.InnerText = $"{contact.Name}_{counter}";
                }
                else { XName.InnerText = contact.Name; }
            }

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

        public void UpdateContact(Contact contact, string contactId)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(contact.Full_Path.ToString());
            foreach (XmlNode node in xmlDocument.SelectNodes($"{contact.Contact_Database}/contact"))
            {
                //if xml node name corresponds to the name on textbox
                if (node.SelectSingleNode("name").InnerText == contactId)
                {
                    //set the new non empty values
                    if (!string.IsNullOrEmpty(contact.Name))//name
                    {
                        //Go through all contacts to check for duplicate name
                        foreach (XmlNode nameNode in xmlDocument.SelectNodes($"{contact.Contact_Database}/contact/name"))
                        {
                            if (node.SelectSingleNode("name").InnerText != contact.Name)
                            {
                                node.SelectSingleNode("name").InnerText = contact.Name;
                            }
                            else
                            {
                                //leave the name unchanged
                                node.SelectSingleNode("name").InnerText = contactId;
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(contact.Email))//Email
                    {
                        node.SelectSingleNode("email").InnerText = contact.Email;
                    }
                    if (!string.IsNullOrEmpty(contact.Mobile))//Mobile
                    {
                        node.SelectSingleNode("mobile").InnerText = contact.Mobile;
                    }
                    if (!string.IsNullOrEmpty(contact.Alternative_Mobile))//Alternative
                    {
                        node.SelectSingleNode("alternative").InnerText = contact.Alternative_Mobile;
                    }
                    if (!string.IsNullOrEmpty(contact.Address))//Address
                    {
                        node.SelectSingleNode("address").InnerText = contact.Address;
                    }
                    if (!string.IsNullOrEmpty(contact.Note))//Additional Info
                    {
                        node.SelectSingleNode("information").InnerText = contact.Note;
                    }
                }
            }
            xmlDocument.Save(contact.Full_Path.ToString());
        }

        public void DeleteAlert(Alert alert)
        {

        }

        public void DeleteContact(Contact contact, string contactId)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(contact.Full_Path.ToString());
            foreach (XmlNode node in xmlDocument.SelectNodes($"{contact.Contact_Database}/contact"))
            {
                //if xml node name corresponds to the name on textbox
                if (node.SelectSingleNode("name").InnerText == contactId)
                {
                    node.ParentNode.RemoveChild(node); //this removes the contact node that matches the contactId
                }
            }
            xmlDocument.Save(contact.Full_Path.ToString());

            //delete associated alert Tag in alert File
           // xmlDocument.Load()
        }

        //this method is called on sign in button click
        public void CreateUser(User user)
        {
            //on click of Register button
            //create a directory once user signs in, and create an xml file with username as root element
            if (!File.Exists(user.UserFilePath))
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true,
                    Encoding = Encoding.UTF8
                };
                XmlWriter xmlwriter;
                xmlwriter = XmlWriter.Create(user.UserFilePath, settings);
                xmlwriter.WriteStartDocument();
                xmlwriter.WriteStartElement(user.Username);
                xmlwriter.WriteAttributeString("password", user.Password);
                xmlwriter.WriteComment("---------Database List----------");
                xmlwriter.WriteEndElement();
                xmlwriter.Flush();
                xmlwriter.Close();
            }
        }

        //add to list of users folder
        public void SaveUsersAccount(string username, string userpath)
        {
            if (!Directory.Exists(CMA_UsersFolder))
            {
                Directory.CreateDirectory(CMA_UsersFolder);
            }
            string usersXmlFile = Path.Combine(CMA_UsersFolder, "CMA_users.xml");
            if (!File.Exists(usersXmlFile))
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true,
                    Encoding = Encoding.UTF8
                };

                XmlWriter xmlwriter;//create and write to the file
                xmlwriter = XmlWriter.Create(usersXmlFile, settings);
                xmlwriter.WriteStartDocument();
                //
                xmlwriter.WriteStartElement("allusers");
                xmlwriter.WriteStartElement("user");
                xmlwriter.WriteElementString("username", username);
                xmlwriter.WriteElementString("path", userpath);
                xmlwriter.WriteEndElement();
                xmlwriter.WriteEndElement();
                //
                xmlwriter.Flush();
                xmlwriter.Close();
            }
            else
            {
                // if the users.xml file already exists, simply load it
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(Path.GetFullPath(usersXmlFile));

                XmlNode top = xmlDocument.CreateElement("user");
                XmlNode Xusername = xmlDocument.CreateElement("username");
                XmlNode XUpath = xmlDocument.CreateElement("path");

                Xusername.InnerText = username;
                XUpath.InnerText = userpath;

                top.AppendChild(Xusername);
                top.AppendChild(XUpath);

                xmlDocument.DocumentElement.AppendChild(top);
                xmlDocument.Save(Path.GetFullPath(usersXmlFile));
            }
        }

        //this method is called on finish button in the create database form
        public void SaveUserDatabaseDetails(User user, string databasesXml)
        {
            //load the xml file and add all created databases and alerts
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Path.GetFullPath(databasesXml));
            XmlNode XTop = xmlDocument.CreateElement("Files");
            XmlNode Xname = xmlDocument.CreateElement("database_name");
            XmlNode XDpath = xmlDocument.CreateElement("database_path");
            //XmlNode Xalert = xmlDocument.CreateElement("alert_name");
            //XmlNode XApath = xmlDocument.CreateElement("alert_path");

            Xname.InnerText = user.Database_Name;
            XDpath.InnerText = user.Database_Path;

            XTop.AppendChild(Xname);
            XTop.AppendChild(XDpath);
            //appends the nodes just under the comment "---Database list---"
            xmlDocument.DocumentElement.AppendChild(XTop);

            xmlDocument.Save(Path.GetFullPath(databasesXml));
        }

        public void ShowUserFiles(User user)
        {
            //load the xml file and display all created databases and alerts
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(user.UserFilePath);
        }
    }
}
