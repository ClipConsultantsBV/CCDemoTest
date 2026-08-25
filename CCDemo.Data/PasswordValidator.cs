namespace CCDemo.Data
{
    /// <summary>
    /// Valideert wachtwoorden op diverse regels.
    /// </summary>
    public class PasswordValidator
    {
        public bool HasMinimumLength(string password, int minLength = 8)
        {
            return password?.Length >= minLength;
        }

        public bool HasUpperCase(string password)
        {
            return password != null && password.Any(c => char.IsUpper(c));
        }

        public bool HasLowerCase(string password)
        {
            return password != null && password.Any(c => char.IsLower(c));
        }

        public bool HasDigit(string password)
        {
            return password != null && password.Any(c => char.IsDigit(c));
        }

        public bool HasSpecialCharacter(string password)
        {
            return password != null && password.Any(c => !char.IsLetterOrDigit(c));
        }

        public List<string> GetViolations(string password)
        {
            var violations = new List<string>();

            if (password == null)
                return new List<string> { "Wachtwoord mag niet null zijn" };

            if (password.Length < 8)
                violations.Add("Minimaal 8 tekens vereist");
            if (!password.Any(c => char.IsUpper(c)))
                violations.Add("Minimaal 1 hoofdletter vereist");
            if (!password.Any(c => char.IsLower(c)))
                violations.Add("Minimaal 1 kleine letter vereist");
            if (!password.Any(c => char.IsDigit(c)))
                violations.Add("Minimaal 1 cijfer vereist");
            if (!password.Any(c => !char.IsLetterOrDigit(c)))
                violations.Add("Minimaal 1 speciaal teken vereist");

            return violations;
        }
    }
}
