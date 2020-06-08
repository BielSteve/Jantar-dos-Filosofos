using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BielFilosofos.jantar;

namespace BielFilosofos
{
    public partial class Form1 : Form
    {
        Relatorio relatorio;

        public Form1()
        {
            //CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.relatorio = new Relatorio(CallbackRelatorio);
            new Mesa(relatorio);
            Console.WriteLine("continua");
            
        }

        public void CallbackRelatorio()
        {
            filo1_Comeu.Invoke((MethodInvoker)(() => filo1_Comeu.Text = relatorio.pegaValorDoRelatorio("Filosofo 1 Comeu") + ""));
            filo1_Fome.Invoke((MethodInvoker)(() => filo1_Fome.Text = relatorio.pegaValorDoRelatorio("Filosofo 1 Fome") + ""));
            filo1_Pensou.Invoke((MethodInvoker)(() => filo1_Pensou.Text = relatorio.pegaValorDoRelatorio("Filosofo 1 Pensou") + ""));
            filo1_Tempo.Invoke((MethodInvoker)(() => filo1_Tempo.Text = relatorio.pegaValorDoRelatorio("Filosofo 1 Tempo") + ""));
            filo1_Status.Invoke((MethodInvoker)(() => filo1_Status.Text = relatorio.pegaValorDoStatus("Filosofo 1 Status") + ""));

            filo2_Comeu.Invoke((MethodInvoker)(() => filo2_Comeu.Text = relatorio.pegaValorDoRelatorio("Filosofo 2 Comeu") + ""));
            filo2_Fome.Invoke((MethodInvoker)(() => filo2_Fome.Text = relatorio.pegaValorDoRelatorio("Filosofo 2 Fome") + ""));
            filo2_Pensou.Invoke((MethodInvoker)(() => filo2_Pensou.Text = relatorio.pegaValorDoRelatorio("Filosofo 2 Pensou") + ""));
            filo2_Tempo.Invoke((MethodInvoker)(() => filo2_Tempo.Text = relatorio.pegaValorDoRelatorio("Filosofo 2 Tempo") + ""));
            filo2_Status.Invoke((MethodInvoker)(() => filo2_Status.Text = relatorio.pegaValorDoStatus("Filosofo 2 Status") + ""));

            filo3_Comeu.Invoke((MethodInvoker)(() => filo3_Comeu.Text = relatorio.pegaValorDoRelatorio("Filosofo 3 Comeu") + ""));
            filo3_Fome.Invoke((MethodInvoker)(() => filo3_Fome.Text = relatorio.pegaValorDoRelatorio("Filosofo 3 Fome") + ""));
            filo3_Pensou.Invoke((MethodInvoker)(() => filo3_Pensou.Text = relatorio.pegaValorDoRelatorio("Filosofo 3 Pensou") + ""));
            filo3_Tempo.Invoke((MethodInvoker)(() => filo3_Tempo.Text = relatorio.pegaValorDoRelatorio("Filosofo 3 Tempo") + ""));
            filo3_Status.Invoke((MethodInvoker)(() => filo3_Status.Text = relatorio.pegaValorDoStatus("Filosofo 3 Status") + ""));

            filo4_Comeu.Invoke((MethodInvoker)(() => filo4_Comeu.Text = relatorio.pegaValorDoRelatorio("Filosofo 4 Comeu") + ""));
            filo4_Fome.Invoke((MethodInvoker)(() => filo4_Fome.Text = relatorio.pegaValorDoRelatorio("Filosofo 4 Fome") + ""));
            filo4_Pensou.Invoke((MethodInvoker)(() => filo4_Pensou.Text = relatorio.pegaValorDoRelatorio("Filosofo 4 Pensou") + ""));
            filo4_Tempo.Invoke((MethodInvoker)(() => filo4_Tempo.Text = relatorio.pegaValorDoRelatorio("Filosofo 4 Tempo") + ""));
            filo4_Status.Invoke((MethodInvoker)(() => filo4_Status.Text = relatorio.pegaValorDoStatus("Filosofo 4 Status") + ""));

            filo5_Comeu.Invoke((MethodInvoker)(() => filo5_Comeu.Text = relatorio.pegaValorDoRelatorio("Filosofo 5 Comeu") + ""));
            filo5_Fome.Invoke((MethodInvoker)(() => filo5_Fome.Text = relatorio.pegaValorDoRelatorio("Filosofo 5 Fome") + ""));
            filo5_Pensou.Invoke((MethodInvoker)(() => filo5_Pensou.Text = relatorio.pegaValorDoRelatorio("Filosofo 5 Pensou") + ""));
            filo5_Tempo.Invoke((MethodInvoker)(() => filo5_Tempo.Text = relatorio.pegaValorDoRelatorio("Filosofo 5 Tempo") + ""));
            filo5_Status.Invoke((MethodInvoker)(() => filo5_Status.Text = relatorio.pegaValorDoStatus("Filosofo 5 Status") + ""));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
