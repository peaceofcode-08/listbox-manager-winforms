namespace listbox.task
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            countriesListbox = new ListBox();
            addbtn = new Button();
            removesinglebtn = new Button();
            countBtn = new Button();
            clearlistBtn = new Button();
            countryTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // countriesListbox
            // 
            countriesListbox.FormattingEnabled = true;
            countriesListbox.ItemHeight = 25;
            countriesListbox.Items.AddRange(new object[] { "UK", "USA", "AUSTRALIA", "PAKISTAN", "TURKEY", "IRAN", "CHINA", "AFGHANISTAN", "SAUDIA ARABIA", "UAE", "QATAR", "SYRIA", "PALESTINE", "YEMEN" });
            countriesListbox.Location = new Point(12, 169);
            countriesListbox.Name = "countriesListbox";
            countriesListbox.SelectionMode = SelectionMode.MultiSimple;
            countriesListbox.Size = new Size(424, 379);
            countriesListbox.TabIndex = 0;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.PowderBlue;
            addbtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            addbtn.ForeColor = Color.DarkGreen;
            addbtn.Location = new Point(501, 189);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(220, 42);
            addbtn.TabIndex = 1;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // removesinglebtn
            // 
            removesinglebtn.BackColor = Color.PowderBlue;
            removesinglebtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            removesinglebtn.ForeColor = Color.DarkGreen;
            removesinglebtn.Location = new Point(501, 280);
            removesinglebtn.Name = "removesinglebtn";
            removesinglebtn.Size = new Size(220, 49);
            removesinglebtn.TabIndex = 2;
            removesinglebtn.Text = "Remove Selected";
            removesinglebtn.UseVisualStyleBackColor = false;
            removesinglebtn.Click += removesinglebtn_Click;
            // 
            // countBtn
            // 
            countBtn.BackColor = Color.PowderBlue;
            countBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            countBtn.ForeColor = Color.DarkGreen;
            countBtn.Location = new Point(501, 481);
            countBtn.Name = "countBtn";
            countBtn.Size = new Size(220, 46);
            countBtn.TabIndex = 3;
            countBtn.Text = "Count Items";
            countBtn.UseVisualStyleBackColor = false;
            countBtn.Click += countBtn_Click;
            // 
            // clearlistBtn
            // 
            clearlistBtn.BackColor = Color.PowderBlue;
            clearlistBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            clearlistBtn.ForeColor = Color.DarkGreen;
            clearlistBtn.Location = new Point(501, 387);
            clearlistBtn.Name = "clearlistBtn";
            clearlistBtn.Size = new Size(220, 44);
            clearlistBtn.TabIndex = 4;
            clearlistBtn.Text = "Clear List";
            clearlistBtn.UseVisualStyleBackColor = false;
            clearlistBtn.Click += clearlistBtn_Click;
            // 
            // countryTextbox
            // 
            countryTextbox.Location = new Point(273, 98);
            countryTextbox.Name = "countryTextbox";
            countryTextbox.Size = new Size(163, 31);
            countryTextbox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 9);
            label1.Name = "label1";
            label1.Size = new Size(518, 65);
            label1.TabIndex = 6;
            label1.Text = "Country List Manager";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(255, 32);
            label2.TabIndex = 7;
            label2.Text = "Enter Country Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(763, 597);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(countryTextbox);
            Controls.Add(clearlistBtn);
            Controls.Add(countBtn);
            Controls.Add(removesinglebtn);
            Controls.Add(addbtn);
            Controls.Add(countriesListbox);
            Name = "Form1";
            Text = "Country List Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox countriesListbox;
        private Button addbtn;
        private Button removesinglebtn;
        private Button countBtn;
        private Button clearlistBtn;
        private TextBox countryTextbox;
        private Label label1;
        private Label label2;
    }
}
