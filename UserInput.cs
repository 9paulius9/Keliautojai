using System;

namespace Keliautojai
{
    public class UserInput
    {
        Skaiciavimai skaiciavimai = new Skaiciavimai();

        public void UserInputs()
        {
            InputVar inputs = new InputVar();
            
            Console.WriteLine("Įveskite kelionės atstumą kilometrais:");
            inputs.atstumas = Convert.ToDouble(Console.ReadLine().Replace(",", "."));

            Console.WriteLine("Įveskite aptytikslu Jūsų ėjimo greitį (km/h):");
            inputs.greitis = Convert.ToDouble(Console.ReadLine().Replace(",", "."));

            Console.WriteLine("Kiek planuojate h eiti per dieną:");
            inputs.hPerDay = Convert.ToDouble(Console.ReadLine().Replace(",", "."));

            Console.WriteLine("Pasirinkite skaicių kuriuo metu laikuotarpiu planuojate kelionę:\n1:Vasara;\n2:Rudeni;\n3:Žiema;\n4:Pavasari;");
            inputs.metuLaikas = Convert.ToInt32(Console.ReadLine());

            skaiciavimai.KelionesTrukme(inputs.atstumas, inputs.greitis, inputs.hPerDay, inputs.metuLaikas);
        }
    }
}
