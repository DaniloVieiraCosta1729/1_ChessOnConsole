using _1_ChessOnConsole;

ChessEntities xadrez = new ChessEntities();

string estado = xadrez.tabuleiroFEN;

Console.WriteLine(estado);

string[] vetor = xadrez.geradorVetorFEN(estado);

Console.WriteLine(vetor.Length);
Console.WriteLine(vetor[0]);
Console.WriteLine(vetor[1]);
Console.WriteLine(vetor[2]);
Console.WriteLine(vetor[3]);
Console.WriteLine(vetor[4]);
Console.WriteLine(vetor[5]);
Console.WriteLine(vetor[6]);
Console.WriteLine(vetor[7]);
Console.WriteLine(vetor[8]);
Console.WriteLine(vetor[9]);
Console.WriteLine(vetor[10]);
Console.WriteLine(vetor[11]);
Console.WriteLine(vetor[12]);

