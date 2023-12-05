namespace WinFormsApp
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            test_button = new Button();
            spInfo = new TextBox();
            label4 = new Label();
            clientSecret = new TextBox();
            clientId = new TextBox();
            baseAddr = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            clear_button = new Button();
            PostalCode = new TextBox();
            Prov = new TextBox();
            City = new TextBox();
            StreetAddr = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            SearchCtrl = new ComboBox();
            label5 = new Label();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 37);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(675, 431);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(test_button);
            tabPage1.Controls.Add(spInfo);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(clientSecret);
            tabPage1.Controls.Add(clientId);
            tabPage1.Controls.Add(baseAddr);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(667, 403);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Connection";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // test_button
            // 
            test_button.Location = new Point(104, 361);
            test_button.Margin = new Padding(2);
            test_button.Name = "test_button";
            test_button.Size = new Size(114, 31);
            test_button.TabIndex = 6;
            test_button.Text = "Test Connection";
            test_button.UseVisualStyleBackColor = true;
            test_button.Click += button1_Click;
            // 
            // spInfo
            // 
            spInfo.Location = new Point(104, 104);
            spInfo.Margin = new Padding(2);
            spInfo.Multiline = true;
            spInfo.Name = "spInfo";
            spInfo.ReadOnly = true;
            spInfo.Size = new Size(551, 243);
            spInfo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImageAlign = ContentAlignment.TopRight;
            label4.Location = new Point(64, 104);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 4;
            label4.Text = "Info:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // clientSecret
            // 
            clientSecret.Location = new Point(104, 74);
            clientSecret.Margin = new Padding(2);
            clientSecret.Name = "clientSecret";
            clientSecret.ReadOnly = true;
            clientSecret.Size = new Size(551, 23);
            clientSecret.TabIndex = 3;
            // 
            // clientId
            // 
            clientId.Location = new Point(104, 47);
            clientId.Margin = new Padding(2);
            clientId.Name = "clientId";
            clientId.ReadOnly = true;
            clientId.Size = new Size(551, 23);
            clientId.TabIndex = 3;
            // 
            // baseAddr
            // 
            baseAddr.Location = new Point(104, 19);
            baseAddr.Margin = new Padding(2);
            baseAddr.Name = "baseAddr";
            baseAddr.ReadOnly = true;
            baseAddr.Size = new Size(551, 23);
            baseAddr.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 77);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Secret:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 50);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Client Id:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Base Address:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(clear_button);
            tabPage2.Controls.Add(PostalCode);
            tabPage2.Controls.Add(Prov);
            tabPage2.Controls.Add(City);
            tabPage2.Controls.Add(StreetAddr);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(SearchCtrl);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(667, 403);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Typeahead";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(95, 209);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(75, 23);
            clear_button.TabIndex = 7;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.MouseClick += clear_button_MouseClick;
            // 
            // PostalCode
            // 
            PostalCode.Location = new Point(93, 163);
            PostalCode.Name = "PostalCode";
            PostalCode.Size = new Size(447, 23);
            PostalCode.TabIndex = 6;
            // 
            // Prov
            // 
            Prov.Location = new Point(93, 131);
            Prov.Name = "Prov";
            Prov.Size = new Size(447, 23);
            Prov.TabIndex = 6;
            // 
            // City
            // 
            City.Location = new Point(93, 99);
            City.Name = "City";
            City.Size = new Size(447, 23);
            City.TabIndex = 6;
            // 
            // StreetAddr
            // 
            StreetAddr.Location = new Point(93, 67);
            StreetAddr.Name = "StreetAddr";
            StreetAddr.Size = new Size(447, 23);
            StreetAddr.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ImageAlign = ContentAlignment.TopRight;
            label9.Location = new Point(15, 166);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 5;
            label9.Text = "Postal Code:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ImageAlign = ContentAlignment.TopRight;
            label8.Location = new Point(53, 134);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 4;
            label8.Text = "Prov:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ImageAlign = ContentAlignment.TopRight;
            label7.Location = new Point(56, 102);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 3;
            label7.Text = "City:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ImageAlign = ContentAlignment.TopRight;
            label6.Location = new Point(19, 70);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 2;
            label6.Text = "Street Addr:";
            // 
            // SearchCtrl
            // 
            SearchCtrl.FormattingEnabled = true;
            SearchCtrl.Location = new Point(94, 24);
            SearchCtrl.Name = "SearchCtrl";
            SearchCtrl.Size = new Size(446, 23);
            SearchCtrl.TabIndex = 1;
            SearchCtrl.SelectionChangeCommitted += SearchCtrl_SelectionChangeCommitted;
            SearchCtrl.TextUpdate += SearchCtrl_TextUpdate;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImageAlign = ContentAlignment.TopRight;
            label5.Location = new Point(43, 27);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 0;
            label5.Text = "Search:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(6, 8);
            label10.Name = "label10";
            label10.Size = new Size(376, 21);
            label10.TabIndex = 1;
            label10.Text = "StreetPerfect C# HTTP Client WinForms Example";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 463);
            Controls.Add(label10);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Resize += Form1_Resize;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox spInfo;
        private Label label4;
        private TextBox clientSecret;
        private TextBox clientId;
        private TextBox baseAddr;
        private Label label3;
        private Label label2;
        private Button test_button;
        private Label label5;
        private Label label6;
        private ComboBox SearchCtrl;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox PostalCode;
        private TextBox Prov;
        private TextBox City;
        private TextBox StreetAddr;
        private Button clear_button;
        private Label label10;
    }
}
