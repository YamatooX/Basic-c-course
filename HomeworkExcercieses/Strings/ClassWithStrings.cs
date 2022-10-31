using System;
using System.Collections.Generic;
using System.Text;

// Twoją pracą domową w tym module jest napisanie programu, który każe użytkownikowi wpisać kilka zdań tekstu.
// Następnie dzieli ten tekst po kropkach
// (Przykładowo „Jakieś zdanie. A to jest inne zdanie” powinno dać Ci tablicę z dwoma stringami).
// Teraz do każdego zdania na końcu dodaje „(CHYBA)” i znak nowej linii (Więc np. mając tekst
// „Jakieś zdanie” powinieneś po tej operacji mieć „Jakieś zdanie (CHYBA)\n„).
// Następnie niech program połączy wszystkie teksty z tablicy w jedną wartość typu string. A potem utworzony tekst wyświetl na ekranie.

namespace HomeworkExcercieses.Strings
{
    class ClassWithStrings
    {
        public string DealWithString(string str)
        {
            StringBuilder sb = new StringBuilder();

            string[] stringArray = str.Split('.');

            foreach(string line in stringArray)
            {
                sb.Append(line);
                sb.AppendLine("(CHYBA)");
            }

            return sb.ToString();
        }
    }
}
