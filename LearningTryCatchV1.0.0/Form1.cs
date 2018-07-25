using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningTryCatchV1._0._0
{
    public partial class Form1 : Form
    {
        HoneyDeliverySystem delivery = new HoneyDeliverySystem();

        public Form1()
        {
            InitializeComponent();
            try
            {
                delivery.FeedHoneyToEggs();
            }
            catch (OutOfHoneyException ex)
            {
                MessageBox.Show(ex.Message, "Ostrzeżnie: brak miodu, uzupełniam zasoby z rezerw.");
                delivery.HoneyLevel = 0;
                MessageBox.Show("Miód uzupełniony.");

            }
            finally
            {

                MessageBox.Show("Ul aktualnie pracuje.");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                delivery.FeedHoneyToEggs();
            }
            catch (OutOfHoneyException ex)
            {

                MessageBox.Show(ex.Message, "Ostrzeżnie: brak miodu, uzupełniam zasoby z rezerw.");
                delivery.HoneyLevel = 1;
                MessageBox.Show("Miód uzupełniony.");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message,"Złapałem");
            }
            finally
            {
                MessageBox.Show("Ul aktualnie pracuje.");
                throw new Exception("Rzucanie nowego wyjątku np. Błąd nr : 404");
            }
        }
    }
}
