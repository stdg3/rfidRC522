using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace rfidRc522
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] portlar = SerialPort.GetPortNames();
        int aa = 0;
        string ardGelenStr = "";
        string dbName = "rfidDB.xml";
        string path = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonYeniKayit.Enabled = false;
            foreach (string portAdi in portlar)
            {
                comboBoxSerials.Items.Add(portAdi);
                comboBoxSerials.SelectedIndex = 0;
            }
            if (!File.Exists(@Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/rfidDB.xml"))
            {
                textBoxConsole.AppendText("\r\nDesktop->rfidDB not exist! please press SetDB");
            }
            else
            {
                textBoxConsole.AppendText("\r\nDB bulundu");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //groupBox2.Enabled = true;
            //buttonLedYak.Enabled = true;
            timer1gibi.Start();
            if (serialPortArd.IsOpen == false)
            {

                serialPortArd.PortName = comboBoxSerials.Text;
                serialPortArd.BaudRate = 9600;
                //serialPortArd.Open();
                //labelMessage.Text = "conn++";
                try
                {
                    serialPortArd.Open();
                    textBoxConsole.AppendText("\r\nconn");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1gibi.Stop();
            //groupBox2.Enabled = false;
            //buttonLedYak.Enabled = false;
            //labelkapiAci.Text = "";
            //progressBar1.Value = 0;
            if (serialPortArd.IsOpen == true)
            {
                serialPortArd.Close();
                textBoxConsole.AppendText("\r\ndisconn");
            }
            else
            {
                textBoxConsole.AppendText("\r\ndisconn error");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPortArd.IsOpen == true)
            {
                serialPortArd.Close();
            }

        }

        private void timer1gibi_Tick(object sender, EventArgs e)
        {
            try
            {
                aa = 0;
                //labelMessage.Text = "";
                ardGelenStr = serialPortArd.ReadExisting();
                labelMessage.Text = ardGelenStr.ToString();
                if (ardGelenStr.ToString() != "")
                {
                    textBoxConsole.AppendText("\r\n" + ardGelenStr.ToString());
                    bool varmi = idAra(ardGelenStr.ToString());
                    if (varmi == true)
                    {
                        textBoxConsole.AppendText("\r\nErişime izin verildi!!");
                    }
                }
                
            }
            catch (Exception)
            {

            
            }
        }

        private bool idAra(string v)
        {
            XDocument xdoc = XDocument.Load(@path + "/rfidDB.xml");
            foreach (XElement contact in xdoc.Element("rfid").Elements("card"))
            {
                XAttribute numAttr = contact.Attribute("id");
                textBoxConsole.AppendText("\r\nAranan: " + v);
                if (numAttr.Value.ToString() == v)
                {
                    textBoxConsole.AppendText("\r\nKayıt mevcut!");
                    return true;
                    break;
                }
            }
            textBoxConsole.AppendText("\r\nKayit mevcut değil!!");
            textBoxCardId.Text = v;
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Yalnızca ilk çalışmada DB atanmalı! Onaylıyor musunuz?","DB Oluşturma",MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                setDBXML();
            }

            
           
            
            /*
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //file.InitialDirectory = "C:\\"; 
            file.Filter = "Folders|\n"; //Folders|\n XML File |*.xml
            file.RestoreDirectory = true; 
            file.Title = "Veri tabanı dosyasını seçiniz";
            file.ShowDialog();

            */
        }

        private void setDBXML()
        {
            try
            {
                FolderBrowserDialog diag = new FolderBrowserDialog();
                if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    path= diag.SelectedPath;  //selected folder path
                    textBoxConsole.AppendText("\r\nSeçilen directory: " + path);
                    if (File.Exists(@path + "/rfidDB.xml"))
                    {
                        //MessageBox.Show("file exist");
                        textBoxConsole.AppendText("\r\nDB mevcut");
                    }
                    else
                    {
                        textBoxConsole.AppendText("\r\nDB bulunamadı...");
                        MessageBox.Show(path);
                        using (FileStream fs = File.Create(@path + "/rfidDB.xml"))

                        textBoxConsole.AppendText("\r\ndosya otomatik oluşturuldu" + " rfidDB.xml");

                        dbIntroYaz();
                    }
                    //MessageBox.Show(folder);
                    labelDBdir.Text = path + "\\" + dbName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seçilen klasöre dosya oluşturulamadı!");
            }
        }

        private void dbIntroYaz()
        {
            XDocument xdoc = new XDocument();
            XElement el1 = new XElement("rfid");
            XAttribute attr = new XAttribute("id", "DA E3 76 82"); //DA E3 76 82 
            XElement el2 = new XElement("card", "system");
            el2.Add(attr);
            el1.Add(el2);
            xdoc.Add(el1);
            xdoc.Save(@path + "/rfidDB.xml");
            textBoxConsole.AppendText("\r\ndosya içeriği otomatik oluşturuldu");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dbIdBul();






            /* var xmlWriter = new XmlTextWriter(labelDBdir.Text, null);

             xmlWriter.WriteStartDocument();                  // <?xml version="1.0"?>
             xmlWriter.WriteStartElement("ListOfBooks");      // <ListOfBooks>
             xmlWriter.WriteStartElement("Book");             //      <Book>
             xmlWriter.WriteString("Title-1");                //                Title-1
             xmlWriter.WriteEndElement();                     //       </Book>
             xmlWriter.WriteStartElement("Book");             //       <Book>
             xmlWriter.WriteString("Title-2");                //                 Title-2
             xmlWriter.WriteEndElement();                     //       </Book>   
             xmlWriter.WriteEndElement();                     // </ListOfBooks>

             xmlWriter.Close();
            */
            /*
            XmlTextWriter textWritter = new XmlTextWriter(@labelDBdir.Text, Encoding.UTF8);
            textWritter.WriteStartDocument();
            textWritter.WriteStartElement("root");
            textWritter.WriteEndElement();
            textWritter.Close();
            */






            /*

            XmlTextWriter xtw = new XmlTextWriter(@labelDBdir.Text, System.Text.Encoding.GetEncoding("utf-8"));
            xtw.Formatting = Formatting.Indented;
            xtw.WriteStartDocument(); //XML belgesine versiyon bilgisi yazılıyor.
            xtw.WriteComment("Bu bir denemedir");
            xtw.WriteStartElement("üst_düğüm");
            xtw.WriteStartElement("alt_düğüm");
            xtw.WriteAttributeString("seçenek", "değer");
            xtw.WriteString("Salt yazı");
            xtw.WriteEndElement();
            xtw.WriteEndElement();
            xtw.WriteEndDocument();
            xtw.Close();
            */


            /*
             * 
            string xmlDosyasi = labelDBdir.Text;
            XmlWriter xmlYazici = XmlWriter.Create(xmlDosyasi);
            xmlYazici.WriteStartDocument();

            xmlYazici.WriteStartElement("card");
            xmlYazici.WriteStartElement("cardId");
            xmlYazici.WriteString("idiiiiii");
            xmlYazici.WriteEndElement();
            xmlYazici.WriteEndElement();

            xmlYazici.WriteEndDocument();
            xmlYazici.Close();

            */
        }

        private void dbIdBul()
        {
            XDocument xdoc = XDocument.Load(path+"/rfidDB.xml");
            foreach (XElement contact in xdoc.Element("rfid").Elements("card"))
            {
                XAttribute numAttr = contact.Attribute("id");

                textBoxConsole.AppendText("id: " + numAttr.Value.ToString());
                textBoxConsole.AppendText("name: " + contact.Value);
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                buttonYeniKayit.Enabled = true;
            }
            else
            {
                buttonYeniKayit.Enabled = false;
            }
        }

        private void buttonYeniKayit_Click(object sender, EventArgs e)
        {
            newKayit(textBoxCardId.Text, textBoxAdSad.Text);
            textBoxAdSad.Text = "";
            textBoxCardId.Text = "";
        }

        private void newKayit(string id, string ad)
        {
            XDocument xdoc = XDocument.Load(path + "/rfidDB.xml");
            XElement root = xdoc.Element("rfid");
            XAttribute attr = new XAttribute("id", textBoxCardId.Text);
            XElement el2 = new XElement("card", textBoxAdSad.Text);
            el2.Add(attr);
            root.Add(el2);
            xdoc.Save(path + "/rfidDB.xml");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            /*
            XDocument xdoc = new XDocument();
            XElement el1 = new XElement("rfid");
            XAttribute attr = new XAttribute("id", "DA E3 76 82"); //DA E3 76 82 
            XElement el2 = new XElement("card", "system");
            el2.Add(attr);
            el1.Add(el2);
            xdoc.Add(el1);
            xdoc.Save(@"idDB.xml");
            */
            XDocument xdoc = XDocument.Load("idDB.xml");
            XElement root = xdoc.Element("rfid");
            XAttribute attr = new XAttribute("id", textBoxCardId.Text);
            XElement el2 = new XElement("card", textBoxAdSad.Text);
            el2.Add(attr);
            root.Add(el2);
            xdoc.Save("idDB.xml");
        }
    }
}



