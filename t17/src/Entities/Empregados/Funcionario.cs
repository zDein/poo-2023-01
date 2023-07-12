using System;
using System.Collections.Generic;
namespace src.Entities.Empregados
{
    public class Funcionario 
    {
        private Funcionario _gerente;
        private List<Funcionario> _gerenciados;
    }
}