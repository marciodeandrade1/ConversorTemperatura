namespace ConversorTemperatura
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
            this.btnConverter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTk = new System.Windows.Forms.Label();
            this.lblTf = new System.Windows.Forms.Label();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(278, 25);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 0;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperatura em Celsius:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura em Kelvin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Temperatura em Fahrenheit:";
            // 
            // lblTk
            // 
            this.lblTk.AutoSize = true;
            this.lblTk.Location = new System.Drawing.Point(170, 56);
            this.lblTk.Name = "lblTk";
            this.lblTk.Size = new System.Drawing.Size(13, 13);
            this.lblTk.TabIndex = 1;
            this.lblTk.Text = "0";
            // 
            // lblTf
            // 
            this.lblTf.AutoSize = true;
            this.lblTf.Location = new System.Drawing.Point(170, 94);
            this.lblTf.Name = "lblTf";
            this.lblTf.Size = new System.Drawing.Size(13, 13);
            this.lblTf.TabIndex = 1;
            this.lblTf.Text = "0";
            // 
            // txtCelcius
            // 
            this.txtCelcius.Location = new System.Drawing.Point(141, 25);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(100, 20);
            this.txtCelcius.TabIndex = 2;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(278, 84);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 142);
            this.Controls.Add(this.txtCelcius);
            this.Controls.Add(this.lblTf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnConverter);
            this.Name = "Form1";
            this.Text = "Conversor 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTk;
        private System.Windows.Forms.Label lblTf;
        private System.Windows.Forms.TextBox txtCelcius;
        private System.Windows.Forms.Button btnFechar;
    }
}

