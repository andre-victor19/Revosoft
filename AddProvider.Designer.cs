namespace WindowsFormsApp1
{
    partial class AddProvider
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRegistrationSituation = new System.Windows.Forms.Label();
            this.comboRegistration = new System.Windows.Forms.ComboBox();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.dateOpenDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(11, 12);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(103, 20);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Razão Social";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(122, 12);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(442, 20);
            this.txtCompanyName.TabIndex = 1;
            this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(66, 48);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(159, 20);
            this.txtCnpj.TabIndex = 3;
            this.txtCnpj.TextChanged += new System.EventHandler(this.txtCnpj_TextChanged);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(11, 48);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(49, 20);
            this.lblCnpj.TabIndex = 2;
            this.lblCnpj.Text = "CNPJ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(310, 48);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(255, 48);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblRegistrationSituation
            // 
            this.lblRegistrationSituation.AutoSize = true;
            this.lblRegistrationSituation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationSituation.Location = new System.Drawing.Point(11, 82);
            this.lblRegistrationSituation.Name = "lblRegistrationSituation";
            this.lblRegistrationSituation.Size = new System.Drawing.Size(144, 20);
            this.lblRegistrationSituation.TabIndex = 6;
            this.lblRegistrationSituation.Text = "Situação Cadastral";
            // 
            // comboRegistration
            // 
            this.comboRegistration.FormattingEnabled = true;
            this.comboRegistration.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.comboRegistration.Location = new System.Drawing.Point(163, 84);
            this.comboRegistration.Name = "comboRegistration";
            this.comboRegistration.Size = new System.Drawing.Size(121, 21);
            this.comboRegistration.TabIndex = 7;
            this.comboRegistration.SelectedIndexChanged += new System.EventHandler(this.comboRegistration_SelectedIndexChanged);
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.AutoSize = true;
            this.lblOpenDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDate.Location = new System.Drawing.Point(12, 119);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(130, 20);
            this.lblOpenDate.TabIndex = 8;
            this.lblOpenDate.Text = "Data de abertura";
            // 
            // dateOpenDate
            // 
            this.dateOpenDate.CustomFormat = "";
            this.dateOpenDate.Location = new System.Drawing.Point(148, 119);
            this.dateOpenDate.Name = "dateOpenDate";
            this.dateOpenDate.Size = new System.Drawing.Size(227, 20);
            this.dateOpenDate.TabIndex = 9;
            this.dateOpenDate.Value = new System.DateTime(2020, 11, 23, 13, 30, 54, 0);
            this.dateOpenDate.ValueChanged += new System.EventHandler(this.dateOpenDate_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(380, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 26);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(480, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 26);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 207);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateOpenDate);
            this.Controls.Add(this.lblOpenDate);
            this.Controls.Add(this.comboRegistration);
            this.Controls.Add(this.lblRegistrationSituation);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Fornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRegistrationSituation;
        private System.Windows.Forms.ComboBox comboRegistration;
        private System.Windows.Forms.Label lblOpenDate;
        private System.Windows.Forms.DateTimePicker dateOpenDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}