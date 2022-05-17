namespace programExercise
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lcount = new System.Windows.Forms.Label();
            this.btnExamine = new System.Windows.Forms.Button();
            this.DGVMonitor = new System.Windows.Forms.DataGridView();
            this.tarea1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Thread1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcount
            // 
            this.lcount.AutoSize = true;
            this.lcount.Location = new System.Drawing.Point(302, 326);
            this.lcount.Name = "lcount";
            this.lcount.Size = new System.Drawing.Size(90, 13);
            this.lcount.TabIndex = 16;
            this.lcount.Text = "Processed files: 0";
            // 
            // btnExamine
            // 
            this.btnExamine.Location = new System.Drawing.Point(328, 43);
            this.btnExamine.Name = "btnExamine";
            this.btnExamine.Size = new System.Drawing.Size(64, 23);
            this.btnExamine.TabIndex = 15;
            this.btnExamine.Text = "Examine";
            this.btnExamine.UseVisualStyleBackColor = true;
            this.btnExamine.Click += new System.EventHandler(this.btnExamine_Click);
            // 
            // DGVMonitor
            // 
            this.DGVMonitor.AllowUserToAddRows = false;
            this.DGVMonitor.AllowUserToDeleteRows = false;
            this.DGVMonitor.AllowUserToResizeRows = false;
            this.DGVMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVMonitor.BackgroundColor = System.Drawing.Color.White;
            this.DGVMonitor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVMonitor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMonitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tarea1,
            this.salida});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVMonitor.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVMonitor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DGVMonitor.Location = new System.Drawing.Point(13, 109);
            this.DGVMonitor.Name = "DGVMonitor";
            this.DGVMonitor.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMonitor.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVMonitor.RowHeadersVisible = false;
            this.DGVMonitor.Size = new System.Drawing.Size(379, 211);
            this.DGVMonitor.TabIndex = 14;
            // 
            // tarea1
            // 
            this.tarea1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tarea1.HeaderText = "File";
            this.tarea1.Name = "tarea1";
            this.tarea1.ReadOnly = true;
            this.tarea1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tarea1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // salida
            // 
            this.salida.FillWeight = 350F;
            this.salida.HeaderText = "Execution date";
            this.salida.Name = "salida";
            this.salida.ReadOnly = true;
            this.salida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.salida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.salida.Width = 170;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(13, 46);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(309, 20);
            this.txtPath.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please put the path of the folder you want to monitor";
            // 
            // Thread1
            // 
            this.Thread1.Interval = 1000;
            this.Thread1.Tick += new System.EventHandler(this.Thread1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::programExercise.Properties.Resources.icono_information2;
            this.pictureBox1.Location = new System.Drawing.Point(13, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::programExercise.Properties.Resources.ejecutar_icon1;
            this.btnStart.Location = new System.Drawing.Point(328, 72);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(64, 31);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::programExercise.Properties.Resources.stop_icon1;
            this.btnStop.Location = new System.Drawing.Point(272, 72);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 31);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 349);
            this.Controls.Add(this.lcount);
            this.Controls.Add(this.btnExamine);
            this.Controls.Add(this.DGVMonitor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Watcher";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lcount;
        private System.Windows.Forms.Button btnExamine;
        internal System.Windows.Forms.DataGridView DGVMonitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarea1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Thread1;
    }
}

