using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitesFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SchoolDBEntities db = new SchoolDBEntities();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var db = new SchoolDBEntities();
            var standard = new Standard
            {
                StandardName = txtStandardName.Text,
                Description = txtDescription.Text
            };
            db.Standards.Add(standard);
            db.SaveChanges();
            MessageBox.Show("Added");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var standard = db.Standards.ToList();
            cbbStandard.DataSource = standard;
            cbbStandard.DisplayMember = "StandardName";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var standard = db.Standards.Where(s => s.StandardName == cbbStandard.Text).FirstOrDefault();
            if (standard != null)
            {
                txtStandardNameUpdate.Text = standard.StandardName;
                txtDescriptionUpdate.Text = standard.Description;
                db.Entry(standard).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Updated");
            }

        }

        private void cbbStandard_SelectedIndexChanged(object sender, EventArgs e)
        {
            var standard = db.Standards.Where(s => s.StandardName == cbbStandard.Text).SingleOrDefault();
            if (standard != null)
            {
                txtStandardNameUpdate.Text = standard.StandardName;
                txtDescriptionUpdate.Text = standard.Description;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var standard = db.Standards.Where(s => s.StandardName == cbbStandard.Text).SingleOrDefault();
            if (standard != null)
            {
                db.Entry(standard).State = EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("Deleted");
            }

        }
    }
}
