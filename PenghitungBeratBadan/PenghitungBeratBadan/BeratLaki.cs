﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PenghitungBeratBadan
{
    internal class BeratLaki
    {
        private double berat;
        private int tinggi;
        private double ideal;

        /*
         *  Encapsulaption Menyembunyikan 
         *  Data Yang Penting atau Kompleks 
         *  Menggunakan method
         *  Setter and Getter
         */

        public void setBeratTinggiLaki(double berat, int tinggi)
        {
            this.berat = berat;
            this.tinggi = tinggi;
            process();
        }

        public void process()
        {
            this.ideal = ((this.tinggi - 100) - (((this.tinggi - 100) * 10) / 100));
        }

        public double getBeratTinggiLaki()
        {
            return this.berat;
        }
        public void showBeratTinggiLaki()
        {
            if (this.berat > (this.ideal - 5) && this.berat < (this.ideal + 5))
            {
                Console.WriteLine("Berat Badan Anda Adalah Ideal");
            }
            else if (this.berat < (this.ideal - 5))
            {
                Console.WriteLine("Berat Badan Anda Adalah Kurang Ideal");
            }
            else if (this.berat > (this.berat + 5))
            {
                Console.WriteLine("Berat Badan Anda Adalah Berlebihan");
            }
        }
    }
}