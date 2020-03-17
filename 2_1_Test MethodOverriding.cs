using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483
{
    class _2_1_Test_MethodOverriding
    {
        class Document { 
        //all documents have the same GetDate behaviour so this method will not be overriden
             public void GetDate()
             {
                    Console.WriteLine("Hello from GetDate in Document");
             }

            //a Document may have its own DoPrint behavior so this method is virtual so it can be overriden
            public virtual void DoPrint()
            {
                Console.WriteLine("Hello from Do Print in Document");
            }


        }


        class Invoice : Document
        {
            //Override the DoPrint metod in the base class
            //to provide custom printing behavior for an Invoice
            public override void DoPrint()
            {
                Console.WriteLine("Hello from DoPrint in Invoice");
            }


        }



        class PrePaidInvoice : Invoice
        {
            //Override the DoPrint metod in the base class
            //to provide custom printing behavior for an Invoice
            public override void DoPrint()
            {
                base.DoPrint();
                Console.WriteLine("Hello from DoPrint in Prepaid Invoice");
            }


        }


        public static void RunMethodOverriding()
        {
            //create an invoice
            Invoice receipt = new Invoice();
            PrePaidInvoice p = new PrePaidInvoice();

            receipt.GetDate(); //set date method from Document

            receipt.DoPrint(); //do print method from Invoice

          //  p.GetDate();
            p.DoPrint();

            Console.ReadLine();
        }


    }
}
