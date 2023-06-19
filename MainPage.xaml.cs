using Microsoft.Maui.Controls.PlatformConfiguration;

namespace DosNumeros;
///<Summary>
///<Createddate>15/06/2023</Createddate>
///<Company>INDEL</Company>
///<Lastmodificationdate>16/06/2023</Lastmodificationdate>
///<Lastmodificationdescription>
///Agrege la setencia If para evaluar los valores introducdos en los cuales
///mostrara como mensaje de error al instroducir valores nulos
///</Lastmodificationdescription>
///<Lastmodifierautor>Ingrid Gabriel</Lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
    /// <summary>
    /// constructor de la clase
    /// </summary>

    public MainPage()
	{
		InitializeComponent();
	}

    ///<summary>
    ///Evento que se ejecuta al presionar el boton para calcular numeros.
    ///se declaran variables y se asignan valores que el usuario introducirá por medio de los controles
    ///Entry y luego se hara un calculo y el resultado se almacenara en la variable result.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(datoA.Text) && !string.IsNullOrEmpty(datoB.Text))
        {
            int N1, N2, result;
            N1 = Convert.ToInt32(datoA.Text);
            N2 = Convert.ToInt32(datoB.Text);

            result = (int)(Math.Pow(N1 + N2, 2) / 2);

            resultado.Text = result.ToString("N2");
        }
        else
        {
            DisplayAlert("error", "Introduce datos numericos", "ok");
        }
    }
 
}

