﻿
public class Loby{

    public static void LOBY(){

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("//////////////////////");
        Console.WriteLine("Jugar: 1");
        Console.WriteLine("Guia:  2");
        Console.WriteLine("Salir: 3");
        Console.WriteLine("//////////////////////");    

        var keyInfo = Console.ReadKey();

        if(keyInfo.KeyChar == '1'){
            
            Modo.Select();
            Picks.SelectEquipo();
        }
        //if(keyInfo.KeyChar == 2)

        if(keyInfo.KeyChar == 3)
            Environment.Exit(-1);    
    }
    
}
