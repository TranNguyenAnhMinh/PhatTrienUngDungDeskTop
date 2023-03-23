﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLyThuyetBuoiSo2
{
    public partial class frmTrang35 : Form
    {
        public frmTrang35()
        {
            InitializeComponent();
        }

        private void frmTrang35_Load(object sender, EventArgs e)
        {
            string strURL = "mailto:ctk45A@gmail.com";
            this.llbMail.Links.Add(0, strURL.Length, strURL);
            strURL = "http://www.ctk45A.net";
            this.llbweb.Links.Add(0, strURL.Length, strURL);
        }

        private void llbMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("mailto:"))
                Process.Start(strURL + "?subject=hello");
        }

        private void llbweb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("http://www."))
                Process.Start(strURL);
        }
    }
}