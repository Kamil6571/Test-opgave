using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test_opgave //DK-Definerer et navneområde med navnet "Test_opgave". Navneområder bruges til at gruppere relaterede klasser og andre typer. /(PL-Definiuje przestrzeń nazw (namespace) o nazwie "Test_opgave". Przestrzenie nazw służą do grupowania powiązanych klas i innych typów.)
{ //otwarcie klamry 
    public class Test_opgave //DK-Opretter en offentlig klasse med navnet "Test_opgave". Denne klasse er tilgængelig for andre dele af koden. /(PL-Tworzy publiczną klasę o nazwie "Test_opgave". Klasa ta jest dostępna dla innych części kodu.)
    { //otwarcie klamry
        private string _input; //DK-Erklærer et privat felt (variabel) med navnet "_input" af strengtype. Dette felt indeholder en tekstværdi. /(PL-Deklaruje prywatne pole (zmienną) o nazwie "_input" typu string. Pole to przechowuje wartość tekstową.)
        public Test_opgave (string input) //DK-Opretter en offentlig konstruktør ved navn "Test_opgave", der tager et strengargument ved navn "input". Konstruktøren bruges til at oprette nye klasseforekomster og initialisere deres tilstand. /(PL-Tworzy publiczny konstruktor o nazwie "Test_opgave", który przyjmuje argument typu string o nazwie "input". Konstruktor służy do tworzenia nowych instancji klasy i inicjalizacji ich stan.)
        { //otwarcie klamry
            _input = input; //DK-Tildeler værdien af ​​"input"-argumentet til "_input"-feltet. Denne indstilling initialiserer "_input"-feltet med den værdi, der blev angivet, da objektet blev oprettet. /(PL-Przypisuje wartość argumentu "input" do pola "_input". To ustawienie inicjalizuje pole "_input" wartością podaną przy tworzeniu obiektu.)
        } //zamkniecie klamry
        private int lcount()//DK-Erklærer en privat metode kaldet "lcount", der returnerer en heltalsværdi (int). Denne metode tager ingen argumenter. /(PL-Deklaruje prywatną metodę o nazwie "lcont" zwracającą wartość całkowitą (int). Metoda ta nie przyjmuje żadnych argumentów.)
        { //otwarcie klamry
            return _input.Length;//DK-Returnerer længden (antal tegn), der er gemt i feltet "_input". Denne metode beregner længden af ​​teksten gemt i "_input"-feltet og returnerer denne værdi. /(PL-Zwraca długość (liczbę znaków) przechowywaną w polu "_input". Metoda ta oblicza długość tekstu przechowywanego w polu "_input" i zwraca tę wartość.)
        }//zamkniecie klamry
        public static void StaticMethod()
        {
        }

    }
}
