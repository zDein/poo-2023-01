using System.Security.AccessControl;
using System;
using System.Collections.Generic;

namespace src.Entities.Aeroporto
{
    public class Operacao
    {
        private string Tipo;
        private DateTime Data;
        private string hora;

        private List<Voo> _voos;
    }
}