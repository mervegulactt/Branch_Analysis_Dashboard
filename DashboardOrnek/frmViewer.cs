using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardOrnek
{
    public partial class frmViewer : Form
    {
        private object dashboardViewer1;

        public frmViewer()
        {
            InitializeComponent();
        }

       public void loadDashboard(String filePath)
        {
            dashboardViewer1.LoadDashboard(filePath);
        }
    }
}
