using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Schedule_Config_Tool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            String test = "";
            DataSet dataset = new DataSet();
            dataset.ReadXml("schedule.xml");
            foreach (DataRow r in dataset.Tables["Company"].Rows)
            {
                test = r["GPCompanyID"].ToString();

                int a = 0;
            }
        }
    }
}
