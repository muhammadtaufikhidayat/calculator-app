using System;

namespace tugas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi Kalkulator\n");

            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("Masukkan Pilihan [1..4]: ");
            int pilih = int.Parse(Console.ReadLine());
            
            if (pilih == 1)
            {
                Console.Write("\nMasukkan Nilai a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Nilai b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + Penambahan(a,b));
                Console.WriteLine("Tekan sembarang key untuk keluar");
                Console.ReadKey();
            }else if(pilih == 2){
                Console.Write("\nMasukkan Nilai a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Nilai b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Hasil Pengurangan " + a 
                + " - " + b + " = " + Pengurangan(a,b));
                Console.WriteLine("Tekan sembarang key untuk keluar");
                Console.ReadKey();
            }else if(pilih == 3){
                Console.Write("\nMasukkan Nilai a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Nilai b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                
                Console.WriteLine("Hasil Perkalian " + a 
                + " * " + b + " = " + Perkalian(a,b));
                Console.WriteLine("Tekan sembarang key untuk keluar");
                Console.ReadKey();
            }else if(pilih == 4){
                Console.Write("\nMasukkan Nilai a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan Nilai b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                
                Console.WriteLine("Hasil Pembagian " + a 
                + " / " + b + " = " + Pembagian(a,b));
                Console.WriteLine("Tekan sembarang key untuk keluar");
                Console.ReadKey();
            } else{
                Console.WriteLine("Maaf Menu Yang anda pilih tidak tersedia");
                Console.WriteLine("tekan sembarang key untuk melanjutkan!");
                Console.ReadKey();
            }
        }
        static int Penambahan(int a, int b){
            return a + b;
        }
        static int Pengurangan(int a, int b){
            return a - b;
        }
        static int Perkalian(int a, int b){
            return a * b;
        } 
        static int Pembagian(int a, int b){
            return a / b;
        }
    }
}
