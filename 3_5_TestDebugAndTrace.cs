using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace Exam70_483
{
    class _3_5_TestDebugAndTrace
    {

        public static void RunAssert()
        {
            //assert(claim) that customer name is never empty
            string customerName = "Lena";
            Debug.Assert(!string.IsNullOrWhiteSpace(customerName));

            customerName = "";
            Debug.Assert(!string.IsNullOrWhiteSpace(customerName));
        }


        public static void RunDebugAndTrace()
        {
            TraceListener consoleListener = new ConsoleTraceListener();
            Trace.Listeners.Add(consoleListener);

            Trace.TraceInformation("info message");
            Trace.Indent();
            Trace.TraceWarning("Warning message");
            Trace.Unindent();
            Trace.TraceError("error message");

            //trace source will create events that can be used to trace program execution
            TraceSource trace = new TraceSource("Tracer", SourceLevels.All);
            //500 is a value that represents certain events (used only as developer reference 500 could be UI, 600 databases and so on)
            trace.TraceEvent(TraceEventType.Start, 500);
            trace.TraceEvent(TraceEventType.Warning, 501);
            trace.TraceEvent(TraceEventType.Verbose, 502, "at the end of the program");

            //Trace data method allos information to be added to an event in the form of a collection of object references
            trace.TraceData(TraceEventType.Information, 503, new object[] { "note 1", "Message 007" });
            trace.Flush();
            trace.Close();


            Console.ReadLine();

        }


    }
}
