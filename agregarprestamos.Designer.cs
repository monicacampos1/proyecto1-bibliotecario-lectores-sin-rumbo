﻿
namespace Practica_semana_10
{
    partial class agregarprestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarprestamos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rnombre = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.bbuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtobser = new System.Windows.Forms.TextBox();
            this.tprestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Practica_semana_10.bibliotecaDataSet();
            this.obser = new System.Windows.Forms.Label();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.txtdevo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bcerrar = new System.Windows.Forms.Button();
            this.bactualizar = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bnuevo = new System.Windows.Forms.Button();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtlibro = new System.Windows.Forms.TextBox();
            this.txtidli = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tprestamosTableAdapter = new Practica_semana_10.bibliotecaDataSetTableAdapters.tprestamosTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tprestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox2.Controls.Add(this.rnombre);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.bbuscar);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.txtbuscar);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(666, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 567);
            this.groupBox2.TabIndex = 216;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empleados registrados";
            // 
            // rnombre
            // 
            this.rnombre.AutoSize = true;
            this.rnombre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rnombre.Location = new System.Drawing.Point(101, 64);
            this.rnombre.Name = "rnombre";
            this.rnombre.Size = new System.Drawing.Size(94, 26);
            this.rnombre.TabIndex = 137;
            this.rnombre.TabStop = true;
            this.rnombre.Text = "Nombre ";
            this.rnombre.UseVisualStyleBackColor = true;
            this.rnombre.CheckedChanged += new System.EventHandler(this.rnombre_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(101, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 26);
            this.radioButton1.TabIndex = 134;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Codigo";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // bbuscar
            // 
            this.bbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.bbuscar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.bbuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bbuscar.Location = new System.Drawing.Point(531, 37);
            this.bbuscar.Name = "bbuscar";
            this.bbuscar.Size = new System.Drawing.Size(87, 35);
            this.bbuscar.TabIndex = 133;
            this.bbuscar.Text = "Buscar";
            this.bbuscar.UseVisualStyleBackColor = false;
            this.bbuscar.Click += new System.EventHandler(this.bbuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 383);
            this.dataGridView1.TabIndex = 132;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtbuscar.Location = new System.Drawing.Point(241, 46);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(284, 26);
            this.txtbuscar.TabIndex = 131;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 130;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox1.Controls.Add(this.txtobser);
            this.groupBox1.Controls.Add(this.obser);
            this.groupBox1.Controls.Add(this.txtempleado);
            this.groupBox1.Controls.Add(this.txtdevo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtusu);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.txtlibro);
            this.groupBox1.Controls.Add(this.txtidli);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.t);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 577);
            this.groupBox1.TabIndex = 215;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario agregar prestamos";
            // 
            // txtobser
            // 
            this.txtobser.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tprestamosBindingSource, "observacionesp", true));
            this.txtobser.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtobser.Location = new System.Drawing.Point(200, 338);
            this.txtobser.Multiline = true;
            this.txtobser.Name = "txtobser";
            this.txtobser.Size = new System.Drawing.Size(295, 59);
            this.txtobser.TabIndex = 214;
            // 
            // tprestamosBindingSource
            // 
            this.tprestamosBindingSource.DataMember = "tprestamos";
            this.tprestamosBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obser
            // 
            this.obser.AutoSize = true;
            this.obser.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.obser.Location = new System.Drawing.Point(21, 338);
            this.obser.Name = "obser";
            this.obser.Size = new System.Drawing.Size(115, 22);
            this.obser.TabIndex = 213;
            this.obser.Text = "Observaiones ";
            // 
            // txtempleado
            // 
            this.txtempleado.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tprestamosBindingSource, "idempleadop", true));
            this.txtempleado.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtempleado.Location = new System.Drawing.Point(200, 283);
            this.txtempleado.Multiline = true;
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(295, 22);
            this.txtempleado.TabIndex = 212;
            // 
            // txtdevo
            // 
            this.txtdevo.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tprestamosBindingSource, "fdevolucionp", true));
            this.txtdevo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtdevo.Location = new System.Drawing.Point(200, 250);
            this.txtdevo.Multiline = true;
            this.txtdevo.Name = "txtdevo";
            this.txtdevo.Size = new System.Drawing.Size(295, 22);
            this.txtdevo.TabIndex = 211;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 22);
            this.label4.TabIndex = 210;
            this.label4.Text = "Fecha de devolución";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 208;
            this.label2.Text = "Nombre del libro";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bcerrar);
            this.groupBox4.Controls.Add(this.bactualizar);
            this.groupBox4.Controls.Add(this.bguardar);
            this.groupBox4.Controls.Add(this.bmodificar);
            this.groupBox4.Controls.Add(this.beliminar);
            this.groupBox4.Controls.Add(this.bnuevo);
            this.groupBox4.Location = new System.Drawing.Point(14, 403);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(612, 142);
            this.groupBox4.TabIndex = 206;
            this.groupBox4.TabStop = false;
            // 
            // bcerrar
            // 
            this.bcerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.bcerrar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.bcerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bcerrar.Location = new System.Drawing.Point(494, 26);
            this.bcerrar.Name = "bcerrar";
            this.bcerrar.Size = new System.Drawing.Size(100, 33);
            this.bcerrar.TabIndex = 0;
            this.bcerrar.Text = "Cerrar";
            this.bcerrar.UseVisualStyleBackColor = false;
            this.bcerrar.Click += new System.EventHandler(this.bcerrar_Click);
            // 
            // bactualizar
            // 
            this.bactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.bactualizar.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.bactualizar.ForeColor = System.Drawing.Color.White;
            this.bactualizar.Location = new System.Drawing.Point(326, 85);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(101, 40);
            this.bactualizar.TabIndex = 110;
            this.bactualizar.Text = "Actualizar ";
            this.bactualizar.UseVisualStyleBackColor = false;
            this.bactualizar.Visible = false;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // bguardar
            // 
            this.bguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.bguardar.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.bguardar.ForeColor = System.Drawing.Color.White;
            this.bguardar.Location = new System.Drawing.Point(19, 85);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(89, 40);
            this.bguardar.TabIndex = 109;
            this.bguardar.Text = "Guardar ";
            this.bguardar.UseVisualStyleBackColor = false;
            this.bguardar.Visible = false;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // bmodificar
            // 
            this.bmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.bmodificar.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.bmodificar.ForeColor = System.Drawing.Color.White;
            this.bmodificar.Location = new System.Drawing.Point(327, 26);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(100, 38);
            this.bmodificar.TabIndex = 108;
            this.bmodificar.Text = "Modificar";
            this.bmodificar.UseVisualStyleBackColor = false;
            this.bmodificar.Click += new System.EventHandler(this.bmodificar_Click);
            // 
            // beliminar
            // 
            this.beliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.beliminar.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.beliminar.ForeColor = System.Drawing.Color.White;
            this.beliminar.Location = new System.Drawing.Point(176, 21);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(89, 38);
            this.beliminar.TabIndex = 107;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = false;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // bnuevo
            // 
            this.bnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.bnuevo.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.bnuevo.ForeColor = System.Drawing.Color.White;
            this.bnuevo.Location = new System.Drawing.Point(19, 21);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(89, 38);
            this.bnuevo.TabIndex = 106;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = false;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // txtusu
            // 
            this.txtusu.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tprestamosBindingSource, "idusup", true));
            this.txtusu.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtusu.Location = new System.Drawing.Point(203, 100);
            this.txtusu.Multiline = true;
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(294, 22);
            this.txtusu.TabIndex = 203;
            // 
            // txtfecha
            // 
            this.txtfecha.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tprestamosBindingSource, "fentregap", true));
            this.txtfecha.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtfecha.Location = new System.Drawing.Point(200, 213);
            this.txtfecha.Multiline = true;
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(297, 22);
            this.txtfecha.TabIndex = 202;
            // 
            // txtlibro
            // 
            this.txtlibro.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tprestamosBindingSource, "nombrelip", true));
            this.txtlibro.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtlibro.Location = new System.Drawing.Point(200, 173);
            this.txtlibro.Multiline = true;
            this.txtlibro.Name = "txtlibro";
            this.txtlibro.Size = new System.Drawing.Size(295, 22);
            this.txtlibro.TabIndex = 201;
            // 
            // txtidli
            // 
            this.txtidli.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tprestamosBindingSource, "idlibrop", true));
            this.txtidli.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.txtidli.Location = new System.Drawing.Point(200, 134);
            this.txtidli.Multiline = true;
            this.txtidli.Name = "txtidli";
            this.txtidli.Size = new System.Drawing.Size(297, 22);
            this.txtidli.TabIndex = 200;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(20, 283);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 22);
            this.label17.TabIndex = 191;
            this.label17.Text = "Id empleado";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(21, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 22);
            this.label18.TabIndex = 190;
            this.label18.Text = "Id libro";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.t.Location = new System.Drawing.Point(21, 100);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(86, 22);
            this.t.TabIndex = 189;
            this.t.Text = "Id usuario";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(21, 213);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(134, 22);
            this.label20.TabIndex = 188;
            this.label20.Text = "Fecha de entrega";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 186;
            this.pictureBox2.TabStop = false;
            // 
            // tprestamosTableAdapter
            // 
            this.tprestamosTableAdapter.ClearBeforeFill = true;
            // 
            // agregarprestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(118)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(1329, 619);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregarprestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agregarprestamos";
            this.Load += new System.EventHandler(this.agregarprestamos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tprestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtempleado;
        private System.Windows.Forms.TextBox txtdevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button bcerrar;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtlibro;
        private System.Windows.Forms.TextBox txtidli;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtobser;
        private System.Windows.Forms.Label obser;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource tprestamosBindingSource;
        private bibliotecaDataSetTableAdapters.tprestamosTableAdapter tprestamosTableAdapter;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rnombre;
    }
}