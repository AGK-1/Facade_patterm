using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_pattern
{
    public class AccountService : IAccountService
    {
        public void closeaccount(string accountId)
        {
            Console.WriteLine($"{accountId} account is closed");
        }

        public void depozit(string accountId, double amount)
        {
            Console.WriteLine($"{accountId} account {amount} depoziting");
        }

        public double getbalance(string accountId)
        {
            Console.WriteLine($"{accountId} account fetching balance info");
            //service muraciet edir ve ordan pul melumatlarini alir 
            return 100;
        }

        public void withdraw(string accountId, double amount)
        {
            Console.WriteLine($"{accountId} account {amount} withdraw");
        }
    }

    public class CustomerService : ICustomerService
    {
        public void getcustomerdetails(string customerId)
        {
            Console.WriteLine($"{customerId} fetching details ");
        }

        public void updatecustomerdetails(string customerId, string newdetails)
        {
            Console.WriteLine($"{customerId} update details");
        }
    }

    public class LoanService : ILoanService
    {
        public void applyforloan(string customerId, double amount)
        {
            Console.WriteLine($"{customerId} {amount} loan applying");
        }

        public void getloandetails(string loanId)
        {
            Console.WriteLine($"{loanId} loan fetching details");
        }

        public void makerapayment(string loanId, double amount)
        {
            Console.WriteLine($"{amount} {loanId} repay");
        }
    }

    public class bankingoperationfacade : Ibankingoperationfacade
    {
        private readonly IAccountService _accountService;
        private readonly ILoanService _loanService;
        private readonly ICustomerService _customerService;

        public bankingoperationfacade(IAccountService accountService, ILoanService loanService,
            ICustomerService customerService)
        {
            _accountService = accountService;
            _loanService = loanService;
            _customerService = customerService;
        }
        public void closeaccount(string accountId)
        {
            double balance = _accountService.getbalance(accountId);
            _accountService.withdraw(accountId, balance);
            _accountService.closeaccount(accountId);
        }

        public void handleloanapplication(string customerId, double amount)
        {
            _customerService.getcustomerdetails(customerId);
            _loanService.applyforloan(customerId, amount);
            Console.WriteLine("Loan application prossesed for " + customerId);
        }

        public void opennewaccount(string customerId, string detailaccount, double initialamount)
        {
            _customerService.updatecustomerdetails(customerId, detailaccount);
            _accountService.depozit(customerId, initialamount);
            Console.WriteLine("New account opened for "+customerId);
        }
    }
}
