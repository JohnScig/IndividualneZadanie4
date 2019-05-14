﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA04
{
    public partial class EditEmployeeView : Form
    {
        private EditEmployeeViewModel _addEmployeeFormViewModel = new EditEmployeeViewModel();

        public EditEmployeeView(int parentNodeID)
        {
            InitializeComponent();
            _addEmployeeFormViewModel.ParentNodeID = parentNodeID;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _addEmployeeFormViewModel.AddEmployee(tb_Title.Text, tb_FirstName.Text, tb_LastName.Text, tb_Phone.Text, tb_Email.Text);
            this.Close();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            string[] newperson = Support.NameGenerator.GeneratePersonData();
            tb_Title.Text = newperson[0];
            tb_FirstName.Text = newperson[1];
            tb_LastName.Text = newperson[2];
            tb_Phone.Text = newperson[3];
            tb_Email.Text = newperson[4];
        }
    }
}
