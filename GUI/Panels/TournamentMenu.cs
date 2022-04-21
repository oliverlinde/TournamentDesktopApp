using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Panels.UserMenuViews;

namespace GUI.Panels {
    public partial class TournamentMenu : BaseSubMenu
    {
        private List<Button> buttonList;
        public TournamentMenu()
        {
            buttonList = new List<Button>();
            Button btn1 = new Button();
            btn1.Click += new System.EventHandler(this.btn1_Click);
            btn1.Text = "Find turnering";
            btn1.Dock = DockStyle.Top;
            Button btn2 = new Button();
            btn2.Text = "Opret Turnering";
            btn2.Dock = DockStyle.Top;
            buttonList.Add(btn1);
            buttonList.Add(btn2);
            InitializeLayout(buttonList);
        }

        private void btn1_Click(object? sender, EventArgs e)
        {
            Form tournaments = UIFactory.TournamentListUI();
            NavigateTo(tournaments, ContentPanel);
        }
    }
}
