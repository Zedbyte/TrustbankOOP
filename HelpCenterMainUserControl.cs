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
    public partial class HelpCenterMainUserControl : UserControl
    {

        Panel parentContainerPanel;
        string? id { get; set; }

        public HelpCenterMainUserControl(Panel parentContainerPanel, string id)
        {
            InitializeComponent();

            this.parentContainerPanel = parentContainerPanel;
            this.id = id;
        }

        private void btnSubmitATicket_Click(object sender, EventArgs e)
        {
            parentContainerPanel.Refresh();

            TicketMainUserControl ticketUC = new TicketMainUserControl(id, this, parentContainerPanel);
            ticketUC.Show();

            parentContainerPanel.Controls.Add(ticketUC);

            this.Hide();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            parentContainerPanel.Refresh();

            FeedbackMainUserControl feedbackUC = new FeedbackMainUserControl(id, this, parentContainerPanel);
            feedbackUC.Show();

            parentContainerPanel.Controls.Add(feedbackUC);

            this.Hide();
        }
    }
}
