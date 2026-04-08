Rekening rekening = new Rekening("2001152");

bool ulang = true;
int jumlah;
string pilihan;

while (ulang)
{
    Console.WriteLine("Menu ATM");
    Console.WriteLine($"1. Display Info \n2. Setor Uang \n3. Tarik Uang \n4. Keluar");
    Console.WriteLine("input Pilihan: ");
    pilihan = Console.ReadLine();


    switch (pilihan)
    {
        case "1":   
                rekening.DisplayInfo();
                break;

            case "2":
            Console.WriteLine("Masukkan jumlah uang: Rp. ");
            jumlah = int.Parse(Console.ReadLine());
            rekening.SetorUang(jumlah);
            break;

            case "3":
            Console.WriteLine("Masukkan jumlah uang: Rp. ");
            jumlah = int.Parse(Console.ReadLine());
            rekening.TarikUang(jumlah);
            break;

            case "4":
            Console.WriteLine("Terima kasih sudah menggunakan layanan kami");
            ulang = false;
            break;
    }
}

class Rekening
{
    private string _noRekening;
    private int _saldo;

    
    public string NoRekening
    {
        get {return _noRekening;}
    }

    public int Saldo
    {
        get { return _saldo; }
        set
        {
            if (value < 0) Console.WriteLine("Saldo tidak boleh negatif!");
            else _saldo = value;
        }
    }

    public Rekening(string no_rekening)
    {
        _noRekening = no_rekening;
        _saldo = 100000;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Menampilkan Info...");
        Console.WriteLine($"No. Rekening: {NoRekening}");
        Console.WriteLine($"Saldo saat ini Rp.{Saldo} ");
    }

    public void SetorUang(int jumlah)
    {
        if ( jumlah <= 0 )
        {
            Console.WriteLine("Jumlah uang tidak boleh negatif atau nol");
        }
        else
        {
            {
                Saldo += jumlah;
                Console.WriteLine($"Berhasil setor uang sebesar Rp.{jumlah}");
                Console.WriteLine($"Jumlah Saldo Sekarang: Rp.{Saldo}");
            }
        }
    }

    public void TarikUang(int jumlah)
    {
        if (jumlah > Saldo)
        {
            Console.WriteLine("Saldo Tidak mencukupi");
        }
        else
        {
            Saldo -= jumlah;
            Console.WriteLine($"Saldo berhasil ditarik sebesar Rp.{jumlah}");
            Console.WriteLine($"Jumlah Saldo Sekarang: Rp.{Saldo}");
        }
    }
}
