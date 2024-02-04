using System;
using System.Diagnostics;

namespace paralelo_app_racer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)

        {
            int[] arreglo = ObtenerArregloDesdeTextBox();

            if (arreglo != null)
            {
                int objetivo;
                if (int.TryParse(txtnumero.Text, out objetivo))
                {
                    Stopwatch stopwatch = new Stopwatch();

                    Thread busquedaSecuencialThread = new Thread(() => EjecutarBusquedaSecuencial(arreglo, objetivo, stopwatch));
                    Thread busquedaBinariaThread = new Thread(() => EjecutarBusquedaBinaria(arreglo, objetivo, stopwatch));
                    Thread burbujaThread = new Thread(() => EjecutarBurbuja(arreglo, stopwatch));
                    Thread quickSortThread = new Thread(() => EjecutarQuickSort(arreglo, stopwatch));
                    Thread insercionThread = new Thread(() => EjecutarInsercion(arreglo, stopwatch));

                    busquedaSecuencialThread.Start();
                    busquedaBinariaThread.Start();
                    burbujaThread.Start();
                    quickSortThread.Start();
                    insercionThread.Start();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido como objetivo.");
                }
            }
        }


        private void EjecutarBusquedaSecuencial(int[] arreglo, int objetivo, Stopwatch stopwatch)
        {
            List<long> tiempos = new List<long>();
            bool resultado = false; // Inicializar el resultado
            for (int i = 0; i < 10; i++) // Ejecutar 10000 veces

            {
                stopwatch.Restart();
                resultado = algoritmos.BusquedaSecuencial(arreglo, objetivo);
                stopwatch.Stop();
                tiempos.Add(stopwatch.ElapsedTicks);
            }
            long tiempoPromedio = (long)tiempos.Average();
            MostrarTiempo(txtbsecuencial, tiempoPromedio);
        }

        private void EjecutarBusquedaBinaria(int[] arreglo, int objetivo, Stopwatch stopwatch)
        {
            List<long> tiempos = new List<long>();
            bool resultado = false; // Inicializar el resultado
            for (int i = 0; i < 10; i++) // Ejecutar 10000 veces
            {
                stopwatch.Restart();
                resultado = algoritmos.BusquedaBinaria(arreglo, objetivo);
                stopwatch.Stop();
                tiempos.Add(stopwatch.ElapsedTicks);
            }
            long tiempoPromedio = (long)tiempos.Average();
            MostrarTiempo(txtbinaria, tiempoPromedio);
        }

        private void EjecutarBurbuja(int[] arreglo, Stopwatch stopwatch)
        {
            List<long> tiempos = new List<long>();
            for (int i = 0; i < 10; i++) // Ejecutar 10000 veces
            {
                int[] copiaBurbuja = (int[])arreglo.Clone(); // Crear una copia del arreglo para no modificar el original
                stopwatch.Restart();
                algoritmos.Burbuja(copiaBurbuja);
                stopwatch.Stop();
                tiempos.Add(stopwatch.ElapsedTicks);
            }
            long tiempoPromedio = (long)tiempos.Average();
            MostrarTiempo(txtburbuja, tiempoPromedio);
        }

        private void EjecutarQuickSort(int[] arreglo, Stopwatch stopwatch)
        {
            List<long> tiempos = new List<long>();
            for (int i = 0; i < 10; i++) // Ejecutar 10000 veces
            {
                int[] copiaQuickSort = (int[])arreglo.Clone();
                stopwatch.Restart();
                algoritmos.QuickSort(copiaQuickSort, 0, copiaQuickSort.Length - 1);
                stopwatch.Stop();
                tiempos.Add(stopwatch.ElapsedTicks);
            }
            long tiempoPromedio = (long)tiempos.Average();
            MostrarTiempo(txtquick, tiempoPromedio);
        }

        private void EjecutarInsercion(int[] arreglo, Stopwatch stopwatch)
        {
            List<long> tiempos = new List<long>();
            for (int i = 0; i < 10; i++) // Ejecutar 10000 veces
            {
                int[] copiaInsercion = (int[])arreglo.Clone();
                stopwatch.Restart();
                algoritmos.Insercion(copiaInsercion);
                stopwatch.Stop();
                tiempos.Add(stopwatch.ElapsedTicks);
            }
            long tiempoPromedio = (long)tiempos.Average();
            MostrarTiempo(txtinsercion, tiempoPromedio);
        }

        private void MostrarResultado(TextBox textBox, bool resultado)
        {
            textBox.Invoke((MethodInvoker)delegate
            {
                textBox.Text = resultado ? "Encontrado" : "No encontrado";
            });
        }

        private void MostrarMensaje(TextBox textBox, string mensaje)
        {
            textBox.Invoke((MethodInvoker)delegate
            {
                textBox.Text = mensaje;
            });
        }

        private void MostrarTiempo(TextBox text, long tiempoTicks)
        {
            double tiempoSegundos = (double)tiempoTicks / Stopwatch.Frequency;
            text.Invoke((MethodInvoker)delegate
            {
                text.Text = $"{tiempoSegundos:F9} seg"; // Mostrar tiempo en segundos con nueve decimales
            });
        }

        private int[] ObtenerArregloDesdeTextBox()
        {
            string[] valoresTexto = txtarreglo.Text.Split(',');

            int[] arreglo = new int[valoresTexto.Length];
            for (int i = 0; i < valoresTexto.Length; i++)
            {
                if (int.TryParse(valoresTexto[i], out int valor))
                {
                    arreglo[i] = valor;
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa números separados por comas.");
                    return null;
                }
            }

            return arreglo;
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            {
                txtarreglo.Text = "";
                txtnumero.Text = "";
                txtburbuja.Text = "";
                txtquick.Text = "";
                txtinsercion.Text = "";
                txtbsecuencial.Text = "";
                txtbinaria.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void generar_Click(object sender, EventArgs e)
        {
            int[] array = new int[1000];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 1000);
            }
            txtarreglo.Text = string.Join(",", array);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}