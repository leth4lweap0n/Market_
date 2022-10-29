namespace Market.LogIn
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.IDLabel = new DevExpress.XtraEditors.LabelControl();
            this.PasswordLabel = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxID = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxPassword = new DevExpress.XtraEditors.TextEdit();
            this.ButtonLogIn = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonAddUser = new DevExpress.XtraEditors.SimpleButton();
            this.MySvgImageCollection = new DevExpress.Utils.SvgImageCollection(this.components);
            this.SeeThePassword = new DevExpress.XtraEditors.SvgImageBox();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MySvgImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeeThePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.Location = new System.Drawing.Point(114, 148);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(55, 13);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "Kullanıcı Adı";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(114, 179);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(69, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Kullanıcı Şifresi";
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(207, 145);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(183, 20);
            this.TextBoxID.TabIndex = 3;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(207, 176);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Properties.UseSystemPasswordChar = true;
            this.TextBoxPassword.Size = new System.Drawing.Size(183, 20);
            this.TextBoxPassword.TabIndex = 4;
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.Location = new System.Drawing.Point(230, 239);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(139, 23);
            this.ButtonLogIn.TabIndex = 5;
            this.ButtonLogIn.Text = "Giriş Yap";
            this.ButtonLogIn.Click += new System.EventHandler(this.ButtonLogIn_Click);
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.Location = new System.Drawing.Point(230, 268);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(139, 23);
            this.ButtonAddUser.TabIndex = 6;
            this.ButtonAddUser.Text = "#Debug/AddUser";
            this.ButtonAddUser.Visible = false;
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // MySvgImageCollection
            // 
            this.MySvgImageCollection.Add("security_visibility", "image://svgimages/icon builder/security_visibility.svg");
            this.MySvgImageCollection.Add("security_visibilityoff", "image://svgimages/icon builder/security_visibilityoff.svg");
            // 
            // SeeThePassword
            // 
            this.SeeThePassword.Location = new System.Drawing.Point(395, 174);
            this.SeeThePassword.Name = "SeeThePassword";
            this.SeeThePassword.Size = new System.Drawing.Size(38, 22);
            this.SeeThePassword.TabIndex = 7;
            this.SeeThePassword.Text = "svgImageBox1";
            this.SeeThePassword.MouseCaptureChanged += new System.EventHandler(this.SeeThePassword_MouseCaptureChanged);
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(239, 3);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(120, 120);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 8;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 318);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.SeeThePassword);
            this.Controls.Add(this.ButtonAddUser);
            this.Controls.Add(this.ButtonLogIn);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.IDLabel);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LogIn.IconOptions.SvgImage")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MySvgImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeeThePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl IDLabel;
        private DevExpress.XtraEditors.LabelControl PasswordLabel;
        private DevExpress.XtraEditors.TextEdit TextBoxID;
        private DevExpress.XtraEditors.TextEdit TextBoxPassword;
        private DevExpress.XtraEditors.SimpleButton ButtonLogIn;
        private DevExpress.XtraEditors.SimpleButton ButtonAddUser;
        private DevExpress.Utils.SvgImageCollection MySvgImageCollection;
        private DevExpress.XtraEditors.SvgImageBox SeeThePassword;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
    }
}