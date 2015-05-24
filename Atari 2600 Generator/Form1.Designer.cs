namespace Game_Gear_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textEmulador = new System.Windows.Forms.TextBox();
            this.checkBoxOptionMEnu = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResX = new System.Windows.Forms.TextBox();
            this.textBoxResY = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioPaddleOn = new System.Windows.Forms.RadioButton();
            this.radioPaddleAuto = new System.Windows.Forms.RadioButton();
            this.radioPaddleOff = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxRenombrar = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form_DragEnter);
            // 
            // textEmulador
            // 
            this.textEmulador.Location = new System.Drawing.Point(10, 20);
            this.textEmulador.Name = "textEmulador";
            this.textEmulador.Size = new System.Drawing.Size(129, 20);
            this.textEmulador.TabIndex = 1;
            this.textEmulador.Text = "jstella_0_95.jar";
            // 
            // checkBoxOptionMEnu
            // 
            this.checkBoxOptionMEnu.AutoSize = true;
            this.checkBoxOptionMEnu.Location = new System.Drawing.Point(211, 411);
            this.checkBoxOptionMEnu.Name = "checkBoxOptionMEnu";
            this.checkBoxOptionMEnu.Size = new System.Drawing.Size(89, 17);
            this.checkBoxOptionMEnu.TabIndex = 5;
            this.checkBoxOptionMEnu.Text = "Activar Menu";
            this.checkBoxOptionMEnu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxResX);
            this.groupBox1.Controls.Add(this.textBoxResY);
            this.groupBox1.Location = new System.Drawing.Point(217, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 74);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format de Video";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resolució:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // textBoxResX
            // 
            this.textBoxResX.Location = new System.Drawing.Point(7, 41);
            this.textBoxResX.Name = "textBoxResX";
            this.textBoxResX.Size = new System.Drawing.Size(40, 20);
            this.textBoxResX.TabIndex = 6;
            this.textBoxResX.Text = "570";
            this.textBoxResX.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxResY
            // 
            this.textBoxResY.Location = new System.Drawing.Point(72, 41);
            this.textBoxResY.Name = "textBoxResY";
            this.textBoxResY.Size = new System.Drawing.Size(41, 20);
            this.textBoxResY.TabIndex = 5;
            this.textBoxResY.Text = "460";
            this.textBoxResY.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textEmulador);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 51);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emulador";
            // 
            // radioPaddleOn
            // 
            this.radioPaddleOn.AutoSize = true;
            this.radioPaddleOn.Location = new System.Drawing.Point(13, 42);
            this.radioPaddleOn.Name = "radioPaddleOn";
            this.radioPaddleOn.Size = new System.Drawing.Size(39, 17);
            this.radioPaddleOn.TabIndex = 8;
            this.radioPaddleOn.Text = "On";
            this.radioPaddleOn.UseVisualStyleBackColor = true;
            // 
            // radioPaddleAuto
            // 
            this.radioPaddleAuto.AutoSize = true;
            this.radioPaddleAuto.Checked = true;
            this.radioPaddleAuto.Location = new System.Drawing.Point(13, 15);
            this.radioPaddleAuto.Name = "radioPaddleAuto";
            this.radioPaddleAuto.Size = new System.Drawing.Size(189, 17);
            this.radioPaddleAuto.TabIndex = 9;
            this.radioPaddleAuto.TabStop = true;
            this.radioPaddleAuto.Text = "Automatic (Segon nom de la ROM)";
            this.radioPaddleAuto.UseVisualStyleBackColor = true;
            // 
            // radioPaddleOff
            // 
            this.radioPaddleOff.AutoSize = true;
            this.radioPaddleOff.Location = new System.Drawing.Point(13, 65);
            this.radioPaddleOff.Name = "radioPaddleOff";
            this.radioPaddleOff.Size = new System.Drawing.Size(39, 17);
            this.radioPaddleOff.TabIndex = 10;
            this.radioPaddleOff.Text = "Off";
            this.radioPaddleOff.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioPaddleAuto);
            this.groupBox3.Controls.Add(this.radioPaddleOff);
            this.groupBox3.Controls.Add(this.radioPaddleOn);
            this.groupBox3.Location = new System.Drawing.Point(0, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 86);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode Paddle";
            // 
            // checkBoxRenombrar
            // 
            this.checkBoxRenombrar.AutoSize = true;
            this.checkBoxRenombrar.Checked = true;
            this.checkBoxRenombrar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRenombrar.Location = new System.Drawing.Point(211, 387);
            this.checkBoxRenombrar.Name = "checkBoxRenombrar";
            this.checkBoxRenombrar.Size = new System.Drawing.Size(153, 17);
            this.checkBoxRenombrar.TabIndex = 12;
            this.checkBoxRenombrar.Text = "Renombrar ROMs per data";
            this.checkBoxRenombrar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 39);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 468);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxRenombrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxOptionMEnu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Atari 2600";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textEmulador;
        private System.Windows.Forms.CheckBox checkBoxOptionMEnu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResX;
        private System.Windows.Forms.TextBox textBoxResY;
        private System.Windows.Forms.RadioButton radioPaddleOn;
        private System.Windows.Forms.RadioButton radioPaddleAuto;
        private System.Windows.Forms.RadioButton radioPaddleOff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxRenombrar;
        private System.Windows.Forms.Label label3;
    }
}

