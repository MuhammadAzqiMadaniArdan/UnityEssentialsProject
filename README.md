# Belajar-Unity-Essential
============================================

<h2>Mission 1 : Editor Essential</h2>

SHORTCUT

ALT + LEFT CLICK = memutar atau melihat seperti orbit di pusat objek
RIGHT CLICK = menggunakna fungsi view
Saat kondisi view :
WASD = standar movement
E = atas
Q = Bawah
F = Frame
shortcut edit or scale
Q 
W
E
R
T
Y

Hold CTRL pada bagian hierarcy dan tekan gameobject berapapun untuk dapat memilih gameobject lebih dari satu pada hierarcy bisa dibuat menajdi parent

========================================================================

<h2>Mission 2 : 3D Essential</h2>

ALIGN WITH VIEW

tekan camera -> cari sudut yang bagus ,menurut kita -> tekan game object camera -> tekan ctrl + shift + f

PLAYMODE TINT -< Melakukan layering atau warna layer Ketika sedang dalam mode  bermain

Mainmenu->Edit->preferences->Colors->playerTint->pilih warna



RigidBody Settings

Mass = Massa / Berat dari objek 


SETTINGS
camera Speeds di camera settings  pada navbar hitam
logo camera=>click->settings speed

Deactive / Active Game Object = Inspector Bagian Atas Klik Checkbok / Tidak 

==============================================================================

<h2>Mission 3 : Audio Essential</h2>

3D Audio Source
Menambahkan Component Audio Source -> Spatial Blend full

Background Music
Hierarcy create Audio -> Audio source di unity 
pilih audio source pada inspector -> kecilkan bagian volume 
ceklis checkbox loop;

Random Music
Hierarcy create Audio -> Audio source di unity
pilih audio source pada inspector -> matikan Play On Awake 
->Spatial Blend Dimaksimalkan menjadi max
Tambah Component = Play Sound at Random Intervals
pada components Min : Max Seconds = 3 : 12 (opsional)

======================================================================

<h2>Mission 4 : Programming Essential</h2>

Cara Membuat Camera Mengikuti player
masukkan camera ke dalam Gameobject / prefabs player -> inspector Rotate = x:0,y:0,z:0 -> Position mengikuti keinginan sendiri -> kamera mengikuti movement player 

Jika Ingin melihat kode program untuk objek yang lain saat mode Bermain / Play
Pada Bawah Tombol start / stop / next -> ada navbar scene dan tekan -> cari objek yang ingin delihat Ketika mode bermain bisa pakai frame atau klik 2 kali 

Jika ingin melakuakn eklarasi float pada nilai di C# gunakan indikasi f diakhir nomor 
Contoh :

0.5f / JIka hanya mengisi daa 0.5 maka akan menampilkan error 

Melakukan deklarasi variable untuk melakukan set langsung di unity :
gunakan deklarasi dengan format
visibility | tipe data | namaVar
Contoh : 
public float rotationSpeed;


Jika ingin Melakukan interaksi dengan benda atau gameObject lain ceklis bagian isTrigger pada bagian component box Collider pada bagian gameobject yang ingin diberikan code interaksi

Inertaksi dalam code :
Menggunakan OntriggerEnter di code dengan game Object yang ingin dientarksi 
code : 
private void OnTriggerEnter(Collider other) {

}

Membuat Instansiasi
Instasiasi : menciptakan salinan objek selama runtime, yaitu saat aplikasi berjalan. Dalam konteks Unity, kita sering kali menginstansiasi prefab, yaitu objek yang sudah didefinisikan sebelumnya, untuk membuat salinannya di dalam scene

intinya jika kita ingin membuat suatu efek dari gameobject tertentu saat melakukan interaksi denagn gameobject tersebuut.
contoh :
Misalnya, ketika pemain bertabrakan dengan objek tertentu (seperti collectible), kita dapat menginstansiasi sebuah efek partikel sebagai respons dari tabrakan tersebut, sehingga efek tersebut terlihat di lokasi dan rotasi tertentu.

Fungsi Instantiate di Unity digunakan untuk membuat instance atau salinan baru dari sebuah objek yang sudah ada. Untuk menggunakan Instantiate, kita perlu menentukan beberapa parameter, yang dipisahkan dengan tanda koma, seperti:

Objek apa yang akan diinstansiasi.
Posisi tempat objek baru ini muncul.
Rotasi yang akan diterapkan pada objek baru ini.

contoh : 

Instantiate(particleEffect, transform.position, Quaternion.identity);

Ket :

particleEffect: Objek yang akan diinstansiasi. Biasanya ini adalah prefab (contohnya, efek partikel) yang akan muncul saat event tertentu terjadi.

transform.position: Posisi tempat objek baru muncul. Dalam contoh ini, objek baru akan muncul di posisi objek yang memiliki script (misalnya, posisi pemain).

Quaternion.identity: Rotasi default (tanpa rotasi tambahan) yang akan diterapkan pada objek baru. Quaternion.identity berarti objek muncul tanpa rotasi tambahan dari prefab aslinya.

Dengan urutan ini, Instantiate tahu objek apa yang harus dimunculkan, di mana posisinya, dan dengan rotasi seperti apa.

Kita bisa melakukan kondisi jika hanya untuk gamobject tertentu contoh untuk player
maka bagian gameobject player harus dibuat tag player agar gameobject dapat melakukan pengkondisian seperti dibawah :

if (other.CompareTag("Player")) {
 
}

Membuat Group GameObject

Membuat Group GameObject dengan cara select all gameobject yang ingin dijadikan group lalu tekan -> Create Empty Parent

Membuat Movement Jump 

contoh :

if (Input.GetButtonDown("Jump")) {
    rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
}

ket : 

Input.GetButtonDown("Jump"):

Fungsi Input.GetButtonDown memeriksa apakah tombol yang ditentukan ("Jump") ditekan pada frame itu.
"Jump" adalah nama default untuk tombol lompat dalam Unity, yang biasanya diatur untuk tombol "Space" pada keyboard. Jadi, jika pemain menekan tombol "Jump", perintah dalam blok if akan dieksekusi.

rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);:

rb adalah variabel dari tipe Rigidbody, komponen fisika di Unity yang memungkinkan objek berinteraksi dengan fisika seperti gravitasi dan gaya.
AddForce adalah metode yang digunakan untuk menerapkan gaya pada Rigidbody sehingga objek tersebut bergerak.
Vector3.up adalah vektor yang mengarah ke atas pada sumbu Y (0,1,0). Dengan mengalikan Vector3.up dengan jumpForce, kita membuat vektor yang mengarahkan gaya ke atas dengan besar gaya jumpForce.
ForceMode.VelocityChange adalah mode yang mengatur gaya diterapkan langsung sebagai perubahan kecepatan objek, mengabaikan massanya.


=================================================================================================================

<h2>Mission 5 : 2D Essential</h2>

2D Camera :

Pada Navbar -> Tekan button dengan tulisan "2D" -> camera bersifat 2D

Add Sprite :

Menambahkan Sprite dengan melakukan hold sprite dan direct ke bagian scene


RigidBody :

Menggunakan RigidBody2D

Menghapus Gravitasi :

Pada RigidBisy Ubah "Gravity Scale" = 0

Aspect Ratio :

Menetapkan Lebar dan Panjang dari scene agar di media yang lebih kecil tetap berukuran sama / Agar scene & game menjadi ukuran yang konsisten

Navbar -> navbar Game (samping scene) -> Tekan "Free Aspect" -> ubah menjadi -> 16 : 9 Aspect

Menambahkan sprite square

Hierarcy klik -> 2D Object -> Sprites -> Square

Mengedit gameobject

tekan gameObject -> keyboard klik t / klik rect tool 

Collider 2D (Object dapat bertabrakan)

Pada Object Square 2d yang sudah dibuat -> tambahkan Box Collider 2D

Object Circle -> tambahkan Cicrcle Collider 2D

Shortcut :

Select all -> tekan satu object pada hierarcy tekan shift pada objek terakhir yang ingin digroup sesuai urutan

Tambah Component Sekaligus -> selectAll -> Add Component yang mau ditambahkan

Melakukan Jarak yang sama -> saat ingin menggeser object geser sambal tekan ctrl -> ctrl + klik ke arah mana object yang ingin dipindahkan																								

Layer :

Layer digunakan sebagai background dan ibject yang timpang tindih contoh :

Rugs / carpet dibawah meja -> maka -> meja harus memiliki layer yang besar

klik layer -> inspector -> bagian Bawah -> additional Settings -> Order in Layer -> tentukan layer keberapa

misal rugs layer = 5 & object di atas rugs seperti meja layer = 10

RigidBody Linear & Angular Dumping :

Linear Dumping : Redaman Linear digunakan jika terjadi interkasi pada object tersebut / Ketika objek didorong maka hasilnya akan diredam 

Penjelasan mudah :

[!] Semakin tinggi nilai linear damping, semakin cepat objek akan berhenti setelah didorong. Ini bisa digunakan untuk membuat objek terasa lebih berat atau lambat bergerak, seperti furnitur yang memberikan perlawanan saat didorong oleh pemain.

Angular Dumping : Redaman Rotasi / sudut komponen digunakan jika object terdorong maka akan diredam putaran yang diberikan dari hasil dorongan oleh gameObject lain

Penjelasan mudah :

Angular damping mengatur seberapa cepat rotasi atau putaran objek akan melambat saat tidak ada momen gaya (torque) yang diberikan.

[!] Semakin tinggi nilai angular damping, semakin cepat objek akan berhenti berputar setelah diputar. Ini berguna untuk membuat objek tidak terus berputar tanpa kontrol, sehingga rotasi terasa lebih realistis dan tidak berlebihan.

Jika ingin menggunakannya pada furniture bisa diset diantara 5 - 10 (Opini)

RigidBody Mass :

Mass adalah berat  massa dari component yang menggunakna rigidBody -> jika setiap object ingin diset memiliki massa yang berbeda bisa menggunakan mass agar lebih terasa realistic dan real movement object

Penjelasan mudah :
Massa adalah ukuran seberapa berat atau ringan sebuah objek. Di Unity, objek dengan massa lebih besar akan membutuhkan lebih banyak gaya untuk dipindahkan dibandingkan dengan objek dengan massa lebih kecil.

[!] Jika massa sebuah objek (misalnya sofa) dibuat lebih besar daripada massa objek lain (seperti sepatu), maka pemain akan membutuhkan usaha lebih untuk mendorong atau menggerakkan sofa dibandingkan sepatu.

Dengan mengatur massa pada objek, pengalaman bermain menjadi lebih realistis. Objek yang lebih besar dan lebih berat akan terasa lebih sulit digerakkan, sementara objek yang ringan lebih mudah untuk didorong atau dipindahkan.

contoh :

[!] Jika ingin membuat furnitur yang lebih berat, seperti sofa, terasa lebih sulit untuk didorong daripada objek yang lebih ringan, seperti sepatu, cukup tambahkan nilai massa yang lebih besar pada objek sofa. Hasilnya, pemain akan merasa seperti benar-benar mendorong objek yang berat, membuat pengalaman bermain lebih realistis dan imersif.

Tips :

Jika ingin menggunakannya pada furniture 2sofa,1sofa,sepatu,kursi dan lainnya bisa di set diantara 1 - 10 (Opini)

UI Prefabs :

UI untuk system Game contoh : collectable remaining
