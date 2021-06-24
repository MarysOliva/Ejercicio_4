namespace Ejercicio_4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combobox_lista = new System.Windows.Forms.ComboBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_desc = new System.Windows.Forms.Button();
            this.btn_asc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(6, 48);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(239, 20);
            this.txt_nom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre completo:";
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(294, 48);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(63, 20);
            this.txt_edad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad:";
            // 
            // combobox_lista
            // 
            this.combobox_lista.FormattingEnabled = true;
            this.combobox_lista.Location = new System.Drawing.Point(6, 122);
            this.combobox_lista.Name = "combobox_lista";
            this.combobox_lista.Size = new System.Drawing.Size(239, 21);
            this.combobox_lista.TabIndex = 3;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(294, 113);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(83, 36);
            this.btn_ingresar.TabIndex = 4;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista de alumnos:";
            // 
            // btn_desc
            // 
            this.btn_desc.Location = new System.Drawing.Point(294, 185);
            this.btn_desc.Name = "btn_desc";
            this.btn_desc.Size = new System.Drawing.Size(83, 23);
            this.btn_desc.TabIndex = 7;
            this.btn_desc.Text = "Descendente ";
            this.btn_desc.UseVisualStyleBackColor = true;
            this.btn_desc.Click += new System.EventHandler(this.btn_desc_Click);
            // 
            // btn_asc
            // 
            this.btn_asc.Location = new System.Drawing.Point(294, 156);
            this.btn_asc.Name = "btn_asc";
            this.btn_asc.Size = new System.Drawing.Size(83, 23);
            this.btn_asc.TabIndex = 7;
            this.btn_asc.Text = "Ascendente";
            this.btn_asc.UseVisualStyleBackColor = true;
            this.btn_asc.Click += new System.EventHandler(this.btn_asc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_desc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_asc);
            this.groupBox2.Controls.Add(this.txt_nom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_ingresar);
            this.groupBox2.Controls.Add(this.txt_edad);
            this.groupBox2.Controls.Add(this.combobox_lista);
            this.groupBox2.Location = new System.Drawing.Point(15, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 232);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 267);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combobox_lista;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_desc;
        private System.Windows.Forms.Button btn_asc;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

