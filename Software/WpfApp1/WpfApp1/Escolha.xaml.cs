using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lógica interna para Escolha.xaml
    /// </summary>
    public partial class Escolha : Window
    {
        public Escolha()
        {
            InitializeComponent();
        }

        private void ___Sem_Nome__Click(object sender, RoutedEventArgs e)
        {
            Cadastrar frm = new Cadastrar();
            this.Hide();
            frm.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Atendimento frm = new Atendimento();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
