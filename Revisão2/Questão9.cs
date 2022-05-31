using System;
class MainClass {
	public static void Main (string[] args) {
    
			Console.WriteLine ("Digite o horário no formato hh:mm");
			String[] horario;
			int hh, mm;
			try {
				horario = Console.ReadLine ().Split(':');
				hh = int.Parse (horario [0]) % 12;
				mm = int.Parse (horario [1]) % 60;
			} catch (Exception) {
				Console.WriteLine ("O horário informado é inválido.");
				return;
			}
			int angA = mm * 6;
			int angb = ((hh * 60) + mm) / 2;
			int dif = angA - angb;
			dif = dif < 0 ? dif * -1 : dif;
			dif = dif > 180 ? 360 - dif : dif;
			Console.WriteLine ($"Menor ângulo entre os ponteiros = {dif} graus");

		}
	}