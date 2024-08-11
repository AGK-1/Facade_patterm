using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hesab idare etmesi AccountService
            //kredit emeliyyatlari LoanService
            //musteri melumatlarinin idare edilmesi CustomerService
            //1 hesab acilmasi 
            // 1.1 musteri m lazimdir CustomerService
            // 1.2 minimum depozit qoyulmasi AccountService
            //2 heasb baglanmasi
            // 2.1 Musterinin hesabindaki pulun qaytarilmasi AccountService
            // 2.2 hasabi baglamaq ucun AccountService
            //3 Kredit muracieti
            // 3.1 Muraciet eden musterinin melumatlarinin oxu CustomerService
            // 3.2 kredit muracietini baslat LoanService
            AccountService accountS = new AccountService();
            CustomerService customerS = new CustomerService();
            LoanService loanS = new LoanService();

            bankingoperationfacade banking = new bankingoperationfacade(accountS,loanS,customerS);
            UseCase Use = new UseCase(banking);
            Use.Run();
        }
    }
}
