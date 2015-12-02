using FestivalOfTrees.Model;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    class BidSheetPrinter
    {
        private string doubleTemplatePath;
        private string singleTemplatePath;
        public string savePath;
        public PdfConcatenate pdfConcat;
        FileStream outFile;
        public string tempFilePath;
        public string formPath;

        public void openPDF()
        {
            outFile = new FileStream(savePath, FileMode.Create);
            pdfConcat = new PdfConcatenate(outFile);
        }

        public void closePDF()
        {
            pdfConcat.Close();
            outFile.Close();
        }

        public bool addToPDF(Item i1, Item i2)
        {
            FileStream tempFile = new FileStream(tempFilePath, FileMode.Create);
            
            PdfReader pdfReader = new PdfReader(formPath);
            PdfStamper pdfStamper = new PdfStamper(pdfReader, tempFile);
            AcroFields fields = pdfStamper.AcroFields;
            fields.SetField("ID#1", i1.CategoryID + i1.ItemID.ToString());
            fields.SetField("Name#1", i1.ItemName);
            fields.SetField("Value#1", i1.ItemValue.ToString());
            fields.SetField("MinBid#1", i1.MinBid.ToString());

            fields.SetField("ID#2", i2.CategoryID + i2.ItemID.ToString());
            fields.SetField("Name#2", i2.ItemName);
            fields.SetField("Value#2", i2.ItemValue.ToString());
            fields.SetField("MinBid#2", i2.MinBid.ToString());

            pdfStamper.Close();
            tempFile.Close();
            pdfReader.Close();
            addPage();

            return true;
        }

        public bool addToPDFWithOneItem(Item i1)
        {
            FileStream tempFile = new FileStream(tempFilePath, FileMode.Create);

            PdfReader pdfReader = new PdfReader(formPath);
            PdfStamper pdfStamper = new PdfStamper(pdfReader, tempFile);
            AcroFields fields = pdfStamper.AcroFields;
            fields.SetField("ID#1", i1.CategoryID + i1.ItemID.ToString());
            fields.SetField("Name#1", i1.ItemName);
            fields.SetField("Value#1", i1.ItemValue.ToString());
            fields.SetField("MinBid#1", i1.MinBid.ToString());

            fields.SetField("ID#2", "");
            fields.SetField("Name#2", "");
            fields.SetField("Value#2", "");
            fields.SetField("MinBid#2", "");

            pdfStamper.Close();
            tempFile.Close();
            pdfReader.Close();
            addPage();

            return true;
        }

        private void addPage()
        {
            using (var sourceDocumentStream1 = new FileStream(tempFilePath, FileMode.Open))
            {
                var pdfReader = new PdfReader(sourceDocumentStream1);
                pdfConcat.AddPages(pdfReader);
                pdfReader.Close();
            }
        }


        public string DoubleTemplatePath
        {
            get
            {
                return doubleTemplatePath;
            }

            set
            {
                doubleTemplatePath = value;
            }
        }

        public string SingleTemplatePath
        {
            get
            {
                return singleTemplatePath;
            }

            set
            {
                singleTemplatePath = value;
            }
        }
    }
}
