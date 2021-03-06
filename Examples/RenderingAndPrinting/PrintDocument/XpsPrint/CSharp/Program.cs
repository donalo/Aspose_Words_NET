//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Reflection;

using Aspose.Words;

namespace XpsPrintExample
{
    /// <summary>
    /// This sample shows how to convert a document to XPS by means of Aspose.Words and then print with the XpsPrint API.
    /// This sample supports both x86 and x64 platforms.
    /// 
    /// The Aspose.Words.Document object provides a family of the Print methods to print documents and
    /// these methods print via the .NET printing classes defined in the System.Drawing.Printing namespace. 
    /// There are many customers of Aspose.Words who use these printing methods in their applications 
    /// (including server side) without any problems. But it came to our attention that Microsoft recommends 
    /// against using the System.Drawing.Printing classes within a Windows service or ASP.NET application or service.
    /// See http://msdn.microsoft.com/en-us/library/system.drawing.printing.aspx for more info.
    /// 
    /// The way to print documents suggested by Microsoft is to use the XpsPrint API 
    /// http://msdn.microsoft.com/en-us/library/dd374565(VS.85).aspx. This API is available on Windows 7, 
    /// Windows Server 2008 R2 and also Windows Vista, provided the Platform Update for Windows Vista is installed.
    /// Since Aspose.Words can easily convert any document into XPS, you can use the following code to print
    /// that document via the XpsPrint API.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main entry point of the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            try
            {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
//ExStart
//ExId:XpsPrint_Main
//ExSummary:Invoke the utility class to print via XPS.
                // Open a sample document in Aspose.Words.
                Aspose.Words.Document document = new Document(dataDir + "SampleDocument.doc");

                // Specify the name of the printer you want to print to.
                const string printerName = @"\\COMPANY\Brother MFC-885CW Printer";

                // Print the document.
                XpsPrintHelper.Print(document, printerName, "My Test Job", true);
//ExEnd
                Console.WriteLine("Printed successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("Press Enter.");
            Console.ReadLine();
        }
    }
}