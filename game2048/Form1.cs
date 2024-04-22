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
    public partial class Menu : Form {

        public static bool switcher = true;                                 // Лог. переменная, показывающая, включен или выключен звук
        SoundPlayer sp = new SoundPlayer(@"game_sounds\SimpleSound.wav");   // Аудио - переменная 

        public Menu() {
            InitializeComponent();

            textSpec.Text = "1. В каждом раунде появляется плитка номинала «2» (с \nвероятностью 75 %) или «4» (с вероятностью 25 %). \n\n" +
                            "2. Нажатием стрелки игрок может скинуть все плитки \nигрового поля в одну из 4 сторон. Если при сбрасывании \nдве плитки одного номинала «налетают» одна на другую, \nто они слипаются в одну, номинал которой равен сумме \nсоединившихся плиток. \n\n" +
                            "3. Если при нажатии кнопки местоположение плиток или \nих номинал не изменится, то ход не совершается. \n\n" +
                            "4. Если в одной строчке или в одном столбце находится \nболее двух плиток одного номинала, то при сбрасывании \nони начинают слипаться с той стороны, в которую были \nнаправлены.Например, находящиеся в одной строке \nплитки (4, 4, 4) после хода влево они превратятся в (8, 4), \nа после хода вправо — в (4, 8). \n\n" +
                            "5. Игра заканчивается поражением, если после очередного \nхода невозможно совершить действие.";
        }

        // Нажатие кнопки "Начало игры"
        private void button1_Click_1(object sender, EventArgs e) {
            if (switcher)
                sp.Play();
            game2048.Endgame.gameRefresh = false;
            PlayGround pg = new PlayGround(this);
            Endgame eg = new Endgame(this, pg);
            pg.Show();
            Hide();
        }

        // Нажатие кнопки "Правила игры"
        private void specButton_Click(object sender, EventArgs e) {
            if (switcher)
                sp.Play();
            Specification.BringToFront();
        }

        // Нажатие кнопки "Назад"
        private void backButton_Click(object sender, EventArgs e) {
            if (switcher)
                sp.Play();
            mainMenu.BringToFront();
        }

        // Нажатие кнопки "Звук Вкл. / Выкл."
        private void soundButton_Click(object sender, EventArgs e) {
            if (switcher) {
                switcher = false;
                soundButton.BackColor = System.Drawing.Color.Red;
                soundButton.Text = "🔇";
            }
            else {
                switcher = true;
                soundButton.BackColor = System.Drawing.Color.Green;
                soundButton.Text = "🔈";
            }
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {

        }
    }
}