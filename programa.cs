using System;
using System.IO;
using System.Threading;
 
public class CicloFor{//clase con un método para escribir en consola
   public void run()//Metodo void no regresa ningún valor
   {
      for(int i=0; i<10; i++){//Ciclo for para imprimir en pantalla 10 veces
         Console.WriteLine("Universidad alvart \nEscrito:"+(i+1)+" veces");
         Thread.Sleep(1000);//Método sleep para dormir el hilo por 1 segundo
      }
       Console.WriteLine("Aqui acaba el hilo... ");
   }
}
 
public class Ejecucion{//Clase dónde se va a ejecutar el hilo/thread
 
   public static void Main()//Método principal
   { 
       int total=0;
       CicloFor mifor = new CicloFor();//Creación del objeto de la clase
       Thread hilo = new Thread(new ThreadStart(mifor.run));//Se crea una instancia de la clase Thread
       hilo.Start();//Aqui inicia la ejecución del hilo
      hilo.Join();//Método join espera a que finalice el hilo antes de terminar el programa
      Console.WriteLine("Aqui Ya está finalizado el hilo");
   }
 
}