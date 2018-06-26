using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace personelKayit_dosyaOkuma_
{
    public partial class Form1 : Form
    {
        BindingList<Person> personList = new BindingList<Person>();

        public Form1()
        {
            InitializeComponent();
            dgwListe.AutoGenerateColumns = false;
            dgwListe.DataSource = personList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            frmAdd frm = new frmAdd(person);
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                personList.Add(person);
                MessageBox.Show("New person addedd.");
            }
            frm.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Person person;
            if (dgwListe.SelectedRows.Count > 0)
            {
                person = personList[dgwListe.SelectedRows[0].Index];
                frmAdd frm = new frmAdd(person);
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    MessageBox.Show("İnformation updated");
                }
                frm.Dispose();
            }
            else
                MessageBox.Show("Select the person you want to edit");
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            Person person;
             if (dgwListe.SelectedRows.Count > 0)
            {
                DialogResult secenek = MessageBox.Show("Do you want remove?", " Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    person = personList[dgwListe.SelectedRows[0].Index];
                    personList.Remove(person);
                    MessageBox.Show("Person removed.");
                }
            }
            else
                MessageBox.Show("Please select the person to be removed.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbxType.SelectedIndex == 0)
            {
                sfdSave.Filter = "CSV files|*.csv";
                sfdSave.FileName = "person file";
                if (sfdSave.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfdSave.FileName);
                    for (int i = 0; i < personList.Count; i++)
                    {
                        Person _person = personList[i];
                        string a = _person.Id + ";" + _person.Name + ";" + _person.SName + ";" + _person.Date;
                        sw.WriteLine(a);
                    }
                    sw.Flush();
                    sw.Close();
                }
            }
            else if (cmbxType.SelectedIndex == 1)
            {
                sfdSave.Filter = "XML files|*.xml";
                if (sfdSave.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfdSave.FileName);
                    XmlSerializer xs = new XmlSerializer(typeof(BindingList<Person>));
                    xs.Serialize(sw, personList);
                    sw.Flush();
                    sw.Close();
                }
            }
            else if (cmbxType.SelectedIndex == 2)
            {
                sfdSave.Filter = "Json files|*.json";
                if (sfdSave.ShowDialog() == DialogResult.OK)
                {
                    string convert = JsonConvert.SerializeObject(personList);
                    File.WriteAllText(sfdSave.FileName, convert);
                }
            }
            else
                MessageBox.Show("Select type");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {        
            if (cmbxType2.SelectedIndex == 0)
            {
                ofdLoad.Filter = "Csv File|*.csv";
                ofdLoad.Title = "Select Person File";
                if (ofdLoad.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    personList.Clear();
                    StreamReader sr = new StreamReader(ofdLoad.FileName);
                    string satir;
                    satir = sr.ReadLine();
                    while (satir != null)
                    {
                        string[] str = satir.Split(';');
                        Person person = new Person();
                        person.Id = str[0];
                        person.Name = str[1];
                        person.SName = str[2];
                        person.Date = DateTime.Parse(str[3]);
                        personList.Add(person);
                        satir = sr.ReadLine();
                    }
                    sr.Close();
                }
            }
            else if (cmbxType2.SelectedIndex == 1)
            {
                ofdLoad.Filter = "Xml File|*.xml";
                if (ofdLoad.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    personList.Clear();
                    XmlSerializer xs = new XmlSerializer(typeof(BindingList<Person>));
                    StreamReader reader = new StreamReader(ofdLoad.FileName);
                    BindingList<Person> loadedList = (BindingList<Person>)xs.Deserialize(reader);
                    //MessageBox.Show(person.ToString());
                    for (int i = 0; i < loadedList.Count; i++)
                    {
                        personList.Add(loadedList[i]);

                    }
                    reader.Close();
                  
                }
            }
            else if (cmbxType2.SelectedIndex == 2)
            {
                ofdLoad.Filter = "Json files|*.json";
                if (ofdLoad.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    personList.Clear();
                    BindingList<Person> loadedList = JsonConvert.DeserializeObject<BindingList<Person>>(File.ReadAllText(ofdLoad.FileName));
                    for (int i = 0; i < loadedList.Count; i++)
                    {
                        personList.Add(loadedList[i]);
                    }
                }
            }
            else
                MessageBox.Show("Select type");
        }
    }
}