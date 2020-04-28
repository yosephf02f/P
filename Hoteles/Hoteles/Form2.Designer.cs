namespace Hoteles
{
    partial class Form2
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label metodoDePagoLabel;
            System.Windows.Forms.Label nombreDeClienteLabel;
            System.Windows.Forms.Label numeroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listaDeClientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaDeClientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.metodoDePagoTextBox = new System.Windows.Forms.TextBox();
            this.nombreDeClienteTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.listaDeClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaDeClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaDeDatosClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            metodoDePagoLabel = new System.Windows.Forms.Label();
            nombreDeClienteLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeClientesBindingNavigator)).BeginInit();
            this.listaDeClientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeClientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeDatosClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(103, 44);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // metodoDePagoLabel
            // 
            metodoDePagoLabel.AutoSize = true;
            metodoDePagoLabel.Location = new System.Drawing.Point(103, 121);
            metodoDePagoLabel.Name = "metodoDePagoLabel";
            metodoDePagoLabel.Size = new System.Drawing.Size(91, 13);
            metodoDePagoLabel.TabIndex = 5;
            metodoDePagoLabel.Text = "Metodo De Pago:";
            // 
            // nombreDeClienteLabel
            // 
            nombreDeClienteLabel.AutoSize = true;
            nombreDeClienteLabel.Location = new System.Drawing.Point(103, 70);
            nombreDeClienteLabel.Name = "nombreDeClienteLabel";
            nombreDeClienteLabel.Size = new System.Drawing.Size(99, 13);
            nombreDeClienteLabel.TabIndex = 7;
            nombreDeClienteLabel.Text = "Nombre De Cliente:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(103, 96);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(47, 13);
            numeroLabel.TabIndex = 9;
            numeroLabel.Text = "Numero:";
            // 
            // listaDeClientesBindingNavigator
            // 
            this.listaDeClientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaDeClientesBindingNavigator.BindingSource = this.listaDeClientesBindingSource;
            this.listaDeClientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaDeClientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaDeClientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaDeClientesBindingNavigatorSaveItem});
            this.listaDeClientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaDeClientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaDeClientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaDeClientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaDeClientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaDeClientesBindingNavigator.Name = "listaDeClientesBindingNavigator";
            this.listaDeClientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaDeClientesBindingNavigator.Size = new System.Drawing.Size(641, 25);
            this.listaDeClientesBindingNavigator.TabIndex = 0;
            this.listaDeClientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // listaDeClientesBindingNavigatorSaveItem
            // 
            this.listaDeClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaDeClientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaDeClientesBindingNavigatorSaveItem.Image")));
            this.listaDeClientesBindingNavigatorSaveItem.Name = "listaDeClientesBindingNavigatorSaveItem";
            this.listaDeClientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaDeClientesBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeClientesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(208, 41);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // metodoDePagoTextBox
            // 
            this.metodoDePagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeClientesBindingSource, "MetodoDePago", true));
            this.metodoDePagoTextBox.Location = new System.Drawing.Point(208, 118);
            this.metodoDePagoTextBox.Name = "metodoDePagoTextBox";
            this.metodoDePagoTextBox.Size = new System.Drawing.Size(100, 20);
            this.metodoDePagoTextBox.TabIndex = 6;
            // 
            // nombreDeClienteTextBox
            // 
            this.nombreDeClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeClientesBindingSource, "NombreDeCliente", true));
            this.nombreDeClienteTextBox.Location = new System.Drawing.Point(208, 67);
            this.nombreDeClienteTextBox.Name = "nombreDeClienteTextBox";
            this.nombreDeClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreDeClienteTextBox.TabIndex = 8;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDeClientesBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(208, 93);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroTextBox.TabIndex = 10;
            // 
            // listaDeClientesDataGridView
            // 
            this.listaDeClientesDataGridView.AutoGenerateColumns = false;
            this.listaDeClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDeClientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.listaDeClientesDataGridView.DataSource = this.listaDeClientesBindingSource;
            this.listaDeClientesDataGridView.Location = new System.Drawing.Point(12, 178);
            this.listaDeClientesDataGridView.Name = "listaDeClientesDataGridView";
            this.listaDeClientesDataGridView.Size = new System.Drawing.Size(446, 220);
            this.listaDeClientesDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreDeCliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreDeCliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MetodoDePago";
            this.dataGridViewTextBoxColumn3.HeaderText = "MetodoDePago";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn4.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // listaDeClientesBindingSource
            // 
            this.listaDeClientesBindingSource.AllowNew = true;
            this.listaDeClientesBindingSource.DataSource = typeof(Hoteles.Modelos.Cliente);
            // 
            // listaDeDatosClientesBindingSource
            // 
            this.listaDeDatosClientesBindingSource.DataSource = typeof(Hoteles.Modelos.DatosCliente);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 492);
            this.Controls.Add(this.listaDeClientesDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(metodoDePagoLabel);
            this.Controls.Add(this.metodoDePagoTextBox);
            this.Controls.Add(nombreDeClienteLabel);
            this.Controls.Add(this.nombreDeClienteTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.listaDeClientesBindingNavigator);
            this.Name = "Form2";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.listaDeClientesBindingNavigator)).EndInit();
            this.listaDeClientesBindingNavigator.ResumeLayout(false);
            this.listaDeClientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeClientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeDatosClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaDeClientesBindingSource;
        private System.Windows.Forms.BindingNavigator listaDeClientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaDeClientesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox metodoDePagoTextBox;
        private System.Windows.Forms.TextBox nombreDeClienteTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.BindingSource listaDeDatosClientesBindingSource;
        private System.Windows.Forms.DataGridView listaDeClientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}