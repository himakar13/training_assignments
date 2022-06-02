using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebase_Retest
{
    class BalanceException : ApplicationException



    {



        public BalanceException(string msg) : base(msg)



        {





        }



    }



    class LoanProcess



    {



        public long Loan_No;



        public string Name;



        public float LoanAmount;



        public float EMI_Amount;



        public float Account_Balance;



        public LoanProcess(long loanNo, string name)



        {



            Loan_No = loanNo;



            Name = name;



        }



        public float calculate_EMI(float r = 13, float t = 3)



        {



            Console.WriteLine("Enter Loan Amount : ");



            LoanAmount = float.Parse(Console.ReadLine());



            float p = LoanAmount;



            r = r / (12 * 100); // one month interest



            t = t * 12; // one month period



            EMI_Amount = (p * r * (float)Math.Pow(1 + r, t))



            / (float)(Math.Pow(1 + r, t) - 1);



            return (EMI_Amount);



        }



        public void CheckBalance()



        {



            Console.WriteLine("Enter Account Balance : ");



            Account_Balance = float.Parse(Console.ReadLine());



            if (Account_Balance < EMI_Amount)



            {



                throw (new BalanceException("Not Sufficient Balance to repay Loan"));



            }



            else



            {



                Console.WriteLine("EMI amount debited from your account.....");



            }





        }



    }



    class Program



    {



        static void Main(string[] args)



        {



            LoanProcess lp1 = new LoanProcess(42335222, "Subhramanyam");



            lp1.calculate_EMI();



            try



            {



                lp1.CheckBalance();



            }
            catch (BalanceException Be)



            {



                Console.WriteLine(Be.Message);



            }



            LoanProcess lp2 = new LoanProcess(23425855, "Sakunthala");



            lp2.calculate_EMI();



            try



            {



                lp2.CheckBalance();



            }



            catch (BalanceException Be)



            {



                Console.WriteLine(Be.Message);



            }



            Console.Read();



        }



    }


}
