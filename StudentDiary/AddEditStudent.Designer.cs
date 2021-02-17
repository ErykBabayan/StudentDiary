
namespace StudentDiary
{
    partial class AddEditStudent
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
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbMath = new System.Windows.Forms.Label();
            this.tbMathematic = new System.Windows.Forms.TextBox();
            this.lbTechnology = new System.Windows.Forms.Label();
            this.tbTechnology = new System.Windows.Forms.TextBox();
            this.lbPhysic = new System.Windows.Forms.Label();
            this.tbPhysic = new System.Windows.Forms.TextBox();
            this.lbPolishLang = new System.Windows.Forms.Label();
            this.tbPolishLang = new System.Windows.Forms.TextBox();
            this.lbForeignLang = new System.Windows.Forms.Label();
            this.tbForeignLang = new System.Windows.Forms.TextBox();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.lbComments = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbAdditionalClasses = new System.Windows.Forms.CheckBox();
            this.cbxStudentClass = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(12, 33);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(21, 13);
            this.lbId.TabIndex = 8;
            this.lbId.Text = "ID:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(117, 30);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(218, 20);
            this.tbId.TabIndex = 7;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(12, 59);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(29, 13);
            this.lbFirstName.TabIndex = 10;
            this.lbFirstName.Text = "Imie:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(117, 56);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(218, 20);
            this.tbFirstName.TabIndex = 9;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(12, 85);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(56, 13);
            this.lbLastName.TabIndex = 12;
            this.lbLastName.Text = "Nazwisko:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(117, 82);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(218, 20);
            this.tbLastName.TabIndex = 11;
            // 
            // lbMath
            // 
            this.lbMath.AutoSize = true;
            this.lbMath.Location = new System.Drawing.Point(12, 111);
            this.lbMath.Name = "lbMath";
            this.lbMath.Size = new System.Drawing.Size(68, 13);
            this.lbMath.TabIndex = 14;
            this.lbMath.Text = "Matematyka:";
            // 
            // tbMathematic
            // 
            this.tbMathematic.Location = new System.Drawing.Point(117, 108);
            this.tbMathematic.Name = "tbMathematic";
            this.tbMathematic.Size = new System.Drawing.Size(218, 20);
            this.tbMathematic.TabIndex = 13;
            // 
            // lbTechnology
            // 
            this.lbTechnology.AutoSize = true;
            this.lbTechnology.Location = new System.Drawing.Point(12, 137);
            this.lbTechnology.Name = "lbTechnology";
            this.lbTechnology.Size = new System.Drawing.Size(69, 13);
            this.lbTechnology.TabIndex = 16;
            this.lbTechnology.Text = "Technologia:";
            // 
            // tbTechnology
            // 
            this.tbTechnology.Location = new System.Drawing.Point(117, 134);
            this.tbTechnology.Name = "tbTechnology";
            this.tbTechnology.Size = new System.Drawing.Size(218, 20);
            this.tbTechnology.TabIndex = 15;
            // 
            // lbPhysic
            // 
            this.lbPhysic.AutoSize = true;
            this.lbPhysic.Location = new System.Drawing.Point(12, 163);
            this.lbPhysic.Name = "lbPhysic";
            this.lbPhysic.Size = new System.Drawing.Size(43, 13);
            this.lbPhysic.TabIndex = 18;
            this.lbPhysic.Text = "Fizyka: ";
            // 
            // tbPhysic
            // 
            this.tbPhysic.Location = new System.Drawing.Point(117, 160);
            this.tbPhysic.Name = "tbPhysic";
            this.tbPhysic.Size = new System.Drawing.Size(218, 20);
            this.tbPhysic.TabIndex = 17;
            // 
            // lbPolishLang
            // 
            this.lbPolishLang.AutoSize = true;
            this.lbPolishLang.Location = new System.Drawing.Point(12, 189);
            this.lbPolishLang.Name = "lbPolishLang";
            this.lbPolishLang.Size = new System.Drawing.Size(71, 13);
            this.lbPolishLang.TabIndex = 20;
            this.lbPolishLang.Text = "Język Polski: ";
            // 
            // tbPolishLang
            // 
            this.tbPolishLang.Location = new System.Drawing.Point(117, 186);
            this.tbPolishLang.Name = "tbPolishLang";
            this.tbPolishLang.Size = new System.Drawing.Size(218, 20);
            this.tbPolishLang.TabIndex = 19;
            // 
            // lbForeignLang
            // 
            this.lbForeignLang.AutoSize = true;
            this.lbForeignLang.Location = new System.Drawing.Point(12, 215);
            this.lbForeignLang.Name = "lbForeignLang";
            this.lbForeignLang.Size = new System.Drawing.Size(68, 13);
            this.lbForeignLang.TabIndex = 22;
            this.lbForeignLang.Text = "Język Obcy: ";
            // 
            // tbForeignLang
            // 
            this.tbForeignLang.Location = new System.Drawing.Point(117, 212);
            this.tbForeignLang.Name = "tbForeignLang";
            this.tbForeignLang.Size = new System.Drawing.Size(218, 20);
            this.tbForeignLang.TabIndex = 21;
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(117, 238);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(218, 60);
            this.rtbComments.TabIndex = 23;
            this.rtbComments.Text = "";
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(12, 241);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(40, 13);
            this.lbComments.TabIndex = 24;
            this.lbComments.Text = "Uwagi:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(260, 407);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(117, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbAdditionalClasses
            // 
            this.cbAdditionalClasses.AutoSize = true;
            this.cbAdditionalClasses.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbAdditionalClasses.Location = new System.Drawing.Point(15, 322);
            this.cbAdditionalClasses.Name = "cbAdditionalClasses";
            this.cbAdditionalClasses.Size = new System.Drawing.Size(117, 17);
            this.cbAdditionalClasses.TabIndex = 27;
            this.cbAdditionalClasses.Text = "Zajęcia dodatkowe";
            this.cbAdditionalClasses.UseVisualStyleBackColor = true;
            // 
            // cbxStudentClass
            // 
            this.cbxStudentClass.FormattingEnabled = true;
            this.cbxStudentClass.Items.AddRange(new object[] {
            "Klasa",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbxStudentClass.Location = new System.Drawing.Point(13, 366);
            this.cbxStudentClass.Name = "cbxStudentClass";
            this.cbxStudentClass.Size = new System.Drawing.Size(67, 21);
            this.cbxStudentClass.TabIndex = 28;
            this.cbxStudentClass.Text = "Klasa";
            this.cbxStudentClass.SelectedIndexChanged += new System.EventHandler(this.cbxStudentClass_SelectedIndexChanged);
            // 
            // AddEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(349, 511);
            this.Controls.Add(this.cbxStudentClass);
            this.Controls.Add(this.cbAdditionalClasses);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.lbForeignLang);
            this.Controls.Add(this.tbForeignLang);
            this.Controls.Add(this.lbPolishLang);
            this.Controls.Add(this.tbPolishLang);
            this.Controls.Add(this.lbPhysic);
            this.Controls.Add(this.tbPhysic);
            this.Controls.Add(this.lbTechnology);
            this.Controls.Add(this.tbTechnology);
            this.Controls.Add(this.lbMath);
            this.Controls.Add(this.tbMathematic);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbId);
            this.MaximumSize = new System.Drawing.Size(400, 550);
            this.MinimumSize = new System.Drawing.Size(360, 466);
            this.Name = "AddEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodawanie ucznia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbMath;
        private System.Windows.Forms.TextBox tbMathematic;
        private System.Windows.Forms.Label lbTechnology;
        private System.Windows.Forms.TextBox tbTechnology;
        private System.Windows.Forms.Label lbPhysic;
        private System.Windows.Forms.TextBox tbPhysic;
        private System.Windows.Forms.Label lbPolishLang;
        private System.Windows.Forms.TextBox tbPolishLang;
        private System.Windows.Forms.Label lbForeignLang;
        private System.Windows.Forms.TextBox tbForeignLang;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbAdditionalClasses;
        private System.Windows.Forms.ComboBox cbxStudentClass;
    }
}