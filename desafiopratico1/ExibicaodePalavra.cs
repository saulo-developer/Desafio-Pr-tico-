namespace desafiopratico1;
using System;

class ExibicaodePalavra
    {
    internal object Contar(string palavras, bool v)
    {
        throw new NotImplementedException();
    }

    internal object Contar(string palavras)
    {
        throw new NotImplementedException();
    }

    // Classe responsável por contar os caracteres
    class ContadorDeCaracteres
    {
        // Método que conta os caracteres, opcionalmente excluindo espaços
        public int Contar(string texto, bool excluirEspacos = false)
        {
            return excluirEspacos ? texto.Replace(" ", "").Length : texto.Length;
        }
    }
}

