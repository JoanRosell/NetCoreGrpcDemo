using Microsoft.Extensions.Configuration;
using NetCoreGrpcDemo.Client.Contracts;
using NetCoreGrpcDemo.Client.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreGrpcDemo.WinSite
{
    public partial class CalculatorForm : Form
    {
        private readonly string _connectionString = Program.Configuration.GetConnectionString("local");
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            ICalculatorClient client = new CalculatorClient(_connectionString);

            int? result = null;
            if (radioAdd.Checked)
            {
                result = client.Add(int.Parse(textA.Text), int.Parse(textB.Text));
            }

            if (radioSub.Checked)
            {
                result = client.Subtract(int.Parse(textA.Text), int.Parse(textB.Text));
            }

            if (radioMul.Checked)
            {
                result = client.Multiply(int.Parse(textA.Text), int.Parse(textB.Text));
            }

            if (radioDiv.Checked)
            {
                result = client.Divide(int.Parse(textA.Text), int.Parse(textB.Text));
            }

            MessageBox.Show($"Result: {result}");
        }
    }
}
