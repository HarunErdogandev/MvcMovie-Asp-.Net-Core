using NPOI.SS.Formula.Functions;

namespace MovieWebUI.Models.Logger
{
    public class Logger
    {
       

        public void LogAdd(string Name)
        {
            string yol = "C:\\Users\\harun\\source\\repos\\FilmProje\\MovieWebUI\\Models\\Logger\\logFile\\log.txt";
            using (StreamWriter sw = new StreamWriter(yol, true))
            {
                // "Merhaba Dünya!" yazısını dosyaya yaz
                sw.WriteLine($"{Name} isimli nesne  Veritabanına eklendi{DateTime.Now} ");
            }
            
        }

    }
}
