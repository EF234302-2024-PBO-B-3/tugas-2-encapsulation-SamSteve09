using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Encapsulation.Extra
{
    /*
     * Soal simulasi pajak penghasilan berdasarkan aturan yang ada di Indonesia
     * Kelas yang dibuat: Tax
     * Atribut apa saja yang dibutuhkan: Nama Lengkap(_fullName & FullName), NIK(_nik & Nik) dan 
     * Gaji Bulanan(_monthlySalary & MonthlySalary) menggunakan encapsulation
     * Metode apa saja yang dibutuhkan: GetYearlySalary untuk mendapatkan gaji tahunan, GetTaxBracket untuk mendapatkan persentase
     * pajak yang harus dibayar berdasarkan pajak tahunan, GetTaxAmount untuk mendapatkan total pajak yang perlu dibayar per tahun
     * Validasi atau aturan apa yang harus dilakukan: Nama dan NIK tidak boleh null, NIK harus 16 digit,
     * jika Nama dan/atau NIK salah maka kedua atribut tersebut akan diset ke Unknown
     * Gaji bulanan tidak boleh negatif, jika negatif akan dibulatkan ke 0.
     */
    // Implementasi solusi soal
    public class Tax
    {
        private string _fullName;
        private string _nik;
        private double _monthlySalary;
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        public string Nik
        {
            get { return _nik; }
            set { _nik = value; }
        }

        public double MonthlySalary
        {
            get { return _monthlySalary; }
            set
            {
                if (value > 0) _monthlySalary = value;
            }
        }
        public Tax(string Ful, string Ni, double Mon)
        {
            if (string.IsNullOrEmpty(Ful) || string.IsNullOrEmpty(Ni) || Ni.Length != 16)

            {
                Ful = "Unknown";
                Ni = "Unknown";
            }
            if (Mon < 0) Mon = 0;
            FullName = Ful;
            Nik = Ni;
            MonthlySalary = Mon;
        }
        public double GetYearlySalary()
        {
            double total = this.MonthlySalary * 12;
            return total;
        }
        public int GetTaxBracket()
        {
            double salary = GetYearlySalary();
            // more than 5 billion IDR return 35 percent tax rate
            if (salary > 5000000000)
            {
                return 35;
            } // more than 500 million IDR return 30 percent tax rate
            else if (salary > 500000000)
            {
                return 30;
            } // more than 250 million IDR return 25 percent tax rate
            else if (salary > 250000000)
            {
                return 25;
            } // more than 60 million IDR return 15 percent
            else if (salary > 60000000)
            {
                return 15;
            } // more than 54 million IDR return 5 percent
            else if(salary > 54000000)
            {
                return 5;
            }
            // 54 million IDR and below return 0 percent
            else
            {
                return 0;
            }
        }
        public double GetTaxAmount()
        {
            double multiplier = (double)this.GetTaxBracket() / 100;

            return GetYearlySalary() * multiplier;
        }
    }
}