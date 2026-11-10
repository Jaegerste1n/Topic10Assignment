namespace Topic10Assignment
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
            this.btnThatKillsMario = new System.Windows.Forms.Button();
            this.lblMarioComplaint = new System.Windows.Forms.Label();
            this.btnCPU = new System.Windows.Forms.Button();
            this.btnRAM = new System.Windows.Forms.Button();
            this.btnSSD = new System.Windows.Forms.Button();
            this.btnPowerSupply = new System.Windows.Forms.Button();
            this.btnInputPeripheral = new System.Windows.Forms.Button();
            this.btnOutputPeripheral = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDesc2 = new System.Windows.Forms.Label();
            this.imgComponent = new System.Windows.Forms.PictureBox();
            this.imgMario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgComponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThatKillsMario
            // 
            this.btnThatKillsMario.Enabled = false;
            this.btnThatKillsMario.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThatKillsMario.Location = new System.Drawing.Point(570, 276);
            this.btnThatKillsMario.Name = "btnThatKillsMario";
            this.btnThatKillsMario.Size = new System.Drawing.Size(94, 77);
            this.btnThatKillsMario.TabIndex = 1;
            this.btnThatKillsMario.Text = "Button That Kills Mario";
            this.btnThatKillsMario.UseVisualStyleBackColor = true;
            this.btnThatKillsMario.Visible = false;
            this.btnThatKillsMario.Click += new System.EventHandler(this.btnThatKillsMario_Click);
            // 
            // lblMarioComplaint
            // 
            this.lblMarioComplaint.AutoSize = true;
            this.lblMarioComplaint.BackColor = System.Drawing.Color.Transparent;
            this.lblMarioComplaint.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarioComplaint.ForeColor = System.Drawing.Color.Red;
            this.lblMarioComplaint.Location = new System.Drawing.Point(455, 356);
            this.lblMarioComplaint.Name = "lblMarioComplaint";
            this.lblMarioComplaint.Size = new System.Drawing.Size(356, 18);
            this.lblMarioComplaint.TabIndex = 2;
            this.lblMarioComplaint.Text = "What Is Wrong With You Why Would You Do That You Herrid Twat";
            this.lblMarioComplaint.Visible = false;
            // 
            // btnCPU
            // 
            this.btnCPU.Font = new System.Drawing.Font("GOST Common", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPU.Location = new System.Drawing.Point(12, 12);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(85, 23);
            this.btnCPU.TabIndex = 3;
            this.btnCPU.Text = "CPU";
            this.btnCPU.UseVisualStyleBackColor = true;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // btnRAM
            // 
            this.btnRAM.Font = new System.Drawing.Font("GOST Common", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRAM.Location = new System.Drawing.Point(12, 41);
            this.btnRAM.Name = "btnRAM";
            this.btnRAM.Size = new System.Drawing.Size(85, 23);
            this.btnRAM.TabIndex = 4;
            this.btnRAM.Text = "RAM";
            this.btnRAM.UseVisualStyleBackColor = true;
            this.btnRAM.Click += new System.EventHandler(this.btnRAM_Click);
            // 
            // btnSSD
            // 
            this.btnSSD.Font = new System.Drawing.Font("GOST Common", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSD.Location = new System.Drawing.Point(12, 70);
            this.btnSSD.Name = "btnSSD";
            this.btnSSD.Size = new System.Drawing.Size(85, 23);
            this.btnSSD.TabIndex = 5;
            this.btnSSD.Text = "SSD";
            this.btnSSD.UseVisualStyleBackColor = true;
            this.btnSSD.Click += new System.EventHandler(this.btnSSD_Click);
            // 
            // btnPowerSupply
            // 
            this.btnPowerSupply.Font = new System.Drawing.Font("GOST Common", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPowerSupply.Location = new System.Drawing.Point(12, 99);
            this.btnPowerSupply.Name = "btnPowerSupply";
            this.btnPowerSupply.Size = new System.Drawing.Size(85, 23);
            this.btnPowerSupply.TabIndex = 6;
            this.btnPowerSupply.Text = "Power Supply";
            this.btnPowerSupply.UseVisualStyleBackColor = true;
            this.btnPowerSupply.Click += new System.EventHandler(this.btnPowerSupply_Click);
            // 
            // btnInputPeripheral
            // 
            this.btnInputPeripheral.Font = new System.Drawing.Font("GOST Common", 6.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputPeripheral.Location = new System.Drawing.Point(12, 128);
            this.btnInputPeripheral.Name = "btnInputPeripheral";
            this.btnInputPeripheral.Size = new System.Drawing.Size(85, 23);
            this.btnInputPeripheral.TabIndex = 7;
            this.btnInputPeripheral.Text = "Input Peripheral";
            this.btnInputPeripheral.UseVisualStyleBackColor = true;
            this.btnInputPeripheral.Click += new System.EventHandler(this.btnInputPeripheral_Click);
            // 
            // btnOutputPeripheral
            // 
            this.btnOutputPeripheral.Font = new System.Drawing.Font("GOST Common", 5.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputPeripheral.Location = new System.Drawing.Point(12, 157);
            this.btnOutputPeripheral.Name = "btnOutputPeripheral";
            this.btnOutputPeripheral.Size = new System.Drawing.Size(85, 23);
            this.btnOutputPeripheral.TabIndex = 8;
            this.btnOutputPeripheral.Text = "Output Peripheral";
            this.btnOutputPeripheral.UseVisualStyleBackColor = true;
            this.btnOutputPeripheral.Click += new System.EventHandler(this.btnOutputPeripheral_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescription.Location = new System.Drawing.Point(130, 267);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(28, 14);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "N/A";
            this.lblDescription.Visible = false;
            // 
            // lblDesc2
            // 
            this.lblDesc2.AutoSize = true;
            this.lblDesc2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDesc2.Location = new System.Drawing.Point(130, 281);
            this.lblDesc2.Name = "lblDesc2";
            this.lblDesc2.Size = new System.Drawing.Size(28, 14);
            this.lblDesc2.TabIndex = 11;
            this.lblDesc2.Text = "N/A";
            this.lblDesc2.Visible = false;
            // 
            // imgComponent
            // 
            this.imgComponent.Location = new System.Drawing.Point(133, 12);
            this.imgComponent.Name = "imgComponent";
            this.imgComponent.Size = new System.Drawing.Size(378, 238);
            this.imgComponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgComponent.TabIndex = 9;
            this.imgComponent.TabStop = false;
            // 
            // imgMario
            // 
            this.imgMario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMario.Image = global::Topic10Assignment.Properties.Resources.MarioDead;
            this.imgMario.Location = new System.Drawing.Point(671, 362);
            this.imgMario.Name = "imgMario";
            this.imgMario.Size = new System.Drawing.Size(130, 89);
            this.imgMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMario.TabIndex = 0;
            this.imgMario.TabStop = false;
            this.imgMario.Click += new System.EventHandler(this.imgMario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDesc2);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.imgComponent);
            this.Controls.Add(this.btnOutputPeripheral);
            this.Controls.Add(this.btnInputPeripheral);
            this.Controls.Add(this.btnPowerSupply);
            this.Controls.Add(this.btnSSD);
            this.Controls.Add(this.btnRAM);
            this.Controls.Add(this.btnCPU);
            this.Controls.Add(this.lblMarioComplaint);
            this.Controls.Add(this.btnThatKillsMario);
            this.Controls.Add(this.imgMario);
            this.Name = "Form1";
            this.Text = "Resources & Components";
            ((System.ComponentModel.ISupportInitialize)(this.imgComponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMario;
        private System.Windows.Forms.Button btnThatKillsMario;
        private System.Windows.Forms.Label lblMarioComplaint;
        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Button btnRAM;
        private System.Windows.Forms.Button btnSSD;
        private System.Windows.Forms.Button btnPowerSupply;
        private System.Windows.Forms.Button btnInputPeripheral;
        private System.Windows.Forms.Button btnOutputPeripheral;
        private System.Windows.Forms.PictureBox imgComponent;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDesc2;
    }
}

