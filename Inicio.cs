﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOIS1
{
    public partial class Inicio : Form
    {
        public Inicio(int SW_TipoDeUsuario)
        {

            InitializeComponent();
            this.SW_TipoDeUsuario = SW_TipoDeUsuario;
            if (SW_TipoDeUsuario == CON_TipoAdministrador)
            {

                Label_NombreDelUsuario.Text = "Juanito Banana";
                Label_Area.Text = "Oficina";
                Label_Puesto.Text = "Administrador";
            }
            else if (SW_TipoDeUsuario == CON_TipoCajero)
            {
                Label_NombreDelUsuario.Text = "Patricia Rodriguez";
                Label_Area.Text = "Carniceria";
                Label_Puesto.Text = "Cajero";
            }
            else
            {
                Label_NombreDelUsuario.Text = "Victor Pacheco";
                Label_Area.Text = "Obrador";
                Label_Puesto.Text = "Inventariado";
            }
        }

        readonly int SW_TipoDeUsuario;
        readonly int CON_TipoAdministrador = 1;
        readonly int CON_TipoInventario = 3;
        readonly int CON_TipoCajero = 2;

     

        private void Boton_PuntoDeVenta_Click(object sender, EventArgs e)
        {
            if (SW_TipoDeUsuario == CON_TipoCajero)
            {
                Punto_de_Venta Pv = new Punto_de_Venta();
                Pv.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El tipo de Usuario NO tiene autorizacion para realizar esta accion.", "ERROR #2:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Boton_AjustesAdministrativos_Click(object sender, EventArgs e)
        {
            if (SW_TipoDeUsuario == CON_TipoAdministrador)
            {
                Ajustes_Administrativos AA = new Ajustes_Administrativos();
                AA.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El tipo de Usuario NO tiene autorizacion para realizar esta accion.", "ERROR #2:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Boton_SistemaDeInventario_Click_1(object sender, EventArgs e)
        {
            if (SW_TipoDeUsuario == CON_TipoAdministrador || SW_TipoDeUsuario == CON_TipoInventario)
            {
                Sistema_de_Inventariado SI = new Sistema_de_Inventariado(SW_TipoDeUsuario);
                SI.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El tipo de Usuario NO tiene autorizacion para realizar esta accion.", "ERROR #2:", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Label_Puesto_Click(object sender, EventArgs e)
        {

        }
    }
}
