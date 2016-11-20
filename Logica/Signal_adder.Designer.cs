namespace Logica
{
    partial class Signal_adder
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
            this.Name_Field = new System.Windows.Forms.TextBox();
            this.MSB_Field = new System.Windows.Forms.TextBox();
            this.LSB_Field = new System.Windows.Forms.TextBox();
            this.Weight_Field = new System.Windows.Forms.TextBox();
            this.Min_Field = new System.Windows.Forms.TextBox();
            this.Max_Field = new System.Windows.Forms.TextBox();
            this.Values_Field = new System.Windows.Forms.TextBox();
            this.TYPE_Field = new System.Windows.Forms.ComboBox();
            this.ADD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_Field
            // 
            this.Name_Field.Location = new System.Drawing.Point(12, 12);
            this.Name_Field.Name = "Name_Field";
            this.Name_Field.Size = new System.Drawing.Size(237, 20);
            this.Name_Field.TabIndex = 0;
            this.Name_Field.Text = "Signal_Name";
            // 
            // MSB_Field
            // 
            this.MSB_Field.Enabled = false;
            this.MSB_Field.Location = new System.Drawing.Point(12, 65);
            this.MSB_Field.Name = "MSB_Field";
            this.MSB_Field.Size = new System.Drawing.Size(237, 20);
            this.MSB_Field.TabIndex = 1;
            this.MSB_Field.Visible = false;
            // 
            // LSB_Field
            // 
            this.LSB_Field.Enabled = false;
            this.LSB_Field.Location = new System.Drawing.Point(12, 91);
            this.LSB_Field.Name = "LSB_Field";
            this.LSB_Field.Size = new System.Drawing.Size(237, 20);
            this.LSB_Field.TabIndex = 2;
            this.LSB_Field.Visible = false;
            // 
            // Weight_Field
            // 
            this.Weight_Field.Enabled = false;
            this.Weight_Field.Location = new System.Drawing.Point(12, 117);
            this.Weight_Field.Name = "Weight_Field";
            this.Weight_Field.Size = new System.Drawing.Size(237, 20);
            this.Weight_Field.TabIndex = 3;
            this.Weight_Field.Visible = false;
            // 
            // Min_Field
            // 
            this.Min_Field.Enabled = false;
            this.Min_Field.Location = new System.Drawing.Point(12, 143);
            this.Min_Field.Name = "Min_Field";
            this.Min_Field.Size = new System.Drawing.Size(237, 20);
            this.Min_Field.TabIndex = 4;
            this.Min_Field.Visible = false;
            // 
            // Max_Field
            // 
            this.Max_Field.Enabled = false;
            this.Max_Field.Location = new System.Drawing.Point(12, 169);
            this.Max_Field.Name = "Max_Field";
            this.Max_Field.Size = new System.Drawing.Size(237, 20);
            this.Max_Field.TabIndex = 5;
            this.Max_Field.Visible = false;
            // 
            // Values_Field
            // 
            this.Values_Field.Enabled = false;
            this.Values_Field.Location = new System.Drawing.Point(12, 195);
            this.Values_Field.Name = "Values_Field";
            this.Values_Field.Size = new System.Drawing.Size(237, 20);
            this.Values_Field.TabIndex = 6;
            this.Values_Field.Visible = false;
            // 
            // TYPE_Field
            // 
            this.TYPE_Field.FormattingEnabled = true;
            this.TYPE_Field.Items.AddRange(new object[] {
            "BOOL",
            "INT",
            "REAL",
            "RANGE",
            "ENUM"});
            this.TYPE_Field.Location = new System.Drawing.Point(12, 38);
            this.TYPE_Field.Name = "TYPE_Field";
            this.TYPE_Field.Size = new System.Drawing.Size(237, 21);
            this.TYPE_Field.TabIndex = 7;
            this.TYPE_Field.SelectedIndexChanged += new System.EventHandler(this.TYPE_Field_SelectedIndexChanged);
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(105, 221);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 8;
            this.ADD.Text = "Add";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // Signal_adder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 253);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.TYPE_Field);
            this.Controls.Add(this.Values_Field);
            this.Controls.Add(this.Max_Field);
            this.Controls.Add(this.Min_Field);
            this.Controls.Add(this.Weight_Field);
            this.Controls.Add(this.LSB_Field);
            this.Controls.Add(this.MSB_Field);
            this.Controls.Add(this.Name_Field);
            this.Name = "Signal_adder";
            this.Text = "Signal_adder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_Field;
        private System.Windows.Forms.TextBox MSB_Field;
        private System.Windows.Forms.TextBox LSB_Field;
        private System.Windows.Forms.TextBox Weight_Field;
        private System.Windows.Forms.TextBox Min_Field;
        private System.Windows.Forms.TextBox Max_Field;
        private System.Windows.Forms.TextBox Values_Field;
        private System.Windows.Forms.ComboBox TYPE_Field;
        private System.Windows.Forms.Button ADD;
    }
}