using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App2
{
    class Contact
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Tel { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public int QRcode { get; set; }

        public Contact()
        {

        }
        public Contact(string username, string password, string name, int tele, string email, string company)
        {
            Username = username;
            Password = password;
            Name = name;
            Tel = tele;
            Email = email;
            Company = company;
        }
        //CreateBarcode(Contact);

        public static void CreateBarcode(string[] args)
        {
            //var writer = new BarcodeWriter
            //{
            //    Format = BarcodeFormat.QR_CODE,
            //    Options = new d
            //    {
            //        Name = ,
            //        Width = 600
            //    }
            //};
            //var bitmap = writer.Write("My content");

            ///////////////////////////////////////////

            //    IBarcodeWriter writer = new BarcodeWriter
            //    {
            //        Format = BarcodeFormat.AZTEC
            //    };
            //    Bitmap aztecbitmap;

            //    var result = writer.Write("hello");
            //    aztecbitmap = new Bitmap(result);

            //    using (var stream = new FileStream("test.bmp", FileMode.OpenOrCreate, ))
            //        FileAccess.ReadWrite))
            //        {
            //        var aztecAsBytes = ImageToByte(aztecbitmap);
            //        Stream.Write(aztecAsBytes, 0, aztecAsBytes.Length);
            //    }
            //
            //public static byte[] ImageToByte(Image img)
            //{
            //    ImageConverter converter = new ImageConverter();
            //    return (byte[])converter.ConvertTo(img, typeof(byte[]));
            //}

            /////////////////////////////////////////////
            /*
            IBarcodeWriter writer = new BarcodeWriter
            { Format = BarcodeFormat.QR_CODE };
            var result = writer.Write("Hello");
            var barcodeBitmap = new Bitmap(result);
            imgBarcode.Image = barcodeBitmap;//*/
        }
    }
}