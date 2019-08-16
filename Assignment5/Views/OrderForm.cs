using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TotalLine_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("thanks you for your order and your order will be processed in 7 - 10 business days. ");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ConditionDataLabel.Text = Program.product.condition;
            PlatformDataLabel.Text = Program.product.platform;
            ManufacturerDataLabel.Text = Program.product.manufacturer;
            ModelDataLabel.Text = Program.product.model;

            GroupDataLabel.Text = Program.product.screensize + "\n\n" +
                Program.product.RAM_size + "\n\n" + Program.product.CPU_brand + "\n\n" +
                Program.product.CPU_type + "\n\n" + Program.product.CPU_number + "\n\n" +
                Program.product.CPU_speed + "\n\n" + Program.product.HDD_size + "\n\n" +
                Program.product.GPU_Type + "\n\n" + Program.product.webcam + "\n\n" +
                Program.product.OS;



            LogoDataLabel.Text = Program.product.manufacturer;

            double firstCost = Convert.ToDouble(String.Format("{0:C}", Program.product.cost.ToString()));
            PriceDataLabel.Text = firstCost.ToString();
            SalesTaxDataLabel.Text = (Math.Round(firstCost * 0.13, 2)).ToString();
            TotalDataLabel.Text = (Math.Round(firstCost * 1.13, 2)).ToString();
        }
    }
}
