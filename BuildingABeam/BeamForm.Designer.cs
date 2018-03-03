namespace BuildingABeam
{
    partial class BeamForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Build = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ExternalDiameter = new System.Windows.Forms.TextBox();
            this.Depth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BeamParams = new System.Windows.Forms.TextBox();
            this.BeamPic = new System.Windows.Forms.PictureBox();
            this.BeamLength = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buildstate = new System.Windows.Forms.Label();
            this.OpenSelectDialog = new System.Windows.Forms.Button();
            this.PathToBeam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectBeam = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.BeamPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Параметры балки";
            // 
            // Build
            // 
            this.Build.Location = new System.Drawing.Point(12, 185);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(75, 23);
            this.Build.TabIndex = 4;
            this.Build.Text = "Построить";
            this.Build.UseVisualStyleBackColor = true;
            this.Build.Click += new System.EventHandler(this.Build_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Внешний диаметр х толщина";
            // 
            // ExternalDiameter
            // 
            this.ExternalDiameter.Location = new System.Drawing.Point(12, 50);
            this.ExternalDiameter.Name = "ExternalDiameter";
            this.ExternalDiameter.Size = new System.Drawing.Size(65, 20);
            this.ExternalDiameter.TabIndex = 6;
            this.ExternalDiameter.Text = "100";
            this.ExternalDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Depth
            // 
            this.Depth.Location = new System.Drawing.Point(101, 50);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(64, 20);
            this.Depth.TabIndex = 7;
            this.Depth.Text = "2";
            this.Depth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "х";
            // 
            // BeamParams
            // 
            this.BeamParams.Location = new System.Drawing.Point(12, 91);
            this.BeamParams.Multiline = true;
            this.BeamParams.Name = "BeamParams";
            this.BeamParams.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BeamParams.Size = new System.Drawing.Size(153, 88);
            this.BeamParams.TabIndex = 9;
            // 
            // BeamPic
            // 
            this.BeamPic.Image = global::BuildingABeam.Properties.Resources.RingBeam;
            this.BeamPic.Location = new System.Drawing.Point(180, 50);
            this.BeamPic.Name = "BeamPic";
            this.BeamPic.Size = new System.Drawing.Size(196, 196);
            this.BeamPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BeamPic.TabIndex = 10;
            this.BeamPic.TabStop = false;
            // 
            // BeamLength
            // 
            this.BeamLength.Location = new System.Drawing.Point(58, 6);
            this.BeamLength.Name = "BeamLength";
            this.BeamLength.Size = new System.Drawing.Size(65, 20);
            this.BeamLength.TabIndex = 11;
            this.BeamLength.Text = "300";
            this.BeamLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 252);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(367, 23);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Value = 100;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // buildstate
            // 
            this.buildstate.AutoSize = true;
            this.buildstate.Location = new System.Drawing.Point(12, 236);
            this.buildstate.Name = "buildstate";
            this.buildstate.Size = new System.Drawing.Size(36, 13);
            this.buildstate.TabIndex = 13;
            this.buildstate.Text = "Готов";
            // 
            // OpenSelectDialog
            // 
            this.OpenSelectDialog.Location = new System.Drawing.Point(180, 27);
            this.OpenSelectDialog.Name = "OpenSelectDialog";
            this.OpenSelectDialog.Size = new System.Drawing.Size(68, 20);
            this.OpenSelectDialog.TabIndex = 14;
            this.OpenSelectDialog.Text = "Обзор";
            this.OpenSelectDialog.UseVisualStyleBackColor = true;
            this.OpenSelectDialog.Click += new System.EventHandler(this.OpenSelectDialog_Click);
            // 
            // PathToBeam
            // 
            this.PathToBeam.Location = new System.Drawing.Point(254, 27);
            this.PathToBeam.Name = "PathToBeam";
            this.PathToBeam.Size = new System.Drawing.Size(122, 20);
            this.PathToBeam.TabIndex = 15;
            this.PathToBeam.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Выберите файл балки";
            // 
            // SelectBeam
            // 
            this.SelectBeam.FileName = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 287);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PathToBeam);
            this.Controls.Add(this.OpenSelectDialog);
            this.Controls.Add(this.buildstate);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BeamLength);
            this.Controls.Add(this.BeamPic);
            this.Controls.Add(this.BeamParams);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.ExternalDiameter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Балка кольцо";
            ((System.ComponentModel.ISupportInitialize)(this.BeamPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Build;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExternalDiameter;
        private System.Windows.Forms.TextBox Depth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BeamParams;
        private System.Windows.Forms.PictureBox BeamPic;
        private System.Windows.Forms.TextBox BeamLength;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label buildstate;
        private System.Windows.Forms.Button OpenSelectDialog;
        private System.Windows.Forms.TextBox PathToBeam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog SelectBeam;
    }
}

