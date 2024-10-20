using System;
using System.Text.RegularExpressions;


namespace desafiopratico1;




internal class DigitarPlaca
{

    static bool VerificarPlaca(string placa)
    {
        // Define a expressão regular para o formato da placa brasileira válida até 2018
        string padraoPlaca = @"^[a-zA-Z]{3}[0-9]{4}$";

        // Verifica se a placa corresponde ao padrão
        return Regex.IsMatch(placa, padraoPlaca);
    }

}