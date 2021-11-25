
namespace Projetohw
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxCategoria = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUser1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Snow;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonLogout.Location = new System.Drawing.Point(581, 6);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(100, 31);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.Location = new System.Drawing.Point(12, 205);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.Size = new System.Drawing.Size(669, 150);
            this.dataGridViewProduto.TabIndex = 32;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(354, 171);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(88, 23);
            this.buttonExcluir.TabIndex = 29;
            this.buttonExcluir.Text = "Excluir produto";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(12, 171);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(144, 23);
            this.buttonInserir.TabIndex = 28;
            this.buttonInserir.Text = "Inserir produto ao catálogo";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(263, 171);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(83, 23);
            this.buttonLimpar.TabIndex = 27;
            this.buttonLimpar.Text = "Limpar dados";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button7.Location = new System.Drawing.Point(131, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(311, 34);
            this.button7.TabIndex = 26;
            this.button7.Text = "Tela de Pesquisa de Produtos";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(100, 142);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(342, 20);
            this.textBoxDescricao.TabIndex = 25;
            this.textBoxDescricao.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(100, 109);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(342, 20);
            this.textBoxValor.TabIndex = 24;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(100, 78);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(342, 20);
            this.textBoxNome.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(8, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(8, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Inserir produto";
            // 
            // listBoxCategoria
            // 
            this.listBoxCategoria.FormattingEnabled = true;
            this.listBoxCategoria.Items.AddRange(new object[] {
            "Placa mãe ",
            "Processador",
            "Memória",
            "Placa de vídeo",
            "Fonte",
            "HD"});
            this.listBoxCategoria.Location = new System.Drawing.Point(100, 42);
            this.listBoxCategoria.Name = "listBoxCategoria";
            this.listBoxCategoria.Size = new System.Drawing.Size(342, 30);
            this.listBoxCategoria.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Usuario:";
            // 
            // textBoxUser1
            // 
            this.textBoxUser1.Location = new System.Drawing.Point(581, 48);
            this.textBoxUser1.Name = "textBoxUser1";
            this.textBoxUser1.ReadOnly = true;
            this.textBoxUser1.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser1.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Atualizar perfil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 367);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxUser1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewProduto);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogout);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela inicial - HAX Informática";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.DataGridView dataGridViewProduto;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUser1;
        private System.Windows.Forms.Button button2;
    }
}

