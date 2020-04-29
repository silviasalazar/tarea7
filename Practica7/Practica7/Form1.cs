using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Practica7
{
    public partial class Form1 : Form
    {
        private TaskScheduler _secuencial;
        
        
        //Se crea el hilo
        Thread hilo;
        //Actualizar Progress bar
        delegate void delegado(int valor);
        public Form1()
        {
            InitializeComponent();
            _secuencial = TaskScheduler.FromCurrentSynchronizationContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            
            hilo = new Thread(new ThreadStart(Progreso1));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Progreso2));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Progreso3));
            hilo.Start();

        }
        
        //Incrementantan valoren es las barras
        public void Progreso1()
        {
            
            for(int i=0;i<=100;i++)
            {
                Delegate MD = new delegado(Actualizar1);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(50);
            }
            CheckForIllegalCrossThreadCalls = false;
            
            //Imprimir numeros del 1 al 1000
            for(int i=0;i<=1000;i++)
            {
                textBox1.Text += i.ToString()+ Environment.NewLine;
            }
          

            
        }
      
        //Actualiza barra de progreso
        public void Actualizar1(int valor)
        {
            progress1.Value = valor;
        }
       

        public void Progreso2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Delegate MD = new delegado(Actualizar2);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(40);
            }
            CheckForIllegalCrossThreadCalls = false;

            //Genera 100 numeros aleatorios
            Random random = new Random();
            for(int i=0;i<=100;i++)
            {
                
               textBox2.Text += (random.Next(0, 11)).ToString()+ Environment.NewLine;
            }

        }
        public void Actualizar2(int valor)
        {
            progress2.Value = valor;
        }
        public void Progreso3()
        {
            for (int i = 0; i <= 100; i++)
            {
                Delegate MD = new delegado(Actualizar3);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(30);
            }
            CheckForIllegalCrossThreadCalls = false;
            //calcular media
            string cadena1 = "56782469104569875698452";
            double suma = 0.0;
            for (int i = 0; i < cadena1.Length; i++)
            {
                suma = suma + Convert.ToInt32(cadena1.Substring(i, 1));
            }
            double resultado = suma / cadena1.Length;


            textBox3.Text = "La media aritmetica es: " + resultado.ToString();

        }
        public void Actualizar3(int valor)
        {
            progress3.Value = valor;
        }

        private void btnSecuencial_Click(object sender, EventArgs e)
        {
            new Task(() =>
            {
                Task[] tareas = {
                Task.Factory.StartNew(() => IncreaseValue(textBox4, progressBar4, 100,1), CancellationToken.None, TaskCreationOptions.LongRunning, _secuencial),
                Task.Factory.StartNew(() => IncreaseValue(textBox5, progressBar5, 100, 1), CancellationToken.None, TaskCreationOptions.LongRunning, _secuencial),
                Task.Factory.StartNew(() => IncreaseValue(textBox6, progressBar6, 100, 1), CancellationToken.None, TaskCreationOptions.LongRunning, _secuencial),
                
                };
                Task.WaitAll(tareas);

            }).Start();

          
            

        }
        private void IncreaseValue(TextBox t, ProgressBar p, int r, int c)
        {
            CheckForIllegalCrossThreadCalls = false;
            p.Maximum = r;
             for (int i = 0; i <= r; i++)
             {
                 int result = i *c;

                 Thread.Sleep(10);

                 UpdateView(t, p, result, c);
             }
            

            //Imprimir numeros del 1 al 1000
            for (int i = 0; i <= 1000; i++)
            {
                t.Text += i.ToString() + Environment.NewLine;
            }
            

            //Genera 100 numeros aleatorios
            Random random = new Random();
            for (int i = 0; i <= 100; i++)
            {

                t.Text += (random.Next(0, 11)).ToString() + Environment.NewLine;
            }


            //calcular media
            string cadena1 = "56782469104569875698452";
            double suma = 0.0;
            for (int i = 0; i < cadena1.Length; i++)
            {
                suma = suma + Convert.ToInt32(cadena1.Substring(i, 1));
            }
            double resultado = suma / cadena1.Length;


            t.Text = "La media aritmetica es: " + resultado.ToString();


        }

        private void UpdateView(TextBox t, ProgressBar p, int result, int c)
        {
            p.Value = result;
          
            //t.Text += "Count: " + result + Environment.NewLine;
            t.SelectionStart = t.Text.Length;
            t.ScrollToCaret();
            Application.DoEvents();
        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            progress1.Value = 0;
            progress2.Value = 0;
            progress3.Value = 0;
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            progressBar4.Value = 0;
            progressBar5.Value = 0;
            progressBar6.Value = 0;
        }
    }
}
