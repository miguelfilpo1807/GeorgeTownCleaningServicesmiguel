using System.Configuration;
using System.Linq.Expressions;

namespace GeorgeTownCleaningServices
{
    public partial class frmPrincipal : Form
    {
        //atributos

        //constantes para los precios de los items
        const double priceOneShirt = 0.75;
        const double pricePairPants = 2.25;
        const double priceOneDress = 4.36;

        const double ITBIS = 0.18;

        //variables para almacenar las cantidades de los items
        uint ShirtsQuantity;
        uint PantsQuantity;
        uint DressesQuantity;

        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //deshabilitamos el boton de calcular hasta que se introduzcan cantidades
            //a procesar
            // btnCalculate.Enabled = false;

            //cargamos los precios unitarios de los items
            txtShirtPrice.Text = priceOneShirt.ToString("C");
            txtPantsPrice.Text = pricePairPants.ToString("C");
            txtDressPrice.Text = priceOneDress.ToString("C");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Salir de la aplicacion
            Application.Exit();
        }
        private void txtShirtsQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtShirtsQuantity.Text.Length > 0 || txtPantsQuantity.Text.Length > 0 || txtDressesQuantity.Text.Length > 0)
            {
                btnCalculate.Enabled = true; //habilita el botón porque hay algun valor
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }
        private void txtShirtsQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Constante precios
            const double precio_Camisa = 0.25;
            const double precio_Pantalones = 0.70;
            const double precio_Vestidos = 4.75;
            const double ITBIS = 0.18;

            //capturar los datos del cliente
            string customerName = "";
            string customerPhone = "";
            //DateTime orderDate = 
            DateTime fechaorden = DateTime.Now;

            //variables para las cantidades de items
            double subTotalShirts;
            double subTotalPants = 0;
            double subTotalDress = 0;

            //variables cantidad

            //uint cantidad_Camisas;
            //uint cantidad_Pantalones;
            //uint cantidad_Vestidos;
            //capturar los datos de entrada

            customerName = txtCustomerName.Text;
            customerPhone = txtCustomerPhone.Text;
            //fechaorden = Convert.ToDateTime(txtoderdate.Text);

            //capturar las cantidades items




            //vamos a calcular

            if (txtShirtsQuantity.Text == string.Empty)
            {
                txtShirtsQuantity.Text = "0";
            }
            if (txtPantsQuantity.Text == string.Empty)
            {
                txtPantsQuantity.Text = "0";
            }
            ShirtsQuantity = Convert.ToUInt32(txtShirtsQuantity.Text);
            subTotalShirts = Convert.ToUInt32(txtShirtsQuantity.Text) * priceOneShirt;

            //completar los otros calculos de los subtotales

            double totalGross = subTotalShirts + subTotalPants + subTotalDress;
            double taxes = ITBIS * totalGross;
            double totalNet = totalGross + taxes;

            //Informar al cliente del total
            MessageBox.Show($"El total de su compra es {totalNet:C}", "pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            //pedir el pago
            double payment = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Digite el Pago"));

            //calcular la devuelta
            double difference = payment - totalNet;

            //AQUI VAMOS A PEDIR EL PAGO POR EL CLIENTE :)

            double valor_pagado = 0;

            do
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Digite el valor pagado por el cliente: ");
                if (input != null && !string.IsNullOrEmpty(input) && double.TryParse(input, out valor_pagado))
                {
                    if (valor_pagado < totalGross)
                    {
                        MessageBox.Show("Digite un valor igual o mayor al neto :) ", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        valor_pagado = 0;
                    }
                }
                else if (input == "")
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Por favor, Digite Un valor Numerico:", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valor_pagado = 0;
                }
            } while (valor_pagado < totalGross);

            double cambio = valor_pagado - totalNet;




            label15.Text += customerName;
            label16.Text += customerPhone;
            label17.Text += DateTime.Now;
            label24.Text = subTotalShirts;


        }






        private void txtShirtsQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPantsQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void form1_load(object sender, EventArgs e)
        {
            btnCalculate.Enabled = false;

        }

        private void txtCustomername_textchanged(object sender, EventArgs e)
        {
        }
        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void txtSubTotalShirts_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
//subTotalShirts = Convert.ToUInt32(txtShirtsQuantity.Text) * priceOneShirt;
///completar los otros subtotales

//double totalGross = subTotalShirts + subTotalPants + subTotalDress;

////calcular el impuesto a pagar
//double taxes = ITBIS * totalGross;

////calcular el total neto
//double totalNet = totalGross + taxes;

////Informar al cliente del total
//MessageBox.Show($"El total de su compra es {totalNet:C}", "Resume",
//    MessageBoxButtons.OK, MessageBoxIcon.Information);

////pedir el pago
//double payment = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Digite el Pago"));

////calcular la devuelta
//double difference = payment - totalNet;