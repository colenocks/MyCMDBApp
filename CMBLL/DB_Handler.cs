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
        //Users List Folder -- This is created as the application starts
        public string CMA_ALL_USERS_FOLDER => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CMA_All_Users";
        //this is created when a user registers
        public string CMA_ALL_USERS_FILE => "CMA_users.xml";

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
            xmlwriter.WriteStartElement(database.Database_Name.ToString());//root element
            xmlwriter.WriteComment("Contacts here");
            xmlwriter.WriteEndElement();
            xmlwriter.Close();

            //Add to list
            List_All_Databases.Add(database);
        }

        public void AddContact(Contact contact)
        {
            //add non-empty nodes
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(contact.Full_Path.ToString());
            XmlNode XTop = xmlDocument.CreateElement("contact");
            XmlNode XName = xmlDocument.CreateElement("name");
            XmlNode XEmail = xmlDocument.CreateElement("email");
            XmlNode XMobile = xmlDocument.CreateElement("mobile");
            XmlNode XAltMobile = xmlDocument.CreateElement("alternative");
            XmlNode XAddress = xmlDocument.CreateElement("address");
            XmlNode XNote = xmlDocument.CreateElement("information");
            //XmlNode XAlert = xmlDocument.CreateElement("alert");

            //fill nodes with text
            foreach (XmlNode node in xmlDocument.SelectNodes($"{contact.Contact_Database}/contact"))//look for duplicate names in list of contacts
            {
                if (node.SelectSingleNode("name").InnerText == contact.Name)
                {
                    //Add a suffix
                    XName.InnerText = $"{contact.Name}_NEW";
                }
                else
                {
                    XName.InnerText = contact.Name;
                }
                XEmail.InnerText = contact.Email;
                XMobile.InnerText = contact.Mobile;
                XAltMobile.InnerText = contact.Alternative_Mobile;
                XAddress.InnerText = contact.Address;
                XNote.InnerText = contact.Note;
                //XAlert.InnerText = contact.
            }
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
                        //    foreach (XmlNode nameNode in xmlDocument.SelectNodes($"{contact.Contact_Database}/contact/name"))
                        //    {
                        //        if (node.SelectSingleNode("name").InnerText != contact.Name)
                        //        {
                        //            node.SelectSingleNode("name").InnerText = contact.Name;
                        //        }
                        //        else
                        //        {
                        //            //leave the name unchanged
                        //            node.SelectSingleNode("name").InnerText = contactId;
                        //        }
                        //    }
                        node.SelectSingleNode("name").InnerText = contact.Name;
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

        public void DeleteContact(Contact contact, string contactId/*, Alert alert*/)
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
            //DeleteAlert(alert);
        }

        public void AddAlert(Alert alert)
        {   
            if(alert != null)
            {
                //write to xml
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true,
                    Encoding = Encoding.UTF8
                };
                
                if (!Directory.Exists(alert.Alert_Path))
                {
                    Directory.CreateDirectory(alert.Alert_Path);
                }
                XmlDocument xDoc = new XmlDocument();
                if (!File.Exists(Path.GetFullPath(alert.Alert_Path)))
                {
                    XmlWriter xmlwriter;
                    xmlwriter = XmlWriter.Create(alert.Alert_Path, settings);
                    xmlwriter.WriteStartDocument();
                    xmlwriter.WriteStartElement("alerts");
                    xmlwriter.WriteStartElement($"{alert.Alert_Tag}_alert");//root element
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
                    //load the file and append the nodes
                    xDoc.Load(Path.GetFullPath(alert.Alert_Path));
                    
                    XmlNode top = xDoc.CreateElement($"{alert.Alert_Tag}_alert");
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
                    xDoc.Save(Path.GetFullPath(alert.Alert_Path));
                }

                //save alert file path to CMA_users.xml
                xDoc.Load(Path.GetFullPath(CMA_ALL_USERS_FILE));
                foreach(XmlNode node in xDoc.SelectNodes("allusers/users"))
                {
                    if(node.SelectSingleNode("username").InnerText == alert.Alert_User)
                    {
                        node.SelectSingleNode("alert_path").InnerText = alert.Alert_Path;
                    }
                }
                xDoc.Save(Path.GetFullPath(CMA_ALL_USERS_FILE));
            }
            
        }

        public void DeleteAlert(Alert alert)//call delete constructor 
        {
            if(alert != null)
            {
                XmlDocument xmlDocument = new XmlDocument();
                //Every alert file is named Alerts.xml
                string alertFile = Path.Combine(alert.Alert_Path, "Alerts.xml");

                xmlDocument.Load(Path.GetFullPath(alertFile));
                foreach (XmlNode node in xmlDocument.SelectNodes($"{alert.Alert_Tag}/alerts"))
                {
                    //if xml node name corresponds to the name on textbox
                    if (node.SelectSingleNode("title").InnerText == alert.Title)
                    {
                        node.ParentNode.RemoveChild(node); //this removes the alert node that matches the alert title
                    }
                }
                if (xmlDocument.SelectSingleNode("alerts").InnerText == null)
                    //if no nodes but the declaration remains
                {
                    File.Delete(alertFile);
                }
                xmlDocument.Save(Path.GetFullPath(alertFile));
            }
        }
        
        //this method is called when a user registers
        public void SaveUsersAccount(User user)
        {
            //save user account into usersXmlFile 
            if (!Directory.Exists(CMA_ALL_USERS_FOLDER))
            {
                Directory.CreateDirectory(CMA_ALL_USERS_FOLDER);
            }
            string allUsersFile = Path.Combine(CMA_ALL_USERS_FOLDER, CMA_ALL_USERS_FILE);

            //Check if the userXmlFile was created successfully on application startup
            if (!File.Exists(allUsersFile))
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true,
                    Encoding = Encoding.UTF8
                };

                XmlWriter xmlwriter;//create and write to the file
                xmlwriter = XmlWriter.Create(CMA_ALL_USERS_FILE, settings);
                xmlwriter.WriteStartDocument();
                //
                xmlwriter.WriteStartElement("allusers");
                xmlwriter.WriteStartElement("user");
                xmlwriter.WriteElementString("username", user.Username);
                xmlwriter.WriteElementString("path", user.UserFilePath);
                xmlwriter.WriteElementString("alert_path", "None");//Null at first
                xmlwriter.WriteEndElement();
                xmlwriter.WriteEndElement();
                //
                xmlwriter.Flush();
                xmlwriter.Close();
            }
            else
            {
                // if the CMA_All_Users.xml file already exists, simply load it
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(Path.GetFullPath(CMA_ALL_USERS_FILE));

                XmlNode top = xmlDocument.CreateElement("user");
                XmlNode Xusername = xmlDocument.CreateElement("username");
                XmlNode XUpath = xmlDocument.CreateElement("path");
                XmlNode XApath = xmlDocument.CreateElement("alert_path");

                Xusername.InnerText = user.Username;
                XUpath.InnerText = user.UserFilePath;
                XApath.InnerText = "None"; //Null at first

                top.AppendChild(Xusername);
                top.AppendChild(XUpath);
                top.AppendChild(XApath);

                xmlDocument.DocumentElement.AppendChild(top);
                xmlDocument.Save(Path.GetFullPath(CMA_ALL_USERS_FILE));
            }
        }

        //this method is called on sign in button click
        public void CreateUserInfo(User user) //User class constructor B
        {
            //on click of Register button
            //create an xml file with username as root element
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

        //this method is called on finish button in the New database form
        public void SaveUserDatabaseInfo(User user)
        {
            //load the xml file and add all created databases and alerts
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Path.GetFullPath(user.UserFilePath));
            XmlNode XTop = xmlDocument.CreateElement("Files");
            XmlNode Xname = xmlDocument.CreateElement("database_name");
            XmlNode XDpath = xmlDocument.CreateElement("database_path");

            Xname.InnerText = user.Database_Name;
            XDpath.InnerText = user.Database_Path;

            XTop.AppendChild(Xname);
            XTop.AppendChild(XDpath);
            //appends the nodes just under the comment "---Database list---"
            xmlDocument.DocumentElement.AppendChild(XTop);

            xmlDocument.Save(Path.GetFullPath(user.UserFilePath));
        }

        //public void ShowUserFiles(User user)
        //{
        //    //load the xml file and display all created databases and alerts
        //    XmlDocument xmlDocument = new XmlDocument();
        //    xmlDocument.Load(user.UserFilePath);
        //}
    }
}
