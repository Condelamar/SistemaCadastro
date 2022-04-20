namespace SistemaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Nome = new System.Windows.Forms.Label();
            this.DtNasc = new System.Windows.Forms.Label();
            this.EstCivil = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtData = new System.Windows.Forms.DateTimePicker();
            this.ComboCivil = new System.Windows.Forms.ComboBox();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.CheckCasa = new System.Windows.Forms.CheckBox();
            this.CheckVeiculo = new System.Windows.Forms.CheckBox();
            this.GrupoSexo = new System.Windows.Forms.GroupBox();
            this.RadioO = new System.Windows.Forms.RadioButton();
            this.RadioF = new System.Windows.Forms.RadioButton();
            this.RadioM = new System.Windows.Forms.RadioButton();
            this.Lista = new System.Windows.Forms.ListBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.GrupoSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(12, 10);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(64, 24);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // DtNasc
            // 
            this.DtNasc.AutoSize = true;
            this.DtNasc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtNasc.Location = new System.Drawing.Point(12, 65);
            this.DtNasc.Name = "DtNasc";
            this.DtNasc.Size = new System.Drawing.Size(200, 24);
            this.DtNasc.TabIndex = 1;
            this.DtNasc.Text = "Data de Nascimento";
            // 
            // EstCivil
            // 
            this.EstCivil.AutoSize = true;
            this.EstCivil.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstCivil.Location = new System.Drawing.Point(12, 120);
            this.EstCivil.Name = "EstCivil";
            this.EstCivil.Size = new System.Drawing.Size(122, 24);
            this.EstCivil.TabIndex = 2;
            this.EstCivil.Text = "Estado Civil";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(12, 174);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(89, 24);
            this.Telefone.TabIndex = 3;
            this.Telefone.Text = "Telefone";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(253, 10);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(589, 32);
            this.TxtNome.TabIndex = 4;
            // 
            // TxtData
            // 
            this.TxtData.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtData.Location = new System.Drawing.Point(253, 65);
            this.TxtData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(589, 32);
            this.TxtData.TabIndex = 5;
            // 
            // ComboCivil
            // 
            this.ComboCivil.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCivil.FormattingEnabled = true;
            this.ComboCivil.Location = new System.Drawing.Point(253, 120);
            this.ComboCivil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboCivil.Name = "ComboCivil";
            this.ComboCivil.Size = new System.Drawing.Size(471, 32);
            this.ComboCivil.TabIndex = 6;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefone.Location = new System.Drawing.Point(253, 174);
            this.TxtTelefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTelefone.Mask = "(99) 99999-9999";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(471, 32);
            this.TxtTelefone.TabIndex = 7;
            // 
            // CheckCasa
            // 
            this.CheckCasa.AutoSize = true;
            this.CheckCasa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCasa.Location = new System.Drawing.Point(253, 240);
            this.CheckCasa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckCasa.Name = "CheckCasa";
            this.CheckCasa.Size = new System.Drawing.Size(209, 28);
            this.CheckCasa.TabIndex = 8;
            this.CheckCasa.Text = "Possui casa própia";
            this.CheckCasa.UseVisualStyleBackColor = true;
            // 
            // CheckVeiculo
            // 
            this.CheckVeiculo.AutoSize = true;
            this.CheckVeiculo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckVeiculo.Location = new System.Drawing.Point(253, 276);
            this.CheckVeiculo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckVeiculo.Name = "CheckVeiculo";
            this.CheckVeiculo.Size = new System.Drawing.Size(166, 28);
            this.CheckVeiculo.TabIndex = 9;
            this.CheckVeiculo.Text = "Possui veículo";
            this.CheckVeiculo.UseVisualStyleBackColor = true;
            // 
            // GrupoSexo
            // 
            this.GrupoSexo.Controls.Add(this.RadioO);
            this.GrupoSexo.Controls.Add(this.RadioF);
            this.GrupoSexo.Controls.Add(this.RadioM);
            this.GrupoSexo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoSexo.Location = new System.Drawing.Point(253, 326);
            this.GrupoSexo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GrupoSexo.Name = "GrupoSexo";
            this.GrupoSexo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GrupoSexo.Size = new System.Drawing.Size(358, 145);
            this.GrupoSexo.TabIndex = 10;
            this.GrupoSexo.TabStop = false;
            this.GrupoSexo.Text = "Sexo";
            // 
            // RadioO
            // 
            this.RadioO.AutoSize = true;
            this.RadioO.Location = new System.Drawing.Point(6, 108);
            this.RadioO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioO.Name = "RadioO";
            this.RadioO.Size = new System.Drawing.Size(80, 28);
            this.RadioO.TabIndex = 12;
            this.RadioO.TabStop = true;
            this.RadioO.Text = "Outro";
            this.RadioO.UseVisualStyleBackColor = true;
            // 
            // RadioF
            // 
            this.RadioF.AutoSize = true;
            this.RadioF.Location = new System.Drawing.Point(6, 70);
            this.RadioF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioF.Name = "RadioF";
            this.RadioF.Size = new System.Drawing.Size(113, 28);
            this.RadioF.TabIndex = 11;
            this.RadioF.TabStop = true;
            this.RadioF.Text = "Feminino";
            this.RadioF.UseVisualStyleBackColor = true;
            // 
            // RadioM
            // 
            this.RadioM.AutoSize = true;
            this.RadioM.Checked = true;
            this.RadioM.Location = new System.Drawing.Point(6, 33);
            this.RadioM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioM.Name = "RadioM";
            this.RadioM.Size = new System.Drawing.Size(122, 28);
            this.RadioM.TabIndex = 0;
            this.RadioM.TabStop = true;
            this.RadioM.Text = "Masculino";
            this.RadioM.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            this.Lista.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 24;
            this.Lista.Location = new System.Drawing.Point(16, 600);
            this.Lista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(850, 124);
            this.Lista.TabIndex = 11;
            this.Lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Lista_MouseDoubleClick);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(33)))));
            this.BtnCadastrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Location = new System.Drawing.Point(16, 516);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(238, 78);
            this.BtnCadastrar.TabIndex = 12;
            this.BtnCadastrar.Text = "Cadastrar / Alterar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(322, 516);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(238, 78);
            this.BtnExcluir.TabIndex = 13;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(121)))));
            this.BtnLimpar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(628, 516);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(238, 78);
            this.BtnLimpar.TabIndex = 14;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(885, 730);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.GrupoSexo);
            this.Controls.Add(this.CheckVeiculo);
            this.Controls.Add(this.CheckCasa);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.ComboCivil);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.EstCivil);
            this.Controls.Add(this.DtNasc);
            this.Controls.Add(this.Nome);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(901, 769);
            this.MinimumSize = new System.Drawing.Size(901, 622);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.GrupoSexo.ResumeLayout(false);
            this.GrupoSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label DtNasc;
        private System.Windows.Forms.Label EstCivil;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.DateTimePicker TxtData;
        private System.Windows.Forms.ComboBox ComboCivil;
        private System.Windows.Forms.MaskedTextBox TxtTelefone;
        private System.Windows.Forms.CheckBox CheckCasa;
        private System.Windows.Forms.CheckBox CheckVeiculo;
        private System.Windows.Forms.GroupBox GrupoSexo;
        private System.Windows.Forms.RadioButton RadioF;
        private System.Windows.Forms.RadioButton RadioM;
        private System.Windows.Forms.RadioButton RadioO;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnLimpar;
    }
}

