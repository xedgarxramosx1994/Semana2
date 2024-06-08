namespace eramos_TallerS2.Views;

public partial class vHome : ContentPage
{
	public vHome()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
		if (pkEstudiantes.SelectedIndex == -1)
			DisplayAlert("Error", "No se ha elegido el estudiante", "ok");
		else
		{
			double seguimiento1 = 0, seguimiento2 = 0, examen1 = 0, examen2 = 0;
			string estudiante = pkEstudiantes.SelectedItem.ToString();
            if (txtSeguimiento.Text != string.Empty && txtSeguimiento.Text != "0")
				seguimiento1 = Convert.ToInt32(txtSeguimiento.Text) *0.3;
			if(txtExamen.Text != string.Empty && txtExamen.Text != "0")
				examen1 = Convert.ToInt32(txtExamen.Text)*0.2;
            if (txtSeguimiento2.Text != string.Empty && txtSeguimiento2.Text != "0")
                seguimiento2 = Convert.ToInt32(txtSeguimiento2.Text)*0.3;
            if (txtExamen2.Text != string.Empty && txtExamen2.Text != "0" )
                examen2 = Convert.ToInt32(txtExamen2.Text) *0.2;

			txtParcial1.Text = "Nota parcial 1: " + (seguimiento1 + examen1).ToString();
			txtParcial2.Text = "Nota parcial 2: " + (seguimiento2 + examen2).ToString();

			txtFinal.Text = "Nota Final: " + (seguimiento1 + seguimiento2 + examen1 + examen2).ToString();

			string estado = "";
			if ((seguimiento1 + seguimiento2 + examen1 + examen2) >= 7)
				estado = "Aprobado.";
			else if((seguimiento1 + seguimiento2 + examen1 + examen2) >= 5 && (seguimiento1 + seguimiento2 + examen1 + examen2) <= 6.99)
				estado = "Complementario.";
			else
				estado = "Reprobado.";

			DisplayAlert("Alerta", $"Estudiante : {estudiante} \nFecha: {(dpFecha.Date).ToShortDateString()} \n{txtParcial1.Text}\n{txtParcial2.Text}\n{txtFinal.Text}\nEstado: {estado}"
				,"ok");
        }
    }
}