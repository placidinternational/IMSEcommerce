using IMSBackend.Common.Models;
using System.Security.Cryptography;
using System.Text;

namespace IMSBackend.Common.Helpers;

public class PasswordHelper
{
    private const string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string LowerCase = "abcdefghijklmnopqrstuvwxyz";
    private const string Numbers = "0123456789";
    private const string Symbols = "!@#$%^&*()_+-=[]{}|;:,.<>?";
    private const string AllCharacters = UpperCase + LowerCase + Numbers + Symbols;

    public static string GeneratePassword(int length = 8)
    {
        if (length < 8)
        {
            throw new ArgumentException("Password length must be at least 8 characters.");
        }

        Random random = new Random();
        StringBuilder password = new StringBuilder();

        // Ensure at least 1 uppercase, 1 lowercase, 1 number, and 1 symbol
        password.Append(UpperCase[random.Next(UpperCase.Length)]);
        password.Append(LowerCase[random.Next(LowerCase.Length)]);
        password.Append(Numbers[random.Next(Numbers.Length)]);
        password.Append(Symbols[random.Next(Symbols.Length)]);

        // Fill the remaining characters
        for (int i = 4; i < length; i++)
        {
            password.Append(AllCharacters[random.Next(AllCharacters.Length)]);
        }

        // Shuffle the password to randomize the character order
        return ShufflePassword(password.ToString(), random);
    }
    // Function to shuffle the generated password
    private static string ShufflePassword(string password, Random random)
    {
        char[] array = password.ToCharArray();
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            // Swap characters
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        return new string(array);
    }

    public static PasswordResult CreateNewPasswordHash(string password)
    {
        PasswordResult result = new PasswordResult();
        using (var hmac = new System.Security.Cryptography.HMACSHA512())
        {
            result.PasswordSalt = hmac.Key;
            result.PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
        return result;
    }
    public static string GenerateNewRandomOTP(int iOTPLength, string[] saAllowedCharacters)
    {
        string sOTP = String.Empty;
        string sTempChars = String.Empty;
        Random rand = new Random();

        for (int i = 0; i < iOTPLength; i++)
        {
            int p = rand.Next(0, saAllowedCharacters.Length);

            sTempChars = saAllowedCharacters[rand.Next(0, saAllowedCharacters.Length)];

            sOTP += sTempChars;
        }

        return sOTP;
    }
    public static (byte[] passwordSalt, byte[] passwordHash) CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using (var hmac = new System.Security.Cryptography.HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }

        return (passwordSalt, passwordHash);
    }

    public static PasswordResult CreatePasswordHash(string password)
    {
        PasswordResult result = new PasswordResult();
        using (var hmac = new System.Security.Cryptography.HMACSHA512())
        {
            result.PasswordSalt = hmac.Key;
            result.PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
        return result;
    }
    public static string GenerateRandomOTP(int iOTPLength, string[] saAllowedCharacters)
    {
        string sOTP = String.Empty;
        string sTempChars = String.Empty;
        Random rand = new Random();

        for (int i = 0; i < iOTPLength; i++)
        {
            int p = rand.Next(0, saAllowedCharacters.Length);

            sTempChars = saAllowedCharacters[rand.Next(0, saAllowedCharacters.Length)];

            sOTP += sTempChars;
        }

        return sOTP;
    }
    private bool VerifyPassword(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
        {
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != passwordHash[i]) return false;
            }
            return true;
        }
    }
    public static string GenerateMD5(string input)
    {
        // Create a new instance of the MD5CryptoServiceProvider object.
        MD5 md5Hasher = MD5.Create();
        // Convert the input string to a byte array and compute the hash.
        byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
        // Create a new Stringbuilder to collect the bytes and create a string.
        StringBuilder sBuilder = new StringBuilder();
        // Loop through each byte of the hashed data and format each one as a hexadecimal string.
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        // Return the hexadecimal string.
        return sBuilder.ToString();
    }
}
