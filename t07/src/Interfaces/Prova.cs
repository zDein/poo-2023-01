using System;

namespace CSharp.Entites{

    // Assim como herança, para implementarmor uma interface, usamos ':' em C#/.NET
    public class Prova : Identificacao
    {
        public string getNome()
        {
            throw new NotImplementedException();
        }
    }

    public interface Identificacao{
        string getNome();
    }
}