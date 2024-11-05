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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void descriptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.descriptionBindingSource.EndEdit();
            //this.descriptionTableAdapter.UpdateQuery(textRichTextBox.Text, ingridientsRichTextBox.Text, nameTextBox.Text, Convert.ToInt32(idLabel1.Text));
            this.tableAdapterManager.UpdateAll(this.database1DataSet);


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'database1DataSet.description' table. You can move, or remove it, as needed.
            this.descriptionTableAdapter.Fill(this.database1DataSet.description);
            
        }



        private void searchByToolStripButton_Click_1(object sender, EventArgs e)
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
            //this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
    }
/* To do: 
 * 0) Bug with update(not anymore)
 * 1) Image
 * 2) Timer
 * 3) Theme
 * 4) Print
 * 5) Somewhat nice design */
 
}
