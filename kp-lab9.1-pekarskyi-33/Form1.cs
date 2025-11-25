using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kp_lab9._1_pekarskyi_33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Turtle
        {
            public string Name { get; set; }
            public string Weapon { get; set; }

            public Turtle(string name, string weapon)
            {
                Name = name;
                Weapon = weapon;
            }

            public override string ToString()
            {
                return $"{Name} ({Weapon})";
            }
        }

        public class NinjaTeam
        {
            private Turtle[] turtles = new Turtle[4];

            public NinjaTeam()
            {
                turtles[0] = new Turtle("Леонардо", "Катана");
                turtles[1] = new Turtle("Донателло", "Паличка");
                turtles[2] = new Turtle("Мікеланджело", "Нунчаки");
                turtles[3] = new Turtle("Рафаель", "Саї");
            }

            public Turtle this[int index]
            {
                get
                {
                    if (index >= 0 && index < turtles.Length)
                    {
                        return turtles[index];
                    }
                    return null;
                }

                set
                {
                    if (index >= 0 && index < turtles.Length)
                    {
                        turtles[index] = value;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NinjaTeam team = new NinjaTeam();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Teenage Mutant Ninja Turtles");
            sb.AppendLine();

            sb.AppendLine("get");
            sb.AppendLine($"Лідер 0: {team[0]}");
            sb.AppendLine($"Геніальний 1: {team[1]}");
            sb.AppendLine($"Клоун 2: {team[2]}");

            Turtle CaseyJones = new Turtle("Кейсі Джонс", "Ключка");

            team[2] = CaseyJones;
            sb.AppendLine();
            sb.AppendLine("set");
            sb.AppendLine($"Член команди 2 замінений на: {team[2]}");

            sb.AppendLine();
            sb.AppendLine("неправильний індекс");
            Turtle wrongIndex = team[5];

            if (wrongIndex == null)
            {
                sb.AppendLine("Індекс 5 не знайдено");
            }

            label1.Text = sb.ToString();
        }
    }
}
