using Newtonsoft.Json;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace IMSBackend.Common.Helpers;

public class CommonHelper
{
    private static readonly Random getrandom = new Random();

    public static string GenerateReference(string id)
    {
        return "BGW-" + id + "-" + DateTime.UtcNow.ToString("yyyyMMddhhmmss") + GetRandomNumber(6);
    }
    private static Random random = new Random();

    /// <summary>
    /// Code copied from https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
    /// </summary>
    /// <param name="length"></param>
    /// <returns></returns>
    public static string GetRandomNumber(int length)
    {
        const string chars = "0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    /// <summary>
    /// Code copied from https://stackoverflow.com/questions/12416249/hashing-a-string-with-sha256
    /// </summary>
    /// <param name="randomString">the string to convert to sha256</param>
    /// <returns>an encrypted sha256 string</returns>
    public static string Sha256(string randomString)
    {
        var crypt = SHA256.Create();
        string hash = String.Empty;
        byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(randomString));
        foreach (byte theByte in crypto)
        {
            hash += theByte.ToString("x2");
        }
        return hash;
    }
    public static List<T> GetEnumList<T>()
    {
        T[] array = (T[])Enum.GetValues(typeof(T));
        List<T> list = new List<T>(array);
        return list;
    }

    public static string MaskPan(string pan)
    {
        return pan.Substring(0, 6) + "*******" + pan.Substring(pan.Length - 4, 4);
    }

    public static int GetAge(string date)
    {
        var today = DateTime.UtcNow;
        var todaySDate = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0);
        //var dateOfBirthString = "2003-10-09";
        CultureInfo provider = CultureInfo.InvariantCulture;
        var dateOfBirth = DateTime.ParseExact(date, "yyyy-MM-dd", provider);
        var todays = DateTime.Today;
        // Calculate the age.
        var age = today.Year - dateOfBirth.Year;
        // Go back to the year in which the person was born in case of a leap year
        if (dateOfBirth.Date > today.AddYears(-age)) age--;
        return age;
    }

    public static double CheckStringSimilarity(String s1, string s2)
    {
        String longer = s1, shorter = s2;
        if (s1.Trim().Length < s2.Trim().Length)
        { // longer should always have greater length
            longer = s2; shorter = s1;
        }
        int longerLength = longer.Length;
        if (longerLength == 0) { return 1.0; }
        int editDistance = GetStringDistance(longer, shorter);
        // Console.WriteLine("editDistance: " + editDistance);
        // Console.WriteLine("longerlength: " + longerLength);
        return ((longerLength - editDistance) / (double)longerLength) * 100;
    }

    public static int GetStringDistance(String s1, String s2)
    {
        s1 = s1.ToLower();
        s2 = s2.ToLower();
        int[] costs = new int[s2.Length + 1];
        for (int i = 0; i <= s1.Length; i++)
        {
            int lastValue = i;
            for (int j = 0; j <= s2.Length; j++)
            {
                if (i == 0)
                    costs[j] = j;
                else
                {
                    if (j > 0)
                    {
                        int newValue = costs[j - 1];
                        if (s1[i - 1] != s2[j - 1])
                            newValue = Math.Min(Math.Min(newValue, lastValue),
                                    costs[j]) + 1;
                        costs[j - 1] = lastValue;
                        lastValue = newValue;
                    }
                }
            }
            if (i > 0)
                costs[s2.Length] = lastValue;
        }
        return costs[s2.Length];
    }

    public static bool ValidatePinSecurity(string pin, DateTime? dob)
    {
        try
        {
            var regex = "^\\d+$";
            var pinCheck = Regex.Match(pin, regex, RegexOptions.None);
            if (!pinCheck.Success) throw new Exception("Pin must not be only numbers");
            bool sequencePin = true;
            bool reverseSequencePin = true;
            if (dob != null)
            {
                bool yearInPin = pin == dob?.Year.ToString();
                if (yearInPin) throw new Exception("Pin must not be your year of birth");
                bool dateMonthInPin = pin == dob?.ToString("dd") + dob?.ToString("MM");
                if (dateMonthInPin) throw new Exception("Pin must not be your month and date of birth");
                bool monthDateInPin = pin == dob?.ToString("MM") + dob?.ToString("dd");
                if (monthDateInPin) throw new Exception("Pin must not be your month and date of birth");
            }
            for (int x = 1; x < pin.Length; x++)
            {
                sequencePin &= (int)pin[x] == (int)pin[x - 1] + 1;
                reverseSequencePin &= (int)pin[x] == (int)pin[x - 1] - 1;
            }
            if (sequencePin || reverseSequencePin)
            {
                throw new Exception("Please provide a stronger pin");
            }
            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public static T CopyObject<T>(object source) where T : new()
    {
        try
        {
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source));
        }
        catch (Exception)
        {
            throw;
        }
    }

    public static string Base64Decode(string base64EncodedData)
    {
        var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
        return Encoding.UTF8.GetString(base64EncodedBytes);
    }

    public static string HashData(string randomString)
    {
        // SHA512Managed crypt = new SHA512Managed();
        System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
        string hash = String.Empty;
        byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(randomString), 0, Encoding.ASCII.GetByteCount(randomString));
        foreach (byte theByte in crypto)
        {
            hash += theByte.ToString("x2");
        }
        return hash;
    }
    public static decimal CalculateDiscountPercentage(decimal costPrice, decimal discountPrice)
    {
        if (costPrice <= 0)
            throw new ArgumentException("Cost price must be greater than zero.", nameof(costPrice));

        if (discountPrice < 0)
            throw new ArgumentException("Discount price cannot be negative.", nameof(discountPrice));

        var discountAmount = costPrice - discountPrice;
        var percentageOff = (discountAmount / costPrice) * 100;

        return Math.Round(percentageOff, 2);
    }
}

