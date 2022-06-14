namespace cadCidades
{
    partial class cadCidade
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadCidade));
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label codigo_IBGELabel;
            System.Windows.Forms.Label codigo_ANPLabel;
            System.Windows.Forms.Label codigo_DDDLabel;
            this.cadCidadesDataSet = new cadCidades.cadCidadesDataSet();
            this.cAD_CidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAD_CidadeTableAdapter = new cadCidades.cadCidadesDataSetTableAdapters.CAD_CidadeTableAdapter();
            this.tableAdapterManager = new cadCidades.cadCidadesDataSetTableAdapters.TableAdapterManager();
            this.cAD_CidadeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cAD_CidadeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.paisComboBox = new System.Windows.Forms.ComboBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.cEPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.codigo_IBGETextBox = new System.Windows.Forms.TextBox();
            this.codigo_ANPTextBox = new System.Windows.Forms.TextBox();
            this.codigo_DDDTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            codigo_IBGELabel = new System.Windows.Forms.Label();
            codigo_ANPLabel = new System.Windows.Forms.Label();
            codigo_DDDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadCidadesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_CidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_CidadeBindingNavigator)).BeginInit();
            this.cAD_CidadeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            resources.ApplyResources(idLabel, "idLabel");
            idLabel.Name = "idLabel";
            // 
            // paisLabel
            // 
            resources.ApplyResources(paisLabel, "paisLabel");
            paisLabel.Name = "paisLabel";
            // 
            // estadoLabel
            // 
            resources.ApplyResources(estadoLabel, "estadoLabel");
            estadoLabel.Name = "estadoLabel";
            // 
            // cidadeLabel
            // 
            resources.ApplyResources(cidadeLabel, "cidadeLabel");
            cidadeLabel.Name = "cidadeLabel";
            // 
            // cEPLabel
            // 
            resources.ApplyResources(cEPLabel, "cEPLabel");
            cEPLabel.Name = "cEPLabel";
            // 
            // codigo_IBGELabel
            // 
            resources.ApplyResources(codigo_IBGELabel, "codigo_IBGELabel");
            codigo_IBGELabel.Name = "codigo_IBGELabel";
            // 
            // codigo_ANPLabel
            // 
            resources.ApplyResources(codigo_ANPLabel, "codigo_ANPLabel");
            codigo_ANPLabel.Name = "codigo_ANPLabel";
            // 
            // codigo_DDDLabel
            // 
            resources.ApplyResources(codigo_DDDLabel, "codigo_DDDLabel");
            codigo_DDDLabel.Name = "codigo_DDDLabel";
            // 
            // cadCidadesDataSet
            // 
            this.cadCidadesDataSet.DataSetName = "cadCidadesDataSet";
            this.cadCidadesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAD_CidadeBindingSource
            // 
            this.cAD_CidadeBindingSource.DataMember = "CAD_Cidade";
            this.cAD_CidadeBindingSource.DataSource = this.cadCidadesDataSet;
            // 
            // cAD_CidadeTableAdapter
            // 
            this.cAD_CidadeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAD_CidadeTableAdapter = this.cAD_CidadeTableAdapter;
            this.tableAdapterManager.UpdateOrder = cadCidades.cadCidadesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cAD_CidadeBindingNavigator
            // 
            resources.ApplyResources(this.cAD_CidadeBindingNavigator, "cAD_CidadeBindingNavigator");
            this.cAD_CidadeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cAD_CidadeBindingNavigator.BindingSource = this.cAD_CidadeBindingSource;
            this.cAD_CidadeBindingNavigator.CountItem = null;
            this.cAD_CidadeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cAD_CidadeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cAD_CidadeBindingNavigatorSaveItem});
            this.cAD_CidadeBindingNavigator.MoveFirstItem = null;
            this.cAD_CidadeBindingNavigator.MoveLastItem = null;
            this.cAD_CidadeBindingNavigator.MoveNextItem = null;
            this.cAD_CidadeBindingNavigator.MovePreviousItem = null;
            this.cAD_CidadeBindingNavigator.Name = "cAD_CidadeBindingNavigator";
            this.cAD_CidadeBindingNavigator.PositionItem = null;
            // 
            // bindingNavigatorAddNewItem
            // 
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            // 
            // bindingNavigatorDeleteItem
            // 
            resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            // 
            // bindingNavigatorSeparator
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            // 
            // bindingNavigatorSeparator1
            // 
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            // 
            // cAD_CidadeBindingNavigatorSaveItem
            // 
            resources.ApplyResources(this.cAD_CidadeBindingNavigatorSaveItem, "cAD_CidadeBindingNavigatorSaveItem");
            this.cAD_CidadeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cAD_CidadeBindingNavigatorSaveItem.Name = "cAD_CidadeBindingNavigatorSaveItem";
            this.cAD_CidadeBindingNavigatorSaveItem.Click += new System.EventHandler(this.cAD_CidadeBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            resources.ApplyResources(this.idTextBox, "idTextBox");
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_CidadeBindingSource, "Id", true));
            this.idTextBox.Name = "idTextBox";
            // 
            // paisComboBox
            // 
            resources.ApplyResources(this.paisComboBox, "paisComboBox");
            this.paisComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_CidadeBindingSource, "Pais", true));
            this.paisComboBox.FormattingEnabled = true;
            this.paisComboBox.Items.AddRange(new object[] {
            resources.GetString("paisComboBox.Items")});
            this.paisComboBox.Name = "paisComboBox";
            this.paisComboBox.SelectedIndexChanged += new System.EventHandler(this.paisComboBox_SelectedIndexChanged);
            // 
            // estadoComboBox
            // 
            resources.ApplyResources(this.estadoComboBox, "estadoComboBox");
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_CidadeBindingSource, "Estado", true));
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cAD_CidadeBindingSource, "Pais", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            resources.GetString("estadoComboBox.Items")});
            this.estadoComboBox.Name = "estadoComboBox";
            // 
            // cidadeComboBox
            // 
            resources.ApplyResources(this.cidadeComboBox, "cidadeComboBox");
            this.cidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_CidadeBindingSource, "Cidade", true));
            this.cidadeComboBox.FormattingEnabled = true;
            this.cidadeComboBox.Items.AddRange(new object[] {
            resources.GetString("cidadeComboBox.Items"),
            resources.GetString("cidadeComboBox.Items1"),
            resources.GetString("cidadeComboBox.Items2")});
            this.cidadeComboBox.Name = "cidadeComboBox";
            // 
            // cEPMaskedTextBox
            // 
            resources.ApplyResources(this.cEPMaskedTextBox, "cEPMaskedTextBox");
            this.cEPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_CidadeBindingSource, "CEP", true));
            this.cEPMaskedTextBox.Name = "cEPMaskedTextBox";
            // 
            // codigo_IBGETextBox
            // 
            resources.ApplyResources(this.codigo_IBGETextBox, "codigo_IBGETextBox");
            this.codigo_IBGETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_CidadeBindingSource, "Codigo IBGE", true));
            this.codigo_IBGETextBox.Name = "codigo_IBGETextBox";
            // 
            // codigo_ANPTextBox
            // 
            resources.ApplyResources(this.codigo_ANPTextBox, "codigo_ANPTextBox");
            this.codigo_ANPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_CidadeBindingSource, "Codigo ANP", true));
            this.codigo_ANPTextBox.Name = "codigo_ANPTextBox";
            // 
            // codigo_DDDTextBox
            // 
            resources.ApplyResources(this.codigo_DDDTextBox, "codigo_DDDTextBox");
            this.codigo_DDDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAD_CidadeBindingSource, "Codigo DDD", true));
            this.codigo_DDDTextBox.Name = "codigo_DDDTextBox";
            // 
            // cadCidade
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(codigo_DDDLabel);
            this.Controls.Add(this.codigo_DDDTextBox);
            this.Controls.Add(codigo_ANPLabel);
            this.Controls.Add(this.codigo_ANPTextBox);
            this.Controls.Add(codigo_IBGELabel);
            this.Controls.Add(this.codigo_IBGETextBox);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPMaskedTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeComboBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.cAD_CidadeBindingNavigator);
            this.MaximizeBox = false;
            this.Name = "cadCidade";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadCidadesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_CidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAD_CidadeBindingNavigator)).EndInit();
            this.cAD_CidadeBindingNavigator.ResumeLayout(false);
            this.cAD_CidadeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cadCidadesDataSet cadCidadesDataSet;
        private System.Windows.Forms.BindingSource cAD_CidadeBindingSource;
        private cadCidadesDataSetTableAdapters.CAD_CidadeTableAdapter cAD_CidadeTableAdapter;
        private cadCidadesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cAD_CidadeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton cAD_CidadeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox paisComboBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.ComboBox cidadeComboBox;
        private System.Windows.Forms.TextBox codigo_IBGETextBox;
        private System.Windows.Forms.TextBox codigo_ANPTextBox;
        private System.Windows.Forms.TextBox codigo_DDDTextBox;
        private System.Windows.Forms.MaskedTextBox cEPMaskedTextBox;
    }
}

