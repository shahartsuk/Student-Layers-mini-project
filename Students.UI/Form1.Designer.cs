namespace Students.UI
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
            this.components = new System.ComponentModel.Container();
            this.textName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.buttonIniDB = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.getStudentbutton = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(152, 68);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(152, 136);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 20);
            this.textAddress.TabIndex = 2;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(152, 218);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 20);
            this.textAge.TabIndex = 3;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(152, 298);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(80, 75);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(80, 143);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(80, 305);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(18, 13);
            this.LabelID.TabIndex = 8;
            this.LabelID.Text = "ID";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(80, 225);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(26, 13);
            this.AgeLabel.TabIndex = 9;
            this.AgeLabel.Text = "Age";
            // 
            // buttonIniDB
            // 
            this.buttonIniDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttonIniDB.Location = new System.Drawing.Point(490, 53);
            this.buttonIniDB.Name = "buttonIniDB";
            this.buttonIniDB.Size = new System.Drawing.Size(111, 43);
            this.buttonIniDB.TabIndex = 10;
            this.buttonIniDB.Text = "Initainlize DB";
            this.buttonIniDB.UseVisualStyleBackColor = true;
            this.buttonIniDB.Click += new System.EventHandler(this.buttonIniDB_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.addStudentButton.Location = new System.Drawing.Point(490, 162);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(111, 46);
            this.addStudentButton.TabIndex = 11;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // getStudentbutton
            // 
            this.getStudentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.getStudentbutton.Location = new System.Drawing.Point(490, 276);
            this.getStudentbutton.Name = "getStudentbutton";
            this.getStudentbutton.Size = new System.Drawing.Size(133, 52);
            this.getStudentbutton.TabIndex = 12;
            this.getStudentbutton.Text = "Get student by id";
            this.getStudentbutton.UseVisualStyleBackColor = true;
            this.getStudentbutton.Click += new System.EventHandler(this.getStudentbutton_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttonClear.Location = new System.Drawing.Point(490, 365);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(111, 49);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear Text";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.getStudentbutton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.buttonIniDB);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textName);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Button buttonIniDB;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button getStudentbutton;
        private System.Windows.Forms.Button buttonClear;
    }
}

