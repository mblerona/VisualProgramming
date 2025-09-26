using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders
{
    public partial class Form1 : Form
    {

        public DateTime DateTime = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500;
            timer1.Start(); 
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            NewOrderForm newOrderForm = new NewOrderForm();
            if (newOrderForm.ShowDialog() == DialogResult.OK) { 
            
            lbOrders.Items.Add(newOrderForm.Order);
            }
        }

        private void timeNowLabel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timeNowLabel.Text = $"{DateTime.ToLongDateString()} \n {DateTime.ToLongTimeString()}";
        }

        private void btnSmetka_Click(object sender, EventArgs e)
        {
            if (lbOrders.Items.Count > 0) { 
            Bill bill = new Bill();
                foreach(Order order in lbOrders.Items)
                {
                    bill.totalPrice += order.totalPrice();
                }

                bill.DateTime = DateTime.Now;
                lbSmetki.Items.Add(bill);
                lbOrders.Items.Clear();
                calculateTotal();
            }
        }

        private void calculateTotal() {
            int sum = 0;
            foreach (Bill bill in lbSmetki.Items) {
                sum += bill.totalPrice;
            }
            tbTotal.Text = String.Format("{0:0.00} ден", sum);
        }
    }
}
