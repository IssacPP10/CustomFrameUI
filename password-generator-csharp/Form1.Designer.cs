namespace password_generator_csharp
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
            components = new System.ComponentModel.Container();
            panelTitleBar = new Panel();
            btnMin = new FontAwesome.Sharp.IconButton();
            lbLogo = new Label();
            btnMax = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            panelMenu = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label1 = new Label();
            panelDesktop = new Panel();
            lbFecha = new Label();
            lbHora = new Label();
            cbTheme = new ReaLTaiizor.Controls.DungeonComboBox();
            horaFecha = new System.Windows.Forms.Timer(components);
            panelTitleBar.SuspendLayout();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(186, 54, 85);
            panelTitleBar.Controls.Add(btnMin);
            panelTitleBar.Controls.Add(lbLogo);
            panelTitleBar.Controls.Add(btnMax);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1111, 46);
            panelTitleBar.TabIndex = 0;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnMin.IconColor = Color.White;
            btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMin.IconSize = 25;
            btnMin.Location = new Point(920, 0);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(65, 39);
            btnMin.TabIndex = 5;
            btnMin.TabStop = false;
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // lbLogo
            // 
            lbLogo.AutoSize = true;
            lbLogo.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lbLogo.ForeColor = Color.White;
            lbLogo.Location = new Point(35, 10);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(139, 22);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Pass Manager";
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            btnMax.IconColor = Color.White;
            btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMax.IconSize = 25;
            btnMax.Location = new Point(984, 0);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(65, 39);
            btnMax.TabIndex = 4;
            btnMax.TabStop = false;
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Remove;
            btnClose.IconColor = Color.White;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 25;
            btnClose.Location = new Point(1048, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(65, 39);
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(186, 54, 85);
            panelMenu.Controls.Add(iconButton3);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 696);
            panelMenu.TabIndex = 1;
            // 
            // iconButton3
            // 
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Info;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 25;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 279);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(15, 0, 0, 0);
            iconButton3.Size = new Size(230, 45);
            iconButton3.TabIndex = 7;
            iconButton3.Text = "   Acerca de";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.SquareGitlab;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 25;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 234);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(15, 0, 0, 0);
            iconButton2.Size = new Size(230, 45);
            iconButton2.TabIndex = 6;
            iconButton2.Text = "   Generar Nueva";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 189);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(15, 0, 0, 0);
            iconButton1.Size = new Size(230, 45);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "   Contraseñas";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            btnHome.IconColor = Color.White;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 25;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 144);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(15, 0, 0, 0);
            btnHome.Size = new Size(230, 45);
            btnHome.TabIndex = 4;
            btnHome.Text = "   Inicio";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 144);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(204, 98);
            label1.TabIndex = 0;
            label1.Text = "Ricardo \r\nDev";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(lbFecha);
            panelDesktop.Controls.Add(lbHora);
            panelDesktop.Controls.Add(cbTheme);
            panelDesktop.Controls.Add(panelTitleBar);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(230, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1111, 696);
            panelDesktop.TabIndex = 2;
            // 
            // lbFecha
            // 
            lbFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbFecha.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbFecha.Location = new Point(0, 307);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(1111, 91);
            lbFecha.TabIndex = 8;
            lbFecha.Text = "Sabado, 04 de enero de 2025";
            lbFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbHora
            // 
            lbHora.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbHora.Font = new Font("Arial Rounded MT Bold", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lbHora.Location = new Point(0, 191);
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(1111, 116);
            lbHora.TabIndex = 7;
            lbHora.Text = "00:00:00";
            lbHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbTheme
            // 
            cbTheme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbTheme.BackColor = Color.FromArgb(246, 246, 246);
            cbTheme.ColorA = Color.FromArgb(246, 132, 85);
            cbTheme.ColorB = Color.FromArgb(231, 108, 57);
            cbTheme.ColorC = Color.FromArgb(242, 241, 240);
            cbTheme.ColorD = Color.FromArgb(253, 252, 252);
            cbTheme.ColorE = Color.FromArgb(239, 237, 236);
            cbTheme.ColorF = Color.FromArgb(180, 180, 180);
            cbTheme.ColorG = Color.FromArgb(119, 119, 118);
            cbTheme.ColorH = Color.FromArgb(224, 222, 220);
            cbTheme.ColorI = Color.FromArgb(250, 249, 249);
            cbTheme.DrawMode = DrawMode.OwnerDrawFixed;
            cbTheme.DropDownHeight = 100;
            cbTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTheme.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbTheme.ForeColor = Color.FromArgb(76, 76, 97);
            cbTheme.FormattingEnabled = true;
            cbTheme.HoverSelectionColor = Color.Empty;
            cbTheme.IntegralHeight = false;
            cbTheme.ItemHeight = 20;
            cbTheme.Location = new Point(950, 69);
            cbTheme.Name = "cbTheme";
            cbTheme.Size = new Size(149, 26);
            cbTheme.StartIndex = 0;
            cbTheme.TabIndex = 6;
            cbTheme.SelectedIndexChanged += cbTheme_SelectedIndexChanged;
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += horaFecha_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 696);
            Controls.Add(panelDesktop);
            Controls.Add(panelMenu);
            MinimumSize = new Size(1357, 735);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelDesktop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Panel panelMenu;
        private Panel panelDesktop;
        private Label lbLogo;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panel1;
        private Label label1;
        private ReaLTaiizor.Controls.DungeonComboBox cbTheme;
        private Label lbFecha;
        private Label lbHora;
        private System.Windows.Forms.Timer horaFecha;
    }
}
