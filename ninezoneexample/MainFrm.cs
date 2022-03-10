using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ninezoneexample
{
    public partial class MainFrm : Form
    {
        StateProcessManager _state = new StateProcessManager();
        BaseState _base = new BaseState();
        public MainFrm()
        {
            InitializeComponent();
            string pitcher = "Gonzalez";
            string batter = "Gale";
            _state.Pitcher = pitcher;
            _state.Batter = batter;
            refreshStatement();
        }
        private void refreshStatement()
        {
            V_Pitcher.Text = _state.Pitcher;
            V_Batter.Text = _state.Batter;
            V_Strike.Text = _state.S.ToString();
            V_Ball.Text = _state.B.ToString();
            V_Out.Text = _state.O.ToString();
        }

        private void B_Base2_Click(object sender, EventArgs e)
        {

        }

        private void B_Base1_Click(object sender, EventArgs e)
        {

        }

        private void B_Base3_Click(object sender, EventArgs e)
        {

        }

        private void B_Home_Click(object sender, EventArgs e)
        {

        }

        private void B_Ball_Click(object sender, EventArgs e)
        {

        }

        private void B_Strike_Click(object sender, EventArgs e)
        {

        }
    }
}
