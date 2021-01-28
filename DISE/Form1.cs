using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISE
{

    public partial class Form1 : Form
    {
        TextBox[] control1 = new TextBox[2];
        int click, fecha, contador;

        public Form1()
        {
            InitializeComponent();
        }

        private void empresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contableDataSet);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'contableDataSet.Deducibles' Puede moverla o quitarla según sea necesario.
            this.deduciblesTableAdapter.Fill(this.contableDataSet.Deducibles);
            // TODO: esta línea de código carga datos en la tabla 'contableDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.contableDataSet.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'contableDataSet.Empresa' Puede moverla o quitarla según sea necesario.
            this.empresaTableAdapter.Fill(this.contableDataSet.Empresa);
            control1[0] = nombreTextBox;
            control1[1] = cUITTextBox;
            nombreCompletoTextBox.Text = "";
            legajoTextBox.Text = "";
            codEmpresaTextBox.Text = "";
            cUITTextBox.Text = "";
            cUILTextBox.Text = "";
            nombreTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < control1.Length; i++)
            {
                if (control1[i].Text == "")
                {
                    contador++;
                }
            }
            if (contador == 0)
            {
                int a = Convert.ToInt32(cUITTextBox.Text);
                this.empresaTableAdapter.addEmpresa(nombreTextBox.Text, a);
                cUITTextBox.Text = "";
                nombreTextBox.Text = "";
                MessageBox.Show("Se a guardado correctamente");
            }
            else
            {
                MessageBox.Show("No puede dejar lugares en blanco");
                contador = 0;

            }
        }

        private void btaddEmpleado_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < control1.Length; i++)
            {
                if (control1[i].Text == "")
                {
                    contador++;
                }
                else
                {
                    int a = Convert.ToInt32(cUILTextBox.Text);
                    int b = Convert.ToInt32(legajoTextBox.Text);
                    int c = Convert.ToInt32(codEmpresaTextBox.Text);
                    this.empleadosTableAdapter.addEmpleado(nombreCompletoTextBox.Text, a, b, c);
                    panelDeduc.Visible = true;
                    cUILTextBox.Enabled = false;
                    nombreCompletoTextBox.Enabled = false;
                    legajoTextBox.Enabled = false;
                    codEmpresaTextBox.Enabled = false;
                    if (MessageBox.Show("Se ha guardado correctamente ¿desea agregar mas? ", "Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {

                    }
                    else
                    {
                        panelDeduc.Visible = true;
                    }
                }
            }
        }

        private void btEmpresa_Click(object sender, EventArgs e)
        {
            panelDet2.Visible = false;
            panelDet1.Visible = true;
            subPanel1.Visible = true;
            click++;
            if (click== 2)
            {
                subPanel1.Visible = false;
                panelDet1.Visible = false;
                click = 0;
            }
        }

        private void btEmpresaAdd_Click(object sender, EventArgs e)
        {
            panelEmpresa.Visible = true;
            panelEmpleado.Visible = false;
            cUITTextBox.Text = "";
            nombreTextBox.Text = "";

        }

        private void addEmpleado_Click(object sender, EventArgs e)
        {
            panelEmpleado.Visible = true;
            panelEmpresa.Visible = false;
            cUILTextBox.Text = "";
            nombreCompletoTextBox.Text = "";
            legajoTextBox.Text = "";
            codEmpresaTextBox.Text = "";

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        
            if (fecha == 1 )
            {
                    fechaNacTextBox.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            }
            else if (fecha == 2)           
            {
                fechaMatTextBox.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            }
        }
        private void fechaNacTextBox_TextChanged(object sender, EventArgs e)
        {
            fecha = 1;
            monthCalendar1.Visible = true;

        }

        private void estCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void panelDeduc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void fechaMatTextBox_TextChanged(object sender, EventArgs e)
        {
            fecha = 2;
        }
    }
}
