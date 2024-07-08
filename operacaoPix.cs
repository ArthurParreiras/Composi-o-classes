using System;

public class OperacaoPIX {
    public decimal Valor { get; private set; }
    public string ChavePIXDestinatario { get; private set; }
    public DateTime DataHora { get; private set; }
    public string Status { get; private set; }

    public OperacaoPIX(decimal valor, string chavePIXDestinatario) {
        Valor = valor;
        ChavePIXDestinatario = chavePIXDestinatario;
        DataHora = DateTime.Now; 
        Status = "Pendente"; 
    }

    public Comprovante RealizarOperacao() {
        // Validaçao (exemplo)
        Status = "Sucesso";

        
        return new Comprovante(DataHora, Valor, ChavePIXDestinatario, Status);
    }
}

public class Comprovante {
    public DateTime DataHora { get; private set; }
    public decimal Valor { get; private set; }
    public string ChavePIXDestinatario { get; private set; }
    public string Status { get; private set; }

    public Comprovante(DateTime dataHora, decimal valor, string chavePIXDestinatario, string status) {
        DataHora = dataHora;
        Valor = valor;
        ChavePIXDestinatario = chavePIXDestinatario;
        Status = status;
    }

    public void ImprimirComprovante() {
        Console.WriteLine("Comprovante de Operação PIX");
        Console.WriteLine($"Data/Hora: {DataHora}");
        Console.WriteLine($"Valor: {Valor}");
        Console.WriteLine($"Chave PIX Destinatário: {ChavePIXDestinatario}");
        Console.WriteLine($"Status: {Status}");
    }
}

class Program {
    static void Main() {
        // Dados inventados
        var operacaoPIX = new OperacaoPIX(100.00m, "12345678909");
        var comprovante = operacaoPIX.RealizarOperacao();

        // Impressao
        comprovante.ImprimirComprovante();
    }
}