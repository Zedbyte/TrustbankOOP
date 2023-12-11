﻿using System;
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
        string? id {  get; set; }

        public HelpCenterMainUserControl(Panel parentContainerPanel, string id)
        {
            InitializeComponent();

            this.parentContainerPanel = parentContainerPanel;
            this.id = id;
        }
    }
}