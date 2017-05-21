namespace CompiladorApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabControlDescripcion = new System.Windows.Forms.TabPage();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCompiladorApp = new System.Windows.Forms.Label();
            this.tabControlCompilador = new System.Windows.Forms.TabPage();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.clmVariables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtEditorTexto = new System.Windows.Forms.TextBox();
            this.pnlNavegacion = new System.Windows.Forms.Panel();
            this.rdbIntegrantes = new System.Windows.Forms.RadioButton();
            this.rdbCompilador = new System.Windows.Forms.RadioButton();
            this.rdbDescripcion = new System.Windows.Forms.RadioButton();
            this.tabControl.SuspendLayout();
            this.tabControlDescripcion.SuspendLayout();
            this.tabControlCompilador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.pnlNavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabControlDescripcion);
            this.tabControl.Controls.Add(this.tabControlCompilador);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(823, 484);
            this.tabControl.TabIndex = 0;
            // 
            // tabControlDescripcion
            // 
            this.tabControlDescripcion.Controls.Add(this.lblCopyright);
            this.tabControlDescripcion.Controls.Add(this.lblAuthor);
            this.tabControlDescripcion.Controls.Add(this.txtDescripcion);
            this.tabControlDescripcion.Controls.Add(this.lblVersion);
            this.tabControlDescripcion.Controls.Add(this.lblCategoria);
            this.tabControlDescripcion.Controls.Add(this.lblCompiladorApp);
            this.tabControlDescripcion.Location = new System.Drawing.Point(4, 29);
            this.tabControlDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.tabControlDescripcion.Name = "tabControlDescripcion";
            this.tabControlDescripcion.Padding = new System.Windows.Forms.Padding(5);
            this.tabControlDescripcion.Size = new System.Drawing.Size(815, 451);
            this.tabControlDescripcion.TabIndex = 0;
            this.tabControlDescripcion.Text = "  ";
            this.tabControlDescripcion.UseVisualStyleBackColor = true;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.Black;
            this.lblCopyright.Location = new System.Drawing.Point(276, 432);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(20, 20);
            this.lblCopyright.TabIndex = 6;
            this.lblCopyright.Text = "©";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.Black;
            this.lblAuthor.Location = new System.Drawing.Point(294, 435);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(259, 16);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "2017 Felix M.P.  Alexander N.G.  Victor E.B.";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(137, 239);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(541, 67);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.Text = resources.GetString("txtDescripcion.Text");
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Location = new System.Drawing.Point(133, 168);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(100, 20);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Version 1.0";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(133, 137);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(178, 20);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Standalone Software";
            // 
            // lblCompiladorApp
            // 
            this.lblCompiladorApp.AutoSize = true;
            this.lblCompiladorApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompiladorApp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCompiladorApp.Location = new System.Drawing.Point(127, 89);
            this.lblCompiladorApp.Name = "lblCompiladorApp";
            this.lblCompiladorApp.Size = new System.Drawing.Size(253, 37);
            this.lblCompiladorApp.TabIndex = 0;
            this.lblCompiladorApp.Text = "CompiladorApp";
            // 
            // tabControlCompilador
            // 
            this.tabControlCompilador.Controls.Add(this.dgvResultado);
            this.tabControlCompilador.Controls.Add(this.btnLimpiar);
            this.tabControlCompilador.Controls.Add(this.txtEditorTexto);
            this.tabControlCompilador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlCompilador.ForeColor = System.Drawing.Color.Black;
            this.tabControlCompilador.Location = new System.Drawing.Point(4, 29);
            this.tabControlCompilador.Margin = new System.Windows.Forms.Padding(5);
            this.tabControlCompilador.Name = "tabControlCompilador";
            this.tabControlCompilador.Padding = new System.Windows.Forms.Padding(5);
            this.tabControlCompilador.Size = new System.Drawing.Size(815, 451);
            this.tabControlCompilador.TabIndex = 1;
            this.tabControlCompilador.Text = "tabPage2";
            this.tabControlCompilador.UseVisualStyleBackColor = true;
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmVariables,
            this.clmResultado});
            this.dgvResultado.Location = new System.Drawing.Point(23, 114);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(768, 275);
            this.dgvResultado.TabIndex = 3;
            // 
            // clmVariables
            // 
            this.clmVariables.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmVariables.HeaderText = "Variables";
            this.clmVariables.Name = "clmVariables";
            this.clmVariables.Width = 93;
            // 
            // clmResultado
            // 
            this.clmResultado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmResultado.HeaderText = "Resultado";
            this.clmResultado.Name = "clmResultado";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::CompiladorApp.Properties.Resources.Clear2;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(339, 403);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 40);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtEditorTexto
            // 
            this.txtEditorTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorTexto.Location = new System.Drawing.Point(23, 61);
            this.txtEditorTexto.Name = "txtEditorTexto";
            this.txtEditorTexto.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtEditorTexto.Size = new System.Drawing.Size(768, 26);
            this.txtEditorTexto.TabIndex = 0;
            this.txtEditorTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditorTexto_KeyPress);
            // 
            // pnlNavegacion
            // 
            this.pnlNavegacion.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlNavegacion.Controls.Add(this.rdbIntegrantes);
            this.pnlNavegacion.Controls.Add(this.rdbCompilador);
            this.pnlNavegacion.Controls.Add(this.rdbDescripcion);
            this.pnlNavegacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavegacion.Location = new System.Drawing.Point(0, 0);
            this.pnlNavegacion.Margin = new System.Windows.Forms.Padding(5);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Size = new System.Drawing.Size(823, 69);
            this.pnlNavegacion.TabIndex = 2;
            // 
            // rdbIntegrantes
            // 
            this.rdbIntegrantes.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbIntegrantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbIntegrantes.FlatAppearance.BorderSize = 0;
            this.rdbIntegrantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.rdbIntegrantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.rdbIntegrantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbIntegrantes.ForeColor = System.Drawing.Color.White;
            this.rdbIntegrantes.Location = new System.Drawing.Point(238, 0);
            this.rdbIntegrantes.Name = "rdbIntegrantes";
            this.rdbIntegrantes.Size = new System.Drawing.Size(121, 69);
            this.rdbIntegrantes.TabIndex = 2;
            this.rdbIntegrantes.TabStop = true;
            this.rdbIntegrantes.Text = "Integrantes";
            this.rdbIntegrantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbIntegrantes.UseVisualStyleBackColor = true;
            this.rdbIntegrantes.Click += new System.EventHandler(this.rdbIntegrantes_Click);
            // 
            // rdbCompilador
            // 
            this.rdbCompilador.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbCompilador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbCompilador.FlatAppearance.BorderSize = 0;
            this.rdbCompilador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.rdbCompilador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.rdbCompilador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbCompilador.ForeColor = System.Drawing.Color.White;
            this.rdbCompilador.Location = new System.Drawing.Point(121, 0);
            this.rdbCompilador.Name = "rdbCompilador";
            this.rdbCompilador.Size = new System.Drawing.Size(120, 69);
            this.rdbCompilador.TabIndex = 1;
            this.rdbCompilador.TabStop = true;
            this.rdbCompilador.Text = "Compilador";
            this.rdbCompilador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbCompilador.UseVisualStyleBackColor = true;
            this.rdbCompilador.CheckedChanged += new System.EventHandler(this.rdbCompilador_CheckedChanged);
            // 
            // rdbDescripcion
            // 
            this.rdbDescripcion.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbDescripcion.Checked = true;
            this.rdbDescripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbDescripcion.FlatAppearance.BorderSize = 0;
            this.rdbDescripcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.rdbDescripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.rdbDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbDescripcion.ForeColor = System.Drawing.Color.White;
            this.rdbDescripcion.Location = new System.Drawing.Point(12, 0);
            this.rdbDescripcion.Name = "rdbDescripcion";
            this.rdbDescripcion.Size = new System.Drawing.Size(112, 69);
            this.rdbDescripcion.TabIndex = 0;
            this.rdbDescripcion.TabStop = true;
            this.rdbDescripcion.Text = "Descripción";
            this.rdbDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbDescripcion.UseVisualStyleBackColor = true;
            this.rdbDescripcion.CheckedChanged += new System.EventHandler(this.rdbDescripcion_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 484);
            this.Controls.Add(this.pnlNavegacion);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompiladorApp";
            this.tabControl.ResumeLayout(false);
            this.tabControlDescripcion.ResumeLayout(false);
            this.tabControlDescripcion.PerformLayout();
            this.tabControlCompilador.ResumeLayout(false);
            this.tabControlCompilador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.pnlNavegacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabControlDescripcion;
        private System.Windows.Forms.TabPage tabControlCompilador;
        private System.Windows.Forms.Panel pnlNavegacion;
        private System.Windows.Forms.RadioButton rdbDescripcion;
        private System.Windows.Forms.RadioButton rdbIntegrantes;
        private System.Windows.Forms.RadioButton rdbCompilador;
        private System.Windows.Forms.TextBox txtEditorTexto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVariables;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmResultado;
        private System.Windows.Forms.Label lblCompiladorApp;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCopyright;
    }
}

