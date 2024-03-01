using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Puzzle
{
    public partial class MainPage : ContentPage
    {
        string btn;
        Button button;

        Button newButton;
        string newBtn;

        int id;
        public MainPage()
        {
            InitializeComponent();
            losujKurwe();
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            btn = ((Button)sender).AutomationId;
            button = FindByName(btn) as Button;
            if (button.Text != "")
            {
                try
                {
                    id = int.Parse(btn.Substring(3, 1)) + 3;
                    newBtn = "Btn" + id.ToString();
                    newButton = FindByName(newBtn) as Button;
                    if(newButton.Text == "")
                    {
                        newButton.Text = button.Text;
                        button.Text = "";
                    }
                }
                catch { }
                try
                {
                    id = int.Parse(btn.Substring(3, 1)) - 3;
                    newBtn = "Btn" + id.ToString();
                    newButton = FindByName(newBtn) as Button;
                    if (newButton.Text == "")
                    {
                        newButton.Text = button.Text;
                        button.Text = "";
                    }
                }
                catch { }
                try
                {
                    id = int.Parse(btn.Substring(3, 1)) + 1;
                    newBtn = "Btn" + id.ToString();
                    newButton = FindByName(newBtn) as Button;
                    if (newButton.Text == "" && (id-1)%3 != 0)
                    {
                        newButton.Text = button.Text;
                        button.Text = "";
                    }
                }
                catch { }
                try
                {
                    id = int.Parse(btn.Substring(3, 1)) - 1;
                    newBtn = "Btn" + id.ToString();
                    newButton = FindByName(newBtn) as Button;
                    if (newButton.Text == "" && id % 3 != 0)
                    {
                        newButton.Text = button.Text;
                        button.Text = "";
                    }
                }
                catch { }
            }
            Var();
        }
        void Var()
        {
        if(Btn1.Text == "1" && Btn2.Text == "2" && Btn3.Text == "3" && Btn4.Text == "4" && Btn5.Text == "5" && Btn6.Text == "6" && Btn7.Text == "7" && Btn8.Text == "8" && Btn9.Text == "")
            {
                DisplayAlert("Decyzja VARu", "Wygrałeś!", "Git");
                losujKurwe();
            }       
        }

        void losujKurwe()
        {
            Random rand = new Random();
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 1; i < 9; i++)
            {
                int ranXD = rand.Next(1, list.Count);
                string btnn = "Btn" + list[ranXD - 1].ToString();
                list.RemoveAt(ranXD - 1);
                Button buttonn = FindByName(btnn) as Button;
                buttonn.Text = i.ToString();
            }
        }
    }
}
