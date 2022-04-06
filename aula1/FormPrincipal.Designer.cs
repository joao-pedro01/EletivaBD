
namespace aula1
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadrastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadrastroToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 27);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // cadrastroToolStripMenuItem
            // 
            this.cadrastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuCliente,
            this.itemMenuProduto,
            this.itemMenuCategoria,
            this.itemMenuSair});
            this.cadrastroToolStripMenuItem.Name = "cadrastroToolStripMenuItem";
            this.cadrastroToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.cadrastroToolStripMenuItem.Text = "Cadrastro";
            // 
            // itemMenuCliente
            // 
            this.itemMenuCliente.Name = "itemMenuCliente";
            this.itemMenuCliente.Size = new System.Drawing.Size(180, 24);
            this.itemMenuCliente.Text = "Cliente";
            this.itemMenuCliente.Click += new System.EventHandler(this.itemMenuCliente_Click);
            // 
            // itemMenuProduto
            // 
            this.itemMenuProduto.Name = "itemMenuProduto";
            this.itemMenuProduto.Size = new System.Drawing.Size(180, 24);
            this.itemMenuProduto.Text = "Produto";
            this.itemMenuProduto.Click += new System.EventHandler(this.itemMenuProduto_Click);
            // 
            // itemMenuCategoria
            // 
            this.itemMenuCategoria.Name = "itemMenuCategoria";
            this.itemMenuCategoria.Size = new System.Drawing.Size(180, 24);
            this.itemMenuCategoria.Text = "Categoria";
            this.itemMenuCategoria.Click += new System.EventHandler(this.itemMenuCategoria_Click);
            // 
            // itemMenuSair
            // 
            this.itemMenuSair.Name = "itemMenuSair";
            this.itemMenuSair.Size = new System.Drawing.Size(180, 24);
            this.itemMenuSair.Text = "Sair";
            this.itemMenuSair.Click += new System.EventHandler(this.itemMenuSair_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "Form1";
            this.Text = "Super formulário";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadrastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMenuCliente;
        private System.Windows.Forms.ToolStripMenuItem itemMenuProduto;
        private System.Windows.Forms.ToolStripMenuItem itemMenuCategoria;
        private System.Windows.Forms.ToolStripMenuItem itemMenuSair;
    }
}

