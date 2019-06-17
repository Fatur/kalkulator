using System;
using Calculator;
namespace CalculatorConsole
{
    class Program
    {
        static Kalkulator m_kalkulator;
        static void Main(string[] args)
        {
            SetupProgram();
            bool isExit=false;
            while(!isExit){
                var bilangan=MasukkanBilangan();
                m_kalkulator.Input(bilangan);
                var isOperasi=PilihAksi();
                if(isOperasi){
                    var isPenjumlahan=PilihOperasi();
                    if(isPenjumlahan){
                        m_kalkulator.Tambah();
                    }else{
                        m_kalkulator.Kurang();
                    }
                }else{
                    Console.WriteLine($"Hasil kalkulasi adalah {m_kalkulator.Output()}");
                    isExit=PilihKeluar();
                }
           
            }
            
        }
        static bool PilihKeluar(){
            Console.WriteLine("Pilih 1. Keluar. 2. Hitung Lagi");
            var operasi=Console.ReadLine();
            if(operasi.ToLower().Equals("1"))
                return true;
            else if(operasi.ToLower().Equals("2")){
                m_kalkulator.Reset();
                return false;
            }
            else{
                Console.WriteLine("Pilihan tidak bisa dimengerti.");
                return PilihKeluar();
            }
        }
        static bool PilihOperasi(){
            Console.WriteLine("Pilih 1. Penjumlahan. 2. Pengurangan");
            var operasi=Console.ReadLine();
            if(operasi.ToLower().Equals("1"))
                return true;
            else if(operasi.ToLower().Equals("2"))
                return false;
            else{
                Console.WriteLine("Operasi tidak bisa dimengerti.");
                return PilihOperasi();
            }
        }
        static bool PilihAksi(){
            Console.WriteLine("Pilih 1. Operasi. 2. Hasil");
            var aksi=Console.ReadLine();
            if(aksi.ToLower().Equals("1"))
                return true;
            else if(aksi.ToLower().Equals("2"))
                return false;
            else{
                Console.WriteLine("Aksi tidak bisa dimengerti.");
                return PilihAksi();
            }
        }
        static int MasukkanBilangan(){
            Console.WriteLine("Masukkan bilangan");
            var bilangan=Console.ReadLine();
            int result=0;
            var convertSuccess=int.TryParse(bilangan,out result);
            if(convertSuccess)
                return result;
            else{
                Console.WriteLine($"Gagal mengkonversi {bilangan} menjadi integer.");
                return MasukkanBilangan();
            }
        }
        static void SetupProgram(){
           Console.WriteLine("Tekan enter untuk memulai."); 
           Console.ReadLine();
           m_kalkulator=new Kalkulator();
        }
    }
}
