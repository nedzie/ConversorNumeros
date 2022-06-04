namespace TesteConversor
{
    partial class Teste
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
            this.components = new System.ComponentModel.Container();
            this.numericUpDownDecimais = new System.Windows.Forms.NumericUpDown();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.textBoxRomanoConvertido = new System.Windows.Forms.TextBox();
            this.buttonConverterDeVoltaDecimal = new System.Windows.Forms.Button();
            this.textBoxDeVoltaDecimais = new System.Windows.Forms.TextBox();
            this.buttonMaisCem = new System.Windows.Forms.Button();
            this.buttonMaisQuinhentos = new System.Windows.Forms.Button();
            this.buttonMaisMil = new System.Windows.Forms.Button();
            this.buttonMenos1000 = new System.Windows.Forms.Button();
            this.buttonMenos500 = new System.Windows.Forms.Button();
            this.buttonMenosCem = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.timerTemp = new System.Windows.Forms.Timer(this.components);
            this.buttonRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDecimais)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownDecimais
            // 
            this.numericUpDownDecimais.BackColor = System.Drawing.Color.White;
            this.numericUpDownDecimais.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownDecimais.ForeColor = System.Drawing.Color.DimGray;
            this.numericUpDownDecimais.Location = new System.Drawing.Point(122, 114);
            this.numericUpDownDecimais.Maximum = new decimal(new int[] {
            3999,
            0,
            0,
            0});
            this.numericUpDownDecimais.Name = "numericUpDownDecimais";
            this.numericUpDownDecimais.ReadOnly = true;
            this.numericUpDownDecimais.Size = new System.Drawing.Size(120, 35);
            this.numericUpDownDecimais.TabIndex = 0;
            // 
            // buttonConverter
            // 
            this.buttonConverter.BackColor = System.Drawing.Color.White;
            this.buttonConverter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConverter.FlatAppearance.BorderSize = 0;
            this.buttonConverter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonConverter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConverter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConverter.Location = new System.Drawing.Point(292, 155);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(90, 39);
            this.buttonConverter.TabIndex = 1;
            this.buttonConverter.Text = "Converter";
            this.buttonConverter.UseVisualStyleBackColor = false;
            this.buttonConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // textBoxRomanoConvertido
            // 
            this.textBoxRomanoConvertido.BackColor = System.Drawing.Color.White;
            this.textBoxRomanoConvertido.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRomanoConvertido.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxRomanoConvertido.Location = new System.Drawing.Point(292, 104);
            this.textBoxRomanoConvertido.Multiline = true;
            this.textBoxRomanoConvertido.Name = "textBoxRomanoConvertido";
            this.textBoxRomanoConvertido.ReadOnly = true;
            this.textBoxRomanoConvertido.Size = new System.Drawing.Size(173, 45);
            this.textBoxRomanoConvertido.TabIndex = 2;
            // 
            // buttonConverterDeVoltaDecimal
            // 
            this.buttonConverterDeVoltaDecimal.BackColor = System.Drawing.Color.White;
            this.buttonConverterDeVoltaDecimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConverterDeVoltaDecimal.FlatAppearance.BorderSize = 0;
            this.buttonConverterDeVoltaDecimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonConverterDeVoltaDecimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonConverterDeVoltaDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConverterDeVoltaDecimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConverterDeVoltaDecimal.Location = new System.Drawing.Point(476, 155);
            this.buttonConverterDeVoltaDecimal.Name = "buttonConverterDeVoltaDecimal";
            this.buttonConverterDeVoltaDecimal.Size = new System.Drawing.Size(90, 39);
            this.buttonConverterDeVoltaDecimal.TabIndex = 6;
            this.buttonConverterDeVoltaDecimal.Text = "Converter";
            this.buttonConverterDeVoltaDecimal.UseVisualStyleBackColor = false;
            this.buttonConverterDeVoltaDecimal.Click += new System.EventHandler(this.buttonConverterDeVoltaDecimal_Click);
            // 
            // textBoxDeVoltaDecimais
            // 
            this.textBoxDeVoltaDecimais.BackColor = System.Drawing.Color.White;
            this.textBoxDeVoltaDecimais.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDeVoltaDecimais.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDeVoltaDecimais.Location = new System.Drawing.Point(476, 104);
            this.textBoxDeVoltaDecimais.Multiline = true;
            this.textBoxDeVoltaDecimais.Name = "textBoxDeVoltaDecimais";
            this.textBoxDeVoltaDecimais.ReadOnly = true;
            this.textBoxDeVoltaDecimais.Size = new System.Drawing.Size(173, 45);
            this.textBoxDeVoltaDecimais.TabIndex = 7;
            // 
            // buttonMaisCem
            // 
            this.buttonMaisCem.BackColor = System.Drawing.Color.White;
            this.buttonMaisCem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaisCem.FlatAppearance.BorderSize = 0;
            this.buttonMaisCem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonMaisCem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMaisCem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaisCem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMaisCem.Location = new System.Drawing.Point(83, 155);
            this.buttonMaisCem.Name = "buttonMaisCem";
            this.buttonMaisCem.Size = new System.Drawing.Size(90, 39);
            this.buttonMaisCem.TabIndex = 9;
            this.buttonMaisCem.Text = "+100";
            this.buttonMaisCem.UseVisualStyleBackColor = false;
            this.buttonMaisCem.Click += new System.EventHandler(this.buttonMaisCem_Click);
            // 
            // buttonMaisQuinhentos
            // 
            this.buttonMaisQuinhentos.BackColor = System.Drawing.Color.White;
            this.buttonMaisQuinhentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaisQuinhentos.FlatAppearance.BorderSize = 0;
            this.buttonMaisQuinhentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonMaisQuinhentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMaisQuinhentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaisQuinhentos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMaisQuinhentos.Location = new System.Drawing.Point(83, 202);
            this.buttonMaisQuinhentos.Name = "buttonMaisQuinhentos";
            this.buttonMaisQuinhentos.Size = new System.Drawing.Size(90, 39);
            this.buttonMaisQuinhentos.TabIndex = 10;
            this.buttonMaisQuinhentos.Text = "+500";
            this.buttonMaisQuinhentos.UseVisualStyleBackColor = false;
            this.buttonMaisQuinhentos.Click += new System.EventHandler(this.buttonMaisQuinhentos_Click);
            // 
            // buttonMaisMil
            // 
            this.buttonMaisMil.BackColor = System.Drawing.Color.White;
            this.buttonMaisMil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaisMil.FlatAppearance.BorderSize = 0;
            this.buttonMaisMil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonMaisMil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMaisMil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaisMil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMaisMil.Location = new System.Drawing.Point(83, 247);
            this.buttonMaisMil.Name = "buttonMaisMil";
            this.buttonMaisMil.Size = new System.Drawing.Size(90, 39);
            this.buttonMaisMil.TabIndex = 11;
            this.buttonMaisMil.Text = "+1000";
            this.buttonMaisMil.UseVisualStyleBackColor = false;
            this.buttonMaisMil.Click += new System.EventHandler(this.buttonMaisMil_Click);
            // 
            // buttonMenos1000
            // 
            this.buttonMenos1000.BackColor = System.Drawing.Color.White;
            this.buttonMenos1000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenos1000.FlatAppearance.BorderSize = 0;
            this.buttonMenos1000.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonMenos1000.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMenos1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenos1000.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMenos1000.Location = new System.Drawing.Point(179, 247);
            this.buttonMenos1000.Name = "buttonMenos1000";
            this.buttonMenos1000.Size = new System.Drawing.Size(90, 39);
            this.buttonMenos1000.TabIndex = 14;
            this.buttonMenos1000.Text = "-1000";
            this.buttonMenos1000.UseVisualStyleBackColor = false;
            this.buttonMenos1000.Click += new System.EventHandler(this.buttonMenos1000_Click);
            // 
            // buttonMenos500
            // 
            this.buttonMenos500.BackColor = System.Drawing.Color.White;
            this.buttonMenos500.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenos500.FlatAppearance.BorderSize = 0;
            this.buttonMenos500.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonMenos500.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMenos500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenos500.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMenos500.Location = new System.Drawing.Point(179, 200);
            this.buttonMenos500.Name = "buttonMenos500";
            this.buttonMenos500.Size = new System.Drawing.Size(90, 39);
            this.buttonMenos500.TabIndex = 13;
            this.buttonMenos500.Text = "-500";
            this.buttonMenos500.UseVisualStyleBackColor = false;
            this.buttonMenos500.Click += new System.EventHandler(this.buttonMenos500_Click);
            // 
            // buttonMenosCem
            // 
            this.buttonMenosCem.BackColor = System.Drawing.Color.White;
            this.buttonMenosCem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenosCem.FlatAppearance.BorderSize = 0;
            this.buttonMenosCem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonMenosCem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMenosCem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenosCem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMenosCem.Location = new System.Drawing.Point(179, 155);
            this.buttonMenosCem.Name = "buttonMenosCem";
            this.buttonMenosCem.Size = new System.Drawing.Size(90, 39);
            this.buttonMenosCem.TabIndex = 12;
            this.buttonMenosCem.Text = "-100";
            this.buttonMenosCem.UseVisualStyleBackColor = false;
            this.buttonMenosCem.Click += new System.EventHandler(this.buttonMenosCem_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.IndianRed;
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(627, 247);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(90, 39);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Resetar";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // timerTemp
            // 
            this.timerTemp.Enabled = true;
            this.timerTemp.Interval = 50;
            this.timerTemp.Tick += new System.EventHandler(this.timerTemp_Tick);
            // 
            // buttonRandom
            // 
            this.buttonRandom.BackColor = System.Drawing.Color.Orange;
            this.buttonRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRandom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRandom.FlatAppearance.BorderSize = 0;
            this.buttonRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.buttonRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRandom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRandom.ForeColor = System.Drawing.Color.White;
            this.buttonRandom.Location = new System.Drawing.Point(122, 69);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(90, 39);
            this.buttonRandom.TabIndex = 16;
            this.buttonRandom.Text = "Aleatório";
            this.buttonRandom.UseVisualStyleBackColor = false;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("iA Writer Duo S", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(292, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Em romanos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("iA Writer Duo S", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(476, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Novamente em decimais:";
            // 
            // Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(840, 430);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonMenos1000);
            this.Controls.Add(this.buttonMenos500);
            this.Controls.Add(this.buttonMenosCem);
            this.Controls.Add(this.buttonMaisMil);
            this.Controls.Add(this.buttonMaisQuinhentos);
            this.Controls.Add(this.buttonMaisCem);
            this.Controls.Add(this.textBoxDeVoltaDecimais);
            this.Controls.Add(this.buttonConverterDeVoltaDecimal);
            this.Controls.Add(this.textBoxRomanoConvertido);
            this.Controls.Add(this.buttonConverter);
            this.Controls.Add(this.numericUpDownDecimais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Teste";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDecimais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownDecimais;
        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.TextBox textBoxRomanoConvertido;
        private System.Windows.Forms.Button buttonConverterDeVoltaDecimal;
        private System.Windows.Forms.TextBox textBoxDeVoltaDecimais;
        private System.Windows.Forms.Button buttonMaisCem;
        private System.Windows.Forms.Button buttonMaisQuinhentos;
        private System.Windows.Forms.Button buttonMaisMil;
        private System.Windows.Forms.Button buttonMenos1000;
        private System.Windows.Forms.Button buttonMenos500;
        private System.Windows.Forms.Button buttonMenosCem;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Timer timerTemp;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}