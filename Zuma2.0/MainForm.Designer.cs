namespace Zuma2._0
{
    partial class MainForm
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
            this.panelBalls = new System.Windows.Forms.Panel();
            this.labelColorBall = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelBalls
            // 
            this.panelBalls.Location = new System.Drawing.Point(41, 45);
            this.panelBalls.Name = "panelBalls";
            this.panelBalls.Size = new System.Drawing.Size(627, 310);
            this.panelBalls.TabIndex = 0;
            this.panelBalls.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBalls_Paint);
            this.panelBalls.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBalls_MouseClick);
            // 
            // labelColorBall
            // 
            this.labelColorBall.AutoSize = true;
            this.labelColorBall.Location = new System.Drawing.Point(317, 388);
            this.labelColorBall.Name = "labelColorBall";
            this.labelColorBall.Size = new System.Drawing.Size(57, 20);
            this.labelColorBall.TabIndex = 1;
            this.labelColorBall.Text = "Шарик";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelColorBall);
            this.Controls.Add(this.panelBalls);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBalls;
        private System.Windows.Forms.Label labelColorBall;
    }
}

