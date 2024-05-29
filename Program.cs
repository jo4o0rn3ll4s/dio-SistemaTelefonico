
using telefone.models;

Nokia nk1 = new Nokia("2197070-6170","LumiaPhone","123ABC456DEF789",256);
IPhone ip1 = new IPhone("249090-1202","20 Ultra-ProMax","987ABC654DEF321",512);

nk1.Ligar();
ip1.ReceberLigacao();

ip1.Ligar();
nk1.ReceberLigacao();

ip1.InstalarAplicativo("Instagram");
nk1.InstalarAplicativo("Mercado Livre");