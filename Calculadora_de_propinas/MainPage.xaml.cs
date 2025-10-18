namespace Calculadora_de_propinas
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            clear();
        }



        private void OnButtonCalcular(object sender, EventArgs e)
        {

            decimal importe = Convert.ToDecimal(ConsumoEntry.Text);
            decimal personas = Convert.ToDecimal(NumdepersonasEntry.Text);
            decimal propina = Convert.ToDecimal(PorcentajedepropinaEntry.Text);
            decimal propinatot = propinatotal(importe, propina);
            decimal propinaporper = propinapersona(propinatot,personas);
            decimal totald = total(importe,propinatot);
            decimal totalperd = totalpersona(totald,personas);

            Propinatotlabel.Text = propinatot.ToString("F2");
            PropinaEachLabel.Text = propinaporper.ToString("F2");
            TotalLbl.Text = totald.ToString("F2");
            TotaleachEntry.Text = totalperd.ToString("F2");



        }

        private void OnButtonClear(object sender, EventArgs e)
        {
            clear();
        }

        private decimal propinatotal(decimal importe, decimal propina)
        {

            return importe * propina / 100;

        }
        private decimal propinapersona(decimal propinatotal, decimal personas)
        {
            return propinatotal / personas;
        }

        private decimal total(decimal importe, decimal propinatotal)
        {
            return importe + propinatotal;
        }

        private decimal totalpersona(decimal total, decimal personas)
        {
            return total / personas;
        }

        private void clear()
        {

            ConsumoEntry.Text = "";
            NumdepersonasEntry.Text = "";
            PorcentajedepropinaEntry.Text = "";

            Propinatotlabel.Text = "";
            PropinaEachLabel.Text = "";
            TotalLbl.Text = "";
            TotaleachEntry.Text = "";
        }
    }
}
