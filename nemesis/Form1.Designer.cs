namespace nemesis
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
            this.pathDicc = new System.Windows.Forms.TextBox();
            this.fuzzingDirFic = new System.Windows.Forms.RadioButton();
            this.scan = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OutPut = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pathDicc
            // 
            this.pathDicc.Location = new System.Drawing.Point(676, 144);
            this.pathDicc.Name = "pathDicc";
            this.pathDicc.Size = new System.Drawing.Size(350, 22);
            this.pathDicc.TabIndex = 0;
            // 
            // fuzzingDirFic
            // 
            this.fuzzingDirFic.AutoSize = true;
            this.fuzzingDirFic.Location = new System.Drawing.Point(677, 196);
            this.fuzzingDirFic.Name = "fuzzingDirFic";
            this.fuzzingDirFic.Size = new System.Drawing.Size(132, 21);
            this.fuzzingDirFic.TabIndex = 1;
            this.fuzzingDirFic.TabStop = true;
            this.fuzzingDirFic.Text = "Fuzzing ficheros";
            this.fuzzingDirFic.UseVisualStyleBackColor = true;
            // 
            // scan
            // 
            this.scan.Location = new System.Drawing.Point(677, 223);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(75, 32);
            this.scan.TabIndex = 2;
            this.scan.Text = "scan";
            this.scan.UseVisualStyleBackColor = true;
            this.scan.Click += new System.EventHandler(this.scan_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(758, 223);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 32);
            this.stop.TabIndex = 3;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estado";
            // 
            // OutPut
            // 
            this.OutPut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.OutPut.Location = new System.Drawing.Point(12, 12);
            this.OutPut.Name = "OutPut";
            this.OutPut.Size = new System.Drawing.Size(222, 472);
            this.OutPut.TabIndex = 5;
            this.OutPut.UseCompatibleStateImageBehavior = false;
            this.OutPut.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ficheros";
            this.columnHeader1.Width = 150;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(677, 279);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(446, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(676, 116);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(100, 22);
            this.ipAddress.TabIndex = 7;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(794, 116);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(59, 22);
            this.Port.TabIndex = 8;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Estatus";
            // 
            // ext
            // 
            this.ext.Location = new System.Drawing.Point(676, 169);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(100, 22);
            this.ext.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP/Puerto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Extension fichero:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::nemesis.Properties.Resources.nemesiss;
            this.pictureBox1.Location = new System.Drawing.Point(240, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(899, 472);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1135, 487);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.scan);
            this.Controls.Add(this.fuzzingDirFic);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.pathDicc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OutPut);
            this.Name = "Form1";
            this.Text = "nemesis";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathDicc;
        private System.Windows.Forms.RadioButton fuzzingDirFic;
        private System.Windows.Forms.Button scan;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView OutPut;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox ipAddress;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox ext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

