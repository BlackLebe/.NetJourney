﻿using System;
using System.Collections.Generic;

using CursoUdemyCSharp.Fundamentos;

namespace CursoUdemyCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - FUndamentos", VariaveisEConstantes.Executar},
                {"Interpoação - Fundamentos", Interpolacao.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}