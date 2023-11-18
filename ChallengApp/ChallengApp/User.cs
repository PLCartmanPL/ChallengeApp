namespace ChallengApp
{
    public class User
    {
        public static string GameName = "Diablo"; // wartość statyczna nieprzypisana do urzytkownika jest typem

        private List<int> score = new List<int>(); // prywatna lista
        public string Login { get; private set; } // POLA propercja z modyfikatorem dostępu set - ustawianie, get oczytywanie
        public string Password { get; private set; } //POLA propercja z modyfikatorem dostępu set - ustawianie, get oczytywanie
        public int Result
        {
            get
            {
                return this.score.Sum(); //wewnętrzna logika
            }
        }
        public User(string login, string password) //Tworzenie nowego obiektu uruchamia ten kod
        {
            this.Login = login; // konstruktor THIS odwołuje sie do prywanej zmiennej
            this.Password = password;
        }

        public void AddScore(int number)//metoda (funkcja)
        {
            this.score.Add(number); //dodawanie wartości do listy
        }
    }
}
