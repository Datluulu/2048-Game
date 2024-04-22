using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Media;

namespace game2048 {
    public partial class PlayGround : Form {

        Random rnd = new Random();
        SoundPlayer simpleSound = new SoundPlayer(@"game_sounds\SimpleSound.wav");  // Звук передвижения ячеек
        SoundPlayer mergeSound = new SoundPlayer(@"game_sounds\Mergering.wav");     // Звук слияния ячеек
        Menu m = new Menu();                                                        // Экземпляр класса Menu
        PictureBox[,] pb = new PictureBox[4, 4];                                    // Массив игрового поля (Ячейки)
        int[,] game = new int[4, 4];                                                // Массив игрового поля (Номиналы ячеек)
        bool[,] Merged = new bool[4, 4];                                            // Массив, показывающий, произошло ли слияние в ячейке
        int summ = 0;                                                               // Количество набранных очков

        public PlayGround(Menu form1) {
            InitializeComponent();

            // Событие нажатия на клавишу
            KeyDown += new KeyEventHandler(KeyBoardPress);

            // Скрытие главного меню
            m = form1;
            m.Hide();

            // Инициализация лучшего результата
            using (StreamReader sr = new StreamReader(@"bestscore_data\BestScore.txt"))
                bestScore.Text = "Лучший счет: " + sr.ReadToEnd();

            // Присваивание всем ячейкам значения -1
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    game[i, j] = -1;

            int x, y;                      // Координаты ячейки
            int tempX, tempY;              // Координаты ячейки (Временные)
            int score1 = 1, score2 = 1;    // Номинал первой и второй генерирующихся ячеек

            // Генерация случайного номинала ячейки
            ScoreGenerate(ref score1);
            ScoreGenerate(ref score2);

            // Генерация случайных координат стартовых ячеек
            do {
                x = rnd.Next(0, 4);
                y = rnd.Next(0, 4);
                tempX = rnd.Next(0, 4);
                tempY = rnd.Next(0, 4);
            } while (x == tempX && y == tempY);

            // Создание стартовых ячеек
            CreateCube(x, y, score1);
            CreateCube(tempX, tempY, score2);
        }

        // Функция генерации случайного номинала ячейки
        void ScoreGenerate(ref int score) {
            int x = rnd.Next(1, 5);
            if (x == 4)
                score *= 4;
            else
                score *= 2;
        }

        // Функция создания ячейки
        void CreateCube(int x, int y, int score) {
            pb[x, y] = new PictureBox();
            pb[x, y].Location = new Point(30 + 120 * y, 200 + 120 * x);
            Controls.Add(pb[x, y]);
            pb[x, y].BringToFront();
            pb[x, y].Size = new Size(100, 100);
            game[x, y] = score;
            switch (score) {
                case 2:
                    pb[x, y].BackgroundImage = Image.FromFile(@"score_pics\score_2.png");
                    break;
                case 4:
                    pb[x, y].BackgroundImage = Image.FromFile(@"score_pics\score_4.png");
                    break;
                case 8:
                    pb[x, y].BackgroundImage = Image.FromFile(@"score_pics\score_8.png");
                    break;
                case 16:
                    pb[x, y].BackgroundImage = Image.FromFile(@"score_pics\score_16.png");
                    break;
                case 32:
                    pb[x, y].BackgroundImage = Image.FromFile(@"score_pics\score_32.png");
                    break;
                case 64:
                    pb[x, y].BackgroundImage = Image.FromFile(@"score_pics\score_64.png");
                    break;
                case 128:
                    pb[x, y].BackgroundImage = Image.FromFile(@"score_pics\score_128.png");
                    break;
                case 256:
                    pb[x, y].BackgroundImage = Image.FromFile(@"score_pics\score_256.png");
                    break;
                case 512:
                    pb[x, y].BackgroundImage = Image.FromFile(@"score_pics\score_512.png");
                    break;
                case 1024:
                    pb[x, y].BackgroundImage = Image.FromFile(@"score_pics\score_1024.png");
                    break;
                case 2048:
                    pb[x, y].BackgroundImage = Image.FromFile(@"score_pics\score_2048.png");
                    break;
            }
        }

        void KeyBoardPress(object sender, KeyEventArgs e) {
            bool move = true;          // Лог. переменная, показывающая, произошло ли передвижение за полный цикл
            bool flag = false;         // Лог. переменная, показывающая, произошло ли передвижение за один цикл
            bool checkSound1 = false;  // Лог. переменная, показывающая, что нужно применить звук SimpleSound
            bool checkSound2 = false;  // Лог. переменная, показывающая, что нужно применить звук MergeSound
            bool final = false;        // Лог. переменная, показывающая, что пользователь достиг плитки 2048

            if (e.KeyCode.ToString() == "Right" || e.KeyCode.ToString() == "Left" || e.KeyCode.ToString() == "Up" || e.KeyCode.ToString() == "Down") {
                switch (e.KeyCode.ToString()) {
                    case "Right":
                        for (int k = 0; k < 3; k++) {
                            for (int i = 0; i < 4; i++) {
                                for (int j = 2; j >= 0; j--) {
                                    MoveTiles(i, j, ref game[i, j + 1], ref Merged[i, j + 1], ref flag, ref checkSound1, ref checkSound2, ref move);
                                }
                            }
                        }
                        
                        GetSound(checkSound1, checkSound2);

                        break;
                    case "Left":
                        for (int k = 0; k < 3; k++) {
                            for (int i = 0; i < 4; i++) {
                                for (int j = 1; j <= 3; j++) {
                                    MoveTiles(i, j, ref game[i, j - 1], ref Merged[i, j - 1], ref flag, ref checkSound1, ref checkSound2, ref move);
                                }
                            }
                        }
                        
                        GetSound(checkSound1, checkSound2);

                        break;
                    case "Up":
                        for (int k = 0; k < 3; k++) {
                            for (int i = 1; i <= 3; i++) {
                                for (int j = 0; j <= 3; j++) {
                                    MoveTiles(i, j, ref game[i - 1, j], ref Merged[i - 1, j], ref flag, ref checkSound1, ref checkSound2, ref move);
                                }
                            }
                        }
                        
                        GetSound(checkSound1, checkSound2);

                        break;
                    case "Down":
                        for (int k = 0; k < 3; k++) {
                            for (int i = 2; i >= 0; i--) {
                                for (int j = 0; j <= 3; j++) {
                                    MoveTiles(i, j, ref game[i + 1, j], ref Merged[i + 1, j], ref flag, ref checkSound1, ref checkSound2, ref move);
                                }
                            }
                        }

                        GetSound(checkSound1, checkSound2);

                        break;
                }

                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++) {
                        if (pb[i, j] != null)
                            pb[i, j].Dispose();
                        Controls.Remove(pb[i, j]);
                        if (game[i, j] > 0)
                            CreateCube(i, j, game[i, j]);
                        if (game[i, j] == 2048)
                            final = true;
                    }

                string max;

                // Чтение лучшего результата
                using (StreamReader sw = new StreamReader(@"bestscore_data\BestScore.txt")) {
                    max = sw.ReadToEnd();
                }

                textScore.Text = "Текущий счет: \t" + Convert.ToString(summ);

                // Перезапись лучшего результата
                if (summ > Int32.Parse(max)) {
                    using (StreamWriter sw = new StreamWriter(@"bestscore_data\BestScore.txt", false))
                        sw.WriteLine(summ);
                    bestScore.Text = "Лучший счет: \t" + Convert.ToString(summ);
                }

                // Обнуление массива, показывающего, произошло ли слияние в ячейке
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                        Merged[i, j] = false;

                int x, y;              // Координаты очередной ячейки
                int score = 1;         // Номинал очередной ячейки
                bool check = true;     // Проверка на существование ячейки в соответствующих координатах
                bool endGame = false;  // Проверка на завершение игры
                bool f1 = false;       // f1 - проверка на заполненное поле
                bool f2 = false;       // f2 - существует слияние по вертикали                 
                bool f3 = false;       // f3 - существует слияние по горизонтали 

                // Проверка на заполненное поле
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                        if (game[i, j] < 0)
                            f1 = true;

                // Генерация ячеек
                if (f1 && move) {
                    do {
                        x = rnd.Next(0, 4);
                        y = rnd.Next(0, 4);
                        if (game[x, y] < 0)
                            check = false;
                    } while (check);

                    ScoreGenerate(ref score);
                    CreateCube(x, y, score);
                }

                f1 = false;

                // Повторная проверка на заполненное поле
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                        if (game[i, j] < 0)
                            f1 = true;

                // Если поле заполнено, проверить ячейки для слияния
                if (!f1) {
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 4; j++)
                            if (game[i, j] == game[i + 1, j])
                                f2 = true;
                    for (int i = 0; i < 4; i++)
                        for (int j = 0; j < 3; j++)
                            if (game[i, j] == game[i, j + 1])
                                f3 = true;
                    if (!f2 && !f3)
                        endGame = true;
                }

                // Если невозможно передвигать плитки или игрок достиг плитки 2048 - завершать игру
                if (endGame || final) {
                    Endgame eg = new Endgame(m, this);
                    if (final) {
                        eg.labelMenu.Location = new Point(97, 23);
                        eg.labelMenu.Text = "You Win!";
                    }
                    else {
                        eg.labelMenu.Location = new Point(70, 23);
                        eg.labelMenu.Text = "Game over!";
                    }
                    while (!game2048.Endgame.gameRefresh)
                        eg.ShowDialog();
                    game2048.Endgame.gameRefresh = false;
                }
            }
        }

        // Логика передвижения и слияния плиток
        void MoveTiles(int i, int j, ref int x, ref bool y, ref bool flag, 
                       ref bool checkSound1, ref bool checkSound2, ref bool move) {
            // Передвижение ячеек
            if (game[i, j] > 0 && x < 0 && game[i, j] != x) {
                x = game[i, j];
                game[i, j] = -1;
                flag = true;
                checkSound1 = true;
            }
            // Слияние ячеек
            else if (!y && !Merged[i, j] && game[i, j] > 0 && game[i, j] == x) {
                x *= 2;
                summ += x;
                game[i, j] = -1;
                y = true;
                flag = true;
                checkSound2 = true;
            }
            else if (!flag)
                move = false;
            else if (flag)
                move = true;
        }

        // Проверка: если включен звук, звуки воспроизводятся
        void GetSound(bool checkSound1, bool checkSound2) {
            if (game2048.Menu.switcher) {
                if (checkSound2)
                    mergeSound.Play();
                else if (checkSound1)
                    simpleSound.Play();
            }
        }

        // При закрытии формы, показать главное меню
        void PlayGround_FormClosing(object sender, FormClosingEventArgs e) {
            m.Show();
        }

        private void PlayGround_Load(object sender, EventArgs e)
        {

        }

        private void target2_Click(object sender, EventArgs e)
        {

        }

        private void textScore_Click(object sender, EventArgs e)
        {

        }
    }
}
