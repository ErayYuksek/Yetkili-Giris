﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YetkiliGirişi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer=true;
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnkayıt_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            string kullanıcıAdı = txtkullanıcı.Text;

            string şifre = txtsifre.Text;


        }
    }
}
