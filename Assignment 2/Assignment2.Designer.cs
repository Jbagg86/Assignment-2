
using System.Net.Security;

namespace Assignment_2
{
    partial class Assignment2
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
            lblMakeAndModel = new Label();
            lstMakeAndModel = new ListBox();
            lblYear = new Label();
            txtYear = new TextBox();
            lblColor = new Label();
            gbColor = new GroupBox();
            rdoWhite = new RadioButton();
            rdoBlack = new RadioButton();
            rdoBlue = new RadioButton();
            rdoRed = new RadioButton();
            lblFeatures = new Label();
            btnPurchase = new Button();
            lblPurchaseSummary = new Label();
            gbFeatures = new GroupBox();
            chkAC = new CheckBox();
            chkAutoTailgate = new CheckBox();
            chkTintedWindows = new CheckBox();
            chkBackUpCamera = new CheckBox();
            gbColor.SuspendLayout();
            gbFeatures.SuspendLayout();
            SuspendLayout();
            // 
            // lblMakeAndModel
            // 
            lblMakeAndModel.AutoSize = true;
            lblMakeAndModel.Location = new Point(52, 36);
            lblMakeAndModel.Name = "lblMakeAndModel";
            lblMakeAndModel.Size = new Size(96, 15);
            lblMakeAndModel.TabIndex = 0;
            lblMakeAndModel.Text = "&Make and Model";
            // 
            // lstMakeAndModel
            // 
            lstMakeAndModel.FormattingEnabled = true;
            lstMakeAndModel.ItemHeight = 15;
            lstMakeAndModel.Items.AddRange(new object[] { "Dodge Ram", "Ford Ranger", "Chevy Silverado", "GMC Denali" });
            lstMakeAndModel.Location = new Point(52, 54);
            lstMakeAndModel.Name = "lstMakeAndModel";
            lstMakeAndModel.Size = new Size(104, 94);
            lstMakeAndModel.TabIndex = 1;
            lstMakeAndModel.SelectedIndexChanged += listMakeandModel_SelectedIndexChanged;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(207, 36);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.TabIndex = 2;
            lblYear.Text = "&Year";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(207, 54);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 3;
            txtYear.TextChanged += textBox1_TextChanged;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(360, 41);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(36, 15);
            lblColor.TabIndex = 4;
            lblColor.Text = "&Color";
            lblColor.Click += label1_Click;
            // 
            // gbColor
            // 
            gbColor.Controls.Add(rdoWhite);
            gbColor.Controls.Add(rdoBlack);
            gbColor.Controls.Add(rdoBlue);
            gbColor.Controls.Add(rdoRed);
            gbColor.Location = new Point(360, 54);
            gbColor.Name = "gbColor";
            gbColor.Size = new Size(109, 129);
            gbColor.TabIndex = 5;
            gbColor.TabStop = false;
            gbColor.Enter += groupBoxColor_Enter;
            // 
            // rdoWhite
            // 
            rdoWhite.AutoSize = true;
            rdoWhite.Location = new Point(3, 95);
            rdoWhite.Name = "rdoWhite";
            rdoWhite.Size = new Size(56, 19);
            rdoWhite.TabIndex = 3;
            rdoWhite.TabStop = true;
            rdoWhite.Text = "White";
            rdoWhite.UseVisualStyleBackColor = true;
            rdoWhite.CheckedChanged += rdoWhite_CheckedChanged;
            // 
            // rdoBlack
            // 
            rdoBlack.AutoSize = true;
            rdoBlack.Location = new Point(3, 70);
            rdoBlack.Name = "rdoBlack";
            rdoBlack.Size = new Size(53, 19);
            rdoBlack.TabIndex = 2;
            rdoBlack.TabStop = true;
            rdoBlack.Text = "Black";
            rdoBlack.UseVisualStyleBackColor = true;
            rdoBlack.CheckedChanged += rdoBlack_CheckedChanged;
            // 
            // rdoBlue
            // 
            rdoBlue.AutoSize = true;
            rdoBlue.Location = new Point(3, 46);
            rdoBlue.Name = "rdoBlue";
            rdoBlue.Size = new Size(48, 19);
            rdoBlue.TabIndex = 1;
            rdoBlue.TabStop = true;
            rdoBlue.Text = "Blue";
            rdoBlue.UseVisualStyleBackColor = true;
            rdoBlue.CheckedChanged += rdoBlue_CheckedChanged;
            // 
            // rdoRed
            // 
            rdoRed.AutoSize = true;
            rdoRed.Location = new Point(3, 22);
            rdoRed.Name = "rdoRed";
            rdoRed.Size = new Size(45, 19);
            rdoRed.TabIndex = 0;
            rdoRed.TabStop = true;
            rdoRed.Text = "Red";
            rdoRed.UseVisualStyleBackColor = true;
            rdoRed.CheckedChanged += rdoRed_CheckedChanged;
            // 
            // lblFeatures
            // 
            lblFeatures.AutoSize = true;
            lblFeatures.Location = new Point(544, 42);
            lblFeatures.Name = "lblFeatures";
            lblFeatures.Size = new Size(51, 15);
            lblFeatures.TabIndex = 6;
            lblFeatures.Text = "&Features";
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(58, 275);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(75, 23);
            btnPurchase.TabIndex = 8;
            btnPurchase.Text = "&Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // lblPurchaseSummary
            // 
            lblPurchaseSummary.BorderStyle = BorderStyle.FixedSingle;
            lblPurchaseSummary.Location = new Point(207, 275);
            lblPurchaseSummary.Name = "lblPurchaseSummary";
            lblPurchaseSummary.Size = new Size(600, 80);
            lblPurchaseSummary.TabIndex = 9;
            lblPurchaseSummary.TextAlign = ContentAlignment.MiddleCenter;
            lblPurchaseSummary.Click += lblPurchaseSummary_Click;
            // 
            // gbFeatures
            // 
            gbFeatures.Controls.Add(chkAC);
            gbFeatures.Controls.Add(chkAutoTailgate);
            gbFeatures.Controls.Add(chkTintedWindows);
            gbFeatures.Controls.Add(chkBackUpCamera);
            gbFeatures.Location = new Point(544, 54);
            gbFeatures.Name = "gbFeatures";
            gbFeatures.Size = new Size(150, 120);
            gbFeatures.TabIndex = 7;
            gbFeatures.TabStop = false;
            gbFeatures.Enter += groupBoxFeatures_Enter;
            // 
            // chkAC
            // 
            chkAC.AutoSize = true;
            chkAC.Location = new Point(10, 90);
            chkAC.Name = "chkAC";
            chkAC.Size = new Size(42, 19);
            chkAC.TabIndex = 3;
            chkAC.Text = "AC";
            chkAC.UseVisualStyleBackColor = true;
            // 
            // chkAutoTailgate
            // 
            chkAutoTailgate.AutoSize = true;
            chkAutoTailgate.Location = new Point(10, 65);
            chkAutoTailgate.Name = "chkAutoTailgate";
            chkAutoTailgate.Size = new Size(95, 19);
            chkAutoTailgate.TabIndex = 2;
            chkAutoTailgate.Text = "Auto Tailgate";
            chkAutoTailgate.UseVisualStyleBackColor = true;
            // 
            // chkTintedWindows
            // 
            chkTintedWindows.AutoSize = true;
            chkTintedWindows.Location = new Point(9, 37);
            chkTintedWindows.Name = "chkTintedWindows";
            chkTintedWindows.Size = new Size(111, 19);
            chkTintedWindows.TabIndex = 1;
            chkTintedWindows.Text = "Tinted Windows";
            chkTintedWindows.UseVisualStyleBackColor = true;
            // 
            // chkBackUpCamera
            // 
            chkBackUpCamera.AutoSize = true;
            chkBackUpCamera.Location = new Point(9, 12);
            chkBackUpCamera.Name = "chkBackUpCamera";
            chkBackUpCamera.Size = new Size(115, 19);
            chkBackUpCamera.TabIndex = 0;
            chkBackUpCamera.Text = "Back-Up Camera";
            chkBackUpCamera.UseVisualStyleBackColor = true;
            // 
            // Assignment2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 533);
            Controls.Add(gbFeatures);
            Controls.Add(lblPurchaseSummary);
            Controls.Add(btnPurchase);
            Controls.Add(lblFeatures);
            Controls.Add(gbColor);
            Controls.Add(lblColor);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(lstMakeAndModel);
            Controls.Add(lblMakeAndModel);
            Name = "Assignment2";
            Text = "Assignment 2";
            Load += Assignment2_Load;
            gbColor.ResumeLayout(false);
            gbColor.PerformLayout();
            gbFeatures.ResumeLayout(false);
            gbFeatures.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Assignment2_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Label lblMakeAndModel;
        private ListBox lstMakeAndModel;
        private Label lblYear;
        private TextBox txtYear;
        private Label lblColor;
        private GroupBox gbColor;
        private RadioButton rdoWhite;
        private RadioButton rdoBlack;
        private RadioButton rdoBlue;
        private RadioButton rdoRed;
        private Label lblFeatures;
        private Button btnPurchase;
        private Label lblPurchaseSummary;
        private GroupBox gbFeatures;
        private CheckBox chkAC;
        private CheckBox chkAutoTailgate;
        private CheckBox chkTintedWindows;
        private CheckBox chkBackUpCamera;
    }
}
