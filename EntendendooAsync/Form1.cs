using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntendendooAsync
{
    public partial class frm1 : Form
    {
        public List<string> WebSites { get; set; }

        public frm1()
        {
            InitializeComponent();


            //Lista de Sites para se fazer download
            this.WebSites = new List<string>();
            this.WebSites.Add(@"https://www.microsoft.com/pt-br/");
            this.WebSites.Add(@"https://github.com/");
            this.WebSites.Add(@"https://www.ibm.com/br-pt/");
            this.WebSites.Add(@"https://www.redhat.com/pt-br");
            this.WebSites.Add(@"https://www.apple.com/br/");
        }


        /// <summary>
        /// Ação do Botão Síncrono
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnGetData_Click(object sender, EventArgs e)
        {
            tBox1.Text = ""; 

            var watch = System.Diagnostics.Stopwatch.StartNew();

            this.DownloadSync();
            watch.Stop();


            this.tBox1.Text += "\r\n";
            this.tBox1.Text += "Tempo decorrido ms: " + watch.ElapsedMilliseconds.ToString();

        }
        /// <summary>
        /// Ação do Botão Assíncrono
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void btn_clickAsync(object sender, EventArgs e)
        {
            tBox1.Text = "";

            var watch = System.Diagnostics.Stopwatch.StartNew();

            await this.DownloadAsync();
            watch.Stop();


            this.tBox1.Text += "\r\n";
            this.tBox1.Text += "Tempo decorrido ms: " + watch.ElapsedMilliseconds.ToString();
        }

        /// <summary>
        /// Processamento Paralelo
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void btn_click_Paralelo(object sender, EventArgs e)
        {
            tBox1.Text = "";

            var watch = System.Diagnostics.Stopwatch.StartNew();

            await this.DownloadParallelAsync();
            watch.Stop();


            this.tBox1.Text += "\r\n";
            this.tBox1.Text += "Tempo decorrido ms: " + watch.ElapsedMilliseconds.ToString();
        }


        /// <summary>
        /// Faz o Download de forma Síncrona
        /// </summary>
        private void DownloadSync()
        {
            foreach (var item in WebSites)
            {
                WebData dataInfo = GetData(item);
                this.WriteInfo(dataInfo);
            }
        }


        

        /// <summary>
        /// Faz o Download Assíncrono
        /// </summary>
        /// <returns>Task.</returns>
        private async Task DownloadAsync()
        {
            foreach(var item in WebSites)
            {
                WebData dataInfo = await Task.Run(() => GetDataAsync(item));
                this.WriteInfo(dataInfo);
            }
        }


        /// <summary>
        /// Execução em modo paralelo
        /// </summary>
        /// <returns>Task.</returns>
        private async Task DownloadParallelAsync()
        {
            //cria uma lista de tarefas
            List<Task<WebData>> tarefas = new List<Task<WebData>>();

            //Adiciona as tarefas na lista
            foreach (var site in WebSites)
            {
                tarefas.Add(GetDataAsync(site));
            }

            //Aguarda todas terminarem
            var results = await Task.WhenAll(tarefas);

            //Escreve o resultado em tela
            foreach (var site in results)
            {
                this.WriteInfo(site);
            }
            
        }
        

        /// <summary>
        /// Obtem os dados de forma Síncrona
        /// </summary>
        /// <param name="url">The URL.</param>
        private WebData GetData(string url)
        {
            WebData webData = new WebData(); //Cria um novo modelo WebData
            WebClient client = new WebClient();

            webData.dataSize = client.DownloadData(url)
                                     .LongLength
                                     .ToString();
            webData.url = url;
            return webData;
                       
        }

        /// <summary>
        /// Obtem os dados de forma Assíncrona
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>Task&lt;WebData&gt;.</returns>
        private async Task<WebData> GetDataAsync(string url)
        {
            WebData output = new WebData();
            WebClient client = new WebClient();

            var d = await client.DownloadStringTaskAsync(url);
            output.dataSize = d.Length.ToString();
            output.url = url;
            return output;

        }



        /// <summary>
        ///Escreve em tela o resultado 
        /// </summary>
        /// <param name="info">The information.</param>
        private void WriteInfo(WebData info)
        {
            tBox1.Text +=  info.url + "  " + info.dataSize + " kb \r\n";
        }

        
    }
}
