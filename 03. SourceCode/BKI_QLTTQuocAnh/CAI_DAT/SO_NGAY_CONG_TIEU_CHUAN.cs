﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat
{
    public partial class SO_NGAY_CONG_TIEU_CHUAN : Form
    {
        public SO_NGAY_CONG_TIEU_CHUAN()
        {
            InitializeComponent();
        }

        private void text_box_format_numeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
               
            {
                e.Handled = true;
            }

          
        }

       
    }
}
