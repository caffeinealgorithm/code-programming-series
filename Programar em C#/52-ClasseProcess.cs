// YouTube: https://youtu.be/yXHX-nA4Gsk
// Publicação: https://caffeinealgorithm.com/blog/classe-process-em-csharp/

using System;
using System.Diagnostics;
using System.Linq;

namespace Base {
  class ClasseProcess {
    // private Process processo;
    private Process[] processos;

    public void Run() {
      /*
        processo = Process.Start("notepad.exe");
        processo.Kill();

        Console.Write("Pesquisar por: ");
        var pesquisa = Console.ReadLine();
        PesquisarNoGoogle(pesquisa);
      */

      processos = Process.GetProcessesByName("chrome");
      Console.WriteLine($"Número de processos: {processos.Count()}");

      foreach (var processo in processos)
        Console.WriteLine($"Nome do processo: {processo.ProcessName}");
    }

    private void PesquisarNoGoogle(string pesquisa) {
      var aplicacao = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
      Process.Start(aplicacao, $"https://www.google.com/search?q={pesquisa}".Replace(' ', '+'));
    }
  }
}

/*
  Número de processos: 28
  Nome do processo: chrome
  Nome do processo: chrome
  Nome do processo: chrome
  ...
*/
