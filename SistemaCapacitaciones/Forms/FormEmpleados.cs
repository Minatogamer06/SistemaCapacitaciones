﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCapacitaciones.Forms
{
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

            //Prueba de git 

        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBCapacitacionesDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.dBCapacitacionesDataSet.Empleado);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.empleadoTableAdapter.FillBy(this.dBCapacitacionesDataSet.Empleado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            desmarcarCheck();
        }

        private void desmarcarCheck()
        {
            if (guna2CheckBoxFemenino.Checked)   
            {
                guna2CheckBoxFemenino.Checked = false;
            }
            if (guna2CheckBoxMasculino.Checked)
            {
                guna2CheckBoxMasculino.Checked = false;
            }
        }

        private void guna2TextBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
