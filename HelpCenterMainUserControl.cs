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

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TrustBank is a secure, user-friendly, and extensive online banking system that is built with Object-Oriented Programming (OOP) principles such as encapsulation, inheritance, polymorphism, and abstraction. These principles ensure an efficient banking platform that not only fortifies its security but also contributes to a modular and extensible codebase. \r\n\r\nThis system provides users with secure money transfers between accounts, contact enrollment for seamless transactions, and real-time access to account balances.  The system guarantees the preservation of transaction records, which promotes transparency and effortless tracking of financial activities. \r\n\r\nIn the settings function, the users are given the ability to tailor their banking experience through allowing them to change their account information (username, password, email, and mobile number). The system  provides a user-centric approach that aligns to our goal, delivering a secure and user-friendly banking experience.\r\n\r\nStaying true to its name, TrustBank upholds its commitment to security and user satisfaction through the integration of cutting-edge technology. The system features a 2-step verification process, to safeguard all transactions and user data within the application. This advanced security protocol strengthens the defense of the system against any attack that may happen. This ensures that all data within the application are secured, fortifying user privacy and building customer confidence and trust in our system.\r\n");
        }
    }
}
