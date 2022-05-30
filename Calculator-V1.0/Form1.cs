using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myapp
{
    public partial class Form1 : Form
    {
        private const string V = "-";
        private const string V1 = "+";
        private const string V2 = "*";
        private const string V3 = "/";
        private const string V4 = "!";
        private const string V5 = "=";
        private string _islem;
        private string _esitesit;
        private string _islem2;
        private bool _temizleme;
        private float _sayi1,_sayi2;
        private bool _isaret;
        private bool _isaretfakt;
        private string _isareti;
        private bool _esitmi;
        private float _islemne;

        public Form1()
        {
            InitializeComponent();
        }

        // +/-
        private void artieksiButon_Click(object sender, EventArgs e)
        {
            _isaretfakt = true;
            _isaret = true;
            if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
            _temizleme = false;
            ekranLabel.Text += V;
        
        }

        //1
        private void rakam1Buton_Click(object sender, EventArgs e)
        {
            if(_temizleme)
            {
                ekranLabel.Text = "";
                _temizleme = false;
            }
            if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        //2
        private void rakam2Buton_Click(object sender, EventArgs e)
        {
            if (_temizleme)
            {
                ekranLabel.Text = "";
                _temizleme = false;
            }
            if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        //3
        private void rakam3Buton_Click(object sender, EventArgs e)
        {
            if (_temizleme)
            {
                ekranLabel.Text = "";
                _temizleme = false;
            }
            if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        //4
        private void rakam4Buton_Click(object sender, EventArgs e)
        {
            if (_temizleme)
            {
                ekranLabel.Text = "";
                _temizleme = false;
            }
            if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        //5
        private void rakam5Buton_Click(object sender, EventArgs e)
        {
            if (_temizleme)
            {
                ekranLabel.Text = "";
                _temizleme = false;
            }
            if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        //6
        private void rakam6Buton_Click(object sender, EventArgs e)
        {
            if (_temizleme)
            {
                ekranLabel.Text = "";
                _temizleme = false;
            }
            if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        //7
        private void rakam7Buton_Click(object sender, EventArgs e)
        {
            if (_temizleme)
            {
                ekranLabel.Text = "";
                _temizleme = false;
            }
            if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        //8
        private void rakam8Buton_Click(object sender, EventArgs e)
        {
            if (_temizleme)
            {
                ekranLabel.Text = "";
                _temizleme = false;
            }
            if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        //9
        private void rakam9Buton_Click(object sender, EventArgs e)
        {
            if (_temizleme)
            {
                ekranLabel.Text = "";
                _temizleme = false;
            }
            if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        //0
        private void rakam0Buton_Click(object sender, EventArgs e)
        {

            if (_temizleme)
            {
                ekranLabel.Text = "";
                _temizleme = false;
            }
            if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        // ,
        private void virgulButon_Click(object sender, EventArgs e)
        {
            ekranLabel.Text += ",";
        }

        // Delete
        private void silButon_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = ekranLabel.Text.Substring(0, ekranLabel.Text.Length - 1);
        }

        // C
        private void yenidenButon_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
            islemekranLabel.Text = "";
        }

        //+
        private void toplaButon_Click(object sender, EventArgs e)
        {
            _islem = V1;
            _islem2 = V5;
            _temizleme = true;
            islemekranLabel.Text += ekranLabel.Text;
            _sayi1 = float.Parse(ekranLabel.Text);
            if (_isaret)
            {
                _sayi1 = (-1) * _sayi1;
            }
        }

        //-
        private void cikarButon_Click(object sender, EventArgs e)
        {
            _islem = V;
            _islem2 = V5;
            _temizleme = true;
            islemekranLabel.Text += ekranLabel.Text;
            _sayi1 = float.Parse(ekranLabel.Text);
            if (_isaret)
            {
                _sayi1 = (-1) * _sayi1;
            }
        }

        //*
        private void carpButon_Click(object sender, EventArgs e)
        {
            _islem = V2;
            _islem2 = V5;
            _temizleme = true;
            islemekranLabel.Text += ekranLabel.Text;
            _sayi1 = float.Parse(ekranLabel.Text);
            if (_isaret)
            {
                _sayi1 = (-1) * _sayi1;
            }
        }

        // /
        private void bolButon_Click(object sender, EventArgs e)
        {
            _islem = V3;
            _islem2 = V5;
            _temizleme = true;
            islemekranLabel.Text += ekranLabel.Text;
            _sayi1 = float.Parse(ekranLabel.Text);
            if (_isaret)
            {
                _sayi1 = (-1) * _sayi1;
            }
        }

        //x!
        private void fakButon_Click(object sender, EventArgs e)
        {
        if (_isaretfakt) ekranLabel.Text = V4;
        else
        {
            _islem = V4;
            islemekranLabel.Text += ekranLabel.Text;
            _sayi1 = float.Parse(ekranLabel.Text);
            if (_isaret)
            {
                ekranLabel.Text = "";
            }
        }
        }

        //+/-/*//
        private void esittirButon_Click(object sender, EventArgs e)
        {
            float esittir;
            float fak=1;
            string esit;


            islemekranLabel.Text += ekranLabel.Text;
            _sayi2 = float.Parse(ekranLabel.Text);
            if (_isaret) _isareti = "- ";
            else _isareti = null;

            switch (_islem)
            {
                case V1:
                    islemekranLabel.Text = (_isareti + _sayi1 + " + " + _sayi2 + " =");
                    if (_isaret) esittir = ((-1) * _sayi1 + _sayi2);
                    else esittir = (_sayi1 + _sayi2);
                    _islemne = esittir;
                    _esitmi = true;
                    break;

                case V:
                    islemekranLabel.Text = (_isareti + _sayi1 + " - " + _sayi2 + " =");
                    if(_isaret) esittir = (-1)*(_sayi1 + _sayi2);
                    else esittir = (_sayi1 - _sayi2);
                    _islemne = esittir;
                    _esitmi = true;
                    break;

                case V2:
                    islemekranLabel.Text = (_isareti + _sayi1 + " * " + _sayi2 + " =");
                    esittir = (_sayi1 * _sayi2);
                    _islemne = esittir;
                    _esitmi = true;
                    break;

                case V3:
                    islemekranLabel.Text = (_isareti + _sayi1 + " / " + _sayi2 + " = ");
                    esittir = ((_sayi1) / (_sayi2));
                    _islemne = esittir;
                    _esitmi = true;
                    break;

                case V4: 
                    
                    if(_esitmi)
                    {
                        ekranLabel.Text = ekranLabel.Text.Substring(0, ekranLabel.Text.Length - 3);
                        _esitesit = Convert.ToString(ekranLabel.Text); 
                        islemekranLabel.Text = (_esitesit + "! = ");
                        for (int i = 1; i <= _islemne; i++) fak = fak*i;
                        esittir = fak;
                    }
                    else
                    {
                        islemekranLabel.Text = (_sayi1 + "! = ");
                        for (int i = 1; i <= _sayi1; i++) fak = fak * i;
                        esittir = fak;
                    }
                    break;
                    
                default:
                    esittir = '0';
                    break;
            }

            _isaret = false;

            // =Ekran

            esit = esittir.ToString("0.00");
            ekranLabel.Text = esit;
 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            //1
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                if (_temizleme)
                {
                    ekranLabel.Text = "";
                    _temizleme = false;
                }
                if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
                ekranLabel.Text += "1";
            }

            //2
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                if (_temizleme)
                {
                    ekranLabel.Text = "";
                    _temizleme = false;
                }
                if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
                ekranLabel.Text += "2";
            }

            //3
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                if (_temizleme)
                {
                    ekranLabel.Text = "";
                    _temizleme = false;
                }
                if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
                ekranLabel.Text += "3";
            }

            //4
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                if (_temizleme)
                {
                    ekranLabel.Text = "";
                    _temizleme = false;
                }
                if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
                ekranLabel.Text += "4";
            }

            //5
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                if (_temizleme)
                {
                    ekranLabel.Text = "";
                    _temizleme = false;
                }
                if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
                ekranLabel.Text += "5";
            }

            //6
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                if (_temizleme)
                {
                    ekranLabel.Text = "";
                    _temizleme = false;
                }
                if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
                ekranLabel.Text += "6";
            }

            //7
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                if (_temizleme)
                {
                    ekranLabel.Text = "";
                    _temizleme = false;
                }
                if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
                ekranLabel.Text += "7";
            }

            //8
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                if (_temizleme)
                {
                    ekranLabel.Text = "";
                    _temizleme = false;
                }
                if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
                ekranLabel.Text += "8";
            }

            //9
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                if (_temizleme)
                {
                    ekranLabel.Text = "";
                    _temizleme = false;
                }
                if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
                ekranLabel.Text += "9";
            }

            //0
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                if (_temizleme)
                {
                    ekranLabel.Text = "";
                    _temizleme = false;
                }
                if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
                ekranLabel.Text += "0";
            }

            // ,
            if (e.KeyCode == Keys.Decimal)
            {
                ekranLabel.Text += ",";
            }

            //+
            if (e.KeyCode == Keys.Add)
            {
                _islem = V1;
                _islem2 = V5;
                _temizleme = true;
                islemekranLabel.Text += ekranLabel.Text;
                _sayi1 = float.Parse(ekranLabel.Text);
                if (_isaret)
                {
                    _sayi1 = (-1) * _sayi1;
                }
            }

            //-
            if (e.KeyCode == Keys.Subtract)
            {
                _islem = V;
                _islem2 = V5;
                _temizleme = true;
                islemekranLabel.Text += ekranLabel.Text;
                _sayi1 = float.Parse(ekranLabel.Text);
                if (_isaret)
                {
                    _sayi1 = (-1) * _sayi1;
                }
            }

            //*
            if (e.KeyCode == Keys.Multiply)
            {
                _islem = V2;
                _islem2 = V5;
                _temizleme = true;
                islemekranLabel.Text += ekranLabel.Text;
                _sayi1 = float.Parse(ekranLabel.Text);
                if (_isaret)
                {
                    _sayi1 = (-1) * _sayi1;
                }
            }

            // /
            if (e.KeyCode == Keys.Divide)
            {
                _islem = V3;
                _islem2 = V5;
                _temizleme = true;
                islemekranLabel.Text += ekranLabel.Text;
                _sayi1 = float.Parse(ekranLabel.Text);
                if (_isaret)
                {
                    _sayi1 = (-1) * _sayi1;
                }
            }

            //x!
            if (e.KeyCode == Keys.F)
            {
                _islem2 = V5;
                if (_isaretfakt) ekranLabel.Text = V4;
                else
                {
                    _islem = V4;
                    islemekranLabel.Text += ekranLabel.Text;
                    _sayi1 = float.Parse(ekranLabel.Text);
                    if (_isaret)
                    {
                        ekranLabel.Text = "";
                    }

                }
            }

            //+/-
            if (e.KeyCode == Keys.D)
            {
                _isaretfakt = true;
                _isaret = true;
                if (ekranLabel.Text == "0" || ekranLabel.Text == null) ekranLabel.Text = "";
                _temizleme = false;
                ekranLabel.Text += V;
            }

            //Delete
            if (e.KeyCode == Keys.Delete)
            {
                if (ekranLabel.Text.Length>=0) ekranLabel.Text = ekranLabel.Text.Substring(0, ekranLabel.Text.Length - 1);
            }

            //Yenile
            if (e.KeyCode == Keys.C)
            {
                ekranLabel.Text = "0";
                islemekranLabel.Text = "";
            }

            if (e.KeyCode == Keys.Enter)
            {

                float esittir;
                float fak = 1;
                string esit;


                islemekranLabel.Text += ekranLabel.Text;
                _sayi2 = float.Parse(ekranLabel.Text);
                if (_isaret) _isareti = "- ";
                else _isareti = null;

                if (_islem2 == V5)
                {
                    switch (_islem)
                    {
                        case V1:
                            islemekranLabel.Text = (_isareti + _sayi1 + " + " + _sayi2 + " =");
                            if (_isaret) esittir = ((-1) * _sayi1 + _sayi2);
                            else esittir = (_sayi1 + _sayi2);
                            _islemne = esittir;
                            _esitmi = true;
                            break;

                        case V:
                            islemekranLabel.Text = (_isareti + _sayi1 + " - " + _sayi2 + " =");
                            if (_isaret) esittir = (-1) * (_sayi1 + _sayi2);
                            else esittir = (_sayi1 - _sayi2);
                            _islemne = esittir;
                            _esitmi = true;
                            break;

                        case V2:
                            islemekranLabel.Text = (_isareti + _sayi1 + " * " + _sayi2 + " =");
                            esittir = (_sayi1 * _sayi2);
                            _islemne = esittir;
                            _esitmi = true;
                            break;

                        case V3:
                            islemekranLabel.Text = (_isareti + _sayi1 + " / " + _sayi2 + " = ");
                            esittir = ((_sayi1) / (_sayi2));
                            _islemne = esittir;
                            _esitmi = true;
                            break;

                        case V4:
                            islemekranLabel.Text = (_sayi1 + "! = ");
                            if (_esitmi)
                            {
                                for (int i = 1; i <= _islemne; i++) fak *= i;
                                esittir = fak;
                            }
                            else
                            {
                                for (int i = 1; i <= _sayi1; i++) fak *= i;
                                esittir = fak;
                            }
                            break;

                        default:
                            esittir = '0';
                            break;
                    }

                    _isaret = false;

                    // =Ekran
                    esit = esittir.ToString("0.00");

                    ekranLabel.Text = esit;
                }
            }

        }

    }
}
