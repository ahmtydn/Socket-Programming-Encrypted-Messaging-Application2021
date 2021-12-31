using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Net.Sockets;
using System.Diagnostics;
using System.Security.Cryptography;
using System.IO;
using Encryption;
using Ionic.Zip;

namespace Client
{
    public partial class Client : Form
    {
   
        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        /// <summary>
        /// InterNetwork = ipv4 ailesi için
        ///SocketType.Dgram= UDP için
        ///SocketType.Stream= TCP için
        ///ProtocolType.IP = TCP ve UDP
        /// </summary>
        public Client()
        {
            InitializeComponent();

        }
        byte[] receivedBuf = new byte[1024];//veri almak için yer ayırdık

        /// <summary>
        /// buffer=Türünde bir dizi Byte yani alınan veri için depolama konumu.
       /// offset=Sıfır tabanlı konumu buffer, alınan verileri depolamak parametre.
       ///size=Almak için bayt sayısı.
       ///socketFlags=Bit seviyesinde birleşimini SocketFlags değerleri.
       ///callback= Bir AsyncCallback işlemi tamamlandığında harekete geçirmek için bir yönteme başvuran bir temsilci.
      /// state= Alma işlemi hakkında bilgi içeren bir kullanıcı tanımlı nesne.Bu nesne için geçirilen EndReceive işlemi tamamlandığında temsilci.

        ///     https://msdn.microsoft.com/tr-tr/library/dxkwh6zw(v=vs.110).aspx adresine bakabilirsin
      /// </summary>
      /// <param name="ar"></param>
        private void ReceiveData(IAsyncResult ar)//burası asenkron oldugu için hep çalışır thread gibi veriyi almak için
        {

            int listede_yok = 0;//yok
            try
            {

                Socket socket = (Socket)ar.AsyncState;//asenkron soketi alırız
                int received = socket.EndReceive(ar);//verinin toplam uzunlugu
                byte[] dataBuf = new byte[received];//verıyı byte cevırdık
                Array.Copy(receivedBuf, dataBuf, received);//dataBuf=receivedBuf ve received uzunluk
                string gelen = Encoding.ASCII.GetString(dataBuf).ToString();//serverdan gelen mesaj
                if (gelen.Contains("sil*"))
                {
                    string parcala = gelen.Substring(4, (gelen.Length - 4));
                    Console.WriteLine("degerim  " + parcala);
                    for (int j = 0; j < clientListBox.Items.Count; j++)//list boxtanda kaldır
                    {
                        if (clientListBox.Items[j].Equals(parcala))
                        {
                            clientListBox.Items.RemoveAt(j);

                        }
                    }
                }
                else if (gelen.Contains("@"))//içerisinde @ içeriyorsa clienti listeye eklicez
                {

                    for (int i = 0; i < clientListBox.Items.Count; i++)//listedeki itemler kadar dön
                    {
                        if (clientListBox.Items[i].ToString().Equals(gelen))//listede varsa o client
                        {
                            listede_yok = 1;//var
                        }
                    }
                    if (listede_yok == 0)//yoksa  ekle clienti
                    {
                        string ben = "@" + txName.Text;
                        if (ben.Equals(gelen))//kendimi ekleme
                        {

                        }
                        else
                        {
                            clientListBox.Items.Add(gelen);
                        }
                    }

                }
                else
                {

                    TXTsonmesaj.Text = gelen + "\n";
                }




                _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
             

            }
            catch (Exception e)
            {
                Console.WriteLine("ReceiveData() metodunda hata " + e.Message);
            }

        }


        /// <summary>
        /// server bağlantısı kurma fonksiyonu
        /// </summary>
        private void LoopConnect()
        {
            int attempts = 0;
            while (!_clientSocket.Connected)//server çalışmıyorsa(çalışısaya kadar döngü döner)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect("127.0.0.1", 100);//127.0.0.1=IPAddress.Loopback demek 100 portuna bağlan
                }
                catch (SocketException)
                {
                    //Console.Clear();
                    //   label3.Text = ("bağlantılar: " + attempts.ToString());
                    Console.WriteLine("bağlantılar: " + attempts.ToString());
                }
            }
            
            _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);//AsyncCallback thread gibi asenkron eş zamansız çalışıyor
            byte[] buffer = Encoding.ASCII.GetBytes("@@" + txName.Text);//ismimizin başına 2 tane @@ koydum belli olsun
            _clientSocket.Send(buffer);//veriyi gönderdim servera
            lblbaglanti.ForeColor = Color.Green;
            lblbaglanti.Text = ("Online");//servere bağlandı
        }

    


        private void button1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(LoopConnect);
            t1.Start();
        }

        private Stopwatch stopWatch = new Stopwatch();
        public static string anahtar;

     
        

        /// <summary>
        /// Sifrelenmiş metinin diğer cliente gönderilmesi
        /// </summary>
        private void sifreliGonder(string sifreli)
        {



            if (_clientSocket.Connected)//client servera bağlı ise
            {
                string tmpStr = "";
                foreach (var item in clientListBox.SelectedItems)//listboxtaki seçili itemlere
                {

                    tmpStr = clientListBox.GetItemText(item);//isimlerini
                    byte[] buffer = Encoding.UTF8.GetBytes(tmpStr + " : " + sifreli + "*" + txName.Text);//byte çevir
                    _clientSocket.Send(buffer);//ve gönder ip ve porta
                    Thread.Sleep(20);//yapmasanda olur(fakat 4 cliente bırden mesaj gonderınce dıgerlerine gıtmeyebılir)

                }
                if (tmpStr.Equals(""))
                {
                    MessageBox.Show("lütfen göndermek istediğiniz kişiyi seçiniz!");
                }
                else
                {
                    TXTsonmesaj.Text = (txName.Text + ": " + sifreli + "\n");
                }


            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (spnchkbox.Checked == true)
            {



                lblcozmesaj.Text = "";

                stopWatch.Start();

                SPN_encryption spn = new SPN_encryption(txtAnahtar.Text);
                string coz1 = spn.decrypt(TXTsonmesaj.Text.Trim());

                txtbxCozuldu.Text = coz1;
                stopWatch.Stop();
                TimeSpan t = stopWatch.Elapsed;



            }
            else if (shachkbox.Checked == true)
            {
                lblcozmesaj.Text = "";
                string password = txtAnahtar.Text;
                string encryptedText = TXTsonmesaj.Text;
                string notEncryptedText = Decrypt(password, encryptedText);

                txtbxCozuldu.Text = notEncryptedText;
            }
            else
                lblcozmesaj.Text = "Lütfen şifreleme türünü seçiniz...";

        }


        /// <summary>
        /// Metin şifrelme fonksiyonu
        /// </summary>
        public string Encrypt(string key, string data)
        {
            string encData = null;
            byte[][] keys = GetHashKeys(key);

            try
            {
                encData = EncryptStringToBytes_Aes(data, keys[0], keys[1]);
            }
            catch (CryptographicException) { }
            catch (ArgumentNullException) { }

            return encData;
        }

        /// <summary>
        /// Metin çzöme fonksiyonu
        /// </summary>
        public string Decrypt(string key, string data)
        {
            string decData = null;
            byte[][] keys = GetHashKeys(key);

            try
            {
                decData = DecryptStringFromBytes_Aes(data, keys[0], keys[1]);
            }
            catch (CryptographicException) { }
            catch (ArgumentNullException) { }

            return decData;
        }

        /// <summary>
        ///Sha 256 hash alma fonksiyonu
        /// </summary>
        private byte[][] GetHashKeys(string key)
        {
            byte[][] result = new byte[2][];
            Encoding enc = Encoding.UTF8;

            SHA256 sha2 = new SHA256CryptoServiceProvider();

            byte[] rawKey = enc.GetBytes(key);
            byte[] rawIV = enc.GetBytes(key);

            byte[] hashKey = sha2.ComputeHash(rawKey);
            byte[] hashIV = sha2.ComputeHash(rawIV);

            Array.Resize(ref hashIV, 16);

            result[0] = hashKey;
            result[1] = hashIV;

            return result;
        }


        private static string EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            byte[] encrypted;

            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt =
                            new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encrypted);
        }


        private static string DecryptStringFromBytes_Aes(string cipherTextString, byte[] Key, byte[] IV)
        {
            byte[] cipherText = Convert.FromBase64String(cipherTextString);

            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt =
                            new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }



     
        private void shachkbox_MouseClick(object sender, MouseEventArgs e)
        {
            spnchkbox.Checked = false;
            lblanahtarUyari.Text = "";
            txtAnahtar.MaxLength = default;
        }

        
        private void spnchkbox_MouseClick(object sender, MouseEventArgs e)
        {
            shachkbox.Checked = false;
            txtAnahtar.MaxLength = 8;
            if (txtAnahtar.Text.Length == 8)
            {
                lblanahtarUyari.Text = "";
            }
            else
            {
                lblanahtarUyari.Text = "Spn Şifreleme için Anahtar uzunluğu 8 hane olmalıdır";
            }
        }


        private void btnDosyaGonder_Click(object sender, EventArgs e)
        {
            if (txtboxdosyaisim.Text == "")
            {
                MessageBox.Show("Lütfen Dosya ismini giriniz ...");
            }
            else
            {
                Ziple();
                string yol = "C:\\Users\\ahmet\\Desktop\\";
                EncryptFile(yol + txtboxdosyaisim.Text + ".zip", txtboxdosyaisim.Text + "Sifreli");
            }
           
            
        }

        /// <summary>
        /// dosya zipleme
        /// </summary>
        public void Ziple()

        {


            OpenFileDialog ofd = new OpenFileDialog();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ZipFile zf = new ZipFile("C:\\Users\\ahmet\\Desktop\\"+txtboxdosyaisim.Text+".zip");
                zf.AddFile(ofd.FileName, "");
                zf.Save();
                MessageBox.Show(txtboxdosyaisim.Text + ".zip Dosyası Başarıyla oluşturuldu :)");
            }

        }
        /// <summary>
        /// Dosya Şifreleme Fonksiyonu.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        private void EncryptFile(string inputFile, string outputFile)
        {

            try
            {
                string password = @"myKey123"; // Your Key Here
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
                MessageBox.Show("Dosya Şifreleme Başarılı");
            }
            catch
            {
                MessageBox.Show("Encryption failed!", "Error");
            }
        }
        /// <summary>
        /// Şifrelenen Dosyanın çözülme fonksyonu
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        private void DecryptFile(string inputFile, string outputFile)
        {

            {
                string password = @"myKey123"; // Your Key Here

                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
                MessageBox.Show("Dosya Şifre Çözme Başarılı");

            }
        }

     
        private void btnDosyaCoz_Click(object sender, EventArgs e)
        {
            if (txtboxdosyaisim.Text=="")
            {
                MessageBox.Show("Lütfen Dosya ismini giriniz ...");
            }
            else {
                string yol = "C:\\Users\\ahmet\\Desktop\\Socket-Programming-Encrypted-Messaging-Application2021-main\\Socket-Programming-Encrypted-Messaging-Application2021-main\\Client\\bin\\Debug\\";
                DecryptFile(yol + txtboxdosyaisim.Text + "Sifreli", txtboxdosyaisim.Text + "Çözülmüş.zip");
            }
            }
        /// <summary>
        /// Mesaj gönderme butonu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMesajGonder_Click(object sender, EventArgs e)
        {
            if (spnchkbox.Checked == true)
            {
                if (txt_text.Text.Length % 2 == 1)
                {
                    txt_text.Text += " ";

                    MessageBox.Show("Mesaj uzunluğunuz tek sayı olduğundan düzenlendi.Lütfen Gönder butonuna tekrar basınız...");
                }
                else if (txtAnahtar.Text.Length == 8)
                {
                    lblchckboxuyari.Text = "";
                    stopWatch.Start();

                    key = txtAnahtar.Text;
                    SPN_encryption spn = new SPN_encryption(txt_text.Text, key);

                    string sifreli = spn.encrypt();
                    stopWatch.Stop();
                    TimeSpan t = stopWatch.Elapsed;

                    sifreliGonder(sifreli);
                }
                else
                {
                    MessageBox.Show("Spn Şifreleme için Anahtar uzunluğu 8 hane olmalıdır");
                }



            }
            else if (shachkbox.Checked == true)
            {
                lblchckboxuyari.Text = "";
                string password = txtAnahtar.Text;
                string notEncryptedText = txt_text.Text;

                string encryptedText = Encrypt(password, notEncryptedText);
                sifreliGonder(encryptedText);
            }
            else
                lblchckboxuyari.Text = "Lütfen şifreleme türünü seçiniz...";
        }




        //SPN ŞİFRELEME


        public static string plainText, bin_plainText, key, bin_Key, s_Boxes = "", cipherText;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ataman Kurutmaz 192802073\n"
                            +"BARAN YALÇIN 192804007\n"
                            +"AHMET AYDIN 192802002\n"
                            +"MUSTAFA ATAŞ 192802013\n", "BAAMChat");
        }

        /// <summary>
        /// Anahtar Textboxı için kısıtlamalar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAnahtar_TextChanged_1(object sender, EventArgs e)
        {
            if (spnchkbox.Checked)
            {

                if (txtAnahtar.Text.Length == 8)
                {
                    lblanahtarUyari.Text = "";
                }
                else
                {
                    lblanahtarUyari.Text = "Spn Şifreleme için Anahtar uzunluğu 8 hane olmalıdır";
                }
            }
        }

        /// <summary>
        /// Client yüklenme fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void s_Load(object sender, EventArgs e)
        {
            spnchkbox.Checked = true;
            if (spnchkbox.Checked)
            {
                txtAnahtar.MaxLength = 8;
            }
        }


        /// <summary>
        /// XOR işlem fonkisyonu 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string calcXOR(byte a, byte b)
        {
            char[] charAArray = Convert.ToString(a, 2).PadLeft(8, '0').ToCharArray();
            char[] charBArray = Convert.ToString(b, 2).PadLeft(8, '0').ToCharArray();
            char[] result = new char[8];
            string control = "";
            for (int i = 0; i < 8; i++)
            {
                control = charAArray[i].ToString();
                control += charBArray[i].ToString();
                if (control == "01" || control == "10")
                    result[i] = '1';
                else
                    result[i] = '0';
            }
            return new string(result);
        }
    }
}
