using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.YushkovaES.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "Текст не введен!";

            char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '\t' };
            var words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var symmetric = words.Where(w => w.Length > 1 &&
                w.ToLower() == new string(w.ToLower().Reverse().ToArray()));

            return symmetric.Any() ?
                string.Join(", ", symmetric) :
                "Симметричные слова не найдены";



        }
    }
}
