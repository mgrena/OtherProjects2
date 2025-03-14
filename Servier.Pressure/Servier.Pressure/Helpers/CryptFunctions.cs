using System.Security.Cryptography;
using System.Text;

namespace Servier.Pressure.Helpers;

public class CryptFunctions
{
    /// <summary>
    /// Salt value used along with passphrase to generate password. Salt can
    /// be any string. In this example we assume that salt is an ASCII string.
    /// </summary>
    private static readonly string saltValue = "nj_hg@12";            // can be any string
    private static readonly string keyValue = "u@81_DI8";
    /// <summary name="initVector">
    /// Initialization vector (or IV). This value is required to encrypt the
    /// first block of plaintext data. For RijndaelManaged class IV must be 
    /// exactly 16 ASCII characters long.
    /// </summary>
    private static readonly string initVector = "j3PlgR_9";

    public static string CryptPwd(string origPwd)
    {
        string result = AESEncryptString(origPwd);
        return result;
    }

    /// <summary>
    /// Method that converts a string to an MD5 hash
    /// </summary>
    /// <param name="input">input string to convert to hash</param>
    public static string CalculateMD5Hash(string input)
    {
        // step 1, calculate MD5 hash from input
        byte[] inputBytes = Encoding.ASCII.GetBytes(input);
        byte[] hash = MD5.HashData(inputBytes);

        // step 2, convert byte array to hex string
        StringBuilder sb = new();
        for (int i = 0; i < hash.Length; i++)
        {
            sb.Append(hash[i].ToString("X2"));
        }
        return sb.ToString();
    }
    /// <summary>
    /// Method that converts a string to a BCrypt hash
    /// </summary>
    /// <param name="input">input string to convert to hash</param>
    public static string CalculateBCryptHash(string input)
    {
        input += saltValue;
        return BCrypt.Net.BCrypt.HashPassword(input, BCrypt.Net.BCrypt.GenerateSalt());
    }
    /// <summary>
    /// Method that compares a plain string to a BCrypt hash
    /// </summary>
    /// <param name="input">plain input string</param>
    /// <param name="hash">hash string hashed by local algotitm</param>
    public static bool DoesBCryptPasswordMatch(string input, string hash)
    {
        input += saltValue;
        return BCrypt.Net.BCrypt.Verify(input, hash);
    }
    /// <summary>
    /// Encrypts a string according to the AES algorithm with the CreateEncryptor() function 
    /// </summary>
    public static string AESEncryptString(string inputString)
    {
        if (String.IsNullOrEmpty(inputString))
            return String.Empty;

        byte[] iv = Encoding.UTF8.GetBytes(initVector);
        byte[] key = Encoding.UTF8.GetBytes(keyValue);

        string aResult = string.Empty;
        // Create a MemoryStream.
        using (MemoryStream mStream = new())
        {
            // Create a new DES object.
            using (DES des = DES.Create())
            // Create a DES encryptor from the key and IV
            using (ICryptoTransform encryptor = des.CreateEncryptor(key, iv))
            // Create a CryptoStream using the FileStream and encryptor
            using (CryptoStream cStream = new(mStream, encryptor, CryptoStreamMode.Write))
            {
                // Convert the provided string to a byte array.
                byte[] toEncrypt = Encoding.UTF8.GetBytes(inputString);
                // Write the byte array to the crypto stream and flush it.
                cStream.Write(toEncrypt, 0, toEncrypt.Length);
            }
            // Get an array of bytes from the MemoryStream that holds the encrypted data.
            aResult = Convert.ToBase64String(mStream.ToArray());
        }

        return aResult;
    }
    /// <summary>
    /// Encrypts a string according to the AES algorithm with the CreateDecryptor() function 
    /// </summary>
    public static string AESDecryptString(string inputString)
    {
        if (String.IsNullOrEmpty(inputString))
            return String.Empty;

        byte[] inputStringBytes = Convert.FromBase64String(inputString.Replace(" ", "+"));
        byte[] decrypted = new byte[inputStringBytes.Length];
        byte[] iv = Encoding.UTF8.GetBytes(initVector);
        byte[] key = Encoding.UTF8.GetBytes(keyValue);
        int offset = 0;

        // Create a new MemoryStream using the provided array of encrypted data.
        using (MemoryStream mStream = new(inputStringBytes))
        {
            // Create a new DES object.
            using DES des = DES.Create();
            // Create a DES decryptor from the key and IV
            using ICryptoTransform decryptor = des.CreateDecryptor(key, iv);
            // Create a CryptoStream using the MemoryStream and decryptor
            using var cStream = new CryptoStream(mStream, decryptor, CryptoStreamMode.Read);
            // Keep reading from the CryptoStream until it finishes (returns 0).
            int read = 1;

            while (read > 0)
            {
                read = cStream.Read(decrypted, offset, decrypted.Length - offset);
                offset += read;
            }
        }

        // Convert the buffer into a string and return it.
        return Encoding.UTF8.GetString(decrypted, 0, offset);
    }
}
