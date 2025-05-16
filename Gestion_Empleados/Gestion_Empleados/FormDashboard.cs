using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Empleados
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEmpleados formEmpleados = new()
            {
                Visible = true
            };
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormNuevoEmpleado formNuevoEmpleado = new()
            {
                Visible = true
            };
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReportes formReportes = new()
            {
                Visible = true
            };
            Visible = false;
        }
    }
}
