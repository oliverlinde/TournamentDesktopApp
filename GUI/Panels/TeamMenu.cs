using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Panels {
    public partial class TeamMenu : BaseSubMenu
    {
        private List<Button> buttonList;
        public TeamMenu() {
            
            buttonList = new List<Button>();
            Button btn1 = new Button();
            btn1.Text = "Opret bruger";
            btn1.Dock = DockStyle.Top;

            Button btn2 = new Button();
            btn2.Text = "Find bruger";
            btn2.Dock = DockStyle.Top;

            buttonList.Add(btn1);
            buttonList.Add(btn2);
            
            InitializeLayout(buttonList);
        }
    }
}
