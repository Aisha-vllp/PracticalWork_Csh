using System;  
using System.Collections.Generic;  
using System.ComponentModel;  
using System.Data;  
using System.Drawing;  
using System.Linq;  
using System.Text;  
using System.Windows.Forms;  
using System.Media; //подключили пространство имен SoundPlayer  


namespace Task56_57_winforms
{
    public partial class Form1 : Form
    {
        SoundPlayer sp;//объ€вл€ем поле типа SoundPlayer  
        public Form1()
        {
            InitializeComponent();
            //создаем экземпл€р класса SoundPlayer  
            sp = new SoundPlayer();

            //выт€гиваем из ресурсов звуковой файл  
            sp.Stream = Properties.Resources.collectathon;  //Audio file added now!
        }

        private void Start_Click(object sender, EventArgs e)
        {
            sp.Play();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            sp.Stop();
        }
    }
}
