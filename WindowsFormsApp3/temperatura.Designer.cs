namespace WindowsFormsApp3
{
    partial class temperatura
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Temp = new System.Windows.Forms.TextBox();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.rdb_CpF = new System.Windows.Forms.RadioButton();
            this.rdb_KpC = new System.Windows.Forms.RadioButton();
            this.rdb_CpK = new System.Windows.Forms.RadioButton();
            this.rdb_FpC = new System.Windows.Forms.RadioButton();
            this.btn_convert = new System.Windows.Forms.Button();
            this.lbl_convert = new System.Windows.Forms.Label();
            this.txt_convert = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Temp
            // 
            this.txt_Temp.Location = new System.Drawing.Point(115, 35);
            this.txt_Temp.Name = "txt_Temp";
            this.txt_Temp.Size = new System.Drawing.Size(100, 20);
            this.txt_Temp.TabIndex = 0;
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.Location = new System.Drawing.Point(42, 38);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(67, 13);
            this.lbl_Temp.TabIndex = 1;
            this.lbl_Temp.Text = "Temperatura";
            // 
            // rdb_CpF
            // 
            this.rdb_CpF.AutoSize = true;
            this.rdb_CpF.Location = new System.Drawing.Point(64, 61);
            this.rdb_CpF.Name = "rdb_CpF";
            this.rdb_CpF.Size = new System.Drawing.Size(128, 17);
            this.rdb_CpF.TabIndex = 2;
            this.rdb_CpF.TabStop = true;
            this.rdb_CpF.Text = "Celcius p/ Fahreinheit";
            this.rdb_CpF.UseVisualStyleBackColor = true;
            // 
            // rdb_KpC
            // 
            this.rdb_KpC.AutoSize = true;
            this.rdb_KpC.Location = new System.Drawing.Point(64, 130);
            this.rdb_KpC.Name = "rdb_KpC";
            this.rdb_KpC.Size = new System.Drawing.Size(105, 17);
            this.rdb_KpC.TabIndex = 3;
            this.rdb_KpC.TabStop = true;
            this.rdb_KpC.Text = "Kelvin p/ Celcius";
            this.rdb_KpC.UseVisualStyleBackColor = true;
            // 
            // rdb_CpK
            // 
            this.rdb_CpK.AutoSize = true;
            this.rdb_CpK.Location = new System.Drawing.Point(64, 107);
            this.rdb_CpK.Name = "rdb_CpK";
            this.rdb_CpK.Size = new System.Drawing.Size(105, 17);
            this.rdb_CpK.TabIndex = 4;
            this.rdb_CpK.TabStop = true;
            this.rdb_CpK.Text = "Celcius p/ Kelvin";
            this.rdb_CpK.UseVisualStyleBackColor = true;
            this.rdb_CpK.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdb_FpC
            // 
            this.rdb_FpC.AutoSize = true;
            this.rdb_FpC.Location = new System.Drawing.Point(64, 84);
            this.rdb_FpC.Name = "rdb_FpC";
            this.rdb_FpC.Size = new System.Drawing.Size(126, 17);
            this.rdb_FpC.TabIndex = 5;
            this.rdb_FpC.TabStop = true;
            this.rdb_FpC.Text = "Fahrenheit p/ Celcius";
            this.rdb_FpC.UseVisualStyleBackColor = true;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(45, 158);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(170, 23);
            this.btn_convert.TabIndex = 6;
            this.btn_convert.Text = "Converter";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // lbl_convert
            // 
            this.lbl_convert.AutoSize = true;
            this.lbl_convert.Location = new System.Drawing.Point(42, 199);
            this.lbl_convert.Name = "lbl_convert";
            this.lbl_convert.Size = new System.Drawing.Size(58, 13);
            this.lbl_convert.TabIndex = 8;
            this.lbl_convert.Text = "Conversão";
            this.lbl_convert.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_convert
            // 
            this.txt_convert.Location = new System.Drawing.Point(106, 196);
            this.txt_convert.Name = "txt_convert";
            this.txt_convert.Size = new System.Drawing.Size(109, 20);
            this.txt_convert.TabIndex = 7;
            this.txt_convert.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_convert);
            this.Controls.Add(this.txt_convert);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.rdb_FpC);
            this.Controls.Add(this.rdb_CpK);
            this.Controls.Add(this.rdb_KpC);
            this.Controls.Add(this.rdb_CpF);
            this.Controls.Add(this.lbl_Temp);
            this.Controls.Add(this.txt_Temp);
            this.Name = "temperatura";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Temp;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.RadioButton rdb_CpF;
        private System.Windows.Forms.RadioButton rdb_KpC;
        private System.Windows.Forms.RadioButton rdb_CpK;
        private System.Windows.Forms.RadioButton rdb_FpC;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Label lbl_convert;
        private System.Windows.Forms.TextBox txt_convert;
    }
}

