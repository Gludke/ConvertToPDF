﻿using ConvertPDF;
using InteropWindows2;
using PDFsharpWindows;
using System.Text;



Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

ConvertWordToPdf();
ConvertImgToPdf();

Console.ReadLine();




static void ConvertImgToPdf()
{
    PdfHelper.SaveImageAsPdf("C:\\Users\\Guilherme\\Desktop\\Teste02png.png", "C:\\Users\\Guilherme\\Desktop\\Teste01.pdf");

    Console.WriteLine("Imagem convertida para PDF.");
}

static void ConvertWordToPdf()
{
    var pathPdf = ConvertInterop.WordToPdf("C:\\Users\\Guilherme\\Desktop\\Doc01.docx", "C:\\Users\\Guilherme\\Desktop\\Doc01.pdf");

    Console.WriteLine("Documento Word convertido para PDF.");

    //Console.WriteLine("Aperte ENTER para remover o documento");
    //Console.ReadLine();

    //if (File.Exists(pathPdf)) File.Delete(pathPdf);

    //Console.WriteLine("Documento removido.");
    //Console.ReadLine();
}

static void Test(string pathPdf)
{
    string fileString;

    using (var filePdf = new StreamReader(pathPdf))
    {
        fileString = Utils.ConvertToBase64(filePdf.BaseStream);
    }
}





