using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace personelKayit_dosyaOkuma_
{
    public partial class frmAdd : Form
    {
        Person kisi;
        public frmAdd(Person person)
        {
            InitializeComponent();
            kisi = person;
            txtId.Enabled = (kisi.Id == null);      
            loadPerson();        
        }
        private void loadPerson()
        {
            txtId.Text = kisi.Id;
            txtName.Text = kisi.Name;
            txtSName.Text = kisi.SName;
            dtDate.MinDate = kisi.Date;
        }
        private void updatePerson(Person person)
        {
            person.Id = txtId.Text;
            person.Name = txtName.Text;
            person.SName = txtSName.Text;
            person.Date = dtDate.Value;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            updatePerson(kisi);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}