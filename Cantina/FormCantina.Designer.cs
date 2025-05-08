namespace Cantina
{
    partial class FormCantina
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
            listBoxProdutos = new ListBox();
            btnAdicionar = new Button();
            listBoxCarrinho = new ListBox();
            btnFecharPedido = new Button();
            lblTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            btnRemover = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBoxProdutos
            // 
            listBoxProdutos.FormattingEnabled = true;
            listBoxProdutos.ItemHeight = 25;
            listBoxProdutos.Location = new Point(12, 49);
            listBoxProdutos.Name = "listBoxProdutos";
            listBoxProdutos.Size = new Size(320, 129);
            listBoxProdutos.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(373, 60);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar >";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listBoxCarrinho
            // 
            listBoxCarrinho.FormattingEnabled = true;
            listBoxCarrinho.ItemHeight = 25;
            listBoxCarrinho.Location = new Point(528, 49);
            listBoxCarrinho.Name = "listBoxCarrinho";
            listBoxCarrinho.Size = new Size(318, 129);
            listBoxCarrinho.TabIndex = 2;
            // 
            // btnFecharPedido
            // 
            btnFecharPedido.Location = new Point(325, 346);
            btnFecharPedido.Name = "btnFecharPedido";
            btnFecharPedido.Size = new Size(204, 34);
            btnFecharPedido.TabIndex = 3;
            btnFecharPedido.Text = "Fechar Pedido ";
            btnFecharPedido.UseVisualStyleBackColor = true;
            btnFecharPedido.Click += btnFecharPedido_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 20F);
            lblTotal.Location = new Point(355, 217);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(130, 54);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(529, 7);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 5;
            label1.Text = "Carrinho";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 6;
            label2.Text = "Produtos Cantina";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(373, 132);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(112, 34);
            btnRemover.TabIndex = 7;
            btnRemover.Text = "< Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // button1
            // 
            button1.Location = new Point(686, 287);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "testando";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormCantina
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 450);
            Controls.Add(button1);
            Controls.Add(btnRemover);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(btnFecharPedido);
            Controls.Add(listBoxCarrinho);
            Controls.Add(btnAdicionar);
            Controls.Add(listBoxProdutos);
            Name = "FormCantina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCantina";
            Load += FormCantina_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxProdutos;
        private Button btnAdicionar;
        private ListBox listBoxCarrinho;
        private Button btnFecharPedido;
        private Label lblTotal;
        private Label label1;
        private Label label2;
        private Button btnRemover;
        private Button button1;
    }
}