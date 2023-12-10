using FontAwesome.Sharp;
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

        public MainForm(string id, string date)
        {
            InitializeComponent();
            setParent();

            //Set the ID of the current account logged in.
            this.id = id;

            this.date = date;

            //Set the controllers for sliding panel
            slidingPanel.CollapseControl = btnHamburger;
            slidingPanel.CollapseControl = btnSidePanelClose;
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

        //When hovering a side panel button, change the color.
        private void btnLbl_MouseEnter(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;

            btn.ForeColor = Color.Silver;
            btn.IconColor = Color.Silver;
        }

        private void btnLbl_MouseLeave(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;

            btn.ForeColor = Color.White;
            btn.IconColor = Color.White;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
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

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            //Create the accounts
            AccountsMainUserControl accountsMainUserControl = new AccountsMainUserControl(parentContainerPanel, id);
            accountsMainUserControl.Show();

            parentContainerPanel.Controls.Clear();
            parentContainerPanel.Controls.Add(accountsMainUserControl);
            repaintParentPanel();
        }

        private void btnEnrolledContacts_Click(object sender, EventArgs e)
        {
            EnrolledContactsMainUserControl enrolledContactsMainUserControl = new EnrolledContactsMainUserControl(id);
            enrolledContactsMainUserControl.Show();

            parentContainerPanel.Controls.Clear();
            parentContainerPanel.Controls.Add(enrolledContactsMainUserControl);
            repaintParentPanel();
        }

        private void btnBillsPayment_Click(object sender, EventArgs e)
        {

        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnTransferMoney_Click(object sender, EventArgs e)
        {
            TransferMoneyMainUserControl transferMoneyMainUserControl = new TransferMoneyMainUserControl(parentContainerPanel, id, 0, "", "");
            transferMoneyMainUserControl.Show();

            parentContainerPanel.Controls.Clear();
            parentContainerPanel.Controls.Add(transferMoneyMainUserControl);
            repaintParentPanel();
        }

        private void btnConversionRate_Click(object sender, EventArgs e)
        {

        }

        private void btnSettingsSideBar_Click(object sender, EventArgs e)
        {

        }

        private void btnHelpAndSupport_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOutSideBar_Click(object sender, EventArgs e)
        {

        }
    }
}
