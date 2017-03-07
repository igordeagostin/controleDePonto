namespace Ponto.Telas
{
    partial class TelaFuncionarios
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
            this.buttonIncuirFuncionario = new System.Windows.Forms.Button();
            this.dataGridViewFuncionarios = new System.Windows.Forms.DataGridView();
            this.buttonAlterarFuncionario = new System.Windows.Forms.Button();
            this.buttonExcluirFuncionario = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.cargaHorariaDiariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaHorariaSemanalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIncuirFuncionario
            // 
            this.buttonIncuirFuncionario.Location = new System.Drawing.Point(12, 12);
            this.buttonIncuirFuncionario.Name = "buttonIncuirFuncionario";
            this.buttonIncuirFuncionario.Size = new System.Drawing.Size(75, 23);
            this.buttonIncuirFuncionario.TabIndex = 0;
            this.buttonIncuirFuncionario.Text = "Incluir";
            this.buttonIncuirFuncionario.UseVisualStyleBackColor = true;
            this.buttonIncuirFuncionario.Click += new System.EventHandler(this.buttonIncuirFuncionario_Click);
            // 
            // dataGridViewFuncionarios
            // 
            this.dataGridViewFuncionarios.AllowUserToAddRows = false;
            this.dataGridViewFuncionarios.AllowUserToDeleteRows = false;
            this.dataGridViewFuncionarios.AutoGenerateColumns = false;
            this.dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.cargaHorariaDiariaDataGridViewTextBoxColumn,
            this.cargaHorariaSemanalDataGridViewTextBoxColumn,
            this.admissaoDataGridViewTextBoxColumn,
            this.demissaoDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn,
            this.funcaoDataGridViewTextBoxColumn,
            this.departamentoDataGridViewTextBoxColumn,
            this.historicosDataGridViewTextBoxColumn});
            this.dataGridViewFuncionarios.DataSource = this.funcionarioBindingSource;
            this.dataGridViewFuncionarios.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            this.dataGridViewFuncionarios.ReadOnly = true;
            this.dataGridViewFuncionarios.Size = new System.Drawing.Size(984, 409);
            this.dataGridViewFuncionarios.TabIndex = 1;
            this.dataGridViewFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFuncionarios_CellClick);
            this.dataGridViewFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFuncionarios_CellDoubleClick);
            // 
            // buttonAlterarFuncionario
            // 
            this.buttonAlterarFuncionario.Location = new System.Drawing.Point(93, 12);
            this.buttonAlterarFuncionario.Name = "buttonAlterarFuncionario";
            this.buttonAlterarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarFuncionario.TabIndex = 2;
            this.buttonAlterarFuncionario.Text = "Alterar";
            this.buttonAlterarFuncionario.UseVisualStyleBackColor = true;
            this.buttonAlterarFuncionario.Click += new System.EventHandler(this.buttonAlterarFuncionario_Click);
            // 
            // buttonExcluirFuncionario
            // 
            this.buttonExcluirFuncionario.Location = new System.Drawing.Point(174, 12);
            this.buttonExcluirFuncionario.Name = "buttonExcluirFuncionario";
            this.buttonExcluirFuncionario.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirFuncionario.TabIndex = 3;
            this.buttonExcluirFuncionario.Text = "Excluir";
            this.buttonExcluirFuncionario.UseVisualStyleBackColor = true;
            this.buttonExcluirFuncionario.Click += new System.EventHandler(this.buttonExcluirFuncionario_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "Senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "Foto";
            this.fotoDataGridViewImageColumn.HeaderText = "Foto";
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            this.fotoDataGridViewImageColumn.ReadOnly = true;
            // 
            // cargaHorariaDiariaDataGridViewTextBoxColumn
            // 
            this.cargaHorariaDiariaDataGridViewTextBoxColumn.DataPropertyName = "CargaHorariaDiaria";
            this.cargaHorariaDiariaDataGridViewTextBoxColumn.HeaderText = "CargaHorariaDiaria";
            this.cargaHorariaDiariaDataGridViewTextBoxColumn.Name = "cargaHorariaDiariaDataGridViewTextBoxColumn";
            this.cargaHorariaDiariaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargaHorariaSemanalDataGridViewTextBoxColumn
            // 
            this.cargaHorariaSemanalDataGridViewTextBoxColumn.DataPropertyName = "CargaHorariaSemanal";
            this.cargaHorariaSemanalDataGridViewTextBoxColumn.HeaderText = "CargaHorariaSemanal";
            this.cargaHorariaSemanalDataGridViewTextBoxColumn.Name = "cargaHorariaSemanalDataGridViewTextBoxColumn";
            this.cargaHorariaSemanalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // admissaoDataGridViewTextBoxColumn
            // 
            this.admissaoDataGridViewTextBoxColumn.DataPropertyName = "Admissao";
            this.admissaoDataGridViewTextBoxColumn.HeaderText = "Admissao";
            this.admissaoDataGridViewTextBoxColumn.Name = "admissaoDataGridViewTextBoxColumn";
            this.admissaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // demissaoDataGridViewTextBoxColumn
            // 
            this.demissaoDataGridViewTextBoxColumn.DataPropertyName = "Demissao";
            this.demissaoDataGridViewTextBoxColumn.HeaderText = "Demissao";
            this.demissaoDataGridViewTextBoxColumn.Name = "demissaoDataGridViewTextBoxColumn";
            this.demissaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "Situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situacao";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcaoDataGridViewTextBoxColumn
            // 
            this.funcaoDataGridViewTextBoxColumn.DataPropertyName = "Funcao";
            this.funcaoDataGridViewTextBoxColumn.HeaderText = "Funcao";
            this.funcaoDataGridViewTextBoxColumn.Name = "funcaoDataGridViewTextBoxColumn";
            this.funcaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departamentoDataGridViewTextBoxColumn
            // 
            this.departamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento";
            this.departamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.departamentoDataGridViewTextBoxColumn.Name = "departamentoDataGridViewTextBoxColumn";
            this.departamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // historicosDataGridViewTextBoxColumn
            // 
            this.historicosDataGridViewTextBoxColumn.DataPropertyName = "Historicos";
            this.historicosDataGridViewTextBoxColumn.HeaderText = "Historicos";
            this.historicosDataGridViewTextBoxColumn.Name = "historicosDataGridViewTextBoxColumn";
            this.historicosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(Ponto.Entidades.Funcionario);
            // 
            // TelaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 462);
            this.Controls.Add(this.buttonExcluirFuncionario);
            this.Controls.Add(this.buttonAlterarFuncionario);
            this.Controls.Add(this.dataGridViewFuncionarios);
            this.Controls.Add(this.buttonIncuirFuncionario);
            this.Name = "TelaFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIncuirFuncionario;
        private System.Windows.Forms.DataGridView dataGridViewFuncionarios;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.Button buttonAlterarFuncionario;
        private System.Windows.Forms.Button buttonExcluirFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaHorariaDiariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaHorariaSemanalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicosDataGridViewTextBoxColumn;
    }
}