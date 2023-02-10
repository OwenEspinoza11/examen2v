namespace examen2V
{
    public partial class Form1 : Form
    {
        private int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //double ingreso, egreso, inversion, impuesto, utilidad, udIm;
            //string word = cboTipoProy.Text;

            //if (mtxtInversion.Text == "")
            //{
            //    MessageBox.Show("No puede estar en blanco", "Warning");
            //}
            //else if (mtxtIngreso.Text == "")
            //{
            //    MessageBox.Show("No puede estar en blanco", "Warning");
            //}
            //else if (mtxtEgreso.Text == "")
            //{
            //    MessageBox.Show("No puede estar en blanco", "Warning");
            //}
            //else
            //{
            //    inversion = double.Parse(mtxtInversion.Text);
            //    ingreso = double.Parse(mtxtIngreso.Text);
            //    egreso = double.Parse(mtxtEgreso.Text);

            //    if (inversion >= 100 || inversion <= 200000)
            //    {
            //        if (ingreso > egreso)
            //        {
            //            switch (word)
            //            {
            //                case "3":
            //                    utilidad = ingreso - egreso;
            //                    impuesto = utilidad * 0.30;
            //                    udIm = utilidad + utilidad;

            //                    txtUtilidad.Text = utilidad.ToString();
            //                    txtImpuesto.Text = impuesto.ToString();
            //                    txtUdIm.Text = udIm.ToString();
            //                    break;

            //                case "4":
            //                    utilidad = ingreso - egreso;
            //                    impuesto = utilidad * 0.30;
            //                    udIm = utilidad + utilidad;

            //                    txtUtilidad.Text = utilidad.ToString();
            //                    txtImpuesto.Text = impuesto.ToString();
            //                    txtUdIm.Text = udIm.ToString();
            //                    break;

            //                case "6":
            //                    utilidad = ingreso - egreso;
            //                    impuesto = utilidad * 0.30;
            //                    udIm = utilidad + utilidad;

            //                    txtUtilidad.Text = utilidad.ToString();
            //                    txtImpuesto.Text = impuesto.ToString();
            //                    txtUdIm.Text = udIm.ToString();
            //                    break;

            //                case "8":
            //                    utilidad = ingreso - egreso;
            //                    impuesto = utilidad * 0.30;
            //                    udIm = utilidad + utilidad;

            //                    txtUtilidad.Text = utilidad.ToString();
            //                    txtImpuesto.Text = impuesto.ToString();
            //                    txtUdIm.Text = udIm.ToString();
            //                    break;

            //                case "10":
            //                    utilidad = ingreso - egreso;
            //                    impuesto = utilidad * 0.30;
            //                    udIm = utilidad + utilidad;

            //                    txtUtilidad.Text = utilidad.ToString();
            //                    txtImpuesto.Text = impuesto.ToString();
            //                    txtUdIm.Text = udIm.ToString();
            //                    break;

            //                case "12":
            //                    utilidad = ingreso - egreso;
            //                    impuesto = utilidad * 0.30;
            //                    udIm = utilidad + utilidad;

            //                    txtUtilidad.Text = utilidad.ToString();
            //                    txtImpuesto.Text = impuesto.ToString();
            //                    txtUdIm.Text = udIm.ToString();
            //                    break;

            //                case "18":
            //                    utilidad = ingreso - egreso;
            //                    impuesto = utilidad * 0.30;
            //                    udIm = utilidad + utilidad;

            //                    txtUtilidad.Text = utilidad.ToString();
            //                    txtImpuesto.Text = impuesto.ToString();
            //                    txtUdIm.Text = udIm.ToString();
            //                    break;

            //                case "24":
            //                    utilidad = ingreso - egreso;
            //                    impuesto = utilidad * 0.30;
            //                    udIm = utilidad + utilidad;

            //                    txtUtilidad.Text = utilidad.ToString();
            //                    txtImpuesto.Text = impuesto.ToString();
            //                    txtUdIm.Text = udIm.ToString();
            //                    break;


            //            }



            //        }







            //    }


            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUtilidad.Enabled = false;
            txtUdIm.Enabled = false;
            txtImpuesto.Enabled = false;

        }

        private void dtgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            //con esto podemos leer el contenido 
            if (n != -1)
            {
                lblInformacion.Text = (string)dtgvDatos.Rows[n].Cells[1].Value;
            }
        }

        //para organizar mejor el codigo
        #region METODOS PRIVADOS
        //codigo para eliminar 
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgvDatos.Rows.RemoveAt(n);
            }
        }
        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Adicionamos nuevo renglon 
            int n = dtgvDatos.Rows.Add();

            //Colocamos la informacion 
            dtgvDatos.Rows[n].Cells[0].Value = mtxtInversion.Text;
            dtgvDatos.Rows[n].Cells[1].Value = mtxtIngreso.Text;
            dtgvDatos.Rows[n].Cells[2].Value = mtxtEgreso.Text;
            dtgvDatos.Rows[n].Cells[3].Value = txtUtilidad.Text;
            dtgvDatos.Rows[n].Cells[4].Value = txtImpuesto.Text;

            //Limpiamos los campos
            txtUtilidad.Text = "";
            txtImpuesto.Text = "";
            txtUdIm.Text = "";
            mtxtEgreso.Text = "";
            mtxtIngreso.Text = "";
            mtxtInversion.Text = "";
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double ingreso, egreso, inversion, impuesto, utilidad, udIm;
            string word = cboTipoProy.Text;

            if (mtxtInversion.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else if (mtxtIngreso.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else if (mtxtEgreso.Text == "")
            {
                MessageBox.Show("No puede estar en blanco", "Warning");
            }
            else
            {
                inversion = double.Parse(mtxtInversion.Text);
                ingreso = double.Parse(mtxtIngreso.Text);
                egreso = double.Parse(mtxtEgreso.Text);

                if (inversion >= 100 || inversion <= 200000)
                {
                    if (ingreso > egreso)
                    {
                        switch (word)
                        {
                            case "3":
                                utilidad = ingreso - egreso;
                                impuesto = utilidad * 0.30;
                                udIm = utilidad - impuesto;

                                txtUtilidad.Text = utilidad.ToString();
                                txtImpuesto.Text = impuesto.ToString();
                                txtUdIm.Text = udIm.ToString();
                                break;

                            case "4":
                                utilidad = ingreso - egreso;
                                impuesto = utilidad * 0.30;
                                udIm = utilidad - impuesto;

                                txtUtilidad.Text = utilidad.ToString();
                                txtImpuesto.Text = impuesto.ToString();
                                txtUdIm.Text = udIm.ToString();
                                break;

                            case "6":
                                utilidad = ingreso - egreso;
                                impuesto = utilidad * 0.30;
                                udIm = utilidad - impuesto;

                                txtUtilidad.Text = utilidad.ToString();
                                txtImpuesto.Text = impuesto.ToString();
                                txtUdIm.Text = udIm.ToString();
                                break;

                            case "8":
                                utilidad = ingreso - egreso;
                                impuesto = utilidad * 0.30;
                                udIm = utilidad - impuesto;

                                txtUtilidad.Text = utilidad.ToString();
                                txtImpuesto.Text = impuesto.ToString();
                                txtUdIm.Text = udIm.ToString();
                                break;

                            case "10":
                                utilidad = ingreso - egreso;
                                impuesto = utilidad * 0.30;
                                udIm = utilidad - impuesto;

                                txtUtilidad.Text = utilidad.ToString();
                                txtImpuesto.Text = impuesto.ToString();
                                txtUdIm.Text = udIm.ToString();
                                break;

                            case "12":
                                utilidad = ingreso - egreso;
                                impuesto = utilidad * 0.30;
                                udIm = utilidad - impuesto;

                                txtUtilidad.Text = utilidad.ToString();
                                txtImpuesto.Text = impuesto.ToString();
                                txtUdIm.Text = udIm.ToString();
                                break;

                            case "18":
                                utilidad = ingreso - egreso;
                                impuesto = utilidad * 0.30;
                                udIm = utilidad - impuesto;

                                txtUtilidad.Text = utilidad.ToString();
                                txtImpuesto.Text = impuesto.ToString();
                                txtUdIm.Text = udIm.ToString();
                                break;

                            case "24":
                                utilidad = ingreso - egreso;
                                impuesto = utilidad * 0.30;
                                udIm = utilidad - impuesto;

                                txtUtilidad.Text = utilidad.ToString();
                                txtImpuesto.Text = impuesto.ToString();
                                txtUdIm.Text = udIm.ToString();
                                break;
                        }
                    }
                }
            }
        }
    }
}