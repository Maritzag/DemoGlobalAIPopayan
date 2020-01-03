namespace wf_demoCustomVision
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.btnClasificar = new System.Windows.Forms.Button();
            this.exploradorArchivos = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imagen";
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(205, 27);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(284, 31);
            this.txtImagen.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(554, 18);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(105, 48);
            this.btnCargarImagen.TabIndex = 3;
            this.btnCargarImagen.Text = "Cargar";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(95, 136);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(417, 406);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 4;
            this.pbxImagen.TabStop = false;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(753, 177);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(418, 365);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.Text = "";
            // 
            // btnClasificar
            // 
            this.btnClasificar.Location = new System.Drawing.Point(175, 573);
            this.btnClasificar.Name = "btnClasificar";
            this.btnClasificar.Size = new System.Drawing.Size(149, 61);
            this.btnClasificar.TabIndex = 6;
            this.btnClasificar.Text = "Clasificar";
            this.btnClasificar.UseVisualStyleBackColor = true;
            this.btnClasificar.Click += new System.EventHandler(this.btnClasificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 809);
            this.Controls.Add(this.btnClasificar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demo Custom Vision";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCargarImagen;
        public System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.Button btnClasificar;
        private System.Windows.Forms.OpenFileDialog exploradorArchivos;
    }
}

