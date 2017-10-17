using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            var moves = new Dictionary<Keys, Action>
            {
                // circle moves
                {Keys.Left, () => circle.MoveByKeys(new Point(-1, 0))},
                {Keys.Right, () => circle.MoveByKeys(new Point(1, 0))},
                {Keys.Up, () => circle.MoveByKeys(new Point(0, -1))},
                {Keys.Down, () => circle.MoveByKeys(new Point(0, 1))},
                // cross moves
                {Keys.A, () => cross.MoveByKeys(new Point(-1, 0))},
                {Keys.D, () => cross.MoveByKeys(new Point(1, 0))},
                {Keys.W, () => cross.MoveByKeys(new Point(0, -1))},
                {Keys.S, () => cross.MoveByKeys(new Point(0, 1))},
                 // auto moves
                {Keys.F5, () => timer1.Start()},
                {Keys.F6, () => timer1.Stop()},
            };

            if (moves.ContainsKey(keyData))
            {
                moves[keyData].Invoke();
            }
          
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circle.AutoMove();
            cross.AutoMove();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            base.OnMouseClick(e);
            
            if (e.Button == MouseButtons.Left)
            {
                circle.Center = new Point(e.X, e.Y);
            }
             if (e.Button == MouseButtons.Right)
            {
                cross.Center = new Point(e.X, e.Y);
            }
        }
    }
}
