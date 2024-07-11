namespace StudentManagement
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
            txtStName = new TextBox();
            lblStName = new Label();
            txtStSrname = new TextBox();
            lblStSurname = new Label();
            btnAddst = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtStName
            // 
            txtStName.BorderStyle = BorderStyle.FixedSingle;
            txtStName.Location = new Point(347, 66);
            txtStName.Name = "txtStName";
            txtStName.Size = new Size(125, 27);
            txtStName.TabIndex = 0;
            // 
            // lblStName
            // 
            lblStName.AutoSize = true;
            lblStName.Location = new Point(347, 43);
            lblStName.Name = "lblStName";
            lblStName.Size = new Size(100, 20);
            lblStName.TabIndex = 1;
            lblStName.Text = "StudentName";
            // 
            // txtStSrname
            // 
            txtStSrname.Location = new Point(350, 121);
            txtStSrname.Name = "txtStSrname";
            txtStSrname.Size = new Size(125, 27);
            txtStSrname.TabIndex = 2;
            // 
            // lblStSurname
            // 
            lblStSurname.AutoSize = true;
            lblStSurname.Location = new Point(348, 98);
            lblStSurname.Name = "lblStSurname";
            lblStSurname.Size = new Size(118, 20);
            lblStSurname.TabIndex = 3;
            lblStSurname.Text = "StudentSurname";
            // 
            // btnAddst
            // 
            btnAddst.Location = new Point(350, 160);
            btnAddst.Name = "btnAddst";
            btnAddst.Size = new Size(94, 29);
            btnAddst.TabIndex = 4;
            btnAddst.Text = "Add";
            btnAddst.UseVisualStyleBackColor = true;
            btnAddst.Click += btnAddst_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(350, 201);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(756, 429);
            Controls.Add(lblResult);
            Controls.Add(btnAddst);
            Controls.Add(lblStSurname);
            Controls.Add(txtStSrname);
            Controls.Add(lblStName);
            Controls.Add(txtStName);
            ForeColor = Color.MidnightBlue;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStName;
        private Label lblStName;
        private TextBox txtStSrname;
        private Label lblStSurname;
        private Button btnAddst;
        private Label lblResult;
    }
}