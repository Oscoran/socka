using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digi_project3
{
    public partial class mainscreen : Form
    {
        public mainscreen()
        {
            InitializeComponent();
        }

        private void descriptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.descriptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.descriptionTableAdapter.Fill(this.database1DataSet.description);
        }

        private void searchByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.descriptionTableAdapter.SearchBy(this.database1DataSet.description, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.descriptionTableAdapter.Delete(Convert.ToInt32(idLabel1.Text));
        }

        private void import_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Load(openFileDialog1.FileName);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            imagePictureBox.Image = null;
        }


        
    }
}
