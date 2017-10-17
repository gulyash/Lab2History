namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cross = new Lab2.Figure();
            this.circle = new Lab2.Figure();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cross);
            this.panel1.Controls.Add(this.circle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 442);
            this.panel1.TabIndex = 2;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // cross
            // 
            this.cross.BackgroundImage = global::Lab2.Properties.Resources.cross2;
            this.cross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cross.Center = new System.Drawing.Point(452, 13);
            this.cross.Location = new System.Drawing.Point(442, 3);
            this.cross.MovingVector = new System.Drawing.Point(-1, 1);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(20, 20);
            this.cross.Speed = 1;
            this.cross.TabIndex = 2;
            this.cross.TabStop = false;
            // 
            // circle
            // 
            this.circle.BackgroundImage = global::Lab2.Properties.Resources.circle1;
            this.circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circle.Center = new System.Drawing.Point(13, 13);
            this.circle.Location = new System.Drawing.Point(3, 3);
            this.circle.MovingVector = new System.Drawing.Point(1, 1);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(20, 20);
            this.circle.Speed = 1;
            this.circle.TabIndex = 1;
            this.circle.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 466);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Figure circle;
        private System.Windows.Forms.Panel panel1;
        private Figure cross;
    }
}

