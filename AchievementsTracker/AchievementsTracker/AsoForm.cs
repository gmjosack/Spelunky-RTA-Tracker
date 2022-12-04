using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AchievementsTracker
{
    public partial class AsoForm : Form
    {

        public AsoForm()
        {
            InitializeComponent();
        }

        private void AsoForm_Load(object sender, EventArgs e)
        {

        }

        public void Reset()
        {
            this.asoStep.Image = global::AchievementsTracker.Properties.Resources.aso_00_tutorial;
        }

        public void FinishTutorial()
        {
            this.asoStep.Image = global::AchievementsTracker.Properties.Resources.aso_01_bomb;
        }

        public void Finish1Bomb()
        {
            this.asoStep.Image = global::AchievementsTracker.Properties.Resources.aso_02_rope;
        }

        public void Finish1Rope()
        {
            this.asoStep.Image = global::AchievementsTracker.Properties.Resources.aso_03_10k;
        }

        public void Finish10k()
        {
            this.asoStep.Image = global::AchievementsTracker.Properties.Resources.aso_04_bomb_2;
        }

        public void Finish2Bombs()
        {
            this.asoStep.Image = global::AchievementsTracker.Properties.Resources.aso_05_rope_2;
        }

        public void Finish2Ropes()
        {
            this.asoStep.Image = global::AchievementsTracker.Properties.Resources.aso_06_shotgun;
        }

        public void FinishShotgun()
        {
            this.asoStep.Image = global::AchievementsTracker.Properties.Resources.aso_07_bomb_3;
        }

        public void Finish3Bombs()
        {
            this.asoStep.Image = global::AchievementsTracker.Properties.Resources.aso_08_rope_3;
        }

        public void Finish3Ropes()
        {
            this.asoStep.Image = global::AchievementsTracker.Properties.Resources.aso_09_key;
        }

        public void FinishKey()
        {
            this.asoStep.Image = global::AchievementsTracker.Properties.Resources.aso_10_olmec;
        }

    }
}
