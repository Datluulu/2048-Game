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

            textSpec.Text = /*"1. Trong mỗi vòng, một viên gạch sẽ xuất hiện với mệnh giá là \n '2' (với xác suất 75%) hoặc '4' (với xác suất 25%). \n\n" +
                            "2. Người chơi có thể đẩy tất cả các viên gạch trên bàn chơi \n vào một trong 4 hướng bằng cách nhấn mũi tên.  \nNếu hai viên gạch cùng mệnh giá 'va chạm' khi bị đẩy, \n chúng sẽ hợp nhất thành một viên gạch mới \n có mệnh giá bằng tổng của hai viên gạch đã hợp nhất. \n\n" +
                            "3. Nếu sau khi nhấn một nút điều hướng thì vị trí  \n hoặc mệnh giá của các viên gạch không thay đổi, \n thì bước đi đó sẽ không được thực hiện. \n\n" +
                            "4. Nếu trong cùng một hàng hoặc cột có hơn hai viên gạch \n có cùng mệnh giá, khi bị đẩy đi thì chúng sẽ bắt đầu\n hợp nhất từ phía được đẩy vào. Ví dụ,\n các viên gạch trong cùng một hàng (4, 4, 4) \nsau khi bị đẩy sang trái sẽ trở thành (8, 4),\n và sau khi bị đẩy sang phải sẽ trở thành (4, 8). \n\n" +
                            "5. Trò chơi kết thúc khi không thể thực hiện bước đi sau một lượt, dẫn đến thua cuộc.";*/


            "1. In each round, a tile will appear with a value of \n '2' (with a probability of 75%) or '4' (with a probability of 25%). \n\n" +
            "2. Players can push all tiles on the game board \n in one of four directions by pressing arrow keys. \n If two tiles of the same value 'collide' when pushed, \n they will merge into a new tile \n with a value equal to the sum of the merged tiles. \n\n" +
            "3. If after pressing a direction key the position \n or value of the tiles does not change, \n then that move will not be executed. \n\n" +
            "4. If there are more than two tiles \n with the same value in the same row or column, \n when pushed, they will start merging \n from the direction they were pushed. For example, \n tiles in the same row (4, 4, 4) \nafter being pushed to the left will become (8, 4),\n and after being pushed to the right will become (4, 8). \n\n" +
            "5. The game ends when a move cannot be made \n after a turn, resulting in defeat.";
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

        private void Specification_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}