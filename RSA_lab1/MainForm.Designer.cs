
namespace RSA_lab1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            encrypt = new Button();
            decrypt = new Button();
            textBoxS = new TextBox();
            textBoxN = new TextBox();
            textBoxE = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox = new TextBox();
            cipherBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(36, 320);
            button1.Name = "button1";
            button1.Size = new Size(373, 53);
            button1.TabIndex = 0;
            button1.Text = "Генерировать ключи";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // encrypt
            // 
            encrypt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            encrypt.Location = new Point(415, 320);
            encrypt.Name = "encrypt";
            encrypt.Size = new Size(373, 53);
            encrypt.TabIndex = 1;
            encrypt.Text = "Шифровать текст";
            encrypt.UseVisualStyleBackColor = true;
            encrypt.Click += encrypt_Click;
            // 
            // decrypt
            // 
            decrypt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            decrypt.Location = new Point(794, 320);
            decrypt.Name = "decrypt";
            decrypt.Size = new Size(373, 53);
            decrypt.TabIndex = 2;
            decrypt.Text = "Расшифровать текст";
            decrypt.UseVisualStyleBackColor = true;
            decrypt.Click += decrypt_Click;
            // 
            // textBoxS
            // 
            textBoxS.Location = new Point(163, 58);
            textBoxS.Name = "textBoxS";
            textBoxS.Size = new Size(1183, 39);
            textBoxS.TabIndex = 3;
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(163, 135);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(1183, 39);
            textBoxN.TabIndex = 4;
            // 
            // textBoxE
            // 
            textBoxE.Location = new Point(163, 220);
            textBoxE.Name = "textBoxE";
            textBoxE.Size = new Size(1183, 39);
            textBoxE.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(36, 58);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 6;
            label1.Text = "s (public)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(36, 135);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 7;
            label2.Text = "N (public)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(36, 220);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 8;
            label3.Text = "e (private)";
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox.Location = new Point(36, 442);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.Size = new Size(631, 346);
            textBox.TabIndex = 9;
            // 
            // cipherBox
            // 
            cipherBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cipherBox.Location = new Point(715, 442);
            cipherBox.Multiline = true;
            cipherBox.Name = "cipherBox";
            cipherBox.ScrollBars = ScrollBars.Vertical;
            cipherBox.Size = new Size(631, 346);
            cipherBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(36, 392);
            label4.Name = "label4";
            label4.Size = new Size(188, 32);
            label4.TabIndex = 11;
            label4.Text = "Обычный текст";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(715, 392);
            label5.Name = "label5";
            label5.Size = new Size(270, 32);
            label5.TabIndex = 12;
            label5.Text = "Зашифрованный текст";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 834);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cipherBox);
            Controls.Add(textBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxE);
            Controls.Add(textBoxN);
            Controls.Add(textBoxS);
            Controls.Add(decrypt);
            Controls.Add(encrypt);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "RSA (вариант 7)";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button encrypt;
        private Button decrypt;
        private TextBox textBoxS;
        private TextBox textBoxN;
        private TextBox textBoxE;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox;
        private TextBox cipherBox;
        private Label label4;
        private Label label5;
    }
}
