using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*>>>>> IMPORTANTE <<<<<<<<
 Primero hay que vincularlo desde la pc.
 Si se tiene una pc con bluetooth, asigne automaticamente el puerto saliente del Bluetooth una vez que se lo vincula.
 El COM saliente se puede consultar en 
 "Configuración de bluetooth y otros dispositivos -> Mas opciones de Bluetooth -> Puertos COM".
 Si se tiene un módulo bluetooth para PC se debe agregar el puerto saliente manualmente*/

namespace ArduinoBluetooth
{
    public partial class Form1 : Form
    {
        private SerialPort puerto;
        const char DELIMITADOR = '-';
        public Form1()
        {
            InitializeComponent();
    
        }

        private void RecibirDatos()
        {
            // Corrobora solo si el puerto está cerrado (si el dispositivo esta vinculado pero desconectado
            //el puerto sigue abierto
            if (puerto.IsOpen)
            {
                puerto.DataReceived += Puerto_DataReceived;
            }
            else
            {
                MessageBox.Show("Se perdio la conexion");
                Conectar.Enabled = true;
                Desconectado.Text = "Desconectado";
            }

        }

        private void AbrirConexion()
        {
            try
            {
                puerto = new SerialPort();
                puerto.PortName = ListaPuertosCOM.SelectedItem.ToString(); //puerto saliente del bluetooth
                puerto.BaudRate = 9600;
                puerto.DtrEnable = true;
                puerto.Open();
                Conectar.Enabled = false;
                Desconectado.Text = "Conectado";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Puerto_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string linea = "";
            try
            {
                linea = puerto.ReadLine();
                this.BeginInvoke(new LineReceivedEvent(LineReceived), linea);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private delegate void LineReceivedEvent(string linea);
        private void LineReceived(string linea)
        {
            lbRecibeT.Text = linea;
        }


        private void enviar_Click(object sender, EventArgs e)
        {
            string tx = tbEnviaT.Text;
            // Corrobora solo si el puerto está cerrado (si el dispositivo esta vinculado pero desconectado
            //el puerto sigue abierto
            if (puerto.IsOpen)
            {
                puerto.Write(tx + DELIMITADOR);
                RecibirDatos(); //este metodo se puede poner en cualquier lado mientras que esté establecida la conexion
                tbEnviaT.Text = "";
            }
            else
            {
                MessageBox.Show("Se perdio la conexion");
                Conectar.Enabled = true;
                Desconectado.Text = "Desconectado";
            }
        }

        private void ListaPuertosCOM_Click(object sender, EventArgs e)
        {
            ListaPuertosCOM.Items.Clear();// Por si se borra el puerto, que recargue y muestre puertos disponibles
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                ListaPuertosCOM.Items.Add(port);
            }
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            if(ListaPuertosCOM.SelectedIndex > -1)
            {
                AbrirConexion();
            }
            else
            {
                MessageBox.Show("Seleccionar puerto");
            }
                
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            puerto.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            AgregarDispositivo();
        }

        void AgregarDispositivo()
        {
            try
            {  //Ejecutable para vincular el dispositivo
                Process p = Process.Start("C:\\Windows\\System32\\DevicePairingWizard.exe");
                while(true)
                {
                    if (p.HasExited) //Determina si el proceso termina
                        break;
                }    
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        
    }
}
