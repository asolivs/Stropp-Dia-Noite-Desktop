namespace TCCSTROOP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimeDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.checkBoxMisto = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbExperimentador = new System.Windows.Forms.TextBox();
            this.txtbPaciente = new System.Windows.Forms.TextBox();
            this.checkBoxInCongluente = new System.Windows.Forms.CheckBox();
            this.checkBoxCongluente = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTrocaImagem = new System.Windows.Forms.Button();
            this.ImagemResp = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnConsultaRespostaU = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.btnFormulario = new System.Windows.Forms.Button();
            this.btnTeste = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnInicia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemResp)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            this.tabControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabControl1_KeyPress);
            this.tabControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TabControl1_KeyUp);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.dateTimeDataNascimento);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.cbxSexo);
            this.tabPage1.Controls.Add(this.checkBoxMisto);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtbExperimentador);
            this.tabPage1.Controls.Add(this.txtbPaciente);
            this.tabPage1.Controls.Add(this.checkBoxInCongluente);
            this.tabPage1.Controls.Add(this.checkBoxCongluente);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(90)))));
            this.panel8.Controls.Add(this.panel9);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(90)))));
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(90)))));
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(90)))));
            this.panel5.Controls.Add(this.panel6);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(90)))));
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(90)))));
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // dateTimeDataNascimento
            // 
            this.dateTimeDataNascimento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            resources.ApplyResources(this.dateTimeDataNascimento, "dateTimeDataNascimento");
            this.dateTimeDataNascimento.Name = "dateTimeDataNascimento";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(90)))));
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(90)))));
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(90)))));
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(90)))));
            this.label3.Name = "label3";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // cbxSexo
            // 
            this.cbxSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            resources.ApplyResources(this.cbxSexo, "cbxSexo");
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            resources.GetString("cbxSexo.Items"),
            resources.GetString("cbxSexo.Items1")});
            this.cbxSexo.Name = "cbxSexo";
            // 
            // checkBoxMisto
            // 
            resources.ApplyResources(this.checkBoxMisto, "checkBoxMisto");
            this.checkBoxMisto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(90)))));
            this.checkBoxMisto.Name = "checkBoxMisto";
            this.checkBoxMisto.UseVisualStyleBackColor = true;
            this.checkBoxMisto.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(90)))));
            this.label2.Name = "label2";
            // 
            // txtbExperimentador
            // 
            this.txtbExperimentador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtbExperimentador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtbExperimentador, "txtbExperimentador");
            this.txtbExperimentador.Name = "txtbExperimentador";
            // 
            // txtbPaciente
            // 
            this.txtbPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtbPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtbPaciente, "txtbPaciente");
            this.txtbPaciente.Name = "txtbPaciente";
            // 
            // checkBoxInCongluente
            // 
            resources.ApplyResources(this.checkBoxInCongluente, "checkBoxInCongluente");
            this.checkBoxInCongluente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(90)))));
            this.checkBoxInCongluente.Name = "checkBoxInCongluente";
            this.checkBoxInCongluente.UseVisualStyleBackColor = true;
            this.checkBoxInCongluente.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // checkBoxCongluente
            // 
            resources.ApplyResources(this.checkBoxCongluente, "checkBoxCongluente");
            this.checkBoxCongluente.Checked = true;
            this.checkBoxCongluente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCongluente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(90)))));
            this.checkBoxCongluente.Name = "checkBoxCongluente";
            this.checkBoxCongluente.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnTrocaImagem);
            this.tabPage2.Controls.Add(this.ImagemResp);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            this.tabPage2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TabPage2_PreviewKeyDown);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.label6.Name = "label6";
            // 
            // btnTrocaImagem
            // 
            this.btnTrocaImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            resources.ApplyResources(this.btnTrocaImagem, "btnTrocaImagem");
            this.btnTrocaImagem.Name = "btnTrocaImagem";
            this.btnTrocaImagem.UseVisualStyleBackColor = false;
            this.btnTrocaImagem.Click += new System.EventHandler(this.Button3_Click);
            // 
            // ImagemResp
            // 
            this.ImagemResp.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.ImagemResp, "ImagemResp");
            this.ImagemResp.InitialImage = global::TCCSTROOP.Properties.Resources.cinza;
            this.ImagemResp.Name = "ImagemResp";
            this.ImagemResp.TabStop = false;
            this.ImagemResp.UseWaitCursor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.btnImprimir);
            this.tabPage3.Controls.Add(this.btnConsultaRespostaU);
            this.tabPage3.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnImprimir, "btnImprimir");
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.v);
            // 
            // btnConsultaRespostaU
            // 
            this.btnConsultaRespostaU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.btnConsultaRespostaU.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnConsultaRespostaU, "btnConsultaRespostaU");
            this.btnConsultaRespostaU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnConsultaRespostaU.Name = "btnConsultaRespostaU";
            this.btnConsultaRespostaU.UseVisualStyleBackColor = false;
            this.btnConsultaRespostaU.Click += new System.EventHandler(this.Button8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // fbCommand1
            // 
            this.fbCommand1.CommandTimeout = 30;
            // 
            // btnFormulario
            // 
            this.btnFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            resources.ApplyResources(this.btnFormulario, "btnFormulario");
            this.btnFormulario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnFormulario.FlatAppearance.BorderSize = 0;
            this.btnFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.btnFormulario.Name = "btnFormulario";
            this.btnFormulario.UseVisualStyleBackColor = false;
            // 
            // btnTeste
            // 
            this.btnTeste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            resources.ApplyResources(this.btnTeste, "btnTeste");
            this.btnTeste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.btnTeste.FlatAppearance.BorderSize = 0;
            this.btnTeste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.UseVisualStyleBackColor = false;
            this.btnTeste.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            resources.ApplyResources(this.btnResultado, "btnResultado");
            this.btnResultado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.btnResultado.FlatAppearance.BorderSize = 0;
            this.btnResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this.button6, "button6");
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(97)))));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(97)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(218)))), ((int)(((byte)(93)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(218)))), ((int)(((byte)(93)))));
            resources.ApplyResources(this.button7, "button7");
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(90)))));
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button7);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.tabControl1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnInicia
            // 
            this.btnInicia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            resources.ApplyResources(this.btnInicia, "btnInicia");
            this.btnInicia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.btnInicia.FlatAppearance.BorderSize = 0;
            this.btnInicia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.UseVisualStyleBackColor = false;
            this.btnInicia.Click += new System.EventHandler(this.BtnInicia_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.btnInicia);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.btnFormulario);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemResp)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabPage tabPage2;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFormulario;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnConsultaRespostaU;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimeDataNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.CheckBox checkBoxMisto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbExperimentador;
        private System.Windows.Forms.TextBox txtbPaciente;
        private System.Windows.Forms.CheckBox checkBoxInCongluente;
        private System.Windows.Forms.CheckBox checkBoxCongluente;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnTrocaImagem;
        private System.Windows.Forms.PictureBox ImagemResp;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnInicia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

