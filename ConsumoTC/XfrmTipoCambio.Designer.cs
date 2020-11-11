namespace ConsumoTC
{
    partial class XfrmTipoCambio
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
            if(disposing && (components != null))
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
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfrmTipoCambio));
            this.btn_Consultar = new DevExpress.XtraEditors.SimpleButton();
            this.dt_fecha = new DevExpress.XtraEditors.DateEdit();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dt_hasta = new DevExpress.XtraEditors.DateEdit();
            this.dt_desde = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grid_resultados = new DevExpress.XtraGrid.GridControl();
            this.gv_resultados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_tc_dia = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_resultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_resultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tc_dia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(572, 24);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(94, 20);
            this.btn_Consultar.TabIndex = 0;
            this.btn_Consultar.Text = "CONSULTAR";
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // dt_fecha
            // 
            this.dt_fecha.EditValue = null;
            this.dt_fecha.Location = new System.Drawing.Point(434, 26);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dt_fecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_fecha.Properties.CalendarTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dt_fecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_fecha.Properties.CalendarTimeProperties.Mask.EditMask = "d";
            this.dt_fecha.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_fecha.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.dt_fecha.Size = new System.Drawing.Size(132, 20);
            this.dt_fecha.TabIndex = 1;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(5, 26);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Mes"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Dia"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Rango")});
            this.radioGroup1.Size = new System.Drawing.Size(189, 31);
            this.radioGroup1.TabIndex = 2;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.dt_hasta);
            this.groupControl1.Controls.Add(this.dt_desde);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.grid_resultados);
            this.groupControl1.Controls.Add(this.txt_tc_dia);
            this.groupControl1.Controls.Add(this.btn_Consultar);
            this.groupControl1.Controls.Add(this.radioGroup1);
            this.groupControl1.Controls.Add(this.dt_fecha);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(727, 435);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Datos (Servicio Web Brindado por BANCO CENTRAL DE NICARAGUA [https://servicios.bc" +
    "n.gob.ni/])";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(219, 65);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Hasta";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(219, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Desde";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(393, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Fecha";
            // 
            // dt_hasta
            // 
            this.dt_hasta.EditValue = null;
            this.dt_hasta.Location = new System.Drawing.Point(260, 58);
            this.dt_hasta.Name = "dt_hasta";
            this.dt_hasta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dt_hasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_hasta.Properties.CalendarTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dt_hasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_hasta.Properties.CalendarTimeProperties.Mask.EditMask = "d";
            this.dt_hasta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_hasta.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.dt_hasta.Size = new System.Drawing.Size(118, 20);
            this.dt_hasta.TabIndex = 9;
            // 
            // dt_desde
            // 
            this.dt_desde.EditValue = null;
            this.dt_desde.Location = new System.Drawing.Point(260, 26);
            this.dt_desde.Name = "dt_desde";
            this.dt_desde.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dt_desde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_desde.Properties.CalendarTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dt_desde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_desde.Properties.CalendarTimeProperties.Mask.EditMask = "d";
            this.dt_desde.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dt_desde.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.dt_desde.Size = new System.Drawing.Size(118, 20);
            this.dt_desde.TabIndex = 8;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(572, 49);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(154, 23);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "SELECCIONAR Y COPIAR";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(573, 75);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "EXPORTAR EXCEL";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(394, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "T/C Dia";
            // 
            // grid_resultados
            // 
            this.grid_resultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_resultados.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grid_resultados.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grid_resultados.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grid_resultados.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grid_resultados.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grid_resultados.Location = new System.Drawing.Point(5, 100);
            this.grid_resultados.MainView = this.gv_resultados;
            this.grid_resultados.Name = "grid_resultados";
            this.grid_resultados.Size = new System.Drawing.Size(717, 323);
            this.grid_resultados.TabIndex = 4;
            this.grid_resultados.UseEmbeddedNavigator = true;
            this.grid_resultados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_resultados});
            // 
            // gv_resultados
            // 
            this.gv_resultados.GridControl = this.grid_resultados;
            this.gv_resultados.Name = "gv_resultados";
            this.gv_resultados.OptionsBehavior.Editable = false;
            this.gv_resultados.OptionsCustomization.AllowGroup = false;
            this.gv_resultados.OptionsView.ShowFooter = true;
            this.gv_resultados.OptionsView.ShowGroupPanel = false;
            // 
            // txt_tc_dia
            // 
            this.txt_tc_dia.Location = new System.Drawing.Point(435, 58);
            this.txt_tc_dia.Name = "txt_tc_dia";
            this.txt_tc_dia.Properties.Mask.EditMask = "n4";
            this.txt_tc_dia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_tc_dia.Size = new System.Drawing.Size(132, 20);
            this.txt_tc_dia.TabIndex = 3;
            // 
            // XfrmTipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 435);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("XfrmTipoCambio.IconOptions.LargeImage")));
            this.Name = "XfrmTipoCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obtener Tipo de Cambio";
            this.Load += new System.EventHandler(this.XfrmTipoCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_fecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_hasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_desde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_resultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_resultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tc_dia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Consultar;
        private DevExpress.XtraEditors.DateEdit dt_fecha;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grid_resultados;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_resultados;
        private DevExpress.XtraEditors.TextEdit txt_tc_dia;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.DateEdit dt_hasta;
        private DevExpress.XtraEditors.DateEdit dt_desde;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}