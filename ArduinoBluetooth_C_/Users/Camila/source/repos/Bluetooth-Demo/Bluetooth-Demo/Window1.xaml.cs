using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace Bluetooth_Demo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        BackgroundWorker bg;
        public Window1()
        {
            InitializeComponent();
            bg = new BackgroundWorker();
            bg.DoWork += new DoWorkEventHandler(bg_DoWork);
            bg.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_RunWorkerCompleted);
        }

        void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            device_list.ItemsSource = (List<Device>)e.Result;
            pb.Visibility = Visibility.Hidden;
        }

        void bg_DoWork(object sender, DoWorkEventArgs e)
        {
List<Device> devices = new List<Device>();
InTheHand.Net.Sockets.BluetoothClient bc = new InTheHand.Net.Sockets.BluetoothClient();
InTheHand.Net.Sockets.BluetoothDeviceInfo[] array = bc.DiscoverDevices();
int count = array.Length;
for (int i = 0; i < count; i++)
{
    Device device = new Device(array[i]);
    devices.Add(device);
}
e.Result = devices;
        }

        private void btn_find_Click(object sender, RoutedEventArgs e)
        {
            if (!bg.IsBusy)
            {
                pb.Visibility = Visibility.Visible;
                bg.RunWorkerAsync();
            }
        }

        private void device_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (device_list.SelectedItem != null)
            {
                Device device = (Device)device_list.SelectedItem;

                txt_authenticated.Text = device.Authenticated.ToString();
                txt_connected.Text = device.Connected.ToString();
                txt_devicename.Text = device.DeviceName;
                txt_lastseen.Text = device.LastSeen.ToString();
                txt_lastused.Text = device.LastUsed.ToString();
                txt_nap.Text = device.Nap.ToString();
                txt_remembered.Text = device.Remembered.ToString();
                txt_sap.Text = device.Sap.ToString();
            }
        }
    }
}
