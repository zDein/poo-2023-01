using System;

namespace CSharp.Entites{

    // Assim como herança, para implementarmor uma interface, usamos ':' em C#/.NET
    class Prova : Identificacao{

    }

    interface Identificacao{
        string getNome();
    }
}