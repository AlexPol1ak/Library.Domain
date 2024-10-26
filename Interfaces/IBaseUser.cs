namespace Library.Domain.Interfaces
{
    /// <summary>
    /// Интерфейс базового пользователя
    /// </summary>
    public interface IBaseUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Patronymic { get; set; }
        public string Email { get; set; }
    }
}
