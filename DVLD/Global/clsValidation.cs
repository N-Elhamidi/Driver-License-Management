using System.Net.Mail;

namespace DVLD.Global
{
    public class clsValidation
    {
        public static bool ValidateInteger(string number)
        {
            return int.TryParse(number, out _);
        }

        public static bool ValidateFloat(string number)
        {
            return float.TryParse(number, out _);
        }

        public static bool IsNumber(string number)
        {
            return (ValidateFloat(number)||ValidateInteger(number));
        }

        public static bool ValidateEmail(string EmailString)
        {
            try
            {
                var email = new MailAddress(EmailString);
                return (email.Address == EmailString);
            }
            catch
            {
                return false;
            }
        }
    }
}
