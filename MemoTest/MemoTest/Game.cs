﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoTest
{
    public partial class Game : Form
    {
        //public static int Dif;
        public Game(int dif)
        {
            InitializeComponent();
            
            if(dif == 0)
            {
                panelHardLeft.Visible = false;
                panelHardRight.Visible = false;
            }
            else
            {
                panelEasyLeft.Visible = false;
                panelEasyRight.Visible = false;
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }




    }
}
