using System;

namespace TicTacToe
{
	public class TICTACTOE
	{
		char[] Tabella = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};

		public void Par(char[] Tabella_Par)
		{
			Tabella = Tabella_Par;
		}

		public void STAMPA()
		{
			Console.WriteLine("    |     |      ");
			Console.WriteLine("  {0}  |  {1}  |  {2}", Tabella[0],Tabella[1],Tabella[2]);
			Console.WriteLine("_____|_____|_____ ");
			Console.WriteLine("     |     |      ");
			Console.WriteLine("  {0}  |  {1}  |  {2}", Tabella[3],Tabella[4], Tabella[5]);
			Console.WriteLine("_____|_____|_____ ");
			Console.WriteLine("     |     |      ");
			Console.WriteLine("  {0}  |  {1}  |  {2}", Tabella[6], Tabella[7], Tabella[8]);
			Console.WriteLine("     |     |      ");
		}


	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Tic Tac Toe");

			TICTACTOE TabellaTICTACTOE = new TICTACTOE ();

			char[] Tabella = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};

			//int Scelta_Giocatore;

			//do {
				Console.WriteLine ("Seleziona una casella\n");
				
				ConsoleKeyInfo keyInfo = Console.ReadKey();


				
			for (int i = 0; i < 100; i++) 
			{	
				if (keyInfo.Key == ConsoleKey.UpArrow) 
				{
					TabellaTICTACTOE.Par (Tabella);
					Tabella [i] = 'X';
					TabellaTICTACTOE.STAMPA ();
					System.Threading.Thread.Sleep (500);
					Console.Clear ();
				} 
				else if (keyInfo.Key == ConsoleKey.DownArrow) {
					TabellaTICTACTOE.Par (Tabella);
					Tabella [i] = 'X';
					TabellaTICTACTOE.STAMPA ();
					System.Threading.Thread.Sleep (500);
					Console.Clear ();
				} 
				else if (keyInfo.Key == ConsoleKey.RightArrow) 
				{
					TabellaTICTACTOE.Par (Tabella);
					Tabella [i] = 'X';
					TabellaTICTACTOE.STAMPA ();
					System.Threading.Thread.Sleep (500);
					Console.Clear ();
				}
				else if (keyInfo.Key == ConsoleKey.LeftArrow) 
				{
					TabellaTICTACTOE.Par (Tabella);
					Tabella [i] = 'X';
					TabellaTICTACTOE.STAMPA ();
					System.Threading.Thread.Sleep (500);
					Console.Clear ();
				}
			}













							






			//} while(true);


			//Console.ReadKey ();

		}
	}
}
