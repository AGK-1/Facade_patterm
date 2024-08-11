using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_pattern
{
    public interface IAccountService // musteri hesablarinin idare edilmesi
    {
        void depozit(string accountId,double amount);

        void withdraw(string accountId,double anount);
        double getbalance(string accountId);
        void closeaccount(string accountId);
    }

    public interface ICustomerService //musteri melumatlarinin idare edilmesi
    {
        void getcustomerdetails(string customerId);
        void updatecustomerdetails(string customerId,string newdetails);
    }

    public interface ILoanService //kredit emeliyyatlari
    {
        void getloandetails(string loanId);
        void applyforloan(string customerId,double amount);

        void makerapayment(string loanId,double amount);
    }


    public interface Ibankingoperationfacade
    {
        void opennewaccount(string customerId,string detailaccount, double initialamount);
        void closeaccount(string accountId);
        void handleloanapplication(string customerId,double amount);

    }


}
