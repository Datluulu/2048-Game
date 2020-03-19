using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace game2048 {
    public partial class Endgame : Form {

        public static bool gameRefresh = false;  // Запрет на закрытие окна

        Menu m = new Menu();
        PlayGround pg;
        SoundPlayer sp = new SoundPlayer(@"game_sounds\SimpleSound.wav");
        
        public Endgame(Menu form1, PlayGround form2) {
            InitializeComponent();
            pg = new PlayGround(m);
            pg = form2;
            m = form1;
        }

        // Нажатие кнопки "Выйти в меню"
        private void button2_Click(object sender, EventArgs e) {
            if (game2048.Menu.switcher)
                sp.Play();
            gameRefresh = true;
            Close();
            pg.Close();
        }

        // Нажатие кнопки "Начать заново"
        private void button1_Click(object sender, EventArgs e) {
            if (game2048.Menu.switcher)
                sp.Play();
            gameRefresh = true;
            Close();
            pg.Close();
            m.Hide();
            pg = new PlayGround(m);
            pg.Show();
        }
    }
}
