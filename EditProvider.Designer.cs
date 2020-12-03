namespace WindowsFormsApp1
{
    partial class EditProvider
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
            this.txtIdProvider = new System.Windows.Forms.TextBox();
            this.lblIdProvider = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.comboRegistration = new System.Windows.Forms.ComboBox();
            this.lblRegistrationSituation = new System.Windows.Forms.Label();
            this.dateOpenDate = new System.Windows.Forms.DateTimePicker();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdProvider
            // 
            this.txtIdProvider.Enabled = false;
            this.txtIdProvider.Location = new System.Drawing.Point(63, 12);
            this.txtIdProvider.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProvider.Name = "txtIdProvider";
            this.txtIdProvider.Size = new System.Drawing.Size(97, 22);
            this.txtIdProvider.TabIndex = 3;
            // 
            // lblIdProvider
            // 
            this.lblIdProvider.AutoSize = true;
            this.lblIdProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProvider.Location = new System.Drawing.Point(13, 9);
            this.lblIdProvider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProvider.Name = "lblIdProvider";
            this.lblIdProvider.Size = new System.Drawing.Size(42, 25);
            this.lblIdProvider.TabIndex = 2;
            this.lblIdProvider.Text = "#ID";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(313, 13);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(446, 22);
            this.txtCompanyName.TabIndex = 5;
            this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(178, 9);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(127, 25);
            this.lblCompanyName.TabIndex = 4;
            this.lblCompanyName.Text = "Razão Social";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(86, 58);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(4);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(211, 22);
            this.txtCnpj.TabIndex = 7;
            this.txtCnpj.TextChanged += new System.EventHandler(this.txtCnpj_TextChanged);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(13, 54);
            this.lblCnpj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(65, 25);
            this.lblCnpj.TabIndex = 6;
            this.lblCnpj.Text = "CNPJ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(394, 58);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(337, 22);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(326, 54);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // comboRegistration
            // 
            this.comboRegistration.FormattingEnabled = true;
            this.comboRegistration.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.comboRegistration.Location = new System.Drawing.Point(215, 103);
            this.comboRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.comboRegistration.Name = "comboRegistration";
            this.comboRegistration.Size = new System.Drawing.Size(160, 24);
            this.comboRegistration.TabIndex = 11;
            this.comboRegistration.SelectedIndexChanged += new System.EventHandler(this.comboRegistration_SelectedIndexChanged);
            // 
            // lblRegistrationSituation
            // 
            this.lblRegistrationSituation.AutoSize = true;
            this.lblRegistrationSituation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationSituation.Location = new System.Drawing.Point(13, 101);
            this.lblRegistrationSituation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrationSituation.Name = "lblRegistrationSituation";
            this.lblRegistrationSituation.Size = new System.Drawing.Size(178, 25);
            this.lblRegistrationSituation.TabIndex = 10;
            this.lblRegistrationSituation.Text = "Situação Cadastral";
            // 
            // dateOpenDate
            // 
            this.dateOpenDate.CustomFormat = "";
            this.dateOpenDate.Location = new System.Drawing.Point(194, 148);
            this.dateOpenDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateOpenDate.Name = "dateOpenDate";
            this.dateOpenDate.Size = new System.Drawing.Size(301, 22);
            this.dateOpenDate.TabIndex = 13;
            this.dateOpenDate.Value = new System.DateTime(2020, 12, 3, 0, 0, 0, 0);
            this.dateOpenDate.ValueChanged += new System.EventHandler(this.dateOpenDate_ValueChanged);
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.AutoSize = true;
            this.lblOpenDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDate.Location = new System.Drawing.Point(13, 148);
            this.lblOpenDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(157, 25);
            this.lblOpenDate.TabIndex = 12;
            this.lblOpenDate.Text = "Data de abertura";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(647, 211);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 32);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Atualizar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(514, 211);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 32);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 260);
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
            this.Controls.Add(this.txtIdProvider);
            this.Controls.Add(this.lblIdProvider);
            this.MaximizeBox = false;
            this.Name = "EditProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditProvider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdProvider;
        private System.Windows.Forms.Label lblIdProvider;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox comboRegistration;
        private System.Windows.Forms.Label lblRegistrationSituation;
        private System.Windows.Forms.DateTimePicker dateOpenDate;
        private System.Windows.Forms.Label lblOpenDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}