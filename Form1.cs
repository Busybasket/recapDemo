using System;
using System.Drawing;
using System.Windows.Forms;

namespace recapDemo
{

    public partial class Form1 : Form
    {
        private enum PieceType { Empty, Checker, Dama }

        private class Checker
        {
            static PieceType[,] PiecePositions = new PieceType[8, 8];
            public bool IsDama { get; private set; }
            public int Position1 { get; private set; }
            public int Position2 { get; private set; }
            public Checker(bool isDama, int position1, int position2)
            {
                IsDama = isDama;
                Position1 = position1;
                Position2 = position2;
                PiecePositions[position1, position2] = IsDama ? PieceType.Dama : PieceType.Checker;
            }

            public static void gameStart()
            {
                setPiece(0, 0);
                setPiece(2, 0);
                setPiece(4, 0);
                setPiece(6, 0);
                setPiece(1, 1);
                setPiece(3, 1);
                setPiece(5, 1);
                setPiece(7, 1);
                setPiece(0, 2);
                setPiece(2, 2);
                setPiece(4, 2);
                setPiece(6, 2);
            }
            private void setPiece(int pos1, int pos2)
            {

                new Checker(false, pos1, pos2);
                Button button = new Button() {
                    Text = "&First Name",
                    Location = new Point(10, 10),
                    TabIndex = 10
                };


                this.Controls.Add(button);

            }

        }
        public Form1()
        {

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void EventHandler(object sender, EventArgs e)
        {
            Checker.gameStart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }

}
