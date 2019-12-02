using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;
using fireBirdWin;
using System.Diagnostics;
using System.Data.OleDb;
using System.Resources;


namespace TCCSTROOP
{
    public partial class Form1 : Form
    { 
        TcpClient client;
        TcpListener server = new TcpListener(700);
        String modo = "congruente";
        int totalteste =0;
        private Thread thrListener;
        long li ;
        long lf;
        Stopwatch sw = new Stopwatch();

        private StreamReader srReceptor;
        private StreamWriter swEnviador;
        string strNumeroaleatorio ;
        int quantidadeteste = 0;
        int ultimo;
        Task tAtivarConexao;
        Task tRecebeMensagem;
        Task tEnviarMensagem;
        string resposta;
        int X = 0;
        int Y = 0;
        int menu = 0;
        double PCFreq = 0.0;
        long CounterStart = 0;




        public Form1()
        {

            server.Start();


            InitializeComponent();

            /*
            Task tpai = Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Task t = Task.Factory.StartNew(() =>
                    {
                        client = server.AcceptTcpClient();

                        stream = client.GetStream();


                        Console.WriteLine("A Client comercial");
                        while (true)
                        {
                            while (!stream.DataAvailable) ;

                            Byte[] bytes = new Byte[client.Available];

                            stream.Read(bytes, 0, bytes.Length);
                            stream.Write(bytes, 0, bytes.Length);


                            String data = Encoding.UTF8.GetString(bytes);
                            Console.WriteLine(data);



                        }
                    });

                }
                });*/




        }
        public void Aceitaconexao()
        {
            tAtivarConexao = Task.Factory.StartNew(() =>
            {
           //   TcpClient  novo = server.AcceptTcpClient();
           //     if (novo != client)
                client = server.AcceptTcpClient();


                Console.WriteLine(client);
                //  stream = client.GetStreamclient
                srReceptor = new System.IO.StreamReader(client.GetStream());
                swEnviador = new System.IO.StreamWriter(client.GetStream()); //
               

                Console.WriteLine("Chegou");
                EnviarValor("10");
                try
                {
                    while ((resposta = srReceptor.ReadLine()) != "" && resposta != null)
                    {



                        // data = Encoding.UTF8.GetString(bytes);
                        Console.WriteLine(resposta);


                    }
                }
                catch
                {
                    Console.Write("Erro ReadLine");
                }
            });
        }
        public string ReceberValor()
        {
            string data;
            tRecebeMensagem = Task.Factory.StartNew(() =>
            {
                while (true)
                {

                    while (true)
                    {
                        if (client != null && srReceptor != null)
                        {
                            Console.WriteLine("Chegou");
                            while ((data = srReceptor.ReadLine()) != "")
                            {


                                EnviarValor(data);
                                // data = Encoding.UTF8.GetString(bytes);
                                Console.WriteLine(data);
                            }
                            return data;
                        }
                    }
                }
            });
            return "";


        }
        public void EnviarValor(string comando)
        {
            swEnviador = new System.IO.StreamWriter(client.GetStream());



            swEnviador.Write(comando+ (char) 0x04);
            //swEnviador.WriteLine("");
            swEnviador.Flush();



        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            thrListener = new Thread(Aceitaconexao);

            btnFormulario.BackColor = Color.Green;
            thrListener.Start();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        { }



        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            if (client == null)
            {
               // MessageBox.Show("Aguardando um smartphone conectar");
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Aguardando o aplivativo conectar", "", buttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    // Do something  
                }
            }
            else
            {
                btnTeste.BackColor = Color.Green;
                btnFormulario.BackColor = Color.White;
                btnResultado.BackColor = Color.White;
                tabControl1.SelectTab(1);
                //  tabControl1.SelectNextControl(ActiveControl, true, true, true, true);
                int tipo = 1;
                if (checkBoxCongluente.Checked)
                {
                    tipo = 1;
                }
                else if (checkBoxInCongluente.Checked)
                {
                    tipo = 2;
                }
                else if (checkBoxMisto.Checked)
                {
                    tipo = 3;
                }

                insertFBSingleton(txtbPaciente.Text, txtbExperimentador.Text, dateTimeDataNascimento.Value, cbxSexo.Text, tipo,DateTime.Now);

                txtbPaciente.Enabled = false;
                txtbExperimentador.Enabled = false;
                dateTimeDataNascimento.Enabled = false;
                cbxSexo.Enabled = false;
                checkBoxCongluente.Enabled = false;
                checkBoxInCongluente.Enabled = false;
                checkBoxMisto.Enabled = false;
                ImagemResp.Image = Properties.Resources.cinza;
                ImagemResp.Padding = new System.Windows.Forms.Padding(0);
                btnTrocaImagem.Top = 357;
                btnTrocaImagem.Text = "Iniciar";
                btnTrocaImagem.Enabled = true;

            }
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private async void Button3_Click(object sender, EventArgs e)
        {
            swEnviador = new System.IO.StreamWriter(client.GetStream());
            swEnviador.Write("111" + (char)0x04);
            swEnviador.Flush();
            try
            {

                btnTrocaImagem.Top =500;    
                btnTrocaImagem.Text = "";
//                btnTrocaImagem.Enabled = false;
            //    btnTrocaImagem.Visible = false;
                ImagemResp.Visible = true;
                //  ImagemResp.Enabled = true;
                //ImagemResp.SelectNextControl(ActiveControl, true, true, true, true);
             //   btnTrocaImagem.Visible = false;

                Random rdn = new Random();
                byte IOT = 0x04;
                //    string strNumeroaleatorio;
                strNumeroaleatorio = rdn.Next(1, 3).ToString();
                swEnviador = new System.IO.StreamWriter(client.GetStream());
                if (strNumeroaleatorio == "1")
                {
//                    ImagemResp.ImageLocation = "C:/Users/Alanf/source/repos/TCCSTROOP/TCCSTROOP/Dia.png";
                    ImagemResp.Image = Properties.Resources.Dia;
                    ImagemResp.Padding = new System.Windows.Forms.Padding(0);
                }
                else
                if (strNumeroaleatorio == "2")
                {
                    ImagemResp.Image = Properties.Resources.Noite;
                    //   ImagemResp.ImageLocation = "C:/Users/Alanf/source/repos/TCCSTROOP/TCCSTROOP/Noite.png";
                    ImagemResp.Padding = new System.Windows.Forms.Padding(0);
                }
                else
                if (strNumeroaleatorio == "3")
                {
                   // ImagemResp.ImageLocation = "C:/Users/Alanf/source/repos/TCCSTROOP/TCCSTROOP/Dia.png";
                    ImagemResp.Image = Properties.Resources.Dia;
                    ImagemResp.BorderStyle = BorderStyle.FixedSingle;
                    ImagemResp.Padding = new System.Windows.Forms.Padding(20);
                }
                else
                if (strNumeroaleatorio == "4")
                {
                    ImagemResp.Image = Properties.Resources.Noite;
                    //  ImagemResp.ImageLocation = "C:/Users/Alanf/source/repos/TCCSTROOP/TCCSTROOP/Noite.png";
                    ImagemResp.Padding = new System.Windows.Forms.Padding(20);
                }

                swEnviador.Write(strNumeroaleatorio + (char)0x04);
                swEnviador.Flush();

                await PausaComTaskDelay(1000);
                
                sw.Start();
                //EnviarValor(strNumeroaleatorio);
            }
            catch(Exception a)
            {
                Console.WriteLine(a.Message);
            }
        }
        async Task PausaComTaskDelay(int mls)
        {
            await Task.Delay(mls);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            sw.Stop();
            TimeSpan tempo = sw.Elapsed;
            Console.Write(e.KeyValue.ToString());
            //Console.WriteLine(e.KeyChar.ToString());
            byte IOT = 0x04;
            //string strNumeroaleatorio = "";
            //strNumeroaleatorio = rdn.Next(1, 4).ToString();
            swEnviador = new System.IO.StreamWriter(client.GetStream());
            ImagemResp.Image = Properties.Resources.cinza;

            if (strNumeroaleatorio == "1")
            {
                ImagemResp.Image = Properties.Resources.Dia;
          //      ImagemResp.ImageLocation = "C:/Users/Alanf/source/repos/TCCSTROOP/TCCSTROOP/Dia.png";
                ImagemResp.Padding = new System.Windows.Forms.Padding(0);
            }
            else
            if (strNumeroaleatorio == "2")
            {
                ImagemResp.Image = Properties.Resources.Noite;
  //              ImagemResp.ImageLocation = "C:/Users/Alanf/source/repos/TCCSTROOP/TCCSTROOP/Noite.png";
                ImagemResp.Padding = new System.Windows.Forms.Padding(0);
            }
            else
            if (strNumeroaleatorio == "3")
            {
                ImagemResp.Image = Properties.Resources.Dia;
              //  ImagemResp.ImageLocation = "C:/Users/Alanf/source/repos/TCCSTROOP/TCCSTROOP/Dia.png";
                ImagemResp.BorderStyle = BorderStyle.FixedSingle;
                ImagemResp.Padding = new System.Windows.Forms.Padding(20);
            }
            else
            if (strNumeroaleatorio == "4")
            {
                ImagemResp.Image = Properties.Resources.Noite;
//                ImagemResp.ImageLocation = "C:/Users/Alanf/source/repos/TCCSTROOP/TCCSTROOP/Noite.png";
                ImagemResp.Padding = new System.Windows.Forms.Padding(20);
            }

            swEnviador.Write(strNumeroaleatorio + (char)0x04);
            swEnviador.Flush();
            
        }

        private async void TabControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {



                TimeSpan TEMPODERESP;
                try
                {
                    Console.WriteLine(e.KeyChar);
                    String RESULTADOESPERADO; String RESULTADO;


                    if (e.KeyChar == '.' || e.KeyChar == ',')
                    {
                        sw.Stop();
                        TEMPODERESP = sw.Elapsed;
                        quantidadeteste++;
                        totalteste++;
                        RESULTADOESPERADO = "";
                        if (e.KeyChar == '.')
                        {
                            //errado
                            if (strNumeroaleatorio == "1")
                            {
                                RESULTADOESPERADO = "Dia";
                            }
                            else
                            if (strNumeroaleatorio == "2")
                            {
                                RESULTADOESPERADO = "Noite";
                            }
                            else
                            if (strNumeroaleatorio == "3")
                            {
                                RESULTADOESPERADO = "Noite";
                                if (modo == "mista")
                                    RESULTADOESPERADO = RESULTADOESPERADO + "*";
                            }
                            else
                            if (strNumeroaleatorio == "4")
                            {
                                RESULTADOESPERADO = "Dia";
                                if (modo == "mista")
                                    RESULTADOESPERADO = RESULTADOESPERADO + "*";
                            }



                            RESULTADO = "1";

                            insertFBSingletonResultado(ultimo, RESULTADOESPERADO, RESULTADO, quantidadeteste, TEMPODERESP.TotalSeconds, modo, DateTime.Now.ToShortTimeString());
                        }
                        else
                        if (e.KeyChar == ',')
                        {
                            //correto

                            RESULTADOESPERADO = "";


                            if (strNumeroaleatorio == "1")
                            {
                                RESULTADOESPERADO = "Dia";
                            }
                            else
                            if (strNumeroaleatorio == "2")
                            {
                                RESULTADOESPERADO = "Noite";
                            }
                            else
                            if (strNumeroaleatorio == "3")
                            {
                                RESULTADOESPERADO = "Noite";
                                if (modo == "mista")
                                    RESULTADOESPERADO = RESULTADOESPERADO + "*";
                            }
                            else
                            if (strNumeroaleatorio == "4")
                            {
                                RESULTADOESPERADO = "Dia";
                                if (modo == "mista")
                                    RESULTADOESPERADO = RESULTADOESPERADO + "*";
                            }

                            RESULTADO = "0";

                            insertFBSingletonResultado(ultimo, RESULTADOESPERADO, RESULTADO, quantidadeteste, TEMPODERESP.TotalSeconds, modo, DateTime.Now.ToShortTimeString());




                        }
                        Console.WriteLine(RESULTADOESPERADO);
                        Console.Write("tb:" + quantidadeteste.ToString());
                        Console.WriteLine(e.KeyChar.ToString());






                    }

                    if (quantidadeteste == 12)
                    {
                        quantidadeteste = 0;
                        if (modo == "congruente")
                        {
                            //  MessageBox.Show("Modo Congruente finalizado");
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result = MessageBox.Show("Modo congruente finalizado", "", buttons);
                            if (result == DialogResult.Yes)
                            {
                                this.Close();
                            }
                            else
                            {
                                // Do something  
                            }
                            modo = "incongruente";
                        }
                        else if (modo == "incongruente")
                        {

                            //    MessageBox.Show("Modo Incongruente finalizado");
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result = MessageBox.Show("Modo Incongruente finalizado", "", buttons);
                            if (result == DialogResult.Yes)
                            {
                                this.Close();
                            }
                            else
                            {
                                // Do something  
                            }

                            modo = "mista";
                            if (checkBoxMisto.Checked == false)
                            {
                                modo = "finalizado";
                                swEnviador.Write("5" + (char)0x04);
                                swEnviador.Flush();
                            }
                        }
                        else if (modo == "mista")
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result = MessageBox.Show("Modo misto finalizado", "", buttons);
                            if (result == DialogResult.Yes)
                            {
                                this.Close();
                            }
                            else
                            {
                                // Do something  
                            }

                            //   MessageBox.Show("Modo Misto finalizado-");
                            modo = "finalizado";
                            swEnviador.Write("5" + (char)0x04);
                            swEnviador.Flush();
                        }

                    }
                    if (modo == "finalizado")
                    {
                        btnInicia.Visible = true;
                        btnResultado.BackColor = Color.Green;
                        btnConsultaRespostaU.Enabled = true;
                        btnConsultaRespostaU.Visible = true;
                        tabControl1.SelectTab(2);

                    }
                    else
                    {
                        byte IOT = 0x04;

                        Random rdn = new Random();
                        if (modo == "congruente")
                        {
                            //int num = rdn.Next(1, 3);
                            int countnum = 0;
                            /*while( num.ToString() == strNumeroaleatorio)
                            {
                                num = (rdn.Next(1, 3));
                                countnum++;
                            }*/
                            strNumeroaleatorio = (rdn.Next(1, 3)).ToString();
                            //  Console.WriteLine("count:" + countnum.ToString());
                            // strNumeroaleatorio = num.ToString();// (rdn.Next(1, 2)).ToString();
                        }
                        else
                        if (modo == "incongruente")
                        {
                            strNumeroaleatorio = (rdn.Next(3, 5)).ToString();
                        }
                        else
                        if (modo == "mista" && checkBoxMisto.Checked == true)
                        {
                            strNumeroaleatorio = rdn.Next(1, 5).ToString();
                        }
                        else
                            strNumeroaleatorio = rdn.Next(5, 5).ToString();

                        swEnviador = new System.IO.StreamWriter(client.GetStream());
                        // ImagemResp.ImageLocation = "C:/projetos/TCCSTROOP/cinza.png";

                        ImagemResp.Image = Properties.Resources.cinza;
                        //   ImagemResp.Image = null;

                        await PausaComTaskDelay(500);
                        if (strNumeroaleatorio == "1")
                        {
                            ImagemResp.Image = Properties.Resources.Dia;
                            //                        ImagemResp.ImageLocation = "C:/Users/Alanf/source/repos/TCCSTROOP/TCCSTROOP/Dia.png";

                            ImagemResp.Padding = new System.Windows.Forms.Padding(0);
                        }
                        else
                    if (strNumeroaleatorio == "2")
                        {
                            //                  ImagemResp.ImageLocation = "C:/Users/Alanf/source/repos/TCCSTROOP/TCCSTROOP/Noite.png";
                            ImagemResp.Image = Properties.Resources.Noite;
                            ImagemResp.Padding = new System.Windows.Forms.Padding(0);
                        }
                        else
                    if (strNumeroaleatorio == "3")
                        {
                            ImagemResp.Image = Properties.Resources.Dia;
                            //                        ImagemResp.ImageLocation = "C:/Users/Alanf/source/repos/TCCSTROOP/TCCSTROOP/Dia.png";
                            ImagemResp.BorderStyle = BorderStyle.FixedSingle;
                            ImagemResp.Padding = new System.Windows.Forms.Padding(20);
                        }
                        else
                    if (strNumeroaleatorio == "4")
                        {
                            ImagemResp.BorderStyle = BorderStyle.FixedSingle;
                            ImagemResp.Image = Properties.Resources.Noite;
                            //ImagemResp.ImageLocation = "C:/Users/Alanf/source/repos/TCCSTROOP/TCCSTROOP/Noite.png";
                            ImagemResp.Padding = new System.Windows.Forms.Padding(20);
                        }
                        sw.Reset();

                        Console.WriteLine("ENVIAnDO:" + strNumeroaleatorio + (char)0x04);
                        swEnviador.Write(strNumeroaleatorio + (char)0x04);
                        swEnviador.Flush();
                        sw.Start();
                    }

                }
                catch (Exception d)
                {
                    Console.WriteLine("{0} Exception caught.", d);
                }
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  acessoFBSingleton("");
        }
        public void acessoFB()
        {
            string strConn = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
            FbConnection fbConn = new FbConnection(strConn);

            FbCommand fbCmd = new FbCommand("Select NOMEPACIENTE, NOMEEXPERIMENTADOR, DATADENASCIMENTO, SEXO,TIPO from DADOSDEEXPERIMENTO", fbConn);

            try
            {
                fbConn.Open();

                FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
                DataTable dtEmployee = new DataTable();
                fbDa.Fill(dtEmployee);

                dataGridView1.DataSource = dtEmployee;
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o FireBird " + fbex.Message, "Erro");
            }
            finally
            {
                fbConn.Close();
            }
        }
        public void acessoFBSingleton(string ID)
        {
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();

                    //                    string mSQL = "SELECT d.ID as neo  FROM DADOSDEEXPERIMENTO d inner join RESULTADOEXPERIMENTO r on d.ID = r.DADOSDEEXPERIMENTO";
                    string mSQL = "select r.ID,d.NOMEPACIENTE as Paciente,d.NOMEEXPERIMENTADOR as Experimentador , d.DATAEXPERIMENTO as Data,r.HORA as Hora,  r.RESULTADOESPERADO as Condicaoverdadeira , r.TEMPODERESP as TempoReacao, r.ETAPA as Condicao, r.TENTATIVA as Tentativa,r.RESULTADO as Resultado from DADOSDEEXPERIMENTO d inner join RESULTADOEXPERIMENTO r on r.DADOSDEEXPERIMENTO = d.ID";
                    if (ID != "")
                    {
                        mSQL = mSQL + " where d.ID = " + ID;
                    }
                     
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataAdapter da = new FbDataAdapter(cmd);

                    DataTable dtEmployee = new DataTable();
                    da.Fill(dtEmployee);
                    this.dataGridView1.DataSource = dtEmployee;
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro de acesso ao MySQL : " + fbex.Message, "Erro");
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
        public void acessoFBSingleto1n(string ID)
        {
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();

//                    string mSQL = "SELECT d.ID as neo  FROM DADOSDEEXPERIMENTO d inner join RESULTADOEXPERIMENTO r on d.ID = r.DADOSDEEXPERIMENTO";
                    string mSQL = "select r.ID,d.NOMEPACIENTE as Paciente,d.NOMEEXPERIMENTADOR as Experimentador , d.DATAEXPERIMENTO as Data,r.HORA as Hora,  r.RESULTADOESPERADO as Condicaoverdadeira , r.TEMPODERESP as TempoReacao, r.ETAPA as Condicao, r.TENTATIVA as Tentativa,r.RESULTADO as Resultado from DADOSDEEXPERIMENTO d inner join RESULTADOEXPERIMENTO r on r.DADOSDEEXPERIMENTO = d.ID where d.ID = "+ID;
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataAdapter da = new FbDataAdapter(cmd);

                    DataTable dtEmployee = new DataTable();
                    da.Fill(dtEmployee);
                    this.dataGridView1.DataSource = dtEmployee;
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro de acesso ao MySQL : " + fbex.Message, "Erro");
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
        public void insertFBSingleton(String nome,String experimentado,DateTime datanascimento,String sexo,int tipo,DateTime dataexperimento)
        {
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();

                    string mSQL = "INSERT INTO DADOSDEEXPERIMENTO (NOMEPACIENTE, NOMEEXPERIMENTADOR, DATADENASCIMENTO, SEXO,TIPO,DATAEXPERIMENTO) VALUES(@NOME,@NOMEEXPERIMENTADOR,@DATADENASCIMENTO,@SEXO,@TIPO,@DATAEXPERIMENTO) returning ID";

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("NOME", nome);
                    cmd.Parameters.Add("NOMEEXPERIMENTADOR", experimentado);
                    cmd.Parameters.Add("DATADENASCIMENTO", datanascimento);
                    cmd.Parameters.Add("SEXO", sexo);
                    cmd.Parameters.Add("TIPO", tipo);
                    cmd.Parameters.Add("DATAEXPERIMENTO",dataexperimento);
                    // cmd.Parameters.Add("ID", 0);
                    // FbDataAdapter da = new FbDataAdapter(cmd);
                    cmd.Parameters.Add("ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    ultimo= Convert.ToInt32(cmd.Parameters["@ID"].Value);
                    DataTable dtEmployee = new DataTable();
                 //   da.Fill(dtEmployee);
                   // da.R
                   // this.dataGridView1.DataSource = dtEmployee;
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro de acesso ao Banco : " + fbex.Message, "Erro");
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
        public void insertFBSingletonResultado(int ultimo, String RESULTADOESPERADO, String RESULTADO, int TENTATIVA, Double TEMPODERESP, string etapa,string hora)
        {
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();

                    string mSQL = "INSERT INTO RESULTADOEXPERIMENTO(DADOSDEEXPERIMENTO, RESULTADOESPERADO, RESULTADO,TENTATIVA,TEMPODERESP,ETAPA,hora) VALUES(@DADOSDEEXPERIMENTO,@RESULTADOESPERADO,@RESULTADO,@TENTATIVA,@TEMPODERESP,@ETAPA,@HORA) returning ID";
                    
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("DADOSDEEXPERIMENTO", ultimo);
                    cmd.Parameters.Add("RESULTADOESPERADO", RESULTADOESPERADO);
                    cmd.Parameters.Add("RESULTADO", RESULTADO);
                    cmd.Parameters.Add("TENTATIVA", TENTATIVA);
                    cmd.Parameters.Add("TEMPODERESP",TEMPODERESP);
                    cmd.Parameters.Add("ETAPA", etapa);
                    cmd.Parameters.Add("HORA", hora);
                    cmd.Parameters.Add("ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    ultimo = Convert.ToInt32(cmd.Parameters["@ID"].Value);

                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro de acesso ao Banco : " + fbex.Message, "Erro");
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void ImagemResp_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            acessoFBSingleton(ultimo.ToString());
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.Write(e.KeyChar);
        }

        private void TabPage2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Console.WriteLine(e.KeyValue);
        }

        private void TabControl1_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("keyUP:"+e.KeyValue);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
         
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void atualizaMenu()
        {
            btnTeste.ForeColor = Color.FromArgb(244, 244, 244);
            btnTeste.BackColor = Color.FromArgb(32, 156, 120);

            btnFormulario.ForeColor = Color.FromArgb(244, 244, 244);
            btnFormulario.BackColor = Color.FromArgb(32, 156, 120);

            btnResultado.ForeColor = Color.FromArgb(244, 244, 244);
            btnResultado.BackColor = Color.FromArgb(32, 156, 120);

            if (menu == 0)
            {
                btnFormulario.BackColor = Color.FromArgb(244, 244, 244);
                btnFormulario.ForeColor = Color.FromArgb(32, 156, 120);
            }
            else if (menu == 1)
            {
                btnTeste.BackColor = Color.FromArgb(244, 244, 244);
                btnTeste.ForeColor = Color.FromArgb(32, 156, 120);
            }
            else if (menu == 2)
            {
                btnResultado.BackColor = Color.FromArgb(244, 244, 244);
                btnResultado.ForeColor = Color.FromArgb(32, 156, 120);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            btnInicia.Visible = true;
            btnConsultaRespostaU.Enabled = false;
            btnConsultaRespostaU.Visible = false;
            btnResultado.BackColor = Color.Green;
            btnTeste.BackColor = Color.White;
            btnFormulario.BackColor = Color.White;
            tabControl1.SelectTab(2);
            btnConsultaRespostaU.Visible = true;
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //printDGV.
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void BtnInicia_Click(object sender, EventArgs e)
        {
            quantidadeteste = 0;
            totalteste = 0;
            modo = "congruente";
            btnTeste.BackColor = Color.White;
            btnResultado.BackColor = Color.White;
            btnFormulario.BackColor=Color.Green;

            txtbPaciente.Enabled = true;
            txtbPaciente.Text = "";
            txtbExperimentador.Enabled = true;
            txtbExperimentador.Text = "";
            dateTimeDataNascimento.Enabled = true;

            cbxSexo.Enabled = true;
            cbxSexo.Text = "";
            checkBoxCongluente.Enabled = true;
            
            checkBoxInCongluente.Enabled = true;
            checkBoxMisto.Enabled = true;
            checkBoxMisto.Checked = false;
            btnInicia.Visible = false;
            tabControl1.SelectTab(0);
            try
            {
                swEnviador.Write("10" + (char)0x04);
                swEnviador.Flush();
            }
            catch 
            {
                Console.WriteLine("Nada");
            }

        }

        private void v(object sender, EventArgs e)
        {
            writeCSV(dataGridView1, "result.csv");
            MessageBox.Show("Converted successfully to *.csv format");
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void writeCSV(DataGridView gridIn, string outputFile)
        {
            //test to see if the DataGridView has any rows
            if (gridIn.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter swOut = new StreamWriter(outputFile);

                //write header rows to csv
                for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                {
                    if (i > 0)
                    {
                        swOut.Write(",");
                    }
                    swOut.Write(gridIn.Columns[i].HeaderText);
                }

                swOut.WriteLine();

                //write DataGridView rows to csv
                for (int j = 0; j <= gridIn.Rows.Count - 2; j++)
                {
                    if (j > 0)
                    {
                        swOut.WriteLine();
                    }

                    dr = gridIn.Rows[j];

                    for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(",");
                        }

                        value = dr.Cells[i].Value.ToString();
                        //replace comma's with spaces
                        value = value.Replace(',', '.');
                        //replace embedded newlines with spaces
                        value = value.Replace(Environment.NewLine, " ");

                        swOut.Write(value);
                    }
                }
                swOut.Close();
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            acessoFBSingleton("");
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
