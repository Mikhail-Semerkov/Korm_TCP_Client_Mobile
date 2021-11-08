using Android.App;
using Android.OS;
using Android.Widget;
using Sockets.Plugin;
using System;
using System.Text;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using Android.Views;
using System.Collections.Generic;
using Plugin.Settings;
using System.Text.RegularExpressions;
using Android.Graphics;
using Android.Content;
using Xamarin.Forms.PlatformConfiguration;

namespace MenuActionBar
{
    [Activity(Label = "Korm TCP Client Mobile", MainLauncher = true)] //MainLauncher = true, Icon = "@drawable/icon")
    public class MainActivity : Activity
    {

        

        private TcpSocketClient _client;
        ///////////////////////////////////////////////int для ping//////////////////////////////////////////////
        private int pingsSent;
        readonly AutoResetEvent resetEvent = new AutoResetEvent(false);
        /////////////////////////////////////////////////////////////////////////////////////////////////////////


        private const int BufferSize = 256;
        private TextView _connectionStatus, _port, _synchvremyaLabel, _TimePingLabel, _connectedProgressBarLabel, _KalibrovkaLabel;
        private EditText _message, _KalibrovkaEditText, _ipText;
        private Button _connectButton, _DSButton, _KuhnButton, _clearButton, _probrosButton, _Kalibrovka_Send_Button, _proverkaversiiButton, _KalibrovkaButton, _Kalibrovka_Info_Button, _OchistkaKprmovogo_Button, _VPN_Button;
        private CheckBox _pingCheckBox;
        private ProgressBar _connectedProgress;
        public string SettingPort = CrossSettings.Current.GetValueOrDefault("Setting_Port", "4001");





        //Значение Стандартов
        private readonly string SUB = "";// Hex 1A
        private readonly string STX = "";// Hex 02
        private readonly string ETX = "";// Hex 03
        private readonly string ACK = "";// Hex 06
        private readonly string NAK = "";// Hex 15
        private readonly string CR = "";// Hex 0D
        private readonly string LF = "";// Hex 10
        private readonly string RS = "";// Hex 1E
        private readonly string ESC = "";// Hex 1B
        private readonly string EOT = "";// Hex 04


        //////////////Основные кнопки/////////////////
        private readonly string MENU = "1700";
        private readonly string SBROS = "6600";
        private readonly string PRINT = "2300";
        private readonly string ZERO = "4300";
        private readonly string UP = "4400";
        private readonly string DOWN = "2400";
        private readonly string LEFT = "4200";
        private readonly string RIGHT = "2200";
        private readonly string ENTER = "3300";
        private readonly string CLEAR = "1700";
        private readonly string ON = "0800";
        private readonly string SELECT = "2700";
        private readonly string ID = "1200";
        private readonly string HELP = "1300";
        private readonly string FUNCTION = "3700";
        private readonly string PENS = "1100";
        private readonly string RECIPE = "3100";
        private readonly string NETGROSS = "1000";
        private readonly string TARE = "4000";
        private readonly string TIMER = "4700";
        private readonly string HOLD = "2000";


        //Кнопки цифр
        private readonly string N0 = "1600";
        private readonly string N1 = "3400";
        private readonly string N2 = "4500";
        private readonly string N3 = "3500";
        private readonly string N4 = "2500";
        private readonly string N5 = "1500";
        private readonly string N6 = "1400";
        private readonly string N7 = "4600";
        private readonly string N8 = "3600";
        private readonly string N9 = "2600";




        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            
            _client = new TcpSocketClient();
            _connectionStatus = FindViewById<TextView>(Resource.Id.connectionStatus);
            _message = FindViewById<EditText>(Resource.Id.message);
            _connectButton = FindViewById<Button>(Resource.Id.connectButton);
            _connectButton.Click += ConnectButtonOnClick;
            _clearButton = FindViewById<Button>(Resource.Id.clearButton);
            _clearButton.Click += СlearButtonOnClick;
            _probrosButton = FindViewById<Button>(Resource.Id.probrosButton);
            _probrosButton.Click += ProbrosButtonOnClick;
            _ipText = FindViewById<EditText>(Resource.Id.ipText);
            _pingCheckBox = FindViewById<CheckBox>(Resource.Id.pingCheckBox);
            _port = FindViewById<TextView>(Resource.Id.portLabel);
            _proverkaversiiButton = FindViewById<Button>(Resource.Id.proverkaversiirButton);
            _proverkaversiiButton.Click += ProverkaVersiiButtonOnClick;
            _proverkaversiiButton.Visibility = ViewStates.Invisible;
            _connectedProgress = FindViewById<ProgressBar>(Resource.Id.connectedProgressBar);
            _connectedProgress.Visibility = ViewStates.Invisible;
            _synchvremyaLabel = FindViewById<TextView>(Resource.Id.SynchVremyaLabel);
            _synchvremyaLabel.Visibility = ViewStates.Invisible;
            _DSButton = FindViewById<Button>(Resource.Id.Digi_Star_Button);
            _DSButton.Visibility = ViewStates.Invisible;
            _DSButton.Click += _DSButton_Click;
            _KuhnButton = FindViewById<Button>(Resource.Id.Kuhn_Button);
            _KuhnButton.Click += _KuhnButton_Click;
            _KuhnButton.Visibility = ViewStates.Invisible;
            _KalibrovkaButton = FindViewById<Button>(Resource.Id.KalibrovkaButton);
            _KalibrovkaButton.Visibility = ViewStates.Invisible;
            _KalibrovkaLabel = FindViewById<TextView>(Resource.Id.KalibrovkaLabel);
            _KalibrovkaLabel.Visibility = ViewStates.Invisible;
            _KalibrovkaEditText = FindViewById<EditText>(Resource.Id.KalibrovkaEditText);
            _KalibrovkaEditText.Visibility = ViewStates.Invisible;
            _Kalibrovka_Send_Button = FindViewById<Button>(Resource.Id.Kalibrovka_Send_Button);
            _Kalibrovka_Send_Button.Visibility = ViewStates.Invisible;
            _Kalibrovka_Info_Button = FindViewById<Button>(Resource.Id.Kalibrovka_Info_Button);
            _Kalibrovka_Info_Button.Visibility = ViewStates.Invisible;
            _connectedProgressBarLabel = FindViewById<TextView>(Resource.Id.connectedProgressBarLabel);
            _connectedProgressBarLabel.Visibility = ViewStates.Invisible;
            _TimePingLabel = FindViewById<TextView>(Resource.Id.TimePingLabel);
            _TimePingLabel.Visibility = ViewStates.Invisible;
            _OchistkaKprmovogo_Button = FindViewById<Button>(Resource.Id.OchistkaKprmovogo_Button);



            _VPN_Button = FindViewById<Button>(Resource.Id.vpnButton);
            _VPN_Button.Click += delegate 
            {
                Intent intent_vpn = new Intent(Android.Provider.Settings.ActionVpnSettings);
                StartActivity(intent_vpn);
            };


            _OchistkaKprmovogo_Button.Click += delegate 
            {

            
                if (_client.Socket.Client.Connected == true)
                {

                    //Алерт окно
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    alert.SetTitle("Внимание!");
                    alert.SetMessage("Очистить кормовой лист?");
                    alert.SetPositiveButton("Применить", (senderAlert, args) => {


                        System.Net.Sockets.NetworkStream stream = _client.Socket.GetStream();
                        String s = ESC + "Re-99999" + EOT;
                        byte[] message = Encoding.ASCII.GetBytes(s);
                        stream.Write(message, 0, message.Length);
                        _message.Append("Очистка КОРМОВОГО ЛИСТА с памяти терминала\r\n");

                        Toast.MakeText(this, "Очистка кормового листа произведена", ToastLength.Short).Show();
                        

                    });
                    alert.SetNegativeButton("Отменить", (senderAlert, args) => {

                        Toast.MakeText(this, "Отменено", ToastLength.Short).Show();
                        

                    });
                    Dialog dialog = alert.Create();
                    dialog.Show();



                }
                else
                {
                    _message.Append("Вы не подключены\n");
                }

            };

            Spinner spinner = FindViewById<Spinner>(Resource.Id.spinner_dop_setting);

            spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.dop_setting_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;

            _connectedProgress.Click += delegate {


                _connectedProgress.Visibility = ViewStates.Invisible;
                _connectedProgressBarLabel.Visibility = ViewStates.Invisible;
                 _client.DisconnectAsync();
                _connectionStatus.Text = "Нет соединения";
                _connectButton.Text = "Подключиться";
                _message.Append("Соединение отменено\n");

            };

            _Kalibrovka_Send_Button.Click += delegate     
            {



  
                    if (_client.Socket.Client.Connected == true)
                    {
                        System.Net.Sockets.NetworkStream stream = _client.Socket.GetStream();

                        if (_KalibrovkaEditText.Text.Length <= 5 && _KalibrovkaEditText.Text.Length != 0)
                        {

                            //Алерт окно
                            AlertDialog.Builder alert = new AlertDialog.Builder(this);
                            alert.SetTitle("Внимание!");
                            alert.SetMessage("Изменить калибровку на: " + _KalibrovkaEditText.Text);
                            alert.SetPositiveButton("Применить", (senderAlert, args) => {


                                String s = ESC + "Gz" + _KalibrovkaEditText.Text + EOT;
                                _message.Append("Изменение Print Calibration Number на:" + _KalibrovkaEditText.Text + "\r\n");
                                byte[] message = Encoding.ASCII.GetBytes(s);
                                stream.Write(message, 0, message.Length);

                                Toast.MakeText(this, "Калиброка изменена на: " + _KalibrovkaEditText.Text, ToastLength.Short).Show();
                                _KalibrovkaEditText.Text = "";



                            });
                            alert.SetNegativeButton("Отменить", (senderAlert, args) => {

                                Toast.MakeText(this, "Отменено", ToastLength.Short).Show();
                                _KalibrovkaEditText.Text = "";

                            });
                                Dialog dialog = alert.Create();
                                dialog.Show();


                        }
                        else
                        {
                            _message.Append("Не правильный формат (1-99999)\n");
                        }

                    }
                    else
                    {
                        _message.Append("Вы не подключены\n");
                    }




            };

            _KalibrovkaButton.Click += delegate 
            {

                if (_client.Socket.Client.Connected == true)
                {

                    System.Net.Sockets.NetworkStream stream = _client.Socket.GetStream();
                    String s = ESC + "GZ" + EOT;
                    byte[] message = Encoding.ASCII.GetBytes(s);
                    stream.Write(message, 0, message.Length);


                }
                else
                {
                    _message.Append("Вы не подключены\n");
                }

            };

            _Kalibrovka_Info_Button.Click += delegate 
            {

                Toast.MakeText(this, "KUHN = 21922, DS = 10961", ToastLength.Long).Show();


            };


            //ActionBar//////////
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            toolbar.MenuItemClick += (sender, e) => {
                switch (e.Item.ItemId)
                {
                    case Resource.Id.menu_search:
                        StartActivity(typeof(SearchFerms));
                        break;
                    case Resource.Id.menu_sql:
                        StartActivity(typeof(SQL));
                        break;
                    case Resource.Id.menu_kuhn_tmr:
                        StartActivity(typeof(DocumentsKuhn));
                        break;
                    case Resource.Id.menu_digi_star:
                        StartActivity(typeof(DocumentsDS));
                        break;
                    case Resource.Id.menu_setting:
                        StartActivity(typeof(Setting));
                        break;
                    case Resource.Id.menu_exit:
                        Process.KillProcess(Process.MyPid());
                        break;     
                }
            };

            

            StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                if (_ipText.Text.Length > 3 && _ipText.Text.Length != 0)
                {
                    try
                    {
                        SendPing();
                    }
                    catch (Exception exception)
                    {
                        if (_pingCheckBox.Checked)
                        {
                            _message.Append(exception.Message + "\n");
                        }
                    }
                }
                return true; // True = Repeat again, False = Stop the timer
            });

            ///Setting
            _probrosButton.Text = "Проброс веса в формате: " + CrossSettings.Current.GetValueOrDefault("Setting_Probros", "Gs03");
            _port.Text = "Порт по умолчанию: " + CrossSettings.Current.GetValueOrDefault("Setting_Port", "4001");
            _ipText.Text = CrossSettings.Current.GetValueOrDefault("Setting_IPAddres", "192.168.127.254");
  
        }



        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            string Text_Setting = string.Format("{0}", spinner.GetItemAtPosition(e.Position));


            if(Text_Setting == "Синхронизация времени")
            {
                _synchvremyaLabel.Visibility = ViewStates.Visible;
                _DSButton.Visibility = ViewStates.Visible;
                _KuhnButton.Visibility = ViewStates.Visible;
                _proverkaversiiButton.Visibility = ViewStates.Visible;

                _KalibrovkaButton.Visibility = ViewStates.Invisible;
                _KalibrovkaLabel.Visibility = ViewStates.Invisible;
                _KalibrovkaEditText.Visibility = ViewStates.Invisible;
                _Kalibrovka_Send_Button.Visibility = ViewStates.Invisible;
                _Kalibrovka_Info_Button.Visibility = ViewStates.Invisible;

                _OchistkaKprmovogo_Button.Visibility = ViewStates.Invisible;

            }
            if (Text_Setting == "Калибровки терминала")
            {
                _synchvremyaLabel.Visibility = ViewStates.Invisible;
                _DSButton.Visibility = ViewStates.Invisible;
                _KuhnButton.Visibility = ViewStates.Invisible;
                _proverkaversiiButton.Visibility = ViewStates.Invisible;

                _KalibrovkaButton.Visibility = ViewStates.Visible;
                _KalibrovkaLabel.Visibility = ViewStates.Visible;
                _KalibrovkaEditText.Visibility = ViewStates.Visible;
                _Kalibrovka_Send_Button.Visibility = ViewStates.Visible;
                _Kalibrovka_Info_Button.Visibility = ViewStates.Visible;

                _OchistkaKprmovogo_Button.Visibility = ViewStates.Invisible;

            }
            if(Text_Setting == "Очистка кормового листа")
            {

                _synchvremyaLabel.Visibility = ViewStates.Invisible;
                _DSButton.Visibility = ViewStates.Invisible;
                _KuhnButton.Visibility = ViewStates.Invisible;
                _proverkaversiiButton.Visibility = ViewStates.Invisible;
                _KalibrovkaButton.Visibility = ViewStates.Invisible;
                _KalibrovkaLabel.Visibility = ViewStates.Invisible;
                _KalibrovkaEditText.Visibility = ViewStates.Invisible;
                _Kalibrovka_Send_Button.Visibility = ViewStates.Invisible;
                _Kalibrovka_Info_Button.Visibility = ViewStates.Invisible;

                _OchistkaKprmovogo_Button.Visibility = ViewStates.Visible;


            }
            else if(Text_Setting == "Не выбрано")
            {
                _synchvremyaLabel.Visibility = ViewStates.Invisible;
                _DSButton.Visibility = ViewStates.Invisible;
                _KuhnButton.Visibility = ViewStates.Invisible;
                _proverkaversiiButton.Visibility = ViewStates.Invisible;
                _KalibrovkaButton.Visibility = ViewStates.Invisible;
                _KalibrovkaLabel.Visibility = ViewStates.Invisible;
                _KalibrovkaEditText.Visibility = ViewStates.Invisible;
                _Kalibrovka_Send_Button.Visibility = ViewStates.Invisible;
                _Kalibrovka_Info_Button.Visibility = ViewStates.Invisible;
                _OchistkaKprmovogo_Button.Visibility = ViewStates.Invisible;
            }


        }


        private void SendPing()
        {
            Ping pingSender = new Ping();
            pingSender.PingCompleted += new PingCompletedEventHandler(PingSender_Complete);
            byte[] packetData = Encoding.ASCII.GetBytes(".......................");
            PingOptions packetOptions = new PingOptions(50, true);
            pingSender.SendAsync(_ipText.Text, 1700, packetData, packetOptions, resetEvent);



        }

        private void PingSender_Complete(object sender, PingCompletedEventArgs e)
        {

            if (e.Cancelled)
            {
                _message.Append("Пинг был отменен...\n");
                ((AutoResetEvent)e.UserState).Set();
            }
            else if (e.Error != null)
            {
                _message.Append("Произошла ошибка: " + e.Error + "\n");
                ((AutoResetEvent)e.UserState).Set();
            }
            else
            {
                PingReply pingResponse = e.Reply;
                ShowPingResults(pingResponse);
            }
        }

        public void ShowPingResults(PingReply pingResponse)
        {

            if (pingResponse.Status == IPStatus.Success)
            {

                string TimePingString = pingResponse.RoundtripTime.ToString();

                if (_pingCheckBox.Checked)
                {
                    _message.Append("Пинг " + pingResponse.Address.ToString() + ": БАЙТ = " + pingResponse.Buffer.Length + ", МС = " + pingResponse.RoundtripTime + ", TTL = " + pingResponse.Options.Ttl + "\n");
                }
                if (_client.Socket.Client.Connected == true)
                {
                    _TimePingLabel.Visibility = ViewStates.Visible;
                    _TimePingLabel.Text = "Задержка соединения: " + TimePingString + "мс";
                    int TimePingInt = int.Parse(TimePingString);

                    if (TimePingInt >= 0)
                    {
                        _TimePingLabel.SetBackgroundColor(Color.Rgb(0, 255, 0));
                    }

                    if (TimePingInt >= 20)
                    {
                        _TimePingLabel.SetBackgroundColor(Color.Rgb(50, 255, 0));
                    }

                    if (TimePingInt >= 40)
                    {
                        _TimePingLabel.SetBackgroundColor(Color.Rgb(100, 255, 0));
                    }

                    if (TimePingInt >= 60)
                    {
                        _TimePingLabel.SetBackgroundColor(Color.Rgb(150, 255, 0));
                    }

                    if (TimePingInt >= 80)
                    {
                        _TimePingLabel.SetBackgroundColor(Color.Rgb(200, 255, 0));
                    }

                    if (TimePingInt >= 100)
                    {
                        _TimePingLabel.SetBackgroundColor(Color.Rgb(255, 255, 0));
                    }

                    if (TimePingInt >= 120)
                    {
                        _TimePingLabel.SetBackgroundColor(Color.Rgb(255, 200, 0));
                    }

                    if (TimePingInt >= 140)
                    {
                        _TimePingLabel.SetBackgroundColor(Color.Rgb(255, 150, 0));
                    }

                    if (TimePingInt >= 160)
                    {
                        _TimePingLabel.SetBackgroundColor(Color.Rgb(255, 100, 0));
                    }

                    if (TimePingInt >= 180)
                    {
                        _TimePingLabel.SetBackgroundColor(Color.Rgb(255, 80, 0));
                    }



                }
                if (_client.Socket.Client.Connected == false)
                {
                    _TimePingLabel.Text = "Адрес недоступен";
                    _TimePingLabel.SetBackgroundColor(Color.Rgb(255, 0, 0));
                }

            }
            else
            {
                if (_pingCheckBox.Checked)
                {
                    _message.Append("Нет соединения\n");
                }

                _TimePingLabel.Text = "Адрес недоступен";
                _TimePingLabel.SetBackgroundColor(Color.Rgb(255, 0, 0));
            }

            pingsSent++;

            if (pingsSent < 0)
            {
                SendPing();
            }
        }



        private void _KuhnButton_Click(object sender, EventArgs e)
        {


            if (_client.Socket.Client.Connected == true)
            {

                
                //Алерт окно
                AlertDialog.Builder alert = new AlertDialog.Builder(this);
                alert.SetTitle("Внимание!");
                alert.SetMessage("Синхронизировать время для KUHN?");
                alert.SetPositiveButton("Применить", (senderAlert, args) => {


                    string current = DateTime.Now.ToString("HHmmss");
                    string current_label = DateTime.Now.ToString("HH:mm:ss");
                    char[] charMas = current.ToCharArray();
                    string msg;
                    string time_swich = "";
                    foreach (var a in charMas)
                    {
                        switch (a)
                        {
                            case '1': time_swich += N1 + RIGHT; break;
                            case '2': time_swich += N2 + RIGHT; break;
                            case '3': time_swich += N3 + RIGHT; break;
                            case '4': time_swich += N4 + RIGHT; break;
                            case '5': time_swich += N5 + RIGHT; break;
                            case '6': time_swich += N6 + RIGHT; break;
                            case '7': time_swich += N7 + RIGHT; break;
                            case '8': time_swich += N8 + RIGHT; break;
                            case '9': time_swich += N9 + RIGHT; break;
                            case '0': time_swich += N0 + RIGHT; break;

                        }


                    }
                    Thread.Sleep(100);

                    msg = time_swich + ON + CLEAR + CLEAR;
                    string opt = N1 + N2 + N0 + N2 + SELECT;



                    System.Net.Sockets.NetworkStream stream = _client.Socket.GetStream();

                    byte[] message1 = Encoding.ASCII.GetBytes(opt);
                    stream.Write(message1, 0, message1.Length);

                    Thread.Sleep(1500);

                    byte[] message2 = Encoding.ASCII.GetBytes(msg);
                    stream.Write(message2, 0, message2.Length);

                    _message.Append("Произведена синхронизация времени KUHN на: "  + current_label + "\n");
                    Thread.Sleep(100);
                    Toast.MakeText(this, "Синхронизация произведена", ToastLength.Short).Show();

                    
                });
                alert.SetNegativeButton("Отменить", (senderAlert, args) => {

                    Toast.MakeText(this, "Отменено", ToastLength.Short).Show();
                    

                });
                Dialog dialog = alert.Create();
                dialog.Show();



            }
            else
            {
                _message.Append("Вы не подключены\n");
            }
        }
    

        private void _DSButton_Click(object sender, EventArgs e)
        {
            if (_client.Socket.Client.Connected == true)
            {
                

                //Алерт окно
                AlertDialog.Builder alert = new AlertDialog.Builder(this);
                alert.SetTitle("Внимание!");
                alert.SetMessage("Синхронизировать время для Digi-Star?");
                alert.SetPositiveButton("Применить", (senderAlert, args) => {

                    
                    string current = DateTime.Now.ToString("HHmmss");
                    string current_label = DateTime.Now.ToString("HH:mm:ss");
                    char[] charMas = current.ToCharArray();
                    string msg;
                    string time_swich = "";
                    foreach (var a in charMas)
                    {
                        switch (a)
                        {
                            case '1': time_swich += N1; break;
                            case '2': time_swich += N2; break;
                            case '3': time_swich += N3; break;
                            case '4': time_swich += N4; break;
                            case '5': time_swich += N5; break;
                            case '6': time_swich += N6; break;
                            case '7': time_swich += N7; break;
                            case '8': time_swich += N8; break;
                            case '9': time_swich += N9; break;
                            case '0': time_swich += N0; break;

                        }


                    }
                    Thread.Sleep(100);

                    msg = time_swich + ON;


                    string opt = N2 + N0 + N2 + SELECT;


                    System.Net.Sockets.NetworkStream stream = _client.Socket.GetStream();

                    byte[] message1 = Encoding.ASCII.GetBytes(opt);
                    stream.Write(message1, 0, message1.Length);

                    Thread.Sleep(1500);

                    byte[] message2 = Encoding.ASCII.GetBytes(msg);
                    stream.Write(message2, 0, message2.Length);

                    _message.Append("Произведена синхронизация времени DIGI-STAR на: " + current_label + "\n");
                    Thread.Sleep(100);
                    Toast.MakeText(this, "Синхронизация произведена", ToastLength.Short).Show();

                    
                });
                alert.SetNegativeButton("Отменить", (senderAlert, args) => {

                    Toast.MakeText(this, "Отменено", ToastLength.Short).Show();


                });
                Dialog dialog = alert.Create();
                dialog.Show();

            }
            else
            {
                _message.Append("Вы не подключены\n");
            }
        }

        private void ProverkaVersiiButtonOnClick(object sender, EventArgs e)
        {
            if (_client.Socket.Client.Connected == true)
            {

                System.Net.Sockets.NetworkStream stream = _client.Socket.GetStream();
                String s = ESC + "GW" + EOT;
                byte[] message = Encoding.ASCII.GetBytes(s);
                stream.Write(message, 0, message.Length);

            }
            else
            {
                _message.Append("Вы не подключены\n");
            }
        }

        public override bool OnCreateOptionsMenu(Android.Views.IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.top_menus, menu);
            return base.OnCreateOptionsMenu(menu);

        }

        public override bool OnOptionsItemSelected(Android.Views.IMenuItem item)
        {
            Toast.MakeText(this, "Action selected: " + item.TitleFormatted,
                ToastLength.Short).Show();
            return base.OnOptionsItemSelected(item);
        }




        private void СlearButtonOnClick(object sender, EventArgs eventArgs)
        {
            _message.Text = "";
        }


        public void ProbrosButtonOnClick(object sender, EventArgs eventArgs)
        {

            if (_client.Socket.Client.Connected == true)
            {
                
                System.Net.Sockets.NetworkStream stream = _client.Socket.GetStream();
                String s = "" + CrossSettings.Current.GetValueOrDefault("Setting_Probros", "Gs03") + "";
                byte[] message = Encoding.ASCII.GetBytes(s);
                stream.Write(message, 0, message.Length);
               

            }
            else
            {
                _message.Append("Вы не подключены\n");
            }

        }


        public async void ConnectButtonOnClick(object sender, EventArgs eventArgs)
        {
            
            _connectionStatus.Text = "Соединение с " + _ipText.Text;
            _connectedProgress.Visibility = ViewStates.Visible;
            _connectedProgressBarLabel.Text = _connectionStatus.Text + "\n" + "Для отмены кликните по значку!";
            _connectedProgressBarLabel.Visibility = ViewStates.Visible;
            _pingCheckBox.Checked = false;
          
            CrossSettings.Current.AddOrUpdateValue("Setting_IPAddres", _ipText.Text);


            try
            {

                if (_client.Socket.Client.Connected == false)
                {

                    
                    await _client.ConnectAsync(_ipText.Text, int.Parse(SettingPort));
                    
                    _connectionStatus.Text = "Подключено к " + _ipText.Text;
                    _connectButton.Text = "Отключиться";
                    _message.Append("[" + DateTime.Now.ToString("g") + "]" + " Вы успешно подключились к " + _ipText.Text + "\n");
                    _connectedProgress.Visibility = ViewStates.Invisible;
                    _connectedProgressBarLabel.Visibility = ViewStates.Invisible;
                    

                    var buffer = new byte[BufferSize];
                    var actuallyRead = 0;
                    
                    do
                    {


                        actuallyRead = await _client.Socket.GetStream().ReadAsync(buffer, 0, buffer.Length);
                        _message.Append(Encoding.ASCII.GetString(buffer, 0, actuallyRead));
                        
                        



                    } while (actuallyRead != 0);

                }

                if (_client.Socket.Client.Connected == true)
                {

                    _connectedProgress.Visibility = ViewStates.Invisible;
                    _connectedProgressBarLabel.Visibility = ViewStates.Invisible;
                    
                    await _client.DisconnectAsync();
                    _TimePingLabel.Visibility = ViewStates.Invisible;
                    _connectionStatus.Text = "Нет соединения";
                    _connectButton.Text = "Подключиться";
                    _message.Append("[" + DateTime.Now.ToString("g") + "]" + " Вы отключились от " + _ipText.Text + "\n");

                }

            }
            catch (Exception exception)
            {

                if (exception.Message != "Unable to read data from the transport connection: Operation aborted." && exception.Message != "Object reference not set to an instance of an object.")
                {
                    


                    _message.Append("[" + DateTime.Now.ToString("g") + "]" + " Ошибка подключения(" + exception.Message + ")\n");

                    _connectionStatus.Text = "Нет соединения";
                    _connectedProgress.Visibility = ViewStates.Invisible;
                    _connectedProgressBarLabel.Visibility = ViewStates.Invisible;
                }

            }


        }

        public void StartTimer(TimeSpan interval, Func<bool> callback)
        {
            var handler = new Handler(Looper.MainLooper);
            handler.PostDelayed(() => {
                if (callback())
                    StartTimer(interval, callback);

                handler.Dispose();
                handler = null;
            }, (long)interval.TotalMilliseconds);
        }


    }


}