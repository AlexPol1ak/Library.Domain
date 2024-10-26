using System.Security.Cryptography;
using System.Text;

namespace Library.Domain.Utils
{
    /// <summary>
    /// Класс генерации и валидации паролей.
    /// </summary>
    public static class PasswordHasher
    {
        /// <summary>
        /// Метод для создания хеша пароля
        /// </summary>
        /// <param name="password">Не зашифрованный пароль</param>
        /// <returns>Хеш пароля</returns>
        public static string HashPassword(string password)
        {
            // Генерация соли
            byte[] saltBytes = GenerateSalt();
            string salt = Convert.ToBase64String(saltBytes);

            // Хеширование пароля с солью
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(salt + password);
                byte[] hashBytes = sha256.ComputeHash(saltedPasswordBytes);

                // Возвращаем соль и хеш в одном строковом значении
                return $"{salt}:{Convert.ToBase64String(hashBytes)}";
            }
        }

        /// <summary>
        /// Метод для сравнения пароля с хешем
        /// </summary>
        /// <param name="password">Не зашифрованный пароль</param>
        /// <param name="storedHash">Хеш пароля</param>
        /// <returns>true- если пароль верный, иначе- false </returns>
        /// <exception cref="FormatException"></exception>
        public static bool VerifyPassword(string password, string storedHash)
        {
            // Извлечение соли и хеша из сохраненного значения
            string[] parts = storedHash.Split(':');
            if (parts.Length != 2)
            {
                throw new FormatException("Некорректный формат сохраненного хеша.");
            }

            string salt = parts[0];
            string hash = parts[1];

            // Хеширование вводимого пароля с той же солью
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(salt + password);
                byte[] hashBytes = sha256.ComputeHash(saltedPasswordBytes);

                // Сравнение хеша введенного пароля с сохраненным хешем
                string computedHash = Convert.ToBase64String(hashBytes);
                return hash == computedHash;
            }
        }

        /// <summary>
        /// Вспомогательный метод для генерации соли
        /// </summary>
        private static byte[] GenerateSalt(int size = 16)
        {
            byte[] saltBytes = new byte[size];
            RandomNumberGenerator.Fill(saltBytes);
            return saltBytes;
        }
    }
}
