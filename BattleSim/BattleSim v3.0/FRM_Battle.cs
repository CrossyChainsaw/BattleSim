using Logic;
using Logic.NeoFighters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BattleSim_v3._0
{
    public partial class FRM_Battle : Form
    {
        Random rnd = new Random();
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }

        // Visuals
        // Events
        private void FRM_Battle_Load(object sender, EventArgs e)
        {
            LoadCorrectNeoFighterImage(PB_Player1_NeoFighter, Player1);
            LoadCorrectNeoFighterImage(PB_Player2_NeoFighter, Player2);
            LoadAttacks();
            MirrorImage(PB_Player2_NeoFighter);
            UpdateHealth();
        }
        void LoadCorrectNeoFighterImage(PictureBox PB_Player_NeoFighter, Player player)
        {
            if (player.NeoFighter.Name == NeoFighterNames.Korbat)
            {
                PB_Player_NeoFighter.Image = Properties.Resources.Korbat;
            }
            else if (player.NeoFighter.Name == NeoFighterNames.Grarrl)
            {
                PB_Player_NeoFighter.Image = Properties.Resources.Grarrl;
            }
            else if (player.NeoFighter.Name == NeoFighterNames.Blumaroo)
            {
                PB_Player_NeoFighter.Image = Properties.Resources.Blumaroo;
            }
        } // not nice
        void MirrorImage(PictureBox PB_Player_NeoFighter)
        {
            PB_Player_NeoFighter.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            PB_Player_NeoFighter.Invalidate();
        }

        // Logic
        // Methods
        public FRM_Battle(Player player1, Player player2)
        {
            InitializeComponent();
            Player1 = player1;
            Player2 = player2;
        }
        void SwitchTurn()
        {
            BTN_Player1_Attack.Enabled = !BTN_Player1_Attack.Enabled;
            BTN_Player2_Attack.Enabled = !BTN_Player2_Attack.Enabled;
        }
        void UpdateHealth()
        {
            LBL_Player1_Health.Text = Player1.NeoFighter.Health.ToString();
            LBL_Player2_Health.Text = Player2.NeoFighter.Health.ToString();
        }
        void LoadAttacks()
        {
            GB_P1.Text = Player1.NeoFighter.Name.ToString();
            RB_P1_Attack1.Text = Player1.NeoFighter.Attack1Name;
            RB_P1_Attack2.Text = Player1.NeoFighter.Attack2Name;
            RB_P1_Attack3.Text = Player1.NeoFighter.Attack3Name;

            GB_P2.Text = Player2.NeoFighter.Name.ToString();
            RB_P2_Attack1.Text = Player2.NeoFighter.Attack1Name;
            RB_P2_Attack2.Text = Player2.NeoFighter.Attack2Name;
            RB_P2_Attack3.Text = Player2.NeoFighter.Attack3Name;
        }
        // Events
        private void BTN_Player1_Attack_Click(object sender, EventArgs e)
        {
            int damage = CalculateDamagePlayer1();
            Player2.NeoFighter.LoseHealth(damage);
            UpdateHealth();
            SwitchTurn();
        }
        private void BTN_Player2_Attack_Click(object sender, EventArgs e)
        {
            int damage = CalculateDamagePlayer2();
            Player1.NeoFighter.LoseHealth(damage);
            UpdateHealth();
            SwitchTurn();
        }

        int CalculateDamagePlayer1()
        {
            if (RB_P1_Attack1.Checked)
            {
                return Player1.NeoFighter.Attack1(rnd, Player1.NeoFighter.AttackPower, Player2.NeoFighter);
            }
            else if (RB_P1_Attack2.Checked)
            {
                return Player1.NeoFighter.Attack2(rnd, Player1.NeoFighter.AttackPower, Player2.NeoFighter);
            }
            else if (RB_P1_Attack3.Checked)
            {
                return Player1.NeoFighter.Attack3(rnd, Player1.NeoFighter.AttackPower, Player2.NeoFighter);
            }
            else
            {
                return 999999999;
            }
        }

        int CalculateDamagePlayer2()
        {
            if (RB_P2_Attack1.Checked)
            {
                return Player2.NeoFighter.Attack1(rnd, Player2.NeoFighter.AttackPower, Player1.NeoFighter);
            }
            else if (RB_P2_Attack2.Checked)
            {
                return Player2.NeoFighter.Attack2(rnd, Player2.NeoFighter.AttackPower, Player1.NeoFighter);
            }
            else if (RB_P2_Attack3.Checked)
            {
                return Player2.NeoFighter.Attack3(rnd, Player2.NeoFighter.AttackPower, Player1.NeoFighter);
            }
            else
            {
                return 999999999;
            }
        }
    }
}
