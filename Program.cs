Console.Title = "Conversor Fahrenheit/Celsius";

double celsius, fahrenheit;

string[] frase = new string[28];
frase[0] = "C";
frase[1] = "o";
frase[2] = "n";
frase[3] = "v";
frase[4] = "e";
frase[5] = "r";
frase[6] = "s";
frase[7] = "o";
frase[8] = "r";
frase[9] = " ";
frase[10] = "F";
frase[11] = "a";
frase[12] = "h";
frase[13] = "r";
frase[14] = "e";
frase[15] = "n";
frase[16] = "h";
frase[17] = "e";
frase[18] = "i";
frase[19] = "t";
frase[20] = "/";
frase[21] = "C";
frase[22] = "e";
frase[23] = "l";
frase[24] = "s";
frase[25] = "i";
frase[26] = "u";
frase[27] = "s";

Console.ForegroundColor = ConsoleColor.Cyan;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.SetCursorPosition(5, 2);
Console.WriteLine("╔");
Console.SetCursorPosition(40, 2);
Console.WriteLine("╗");
Console.SetCursorPosition(5, 3);
Console.WriteLine("║                                  ║");
Console.SetCursorPosition(5, 4);
Console.Write("╠");
Console.SetCursorPosition(40, 4);
Console.Write("╣");
Console.SetCursorPosition(5, 12);
Console.WriteLine("╚");
Console.SetCursorPosition(40, 12);
Console.WriteLine("╝");

for(int i = 0; i <= 33; i++){
    Console.SetCursorPosition(i+7,3);
    Console.SetCursorPosition(i+6,4);
    Console.Write("═");
    Console.SetCursorPosition(i+6,2);
    Console.Write("═");        
    Console.SetCursorPosition(i+6,12);
    Console.Write("═");
    Thread.Sleep(100);
}

for(int i = 0; i <= 6; i++){
    Console.SetCursorPosition(5, i+5);
    Console.WriteLine("║                                  ║");
    Thread.Sleep(100);
}

for (int i = 0; i <= 27; i++){    
    Console.SetCursorPosition(i+9,3);
    Console.Write(frase[i]);
    Thread.Sleep(100);
}

Console.SetCursorPosition(6, 5);
Console.WriteLine("Digite temperatura em Fahrenheit:");
Console.SetCursorPosition(6, 6);
fahrenheit = Convert.ToDouble(Console.ReadLine().Replace(",","."));

celsius = (fahrenheit - 32) / 1.8;

Console.SetCursorPosition(6, 7);
Console.WriteLine("Convertida em Celsius é:");
Console.SetCursorPosition(6, 8);
Console.WriteLine($"{celsius:N2}°");
Console.SetCursorPosition(6, 9);


Console.SetCursorPosition(6, 9);
Console.WriteLine($"Obrigado!");

Console.SetCursorPosition(6, 10);
Console.WriteLine("Pressione uma tecla p/ sair...");

Console.SetCursorPosition(0, 13);
Console.ReadKey();

Console.SetCursorPosition(6, 11);
Console.WriteLine("FATEC 2022/2");
Console.ResetColor();