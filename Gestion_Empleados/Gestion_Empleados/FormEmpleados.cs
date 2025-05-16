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

    public partial class FormEmpleados : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        public FormEmpleados()
        {
            
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form_FormClosing);
            this.Load += new EventHandler(FormEmpleados_Load);
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "Datos", "Empleados.txt");
            
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string linea;
                    Empleado empleadoActual = null;

                    while ((linea = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linea))
                        {
                            if (empleadoActual != null)
                            {
                                empleados.Add(empleadoActual);
                                empleadoActual = null;
                            }
                            continue;
                        }
                        string[] partes = linea.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                        if (partes.Length == 2)
                        {
                            string campo = partes[0].Trim();
                            string valor = partes[1].Trim();
                            if (empleadoActual == null)
                            {
                                empleadoActual = new Empleado();
                            }
                            switch (campo)
                            {
                                case "Nombre":
                                    empleadoActual.Nombre = valor;
                                    break;
                                case "Apellido 1":
                                    empleadoActual.Apellido1 = valor;
                                    break;
                                case "Apellido 2":
                                    empleadoActual.Apellido2 = valor;
                                    break;
                                case "Salario":
                                    if (decimal.TryParse(valor, out decimal salario))
                                    {
                                        empleadoActual.Salario = salario;
                                    }
                                    break;
                                case "Cargo":
                                    empleadoActual.Cargo = valor;
                                    break;
                                case "Email":
                                    empleadoActual.Email = valor;
                                    break;
                            }
                        }
                    }
                    if (empleadoActual != null)
                    {
                        empleados.Add(empleadoActual);
                    }
                }
                dataGridView1.DataSource = empleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }

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
            List<Empleado> buscar = new List<Empleado>();


            if (comboBox1.SelectedItem != null && textBox2.Text != null)
            {
                foreach (Empleado emp in empleados)
                {
                    if (emp.Nombre == textBox1.Text && emp.Salario == decimal.Parse(textBox2.Text) && emp.Cargo == comboBox1.SelectedItem.ToString())
                    {
                        
                        buscar.Add(emp);
                        dataGridView2.DataSource = buscar;
                    }

                }
            }
            foreach (Empleado emp in empleados)
            {
                if(emp.Nombre == textBox1.Text)
                {
                    
                    buscar.Add(emp);
                    dataGridView2.DataSource = buscar;
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDashboard formDashboard = new()
            {
                Visible = true
            };
            Visible = false;
        }
    }
}
