using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;

namespace JsonTest
{
    public partial class Form1 : Form
    {
        //lokasi file json
        string path = @"json1.json";
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //membaca data json
            string data = File.ReadAllText(path);
            //parse json
            dynamic weatherdata = JObject.Parse(data);
            //memanggil data json
            txtNama.Text = weatherdata.nama.depan +' '+ weatherdata.nama.tengah + ' ' + weatherdata.nama.belakang;
            txtAlamat.Text = weatherdata.alamat;
            txtUmur.Text = weatherdata.umur.umur1;
            txthoby.Text = weatherdata.hobi;
            txtpacar.Text = weatherdata.pacar.pertama;
        }
    }
}
