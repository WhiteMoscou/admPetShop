
namespace admPetShop
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnMaximizarJanela = new System.Windows.Forms.Button();
            this.btnMinimizarJanela = new System.Windows.Forms.Button();
            this.btnFecharJanela = new System.Windows.Forms.Button();
            this.centralPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAgendamentos = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnAnimais = new System.Windows.Forms.Button();
            this.btnRaca = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.centralPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.topPanel.Controls.Add(this.btnMaximizarJanela);
            this.topPanel.Controls.Add(this.btnMinimizarJanela);
            this.topPanel.Controls.Add(this.btnFecharJanela);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1305, 40);
            this.topPanel.TabIndex = 1;
            // 
            // btnMaximizarJanela
            // 
            this.btnMaximizarJanela.BackColor = System.Drawing.Color.Yellow;
            this.btnMaximizarJanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizarJanela.FlatAppearance.BorderSize = 0;
            this.btnMaximizarJanela.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizarJanela.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMaximizarJanela.Location = new System.Drawing.Point(1250, 10);
            this.btnMaximizarJanela.Margin = new System.Windows.Forms.Padding(6);
            this.btnMaximizarJanela.Name = "btnMaximizarJanela";
            this.btnMaximizarJanela.Size = new System.Drawing.Size(21, 21);
            this.btnMaximizarJanela.TabIndex = 4;
            this.btnMaximizarJanela.UseVisualStyleBackColor = false;
            // 
            // btnMinimizarJanela
            // 
            this.btnMinimizarJanela.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMinimizarJanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarJanela.FlatAppearance.BorderSize = 0;
            this.btnMinimizarJanela.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizarJanela.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinimizarJanela.Location = new System.Drawing.Point(1229, 10);
            this.btnMinimizarJanela.Margin = new System.Windows.Forms.Padding(6);
            this.btnMinimizarJanela.Name = "btnMinimizarJanela";
            this.btnMinimizarJanela.Size = new System.Drawing.Size(21, 21);
            this.btnMinimizarJanela.TabIndex = 3;
            this.btnMinimizarJanela.UseVisualStyleBackColor = false;
            this.btnMinimizarJanela.Click += new System.EventHandler(this.btnMinimizarJanela_Click);
            // 
            // btnFecharJanela
            // 
            this.btnFecharJanela.BackColor = System.Drawing.Color.Crimson;
            this.btnFecharJanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharJanela.FlatAppearance.BorderSize = 0;
            this.btnFecharJanela.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharJanela.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFecharJanela.Location = new System.Drawing.Point(1272, 10);
            this.btnFecharJanela.Margin = new System.Windows.Forms.Padding(6);
            this.btnFecharJanela.Name = "btnFecharJanela";
            this.btnFecharJanela.Size = new System.Drawing.Size(21, 21);
            this.btnFecharJanela.TabIndex = 2;
            this.btnFecharJanela.UseVisualStyleBackColor = false;
            this.btnFecharJanela.Click += new System.EventHandler(this.btnFecharJanela_Click);
            // 
            // centralPanel
            // 
            this.centralPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.centralPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.centralPanel.Controls.Add(this.panel1);
            this.centralPanel.Controls.Add(this.leftPanel);
            this.centralPanel.Location = new System.Drawing.Point(0, 40);
            this.centralPanel.Margin = new System.Windows.Forms.Padding(0);
            this.centralPanel.Name = "centralPanel";
            this.centralPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.centralPanel.Size = new System.Drawing.Size(1305, 578);
            this.centralPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::admPetShop.Properties.Resources.frmBackgroundCachorro;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(463, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 480);
            this.panel1.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.leftPanel.Controls.Add(this.btnInicio);
            this.leftPanel.Controls.Add(this.btnAgendamentos);
            this.leftPanel.Controls.Add(this.btnServicos);
            this.leftPanel.Controls.Add(this.btnAnimais);
            this.leftPanel.Controls.Add(this.btnRaca);
            this.leftPanel.Controls.Add(this.btnCliente);
            this.leftPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leftPanel.Location = new System.Drawing.Point(27, 35);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(225, 500);
            this.leftPanel.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInicio.Location = new System.Drawing.Point(34, 12);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(156, 56);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAgendamentos
            // 
            this.btnAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamentos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgendamentos.Location = new System.Drawing.Point(34, 424);
            this.btnAgendamentos.Name = "btnAgendamentos";
            this.btnAgendamentos.Size = new System.Drawing.Size(156, 56);
            this.btnAgendamentos.TabIndex = 4;
            this.btnAgendamentos.Text = "Agendamentos";
            this.btnAgendamentos.UseVisualStyleBackColor = true;
            this.btnAgendamentos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServicos.Location = new System.Drawing.Point(34, 339);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(156, 56);
            this.btnServicos.TabIndex = 3;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.UseVisualStyleBackColor = true;
            this.btnServicos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAnimais
            // 
            this.btnAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnimais.Location = new System.Drawing.Point(34, 256);
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.Size = new System.Drawing.Size(156, 56);
            this.btnAnimais.TabIndex = 2;
            this.btnAnimais.Text = "Animais";
            this.btnAnimais.UseVisualStyleBackColor = true;
            this.btnAnimais.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRaca
            // 
            this.btnRaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRaca.Location = new System.Drawing.Point(34, 175);
            this.btnRaca.Name = "btnRaca";
            this.btnRaca.Size = new System.Drawing.Size(156, 56);
            this.btnRaca.TabIndex = 1;
            this.btnRaca.Text = "Raça";
            this.btnRaca.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCliente.Location = new System.Drawing.Point(34, 90);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(156, 56);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1305, 618);
            this.Controls.Add(this.centralPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.centralPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnRaca;
        private System.Windows.Forms.Button btnAgendamentos;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnAnimais;
        protected System.Windows.Forms.Panel centralPanel;
        private System.Windows.Forms.Button btnFecharJanela;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnMaximizarJanela;
        private System.Windows.Forms.Button btnMinimizarJanela;
        private System.Windows.Forms.Panel panel1;
    }
}

