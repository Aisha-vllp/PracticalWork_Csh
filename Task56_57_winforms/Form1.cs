using System;  
using System.Collections.Generic;  
using System.ComponentModel;  
using System.Data;  
using System.Drawing;  
using System.Linq;  
using System.Text;  
using System.Windows.Forms;  
using System.Media;//���������� ������������ ���� SoundPlayer  


namespace Task56_57_winforms
{
    public partial class Form1 : Form
    {
        SoundPlayer sp;//��������� ���� ���� SoundPlayer  
        public Form1()
        {
            InitializeComponent();
            //������� ��������� ������ SoundPlayer  
            sp = new SoundPlayer();
        }

        private void Start_Click(object sender, EventArgs e)
        {

        }

        private void Stop_Click(object sender, EventArgs e)
        {

        }
    }
}
