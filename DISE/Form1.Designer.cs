namespace DISE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label cUITLabel;
            System.Windows.Forms.Label nombreCompletoLabel;
            System.Windows.Forms.Label cUILLabel;
            System.Windows.Forms.Label legajoLabel;
            System.Windows.Forms.Label codEmpresaLabel;
            System.Windows.Forms.Label fechaNacLabel;
            System.Windows.Forms.Label fechaMatLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelEmpresa = new System.Windows.Forms.Panel();
            this.btCancel1 = new System.Windows.Forms.Button();
            this.btAddEmpresa = new System.Windows.Forms.Button();
            this.cUITTextBox = new System.Windows.Forms.TextBox();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contableDataSet = new DISE.ContableDataSet();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.empresaTableAdapter = new DISE.ContableDataSetTableAdapters.EmpresaTableAdapter();
            this.tableAdapterManager = new DISE.ContableDataSetTableAdapters.TableAdapterManager();
            this.empresaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.empresaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panelEmpleado = new System.Windows.Forms.Panel();
            this.CodEmpresa = new System.Windows.Forms.ComboBox();
            this.btcancel2 = new System.Windows.Forms.Button();
            this.btaddEmpleado = new System.Windows.Forms.Button();
            this.legajoTextBox = new System.Windows.Forms.TextBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUILTextBox = new System.Windows.Forms.TextBox();
            this.nombreCompletoTextBox = new System.Windows.Forms.TextBox();
            this.empleadosTableAdapter = new DISE.ContableDataSetTableAdapters.EmpleadosTableAdapter();
            this.panelSup = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.panelIzq = new System.Windows.Forms.Panel();
            this.panelDet2 = new System.Windows.Forms.Panel();
            this.subPanel2 = new System.Windows.Forms.Panel();
            this.panelDet = new System.Windows.Forms.Panel();
            this.panelDet1 = new System.Windows.Forms.Panel();
            this.btAdministrar = new System.Windows.Forms.Button();
            this.subPanel1 = new System.Windows.Forms.Panel();
            this.edEmpleado = new System.Windows.Forms.Button();
            this.addEmpleado = new System.Windows.Forms.Button();
            this.edEmpresa = new System.Windows.Forms.Button();
            this.btEmpresaAdd = new System.Windows.Forms.Button();
            this.btEmpresa = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDeduc = new System.Windows.Forms.Panel();
            this.deducCancel = new System.Windows.Forms.Button();
            this.addDeducibles = new System.Windows.Forms.Button();
            this.fechaMatTextBox = new System.Windows.Forms.TextBox();
            this.deduciblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaNacTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.acargo = new System.Windows.Forms.ComboBox();
            this.estCivil = new System.Windows.Forms.ComboBox();
            this.cantHijos = new System.Windows.Forms.ComboBox();
            this.deduciblesTableAdapter = new DISE.ContableDataSetTableAdapters.DeduciblesTableAdapter();
            this.panelCentral = new System.Windows.Forms.Panel();
            nombreLabel = new System.Windows.Forms.Label();
            cUITLabel = new System.Windows.Forms.Label();
            nombreCompletoLabel = new System.Windows.Forms.Label();
            cUILLabel = new System.Windows.Forms.Label();
            legajoLabel = new System.Windows.Forms.Label();
            codEmpresaLabel = new System.Windows.Forms.Label();
            fechaNacLabel = new System.Windows.Forms.Label();
            fechaMatLabel = new System.Windows.Forms.Label();
            this.panelEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingNavigator)).BeginInit();
            this.empresaBindingNavigator.SuspendLayout();
            this.panelEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            this.panelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.panelIzq.SuspendLayout();
            this.subPanel1.SuspendLayout();
            this.panelDeduc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deduciblesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(46, 19);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 0;
            nombreLabel.Text = "nombre:";
            // 
            // cUITLabel
            // 
            cUITLabel.AutoSize = true;
            cUITLabel.Location = new System.Drawing.Point(56, 58);
            cUITLabel.Name = "cUITLabel";
            cUITLabel.Size = new System.Drawing.Size(35, 13);
            cUITLabel.TabIndex = 2;
            cUITLabel.Text = "CUIT:";
            // 
            // nombreCompletoLabel
            // 
            nombreCompletoLabel.AutoSize = true;
            nombreCompletoLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreCompletoLabel.Location = new System.Drawing.Point(3, 33);
            nombreCompletoLabel.Name = "nombreCompletoLabel";
            nombreCompletoLabel.Size = new System.Drawing.Size(122, 17);
            nombreCompletoLabel.TabIndex = 0;
            nombreCompletoLabel.Text = "Nombre Completo:";
            // 
            // cUILLabel
            // 
            cUILLabel.AutoSize = true;
            cUILLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cUILLabel.Location = new System.Drawing.Point(86, 60);
            cUILLabel.Name = "cUILLabel";
            cUILLabel.Size = new System.Drawing.Size(37, 17);
            cUILLabel.TabIndex = 2;
            cUILLabel.Text = "CUIL:";
            // 
            // legajoLabel
            // 
            legajoLabel.AutoSize = true;
            legajoLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legajoLabel.Location = new System.Drawing.Point(71, 85);
            legajoLabel.Name = "legajoLabel";
            legajoLabel.Size = new System.Drawing.Size(52, 17);
            legajoLabel.TabIndex = 4;
            legajoLabel.Text = "Legajo:";
            // 
            // codEmpresaLabel
            // 
            codEmpresaLabel.AutoSize = true;
            codEmpresaLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codEmpresaLabel.Location = new System.Drawing.Point(65, 122);
            codEmpresaLabel.Name = "codEmpresaLabel";
            codEmpresaLabel.Size = new System.Drawing.Size(58, 17);
            codEmpresaLabel.TabIndex = 6;
            codEmpresaLabel.Text = "Empresa";
            // 
            // fechaNacLabel
            // 
            fechaNacLabel.AutoSize = true;
            fechaNacLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaNacLabel.Location = new System.Drawing.Point(47, 49);
            fechaNacLabel.Name = "fechaNacLabel";
            fechaNacLabel.Size = new System.Drawing.Size(74, 17);
            fechaNacLabel.TabIndex = 10;
            fechaNacLabel.Text = "fecha Nac:";
            // 
            // fechaMatLabel
            // 
            fechaMatLabel.AutoSize = true;
            fechaMatLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaMatLabel.Location = new System.Drawing.Point(49, 109);
            fechaMatLabel.Name = "fechaMatLabel";
            fechaMatLabel.Size = new System.Drawing.Size(73, 17);
            fechaMatLabel.TabIndex = 11;
            fechaMatLabel.Text = "fecha Mat:";
            // 
            // panelEmpresa
            // 
            this.panelEmpresa.Controls.Add(this.btCancel1);
            this.panelEmpresa.Controls.Add(this.btAddEmpresa);
            this.panelEmpresa.Controls.Add(cUITLabel);
            this.panelEmpresa.Controls.Add(this.cUITTextBox);
            this.panelEmpresa.Controls.Add(nombreLabel);
            this.panelEmpresa.Controls.Add(this.nombreTextBox);
            this.panelEmpresa.Location = new System.Drawing.Point(249, 59);
            this.panelEmpresa.Name = "panelEmpresa";
            this.panelEmpresa.Size = new System.Drawing.Size(251, 139);
            this.panelEmpresa.TabIndex = 0;
            this.panelEmpresa.Visible = false;
            // 
            // btCancel1
            // 
            this.btCancel1.Location = new System.Drawing.Point(140, 101);
            this.btCancel1.Name = "btCancel1";
            this.btCancel1.Size = new System.Drawing.Size(75, 23);
            this.btCancel1.TabIndex = 5;
            this.btCancel1.Text = "&Cancelar";
            this.btCancel1.UseVisualStyleBackColor = true;
            // 
            // btAddEmpresa
            // 
            this.btAddEmpresa.Location = new System.Drawing.Point(59, 101);
            this.btAddEmpresa.Name = "btAddEmpresa";
            this.btAddEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btAddEmpresa.TabIndex = 4;
            this.btAddEmpresa.Text = "&Agregar";
            this.btAddEmpresa.UseVisualStyleBackColor = true;
            this.btAddEmpresa.Click += new System.EventHandler(this.button1_Click);
            // 
            // cUITTextBox
            // 
            this.cUITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "CUIT", true));
            this.cUITTextBox.Location = new System.Drawing.Point(97, 55);
            this.cUITTextBox.Name = "cUITTextBox";
            this.cUITTextBox.Size = new System.Drawing.Size(100, 20);
            this.cUITTextBox.TabIndex = 3;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.contableDataSet;
            // 
            // contableDataSet
            // 
            this.contableDataSet.DataSetName = "ContableDataSet";
            this.contableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresaBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(97, 16);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DeduciblesTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.EmpresaTableAdapter = this.empresaTableAdapter;
            this.tableAdapterManager.RecibosTableAdapter = null;
            this.tableAdapterManager.ServiciosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DISE.ContableDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // empresaBindingNavigator
            // 
            this.empresaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.empresaBindingNavigator.BindingSource = this.empresaBindingSource;
            this.empresaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.empresaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.empresaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.empresaBindingNavigatorSaveItem});
            this.empresaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.empresaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.empresaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.empresaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.empresaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.empresaBindingNavigator.Name = "empresaBindingNavigator";
            this.empresaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.empresaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.empresaBindingNavigator.TabIndex = 1;
            this.empresaBindingNavigator.Text = "bindingNavigator1";
            this.empresaBindingNavigator.Visible = false;
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // empresaBindingNavigatorSaveItem
            // 
            this.empresaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empresaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("empresaBindingNavigatorSaveItem.Image")));
            this.empresaBindingNavigatorSaveItem.Name = "empresaBindingNavigatorSaveItem";
            this.empresaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.empresaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.empresaBindingNavigatorSaveItem.Click += new System.EventHandler(this.empresaBindingNavigatorSaveItem_Click);
            // 
            // panelEmpleado
            // 
            this.panelEmpleado.Controls.Add(this.CodEmpresa);
            this.panelEmpleado.Controls.Add(this.btcancel2);
            this.panelEmpleado.Controls.Add(this.btaddEmpleado);
            this.panelEmpleado.Controls.Add(codEmpresaLabel);
            this.panelEmpleado.Controls.Add(legajoLabel);
            this.panelEmpleado.Controls.Add(this.legajoTextBox);
            this.panelEmpleado.Controls.Add(cUILLabel);
            this.panelEmpleado.Controls.Add(this.cUILTextBox);
            this.panelEmpleado.Controls.Add(nombreCompletoLabel);
            this.panelEmpleado.Controls.Add(this.nombreCompletoTextBox);
            this.panelEmpleado.Location = new System.Drawing.Point(249, 59);
            this.panelEmpleado.Name = "panelEmpleado";
            this.panelEmpleado.Size = new System.Drawing.Size(251, 217);
            this.panelEmpleado.TabIndex = 3;
            this.panelEmpleado.Visible = false;
            // 
            // CodEmpresa
            // 
            this.CodEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empresaBindingSource, "CodEmpresa", true));
            this.CodEmpresa.DataSource = this.empresaBindingSource;
            this.CodEmpresa.DisplayMember = "nombre";
            this.CodEmpresa.FormattingEnabled = true;
            this.CodEmpresa.Location = new System.Drawing.Point(129, 116);
            this.CodEmpresa.Name = "CodEmpresa";
            this.CodEmpresa.Size = new System.Drawing.Size(100, 21);
            this.CodEmpresa.TabIndex = 10;
            this.CodEmpresa.ValueMember = "CodEmpresa";
            this.CodEmpresa.SelectedIndexChanged += new System.EventHandler(this.CodEmpresa_SelectedIndexChanged);
            // 
            // btcancel2
            // 
            this.btcancel2.Location = new System.Drawing.Point(140, 171);
            this.btcancel2.Name = "btcancel2";
            this.btcancel2.Size = new System.Drawing.Size(75, 23);
            this.btcancel2.TabIndex = 9;
            this.btcancel2.Text = "&Cancelar";
            this.btcancel2.UseVisualStyleBackColor = true;
            // 
            // btaddEmpleado
            // 
            this.btaddEmpleado.Location = new System.Drawing.Point(38, 171);
            this.btaddEmpleado.Name = "btaddEmpleado";
            this.btaddEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btaddEmpleado.TabIndex = 8;
            this.btaddEmpleado.Text = "&Agregar";
            this.btaddEmpleado.UseVisualStyleBackColor = true;
            this.btaddEmpleado.Click += new System.EventHandler(this.btaddEmpleado_Click);
            // 
            // legajoTextBox
            // 
            this.legajoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Legajo", true));
            this.legajoTextBox.Location = new System.Drawing.Point(129, 85);
            this.legajoTextBox.Name = "legajoTextBox";
            this.legajoTextBox.Size = new System.Drawing.Size(100, 20);
            this.legajoTextBox.TabIndex = 5;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.contableDataSet;
            // 
            // cUILTextBox
            // 
            this.cUILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "CUIL", true));
            this.cUILTextBox.Location = new System.Drawing.Point(129, 59);
            this.cUILTextBox.Name = "cUILTextBox";
            this.cUILTextBox.Size = new System.Drawing.Size(100, 20);
            this.cUILTextBox.TabIndex = 3;
            // 
            // nombreCompletoTextBox
            // 
            this.nombreCompletoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "NombreCompleto", true));
            this.nombreCompletoTextBox.Location = new System.Drawing.Point(129, 33);
            this.nombreCompletoTextBox.Name = "nombreCompletoTextBox";
            this.nombreCompletoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreCompletoTextBox.TabIndex = 1;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // panelSup
            // 
            this.panelSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelSup.Controls.Add(this.pictureBox2);
            this.panelSup.Controls.Add(this.pictureBox1);
            this.panelSup.Controls.Add(this.picCerrar);
            this.panelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSup.Location = new System.Drawing.Point(0, 0);
            this.panelSup.Name = "panelSup";
            this.panelSup.Size = new System.Drawing.Size(1043, 34);
            this.panelSup.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(950, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(982, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // picCerrar
            // 
            this.picCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picCerrar.Image")));
            this.picCerrar.Location = new System.Drawing.Point(1014, 12);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(26, 22);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 0;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelIzq
            // 
            this.panelIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelIzq.Controls.Add(this.panelDet2);
            this.panelIzq.Controls.Add(this.subPanel2);
            this.panelIzq.Controls.Add(this.panelDet);
            this.panelIzq.Controls.Add(this.panelDet1);
            this.panelIzq.Controls.Add(this.btAdministrar);
            this.panelIzq.Controls.Add(this.subPanel1);
            this.panelIzq.Controls.Add(this.btEmpresa);
            this.panelIzq.Controls.Add(this.panelLogo);
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Location = new System.Drawing.Point(0, 34);
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(200, 493);
            this.panelIzq.TabIndex = 6;
            // 
            // panelDet2
            // 
            this.panelDet2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelDet2.Location = new System.Drawing.Point(0, 103);
            this.panelDet2.Name = "panelDet2";
            this.panelDet2.Size = new System.Drawing.Size(10, 42);
            this.panelDet2.TabIndex = 1;
            // 
            // subPanel2
            // 
            this.subPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanel2.Location = new System.Drawing.Point(0, 353);
            this.subPanel2.Name = "subPanel2";
            this.subPanel2.Size = new System.Drawing.Size(200, 122);
            this.subPanel2.TabIndex = 0;
            // 
            // panelDet
            // 
            this.panelDet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelDet.Location = new System.Drawing.Point(0, 60);
            this.panelDet.Name = "panelDet";
            this.panelDet.Size = new System.Drawing.Size(10, 43);
            this.panelDet.TabIndex = 7;
            // 
            // panelDet1
            // 
            this.panelDet1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelDet1.Location = new System.Drawing.Point(0, 310);
            this.panelDet1.Name = "panelDet1";
            this.panelDet1.Size = new System.Drawing.Size(10, 43);
            this.panelDet1.TabIndex = 0;
            this.panelDet1.Visible = false;
            // 
            // btAdministrar
            // 
            this.btAdministrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAdministrar.FlatAppearance.BorderSize = 0;
            this.btAdministrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdministrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdministrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAdministrar.Image = ((System.Drawing.Image)(resources.GetObject("btAdministrar.Image")));
            this.btAdministrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdministrar.Location = new System.Drawing.Point(0, 310);
            this.btAdministrar.Name = "btAdministrar";
            this.btAdministrar.Size = new System.Drawing.Size(200, 43);
            this.btAdministrar.TabIndex = 6;
            this.btAdministrar.Text = "&Administrar";
            this.btAdministrar.UseVisualStyleBackColor = true;
            // 
            // subPanel1
            // 
            this.subPanel1.Controls.Add(this.edEmpleado);
            this.subPanel1.Controls.Add(this.addEmpleado);
            this.subPanel1.Controls.Add(this.edEmpresa);
            this.subPanel1.Controls.Add(this.btEmpresaAdd);
            this.subPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanel1.Location = new System.Drawing.Point(0, 105);
            this.subPanel1.Name = "subPanel1";
            this.subPanel1.Size = new System.Drawing.Size(200, 205);
            this.subPanel1.TabIndex = 2;
            this.subPanel1.Visible = false;
            // 
            // edEmpleado
            // 
            this.edEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.edEmpleado.FlatAppearance.BorderSize = 0;
            this.edEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edEmpleado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edEmpleado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.edEmpleado.Location = new System.Drawing.Point(0, 129);
            this.edEmpleado.Name = "edEmpleado";
            this.edEmpleado.Size = new System.Drawing.Size(200, 43);
            this.edEmpleado.TabIndex = 5;
            this.edEmpleado.Text = "&Editar Empleado";
            this.edEmpleado.UseVisualStyleBackColor = true;
            // 
            // addEmpleado
            // 
            this.addEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.addEmpleado.FlatAppearance.BorderSize = 0;
            this.addEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpleado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpleado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addEmpleado.Location = new System.Drawing.Point(0, 86);
            this.addEmpleado.Name = "addEmpleado";
            this.addEmpleado.Size = new System.Drawing.Size(200, 43);
            this.addEmpleado.TabIndex = 4;
            this.addEmpleado.Text = "&Agregar Empleado";
            this.addEmpleado.UseVisualStyleBackColor = true;
            this.addEmpleado.Click += new System.EventHandler(this.addEmpleado_Click);
            // 
            // edEmpresa
            // 
            this.edEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.edEmpresa.FlatAppearance.BorderSize = 0;
            this.edEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edEmpresa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edEmpresa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.edEmpresa.Location = new System.Drawing.Point(0, 43);
            this.edEmpresa.Name = "edEmpresa";
            this.edEmpresa.Size = new System.Drawing.Size(200, 43);
            this.edEmpresa.TabIndex = 3;
            this.edEmpresa.Text = "&Editar Empresa";
            this.edEmpresa.UseVisualStyleBackColor = true;
            // 
            // btEmpresaAdd
            // 
            this.btEmpresaAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEmpresaAdd.FlatAppearance.BorderSize = 0;
            this.btEmpresaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmpresaAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmpresaAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btEmpresaAdd.Location = new System.Drawing.Point(0, 0);
            this.btEmpresaAdd.Name = "btEmpresaAdd";
            this.btEmpresaAdd.Size = new System.Drawing.Size(200, 43);
            this.btEmpresaAdd.TabIndex = 2;
            this.btEmpresaAdd.Text = "&Agregar Empresa";
            this.btEmpresaAdd.UseVisualStyleBackColor = true;
            this.btEmpresaAdd.Click += new System.EventHandler(this.btEmpresaAdd_Click);
            // 
            // btEmpresa
            // 
            this.btEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEmpresa.FlatAppearance.BorderSize = 0;
            this.btEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEmpresa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmpresa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btEmpresa.Image")));
            this.btEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEmpresa.Location = new System.Drawing.Point(0, 62);
            this.btEmpresa.Name = "btEmpresa";
            this.btEmpresa.Size = new System.Drawing.Size(200, 43);
            this.btEmpresa.TabIndex = 1;
            this.btEmpresa.Text = "&Empresa";
            this.btEmpresa.UseVisualStyleBackColor = true;
            this.btEmpresa.Click += new System.EventHandler(this.btEmpresa_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 62);
            this.panelLogo.TabIndex = 0;
            // 
            // panelDeduc
            // 
            this.panelDeduc.Controls.Add(this.deducCancel);
            this.panelDeduc.Controls.Add(this.addDeducibles);
            this.panelDeduc.Controls.Add(fechaMatLabel);
            this.panelDeduc.Controls.Add(this.fechaMatTextBox);
            this.panelDeduc.Controls.Add(fechaNacLabel);
            this.panelDeduc.Controls.Add(this.fechaNacTextBox);
            this.panelDeduc.Controls.Add(this.label5);
            this.panelDeduc.Controls.Add(this.label3);
            this.panelDeduc.Controls.Add(this.label1);
            this.panelDeduc.Controls.Add(this.monthCalendar1);
            this.panelDeduc.Controls.Add(this.acargo);
            this.panelDeduc.Controls.Add(this.estCivil);
            this.panelDeduc.Controls.Add(this.cantHijos);
            this.panelDeduc.Location = new System.Drawing.Point(514, 60);
            this.panelDeduc.Name = "panelDeduc";
            this.panelDeduc.Size = new System.Drawing.Size(517, 216);
            this.panelDeduc.TabIndex = 7;
            this.panelDeduc.Visible = false;
            this.panelDeduc.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDeduc_Paint);
            // 
            // deducCancel
            // 
            this.deducCancel.Location = new System.Drawing.Point(217, 180);
            this.deducCancel.Name = "deducCancel";
            this.deducCancel.Size = new System.Drawing.Size(75, 23);
            this.deducCancel.TabIndex = 14;
            this.deducCancel.Text = "&Cancel";
            this.deducCancel.UseVisualStyleBackColor = true;
            // 
            // addDeducibles
            // 
            this.addDeducibles.Location = new System.Drawing.Point(127, 180);
            this.addDeducibles.Name = "addDeducibles";
            this.addDeducibles.Size = new System.Drawing.Size(75, 23);
            this.addDeducibles.TabIndex = 13;
            this.addDeducibles.Text = "&Agregar";
            this.addDeducibles.UseVisualStyleBackColor = true;
            this.addDeducibles.Click += new System.EventHandler(this.addDeducibles_Click);
            // 
            // fechaMatTextBox
            // 
            this.fechaMatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deduciblesBindingSource, "fechaMat", true));
            this.fechaMatTextBox.Location = new System.Drawing.Point(127, 106);
            this.fechaMatTextBox.Name = "fechaMatTextBox";
            this.fechaMatTextBox.Size = new System.Drawing.Size(165, 20);
            this.fechaMatTextBox.TabIndex = 12;
            this.fechaMatTextBox.TextChanged += new System.EventHandler(this.fechaMatTextBox_TextChanged);
            // 
            // deduciblesBindingSource
            // 
            this.deduciblesBindingSource.DataMember = "Deducibles";
            this.deduciblesBindingSource.DataSource = this.contableDataSet;
            // 
            // fechaNacTextBox
            // 
            this.fechaNacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deduciblesBindingSource, "fechaNac", true));
            this.fechaNacTextBox.Location = new System.Drawing.Point(127, 48);
            this.fechaNacTextBox.Name = "fechaNacTextBox";
            this.fechaNacTextBox.Size = new System.Drawing.Size(165, 20);
            this.fechaNacTextBox.TabIndex = 11;
            this.fechaNacTextBox.TextChanged += new System.EventHandler(this.fechaNacTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Familiares a cargo : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estado Civil : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad de hijos :";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(304, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // acargo
            // 
            this.acargo.FormattingEnabled = true;
            this.acargo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.acargo.Location = new System.Drawing.Point(127, 139);
            this.acargo.Name = "acargo";
            this.acargo.Size = new System.Drawing.Size(165, 21);
            this.acargo.TabIndex = 4;
            // 
            // estCivil
            // 
            this.estCivil.FormattingEnabled = true;
            this.estCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Divorciado/a"});
            this.estCivil.Location = new System.Drawing.Point(127, 77);
            this.estCivil.Name = "estCivil";
            this.estCivil.Size = new System.Drawing.Size(165, 21);
            this.estCivil.TabIndex = 2;
            this.estCivil.SelectedIndexChanged += new System.EventHandler(this.estCivil_SelectedIndexChanged);
            // 
            // cantHijos
            // 
            this.cantHijos.FormattingEnabled = true;
            this.cantHijos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cantHijos.Location = new System.Drawing.Point(127, 16);
            this.cantHijos.Name = "cantHijos";
            this.cantHijos.Size = new System.Drawing.Size(165, 21);
            this.cantHijos.TabIndex = 0;
            // 
            // deduciblesTableAdapter
            // 
            this.deduciblesTableAdapter.ClearBeforeFill = true;
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCentral.Location = new System.Drawing.Point(0, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1043, 527);
            this.panelCentral.TabIndex = 8;
            this.panelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCentral_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 527);
            this.Controls.Add(this.panelDeduc);
            this.Controls.Add(this.panelIzq);
            this.Controls.Add(this.panelSup);
            this.Controls.Add(this.panelEmpleado);
            this.Controls.Add(this.panelEmpresa);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.empresaBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEmpresa.ResumeLayout(false);
            this.panelEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingNavigator)).EndInit();
            this.empresaBindingNavigator.ResumeLayout(false);
            this.empresaBindingNavigator.PerformLayout();
            this.panelEmpleado.ResumeLayout(false);
            this.panelEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            this.panelSup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.panelIzq.ResumeLayout(false);
            this.subPanel1.ResumeLayout(false);
            this.panelDeduc.ResumeLayout(false);
            this.panelDeduc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deduciblesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEmpresa;
        private ContableDataSet contableDataSet;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private ContableDataSetTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private ContableDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator empresaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton empresaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button btCancel1;
        private System.Windows.Forms.Button btAddEmpresa;
        private System.Windows.Forms.TextBox cUITTextBox;
        private System.Windows.Forms.Panel panelEmpleado;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private ContableDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.Button btcancel2;
        private System.Windows.Forms.Button btaddEmpleado;
        private System.Windows.Forms.TextBox legajoTextBox;
        private System.Windows.Forms.TextBox cUILTextBox;
        private System.Windows.Forms.TextBox nombreCompletoTextBox;
        private System.Windows.Forms.Panel panelSup;
        private System.Windows.Forms.Panel panelIzq;
        private System.Windows.Forms.Panel subPanel1;
        private System.Windows.Forms.Button btEmpresa;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button edEmpleado;
        private System.Windows.Forms.Button addEmpleado;
        private System.Windows.Forms.Button edEmpresa;
        private System.Windows.Forms.Button btEmpresaAdd;
        private System.Windows.Forms.Panel panelDeduc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox acargo;
        private System.Windows.Forms.ComboBox estCivil;
        private System.Windows.Forms.ComboBox cantHijos;
        private System.Windows.Forms.BindingSource deduciblesBindingSource;
        private ContableDataSetTableAdapters.DeduciblesTableAdapter deduciblesTableAdapter;
        private System.Windows.Forms.TextBox fechaMatTextBox;
        private System.Windows.Forms.TextBox fechaNacTextBox;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Button deducCancel;
        private System.Windows.Forms.Button addDeducibles;
        private System.Windows.Forms.Button btAdministrar;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDet;
        private System.Windows.Forms.Panel panelDet1;
        private System.Windows.Forms.Panel subPanel2;
        private System.Windows.Forms.Panel panelDet2;
        private System.Windows.Forms.ComboBox CodEmpresa;
    }
}

