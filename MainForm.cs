using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trustbank
{
    public partial class MainForm : Form
    {

        string? id { get; set; }
        string? date { get; set; }

        int hamburgerCount = 1;

        public MainForm(string id, string date)
        {
            InitializeComponent();
            setParent();

            //Set the ID of the current account logged in.
            this.id = id;

            this.date = date;

            //Set the controllers for sliding panel
            slidingPanel.CollapseControl = btnHamburger;
            slidingPanel.CollapseControl = headerContainerPanel;

            //Bring the sliding bar to front as it gets overlapped by the nested panels
            slidingPanel.BringToFront();


            //Create the dashboard at startup
            DashboardMainUserControl dashboardMainUserControl = new DashboardMainUserControl(parentContainerPanel, id, date);
            dashboardMainUserControl.Show();

            //Add the dashboard to the container and refresh
            parentContainerPanel.Controls.Add(dashboardMainUserControl);
            repaintParentPanel();

        }

        private void removePanel(Control panel)
        {
            parentContainerPanel.Controls.Remove(panel);
        }

        private void repaintParentPanel()
        {
            parentContainerPanel.Refresh();
        }

        private void setParent()
        {
            HEADERLBLONLY.Parent = HEADERPANEL;
            SUBHEADERLBLONLY.Parent = HEADERPANEL;
            TRUSTBANKLOGOONLY.Parent = HEADERPANEL;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Create the dashboard
            DashboardMainUserControl dashboardMainUserControl = new DashboardMainUserControl(parentContainerPanel, id, date);
            dashboardMainUserControl.Show();

            //Clear the parent container of controls
            parentContainerPanel.Controls.Clear();

            //Add the dashboard to the container and refresh
            parentContainerPanel.Controls.Add(dashboardMainUserControl);
            repaintParentPanel();
        }
    }
}
