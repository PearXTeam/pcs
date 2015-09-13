using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcs
{
    public partial class SkillsGUI : Form
    {
        public SkillsGUI()
        {
            InitializeComponent();
        }

        private void SkillsGUI_Load(object sender, EventArgs e)
        {
            if (skills.skillEnglish)
                labelSkillEnglish.Text = "Знание английского языка: есть";
            else
                labelSkillEnglish.Text = "Знание английского языка: нет";
            if (skills.skillLiteracy)
                labelSkillLiteracy.Text = "Грамотность: есть";
            else
                labelSkillLiteracy.Text = "Грамотность: нет";
            if (skills.skillComputer)
                labelSkillComputer.Text = "Владение компьютером: есть";
            else
                labelSkillComputer.Text = "Владение компьютером: нет";
            if (skills.skillAdvancedMath)
                labelSkillAdvancedMath.Text = "Продвинутое знание математики: есть";
            else
                labelSkillAdvancedMath.Text = "Продвинутое знание математики: нет";
            if (skills.skillCpp)
                labelSkillCpp.Text = "Знание C++: есть";
            else
                labelSkillCpp.Text = "Знание C++: нет";
        }
    }
}
