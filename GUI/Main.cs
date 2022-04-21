using GUI.Panels;

namespace GUI {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void ContentPanel_Resize(object sender, System.EventArgs e)
        {
            foreach (Control item in ContentPanel.Controls) {
                var frm = (Form)item;
                    frm.Width = ContentPanel.Width; 
                    frm.Height = ContentPanel.Height;
            }
        }

            private void NavigateTo(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.Size = panel.Size; // for responsive size
            panel.Controls.Clear();
            panel.Tag = form;
            panel.Resize += ContentPanel_Resize;
            panel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void TournamentMnuBtn_Click_1(object sender, EventArgs e)
        {
            Form tournamentMenu = UIFactory.CreateTournamentMenuUI();
            NavigateTo(tournamentMenu, ContentPanel);
        }

        private void UserMnuBtn_Click(object sender, EventArgs e)
        {
            Form userControl1 = UIFactory.CreateUserMenuUI();
            NavigateTo(userControl1, ContentPanel);
        }

        private void TeamMnuBtn_Click(object sender, EventArgs e)
        {
            Form teamMenu = UIFactory.CreateTeamMenuUI();
            NavigateTo(teamMenu, ContentPanel);
        }
    }
}