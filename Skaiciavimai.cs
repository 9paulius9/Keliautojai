using System;
using System.Collections.Generic;

namespace Keliautojai
{
    public class Skaiciavimai
    {
        public double laikas;
        public double kelionesDienos;
        public int dienos;
        public List<string> sarasas = new List<string>();

        public void KelionesTrukme(double atstumas, double greitis, double hPerDiena, int metuLaikas)
        {
            laikas = atstumas / greitis;
            laikas = Math.Round(laikas,2);
            dienos = (int)Math.Ceiling(laikas / hPerDiena);
            kelionesDienos = laikas - hPerDiena;

            Console.WriteLine($"Jūsų kelionės laikas(Atstumas pėsčiomis) truks apie: {laikas}h.");
            Console.WriteLine($"Jūsų kelionė užtruks apie: {dienos} dienas.");

            if (kelionesDienos > 0)
            {
                Console.Clear();
                kelionesKrepsis(dienos, metuLaikas);
            }
            else
            {
                Console.Clear();
                kelionesKrepsis(dienos, 0);
            }
        }

        public void kelionesKrepsis(int dienos, int metuLaikasInt)
        {
            int x = 0;
            if (metuLaikasInt==3)
            {
                //Žiema
                Console.WriteLine("____________________________________________________");
                Console.WriteLine("Siūloma, jog jūsų kelionės krepšį sudarytų:");
                sarasas.Add($"{++x}: Vanduo (+- 2L)");
                sarasas.Add($"{++x}: Maistas (Proteinas, baltymai, angliavandeniai..)");
                sarasas.Add($"{++x}: Žibintuvėlis");
                sarasas.Add($"{++x}: Miegmaišis");
                sarasas.Add($"{++x}: Palapynė");
                sarasas.Add($"{++x}: Uždegiklis");
                sarasas.Add($"{++x}: Kepure");
                sarasas.Add($"{++x}: Šiltesnė apranga");
                sarasas.ForEach(Console.WriteLine);
            }
            else if((metuLaikasInt==1) || (metuLaikasInt==2) || (metuLaikasInt==4))
        {
                //Vasara, Ruduo, Pavasaris
                Console.Clear();
                Console.WriteLine("____________________________________________________");
                Console.WriteLine("Siūloma, jog jūsų kelionės krepšį sudarytų:");
                sarasas.Add($"{++x}: Vanduo (+- 2L)");
                sarasas.Add($"{++x}: Maistas (Proteinas, baltymai, angliavandeniai..)");
                sarasas.Add($"{++x}: Lėtsargis");
                sarasas.Add($"{++x}: Žibintuvėlis");
                sarasas.Add($"{++x}: Lietpaltis");
                sarasas.Add($"{++x}: Miegmaišis");
                sarasas.Add($"{++x}: Palapynė");
                sarasas.Add($"{++x}: Uždegiklis");
                sarasas.Add($"{++x}: Kepure");
                sarasas.ForEach(Console.WriteLine);
            }
            else if(metuLaikasInt==0)
            {
                //Viena diena
                Console.WriteLine("____________________________________________________");
                Console.WriteLine("Siūloma, jog jūsų kelionės krepšį sudarytų:");
                sarasas.Add($"{++x}: Vanduo (+- 2L)");
                sarasas.Add($"{++x}: Maistas (Proteinas, baltymai, angliavandeniai..)");
                sarasas.Add($"{++x}: Lėtsargis");
                sarasas.Add($"{++x}: Žibintuvėlis");
                sarasas.Add($"{++x}: Lietpaltis");
                sarasas.Add($"{++x}: Uždegiklis");
                sarasas.Add($"{++x}: Kepure");
                sarasas.ForEach(Console.WriteLine);
            }
        } 
    }
}
