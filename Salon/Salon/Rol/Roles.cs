﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salon.GastosFijos;

namespace Salon.Rol
{
    public partial class Roles: Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            AñadirRol añadirRol = new AñadirRol();
            añadirRol.ShowDialog();
        }

        private void Roles_Load(object sender, EventArgs e)
        {

        }
    }
}
