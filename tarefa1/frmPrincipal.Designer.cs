
namespace Tarefa
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.opcConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.itemConsProd = new System.Windows.Forms.ToolStripMenuItem();
            this.itemConsCli = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // opcConsulta
            // 
            this.opcConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemConsProd,
            this.itemConsCli});
            this.opcConsulta.Name = "opcConsulta";
            this.opcConsulta.Size = new System.Drawing.Size(66, 20);
            this.opcConsulta.Text = "Consulta";
            // 
            // itemConsProd
            // 
            this.itemConsProd.Name = "itemConsProd";
            this.itemConsProd.Size = new System.Drawing.Size(117, 22);
            this.itemConsProd.Text = "Produto";
            this.itemConsProd.Click += new System.EventHandler(this.itemConsProd_Click);
            // 
            // itemConsCli
            // 
            this.itemConsCli.Name = "itemConsCli";
            this.itemConsCli.Size = new System.Drawing.Size(117, 22);
            this.itemConsCli.Text = "Cliente";
            this.itemConsCli.Click += new System.EventHandler(this.itemConsCli_Click);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcConsulta});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(794, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FormPrincipal";
            this.Text = "Cadastro de Cliente";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem opcConsulta;
        private System.Windows.Forms.ToolStripMenuItem itemConsProd;
        private System.Windows.Forms.ToolStripMenuItem itemConsCli;
        private System.Windows.Forms.MenuStrip menuPrincipal;
    }
}

