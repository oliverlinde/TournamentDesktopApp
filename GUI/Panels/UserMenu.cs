using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace GUI.Panels {
    public partial class UserMenu : BaseSubMenu {
        public UserMenu() {
           GenerateComponents();
        }

        private void GenerateComponents()
        {
            Button button1 = new Button();
            button1.Text = "Find bruger";
            button1.Click += new System.EventHandler(button1_Click);
            Button button2 = new Button();
            button2.Text = "Opret bruger";

            List<Button> buttonList = new List<Button>();
            buttonList.Add(button1);
            buttonList.Add(button2);
            InitializeLayout(buttonList);
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
