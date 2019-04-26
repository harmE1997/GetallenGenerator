namespace GetallenGenerator
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
            this.nudmin = new System.Windows.Forms.NumericUpDown();
            this.lblmax = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.nudmax = new System.Windows.Forms.NumericUpDown();
            this.btngenerate = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.lblNumber = new System.Windows.Forms.Label();
            this.cbDoubles = new System.Windows.Forms.CheckBox();
            this.cbSort = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // nudmin
            // 
            this.nudmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudmin.Location = new System.Drawing.Point(144, 17);
            this.nudmin.Margin = new System.Windows.Forms.Padding(4);
            this.nudmin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudmin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudmin.Name = "nudmin";
            this.nudmin.Size = new System.Drawing.Size(168, 23);
            this.nudmin.TabIndex = 12;
            this.nudmin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.BackColor = System.Drawing.Color.Transparent;
            this.lblmax.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmax.Location = new System.Drawing.Point(58, 53);
            this.lblmax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(74, 18);
            this.lblmax.TabIndex = 11;
            this.lblmax.Text = "Maximum:";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.BackColor = System.Drawing.Color.Transparent;
            this.lblmin.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmin.Location = new System.Drawing.Point(60, 19);
            this.lblmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(72, 18);
            this.lblmin.TabIndex = 10;
            this.lblmin.Text = "Minimum:";
            // 
            // nudmax
            // 
            this.nudmax.Location = new System.Drawing.Point(144, 52);
            this.nudmax.Margin = new System.Windows.Forms.Padding(4);
            this.nudmax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudmax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudmax.Name = "nudmax";
            this.nudmax.Size = new System.Drawing.Size(168, 22);
            this.nudmax.TabIndex = 8;
            this.nudmax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.SystemColors.Control;
            this.btngenerate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerate.Location = new System.Drawing.Point(61, 156);
            this.btngenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(248, 37);
            this.btngenerate.TabIndex = 7;
            this.btngenerate.Text = "Generen";
            this.btngenerate.UseVisualStyleBackColor = false;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click_1);
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 16;
            this.lbOutput.Location = new System.Drawing.Point(13, 201);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(335, 196);
            this.lbOutput.TabIndex = 13;
            // 
            // nudNumber
            // 
            this.nudNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumber.Location = new System.Drawing.Point(144, 84);
            this.nudNumber.Margin = new System.Windows.Forms.Padding(4);
            this.nudNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(168, 23);
            this.nudNumber.TabIndex = 15;
            this.nudNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumber.Location = new System.Drawing.Point(69, 86);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(52, 18);
            this.lblNumber.TabIndex = 16;
            this.lblNumber.Text = "Aantal:";
            // 
            // cbDoubles
            // 
            this.cbDoubles.AutoSize = true;
            this.cbDoubles.Location = new System.Drawing.Point(13, 128);
            this.cbDoubles.Name = "cbDoubles";
            this.cbDoubles.Size = new System.Drawing.Size(201, 21);
            this.cbDoubles.TabIndex = 17;
            this.cbDoubles.Text = "Dubbele getallen Toestaan";
            this.cbDoubles.UseVisualStyleBackColor = true;
            // 
            // cbSort
            // 
            this.cbSort.AutoSize = true;
            this.cbSort.Location = new System.Drawing.Point(222, 128);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(134, 21);
            this.cbSort.TabIndex = 18;
            this.cbSort.Text = "Sorteer Getallen";
            this.cbSort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(368, 410);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.cbDoubles);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.nudmin);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.nudmax);
            this.Controls.Add(this.btngenerate);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Getallengenerator";
            ((System.ComponentModel.ISupportInitialize)(this.nudmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudmin;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.NumericUpDown nudmax;
        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.CheckBox cbDoubles;
        private System.Windows.Forms.CheckBox cbSort;
    }
}

