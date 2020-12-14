﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoisonCup
{
	public partial class LoseForm : Form
	{
		public LoseForm()
		{
			InitializeComponent();
		}

		private void BtnReset_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
