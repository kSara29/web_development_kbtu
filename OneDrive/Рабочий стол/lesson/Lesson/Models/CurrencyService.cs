using Newtonsoft.Json;

namespace Lesson.Models;

public class CurrencyService
{
    public List<Currency> GetCurrencyRates(string jsonFilePath)
    {
        string jsonText = File.ReadAllText(jsonFilePath);
        List<Currency> cur = JsonConvert.DeserializeObject<List<Currency>>(jsonText);
        string a = "";
        return cur;
    }
}