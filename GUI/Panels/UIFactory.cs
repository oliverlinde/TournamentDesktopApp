using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Panels;
using GUI.Panels.UserMenuViews;

namespace GUI {
    internal class UIFactory {

        public static Form CreateUserMenuUI()
        {
            return new UserMenu();
        }

        public static Form CreateTeamMenuUI()
        {
            return new TeamMenu();
        }

        public static Form CreateTournamentMenuUI()
        {
            return new TournamentMenu();
        }

        public static Form TournamentListUI()
        {
            return new TournamentListMenu();
        }

    }
}
