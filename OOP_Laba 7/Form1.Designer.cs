
namespace OOP_Laba_7
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_YELLOW = new System.Windows.Forms.Button();
            this.button_GREEN = new System.Windows.Forms.Button();
            this.button_RED = new System.Windows.Forms.Button();
            this.button_BLACK = new System.Windows.Forms.Button();
            this.button_BLUE = new System.Windows.Forms.Button();
            this.button_ColorDialog = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_ELLIPSE = new System.Windows.Forms.Button();
            this.button_SQUARE = new System.Windows.Forms.Button();
            this.button_TRIANGLE = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.flowLayoutPanel1.Controls.Add(this.button_YELLOW);
            this.flowLayoutPanel1.Controls.Add(this.button_GREEN);
            this.flowLayoutPanel1.Controls.Add(this.button_RED);
            this.flowLayoutPanel1.Controls.Add(this.button_BLACK);
            this.flowLayoutPanel1.Controls.Add(this.button_BLUE);
            this.flowLayoutPanel1.Controls.Add(this.button_ColorDialog);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(985, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 146);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // button_YELLOW
            // 
            this.button_YELLOW.BackColor = System.Drawing.Color.Yellow;
            this.button_YELLOW.Location = new System.Drawing.Point(3, 3);
            this.button_YELLOW.Name = "button_YELLOW";
            this.button_YELLOW.Size = new System.Drawing.Size(60, 60);
            this.button_YELLOW.TabIndex = 2;
            this.button_YELLOW.TabStop = false;
            this.button_YELLOW.UseVisualStyleBackColor = false;
            this.button_YELLOW.Click += new System.EventHandler(this.button_RED_Click);
            // 
            // button_GREEN
            // 
            this.button_GREEN.BackColor = System.Drawing.Color.Green;
            this.button_GREEN.Location = new System.Drawing.Point(69, 3);
            this.button_GREEN.Name = "button_GREEN";
            this.button_GREEN.Size = new System.Drawing.Size(60, 60);
            this.button_GREEN.TabIndex = 3;
            this.button_GREEN.TabStop = false;
            this.button_GREEN.UseVisualStyleBackColor = false;
            this.button_GREEN.Click += new System.EventHandler(this.button_RED_Click);
            // 
            // button_RED
            // 
            this.button_RED.BackColor = System.Drawing.Color.Red;
            this.button_RED.Location = new System.Drawing.Point(135, 3);
            this.button_RED.Name = "button_RED";
            this.button_RED.Size = new System.Drawing.Size(60, 60);
            this.button_RED.TabIndex = 1;
            this.button_RED.TabStop = false;
            this.button_RED.UseVisualStyleBackColor = false;
            this.button_RED.Click += new System.EventHandler(this.button_RED_Click);
            // 
            // button_BLACK
            // 
            this.button_BLACK.BackColor = System.Drawing.Color.Black;
            this.button_BLACK.Location = new System.Drawing.Point(3, 69);
            this.button_BLACK.Name = "button_BLACK";
            this.button_BLACK.Size = new System.Drawing.Size(60, 60);
            this.button_BLACK.TabIndex = 4;
            this.button_BLACK.TabStop = false;
            this.button_BLACK.UseVisualStyleBackColor = false;
            this.button_BLACK.Click += new System.EventHandler(this.button_RED_Click);
            // 
            // button_BLUE
            // 
            this.button_BLUE.BackColor = System.Drawing.Color.Blue;
            this.button_BLUE.Location = new System.Drawing.Point(69, 69);
            this.button_BLUE.Name = "button_BLUE";
            this.button_BLUE.Size = new System.Drawing.Size(60, 60);
            this.button_BLUE.TabIndex = 5;
            this.button_BLUE.TabStop = false;
            this.button_BLUE.UseVisualStyleBackColor = false;
            this.button_BLUE.Click += new System.EventHandler(this.button_RED_Click);
            // 
            // button_ColorDialog
            // 
            this.button_ColorDialog.BackColor = System.Drawing.Color.White;
            this.button_ColorDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ColorDialog.Location = new System.Drawing.Point(135, 69);
            this.button_ColorDialog.Name = "button_ColorDialog";
            this.button_ColorDialog.Size = new System.Drawing.Size(60, 60);
            this.button_ColorDialog.TabIndex = 6;
            this.button_ColorDialog.TabStop = false;
            this.button_ColorDialog.Text = "...";
            this.button_ColorDialog.UseVisualStyleBackColor = false;
            this.button_ColorDialog.Click += new System.EventHandler(this.button_ColorDialog_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.flowLayoutPanel2.Controls.Add(this.button_ELLIPSE);
            this.flowLayoutPanel2.Controls.Add(this.button_SQUARE);
            this.flowLayoutPanel2.Controls.Add(this.button_TRIANGLE);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(985, 175);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 146);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // button_ELLIPSE
            // 
            this.button_ELLIPSE.BackColor = System.Drawing.Color.Black;
            this.button_ELLIPSE.BackgroundImage = global::OOP_Laba_7.Properties.Resources.imgonline_com_ua_Resize_la7PAupGydH;
            this.button_ELLIPSE.ForeColor = System.Drawing.Color.DimGray;
            this.button_ELLIPSE.Location = new System.Drawing.Point(3, 3);
            this.button_ELLIPSE.Name = "button_ELLIPSE";
            this.button_ELLIPSE.Size = new System.Drawing.Size(60, 60);
            this.button_ELLIPSE.TabIndex = 3;
            this.button_ELLIPSE.TabStop = false;
            this.button_ELLIPSE.UseVisualStyleBackColor = false;
            this.button_ELLIPSE.Click += new System.EventHandler(this.button_ELLIPSE_Click);
            // 
            // button_SQUARE
            // 
            this.button_SQUARE.BackColor = System.Drawing.Color.DimGray;
            this.button_SQUARE.ForeColor = System.Drawing.Color.DimGray;
            this.button_SQUARE.Image = global::OOP_Laba_7.Properties.Resources.imgonline_com_ua_Resize_ylx04X1qh5f8O5;
            this.button_SQUARE.Location = new System.Drawing.Point(69, 3);
            this.button_SQUARE.Name = "button_SQUARE";
            this.button_SQUARE.Size = new System.Drawing.Size(60, 60);
            this.button_SQUARE.TabIndex = 4;
            this.button_SQUARE.TabStop = false;
            this.button_SQUARE.UseVisualStyleBackColor = false;
            this.button_SQUARE.Click += new System.EventHandler(this.button_ELLIPSE_Click);
            // 
            // button_TRIANGLE
            // 
            this.button_TRIANGLE.BackColor = System.Drawing.Color.DimGray;
            this.button_TRIANGLE.ForeColor = System.Drawing.Color.DimGray;
            this.button_TRIANGLE.Image = global::OOP_Laba_7.Properties.Resources.Method_Draw_Image;
            this.button_TRIANGLE.Location = new System.Drawing.Point(135, 3);
            this.button_TRIANGLE.Name = "button_TRIANGLE";
            this.button_TRIANGLE.Size = new System.Drawing.Size(60, 60);
            this.button_TRIANGLE.TabIndex = 5;
            this.button_TRIANGLE.TabStop = false;
            this.button_TRIANGLE.UseVisualStyleBackColor = false;
            this.button_TRIANGLE.Click += new System.EventHandler(this.button_ELLIPSE_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1182, 593);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.Resize += new System.EventHandler(this.pictureBox_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1182, 593);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "СУПЕР УЛЬТРА МЕГА КРУТОЙ И ЛУЧШИЙ ПЕЙНТ 3000  OVER 99999999% OF CRINGE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_RED;
        private System.Windows.Forms.Button button_YELLOW;
        private System.Windows.Forms.Button button_GREEN;
        private System.Windows.Forms.Button button_BLACK;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button_ELLIPSE;
        private System.Windows.Forms.Button button_SQUARE;
        private System.Windows.Forms.Button button_TRIANGLE;
        private System.Windows.Forms.Button button_BLUE;
        private System.Windows.Forms.Button button_ColorDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.PictureBox pictureBox;
    }
}

