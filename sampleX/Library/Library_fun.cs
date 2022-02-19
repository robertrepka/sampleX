using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace sampleX
{
    class RRfun
    {
        RRcode RRcode = new RRcode();

        public string Vyrok(int iPoradie, bool Autor)
        {

            switch (iPoradie)
            {

                default:
                    if (Autor == false)
                    {
                        return "Aj keď človek niekoho miluje, občas na to zabudne.";
                    }
                    else
                    {
                        return "W. S. Maugham";
                    }
                case 1:
                    if (Autor == false)
                    {
                        return "Aj keď človek niekoho miluje, občas na to zabudne.";
                    }
                    else
                    {
                        return "W. S. Maugham";
                    }


                case 2:
                    if (Autor == false)
                    {
                        return "Ženy sú dekoratívne; nikdy nemajú čo povedať, ale hovoria to pôvabne.";
                    }
                    else
                    {
                        return "Oscar Wilde";
                    }
                case 3:
                    if (Autor == false)
                    {
                        return "Ženy sú ako sny - nikdy nie sú také, aké by si ich chcel mať.";
                    }
                    else
                    {
                        return "Pirandello";
                    }
                case 4:
                    if (Autor == false)
                    {
                        return "Ženy sú na to, aby sme ich milovali a nie aby sme im rozumeli.";
                    }
                    else
                    {
                        return "Oscar Wilde";
                    }
                case 5:
                    if (Autor == false)
                    {
                        return "Ženy sú milenky mladých mužov, družky stredného veku a ošetrovateľky starcov.";
                    }
                    else
                    {
                        return "Francis Baconn";
                    }
                case 6:
                    if (Autor == false)
                    {
                        return "Ženy sú slabé - a ako radi to využívajú.";
                    }
                    else
                    {
                        return "Marie de Sevigné";
                    }
                case 7:
                    if (Autor == false)
                    {
                        return "Ženy sú všetkého schopné. sú schopné sa dokonca zamilovať do svojich mužov.";
                    }
                    else
                    {
                        return "Jókai";
                    }
                case 8:
                    if (Autor == false)
                    {
                        return "Ženy sú záhadne krásne po hriechu veselo vykonanom.";
                    }
                    else
                    {
                        return "Pitigrilli";
                    }
                case 9:
                    if (Autor == false)
                    {
                        return "Ženy si navzájom požičiavajú všetko, len nie šaty, mužov a krásu.";
                    }
                    else
                    {
                        return "Jean Paul";
                    }
                case 10:
                    if (Autor == false)
                    {
                        return "Žiť znamená bojovať.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 11:
                    if (Autor == false)
                    {
                        return "Žiť znamená jednať.";
                    }
                    else
                    {
                        return "France";
                    }
                case 12:
                    if (Autor == false)
                    {
                        return "Žiť znamená overovať.";
                    }
                    else
                    {
                        return "Albert Camus";
                    }
                case 13:
                    if (Autor == false)
                    {
                        return "Život je pevnosť, o ktorej ani ja, ani vy nič nevieme.";
                    }
                    else
                    {
                        return "Napoleon";
                    }
                case 14:
                    if (Autor == false)
                    {
                        return "Život je príliš dôležitý na to, aby sa bral vážne.";
                    }
                    else
                    {
                        return "G. K. Chesterton";
                    }
                case 15:
                    if (Autor == false)
                    {
                        return "Život je škola, ale kto môže povedať, že ju absolvoval.";
                    }
                    else
                    {
                        return "Ivan Fontana";
                    }
                case 16:
                    if (Autor == false)
                    {
                        return "Život je vytvorený z budúcnosti, ako telesá z prázdneho priestoru.";
                    }
                    else
                    {
                        return "Sartre";
                    }
                case 17:
                    if (Autor == false)
                    {
                        return "Život je umenie vyvodiť postačujúce závery z nepostačujúcich znalostí.";
                    }
                    else
                    {
                        return "Butler";
                    }
                case 18:
                    if (Autor == false)
                    {
                        return "Ak si chceš zachovať priazeň domu, kam prichádzaš ako priateľ, vyhýbaj sa stykom s jeho ženami. (Starý Egypt)";
                    }
                    else
                    {
                        return "Prahotep";
                    }
                case 19:
                    if (Autor == false)
                    {
                        return "Ak chceš obhájiť svoju autoritu, musíš vedieť trikrát toľko, čo tvoj odporca.";
                    }
                    else
                    {
                        return "František Palacký";
                    }
                case 20:
                    if (Autor == false)
                    {
                        return "Ak chceš zaspať, neotváraj oči, kým nerozoberieš všetky svoje dnešné skutky.";
                    }
                    else
                    {
                        return "Pythagoras";
                    }
                case 21:
                    if (Autor == false)
                    {
                        return "Ak chceš stratiť priateľa, požičaj mu peniaze.";
                    }
                    else
                    {
                        return "České príslovie";
                    }
                case 22:
                    if (Autor == false)
                    {
                        return "Ak chceš, aby nikto nevedel o tvojich zlých skutkoch, nedopúšťaj sa ich.";
                    }
                    else
                    {
                        return "Ralph Waldo Emerson";
                    }
                case 23:
                    if (Autor == false)
                    {
                        return "Ak chceš, aby tvoje deti prežili život v pokoji, nechaj ich trochu hladovať a trocha zažiť zimu.";
                    }
                    else
                    {
                        return "Čínske príslovie";
                    }
                case 24:
                    if (Autor == false)
                    {
                        return "Chcete zmierniť vlastnú bolesť? Pozrite sa na bolesť cudziu.";
                    }
                    else
                    {
                        return "John";
                    }
                case 25:
                    if (Autor == false)
                    {
                        return "Chcete žiť dobre? Kto by nechcel?!";
                    }
                    else
                    {
                        return "Q. Flaccus Horatius";
                    }
                case 26:
                    if (Autor == false)
                    {
                        return "Ak chcete byť toreádorom, musíte najprv vedieť, čo je býk.";
                    }
                    else
                    {
                        return "Španielske príslovie";
                    }
                case 27:
                    if (Autor == false)
                    {
                        return "Ak chcete vedieť, aký ochabnutý je váš mozog, siahnite si na svaly svojich nôh.";
                    }
                    else
                    {
                        return "Segal";
                    }
                case 28:
                    if (Autor == false)
                    {
                        return "Ak chcete vychovať človeka, začnite jeho babičkou.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 29:
                    if (Autor == false)
                    {
                        return "Ak chcete, aby žena mlčala, musíte jej vyznávať lásku alebo sa opýtať na jej vek.";
                    }
                    else
                    {
                        return "Oldřich Fišer";
                    }
                case 30:
                    if (Autor == false)
                    {
                        return "Chcem byť človekom, ktorý sa mi nehnusí.";
                    }
                    else
                    {
                        return "Sartre";
                    }
                case 31:
                    if (Autor == false)
                    {
                        return "Chladná žena je taká, ktorá sa ešte nestretla s tým, koho by milovala.";
                    }
                    else
                    {
                        return "Stendhal";
                    }
                case 32:
                    if (Autor == false)
                    {
                        return "Chlipnosť znamená, že to chceš robiť, i keď ho nemiluješ.";
                    }
                    else
                    {
                        return "Lansky";
                    }
                case 33:
                    if (Autor == false)
                    {
                        return "Chovanie je zrkadlo, v ktorom každý ukazuje svoj obraz.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 34:
                    if (Autor == false)
                    {
                        return "Múdra žena je tá žena, ktorá vie umne zakrývať svoju hlúposť.";
                    }
                    else
                    {
                        return "John";
                    }
                case 35:
                    if (Autor == false)
                    {
                        return "Múdra žena má milióny nepriateľov - všetkých hlúpych mužov.";
                    }
                    else
                    {
                        return "Maria von Ebner-Eschenbachová";
                    }
                case 36:
                    if (Autor == false)
                    {
                        return "Múdru ženu je ťažké milovať, ale ešte ťažšie prestať.";
                    }
                    else
                    {
                        return "Jablonskij";
                    }
                case 37:
                    if (Autor == false)
                    {
                        return "Aj čert bol krásny, keď bol mladý.";
                    }
                    else
                    {
                        return "Francúzske príslovie";
                    }
                case 38:
                    if (Autor == false)
                    {
                        return "Aj dobrí ľudia musia často na zlé privyknúť.";
                    }
                    else
                    {
                        return "Publius Syrus";
                    }
                case 39:
                    if (Autor == false)
                    {
                        return "Aj najrečlivejšiu ženu naučí láska mlčať.";
                    }
                    else
                    {
                        return "Honoré de Balzac";
                    }
                case 40:
                    if (Autor == false)
                    {
                        return "Aj najväčšia vec rastie z malých začiatkov.";
                    }
                    else
                    {
                        return "Publius Syrus";
                    }
                case 41:
                    if (Autor == false)
                    {
                        return "Aj nešťastná láska je krásna, ak je obojstranná.";
                    }
                    else
                    {
                        return "Scheinpflugová";
                    }
                case 42:
                    if (Autor == false)
                    {
                        return "Aj opatrní vtáci bývajú chytení.";
                    }
                    else
                    {
                        return "Nórske príslovie";
                    }
                case 43:
                    if (Autor == false)
                    {
                        return "Aj po zlej úrode je potrebné siať.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 44:
                    if (Autor == false)
                    {
                        return "Aj podľa prázdnych šibeníc poznáš, že niečo visí vo vzduchu.";
                    }
                    else
                    {
                        return "Stanislav Jerzy Lec";
                    }
                case 45:
                    if (Autor == false)
                    {
                        return "Aj pochybné nápady je možné realizovať majstrovsky.";
                    }
                    else
                    {
                        return "Kumor";
                    }
                case 46:
                    if (Autor == false)
                    {
                        return "Aj vedieť znamená moc.";
                    }
                    else
                    {
                        return "Francis Baconn";
                    }
                case 47:
                    if (Autor == false)
                    {
                        return "Aj stará mačka má chuť na mlieko.";
                    }
                    else
                    {
                        return "Švédske príslovie";
                    }
                case 48:
                    if (Autor == false)
                    {
                        return "Aj starec je k naučeniu vždy dosť mladý.";
                    }
                    else
                    {
                        return "Aischylos";
                    }
                case 49:
                    if (Autor == false)
                    {
                        return "Aj žena starne, nikdy však nie je stará.";
                    }
                    else
                    {
                        return "Friedrich Christian Hebbel";
                    }
                case 50:
                    if (Autor == false)
                    {
                        return "Jedine príroda robí veľké veci zadarmo.";
                    }
                    else
                    {
                        return "René Descartes";
                    }
                case 51:
                    if (Autor == false)
                    {
                        return "Jedine príroda vie, čo chce.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 52:
                    if (Autor == false)
                    {
                        return "Jediné víťazstvo nad láskou je útek.";
                    }
                    else
                    {
                        return "Napoleon";
                    }
                case 53:
                    if (Autor == false)
                    {
                        return "Viem, že nič neviem.";
                    }
                    else
                    {
                        return "Sokrates";
                    }
                case 54:
                    if (Autor == false)
                    {
                        return "Iba bohatí si môžu dovoliť byť hlúpi.";
                    }
                    else
                    {
                        return "Q. Flaccus Horatius";
                    }
                case 55:
                    if (Autor == false)
                    {
                        return "Len žena vie, čoho je žena schopná.";
                    }
                    else
                    {
                        return "W. S. Maugham";
                    }
                case 56:
                    if (Autor == false)
                    {
                        return "Len život, ktorý žijeme pre ostatných, stojí za to.";
                    }
                    else
                    {
                        return "Albert Einstein";
                    }
                case 57:
                    if (Autor == false)
                    {
                        return "Iba keď stratíme hlavu, dobyjeme srdce.";
                    }
                    else
                    {
                        return "Turecké príslovie";
                    }
                case 58:
                    if (Autor == false)
                    {
                        return "Ak Boh stvoril tento svet, urobil by dobre, keby svojej dielo poopravil.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 59:
                    if (Autor == false)
                    {
                        return "Ak ma miluješ menej, znamená to, že si ma nemilovala nikdy.";
                    }
                    else
                    {
                        return "Napoleon";
                    }
                case 60:
                    if (Autor == false)
                    {
                        return "Ešte som nestretol vtipálka, ktorý by nebol hlupák.";
                    }
                    else
                    {
                        return "Jonathan Swift";
                    }
                case 61:
                    if (Autor == false)
                    {
                        return "Inak vonia seno koňom a inak zamilovaným.";
                    }
                    else
                    {
                        return "Stanislav Jerzy Lec";
                    }
                case 62:
                    if (Autor == false)
                    {
                        return "Mladík sa stáva mužom, keď obíde kaluž, namiesto toho, aby do nej stúpil.";
                    }
                    else
                    {
                        return "Platón";
                    }
                case 63:
                    if (Autor == false)
                    {
                        return "Istého priateľa poznáme v neistej situácii.";
                    }
                    else
                    {
                        return "Latinské príslovie";
                    }
                case 64:
                    if (Autor == false)
                    {
                        return "Som bezvýhradný ateista, len sa bojím, že ma pánboh potrestá.";
                    }
                    else
                    {
                        return "Jára Cimrman";
                    }
                case 65:
                    if (Autor == false)
                    {
                        return "Som človek - nič ľudského, myslím, mi nie je cudzie.";
                    }
                    else
                    {
                        return "Menandros";
                    }
                case 66:
                    if (Autor == false)
                    {
                        return "Daj pozor, aby jazyk nepredbehol myšlienku.";
                    }
                    else
                    {
                        return "Chelión";
                    }
                case 67:
                    if (Autor == false)
                    {
                        return "Deje tohto sveta sú výsledkom troch faktorov: prirodzenosti, ľudskej vôle a náhody.";
                    }
                    else
                    {
                        return "Avicenna";
                    }
                case 68:
                    if (Autor == false)
                    {
                        return "Dejiny nás učia, ako ich falšovať.";
                    }
                    else
                    {
                        return "Stanislav Jerzy Lec";
                    }
                case 69:
                    if (Autor == false)
                    {
                        return "Dajte božské Bohu a kráľovské cisárovi - ale to platí o dávaní, nie o braní.";
                    }
                    else
                    {
                        return "Heinrich Heine";
                    }
                case 70:
                    if (Autor == false)
                    {
                        return "Dajte dobrý nápoj príchodziemu, dajte vína tomu, kto má zlú náladu, aby sa napil a na svoj zármutok zabudol.";
                    }
                    else
                    {
                        return "Šalamún";
                    }
                case 71:
                    if (Autor == false)
                    {
                        return "Dajte si čo najviac práce, aby ste naozaj žili.";
                    }
                    else
                    {
                        return "William Saroyan";
                    }
                case 72:
                    if (Autor == false)
                    {
                        return "Ďakujem bohu za to, že ma neurobil schopným experimentátorom. Moje najväčšie objavy mi našepkali nevydarené pokusy.";
                    }
                    else
                    {
                        return "Davy";
                    }
                case 73:
                    if (Autor == false)
                    {
                        return "Ak robia dvaja to isté, nie je to to isté.";
                    }
                    else
                    {
                        return "Terentius";
                    }
                case 74:
                    if (Autor == false)
                    {
                        return "Ak si robíš nových priateľov, nezabúdaj na starých.";
                    }
                    else
                    {
                        return "Erasmus Rotterdamský";
                    }
                case 75:
                    if (Autor == false)
                    {
                        return "Robiť ľahko to, čo je obtiažne pre druhých, je talent. Robiť to, čo je nemožné talentovanému, je dielo génia.";
                    }
                    else
                    {
                        return "H. F. Amiel";
                    }
                case 76:
                    if (Autor == false)
                    {
                        return "Robme všetko preto, aby umenie žiť patrilo ku krásnym umeniam.";
                    }
                    else
                    {
                        return "Kumor";
                    }
                case 77:
                    if (Autor == false)
                    {
                        return "Demokracia je vláda tyranov korigovaná novinármi.";
                    }
                    else
                    {
                        return "Ralph Waldo Emerson";
                    }
                case 78:
                    if (Autor == false)
                    {
                        return "Desím sa davu, je najukrutnejší zo všetkých prírodných živlov.";
                    }
                    else
                    {
                        return "Karel Čapek";
                    }
                case 79:
                    if (Autor == false)
                    {
                        return "Deti je potrebné vychovávať k láske k ľuďom a nie k sebe. A preto samotní rodičia musia mať radi ľudí.";
                    }
                    else
                    {
                        return "Dzeržinskij";
                    }
                case 80:
                    if (Autor == false)
                    {
                        return "Deti sú gombíková dierka rodičovskej svornosti.";
                    }
                    else
                    {
                        return "Arabské príslovie";
                    }
                case 81:
                    if (Autor == false)
                    {
                        return "Deťom stačí len žiť, dospelí musia zápasiť.";
                    }
                    else
                    {
                        return "Lev Nikolajevič Tolstoj";
                    }
                case 82:
                    if (Autor == false)
                    {
                        return "Deti hovoria, čo robia. Starci čo urobili. Blázni, čo by robiť mali. Statoční, čo by chceli spraviť. Rozumní, čo sa sluší urobiť.";
                    }
                    else
                    {
                        return "Chorvátske príslovie";
                    }
                case 83:
                    if (Autor == false)
                    {
                        return "Deti začínajú tým, že svojich rodičov milujú, neskôr ich súdia a zriedka, ak vôbec niekedy, im odpúšťajú.";
                    }
                    else
                    {
                        return "Oscar Wilde";
                    }
                case 84:
                    if (Autor == false)
                    {
                        return "Dievčatá, keď si nemôžu v kúte poplakať, ako keby pomaly ani nežili.";
                    }
                    else
                    {
                        return "Mahen";
                    }
                case 85:
                    if (Autor == false)
                    {
                        return "Deväť desatín múdrosti je - byť múdry včas!";
                    }
                    else
                    {
                        return "Cicero";
                    }
                case 86:
                    if (Autor == false)
                    {
                        return "Dilema nespokojnosti: 1. Muži boli šťastní, keď tam prenikli a dosiahli vrchol. 2. Dnes na to potrebujú, aby si ty dosiahla súčasne niekoľko vrcholov.";
                    }
                    else
                    {
                        return "Lansky";
                    }
                case 87:
                    if (Autor == false)
                    {
                        return "Dilema z kuchyne: Nie je ľahké byť hlavnou kuchárkou a umývačkou riadu a napriek tomu ostať sexi.";
                    }
                    else
                    {
                        return "Lansky";
                    }
                case 88:
                    if (Autor == false)
                    {
                        return "Dielo tlačené iba veľkými písmenami sa ťažko číta. Práve tak ako život zo samých nedelí.";
                    }
                    else
                    {
                        return "Jean Paul";
                    }
                case 89:
                    if (Autor == false)
                    {
                        return "Dielo, ktoré človek vytvára, nie je nič iné ako forma denníka.";
                    }
                    else
                    {
                        return "Pablo Picasso";
                    }
                case 90:
                    if (Autor == false)
                    {
                        return "Dieťa sa sťažuje, že bolo zbité, ale nehovorí prečo.";
                    }
                    else
                    {
                        return "Latinské príslovie";
                    }
                case 91:
                    if (Autor == false)
                    {
                        return "Diváci vidia lepšie ako herci.";
                    }
                    else
                    {
                        return "Anglické príslovie";
                    }
                case 92:
                    if (Autor == false)
                    {
                        return "Divadlo je pozoruhodná vec. Režisér nechápe, čo chce autor, herci nerozumejú, čo od nich chce režisér, a diváci nevedia, čo sa robí na javisku.";
                    }
                    else
                    {
                        return "Strindberg";
                    }
                case 93:
                    if (Autor == false)
                    {
                        return "Ak sa pozerá sa niektorá žena často do zrkadla, nemusí to byť márnivosť, ale statočnosť.";
                    }
                    else
                    {
                        return "Mark Twain";
                    }
                case 94:
                    if (Autor == false)
                    {
                        return "Dlhý styk so zlom rovnako ako s dobrom vedie k tomu, že v ňom človek nájde zaľúbenie.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 95:
                    if (Autor == false)
                    {
                        return "Dlh nie je druh.";
                    }
                    else
                    {
                        return "České príslovie";
                    }
                case 96:
                    if (Autor == false)
                    {
                        return "Dnes sme takí vzdelaní, že nás neprekvapí nič, teda okrem šťastného manželstva.";
                    }
                    else
                    {
                        return "Oscar Wilde";
                    }
                case 97:
                    if (Autor == false)
                    {
                        return "Dnes tlsto a zajtra pusto.";
                    }
                    else
                    {
                        return "České príslovie";
                    }
                case 98:
                    if (Autor == false)
                    {
                        return "Dneska už považujeme za gentlemana muža, ktorý si vyberie cigaretu z úst, keď pobozká ženu.";
                    }
                    else
                    {
                        return "Barbara Streisandová";
                    }
                case 99:
                    if (Autor == false)
                    {
                        return "Dnešní ľudia by chceli žiť zajtrajší život za včerajšie ceny.";
                    }
                    else
                    {
                        return "T. Williams";
                    }
                case 100:
                    if (Autor == false)
                    {
                        return "Dnešná mládež je hrozná. Ale najhoršie je, že už k nej nepatríme.";
                    }
                    else
                    {
                        return "Pablo Picasso";
                    }
                case 101:
                    if (Autor == false)
                    {
                        return "Do každého životného obdobia vstupujeme prvýkrát, preto nám tak často - nezávisle na množstva prežitých rokov - chýbajú skúsenosti.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 102:
                    if (Autor == false)
                    {
                        return "Do manželstva sa musí skočiť ako sa skáče do vody.";
                    }
                    else
                    {
                        return "André Maurois";
                    }
                case 103:
                    if (Autor == false)
                    {
                        return "Do zatvorených úst nevletí mucha.";
                    }
                    else
                    {
                        return "Francúzske príslovie";
                    }
                case 104:
                    if (Autor == false)
                    {
                        return "Do žien a do melónov neuvidíš.";
                    }
                    else
                    {
                        return "Talianske príslovie";
                    }
                case 105:
                    if (Autor == false)
                    {
                        return "Dobrá povesť je ako druhý majetok.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 106:
                    if (Autor == false)
                    {
                        return "Dobrá povesť je lepšia ako peniaze.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 107:
                    if (Autor == false)
                    {
                        return "Dobrá povesť niektorých žien závisí najviac od ich priateliek.";
                    }
                    else
                    {
                        return "Hardu";
                    }
                case 108:
                    if (Autor == false)
                    {
                        return "Dobrá rada je mincou najpoužívanejšou.";
                    }
                    else
                    {
                        return "A. Bierce";
                    }
                case 109:
                    if (Autor == false)
                    {
                        return "Dobrá stránka nepriateľstva je v tom, že na svojich nepriateľov sa človek vždy môže spoľahnúť";
                    }
                    else
                    {
                        return "Wilson";
                    }
                case 110:
                    if (Autor == false)
                    {
                        return "Dobrá žena muža inšpiruje, vtipná ho zaujme, krásna ho okúzli, ale súcitná ho dostane.";
                    }
                    else
                    {
                        return "Victor Hugo";
                    }
                case 111:
                    if (Autor == false)
                    {
                        return "Dobré deti sa vychovávajú sami.";
                    }
                    else
                    {
                        return "Nórske príslovie";
                    }
                case 112:
                    if (Autor == false)
                    {
                        return "Dobré divadlo začína dobrým vrátnikom.";
                    }
                    else
                    {
                        return "Jan Werich";
                    }
                case 113:
                    if (Autor == false)
                    {
                        return "Dobré dôvody musia ustúpiť lepším.";
                    }
                    else
                    {
                        return "William Shakespeare";
                    }
                case 114:
                    if (Autor == false)
                    {
                        return "Dobré je i v pekle mať priateľa.";
                    }
                    else
                    {
                        return "John";
                    }
                case 115:
                    if (Autor == false)
                    {
                        return "Dobré mravy vznikajú z drobných obetí.";
                    }
                    else
                    {
                        return "Ralph Waldo Emerson";
                    }
                case 116:
                    if (Autor == false)
                    {
                        return "Dobré slovo je tiež čin.";
                    }
                    else
                    {
                        return "Ivan Sergejevič Turgenev";
                    }
                case 117:
                    if (Autor == false)
                    {
                        return "Dobré vlastnosti nepotlačia nikdy zlé, asi tak ako cukor pridaný do jedu, nezabráni jedu, aby bol smrtiaci.";
                    }
                    else
                    {
                        return "Arabské príslovie";
                    }
                case 118:
                    if (Autor == false)
                    {
                        return "Dobrá výchova spočíva v tom, že skrývame, ako veľa si myslíme o sebe a ako málo o druhých.";
                    }
                    else
                    {
                        return "Jean Cocteau";
                    }
                case 119:
                    if (Autor == false)
                    {
                        return "Dobre hovoriť môže len ten, kto veci dôkladne rozumie.";
                    }
                    else
                    {
                        return "Cicero";
                    }
                case 120:
                    if (Autor == false)
                    {
                        return "Dobre potrestať môže len ten, kto má rád.";
                    }
                    else
                    {
                        return "Zdeněk Matejček";
                    }
                case 121:
                    if (Autor == false)
                    {
                        return "Dobre sa obesiť - to vylúči možnosť zle sa oženiť.";
                    }
                    else
                    {
                        return "William Shakespeare";
                    }
                case 122:
                    if (Autor == false)
                    {
                        return "Dobro má za hrob ľudský nevďak.";
                    }
                    else
                    {
                        return "Musset";
                    }
                case 123:
                    if (Autor == false)
                    {
                        return "Dobrodením lásky nie je len to, že nám dáva vieru v druhého, ale to, že nám vracia vieru v seba.";
                    }
                    else
                    {
                        return "Romain Rolland";
                    }
                case 124:
                    if (Autor == false)
                    {
                        return "Dobrý los nie je spojencom nečinných.";
                    }
                    else
                    {
                        return "Sofokles";
                    }
                case 125:
                    if (Autor == false)
                    {
                        return "Dobrý pastier má ovce ostrihať, nie ich sťahovať z kože.";
                    }
                    else
                    {
                        return "Tiberius";
                    }
                case 126:
                    if (Autor == false)
                    {
                        return "Dobrý protivník je najlepším spojencom.";
                    }
                    else
                    {
                        return "Latinské príslovie";
                    }
                case 127:
                    if (Autor == false)
                    {
                        return "Dobrý smiech je skutočne niečo zázračné.";
                    }
                    else
                    {
                        return "Lagerlöfová";
                    }
                case 128:
                    if (Autor == false)
                    {
                        return "Dobrý vtip vydá za kus chleba a veselá myseľ nahradí pohár vína.";
                    }
                    else
                    {
                        return "Keller";
                    }
                case 129:
                    if (Autor == false)
                    {
                        return "Dobrý začiatok vedie ku dobrému koncu.";
                    }
                    else
                    {
                        return "Walther";
                    }
                case 130:
                    if (Autor == false)
                    {
                        return "Dobre vykonané je vždy lepšie ako dobre povedané.";
                    }
                    else
                    {
                        return "Benjamin Franklin";
                    }
                case 131:
                    if (Autor == false)
                    {
                        return "Dobre využitý čas ho robí ešte drahocennejším.";
                    }
                    else
                    {
                        return "Jean Jacques Rousseau";
                    }
                case 132:
                    if (Autor == false)
                    {
                        return "Dobrí ľudia dlho neživia svoj hnev.";
                    }
                    else
                    {
                        return "Publius Syrus";
                    }
                case 133:
                    if (Autor == false)
                    {
                        return "Dobu neobviňuj, keď si ty príčinou žiaľu.";
                    }
                    else
                    {
                        return "Cato";
                    }
                case 134:
                    if (Autor == false)
                    {
                        return "Dočasné odlúčenie je dobré... i veže sa zdajú zblízka prikrčené, naopak malé a všedné veci narastajú, ak ich pozorujeme bez odstupu.";
                    }
                    else
                    {
                        return "Karl Marx";
                    }
                case 135:
                    if (Autor == false)
                    {
                        return "Dočítate sa, že máte odpúšťať svojim nepriateľom, ale nikde sa nedočítate, že máte odpúšťať svojim priateľom.";
                    }
                    else
                    {
                        return "Medici";
                    }
                case 136:
                    if (Autor == false)
                    {
                        return "Dokonalosť je norma nebies, iba túžba po dokonalosti je norma človeka.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 137:
                    if (Autor == false)
                    {
                        return "Dokonalosť sa dosahuje maličkosťami, ale dokonalosť nie je maličkosť.";
                    }
                    else
                    {
                        return "Michelangelo Buonarotti";
                    }
                case 138:
                    if (Autor == false)
                    {
                        return "Kým dýcham, dúfam. Kým žiješ, sluší sa dúfať.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 139:
                    if (Autor == false)
                    {
                        return "Kým žijeme, žime.";
                    }
                    else
                    {
                        return "Vergilius";
                    }
                case 140:
                    if (Autor == false)
                    {
                        return "Kým sú mladí, chcú z nás mať hračky, keď zostarnú, máme byť ich slúžkami.";
                    }
                    else
                    {
                        return "Karolína Svetlá";
                    }
                case 141:
                    if (Autor == false)
                    {
                        return "Kým sú ženy krásne, ľudstvo nevyhynie.";
                    }
                    else
                    {
                        return "Leon Battista Alberti";
                    }
                case 142:
                    if (Autor == false)
                    {
                        return "Kým muž ženu miluje, hovorí s ňou hlavne o nej; ak ju prestane milovať, hovorí s ňou o sebe.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 143:
                    if (Autor == false)
                    {
                        return "Kým nevyhrávam, samozrejme hovorím, že sú karty zle zamiešané.";
                    }
                    else
                    {
                        return "Jonathan Swift";
                    }
                case 144:
                    if (Autor == false)
                    {
                        return "Kým ti šťastie bude priať, budeš priateľov mať veľa, smutný keď príde ti čas, ostaneš úplne sám.";
                    }
                    else
                    {
                        return "Ovidius";
                    }
                case 145:
                    if (Autor == false)
                    {
                        return "Domnienka ženy býva presnejšia ako istota muža.";
                    }
                    else
                    {
                        return "Rudyard Kipling";
                    }
                case 146:
                    if (Autor == false)
                    {
                        return "Ak sa domnievame, že toho druhého máme radi len z lásky k nemu, veľmi sa klameme.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 147:
                    if (Autor == false)
                    {
                        return "Dve nuly znamenajú toaletu. Často sú to ale i dvaja hajzli.";
                    }
                    else
                    {
                        return "Laub";
                    }
                case 148:
                    if (Autor == false)
                    {
                        return "Hosť a ryba na tretí deň smrdia.";
                    }
                    else
                    {
                        return "České príslovie";
                    }
                case 149:
                    if (Autor == false)
                    {
                        return "Hovor len o tom, čo je ti jasné.";
                    }
                    else
                    {
                        return "Lev Nikolajevič Tolstoj";
                    }
                case 150:
                    if (Autor == false)
                    {
                        return "Klinec vie, do čoho kladivo bije.";
                    }
                    else
                    {
                        return "Mongolské príslovie";
                    }
                case 151:
                    if (Autor == false)
                    {
                        return "Humor je ochranný štít múdrych.";
                    }
                    else
                    {
                        return "Kästner";
                    }
                case 152:
                    if (Autor == false)
                    {
                        return "Humor je vážna vec.";
                    }
                    else
                    {
                        return "Miroslav Horníček";
                    }
                case 153:
                    if (Autor == false)
                    {
                        return "Chcem slúžiť, nie obsluhovať.";
                    }
                    else
                    {
                        return "František Xaver Šalda";
                    }
                case 154:
                    if (Autor == false)
                    {
                        return "Chudoba sa ľahko vyhne škode.";
                    }
                    else
                    {
                        return "Sallustius";
                    }
                case 155:
                    if (Autor == false)
                    {
                        return "Chybami sa učíme.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 156:
                    if (Autor == false)
                    {
                        return "Chybou je, keď veríš každému, ale chybou je i to, keď neveríš nikomu.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 157:
                    if (Autor == false)
                    {
                        return "Chybovať je ľudské.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 158:
                    if (Autor == false)
                    {
                        return "Chyby každého človeka ukazujú, kam patrí.";
                    }
                    else
                    {
                        return "Konfucius";
                    }
                case 159:
                    if (Autor == false)
                    {
                        return "Aj keď si sám, nerob nič zlé.";
                    }
                    else
                    {
                        return "Demokritos";
                    }
                case 160:
                    if (Autor == false)
                    {
                        return "Aj lev sa musí brániť proti muchám.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 161:
                    if (Autor == false)
                    {
                        return "Aj myslenie občas škodí zdraviu.";
                    }
                    else
                    {
                        return "Aristoteles";
                    }
                case 162:
                    if (Autor == false)
                    {
                        return "Aj srdce má rozum.";
                    }
                    else
                    {
                        return "Blaisa Pascal";
                    }
                case 163:
                    if (Autor == false)
                    {
                        return "Je dobré učiť sa aj od nepriateľa.";
                    }
                    else
                    {
                        return "Publius Ovidius Naso";
                    }
                case 164:
                    if (Autor == false)
                    {
                        return "Je lepšie byť nenávidený ako ľutovaný.";
                    }
                    else
                    {
                        return "Herodes";
                    }
                case 165:
                    if (Autor == false)
                    {
                        return "Je niekedy múdre robiť hlúposti.";
                    }
                    else
                    {
                        return "Berlioz";
                    }
                case 166:
                    if (Autor == false)
                    {
                        return "Myslieť si, že prenikáme do duševných pochodov druhého človeka je nezmysel.";
                    }
                    else
                    {
                        return "Robbe-Grillet";
                    }
                case 167:
                    if (Autor == false)
                    {
                        return "Domov nie je miesto, kde bývaš, ale miesto, kde ti rozumejú.";
                    }
                    else
                    {
                        return "Christian Morgenstern";
                    }
                case 168:
                    if (Autor == false)
                    {
                        return "Don Juan je muž, ktorý ženám pomáha pri páde.";
                    }
                    else
                    {
                        return "Piterka";
                    }
                case 169:
                    if (Autor == false)
                    {
                        return "Dosť času je dva roky pred smrťou sa oženiť.";
                    }
                    else
                    {
                        return "Slovenské príslovie";
                    }
                case 170:
                    if (Autor == false)
                    {
                        return "Prišiel som k záveru, že politika je príliš vážna vec, aby mohla byť prenechaná len politikom.";
                    }
                    else
                    {
                        return "Charles de Gaulle";
                    }
                case 171:
                    if (Autor == false)
                    {
                        return "Dúfam, že budem študentom do konca života.";
                    }
                    else
                    {
                        return "Anton Pavlovič Čechov";
                    }
                case 172:
                    if (Autor == false)
                    {
                        return "Dúfať, že zanecháme nejakú spomienku v srdci ženy, je rovnaké, ako chcieť vtlačiť pečať na hladinu tečúcej vody.";
                    }
                    else
                    {
                        return "France";
                    }
                case 173:
                    if (Autor == false)
                    {
                        return "Viem napísať čokoľvek. Keby som to nevedel, bol by zo mňa pravdepodobne hlupák.";
                    }
                    else
                    {
                        return "George Bernard Shaw";
                    }
                case 174:
                    if (Autor == false)
                    {
                        return "Dovoľte ľuďom, aby boli šťastní podľa ich vlastnej vôle.";
                    }
                    else
                    {
                        return "Prus";
                    }
                case 175:
                    if (Autor == false)
                    {
                        return "Dovoľte, aby som povedal, že nie žena je najkrajším výtvorom stvorenia: je ním starnúci muž alebo starec, ak sa vydarí.";
                    }
                    else
                    {
                        return "Eisner";
                    }
                case 176:
                    if (Autor == false)
                    {
                        return "Drahý je mi priateľ; ale i nepriateľ mi môže poslúžiť: ak mi ukazuje priateľ čo môžem, učí ma nepriateľ, čo musím.";
                    }
                    else
                    {
                        return "Friedrich Schiller";
                    }
                case 177:
                    if (Autor == false)
                    {
                        return "Klebety sú útechou žien, ktoré už nikto nemiluje a nikto sa im nedvorí.";
                    }
                    else
                    {
                        return "Guy de Maupassant";
                    }
                case 178:
                    if (Autor == false)
                    {
                        return "Drobné strasti stačia na to, aby nám otrávili život, v prípade že nemáme žiadne veľké.";
                    }
                    else
                    {
                        return "Jonathan Swift";
                    }
                case 179:
                    if (Autor == false)
                    {
                        return "Drviť nepriateľov, vidieť ich padať pred nami na tvár, brať im kone... počuť bedákanie ich žien. To je to najlepšie na svete.";
                    }
                    else
                    {
                        return "Džingischán";
                    }
                case 180:
                    if (Autor == false)
                    {
                        return "Druhá najväčšia slasť po láske je: hovoriť o nej.";
                    }
                    else
                    {
                        return "Labé";
                    }
                case 181:
                    if (Autor == false)
                    {
                        return "Druhý deň je žiakom prvého.";
                    }
                    else
                    {
                        return "Publius Syrus";
                    }
                case 182:
                    if (Autor == false)
                    {
                        return "Drž sa novej cesty a starého priateľa.";
                    }
                    else
                    {
                        return "Slovenské príslovie";
                    }
                case 183:
                    if (Autor == false)
                    {
                        return "Niekedy som nechápal, prečo som nedostal odpoveď na svoju otázku, dnes nechápem, ako som mohol veriť, že sa môžem pýtať.";
                    }
                    else
                    {
                        return "Franz Kafka";
                    }
                case 184:
                    if (Autor == false)
                    {
                        return "Skôr rozbiješ atóm ako klebetu.";
                    }
                    else
                    {
                        return "Albert Einstein";
                    }
                case 185:
                    if (Autor == false)
                    {
                        return "Kedysi sa mladé dievčatá červenali, keď sa hanbili, a teraz sa hanbia, keď sa červenajú.";
                    }
                    else
                    {
                        return "Krejčí";
                    }
                case 186:
                    if (Autor == false)
                    {
                        return "Najprv pozeraj, s kým by si jedol a pil, než to, čo by si jedol a pil. Pretože život bez priateľa je ako kŕmenie leva a vlka.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 187:
                    if (Autor == false)
                    {
                        return "Skôr ako sa zajtrajšok stane včerajškom, ľudia často prehliadnu šance, ktoré im ponúka dnešok.";
                    }
                    else
                    {
                        return "Čínske príslovie";
                    }
                case 188:
                    if (Autor == false)
                    {
                        return "Niekedy študovali muži sami kvôli sebe; dnes študujú, aby spravili dojem na ľudí.";
                    }
                    else
                    {
                        return "Konfucius";
                    }
                case 189:
                    if (Autor == false)
                    {
                        return "Duchaplní ľudia by boli často osamelí bez hlupákov, ktorí sú na nich pyšní.";
                    }
                    else
                    {
                        return "Luc de Vauvenargues";
                    }
                case 190:
                    if (Autor == false)
                    {
                        return "Dôkladne zmúdriem, ale už nebudem vedieť v tom chodiť .";
                    }
                    else
                    {
                        return "Cézanne";
                    }
                case 191:
                    if (Autor == false)
                    {
                        return "Dôležité je nikdy sa nezastaviť.";
                    }
                    else
                    {
                        return "Iacocca";
                    }
                case 192:
                    if (Autor == false)
                    {
                        return "Dôležitou súčasťou odvahy je opatrnosť.";
                    }
                    else
                    {
                        return "William Shakespeare";
                    }
                case 193:
                    if (Autor == false)
                    {
                        return "Duša pomáha telu... je to jediný vták, ktorý podopiera klietku.";
                    }
                    else
                    {
                        return "Victor Hugo";
                    }
                case 194:
                    if (Autor == false)
                    {
                        return "Duševne sebestační sú si jedine géniovia a hlupáci.";
                    }
                    else
                    {
                        return "Stanislav Jerzy Lec";
                    }
                case 195:
                    if (Autor == false)
                    {
                        return "Duševné utrpenie sa znáša ľahšie ako telesné; keby mi bolo ponúknuté zlé svedomie alebo boľavý zub, zvolil by som si prvé.";
                    }
                    else
                    {
                        return "Heinrich Heine";
                    }
                case 196:
                    if (Autor == false)
                    {
                        return "Dušou vtipu je stručnosť.";
                    }
                    else
                    {
                        return "William Shakespeare";
                    }
                case 197:
                    if (Autor == false)
                    {
                        return "Dôvera dáva rozhovoru viac ako inteligencia.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 198:
                    if (Autor == false)
                    {
                        return "Dôverovať každému je rovnako pochybné ako nedôverovať nikomu.";
                    }
                    else
                    {
                        return "Anglické príslovie";
                    }
                case 199:
                    if (Autor == false)
                    {
                        return "Dôveruj, ale rozmysli si komu (dôverovať).";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 200:
                    if (Autor == false)
                    {
                        return "Dôvody, prečo sa niektoré krásne ženy nemôžu vydať, môžu byť dva: Buď veľmi často hovorili nie, alebo príliš často áno.";
                    }
                    else
                    {
                        return "George Bernard Shaw";
                    }
                case 201:
                    if (Autor == false)
                    {
                        return "Sú dva druhy geniálnych spisovateľov: tí, čo myslia, a tí, čo nútia premýšľať ostatných.";
                    }
                    else
                    {
                        return "Roux";
                    }
                case 202:
                    if (Autor == false)
                    {
                        return "Dvaja ľudia sú vždy dva extrémy.";
                    }
                    else
                    {
                        return "Friedrich Christian Hebbel";
                    }
                case 203:
                    if (Autor == false)
                    {
                        return "Dva milostné listy čítame ťažko - prvý a posledný.";
                    }
                    else
                    {
                        return "Francesco Petrarca";
                    }
                case 204:
                    if (Autor == false)
                    {
                        return "Dvadsať rokov sme žili ja a moja žena veľmi šťastne, a potom sme sa zoznámili.";
                    }
                    else
                    {
                        return "Paráček";
                    }
                case 205:
                    if (Autor == false)
                    {
                        return "Dvakrát dáva, kto rýchlo dáva.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 206:
                    if (Autor == false)
                    {
                        return "Dve veci sú nekonečné - vesmír a ľudská hlúposť. Ale vo vesmíre to nie je také isté.";
                    }
                    else
                    {
                        return "Albert Einstein";
                    }
                case 207:
                    if (Autor == false)
                    {
                        return "Dve veci ma napĺňajú úžasom - hviezdne nebo nado mnou a mravný zákon vo mne.";
                    }
                    else
                    {
                        return "Immanuel Kant";
                    }
                case 208:
                    if (Autor == false)
                    {
                        return "Dve ženy pod jednou strechou - dva tigre v jednej klietke. Kameň múdrosti leží v orlom hniezde.";
                    }
                    else
                    {
                        return "Indické príslovie";
                    }
                case 209:
                    if (Autor == false)
                    {
                        return "Dychtivosť po vláde a moci je silnejšia ako ostatné vášne.";
                    }
                    else
                    {
                        return "Tacitus";
                    }
                case 210:
                    if (Autor == false)
                    {
                        return "Fajka je kus páchnuceho dreva; na jednom konci je oheň a na druhom blázon.";
                    }
                    else
                    {
                        return "Abraham Lincoln";
                    }
                case 211:
                    if (Autor == false)
                    {
                        return "Egoista je ten, kto dbá viac o seba ako o mňa.";
                    }
                    else
                    {
                        return "Julian Tuwim";
                    }
                case 212:
                    if (Autor == false)
                    {
                        return "Egoisti sú tí z našich priateľov, ktorým je naše priateľstvo ľahostajné.";
                    }
                    else
                    {
                        return "Montherlant";
                    }
                case 213:
                    if (Autor == false)
                    {
                        return "Erotika sa má k sexualite tak ako zisk ku strate.";
                    }
                    else
                    {
                        return "Kraus";
                    }
                case 214:
                    if (Autor == false)
                    {
                        return "Existencia je dobrodružstvom svojej vlastnej nemožnosti.";
                    }
                    else
                    {
                        return "Heidegger";
                    }
                case 215:
                    if (Autor == false)
                    {
                        return "Existuje jeden princíp dobra, ktorý stvoril poriadok, svetlo a muža, a jeden princíp zlý, ktorý stvoril chaos, temno a ženu.";
                    }
                    else
                    {
                        return "Pythagoras";
                    }
                case 216:
                    if (Autor == false)
                    {
                        return "Existuje len jedno dobro a tým je vedomosť, existuje len jedno zlo a tým je nevedomosť.";
                    }
                    else
                    {
                        return "Sokrates";
                    }
                case 217:
                    if (Autor == false)
                    {
                        return "Existuje len jediný prípad čistého zúfalstva. A to zúfalstvo človeka odsúdeného na smrť.";
                    }
                    else
                    {
                        return "Albert Camus";
                    }
                case 218:
                    if (Autor == false)
                    {
                        return "Existuje sila, ktorú nepremôže žiadna ľudská vynaliezavosť - mám na mysli trápenie, ktoré nám pripravuje ľudská hlúposť.";
                    }
                    else
                    {
                        return "Disraeli";
                    }
                case 219:
                    if (Autor == false)
                    {
                        return "Existuje šťastie, ale nepoznáme ho; čo o to, poznali by sme ho, ale nevieme si ho vážiť.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 220:
                    if (Autor == false)
                    {
                        return "Existuje zákaz hovoriť, ale nie zákaz myslieť.";
                    }
                    else
                    {
                        return "Nórske príslovie";
                    }
                case 221:
                    if (Autor == false)
                    {
                        return "Existujú ľudia, od ktorých sa umažeš, nech si dávaš akokoľvek pozor.";
                    }
                    else
                    {
                        return "Josef Čapek";
                    }
                case 222:
                    if (Autor == false)
                    {
                        return "Existujú takí márniví muži, že sú hrdí na tých, ktorí im nasadzujú parohy.";
                    }
                    else
                    {
                        return "Rey";
                    }
                case 223:
                    if (Autor == false)
                    {
                        return "Existujú aj tak verné ženy, že majú výčitky svedomia, keď svojho muža podvádzajú.";
                    }
                    else
                    {
                        return "Guy de Maupassant";
                    }
                case 224:
                    if (Autor == false)
                    {
                        return "Existujú tisíce chorôb, ale iba jedno zdravie.";
                    }
                    else
                    {
                        return "Börne";
                    }
                case 225:
                    if (Autor == false)
                    {
                        return "Falošný priateľ je ako mačka - spredu líže, zozadu škrabe.";
                    }
                    else
                    {
                        return "Slovinské príslovie";
                    }
                case 226:
                    if (Autor == false)
                    {
                        return "Fantázia je to, čím sa človek líši od zvierat.";
                    }
                    else
                    {
                        return "Jakub Arbes";
                    }
                case 227:
                    if (Autor == false)
                    {
                        return "Flirt bez hlbšieho úmyslu je ako cestovný poriadok, vydaný pre neexistujúcu železnicu.";
                    }
                    else
                    {
                        return "Marcelo Mastroianni";
                    }
                case 228:
                    if (Autor == false)
                    {
                        return "Forma? Forma je skutočne forma: človek môže odliať zlatú misu a môže potom do nej dať vychladnúť huspeninu. Vo forme to nie je.";
                    }
                    else
                    {
                        return "Šukšin";
                    }
                case 229:
                    if (Autor == false)
                    {
                        return "Francúzi o svojich ženách skoro nikdy nehovoria. Boja sa, aby o nich nehovorili pred ľuďmi, ktorí ich poznajú lepšie ako oni sami.";
                    }
                    else
                    {
                        return "Montesquieu";
                    }
                case 230:
                    if (Autor == false)
                    {
                        return "Gardedáma je žena, ktorá bráni dievčaťu, ktoré sprevádza, robiť veci, ktoré nemohla za mlada robiť sama, pretože ju sprevádzala gardedáma.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 231:
                    if (Autor == false)
                    {
                        return "Genialitu ktosi definoval ako schopnosť urobiť z mála veľa - táto charakteristika sa hodí i na lásku.";
                    }
                    else
                    {
                        return "André Maurois";
                    }
                case 232:
                    if (Autor == false)
                    {
                        return "Génius - to je jediné percento inšpirácie a deväťdesiat deväť percent potu.";
                    }
                    else
                    {
                        return "Thomas Alva Edison";
                    }
                case 233:
                    if (Autor == false)
                    {
                        return "Genialita nie je nič iné ako veľká schopnosť trpezlivosti.";
                    }
                    else
                    {
                        return "Buffon";
                    }
                case 234:
                    if (Autor == false)
                    {
                        return "Génius rýchlejšie dospieva k základnému princípu ako ku jednotlivým pojmom.";
                    }
                    else
                    {
                        return "Immanuel Kant";
                    }
                case 235:
                    if (Autor == false)
                    {
                        return "Gentleman je človek, ktorý nikdy neraní city druhého neúmyselne.";
                    }
                    else
                    {
                        return "Oscar Wilde";
                    }
                case 236:
                    if (Autor == false)
                    {
                        return "Geometricky vzaté, je láska pohyb vertikálnym smerom v horizontálnej polohe.";
                    }
                    else
                    {
                        return "Bolognessi";
                    }
                case 237:
                    if (Autor == false)
                    {
                        return "Hádka je soľou lásky - ale nech vám neujde ruka.";
                    }
                    else
                    {
                        return "Gruzínske príslovie";
                    }
                case 238:
                    if (Autor == false)
                    {
                        return "Hanbou je urážať, nie sa ospravedlňovať sa.";
                    }
                    else
                    {
                        return "Jean De La Bruyére";
                    }
                case 239:
                    if (Autor == false)
                    {
                        return "Herecké umenie spočíva v schopnosti zabrániť ľuďom v kašli.";
                    }
                    else
                    {
                        return "C. Richardson";
                    }
                case 240:
                    if (Autor == false)
                    {
                        return "História je skôr plná príkladov vernosti psov ako priateľov.";
                    }
                    else
                    {
                        return "Alexander Pope";
                    }
                case 241:
                    if (Autor == false)
                    {
                        return "História je ťažký sen, z ktorého sa snažíme prebrať.";
                    }
                    else
                    {
                        return "James Joyce";
                    }
                case 242:
                    if (Autor == false)
                    {
                        return "História je záznamom ľudského pokroku, záznamom boja pokroku ľudského myslenia, ľudského ducha smerom k známemu či neznámemu cieľu. (Str. 38).";
                    }
                    else
                    {
                        return "Néhrú";
                    }
                case 243:
                    if (Autor == false)
                    {
                        return "História sveta je súhrn udalostí, ktorým sa bolo možné vyhnúť.";
                    }
                    else
                    {
                        return "Bertrand Russell";
                    }
                case 244:
                    if (Autor == false)
                    {
                        return "História ženy je históriou najhoršej tyranie akú poznal svet: tyranie slabého nad silným.";
                    }
                    else
                    {
                        return "Oscar Wilde";
                    }
                case 245:
                    if (Autor == false)
                    {
                        return "Hlad je najlepší kuchár.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 246:
                    if (Autor == false)
                    {
                        return "Ak existuje na svete niečo smutnejšie ako opustená žena, tak je to žena, ktorá predstiera, že jej to vyhovuje.";
                    }
                    else
                    {
                        return "Day";
                    }
                case 247:
                    if (Autor == false)
                    {
                        return "Hladný dav sa nevie báť.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 248:
                    if (Autor == false)
                    {
                        return "Hlavný problém života tkvie v tom, že sa človek musí neustále rozhodovať medzi viacerými možnosťami.";
                    }
                    else
                    {
                        return "G. Moore";
                    }
                case 249:
                    if (Autor == false)
                    {
                        return "Hlavnou príčinou nevšímavosti sú vopred prijaté názory.";
                    }
                    else
                    {
                        return "Mill";
                    }
                case 250:
                    if (Autor == false)
                    {
                        return "Hlavnou príčinou rozvodov je manželstvo.";
                    }
                    else
                    {
                        return "Achard";
                    }
                case 251:
                    if (Autor == false)
                    {
                        return "Snaž sa udržať si jasnú hlavu, jasnú hlavu za všetkých okolností, keď má človek rozum, má si ho vážiť a nie ho zahadzovať pre slabosť nervov...";
                    }
                    else
                    {
                        return "Karel Poláček";
                    }
                case 252:
                    if (Autor == false)
                    {
                        return "Hľadám človeka.";
                    }
                    else
                    {
                        return "Diogenes";
                    }
                case 253:
                    if (Autor == false)
                    {
                        return "Hľadať ľudí ktorých by ste milovali... to je tajomstvo a úspech celého života.";
                    }
                    else
                    {
                        return "Sova";
                    }
                case 254:
                    if (Autor == false)
                    {
                        return "Hľadať v žene priateľku je o veľa ťažšie, ako nájsť u nej priateľa.";
                    }
                    else
                    {
                        return "Oldřich Fišer";
                    }
                case 255:
                    if (Autor == false)
                    {
                        return "Hľadaj pravdu v myšlienke a nie v knihách práchnivejúcich. Ak chceš vidieť mesiac, pozeraj sa na oblohu a nie do kaluže.";
                    }
                    else
                    {
                        return "Perzské príslovie";
                    }
                case 256:
                    if (Autor == false)
                    {
                        return "Hlúpa hlava nájde vždy hlavu ešte hlúpejšiu, ktorá ju obdivuje.";
                    }
                    else
                    {
                        return "Boileau";
                    }
                case 257:
                    if (Autor == false)
                    {
                        return "Hlúposť bláznov býva vždy inšpiráciou múdrych.";
                    }
                    else
                    {
                        return "William Shakespeare";
                    }
                case 258:
                    if (Autor == false)
                    {
                        return "Hlúposť by nemala mať v tejto sále miesto a ani inde by nemala byť trpená.";
                    }
                    else
                    {
                        return "Gaius Julius Caesar";
                    }
                case 259:
                    if (Autor == false)
                    {
                        return "Hlúposť býva dvojaká: mlčanlivá a utáraná. Mlčanlivá hlúposť je znesiteľnejšia.";
                    }
                    else
                    {
                        return "Honoré de Balzac";
                    }
                case 260:
                    if (Autor == false)
                    {
                        return "Hlúposť ako chlieb nám k životu potrebná je.";
                    }
                    else
                    {
                        return "Gellner";
                    }
                case 261:
                    if (Autor == false)
                    {
                        return "Hlúposť je niečo neporaziteľné. Všetko, čo na ňu zaútočí, na nej stroskotá.";
                    }
                    else
                    {
                        return "Flaubert";
                    }
                case 262:
                    if (Autor == false)
                    {
                        return "Hlúposť je lenivosť ducha a lenivosť je hlúposť tela.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 263:
                    if (Autor == false)
                    {
                        return "Hlúposť je stručná a bez ľsti, kým rozum sa vykrúca; rozum je podliak; hlúposť je priama a poctivá.";
                    }
                    else
                    {
                        return "Fjodor Michajlovič Dostojevskij";
                    }
                case 264:
                    if (Autor == false)
                    {
                        return "Hlúposti môžu byť pôvabné. Hlúposť nikdy.";
                    }
                    else
                    {
                        return "Alberto Moravia";
                    }
                case 265:
                    if (Autor == false)
                    {
                        return "(Čo je) napísané, ostane na veky.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 266:
                    if (Autor == false)
                    {
                        return "... epochy a storočia sú tie okamihy na javisku, kedy sa vlastné ucho diví, čo vlastná huba hovorí...";
                    }
                    else
                    {
                        return "Jan Werich";
                    }
                case 267:
                    if (Autor == false)
                    {
                        return "... ako náhle začnete humor definovať, rozpitvávať, teoreticky vysvetľovať, už je po srande.";
                    }
                    else
                    {
                        return "Císler";
                    }
                case 268:
                    if (Autor == false)
                    {
                        return "... mladosť biologická neoslobodzuje od blbosti a hlúposti, rovnako ako staroba nezaručuje múdrosť. Sú hlúpi dedkovia a hlúpe deti.";
                    }
                    else
                    {
                        return "Jan Werich";
                    }
                case 269:
                    if (Autor == false)
                    {
                        return "... vie sa niekedy v umení, kto je blázon?";
                    }
                    else
                    {
                        return "Cézanne";
                    }
                case 270:
                    if (Autor == false)
                    {
                        return "... vlastný krb a dobrá žena, v tom väčšia ako v zlate je cena.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 271:
                    if (Autor == false)
                    {
                        return "...deti majú dostať tiež bohatstvo, o ktoré by neprišli, ani keby sa pri stroskotaní zachránili nahé.";
                    }
                    else
                    {
                        return "Fernández de Lizardi";
                    }
                case 272:
                    if (Autor == false)
                    {
                        return "1. sentiment - 2. temperament - 3. moment - 4. lament - 5. aliment.";
                    }
                    else
                    {
                        return "Julian Tuwim";
                    }
                case 273:
                    if (Autor == false)
                    {
                        return "A aj keby bola lichôtka akokoľvek hrubá, predsa sa berie najmenej z polovice vážne.";
                    }
                    else
                    {
                        return "Fjodor Michajlovič Dostojevskij";
                    }
                case 274:
                    if (Autor == false)
                    {
                        return "A ako sa hovorí: len keď je koryto. Svine ho už nájdu.";
                    }
                    else
                    {
                        return "John";
                    }
                case 275:
                    if (Autor == false)
                    {
                        return "A ak si miloval niekedy ženu alebo krajinu, prežil si výnimočné šťastie, a ak potom umrieš, už to nie je dôležité.";
                    }
                    else
                    {
                        return "Ernest Hemingway";
                    }
                case 276:
                    if (Autor == false)
                    {
                        return "A keď potom už sú nemé, keď postrácali pôvab ľsti, môj Bože, tak ich milujeme zo zvláštnej zotrvačnosti.";
                    }
                    else
                    {
                        return "Geraldy";
                    }
                case 277:
                    if (Autor == false)
                    {
                        return "A predsa len je jedno obdobie, v ktorom je muž nesporným pánom v dome: od narodenia asi do tretieho roka.";
                    }
                    else
                    {
                        return "Pegas";
                    }
                case 278:
                    if (Autor == false)
                    {
                        return "A predsa každým dňom je svet o chlp lepší ako včerajšok, aj keď ľudia robia psie kusy, aby tomu tak nebolo.";
                    }
                    else
                    {
                        return "Jan Werich";
                    }
                case 279:
                    if (Autor == false)
                    {
                        return "A smrť je zlo - tak bohovia uznali: veď keby bola krásna, aj tak by umierali...";
                    }
                    else
                    {
                        return "Sapfó";
                    }
                case 280:
                    if (Autor == false)
                    {
                        return "Absurdné je to, čo nemôže byť odvodené.";
                    }
                    else
                    {
                        return "Roquentin";
                    }
                case 281:
                    if (Autor == false)
                    {
                        return "Aby človek dosiahol to, čo je možné, musí sa usilovať o to, čo je nemožné.";
                    }
                    else
                    {
                        return "Fischer";
                    }
                case 282:
                    if (Autor == false)
                    {
                        return "Aby mohla dávať nielen mlieko, ale i med, musí byť nielen dobrou matkou, ale tiež šťastným človekom a to veľa ľudí nedosiahne.";
                    }
                    else
                    {
                        return "Erich Fromm";
                    }
                case 283:
                    if (Autor == false)
                    {
                        return "Aby sa človek zapáčil žene buď veľmi krásnej, alebo veľmi škaredej, musí chváliť jej inteligenciu, aby sa zapáčil ostatným, musí chváliť ich krásu.";
                    }
                    else
                    {
                        return "Phillip Chesterfield";
                    }
                case 284:
                    if (Autor == false)
                    {
                        return "Aby sa dosiahlo veľkého, je potrebné začať s menším.";
                    }
                    else
                    {
                        return "Vladimír Iljič Lenin";
                    }
                case 285:
                    if (Autor == false)
                    {
                        return "Aby sme boli básnikmi, potrebovali by sme veľa času; hodiny a hodiny samoty.";
                    }
                    else
                    {
                        return "Pasolini";
                    }
                case 286:
                    if (Autor == false)
                    {
                        return "Aby sme dokázali veľké veci, musíme žiť, ako keby sme nikdy nemali umrieť.";
                    }
                    else
                    {
                        return "Oldřich Nový";
                    }
                case 287:
                    if (Autor == false)
                    {
                        return "Aby sme počuli chválu o sebe, chválime zvyčajne iných.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 288:
                    if (Autor == false)
                    {
                        return "Aby sme posilnili ducha, je potrebné posilniť svaly.";
                    }
                    else
                    {
                        return "Michel de Montaigne";
                    }
                case 289:
                    if (Autor == false)
                    {
                        return "Aby si bol milovaný, miluj!";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 290:
                    if (Autor == false)
                    {
                        return "Aby si bol zdravý, musíš zniesť veľa bolesti.";
                    }
                    else
                    {
                        return "Publius Ovidius Naso";
                    }
                case 291:
                    if (Autor == false)
                    {
                        return "Adam musí mať Evu, ktorej by ukázal, čo urobil.";
                    }
                    else
                    {
                        return "Nemecké príslovie";
                    }
                case 292:
                    if (Autor == false)
                    {
                        return "Afrodiziakálny efekt: Ľudia vyskúšali veľa afrodiziák. Jediným, ktoré funguje, sú peniaze.";
                    }
                    else
                    {
                        return "Lansky";
                    }
                case 293:
                    if (Autor == false)
                    {
                        return "Ach tie prízemné povahy! Aj tá ich láska sa podobá nenávisti.";
                    }
                    else
                    {
                        return "Fjodor Michajlovič Dostojevskij";
                    }
                case 294:
                    if (Autor == false)
                    {
                        return "Ach, ako je ťažké byť krásny, keď je človek škaredý.";
                    }
                    else
                    {
                        return "Ilf";
                    }
                case 295:
                    if (Autor == false)
                    {
                        return "Ach, milí priatelia, priatelia neexistujú.";
                    }
                    else
                    {
                        return "Aristoteles";
                    }
                case 296:
                    if (Autor == false)
                    {
                        return "Achillovou pätou hlupáka je hlava.";
                    }
                    else
                    {
                        return "Twain";
                    }
                case 297:
                    if (Autor == false)
                    {
                        return "Ale načo je sloboda, ak nie na to, aby si sa angažoval.";
                    }
                    else
                    {
                        return "Sartre";
                    }
                case 298:
                    if (Autor == false)
                    {
                        return "Ale premýšľať, a to dá zabrať, vie iba časť ľudstva. Tá časť, tá tenučká vrstva, ktorá bojuje s ľudskou hlúposťou.";
                    }
                    else
                    {
                        return "Jan Werich";
                    }
                case 299:
                    if (Autor == false)
                    {
                        return "Alimenty sú priama daň zo zábavy. Nezriedka i z cudzej.";
                    }
                    else
                    {
                        return "Oldřich Fišer";
                    }
                case 300:
                    if (Autor == false)
                    {
                        return "Anatómia je niečo, čo má každý, ale na peknom mladom dievčati vyzerá najlepšie.";
                    }
                    else
                    {
                        return "Krokodil";
                    }
                case 301:
                    if (Autor == false)
                    {
                        return "Angličan nikdy nežartuje, ak ide o tak vážnu vec, ako je stávka.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 302:
                    if (Autor == false)
                    {
                        return "Ani ateisti nie sú oslobodení od zbožných prianí.";
                    }
                    else
                    {
                        return "Kumor";
                    }
                case 303:
                    if (Autor == false)
                    {
                        return "Ani ľudia hlúpi nespôsobili na svete toľko zmätkov, koľko ľudia múdri, ktorí si boli príliš vedomí svojej múdrosti a spoliehali sa len na ňu.";
                    }
                    else
                    {
                        return "Otto František Babler";
                    }
                case 304:
                    if (Autor == false)
                    {
                        return "Ani slovníky nesmieme brať doslova.";
                    }
                    else
                    {
                        return "Stanislav Jerzy Lec";
                    }
                case 305:
                    if (Autor == false)
                    {
                        return "Anonym je človek, ktorý má svoju česť. Pod svojim menom by to nenapísal.";
                    }
                    else
                    {
                        return "Karel Čapek";
                    }
                case 306:
                    if (Autor == false)
                    {
                        return "Antikvariátne predmety sú bývalé gýče. Gýče sú budúce antikvariátne predmety.";
                    }
                    else
                    {
                        return "Guiness";
                    }
                case 307:
                    if (Autor == false)
                    {
                        return "Architektúra je to, čo robí zrúcaninu krásnou.";
                    }
                    else
                    {
                        return "Le Corbusier";
                    }
                case 308:
                    if (Autor == false)
                    {
                        return "Armáda baranov, ktorú vedie lev, je silnejšia, ako armáda levov, ktorú vedie baran.";
                    }
                    else
                    {
                        return "Napoleon";
                    }
                case 309:
                    if (Autor == false)
                    {
                        return "Asociácia je most - kam ale vedie a čo unesie?";
                    }
                    else
                    {
                        return "Huxley";
                    }
                case 310:
                    if (Autor == false)
                    {
                        return "Nech robíme čokoľvek, má nám záležať na tom, čo robíme, nie na tom, či nás niekto vidí.";
                    }
                    else
                    {
                        return "Cicero";
                    }
                case 311:
                    if (Autor == false)
                    {
                        return "Či chceš alebo nechceš, niekam patríš. Ako veľmi tam však patríš, to už záleží na tebe.";
                    }
                    else
                    {
                        return "Anton Semjonovič Makarenko";
                    }
                case 312:
                    if (Autor == false)
                    {
                        return "Nech je láska akokoľvek príjemná, predsa len sú príjemnejšie jej prejavy ako ona sama.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 313:
                    if (Autor == false)
                    {
                        return "Nech ma nenávidia, len nech sa ma boja.";
                    }
                    else
                    {
                        return "Caligula";
                    }
                case 314:
                    if (Autor == false)
                    {
                        return "Nech do mňa osud akokoľvek bije, nech ma akokoľvek raní, čím viac trpím, tým viac žiarim.";
                    }
                    else
                    {
                        return "Michelangelo";
                    }
                case 315:
                    if (Autor == false)
                    {
                        return "Či sa to človeku páči alebo nie, je nástrojom prírody. Nie je možné ísť proti prírode. Je silnejšia ako najsilnejšia z ľudí.";
                    }
                    else
                    {
                        return "Picasso";
                    }
                case 316:
                    if (Autor == false)
                    {
                        return "Nech sa to vezme z ktoréhokoľvek konca, skutočnosť je vždy zaujímavejšia, ako čokoľvek čo si vymyslíte.";
                    }
                    else
                    {
                        return "Miloš Forman";
                    }
                case 317:
                    if (Autor == false)
                    {
                        return "Nech tí, ktorí môžu, to spravia lepšie.";
                    }
                    else
                    {
                        return "Latinské príslovie";
                    }
                case 318:
                    if (Autor == false)
                    {
                        return "Axióma o alimentoch: Predpokladáš, že ti bude platiť výživné. Ale mala by si počítať len so prepitným.";
                    }
                    else
                    {
                        return "Lansky";
                    }
                case 319:
                    if (Autor == false)
                    {
                        return "Bájka hovorí o tebe, len meno je zmenené.";
                    }
                    else
                    {
                        return "Q. Flaccus Horatius";
                    }
                case 320:
                    if (Autor == false)
                    {
                        return "Bariéra nudnosti: 1. Čím častejšie to robíš, tým nudnejším sa to stáva. 2. Čím menej často to robíš, tým nudnejším sa stávaš ty.";
                    }
                    else
                    {
                        return "Lansky";
                    }
                case 321:
                    if (Autor == false)
                    {
                        return "Básnici majú byť priemerní ľudia, ani bohovia, ani predavači kníh.";
                    }
                    else
                    {
                        return "Q. Flaccus Horatius";
                    }
                case 322:
                    if (Autor == false)
                    {
                        return "Básnici poznajú i krajiny, kde nikdy neboli.";
                    }
                    else
                    {
                        return "Japonské príslovie";
                    }
                case 323:
                    if (Autor == false)
                    {
                        return "Básnik rozumie prírode lepšie ako hlava učenca.";
                    }
                    else
                    {
                        return "Novalis";
                    }
                case 324:
                    if (Autor == false)
                    {
                        return "Báť sa lásky znamená báť sa života a tí, ktorí sa života boja, sú už z troch štvrtín mŕtvi.";
                    }
                    else
                    {
                        return "Bertrand Russell";
                    }
                case 325:
                    if (Autor == false)
                    {
                        return "Bavilo by niekoho blbnúť, keby blbnutie bolo povinné? Alebo nebavilo?";
                    }
                    else
                    {
                        return "Jan Werich";
                    }
                case 326:
                    if (Autor == false)
                    {
                        return "Beda domu, kde sliepka vládne a kohút mlčí.";
                    }
                    else
                    {
                        return "Španielske príslovie";
                    }
                case 327:
                    if (Autor == false)
                    {
                        return "Beda mi! Pracujem na reforme svojich poddaných a zatiaľ neviem zreformovať ani sám seba.";
                    }
                    else
                    {
                        return "Peter Veľký";
                    }
                case 328:
                    if (Autor == false)
                    {
                        return "Beda umelcom, na ktorých nikto nepľuje.";
                    }
                    else
                    {
                        return "Lope de Vega";
                    }
                case 329:
                    if (Autor == false)
                    {
                        return "Beda, keď si šepkár myslí, že je hercom.";
                    }
                    else
                    {
                        return "Stanislav Jerzy Lec";
                    }
                case 330:
                    if (Autor == false)
                    {
                        return "Behaj pre život, ale neži pre beh.";
                    }
                    else
                    {
                        return "Uhlenbruck";
                    }
                case 331:
                    if (Autor == false)
                    {
                        return "Bez dôvery nie je priateľstva.";
                    }
                    else
                    {
                        return "Epikuros";
                    }
                case 332:
                    if (Autor == false)
                    {
                        return "Bez fantázie nepochopíš ani hole fakty.";
                    }
                    else
                    {
                        return "A. Brie";
                    }
                case 333:
                    if (Autor == false)
                    {
                        return "Bez filozofie sa človek na svete obíde. Ale bez humoru žijú iba hlupáci.";
                    }
                    else
                    {
                        return "Michail Michajlovič Prišvin";
                    }
                case 334:
                    if (Autor == false)
                    {
                        return "Bez chýb sa nikto nenarodí.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 335:
                    if (Autor == false)
                    {
                        return "Bez lásky je človek len mŕtvola na dovolenke.";
                    }
                    else
                    {
                        return "Erich Maria Remarque";
                    }
                case 336:
                    if (Autor == false)
                    {
                        return "Bez ľudí dobrej vôle by život bol ako nákladné a nebezpečné dobrodružstvo.";
                    }
                    else
                    {
                        return "Jan Werich";
                    }
                case 337:
                    if (Autor == false)
                    {
                        return "Bez nehôd, útrap a škôd nikto z nás životom neprejde.";
                    }
                    else
                    {
                        return "Aischylos";
                    }
                case 338:
                    if (Autor == false)
                    {
                        return "Bez povinností je život mäkký a ako keby bez kostí: nedrží pohromade.";
                    }
                    else
                    {
                        return "Joseph Joubert";
                    }
                case 339:
                    if (Autor == false)
                    {
                        return "Bez priateľov nie je šťastia, ale bez nešťastia nepoznáme priateľov.";
                    }
                    else
                    {
                        return "Anglické príslovie";
                    }
                case 340:
                    if (Autor == false)
                    {
                        return "Bez rodiny sa človek chveje zimou v nekonečnom vesmíre.";
                    }
                    else
                    {
                        return "André Maurois";
                    }
                case 341:
                    if (Autor == false)
                    {
                        return "Bez snov a ideálov sa nedá byť človekom.";
                    }
                    else
                    {
                        return "Fischer";
                    }
                case 342:
                    if (Autor == false)
                    {
                        return "Bez učenia ani svätec nedokáže prenášať správne úsudky.";
                    }
                    else
                    {
                        return "Campanella";
                    }
                case 343:
                    if (Autor == false)
                    {
                        return "Bez usilovnej pracovitosti nie je ani talentov ani géniov.";
                    }
                    else
                    {
                        return "Mendelejev";
                    }
                case 344:
                    if (Autor == false)
                    {
                        return "Bez viery v svoje schopnosti a v svoje sily sa nedá podniknúť žiadne dielo.";
                    }
                    else
                    {
                        return "N. K. Krupská";
                    }
                case 345:
                    if (Autor == false)
                    {
                        return "Bezpečnejšie je byť podvedený, ako podvádzať.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 346:
                    if (Autor == false)
                    {
                        return "Ak beží človek po nesprávnej ceste, vzdiali sa pravde tým viac, čím je schopnejší a rýchlejší.";
                    }
                    else
                    {
                        return "Francis Baconn";
                    }
                case 347:
                    if (Autor == false)
                    {
                        return "Bežte vždy za psom a neuhryzne vás, pite vždy pred smädom a nedostanete ho.";
                    }
                    else
                    {
                        return "Rabelais";
                    }
                case 348:
                    if (Autor == false)
                    {
                        return "Biblia vraví, aby sme milovali ako svojich blížnych, tak i nepriateľov. Pravdepodobne preto, že väčšinou sú to tí istí ľudia.";
                    }
                    else
                    {
                        return "G. K. Chesterton";
                    }
                case 349:
                    if (Autor == false)
                    {
                        return "Biely pes, čierny pes - stále pes.";
                    }
                    else
                    {
                        return "Turecké príslovie";
                    }
                case 350:
                    if (Autor == false)
                    {
                        return "Blahoslavení, ktorí nič neočakávajú, vyhnú sa sklamaniu.";
                    }
                    else
                    {
                        return "Alexander Pope";
                    }
                case 351:
                    if (Autor == false)
                    {
                        return "Blažený nie je ten, kto má, čo si praje, ale ten, kto si nepraje, čo nemá.";
                    }
                    else
                    {
                        return "Anthistenes";
                    }
                case 352:
                    if (Autor == false)
                    {
                        return "Blb je nezničiteľný. Číta sa spredu i zozadu rovnako. Preto je mu jedno, i keď sa svet postaví na hlavu.";
                    }
                    else
                    {
                        return "Jaromír Škutina";
                    }
                case 353:
                    if (Autor == false)
                    {
                        return "Hlupáci žijú veselšie, pretože vždy majú viac dôvodov ku smiechu ako ľudia múdri a hĺbaví...";
                    }
                    else
                    {
                        return "Flaubert";
                    }
                case 354:
                    if (Autor == false)
                    {
                        return "Hlúpa nie je staroba, ale tie hlúpe reči tých druhých o nej!";
                    }
                    else
                    {
                        return "Miloš Kopecký";
                    }
                case 355:
                    if (Autor == false)
                    {
                        return "Hlupák sa najlepšie utají tým, že múdro mlčí... ale ten, ktorý to vie a praktizuje, nie je vlastne vôbec hlúpy!";
                    }
                    else
                    {
                        return "Miroslav Horníček";
                    }
                case 356:
                    if (Autor == false)
                    {
                        return "Blbnutie je pre múdreho ten najlacnejší druh rekreácie.";
                    }
                    else
                    {
                        return "Twain";
                    }
                case 357:
                    if (Autor == false)
                    {
                        return "Hlúposť je veľký dar prírody. Robí človeka šťastným.";
                    }
                    else
                    {
                        return "Vladimír Komárek";
                    }
                case 358:
                    if (Autor == false)
                    {
                        return "Hlúposť neodhalená pôsobí nezávisle na našom vedomí, a je teda škodlivá; škodlivejšia je však hlúposť odhalená, ale nepovšimnutá a trpená.";
                    }
                    else
                    {
                        return "Twain";
                    }
                case 359:
                    if (Autor == false)
                    {
                        return "Hlúposť od nás sa vzďaľujúca sa zdá menšia!";
                    }
                    else
                    {
                        return "Renčín";
                    }
                case 360:
                    if (Autor == false)
                    {
                        return "Blesky udierajú do najvyšších vrcholov.";
                    }
                    else
                    {
                        return "Q. Flaccus Horatius";
                    }
                case 361:
                    if (Autor == false)
                    {
                        return "Blízkeho človeka pochopíme vtedy, keď sa s ním rozlúčime.";
                    }
                    else
                    {
                        return "Ivan Sergejevič Turgenev";
                    }
                case 362:
                    if (Autor == false)
                    {
                        return "Bohaté skúsenosti majú za následok šikovnosť, veľa vedomostí múdrosť.";
                    }
                    else
                    {
                        return "Thomas Hobbes";
                    }
                case 363:
                    if (Autor == false)
                    {
                        return "Bohatstvo je ako morská voda. Čím viac sa pije, tým väčší je smäd.";
                    }
                    else
                    {
                        return "Arthur Schopenhauer";
                    }
                case 364:
                    if (Autor == false)
                    {
                        return "Bohatstvo múdremu slúži, hlúpemu vládne.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 365:
                    if (Autor == false)
                    {
                        return "Bohatý cit je chudobný na slová, nemá sa krášliť, sám je krásny dosť.";
                    }
                    else
                    {
                        return "William Shakespeare";
                    }
                case 366:
                    if (Autor == false)
                    {
                        return "Bohatý je ten, kto má dosť toho, čo má.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 367:
                    if (Autor == false)
                    {
                        return "Bohatý je ten, kto je múdry.";
                    }
                    else
                    {
                        return "Q. Flaccus Horatius";
                    }
                case 368:
                    if (Autor == false)
                    {
                        return "Bohovia dali človeku dve ruky, aby ich neobťažoval s každou maličkosťou.";
                    }
                    else
                    {
                        return "Pythagoras";
                    }
                case 369:
                    if (Autor == false)
                    {
                        return "Bohovia nebojujú proti hlúposti - žijú z nej.";
                    }
                    else
                    {
                        return "Jean Cocteau";
                    }
                case 370:
                    if (Autor == false)
                    {
                        return "Bohužiaľ, budúcnosť už nie je tým, čím bývala.";
                    }
                    else
                    {
                        return "Valéry";
                    }
                case 371:
                    if (Autor == false)
                    {
                        return "Boj a utrpenie sú soľou života. Víťazstvo je ružovou cestou ku pokoju, ktorý je len slušnejšou formou hnitia.";
                    }
                    else
                    {
                        return "John";
                    }
                case 372:
                    if (Autor == false)
                    {
                        return "Ak sa bojíte samoty, nežeňte sa.";
                    }
                    else
                    {
                        return "Anton Pavlovič Čechov";
                    }
                case 373:
                    if (Autor == false)
                    {
                        return "Bolesť druhých nám pomáha niesť našu vlastnú.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 374:
                    if (Autor == false)
                    {
                        return "Bolesť je prvým pokrmom lásky.";
                    }
                    else
                    {
                        return "Maurice Maeterlinck";
                    }
                case 375:
                    if (Autor == false)
                    {
                        return "Bonus krásy: Je lepšie byť krásna ako múdra, pretože priemerný muž lepšie vidí, ako myslí.";
                    }
                    else
                    {
                        return "Lansky";
                    }
                case 376:
                    if (Autor == false)
                    {
                        return "Bože môj, bdej nado mnou, aby som bola vždy čestným človekom, nikdy však počestnou ženou.";
                    }
                    else
                    {
                        return "Lenclos";
                    }
                case 377:
                    if (Autor == false)
                    {
                        return "Brány svojej väznice si nesie každý človek sám v sebe.";
                    }
                    else
                    {
                        return "Sartre";
                    }
                case 378:
                    if (Autor == false)
                    {
                        return "Skoro oheň, skoro popol.";
                    }
                    else
                    {
                        return "Holandské príslovie";
                    }
                case 379:
                    if (Autor == false)
                    {
                        return "Buď múdrejší ako ostatní, ale nehovor im to.";
                    }
                    else
                    {
                        return "Phillip Chesterfield";
                    }
                case 380:
                    if (Autor == false)
                    {
                        return "Buď opatrný, ak dvoríš žene. Ženy sú diskrétne len dovtedy, kým ťa nevypočujú. Keď ťa odmietnu, veľmi sa potom vyžívajú vo svojej počestnosti.";
                    }
                    else
                    {
                        return "Roda-Roda";
                    }
                case 381:
                    if (Autor == false)
                    {
                        return "Buď sám sebou! Aj tak sa to nedá dlho zatajovať!";
                    }
                    else
                    {
                        return "Brudziňski";
                    }
                case 382:
                    if (Autor == false)
                    {
                        return "Buď skromný. To je typ hrdosti, ktorý najmenej dráždi ostatných.";
                    }
                    else
                    {
                        return "Jules Renard";
                    }
                case 383:
                    if (Autor == false)
                    {
                        return "Buď vždy veselý - to je najlepšia medicína. Veselosť je filozofia veľmi málo pestovaná. Je slnečnou stranou života.";
                    }
                    else
                    {
                        return "George Gordon Byron";
                    }
                case 384:
                    if (Autor == false)
                    {
                        return "Ak bude každý z nás z kremeňa, je celý národ z kvádrov.";
                    }
                    else
                    {
                        return "Jan Neruda";
                    }
                case 385:
                    if (Autor == false)
                    {
                        return "Ak budeš stále s chromými, začneš krívať.";
                    }
                    else
                    {
                        return "Latinské príslovie";
                    }
                case 386:
                    if (Autor == false)
                    {
                        return "Ak budeš spokojný so svojím osudom, budeš žiť múdro.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 387:
                    if (Autor == false)
                    {
                        return "Nech je srdce šťastné alebo trpiace, vždy potrebuje k sebe ešte jedno.";
                    }
                    else
                    {
                        return "Nemcová";
                    }
                case 388:
                    if (Autor == false)
                    {
                        return "Buďme krajne podozrievaví k takým výrokom našich priateľov, ktoré sú nám na prospech.";
                    }
                    else
                    {
                        return "René Descartes";
                    }
                case 389:
                    if (Autor == false)
                    {
                        return "Buďte samoukovia, nečakajte, kým vás naučí život.";
                    }
                    else
                    {
                        return "T. Leo";
                    }
                case 390:
                    if (Autor == false)
                    {
                        return "Boh stvoril len vodu. Človek stvoril víno.";
                    }
                    else
                    {
                        return "Victor Hugo";
                    }
                case 391:
                    if (Autor == false)
                    {
                        return "Boh stvoril muža a ženu, ale zabudol si to dať patentovať, takže každý hlupák môže robiť to isté.";
                    }
                    else
                    {
                        return "George Bernard Shaw";
                    }
                case 392:
                    if (Autor == false)
                    {
                        return "Boh stvoril pokrm, diabol korenie.";
                    }
                    else
                    {
                        return "James Joyce";
                    }
                case 393:
                    if (Autor == false)
                    {
                        return "Bol som dlho presviedčaný, že noviny sú vydávané iba preto, aby pobavili dav a poblúznili ho vo chvíli, kedy buď vonkajšia sila alebo stranícky duch nedovoľujú novinárovi hovoriť pravdu. Preto som ich prestal čítať.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 394:
                    if (Autor == false)
                    {
                        return "Bol mužom svojej ženy, nepatril sám sebe.";
                    }
                    else
                    {
                        return "Fitzgerald";
                    }
                case 395:
                    if (Autor == false)
                    {
                        return "Bol teraz 28 ročný, tragický vek milencov; nemáme už sily milenca mladého a nemáme ešte peňazí milenca starého.";
                    }
                    else
                    {
                        return "Pitigrilli";
                    }
                case 396:
                    if (Autor == false)
                    {
                        return "Bol opatrný. Prvú pomoc poskytol vždy ako druhý.";
                    }
                    else
                    {
                        return "Janovic";
                    }
                case 397:
                    if (Autor == false)
                    {
                        return "Bol taký lejak, že sa všetky svine očistili a všetci ľudia zasvinili.";
                    }
                    else
                    {
                        return "G. Lichtenberg";
                    }
                case 398:
                    if (Autor == false)
                    {
                        return "Bola ako hviezda, vychádzala len za noci.";
                    }
                    else
                    {
                        return "Sekera";
                    }
                case 399:
                    if (Autor == false)
                    {
                        return "Bola na to svoje umenie pyšná. Často vravievala, že keď sa nejaký chlap miloval s ňou, musia mu potom ostatné ženy pripadať nudnejšie ako vychladnutá večera.";
                    }
                    else
                    {
                        return "W. S. Maugham";
                    }
                case 400:
                    if (Autor == false)
                    {
                        return "Bola od prírody žiarlivá, čo je jedna z hlavných vlastností poriadnej ženy.";
                    }
                    else
                    {
                        return "William Makepeace Thackeray";
                    }
                case 401:
                    if (Autor == false)
                    {
                        return "Boli sme dvaja a mali sme len jedno srdce.";
                    }
                    else
                    {
                        return "Villon";
                    }
                case 402:
                    if (Autor == false)
                    {
                        return "Boli najlepší priatelia - jeden o druhom toho veľa vedeli.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 403:
                    if (Autor == false)
                    {
                        return "Bolo by nadmieru nelogické riadiť sa v živote logikou.";
                    }
                    else
                    {
                        return "Kumor";
                    }
                case 404:
                    if (Autor == false)
                    {
                        return "Byť človekom znamená snažiť sa byť bohom.";
                    }
                    else
                    {
                        return "Sartre";
                    }
                case 405:
                    if (Autor == false)
                    {
                        return "Byť dobrým človekom je viac, ako byť veľkým.";
                    }
                    else
                    {
                        return "Julius Zeyer";
                    }
                case 406:
                    if (Autor == false)
                    {
                        return "Byť mladou a nebyť krásnou je práve tak málo potešiteľné, ako byť krásnou ale nebyť mladou.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 407:
                    if (Autor == false)
                    {
                        return "Byť mužom znamená poznať presne svoje možnosti a nepridávať si zbytočné trápenie.";
                    }
                    else
                    {
                        return "Aristainetos";
                    }
                case 408:
                    if (Autor == false)
                    {
                        return "Byť na obtiaž je úlohou hlupáka. Jemný človek vycíti, či je vhodné či nie a vie zmiznúť v okamihu, ktorý ešte predchádza okamihu, kedy sa stane zbytočným.";
                    }
                    else
                    {
                        return "Jean De La Bruyére";
                    }
                case 409:
                    if (Autor == false)
                    {
                        return "Byť odporcom žien, znamená pripisovať im význam, ktorý nemajú.";
                    }
                    else
                    {
                        return "Arbuzov";
                    }
                case 410:
                    if (Autor == false)
                    {
                        return "Byť posledným nevadí, ale nikdy nesmiete byť posledný dvakrát po sebe.";
                    }
                    else
                    {
                        return "Iacocca";
                    }
                case 411:
                    if (Autor == false)
                    {
                        return "Byť radikálny znamená uchopiť vec pri koreni. Koreňom človeka je však človek sám.";
                    }
                    else
                    {
                        return "Karl Marx";
                    }
                case 412:
                    if (Autor == false)
                    {
                        return "Byť sám šťastný a iných obšťastňovať - to je pravým poslaním človeka.";
                    }
                    else
                    {
                        return "Bolzano";
                    }
                case 413:
                    if (Autor == false)
                    {
                        return "Byť šťastný - najistejší prostriedok ako sa priblížiť k dobru.";
                    }
                    else
                    {
                        return "O`Neill";
                    }
                case 414:
                    if (Autor == false)
                    {
                        return "Byť v pravom slova zmysle znamená mať zmysel.";
                    }
                    else
                    {
                        return "Husserl";
                    }
                case 415:
                    if (Autor == false)
                    {
                        return "Byť znamená byť vnímaný.";
                    }
                    else
                    {
                        return "Berkeley";
                    }
                case 416:
                    if (Autor == false)
                    {
                        return "Byť ženou je veľmi ťažká vec, pretože zvyčajne musí žiť s mužom.";
                    }
                    else
                    {
                        return "Conrad";
                    }
                case 417:
                    if (Autor == false)
                    {
                        return "Byť sám je pre mnohých tá najhoršia spoločnosť.";
                    }
                    else
                    {
                        return "Oldřich Fišer";
                    }
                case 418:
                    if (Autor == false)
                    {
                        return "Bývame v láske nespravodliví, pretože toho druhého pokladáme za dokonalého.";
                    }
                    else
                    {
                        return "Jean Paul";
                    }
                case 419:
                    if (Autor == false)
                    {
                        return "Celkom vzaté nám mužom ženské hnutie veľmi lichotí. Ženy sa snažia vyrovnať nám. To znamená, že predstavujeme ich ideál.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 420:
                    if (Autor == false)
                    {
                        return "Celý ľudský život je len cesta ku smrti.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 421:
                    if (Autor == false)
                    {
                        return "Ani Rím nebol postavený za jeden deň.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 422:
                    if (Autor == false)
                    {
                        return "Celý svet je šialene smutný.";
                    }
                    else
                    {
                        return "Lenau";
                    }
                case 423:
                    if (Autor == false)
                    {
                        return "Celý život je priam ideálne začarovaný kruh. Dá sa vyjadriť touto vetou: Lopotíme sa a staráme sa za tým cieľom, aby sme sa nemuseli lopotiť a starať.";
                    }
                    else
                    {
                        return "John";
                    }
                case 424:
                    if (Autor == false)
                    {
                        return "Cesta k veľkým činom je plná tŕnia a bodľačia.";
                    }
                    else
                    {
                        return "Julius Zeyer";
                    }
                case 425:
                    if (Autor == false)
                    {
                        return "Cestovateľ bez znalostí je ako vták bez krídel.";
                    }
                    else
                    {
                        return "Sadí";
                    }
                case 426:
                    if (Autor == false)
                    {
                        return "Cieľom nie je maľovať život, ale dať život maľbe.";
                    }
                    else
                    {
                        return "P. Bonnard";
                    }
                case 427:
                    if (Autor == false)
                    {
                        return "Cieľom umenia je urobiť človeka šťastným.";
                    }
                    else
                    {
                        return "Michelangelo";
                    }
                case 428:
                    if (Autor == false)
                    {
                        return "Cit v láske? To je slabosť, ktorá patrí len mužom. Ženy sú omnoho silnejšie.";
                    }
                    else
                    {
                        return "Léautaud";
                    }
                case 429:
                    if (Autor == false)
                    {
                        return "Civilizácia dverami vyhnala bigamiu, ktorá sa oknom vrátila ako prostitúcia.";
                    }
                    else
                    {
                        return "Louis Aragon";
                    }
                case 430:
                    if (Autor == false)
                    {
                        return "Civilizácie sú líčidlá ľudstva.";
                    }
                    else
                    {
                        return "Reverdy";
                    }
                case 431:
                    if (Autor == false)
                    {
                        return "Cudzia chvála prináša ti len vtedy česť, keď ten, čo ťa chváli, chvály hodný je.";
                    }
                    else
                    {
                        return "František Ladislav Čelakovský";
                    }
                case 432:
                    if (Autor == false)
                    {
                        return "Cudzie ústa nezavrieš, nie sú vráta.";
                    }
                    else
                    {
                        return "Japonské príslovie";
                    }
                case 433:
                    if (Autor == false)
                    {
                        return "Cudzie vady máme pred očami, vlastné za chrbtom.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 434:
                    if (Autor == false)
                    {
                        return "Cudzie výrazy môžu polointeligentom poslúžiť ako ochranný pancier.";
                    }
                    else
                    {
                        return "Vries";
                    }
                case 435:
                    if (Autor == false)
                    {
                        return "Cudzia žena sa zdá krajšia.";
                    }
                    else
                    {
                        return "Talianske príslovie";
                    }
                case 436:
                    if (Autor == false)
                    {
                        return "Čo bráni hovoriť pravdu ako keby žartom.";
                    }
                    else
                    {
                        return "Q. Flaccus Horatius";
                    }
                case 437:
                    if (Autor == false)
                    {
                        return "Čo do suda príde prv, tým bude cítiť navždy.";
                    }
                    else
                    {
                        return "Islandské príslovie";
                    }
                case 438:
                    if (Autor == false)
                    {
                        return "Čo do sveta celého, keď nie je milého.";
                    }
                    else
                    {
                        return "Ruské príslovie";
                    }
                case 439:
                    if (Autor == false)
                    {
                        return "Čo je povolené, po tom sa menej túži.";
                    }
                    else
                    {
                        return "Publius Ovidius Naso";
                    }
                case 440:
                    if (Autor == false)
                    {
                        return "Čo je láska? Prostá rozprávka, mnohokrát rozprávaná.";
                    }
                    else
                    {
                        return "Emile Zola";
                    }
                case 441:
                    if (Autor == false)
                    {
                        return "Čo je mužom česť a sláva, to je ženám krása a láska.";
                    }
                    else
                    {
                        return "Julius Zeyer";
                    }
                case 442:
                    if (Autor == false)
                    {
                        return "Čo je napísané bez námahy, je zvyčajne čítané bez potešenia.";
                    }
                    else
                    {
                        return "Samuel Johnson";
                    }
                case 443:
                    if (Autor == false)
                    {
                        return "Čo je ohavnejšie ako starec, ktorý zvrhlo žije?";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 444:
                    if (Autor == false)
                    {
                        return "Čo je platná väčšina, keď nemá rozum.";
                    }
                    else
                    {
                        return "Modrzewski";
                    }
                case 445:
                    if (Autor == false)
                    {
                        return "Čo je sladšie ako mať niekoho, s kým máš odvahu hovoriť o všetkom tak ako sám so sebou?";
                    }
                    else
                    {
                        return "Cicero";
                    }
                case 446:
                    if (Autor == false)
                    {
                        return "Čo je smiešne? Všetko, kým sa to stane niekomu inému.";
                    }
                    else
                    {
                        return "Voltaire";
                    }
                case 447:
                    if (Autor == false)
                    {
                        return "Čo svet svetom stojí, nikdy žiadna žena neuškrtila muža, keď jej vyznal lásku.";
                    }
                    else
                    {
                        return "Florian";
                    }
                case 448:
                    if (Autor == false)
                    {
                        return "Čo je to stručnosť? Vynechaj niečo, ale nech aj hlupák pochopí, že je to vynechané. Zrozumiteľnú nedopovedanosť ľudia chápu a majú ju radi.";
                    }
                    else
                    {
                        return "Šukšin";
                    }
                case 449:
                    if (Autor == false)
                    {
                        return "Čo je to veľký život? Sú to sny a túžby mladosti, ktoré sa dočkali realizácie v dospelosti.";
                    }
                    else
                    {
                        return "Comte";
                    }
                case 450:
                    if (Autor == false)
                    {
                        return "Čo je to výprask, vie každý z nás celkom presne, ale čo je to láska, to nikto stále nevie.";
                    }
                    else
                    {
                        return "Heinrich Heine";
                    }
                case 451:
                    if (Autor == false)
                    {
                        return "Čo je tragédia a čo komédia, to spoznáš časom.";
                    }
                    else
                    {
                        return "Stanislav Jerzy Lec";
                    }
                case 452:
                    if (Autor == false)
                    {
                        return "Čo raz vstúpi do priestoru a času, musí sa tiež podriadiť zákonom priestoru a času.";
                    }
                    else
                    {
                        return "Feuerbach";
                    }
                case 453:
                    if (Autor == false)
                    {
                        return "Čo si nevysvetlil slovom, palicou nevysvetlíš.";
                    }
                    else
                    {
                        return "Tatarské príslovie";
                    }
                case 454:
                    if (Autor == false)
                    {
                        return "Čo si skutočne miloval, to ti ostane, ostatné je preč. Čo si skutočne miloval, o to ťa nikto neokradne. Čo si skutočne miloval, je tvoje pravé dedičstvo...";
                    }
                    else
                    {
                        return "Pound";
                    }
                case 455:
                    if (Autor == false)
                    {
                        return "Čo si povinný zaplatiť, máš platiť s úsmevom.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 456:
                    if (Autor == false)
                    {
                        return "Čo si zdedil po svojich otcoch, to musíš dobyť, aby si to naozaj mal.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 457:
                    if (Autor == false)
                    {
                        return "Čo koho bolí, o tom i reč volí.";
                    }
                    else
                    {
                        return "Poľské príslovie";
                    }
                case 458:
                    if (Autor == false)
                    {
                        return "Čo milujeme povrchne, si ľahko znechutíme. Od toho však, čo milujeme z hĺbky svojej duše, nás nemôže odradiť nič na svete.";
                    }
                    else
                    {
                        return "Casson";
                    }
                case 459:
                    if (Autor == false)
                    {
                        return "Čo náhodou spadlo, to aby si šikovnosťou opravil.";
                    }
                    else
                    {
                        return "Terentius";
                    }
                case 460:
                    if (Autor == false)
                    {
                        return "Čo nám spraví staroba, keď sme dvaja?";
                    }
                    else
                    {
                        return "Stendhal";
                    }
                case 461:
                    if (Autor == false)
                    {
                        return "Čo nemôžeš urobiť sám, pokaz to aspoň tomu druhému.";
                    }
                    else
                    {
                        return "Karel Čapek";
                    }
                case 462:
                    if (Autor == false)
                    {
                        return "Čo nepríde v pravý čas, nepríde nikdy.";
                    }
                    else
                    {
                        return "Björnson";
                    }
                case 463:
                    if (Autor == false)
                    {
                        return "Čo nevyliečia lieky, vylieči železo, čo nevylieči železo, vylieči oheň, čo nevylieči oheň, je potrebné pokladať za nevyliečiteľné.";
                    }
                    else
                    {
                        return "Hippokrates";
                    }
                case 464:
                    if (Autor == false)
                    {
                        return "Čo nezakazuje zákon, to zakazuje ostych.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 465:
                    if (Autor == false)
                    {
                        return "Čo s farebnou televíziou, keď všetky relácie sú sivé?";
                    }
                    else
                    {
                        return "Ž. Petan";
                    }
                case 466:
                    if (Autor == false)
                    {
                        return "Čo je v nezhode s prírodou, má smrti znak už na svojom čele - a kliatbu v svojom pôvode.";
                    }
                    else
                    {
                        return "Hálek";
                    }
                case 467:
                    if (Autor == false)
                    {
                        return "Čo sa nazýva priateľstvom, býva len spolok na ochranu obojstranných záujmov a výmena dobrých služieb.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 468:
                    if (Autor == false)
                    {
                        return "Čo sa odlúči, to uchmatne líška.";
                    }
                    else
                    {
                        return "Talianske príslovie";
                    }
                case 469:
                    if (Autor == false)
                    {
                        return "Čo sa zrodí, musí umrieť, a čo dozreje, starne.";
                    }
                    else
                    {
                        return "Sallustius";
                    }
                case 470:
                    if (Autor == false)
                    {
                        return "Čo si prajeme, tomu radi veríme.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 471:
                    if (Autor == false)
                    {
                        return "Čo si si zavinil sám, bolí najviac.";
                    }
                    else
                    {
                        return "Sofokles";
                    }
                case 472:
                    if (Autor == false)
                    {
                        return "Čo skutočne chcú muži? Cnostné ženy mužov nudia. Sexuálne agresívne ženy im naháňajú strach.";
                    }
                    else
                    {
                        return "Lansky";
                    }
                case 473:
                    if (Autor == false)
                    {
                        return "Čo ťulpasi napíšu, nech tiež ťulpasi čítajú.";
                    }
                    else
                    {
                        return "Julian Tuwim";
                    }
                case 474:
                    if (Autor == false)
                    {
                        return "Čo už nejde uskutočniť v láske, nech sa stane aspoň v nenávisti.";
                    }
                    else
                    {
                        return "S. Dygat";
                    }
                case 475:
                    if (Autor == false)
                    {
                        return "Čo všetko si ľudia nevymyslia, len aby nemuseli skutočne myslieť.";
                    }
                    else
                    {
                        return "Kumor";
                    }
                case 476:
                    if (Autor == false)
                    {
                        return "Čokoľvek človek získa ľahko, bez práce, máva väčšinou pochybnú hodnotu.";
                    }
                    else
                    {
                        return "Leonid Leonov";
                    }
                case 477:
                    if (Autor == false)
                    {
                        return "Aké je to umenie byť mladý, keď je Vám 24 rokov?";
                    }
                    else
                    {
                        return "Charlie Chaplin";
                    }
                case 478:
                    if (Autor == false)
                    {
                        return "Čo si pre ženu urobil, na to môže zabudnúť, nikdy ti ale nezabudne to, čo si pre ňu neurobil.";
                    }
                    else
                    {
                        return "André Maurois";
                    }
                case 479:
                    if (Autor == false)
                    {
                        return "Cnostná žena je poklad a kto ho má, spraví najlepšie, keď sa s ním nebude chváliť.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 480:
                    if (Autor == false)
                    {
                        return "Cynik je ten, kto tvrdí, že plakal iba preto, že kritizovali kamaráta.";
                    }
                    else
                    {
                        return "Richter";
                    }
                case 481:
                    if (Autor == false)
                    {
                        return "Čiara nášho života je tragická a nádherná arabeska, načrtnutá rydlom duše na skle času.";
                    }
                    else
                    {
                        return "Reverdy";
                    }
                case 482:
                    if (Autor == false)
                    {
                        return "Čas a peniaze sú najťažším bremenom človeka. Beda tomu, kto ich má viac, ako ich môže a vie užiť.";
                    }
                    else
                    {
                        return "Samuel Johnson";
                    }
                case 483:
                    if (Autor == false)
                    {
                        return "Čas dokáže často vyliečiť i hlupáka.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 484:
                    if (Autor == false)
                    {
                        return "Čas je to, čo sa človek neustále snaží zabiť, ale čo nakoniec zabije jeho.";
                    }
                    else
                    {
                        return "Spencer";
                    }
                case 485:
                    if (Autor == false)
                    {
                        return "Čas letí, zvykli sme si hovoriť. Čas však nie, pohybujeme sa my.";
                    }
                    else
                    {
                        return "Talmud";
                    }
                case 486:
                    if (Autor == false)
                    {
                        return "Čas ľudského života je kruh, ale nezatvárajúci sa a veľmi kostrbatý.";
                    }
                    else
                    {
                        return "Laub";
                    }
                case 487:
                    if (Autor == false)
                    {
                        return "Čas prúdi z budúcnosti, ktorá ešte neexistuje, cez prítomnosť, ktorá nemá trvania, do minulosti, čo prestala existovať.";
                    }
                    else
                    {
                        return "Svätý Augustín";
                    }
                case 488:
                    if (Autor == false)
                    {
                        return "Čas ubieha rôzne, podľa toho s kým.";
                    }
                    else
                    {
                        return "William Shakespeare";
                    }
                case 489:
                    if (Autor == false)
                    {
                        return "Čas všetko zahojí.";
                    }
                    else
                    {
                        return "Publius Ovidius Naso";
                    }
                case 490:
                    if (Autor == false)
                    {
                        return "Skoro ísť spať a skoro vstávať a budeš bohatý, múdry a zdravý.";
                    }
                    else
                    {
                        return "Benjamin Franklin";
                    }
                case 491:
                    if (Autor == false)
                    {
                        return "Často by sa muž uspokojil aj s drobnými prejavmi priazne od ženy, ktorej dvorí, ale neodváži sa byť nezdvorilý a tak sa stane jej milencom.";
                    }
                    else
                    {
                        return "Rey";
                    }
                case 492:
                    if (Autor == false)
                    {
                        return "Často býva človek sám sebe najväčším nepriateľom.";
                    }
                    else
                    {
                        return "Cicero";
                    }
                case 493:
                    if (Autor == false)
                    {
                        return "Často je potrebné, žiaľ, dvoch mužov, aby vytvorili jedného dokonalého milenca.";
                    }
                    else
                    {
                        return "Honoré de Balzac";
                    }
                case 494:
                    if (Autor == false)
                    {
                        return "Často máme ľuďom za zlé, že sa nechcú prispôsobiť predstavám, ktoré sme si o nich vytvorili.";
                    }
                    else
                    {
                        return "Kumor";
                    }
                case 495:
                    if (Autor == false)
                    {
                        return "Často si myslím, aká škoda to bola, že Noe s celou svojou kompániou nezmeškal archu.";
                    }
                    else
                    {
                        return "Mark Twain";
                    }
                case 496:
                    if (Autor == false)
                    {
                        return "Často starec vo vysokom veku nemá žiadny iný dôkaz o tom, že žil dlho, ako že zomrel.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 497:
                    if (Autor == false)
                    {
                        return "Často ubližujeme svojim blížnym najviac práve v snahe neublížiť im.";
                    }
                    else
                    {
                        return "Martin";
                    }
                case 498:
                    if (Autor == false)
                    {
                        return "Často upadáme do omylu, keď si myslíme, že to, čo nám druhý hovorí, si skutočne tiež myslí.";
                    }
                    else
                    {
                        return "Becher";
                    }
                case 499:
                    if (Autor == false)
                    {
                        return "Často uzavrú dvaja idioti svadbu z rozumu.";
                    }
                    else
                    {
                        return "Brudziňski";
                    }
                case 500:
                    if (Autor == false)
                    {
                        return "Čakal som to, ale nie tak skoro. (náhrobný nápis).";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 501:
                    if (Autor == false)
                    {
                        return "Ak čakáme, trpíme neprítomnosťou toho, po kom túžime tak veľmi, že nemôžeme zniesť prítomnosť niekoho iného.";
                    }
                    else
                    {
                        return "Marcel Proust";
                    }
                case 502:
                    if (Autor == false)
                    {
                        return "Čakanie na šťastné dni býva oveľa krajšie ako samotné šťastné dni.";
                    }
                    else
                    {
                        return "Paustovskij";
                    }
                case 503:
                    if (Autor == false)
                    {
                        return "Čomu ľudia zo zvyku hovoria osud, sú väčšinou ich vlastné hlúpe skutky.";
                    }
                    else
                    {
                        return "Arthur Schopenhauer";
                    }
                case 504:
                    if (Autor == false)
                    {
                        return "Hocičomu sa učíš, učíš sa pre seba.";
                    }
                    else
                    {
                        return "Petronius";
                    }
                case 505:
                    if (Autor == false)
                    {
                        return "Čestná smrť je lepšia ako hanebný život.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 506:
                    if (Autor == false)
                    {
                        return "Čítanie dobrých kníh je ako rozhovory s najpočestnejšími ľuďmi z minulého storočia.";
                    }
                    else
                    {
                        return "René Descartes";
                    }
                case 507:
                    if (Autor == false)
                    {
                        return "Čím bližšie sú ľudia ku pravde, tým sú tolerantnejší ku omylom druhých. A naopak.";
                    }
                    else
                    {
                        return "Lev Nikolajevič Tolstoj";
                    }
                case 508:
                    if (Autor == false)
                    {
                        return "Čím budeš väčší, tým buď skromnejší.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 509:
                    if (Autor == false)
                    {
                        return "Čím by som bol, keby som sa nezúčastnil? K tomu, aby som bol, musím sa zúčastniť.";
                    }
                    else
                    {
                        return "Antoine de Saint-Exupéry";
                    }
                case 510:
                    if (Autor == false)
                    {
                        return "Čím čistejšia obeť, tým špinavšie ruky vrahov.";
                    }
                    else
                    {
                        return "Stanislav Jerzy Lec";
                    }
                case 511:
                    if (Autor == false)
                    {
                        return "Čím ďalej v lese, tým viac dreva.";
                    }
                    else
                    {
                        return "České príslovie";
                    }
                case 512:
                    if (Autor == false)
                    {
                        return "Čím dlhšie sa človek neožení, tým je slávnejší.";
                    }
                    else
                    {
                        return "Gaius Julius Caesar";
                    }
                case 513:
                    if (Autor == false)
                    {
                        return "Čím horší je štát, tým viac má zákonov.";
                    }
                    else
                    {
                        return "Tacitus";
                    }
                case 514:
                    if (Autor == false)
                    {
                        return "Čo zhrešíme v mladosti, to odpykáme v starobe.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 515:
                    if (Autor == false)
                    {
                        return "Čím je kto učenejší, tým je skromnejší.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 516:
                    if (Autor == false)
                    {
                        return "Čím je muž starší, tým mladšia je jeho druhá žena.";
                    }
                    else
                    {
                        return "Lansky";
                    }
                case 517:
                    if (Autor == false)
                    {
                        return "Čím je spisovateľ lepší, tým menej literárne píše.";
                    }
                    else
                    {
                        return "Sienkiewicz";
                    }
                case 518:
                    if (Autor == false)
                    {
                        return "Čím je život ťažší, tým je krajší.";
                    }
                    else
                    {
                        return "Šukšin";
                    }
                case 519:
                    if (Autor == false)
                    {
                        return "Čím lepší pracant, tým horší manžel.";
                    }
                    else
                    {
                        return "Francúzske príslovie";
                    }
                case 520:
                    if (Autor == false)
                    {
                        return "Čím menej peňazí, tým väčšie počty.";
                    }
                    else
                    {
                        return "Milan Růžička";
                    }
                case 521:
                    if (Autor == false)
                    {
                        return "Čím múdrejší je človek, tým menej má potrieb.";
                    }
                    else
                    {
                        return "Diogenes";
                    }
                case 522:
                    if (Autor == false)
                    {
                        return "Čím premyslenejšie si ľudia počínajú, tým účinnejšie ich môže postihnúť náhoda.";
                    }
                    else
                    {
                        return "Dürrenmatt";
                    }
                case 523:
                    if (Autor == false)
                    {
                        return "Čím slabšie je telo, tým viac rozkazuje: čím je silnejšie, tým viac počúva.";
                    }
                    else
                    {
                        return "Jean Jacques Rousseau";
                    }
                case 524:
                    if (Autor == false)
                    {
                        return "Čím to je, že z tých najšpinavších obchodov býva zvyčajne najväčší čistý zisk?";
                    }
                    else
                    {
                        return "Vlasta Burian";
                    }
                case 525:
                    if (Autor == false)
                    {
                        return "Čím viac je človek rozumnejší a lepší, tým viac dobra v ľuďoch pozoruje.";
                    }
                    else
                    {
                        return "Blaisa Pascal";
                    }
                case 526:
                    if (Autor == false)
                    {
                        return "Čím viac jej dávam, tým viac ju mám.";
                    }
                    else
                    {
                        return "William Shakespeare";
                    }
                case 527:
                    if (Autor == false)
                    {
                        return "Čím viac ľudia majú, tým viac by chceli.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 528:
                    if (Autor == false)
                    {
                        return "Čím viac spoznávam ľudí, tým viac milujem psov.";
                    }
                    else
                    {
                        return "Anglické príslovie";
                    }
                case 529:
                    if (Autor == false)
                    {
                        return "Čím viac vecí máte, tým menej ste slobodní.";
                    }
                    else
                    {
                        return "Jiří Lábus";
                    }
                case 530:
                    if (Autor == false)
                    {
                        return "Čím viac bláznov, tým väčšia sranda, tým viac človek zmúdrie.";
                    }
                    else
                    {
                        return "Romain Rolland";
                    }
                case 531:
                    if (Autor == false)
                    {
                        return "Čím viac človek vie, tým je väčší.";
                    }
                    else
                    {
                        return "Alexej Maximovič Gorkij";
                    }
                case 532:
                    if (Autor == false)
                    {
                        return "Čím viac kníh, tým menej múdrosti. Čím viac súloženia, tým menej detí.";
                    }
                    else
                    {
                        return "Jean Jacques Rousseau";
                    }
                case 533:
                    if (Autor == false)
                    {
                        return "Čím viac ľudia majú, tým viac žiadajú.";
                    }
                    else
                    {
                        return "Justinus";
                    }
                case 534:
                    if (Autor == false)
                    {
                        return "Čím viac máme lásky, tým ľahšie prejdeme svetom.";
                    }
                    else
                    {
                        return "Immanuel Kant";
                    }
                case 535:
                    if (Autor == false)
                    {
                        return "Čím viac hovoríte, tým menej si ľudia zapamätajú.";
                    }
                    else
                    {
                        return "Francois Fénelon";
                    }
                case 536:
                    if (Autor == false)
                    {
                        return "Čím vyššie vyletíme, tým menší sa zdáme tým, čo nevedia lietať.";
                    }
                    else
                    {
                        return "Friedrich Nietszche";
                    }
                case 537:
                    if (Autor == false)
                    {
                        return "Rob ľuďom to, čo chceš, aby oni robili tebe.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 538:
                    if (Autor == false)
                    {
                        return "Činy sú mocnejšie ako slová.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 539:
                    if (Autor == false)
                    {
                        return "Činy múdrych ľudí diktuje rozum, menej múdrych skúsenosť, nevediacich nutnosť, činy zvierat príroda.";
                    }
                    else
                    {
                        return "Cicero";
                    }
                case 540:
                    if (Autor == false)
                    {
                        return "Činy, ktoré sú často trestané, sa často páchajú.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 541:
                    if (Autor == false)
                    {
                        return "Čistému všetko čisté.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 542:
                    if (Autor == false)
                    {
                        return "Človeče, mysli trocha na druhých. Nemysli si, že iba ty si dôležitý. Na každom záleží tak isto ako na tebe.";
                    }
                    else
                    {
                        return "Jan Masaryk";
                    }
                case 543:
                    if (Autor == false)
                    {
                        return "Človečenstvo nie je stav, v ktorom prichádzame na svet - je to dôstojnosť, ktorú je potrebné získať.";
                    }
                    else
                    {
                        return "Vercors";
                    }
                case 544:
                    if (Autor == false)
                    {
                        return "Človek a kvetina? Potreba nehy a ľútostivý pocit pominuteľnosti krásy.";
                    }
                    else
                    {
                        return "V. Renč";
                    }
                case 545:
                    if (Autor == false)
                    {
                        return "Človek bez princípov a bez vôle sa podobá korábu bez kormidla a bez kompasu. Mení smer pri každej premene vetra.";
                    }
                    else
                    {
                        return "Samuel Smiles";
                    }
                case 546:
                    if (Autor == false)
                    {
                        return "Človek by mal byť tým, čím by mohol byť.";
                    }
                    else
                    {
                        return "Karl Marx";
                    }
                case 547:
                    if (Autor == false)
                    {
                        return "Človek býva taký sebavedomý, ako je obmedzené jeho chápanie.";
                    }
                    else
                    {
                        return "Alexander Pope";
                    }
                case 548:
                    if (Autor == false)
                    {
                        return "Človek dokáže pred svetom ukryť všetko len nie dve veci: že je opitý a že je zamilovaný.";
                    }
                    else
                    {
                        return "Myrer";
                    }
                case 549:
                    if (Autor == false)
                    {
                        return "Človek je bytosť prirodzene spoločenská.";
                    }
                    else
                    {
                        return "Aristoteles";
                    }
                case 550:
                    if (Autor == false)
                    {
                        return "Človek je celý a vždy vnútorne slobodný, keď chce.";
                    }
                    else
                    {
                        return "Mounier";
                    }
                case 551:
                    if (Autor == false)
                    {
                        return "Človek je človeku najlepším liekom.";
                    }
                    else
                    {
                        return "Africké príslovie";
                    }
                case 552:
                    if (Autor == false)
                    {
                        return "Človek je dieťaťom svojho diela.";
                    }
                    else
                    {
                        return "Miguel de Cervantes";
                    }
                case 553:
                    if (Autor == false)
                    {
                        return "Človek je ako ovca, nasleduje vždy prvého okoloidúceho.";
                    }
                    else
                    {
                        return "Napoleon";
                    }
                case 554:
                    if (Autor == false)
                    {
                        return "Človek je jediný tvor, ktorý sa smeje.";
                    }
                    else
                    {
                        return "Whitehead";
                    }
                case 555:
                    if (Autor == false)
                    {
                        return "Človek je jediný živočích, ktorý musí pracovať.";
                    }
                    else
                    {
                        return "Immanuel Kant";
                    }
                case 556:
                    if (Autor == false)
                    {
                        return "Človek je jediný živočích, ktorý sa červená.";
                    }
                    else
                    {
                        return "Jean Paul";
                    }
                case 557:
                    if (Autor == false)
                    {
                        return "Človek je iba potulný bitkár a uličník, pokiaľ neprekročí tridsiaty rok a neožení sa.";
                    }
                    else
                    {
                        return "Grillparzer";
                    }
                case 558:
                    if (Autor == false)
                    {
                        return "Človek je nedokonalý, ale dokonale si s tým poradí.";
                    }
                    else
                    {
                        return "Kumor";
                    }
                case 559:
                    if (Autor == false)
                    {
                        return "Človek je omyl prírody.";
                    }
                    else
                    {
                        return "Gilbert";
                    }
                case 560:
                    if (Autor == false)
                    {
                        return "Človek je len trstina, to najslabšie, čo chová príroda; ale je to trstina mysliaca.";
                    }
                    else
                    {
                        return "Blaisa Pascal";
                    }
                case 561:
                    if (Autor == false)
                    {
                        return "Človek je si vždy skôr vedomý svojich individuálnych útrap ako svojej surovosti voči tým druhým.";
                    }
                    else
                    {
                        return "Josef Čapek";
                    }
                case 562:
                    if (Autor == false)
                    {
                        return "Človek je taký, aká je jeho činnosť, človek nie je nič iného ako jeho život.";
                    }
                    else
                    {
                        return "Sartre";
                    }
                case 563:
                    if (Autor == false)
                    {
                        return "Človek je taký, aká je jeho predstava o šťastí.";
                    }
                    else
                    {
                        return "Suchomlynskij";
                    }
                case 564:
                    if (Autor == false)
                    {
                        return "Človek je ten, kto v sebe nosí väčšiu bytosť, ako je sám.";
                    }
                    else
                    {
                        return "Antoine de Saint-Exupéry";
                    }
                case 565:
                    if (Autor == false)
                    {
                        return "Človek je tvor spoločenský.";
                    }
                    else
                    {
                        return "Aristoteles";
                    }
                case 566:
                    if (Autor == false)
                    {
                        return "Človek je v podstate bytosť s tými ostatnými nespokojná.";
                    }
                    else
                    {
                        return "Josef Čapek";
                    }
                case 567:
                    if (Autor == false)
                    {
                        return "Človek je závislý na svojom prostredí a nemôže sa dokonale izolovať. Nie je však potrebné sa upäto izolovať, aby bol človek sám sebou.";
                    }
                    else
                    {
                        return "Josef Čapek";
                    }
                case 568:
                    if (Autor == false)
                    {
                        return "Človek je zdravý vtedy, keď ho bolí zakaždým niekde inde.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 569:
                    if (Autor == false)
                    {
                        return "Človek je zrodený ku vzájomnej pomoci.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 570:
                    if (Autor == false)
                    {
                        return "Človek je stelesnený paradox, uzlík protikladov.";
                    }
                    else
                    {
                        return "Colton";
                    }
                case 571:
                    if (Autor == false)
                    {
                        return "Človek je zvláštny tvor! Desí ho, ak prichádza o bohatstvo, avšak zostáva ľahostajný k tomu, že sa nenávratne míňajú dni jeho života.";
                    }
                    else
                    {
                        return "Abú al Farah";
                    }
                case 572:
                    if (Autor == false)
                    {
                        return "Človek ešte nie je dosť dokonalý ani dosť slušný, aby mal právo žiť na niečom tak krásnom, ako je zem.";
                    }
                    else
                    {
                        return "Karel Čapek";
                    }
                case 573:
                    if (Autor == false)
                    {
                        return "Človek má byť ku svojmu priateľovi taký ako sám k sebe.";
                    }
                    else
                    {
                        return "Sokrates";
                    }
                case 574:
                    if (Autor == false)
                    {
                        return "Človek má byť stále zamilovaný. To je dôvod, prečo sa nemá oženiť.";
                    }
                    else
                    {
                        return "Oscar Wilde";
                    }
                case 575:
                    if (Autor == false)
                    {
                        return "Človek má na to, aby si zjednodušil život, má vynaložiť rovnaké úsilie, aké vynakladá, keď si ho komplikuje.";
                    }
                    else
                    {
                        return "H. Bergson";
                    }
                case 576:
                    if (Autor == false)
                    {
                        return "Človek má vždy niečo dôležitejšie na práci ako sa oženiť.";
                    }
                    else
                    {
                        return "Friedrich Nietszche";
                    }
                case 577:
                    if (Autor == false)
                    {
                        return "Človek si myslí, že musí byť starý, aby bol múdry. V podstate má ale človek s pribúdajúcimi rokmi čo robiť, aby sa udržal taký múdry, ako bol.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 578:
                    if (Autor == false)
                    {
                        return "Človek musí veriť, že sa dá pochopiť nepochopiteľné, inak by o tom nezačal premýšľať.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 579:
                    if (Autor == false)
                    {
                        return "Človek môže srdcom milovať, ale len rozumom byť šťastný.";
                    }
                    else
                    {
                        return "Giordano Bruno";
                    }
                case 580:
                    if (Autor == false)
                    {
                        return "Človek môže uniknúť všetkému, len nie sebe samému.";
                    }
                    else
                    {
                        return "Zweig";
                    }
                case 581:
                    if (Autor == false)
                    {
                        return "Človek môže veriť vlastným silám, len pokiaľ si nič nenahovára.";
                    }
                    else
                    {
                        return "Pavlenko";
                    }
                case 582:
                    if (Autor == false)
                    {
                        return "Človek nadobúda vedomie svojho vlastného bytia tým, že uznáva bytie mimo seba za sebe rovné, za zákonité.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 583:
                    if (Autor == false)
                    {
                        return "Človek ranený neláskou sa potáca na svete bezcieľne z miesta na miesto.";
                    }
                    else
                    {
                        return "Browne";
                    }
                case 584:
                    if (Autor == false)
                    {
                        return "Človek nemá byť otrokom svojich nerestí, ale tiež nemá byť otrokom svojich cností.";
                    }
                    else
                    {
                        return "John";
                    }
                case 585:
                    if (Autor == false)
                    {
                        return "Človek nemá priateľov, len jeho úspech ich má. (po bitke pri Waterloo).";
                    }
                    else
                    {
                        return "Napoleon";
                    }
                case 586:
                    if (Autor == false)
                    {
                        return "Človek nemusí byť múdrejší ako celý národ.";
                    }
                    else
                    {
                        return "Honoré de Balzac";
                    }
                case 587:
                    if (Autor == false)
                    {
                        return "Človek nie je človekom, keď miluje len seba.";
                    }
                    else
                    {
                        return "Francois Fénelon";
                    }
                case 588:
                    if (Autor == false)
                    {
                        return "Človek nie je v starobe múdrejší, je len opatrnejší.";
                    }
                    else
                    {
                        return "Ernest Hemingway";
                    }
                case 589:
                    if (Autor == false)
                    {
                        return "Človek nie je nikdy žiarlivejší, ako keď sám začína v láske ochabovať. Potom už neverí tomu druhému, pretože cíti, ako málo sa dá veriť jemu samému.";
                    }
                    else
                    {
                        return "Grillparzer";
                    }
                case 590:
                    if (Autor == false)
                    {
                        return "Človek nie je súhrnom toho, čo má, ale súhrnom všetkého , čo ešte nemá, čoho ešte môže dosiahnuť.";
                    }
                    else
                    {
                        return "Sartre";
                    }
                case 591:
                    if (Autor == false)
                    {
                        return "Človek nie je stvorený pre porážku. Človeka je možné zničiť, ale nie poraziť.";
                    }
                    else
                    {
                        return "Ernest Hemingway";
                    }
                case 592:
                    if (Autor == false)
                    {
                        return "Človek nesmie strácať nádej. Stratiť nádej je to isté ako umrieť dvadsať rokov pred vlastnou smrťou.";
                    }
                    else
                    {
                        return "Erenburg";
                    }
                case 593:
                    if (Autor == false)
                    {
                        return "Človek potrebuje dva roky kým sa naučí hovoriť a šesťdesiat, aby sa naučil mlčať.";
                    }
                    else
                    {
                        return "L. Feuchtwanger";
                    }
                case 594:
                    if (Autor == false)
                    {
                        return "Človek pozná len maličký kúsok bytia, ale každý verí, že objavil všetko.";
                    }
                    else
                    {
                        return "Empedokles";
                    }
                case 595:
                    if (Autor == false)
                    {
                        return "Človek pozná sám seba len do tej miery, do akej pozná svet.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 596:
                    if (Autor == false)
                    {
                        return "Človek prekročí plot, kde najnižší uvidí bod.";
                    }
                    else
                    {
                        return "Latinské príslovie";
                    }
                case 597:
                    if (Autor == false)
                    {
                        return "Človek radšej spoznáva vesmír ako seba samého.";
                    }
                    else
                    {
                        return "Ernest Hemingway";
                    }
                case 598:
                    if (Autor == false)
                    {
                        return "Človek sa často žení z náhleho zúfalstva a potom to ľutuje celý život.";
                    }
                    else
                    {
                        return "Moliere";
                    }
                case 599:
                    if (Autor == false)
                    {
                        return "Človek sa môže rozlúčiť so všetkým, len nie s nádejou.";
                    }
                    else
                    {
                        return "Erenburg";
                    }
                case 600:
                    if (Autor == false)
                    {
                        return "Človek sa môže stať človekom len výchovou.";
                    }
                    else
                    {
                        return "Immanuel Kant";
                    }
                case 601:
                    if (Autor == false)
                    {
                        return "Aké by boli ženy milé, keby nechceli byť šťastné!";
                    }
                    else
                    {
                        return "Guitry";
                    }
                case 602:
                    if (Autor == false)
                    {
                        return "Ako náhle človek raz začne, - totiž začať nemusí, ale dokončiť to musí!";
                    }
                    else
                    {
                        return "Karel Čapek";
                    }
                case 603:
                    if (Autor == false)
                    {
                        return "Ako človek starne, umenie a život tvoria jedno.";
                    }
                    else
                    {
                        return "Braque";
                    }
                case 604:
                    if (Autor == false)
                    {
                        return "Ako je pre veľkých duchom charakteristické, že hovoria málo slovami, tak naopak malí duchom majú zasa nadanie, že hovoria veľa a nepovedia nič.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 605:
                    if (Autor == false)
                    {
                        return "Aký istý je priateľ, zistíš v chvíli neistej.";
                    }
                    else
                    {
                        return "Quintus Ennius";
                    }
                case 606:
                    if (Autor == false)
                    {
                        return "Aký je odlišný cit umelca od citu filolozofa!";
                    }
                    else
                    {
                        return "Taine";
                    }
                case 607:
                    if (Autor == false)
                    {
                        return "Ako ochotne uveríme v múdrosť tých, ktorí majú s nami rovnaké názory!";
                    }
                    else
                    {
                        return "John";
                    }
                case 608:
                    if (Autor == false)
                    {
                        return "Ako napredujeme v živote, poznávame hranice svojich schopností.";
                    }
                    else
                    {
                        return "Sigmund Freud";
                    }
                case 609:
                    if (Autor == false)
                    {
                        return "Ako sa ubrániť opilstvu? Pohľadom na opilca.";
                    }
                    else
                    {
                        return "Čínske príslovie";
                    }
                case 610:
                    if (Autor == false)
                    {
                        return "Aké smutné je pre maliara, ktorý miluje blondíny a nesmie ich maľovať na svojich obrazoch, pretože sa nehodia ku košíku s ovocím.";
                    }
                    else
                    {
                        return "Pablo Picasso";
                    }
                case 611:
                    if (Autor == false)
                    {
                        return "Ako starí hudú, tak mladí pískajú.";
                    }
                    else
                    {
                        return "Nemecké príslovie";
                    }
                case 612:
                    if (Autor == false)
                    {
                        return "Aký strašný by bol svet, keby sa nerodili ustavične deti, čo prinášajú so sebou možnosť dokonalosti a nevinnosti.";
                    }
                    else
                    {
                        return "John Ruskin";
                    }
                case 613:
                    if (Autor == false)
                    {
                        return "Ako školák zo školy ide milý k milej, ako do školy však od nej zasmušilo.";
                    }
                    else
                    {
                        return "William Shakespeare";
                    }
                case 614:
                    if (Autor == false)
                    {
                        return "Ako ťa asi musí milovať žena, ktorá ti odpustí i krivdu, ktorú na tebe spáchala!";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 615:
                    if (Autor == false)
                    {
                        return "Aký veľký som bol muž, keď som bol ešte malý chlapec!";
                    }
                    else
                    {
                        return "Börne";
                    }
                case 616:
                    if (Autor == false)
                    {
                        return "Ako všetky zmyslové vnemy, tak i to, čo je v mysli, je vo vzťahu k človeku a nie k vesmíru.";
                    }
                    else
                    {
                        return "Francis Baconn";
                    }
                case 617:
                    if (Autor == false)
                    {
                        return "Ako vychovať syna ku skutočnej mravnosti? Zariadiť, aby žil v obci s dobrými zákonmi.";
                    }
                    else
                    {
                        return "Hegel";
                    }
                case 618:
                    if (Autor == false)
                    {
                        return "Ako náhle je ľudská myseľ otrasená, má sklon veriť poverám.";
                    }
                    else
                    {
                        return "Tacitus";
                    }
                case 619:
                    if (Autor == false)
                    {
                        return "Ako náhle stretnete ženu, ktorá vám zostala dlžná odpoveď, dobre sa jej pozrite do úst - určite nemá jazyk.";
                    }
                    else
                    {
                        return "William Shakespeare";
                    }
                case 620:
                    if (Autor == false)
                    {
                        return "Ako náhle sa láska zmení v priateľstvo, vyprchá a mizne.";
                    }
                    else
                    {
                        return "Michel de Montaigne";
                    }
                case 621:
                    if (Autor == false)
                    {
                        return "Ako náhle sa z mladosti začne robiť zásluha, je to zlé. Pretože každý starý hlupák bol tiež raz mladý hlupák.";
                    }
                    else
                    {
                        return "Jan Werich";
                    }
                case 622:
                    if (Autor == false)
                    {
                        return "Ako náhle žiadame priateľskú radu, sme už rozhodnutí. Predseda súdu udelí slovo advokátovi, tiež až keď má už rozsudok hotový.";
                    }
                    else
                    {
                        return "Pitigrilli";
                    }
                case 623:
                    if (Autor == false)
                    {
                        return "Čestní muži sa ženia rýchlo, múdri nikdy.";
                    }
                    else
                    {
                        return "Miguel de Cervantes";
                    }
                case 624:
                    if (Autor == false)
                    {
                        return "Čo oko nevidí, to srdce nebolí.";
                    }
                    else
                    {
                        return "Arabské príslovie";
                    }
                case 625:
                    if (Autor == false)
                    {
                        return "Človek sa musí smiať skôr, ako je šťastný, pretože inak by mohol umrieť bez toho, aby sa smial.";
                    }
                    else
                    {
                        return "Jean De La Bruyére";
                    }
                case 626:
                    if (Autor == false)
                    {
                        return "Človek sa narodil pre činnosť. Nebyť ničím zamestnaný a neexistovať je pre človeka to isté.";
                    }
                    else
                    {
                        return "Voltaire";
                    }
                case 627:
                    if (Autor == false)
                    {
                        return "Človek sa nasýti všetkého - aj lásky.";
                    }
                    else
                    {
                        return "Homér";
                    }
                case 628:
                    if (Autor == false)
                    {
                        return "Človek sa nesmie pokúšať vstúpiť do života druhých proti ich prianiu.";
                    }
                    else
                    {
                        return "Mauriac";
                    }
                case 629:
                    if (Autor == false)
                    {
                        return "Človek sa nikdy nezbaví toho, o čom mlčí.";
                    }
                    else
                    {
                        return "Karel Čapek";
                    }
                case 630:
                    if (Autor == false)
                    {
                        return "Človek sa naplno prejaví, až keď zmeria svoje sily s nejakou prekážkou.";
                    }
                    else
                    {
                        return "Antoine de Saint-Exupéry";
                    }
                case 631:
                    if (Autor == false)
                    {
                        return "Človek sa podobá zlomku, v ktorom čitateľ je to, čo naozaj je, a menovateľ to, čo si o sebe myslí. Čím je menovateľ väčší, tým menší je zlomok.";
                    }
                    else
                    {
                        return "Lev Nikolajevič Tolstoj";
                    }
                case 632:
                    if (Autor == false)
                    {
                        return "Ak je ich vzájomná láska ušľachtilá a slobodná, môže nájsť hrdinské vyjadrenie v tom, že sa obaja dobrovoľne stanú otrokmi.";
                    }
                    else
                    {
                        return "G. K. Chesterton";
                    }
                case 633:
                    if (Autor == false)
                    {
                        return "Ak je osol veľký, myslí si, že je kôň.";
                    }
                    else
                    {
                        return "Španielske príslovie";
                    }
                case 634:
                    if (Autor == false)
                    {
                        return "Ak je osud k človeku mimoriadne blahosklonný a chce ho obdariť najväčším šťastím na svete, dá mu verných priateľov.";
                    }
                    else
                    {
                        return "Ernst Thälmann";
                    }
                case 635:
                    if (Autor == false)
                    {
                        return "Ak je pravda, právo a spravodlivosť na pochode, tak až potom je skutočne šťastím žiť.";
                    }
                    else
                    {
                        return "Josef Čapek";
                    }
                case 636:
                    if (Autor == false)
                    {
                        return "Ak je tvoj priateľ medový, nemusíš ho zožrať celého.";
                    }
                    else
                    {
                        return "Arabské príslovie";
                    }
                case 637:
                    if (Autor == false)
                    {
                        return "Človek sa stáva otrokom svojich návykov.";
                    }
                    else
                    {
                        return "Latinské príslovie";
                    }
                case 638:
                    if (Autor == false)
                    {
                        return "Človek sa vynoril zo všeobecného tápania zeme.";
                    }
                    else
                    {
                        return "Teilhard de Chardin";
                    }
                case 639:
                    if (Autor == false)
                    {
                        return "Človek si uchová prvú lásku - kým nepríde druhá.";
                    }
                    else
                    {
                        return "Francois de la Rochefoucauld";
                    }
                case 640:
                    if (Autor == false)
                    {
                        return "Človek ľahšie spozná vesmír ako svojho suseda.";
                    }
                    else
                    {
                        return "Erich Maria Remarque";
                    }
                case 641:
                    if (Autor == false)
                    {
                        return "Človek spraví veľa, aby ho milovali a spraví všetko, aby mu závideli.";
                    }
                    else
                    {
                        return "Mark Twain";
                    }
                case 642:
                    if (Autor == false)
                    {
                        return "Človek umiera toľkokrát, koľkokrát stratí priateľa.";
                    }
                    else
                    {
                        return "Francis Bacon";
                    }
                case 643:
                    if (Autor == false)
                    {
                        return "Človek sa nachádza vždy v určitej situácii, o ktorej by sa dalo oprávnene povedať, že je ako keby okamžitým pokračovaním jeho tela.";
                    }
                    else
                    {
                        return "Marcel";
                    }
                case 644:
                    if (Autor == false)
                    {
                        return "Človek vidí svet skoro vždy okuliarmi citu, a podľa farby skla sa mu zdá jemný, alebo purpurovo jasný.";
                    }
                    else
                    {
                        return "Hans Christian Andersen";
                    }
                case 645:
                    if (Autor == false)
                    {
                        return "Človek vlastne vie, len keď vie málo. Čím viac vie, tým väčšie sú pochybnosti.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 646:
                    if (Autor == false)
                    {
                        return "Človek vytvára človeka k svojmu obrazu - ale nie vždy ho potom v skutočnosti pozná.";
                    }
                    else
                    {
                        return "Reverdy";
                    }
                case 647:
                    if (Autor == false)
                    {
                        return "Človek ostáva mladý, kým je ešte schopný učiť sa, získavať nové vlastnosti a znášať odlišné názory ostatných.";
                    }
                    else
                    {
                        return "Maria von Ebner-Eschenbachová";
                    }
                case 648:
                    if (Autor == false)
                    {
                        return "Človek žije skutočný život, ak je šťastný šťastím druhých.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 649:
                    if (Autor == false)
                    {
                        return "Človek žije, umiera, nevie ani ako žije, ani ako umiera.";
                    }
                    else
                    {
                        return "Sartre";
                    }
                case 650:
                    if (Autor == false)
                    {
                        return "Človek, ktorému sa nikto nepáči, je na tom oveľa horšie ako človek, ktorý sa nepáči nikomu.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 651:
                    if (Autor == false)
                    {
                        return "Človek, ktorý prichádza s novou myšlienkou je blázon dovtedy, kým jeho myšlienka zvíťazí.";
                    }
                    else
                    {
                        return "Mark Twain";
                    }
                case 652:
                    if (Autor == false)
                    {
                        return "Človek, ktorý sa nevie usmievať, si nesmie otvoriť obchod.";
                    }
                    else
                    {
                        return "Čínske príslovie";
                    }
                case 653:
                    if (Autor == false)
                    {
                        return "Človek, ktorý sa nemôže pochváliť ničím iným, ako svojimi vznešenými predkami, je ako zemiak: jeho lepšia časť je pod zemou.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 654:
                    if (Autor == false)
                    {
                        return "Človek, ktorý sa naplno niečomu oddá, nepotrebuje rodinu.";
                    }
                    else
                    {
                        return "M. L. King";
                    }
                case 655:
                    if (Autor == false)
                    {
                        return "Človek, na ktorého nadávajú hlupáci, je hodný dôvery.";
                    }
                    else
                    {
                        return "Sartre";
                    }
                case 656:
                    if (Autor == false)
                    {
                        return "Človeka je možné poznať podľa kníh, ktoré číta.";
                    }
                    else
                    {
                        return "Samuel Smiles";
                    }
                case 657:
                    if (Autor == false)
                    {
                        return "Človeka posudzujeme skôr podľa otázok ako podľa odpovedí.";
                    }
                    else
                    {
                        return "Voltaire";
                    }
                case 658:
                    if (Autor == false)
                    {
                        return "Človeka pri víne spoznáš.";
                    }
                    else
                    {
                        return "České príslovie";
                    }
                case 659:
                    if (Autor == false)
                    {
                        return "Človeka súdime nie podľa toho, čo o sebe hovorí alebo čo si o sebe myslí, ale podľa toho čo robí.";
                    }
                    else
                    {
                        return "Vladimír Iljič Lenin";
                    }
                case 660:
                    if (Autor == false)
                    {
                        return "Človeka vítaj podľa šiat a vyprevádzaj podľa rozumu.";
                    }
                    else
                    {
                        return "Slovenské príslovie";
                    }
                case 661:
                    if (Autor == false)
                    {
                        return "Čo dedina, to milá; čo hodina, to iná.";
                    }
                    else
                    {
                        return "Slovenské príslovie";
                    }
                case 662:
                    if (Autor == false)
                    {
                        return "Čítame zo stále ošumelejšej knihy prírody.";
                    }
                    else
                    {
                        return "Kumor";
                    }
                case 663:
                    if (Autor == false)
                    {
                        return "Čítanie je najlepšia výučba. Sledovať myšlienky veľkého človeka - to je tá najzaujímavejšia veda.";
                    }
                    else
                    {
                        return "Puškin";
                    }
                case 664:
                    if (Autor == false)
                    {
                        return "Čítanie prehlbuje myslenie, povzbudzuje myseľ k hľadaniu a analýze javov.";
                    }
                    else
                    {
                        return "Kalinin";
                    }
                case 665:
                    if (Autor == false)
                    {
                        return "Ak čítaš knihu prvý raz, poznávaš nového priateľa, ak ju čítaš druhý raz, stretávaš starého.";
                    }
                    else
                    {
                        return "Čínske príslovie";
                    }
                case 666:
                    if (Autor == false)
                    {
                        return "Štyridsiatnik nielenže nevyžaduje vernosť, ale cíti sa bezpečnejšie, ak majú jeho priateľky vážne známosti.";
                    }
                    else
                    {
                        return "Milan Kundera";
                    }
                case 667:
                    if (Autor == false)
                    {
                        return "Štyridsiatka je staroba mladosti a päťdesiatka mladosť staroby.";
                    }
                    else
                    {
                        return "Metz";
                    }
                case 668:
                    if (Autor == false)
                    {
                        return "Diabol je optimista, keď si myslí, že môže ľudí urobiť horších.";
                    }
                    else
                    {
                        return "Kraus";
                    }
                case 669:
                    if (Autor == false)
                    {
                        return "Ak vám dajú linajkovaný papier, píšte krížom!";
                    }
                    else
                    {
                        return "Jiménez";
                    }
                case 670:
                    if (Autor == false)
                    {
                        return "Ďalšou výhodou starého mládenca je, že si môže obúvať ponožky ktorým chce koncom.";
                    }
                    else
                    {
                        return "Nestroy";
                    }
                case 671:
                    if (Autor == false)
                    {
                        return "Dáma nie je len titul, dáma je vlastnosť.";
                    }
                    else
                    {
                        return "Štuchal";
                    }
                case 672:
                    if (Autor == false)
                    {
                        return "Dámam a pánom je dovolené mať priateľov v psinci, nie však v kuchyni.";
                    }
                    else
                    {
                        return "George Bernard Shaw";
                    }
                case 673:
                    if (Autor == false)
                    {
                        return "Dámska móda bola vždy tou najnákladnejšou obalovou technikou.";
                    }
                    else
                    {
                        return "A. Bierce";
                    }
                case 674:
                    if (Autor == false)
                    {
                        return "Dané slovo platí viac ako slonovina.";
                    }
                    else
                    {
                        return "Africké príslovie";
                    }
                case 675:
                    if (Autor == false)
                    {
                        return "Darovanému koňovi na zuby nepozeraj.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 676:
                    if (Autor == false)
                    {
                        return "Ak daruješ človeku rybu, nakŕmiš ho na deň, ak ho naučíš loviť, dáš mu potravu pre celý život.";
                    }
                    else
                    {
                        return "Čínske príslovie";
                    }
                case 677:
                    if (Autor == false)
                    {
                        return "Dávajte mi čo najviac plodných omylov plných zárodkov myšlienok a nechajte si svoju jalovú pravdu.";
                    }
                    else
                    {
                        return "Pareto";
                    }
                case 678:
                    if (Autor == false)
                    {
                        return "Dbajme, aby nám staroba neurobila vrásky tiež na duši, keď ich robí na tvári.";
                    }
                    else
                    {
                        return "Michel de Montaigne";
                    }
                case 679:
                    if (Autor == false)
                    {
                        return "Dedičnosť je to, v čo veríme, keď máme inteligentné dieťa.";
                    }
                    else
                    {
                        return "Charlie Chaplin";
                    }
                case 680:
                    if (Autor == false)
                    {
                        return "Deficit je to, čo máme, keď už nič nemáme.";
                    }
                    else
                    {
                        return "Oldřich Fišer";
                    }
                case 681:
                    if (Autor == false)
                    {
                        return "Definícia úspechu: Ak pokladáme A za úspech, platí výraz: A=X+Y+Z, kde X je práca, Y odpočinok a Z je držať jazyk za zubami.";
                    }
                    else
                    {
                        return "Albert Einstein";
                    }
                case 682:
                    if (Autor == false)
                    {
                        return "Definovať niečo je akési poškrabanie, po ktorom svrbiace miesto svrbí ešte viac.";
                    }
                    else
                    {
                        return "Butler";
                    }
                case 683:
                    if (Autor == false)
                    {
                        return "Hlúpy človek by urobil najlepšie, keby mlčal. Ale keby vedel, že má mlčať nebol by taký hlúpy.";
                    }
                    else
                    {
                        return "Čínske príslovie";
                    }
                case 684:
                    if (Autor == false)
                    {
                        return "Hlúpy nie je ten, kto sa dopustí hlúposti, ale ten, kto svoju hlúposť nevie zakryť.";
                    }
                    else
                    {
                        return "Gracian";
                    }
                case 685:
                    if (Autor == false)
                    {
                        return "Hlupáci sú sebaistí, mysliaci ľudia sú plní pochybností.";
                    }
                    else
                    {
                        return "Bertrand Russell";
                    }
                case 686:
                    if (Autor == false)
                    {
                        return "Hlupák je iba ten, kto nikdy nemyslí inak.";
                    }
                    else
                    {
                        return "Barthélemy";
                    }
                case 687:
                    if (Autor == false)
                    {
                        return "Hlupák je ten, kto nemá ani toľko ducha, aby bol márnivý.";
                    }
                    else
                    {
                        return "Jean De La Bruyére";
                    }
                case 688:
                    if (Autor == false)
                    {
                        return "Hlupák má jednu veľkú výhodu pred človekom vzdelaným: je sám sa sebou spokojný.";
                    }
                    else
                    {
                        return "Napoleon";
                    }
                case 689:
                    if (Autor == false)
                    {
                        return "Hlupák nevychádza nikdy zo smiešnosti, je to jeho charakteristická črta; do smiešnosti upadne niekedy i ten, kto ducha má, ale ten z nej opäť vyjde.";
                    }
                    else
                    {
                        return "Jean De La Bruyére";
                    }
                case 690:
                    if (Autor == false)
                    {
                        return "Hlupák sa nemení, pretože čas ho míňa a skúsenosť sa mu vyhýba.";
                    }
                    else
                    {
                        return "Puškin";
                    }
                case 691:
                    if (Autor == false)
                    {
                        return "Hlupákovi pri každom vtipnom slove vojde do údov úľak.";
                    }
                    else
                    {
                        return "Herakleitos";
                    }
                case 692:
                    if (Autor == false)
                    {
                        return "Hnev je krátke šialenstvo.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 693:
                    if (Autor == false)
                    {
                        return "Hnev milujúcich sa je obroda lásky.";
                    }
                    else
                    {
                        return "Plautus";
                    }
                case 694:
                    if (Autor == false)
                    {
                        return "Hoď dobré zrno do mora a vyrastie ostrov.";
                    }
                    else
                    {
                        return "Indonéske príslovie";
                    }
                case 695:
                    if (Autor == false)
                    {
                        return "Hodiny šťastia počítame len na minúty.";
                    }
                    else
                    {
                        return "George Gordon Byron";
                    }
                case 696:
                    if (Autor == false)
                    {
                        return "Hodnotenie človeka má vychádzať z toho, čo dáva, nie z toho čo je schopný získať.";
                    }
                    else
                    {
                        return "Albert Einstein";
                    }
                case 697:
                    if (Autor == false)
                    {
                        return "Horší je jazyk falošníka ako oštep protivníka.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 698:
                    if (Autor == false)
                    {
                        return "Horšie je hosťa vyhodiť ako ho vôbec do domu nepustiť.";
                    }
                    else
                    {
                        return "Publius Ovidius Naso";
                    }
                case 699:
                    if (Autor == false)
                    {
                        return "Hovoriť o poézii je oveľa obľúbenejšie ako poézia sama.";
                    }
                    else
                    {
                        return "Enzensberger";
                    }
                case 700:
                    if (Autor == false)
                    {
                        return "Hromada ryže sú v skutočnosti jednotlivé zrnká vedľa seba.";
                    }
                    else
                    {
                        return "Indické príslovie";
                    }
                case 701:
                    if (Autor == false)
                    {
                        return "Hrozná je predstava, že by ľudia chodili otravovať, aj keď nič nechcú.";
                    }
                    else
                    {
                        return "Sekera";
                    }
                case 702:
                    if (Autor == false)
                    {
                        return "Hrubá nedbalosť je blízka zlému úmyslu.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 703:
                    if (Autor == false)
                    {
                        return "Cintoríny sú plné nenahraditeľných ľudí.";
                    }
                    else
                    {
                        return "Clemenceau";
                    }
                case 704:
                    if (Autor == false)
                    {
                        return "Hudba je tesnopis emócií. Emócie, ktoré sa dajú opísať tak neľahko, sú priamo oznamované človeku v hudbe a v tom je jej sila a význam.";
                    }
                    else
                    {
                        return "Lev Nikolajevič Tolstoj";
                    }
                case 705:
                    if (Autor == false)
                    {
                        return "Hudba je zjavenie vyššieho rozumu a múdrosti.";
                    }
                    else
                    {
                        return "Ludwig van Beethoven";
                    }
                case 706:
                    if (Autor == false)
                    {
                        return "Hudba musí nám byť niečím božským, čo otvára naše vnútro.";
                    }
                    else
                    {
                        return "Thern";
                    }
                case 707:
                    if (Autor == false)
                    {
                        return "Humor a satira sú ako milenec a milenka: kde jedného niet, tam druhý smutne hľadí.";
                    }
                    else
                    {
                        return "Jan Neruda";
                    }
                case 708:
                    if (Autor == false)
                    {
                        return "Humor a vtip sú príjemné a často mimoriadne užitočné.";
                    }
                    else
                    {
                        return "Cicero";
                    }
                case 709:
                    if (Autor == false)
                    {
                        return "Humor je boj s ľudskou hlúposťou. V tomto boji nemôžeme nikdy vyhrať, ale nikdy v ňom nesmieme ustať. Avšak pozor na mýlku: ten, koho považujeme za hlupáka, považuje za hlupáka nás. Ide o to nevyvraždiť sa.";
                    }
                    else
                    {
                        return "Jan Werich";
                    }
                case 710:
                    if (Autor == false)
                    {
                        return "Humor je jedným z najlepších kusov odevu, aký môže človek v spoločnosti nosiť.";
                    }
                    else
                    {
                        return "William Makepeace Thackeray";
                    }
                case 711:
                    if (Autor == false)
                    {
                        return "Hovorí sa tomu láska. V skutočnosti je to len neovládateľná túžba ovládať a vlastniť druhého človeka.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 712:
                    if (Autor == false)
                    {
                        return "Hovorí sa, že deti, blázni a filozofovia hovoria pravdu. Preto deti bijú, bláznov zatvárajú a filozofov nechápu.";
                    }
                    else
                    {
                        return "Niccolo Paganini";
                    }
                case 713:
                    if (Autor == false)
                    {
                        return "Hovorí sa, že opatrnosť je matka múdrosti. To je lož, pretože keby bola opatrná, nestala by sa matkou.";
                    }
                    else
                    {
                        return "Julian Tuwim";
                    }
                case 714:
                    if (Autor == false)
                    {
                        return "Hovorí sa, že život je oceánom bolesti. To je možné, ale jeho pena je krásna.";
                    }
                    else
                    {
                        return "Gilbert Pierre Cesbron";
                    }
                case 715:
                    if (Autor == false)
                    {
                        return "Humor je isté videnie sveta, je to umenie vidieť svet.";
                    }
                    else
                    {
                        return "Karel Čapek";
                    }
                case 716:
                    if (Autor == false)
                    {
                        return "Humor je najdemokratickejší z ľudských zvykov.";
                    }
                    else
                    {
                        return "Karel Čapek";
                    }
                case 717:
                    if (Autor == false)
                    {
                        return "Humor je najdôstojnejší prejav smútku.";
                    }
                    else
                    {
                        return "Miloš Kopecký";
                    }
                case 718:
                    if (Autor == false)
                    {
                        return "Humor je najvznešenejšou formou ľudských citov.";
                    }
                    else
                    {
                        return "Björnson";
                    }
                case 719:
                    if (Autor == false)
                    {
                        return "Humor je perla z hĺbky, vtip iskriaca pena na povrchu.";
                    }
                    else
                    {
                        return "Publius Syrus";
                    }
                case 720:
                    if (Autor == false)
                    {
                        return "Humor je protijed na pedantstvo.";
                    }
                    else
                    {
                        return "Suaréz";
                    }
                case 721:
                    if (Autor == false)
                    {
                        return "Humor je soľ zeme, a kto je ním dobre nasolený, uchová sa dlho čerstvý.";
                    }
                    else
                    {
                        return "Karel Čapek";
                    }
                case 722:
                    if (Autor == false)
                    {
                        return "Humor, vtip a veselosť nie sú o nič menej hlboké pohnutia mysle ako úškľab a srdcervúce gestá tragédov.";
                    }
                    else
                    {
                        return "Konrád";
                    }
                case 723:
                    if (Autor == false)
                    {
                        return "Hviezdy netušia, že tvoria súhvezdie.";
                    }
                    else
                    {
                        return "Jean Cocteau";
                    }
                case 724:
                    if (Autor == false)
                    {
                        return "Hypotézy sú uspávanky, ktorými profesor uspáva svojich žiakov.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 725:
                    if (Autor == false)
                    {
                        return "Charakter človeka sa spozná podľa toho, aké vtipy ho rania.";
                    }
                    else
                    {
                        return "Christian Morgenstern";
                    }
                case 726:
                    if (Autor == false)
                    {
                        return "Charakter, to je osud človeka.";
                    }
                    else
                    {
                        return "Herakleitos";
                    }
                case 727:
                    if (Autor == false)
                    {
                        return "Charakterom človeka nazývam súhrn jeho morálnych návykov.";
                    }
                    else
                    {
                        return "Stendhal";
                    }
                case 728:
                    if (Autor == false)
                    {
                        return "Charakteristickým znakom výmyslov je ich totálna odolnosť voči objektívnym faktom a ku skúsenosti. Každá argumentácia ku výmyslu je zbytočná.";
                    }
                    else
                    {
                        return "Rubinštejn";
                    }
                case 729:
                    if (Autor == false)
                    {
                        return "Charakterný človek je poctivý v každom slove a každom čine.";
                    }
                    else
                    {
                        return "Samuel Smiles";
                    }
                case 730:
                    if (Autor == false)
                    {
                        return "Chatrč zo slamy, v ktorej sa ľudia smejú, má väčšiu cenu ako palác, v ktorom ľudia plačú.";
                    }
                    else
                    {
                        return "Čínske príslovie";
                    }
                case 731:
                    if (Autor == false)
                    {
                        return "Chceme od svojich priateľov, aby nám úprimne vytýkali naše chyby; keď nás počúvnu, okamžite spoznáme, s akými idiotmi sme sa to vlastne priatelili.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 732:
                    if (Autor == false)
                    {
                        return "Chceš realizovať svojej sny? Prebuď sa!";
                    }
                    else
                    {
                        return "Rudyard Kipling";
                    }
                case 733:
                    if (Autor == false)
                    {
                        return "Chceš si udržať svoje zdravie? Nejedz do sýtosti a neľakaj sa námahy.";
                    }
                    else
                    {
                        return "Hippokrates";
                    }
                case 734:
                    if (Autor == false)
                    {
                        return "Ak chceš byť filozofom, píš romány.";
                    }
                    else
                    {
                        return "Albert Camus";
                    }
                case 735:
                    if (Autor == false)
                    {
                        return "Ak chceš ďaleko doskočiť, stoj nohami pevne na zemi.";
                    }
                    else
                    {
                        return "Pavel Kysilka";
                    }
                case 736:
                    if (Autor == false)
                    {
                        return "Ak chceš dosiahnuť najvyššie, začni najnižšie.";
                    }
                    else
                    {
                        return "Publius Syrus";
                    }
                case 737:
                    if (Autor == false)
                    {
                        return "Ak chceš dobrú ženu, buď správnym chlapom.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 738:
                    if (Autor == false)
                    {
                        return "Ak chceš mať nepriateľov, povyšuj sa nad nich. Ak chceš mať priateľov, dovoľ im vynikať nad tebou.";
                    }
                    else
                    {
                        return "Colton";
                    }
                case 739:
                    if (Autor == false)
                    {
                        return "Ak chceš pocítiť, čo je to radosť, iným radosť pripravuj.";
                    }
                    else
                    {
                        return "Karolína Svetlá";
                    }
                case 740:
                    if (Autor == false)
                    {
                        return "Som rada, že nie som muž, pretože by som sa musela oženiť.";
                    }
                    else
                    {
                        return "Me de Staelová";
                    }
                case 741:
                    if (Autor == false)
                    {
                        return "Ten chlapík je blázon, alebo píše verše.";
                    }
                    else
                    {
                        return "Q. Flaccus Horatius";
                    }
                case 742:
                    if (Autor == false)
                    {
                        return "Ten, kto je prázdny, je naplnený sám sebou";
                    }
                    else
                    {
                        return "Michial Jurjevič Lermontov";
                    }
                case 743:
                    if (Autor == false)
                    {
                        return "Ženy nie sú nikdy silnejšie, ako keď sa ozbroja svojou slabosťou.";
                    }
                    else
                    {
                        return "Sandová";
                    }
                case 744:
                    if (Autor == false)
                    {
                        return "Ženy nevedia, čo chcú a nedajú pokoj, kým to nedostanú.";
                    }
                    else
                    {
                        return "Oscar Wilde";
                    }
                case 745:
                    if (Autor == false)
                    {
                        return "Ženy nikdy neklamú - veria skrátka tomu, čo práve vravia.";
                    }
                    else
                    {
                        return "Dušek";
                    }
                case 746:
                    if (Autor == false)
                    {
                        return "Ženy potrebujú vedieť len dve veci, a variť je jedna z nich.";
                    }
                    else
                    {
                        return "Maurier";
                    }
                case 747:
                    if (Autor == false)
                    {
                        return "Ženy považujú za nevinné všetko, čoho sa dopúšťajú.";
                    }
                    else
                    {
                        return "Joseph Joubert";
                    }
                case 748:
                    if (Autor == false)
                    {
                        return "Život je i v abecede na konci.";
                    }
                    else
                    {
                        return "Laub";
                    }
                case 749:
                    if (Autor == false)
                    {
                        return "Život je najlepšia škola života.";
                    }
                    else
                    {
                        return "Jára Cimrman";
                    }
                case 750:
                    if (Autor == false)
                    {
                        return "Priateľa chváľ verejne a káraj ho medzi štyrmi očami.";
                    }
                    else
                    {
                        return "Leonardo da Vinci";
                    }
                case 751:
                    if (Autor == false)
                    {
                        return "Ideál je v tebe samom. Prekážky k jeho dosiahnutiu sú tiež v tebe.";
                    }
                    else
                    {
                        return "Thomas Carlyle";
                    }
                case 752:
                    if (Autor == false)
                    {
                        return "Idealista je ten, kto pomáha ostatným k prosperite.";
                    }
                    else
                    {
                        return "Henry Ford";
                    }
                case 753:
                    if (Autor == false)
                    {
                        return "Ideálny muž nepije, nefajčí, nestávkuje, neháda sa a neexistuje.";
                    }
                    else
                    {
                        return "Vocásek";
                    }
                case 754:
                    if (Autor == false)
                    {
                        return "Intelekt je neviditeľný pre toho, kto žiadny nemá.";
                    }
                    else
                    {
                        return "Arthur Schopenhauer";
                    }
                case 755:
                    if (Autor == false)
                    {
                        return "Inteligencia nie je nákazlivá choroba.";
                    }
                    else
                    {
                        return "Oscar Wilde";
                    }
                case 756:
                    if (Autor == false)
                    {
                        return "Investície do znalostí prinášajú najvyšší úrok.";
                    }
                    else
                    {
                        return "Benjamin Franklin";
                    }
                case 757:
                    if (Autor == false)
                    {
                        return "Jazyk nemá kosti, a predsa môže zlámať väz.";
                    }
                    else
                    {
                        return "Basile";
                    }
                case 758:
                    if (Autor == false)
                    {
                        return "Ide o úctu k človeku cez jednotlivca.";
                    }
                    else
                    {
                        return "Antoine de Saint-Exupéry";
                    }
                case 759:
                    if (Autor == false)
                    {
                        return "Ak ideš medzi ženy, vezmi bič.";
                    }
                    else
                    {
                        return "Friedrich Nietszche";
                    }
                case 760:
                    if (Autor == false)
                    {
                        return "Je holdom umelcovi, keď ho vykrádajú.";
                    }
                    else
                    {
                        return "Braque";
                    }
                case 761:
                    if (Autor == false)
                    {
                        return "Je len jeden originál lásky, ale tisíc rôznych kópií.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 762:
                    if (Autor == false)
                    {
                        return "Iba zohnutý oráč orie rovnú brázdu.";
                    }
                    else
                    {
                        return "Plinius";
                    }
                case 763:
                    if (Autor == false)
                    {
                        return "Iba ten je šťastný, kto rozumie aforizmom.";
                    }
                    else
                    {
                        return "Jean Paul";
                    }
                case 764:
                    if (Autor == false)
                    {
                        return "Iba ten národ je slobodný, ktorý neberie slobodu iným národom.";
                    }
                    else
                    {
                        return "Karl Marx";
                    }
                case 765:
                    if (Autor == false)
                    {
                        return "Iba to je stratené, čoho sa sami vzdávame.";
                    }
                    else
                    {
                        return "T. Lessing";
                    }
                case 766:
                    if (Autor == false)
                    {
                        return "Iba ženy a lekári vedia, ako veľmi potrebná a milosrdná je lož.";
                    }
                    else
                    {
                        return "France";
                    }
                case 767:
                    if (Autor == false)
                    {
                        return "Ešte nie je všetkým dňom koniec.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 768:
                    if (Autor == false)
                    {
                        return "Ešte nikto nebol taký filozof, aby trpezlivo znášal bolenie zubov.";
                    }
                    else
                    {
                        return "William Shakespeare";
                    }
                case 769:
                    if (Autor == false)
                    {
                        return "Ešte nikoho som nevidel umierať veselo.";
                    }
                    else
                    {
                        return "Friedrich Schiller";
                    }
                case 770:
                    if (Autor == false)
                    {
                        return "Aj hore sa dá dostať plazením.";
                    }
                    else
                    {
                        return "Jonathan Swift";
                    }
                case 771:
                    if (Autor == false)
                    {
                        return "Aj nevera, rovnako ako láska, môže byť platonická.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 772:
                    if (Autor == false)
                    {
                        return "Aj tie najkrajšie nohy niekde končia.";
                    }
                    else
                    {
                        return "Julian Tuwim";
                    }
                case 773:
                    if (Autor == false)
                    {
                        return "Lev je levom aj v klietke, nestane sa oslom.";
                    }
                    else
                    {
                        return "T. G. Masaryk";
                    }
                case 774:
                    if (Autor == false)
                    {
                        return "Neexistuje nevinná lož.";
                    }
                    else
                    {
                        return "Albert Camus";
                    }
                case 775:
                    if (Autor == false)
                    {
                        return "Neexistujú impotentní muži, existujú len nešikovné ženy.";
                    }
                    else
                    {
                        return "Massary";
                    }
                case 776:
                    if (Autor == false)
                    {
                        return "Nechváľme hrdinu pred večerom.";
                    }
                    else
                    {
                        return "A. Brie";
                    }
                case 777:
                    if (Autor == false)
                    {
                        return "Nie je to víno, čo robí človeka opitým - je to on sám.";
                    }
                    else
                    {
                        return "Čínske príslovie";
                    }
                case 778:
                    if (Autor == false)
                    {
                        return "Niet ukrutnejšieho zvieraťa ako človek bez súcitu.";
                    }
                    else
                    {
                        return "Kotzebue";
                    }
                case 779:
                    if (Autor == false)
                    {
                        return "Nie je väčšia chyba, ako prestať skúšať.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 780:
                    if (Autor == false)
                    {
                        return "Nie je väčšia škoda ako stratený čas.";
                    }
                    else
                    {
                        return "Michelangelo Buonarotti";
                    }
                case 781:
                    if (Autor == false)
                    {
                        return "Nepíše ten, koho básne nikto nečíta.";
                    }
                    else
                    {
                        return "Martial";
                    }
                case 782:
                    if (Autor == false)
                    {
                        return "Neplačte nad rozliatym mliekom - je v ňom vody dosť.";
                    }
                    else
                    {
                        return "Anglické príslovie";
                    }
                case 783:
                    if (Autor == false)
                    {
                        return "Nepokúšaj sa utopiť smútok v rume, vie plávať.";
                    }
                    else
                    {
                        return "Francúzske príslovie";
                    }
                case 784:
                    if (Autor == false)
                    {
                        return "Nepomáha nám toľko ani tak pomoc našich priateľov, ako istota, že by nám pomohli.";
                    }
                    else
                    {
                        return "Epikuros";
                    }
                case 785:
                    if (Autor == false)
                    {
                        return "Nepracujem, ako chcem, pracujem ako viem.";
                    }
                    else
                    {
                        return "Braque";
                    }
                case 786:
                    if (Autor == false)
                    {
                        return "Nešťastie pociťujeme ako skutočnosť, zatiaľ čo šťastie je našim snom.";
                    }
                    else
                    {
                        return "Voltaire";
                    }
                case 787:
                    if (Autor == false)
                    {
                        return "Neverme príliš ľuďom.";
                    }
                    else
                    {
                        return "Friedrich Schiller";
                    }
                case 788:
                    if (Autor == false)
                    {
                        return "Všetko skúste; čo je dobré, toho sa držte.";
                    }
                    else
                    {
                        return "Ep. sv. Pavla";
                    }
                case 789:
                    if (Autor == false)
                    {
                        return "Všetko intelektuálne zdokonalenie vzniká v chvíľach voľna.";
                    }
                    else
                    {
                        return "Samuel Johnson";
                    }
                case 790:
                    if (Autor == false)
                    {
                        return "Všetko má svoju krásu, ale nie každý ju vidí.";
                    }
                    else
                    {
                        return "Konfucius (Kung fu tse)";
                    }
                case 791:
                    if (Autor == false)
                    {
                        return "Všetko na žene je hádankou a všetko na žene má jediné riešenie a tým je tehotenstvo.";
                    }
                    else
                    {
                        return "Friedrich Nietszche";
                    }
                case 792:
                    if (Autor == false)
                    {
                        return "Všetko nadmerné sa obracia v zlo.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 793:
                    if (Autor == false)
                    {
                        return "Všetko sa dá vylepšiť - s výnimkou človeka.";
                    }
                    else
                    {
                        return "Bertold Brecht";
                    }
                case 794:
                    if (Autor == false)
                    {
                        return "Všetko, čo vieme, pochádza zo skúsenosti.";
                    }
                    else
                    {
                        return "Immanuel Kant";
                    }
                case 795:
                    if (Autor == false)
                    {
                        return "Všetky nepomiluješ, ale máš sa snažiť.";
                    }
                    else
                    {
                        return "Napoleon";
                    }
                case 796:
                    if (Autor == false)
                    {
                        return "Všetky nezmysly nevznikli naraz. Aj na to bol potrebný vývoj.";
                    }
                    else
                    {
                        return "Konrád";
                    }
                case 797:
                    if (Autor == false)
                    {
                        return "Všetky všeobecné uzávery sú nepresné a nebezpečné.";
                    }
                    else
                    {
                        return "Michel de Montaigne";
                    }
                case 798:
                    if (Autor == false)
                    {
                        return "Aj keď sa vydaté paničky nijako zvlášť nemajú radi, držia predsa mlčky spolu, zvlášť proti mladým dievčatám.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 799:
                    if (Autor == false)
                    {
                        return "Aj keď svet ide vpred, mladosť musí stále začínať od začiatku.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 800:
                    if (Autor == false)
                    {
                        return "Je stále ešte lepšie byť žena, ako byť mŕtvy.";
                    }
                    else
                    {
                        return "Moliere";
                    }
                case 801:
                    if (Autor == false)
                    {
                        return "Je správne dať sa poučiť, aj od nepriateľa.";
                    }
                    else
                    {
                        return "Ovidius";
                    }
                case 802:
                    if (Autor == false)
                    {
                        return "Je ťažké tlieskať tým, čo ti zviazali ruky.";
                    }
                    else
                    {
                        return "Stanislav Jerzy Lec";
                    }
                case 803:
                    if (Autor == false)
                    {
                        return "Je úžasné, akú výbornú pamäť majú ženy, keď ide o to, oplatiť niekomu niečo zlé.";
                    }
                    else
                    {
                        return "Breier";
                    }
                case 804:
                    if (Autor == false)
                    {
                        return "Je v povahe smrteľníkov kopnúť do človeka, keď leží.";
                    }
                    else
                    {
                        return "Aischylos";
                    }
                case 805:
                    if (Autor == false)
                    {
                        return "Jeden otec je lepší ako sto učiteľov.";
                    }
                    else
                    {
                        return "Nórske príslovie";
                    }
                case 806:
                    if (Autor == false)
                    {
                        return "Jeden otec uživí skôr desať detí ako desať detí jedného otca.";
                    }
                    else
                    {
                        return "Holandské príslovie";
                    }
                case 807:
                    if (Autor == false)
                    {
                        return "Jediná spoločnosť, v ktorej človek vydrží, je jeho vlastná.";
                    }
                    else
                    {
                        return "Oscar Wilde";
                    }
                case 808:
                    if (Autor == false)
                    {
                        return "Jedna ruka netlieska.";
                    }
                    else
                    {
                        return "Perské príslovie";
                    }
                case 809:
                    if (Autor == false)
                    {
                        return "Jedna vetva oheň nespraví, jeden človek ešte nie je ľudstvo.";
                    }
                    else
                    {
                        return "Mongolské príslovie";
                    }
                case 810:
                    if (Autor == false)
                    {
                        return "Jedna lastovička jar nerobí.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 811:
                    if (Autor == false)
                    {
                        return "Jedna žena vidí niekedy ďalej ako päť mužov s ďalekohľadom.";
                    }
                    else
                    {
                        return "Jan Werich";
                    }
                case 812:
                    if (Autor == false)
                    {
                        return "Jedenkrát je nikdy, ale dvakrát je zvyk.";
                    }
                    else
                    {
                        return "Dánske príslovie";
                    }
                case 813:
                    if (Autor == false)
                    {
                        return "Jedenkrát vidieť je lepšie ako stokrát počuť.";
                    }
                    else
                    {
                        return "Japonské príslovie";
                    }
                case 814:
                    if (Autor == false)
                    {
                        return "Vypustené slovo sa nedá vziať späť.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 815:
                    if (Autor == false)
                    {
                        return "Jednou z najrozšírenejších chorôb je diagnóza.";
                    }
                    else
                    {
                        return "Kraus";
                    }
                case 816:
                    if (Autor == false)
                    {
                        return "Koniec dobrý, všetko dobré...";
                    }
                    else
                    {
                        return "Walther";
                    }
                case 817:
                    if (Autor == false)
                    {
                        return "Ak sa milenci spolu nenudia, je to preto, že hovoria stále iba o sebe.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 818:
                    if (Autor == false)
                    {
                        return "Ak sa ti podarilo ovládnuť vášeň skôr, ako ona ovládla teba, potom sa môžeš radovať.";
                    }
                    else
                    {
                        return "Plautus";
                    }
                case 819:
                    if (Autor == false)
                    {
                        return "Ak sa žena naozaj hnevá, bozkom to nenapravíš. Tu pomôžu najmenej tri bozky.";
                    }
                    else
                    {
                        return "Carlo Goldoni";
                    }
                case 820:
                    if (Autor == false)
                    {
                        return "Ak žijete v sklenenom dome, nehádžte z dlhej chvíle kameňmi.";
                    }
                    else
                    {
                        return "Anglické príslovie";
                    }
                case 821:
                    if (Autor == false)
                    {
                        return "Jazdec, ktorý nie je milovaný koňom, ďaleko nedôjde.";
                    }
                    else
                    {
                        return "Gruzínske príslovie";
                    }
                case 822:
                    if (Autor == false)
                    {
                        return "K mlčaniu je potrebné veľa duchaplnosti.";
                    }
                    else
                    {
                        return "André Maurois";
                    }
                case 823:
                    if (Autor == false)
                    {
                        return "Karikatúra je vždy pravdivá len chvíľu.";
                    }
                    else
                    {
                        return "Christian Morgenstern";
                    }
                case 824:
                    if (Autor == false)
                    {
                        return "Kašeľ, dym a lásku neutajíš.";
                    }
                    else
                    {
                        return "Benjamin Franklin";
                    }
                case 825:
                    if (Autor == false)
                    {
                        return "Každá chvíľa je tým kratšia, čím je šťastnejšia.";
                    }
                    else
                    {
                        return "Ovidius";
                    }
                case 826:
                    if (Autor == false)
                    {
                        return "Aj hlúposť je produktom vysoko organizovanej hmoty.";
                    }
                    else
                    {
                        return "Kenda";
                    }
                case 827:
                    if (Autor == false)
                    {
                        return "Aj hlúpy muž sa pokladá za niečo lepšie ako je žena.";
                    }
                    else
                    {
                        return "Mongolské príslovie";
                    }
                case 828:
                    if (Autor == false)
                    {
                        return "Aj chyba môže byť užitočná, kým sme mladí. Ale nenosme ju so sebou do staroby.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 829:
                    if (Autor == false)
                    {
                        return "Aj jediný vlas má svoj tieň.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 830:
                    if (Autor == false)
                    {
                        return "Aj keď ľudia nevedia, čo je dobro, majú ho v sebe.";
                    }
                    else
                    {
                        return "Konfucius";
                    }
                case 831:
                    if (Autor == false)
                    {
                        return "Aj vajce je potrebné variť uvážlivo.";
                    }
                    else
                    {
                        return "Arabské príslovie";
                    }
                case 832:
                    if (Autor == false)
                    {
                        return "Aj veľká láska je len malou náhradou za prvú lásku.";
                    }
                    else
                    {
                        return "J. Addison";
                    }
                case 833:
                    if (Autor == false)
                    {
                        return "Je lepšie sa opotrebovať, ako zhrdzavieť.";
                    }
                    else
                    {
                        return "Diderot";
                    }
                case 834:
                    if (Autor == false)
                    {
                        return "Je niekto taký múdry, aby sa poučil skúsenosťami druhých?";
                    }
                    else
                    {
                        return "Voltaire";
                    }
                case 835:
                    if (Autor == false)
                    {
                        return "Je nemožné nájsť muža, ktorý by mi bol ľahostajný.";
                    }
                    else
                    {
                        return "Sophia Loren";
                    }
                case 836:
                    if (Autor == false)
                    {
                        return "Je nerozumné neustupovať nutnostiam v živote.";
                    }
                    else
                    {
                        return "Demokritos";
                    }
                case 837:
                    if (Autor == false)
                    {
                        return "Je len jediný prostriedok, ktorým spoznáš, čo v kom väzí: pusť ho k práci.";
                    }
                    else
                    {
                        return "František Xaver Šalda";
                    }
                case 838:
                    if (Autor == false)
                    {
                        return "Je len jediný spôsob, ako jednať so ženami. Bohužiaľ ho nikto nepozná.";
                    }
                    else
                    {
                        return "Charlie Chaplin";
                    }
                case 839:
                    if (Autor == false)
                    {
                        return "Je len jedno nespochybniteľné šťastie v živote - žiť pre druhého.";
                    }
                    else
                    {
                        return "Lev Nikolajevič Tolstoj";
                    }
                case 840:
                    if (Autor == false)
                    {
                        return "Je krásne spolu mlčať, krajšie spolu sa smiať.";
                    }
                    else
                    {
                        return "Friedrich Nietszche";
                    }
                case 841:
                    if (Autor == false)
                    {
                        return "Je ľahké nájsť si milenku a udržať priateľa. Ťažšie je však nájsť si priateľa a udržať milenku.";
                    }
                    else
                    {
                        return "Sienkiewicz";
                    }
                case 842:
                    if (Autor == false)
                    {
                        return "Chlapi sa neradi rozhodujú, najradšej sú, keď za nich rozhodne žena alebo Boh.";
                    }
                    else
                    {
                        return "John Updike";
                    }
                case 843:
                    if (Autor == false)
                    {
                        return "Múdry sa nedopúšťajú malých hlúpostí.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 844:
                    if (Autor == false)
                    {
                        return "Iba bezcitný muž uvádza ženu do rozpakov.";
                    }
                    else
                    {
                        return "Gaius Julius Caesar";
                    }
                case 845:
                    if (Autor == false)
                    {
                        return "Iba hlupák si môže myslieť, že sa riadim radami, ktoré dávam iným.";
                    }
                    else
                    {
                        return "Salvadore Dalí";
                    }
                case 846:
                    if (Autor == false)
                    {
                        return "Iba keď zdravý ochorie, vie, čo mal.";
                    }
                    else
                    {
                        return "Thomas Carlyle";
                    }
                case 847:
                    if (Autor == false)
                    {
                        return "Ešte nikdy som k žiadnemu mužovi nepocítila takú nenávisť, aby som mu vrátila diamanty.";
                    }
                    else
                    {
                        return "Gaborová";
                    }
                case 848:
                    if (Autor == false)
                    {
                        return "Zvádzanie je skrátka ženský zvyk. Ponúkať sa je skrátka ženská potreba.";
                    }
                    else
                    {
                        return "Clavell";
                    }
                case 849:
                    if (Autor == false)
                    {
                        return "Svadba spraví zo dvoch ľudí jedného, problémom je však určiť ktorý z nich to bude.";
                    }
                    else
                    {
                        return "Mencken";
                    }
                case 850:
                    if (Autor == false)
                    {
                        return "Svedomie (sa rovná) tisíc svedkov.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 851:
                    if (Autor == false)
                    {
                        return "Inšpirácia privodí samotu kdekoľvek.";
                    }
                    else
                    {
                        return "Ralph Waldo Emerson";
                    }
                case 852:
                    if (Autor == false)
                    {
                        return "Inteligencia vidí veci v zárodku.";
                    }
                    else
                    {
                        return "Lao c";
                    }
                case 853:
                    if (Autor == false)
                    {
                        return "Jablko obracia stopku k stromu, z ktorého spadlo.";
                    }
                    else
                    {
                        return "Latinské príslovie";
                    }
                case 854:
                    if (Autor == false)
                    {
                        return "Akí sme, také budú naše deti.";
                    }
                    else
                    {
                        return "Johann Gottfried von Herder";
                    }
                case 855:
                    if (Autor == false)
                    {
                        return "Akí sú ľudia, taká je i diskusia.";
                    }
                    else
                    {
                        return "Karl Marx";
                    }
                case 856:
                    if (Autor == false)
                    {
                        return "Aká práca, taká pláca.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 857:
                    if (Autor == false)
                    {
                        return "Ako veľa moderných žien, sťažuje si aj moja manželka na práce v domácnosti. Neznáša totiž vôbec spôsob, akým ich ja vykonávam.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 858:
                    if (Autor == false)
                    {
                        return "Ako rana páli jazva zlého svedomia.";
                    }
                    else
                    {
                        return "Publius Syrus";
                    }
                case 859:
                    if (Autor == false)
                    {
                        return "Ako všetky zákony sveta, aj pravda je stála a nemenná.";
                    }
                    else
                    {
                        return "Giordano Bruno";
                    }
                case 860:
                    if (Autor == false)
                    {
                        return "Aký život, taký koniec.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 861:
                    if (Autor == false)
                    {
                        return "Jar neprináša jesenné ovocie a nehreje ako septembrové slnko.";
                    }
                    else
                    {
                        return "Louis Aragon";
                    }
                case 862:
                    if (Autor == false)
                    {
                        return "Je hlúpe obávať sa toho, čomu sa nedá vyhnúť.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 863:
                    if (Autor == false)
                    {
                        return "Je hlúposť kopať studňu až vtedy, keď hrdlo zviera smäd.";
                    }
                    else
                    {
                        return "Plautus";
                    }
                case 864:
                    if (Autor == false)
                    {
                        return "Je chybou vyrábať teórie skôr, ako sú zhromaždené všetky fakty.";
                    }
                    else
                    {
                        return "Doyle";
                    }
                case 865:
                    if (Autor == false)
                    {
                        return "Je jedným z najväčších nebeských darov mať takúto roztomilú vec v náručí.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 866:
                    if (Autor == false)
                    {
                        return "Je určite viac ľudí bez zištnosti ako bez závisti.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 867:
                    if (Autor == false)
                    {
                        return "Je lepšie ľutovať, že sme niečo zažili, ako ľutovať, že sme nezažili.";
                    }
                    else
                    {
                        return "Boccaccio";
                    }
                case 868:
                    if (Autor == false)
                    {
                        return "Je lepšie pre ženu, aby si vzala muža, ktorý ju miluje, ako keby si vzala muža, ktorého miluje.";
                    }
                    else
                    {
                        return "Arabské príslovie";
                    }
                case 869:
                    if (Autor == false)
                    {
                        return "Je lepšie radiť sa pred činmi, ako potom o nich premýšľať.";
                    }
                    else
                    {
                        return "Demokritos";
                    }
                case 870:
                    if (Autor == false)
                    {
                        return "Je lepšie rozsvietiť len malú sviečku, ako preklínať temnotu.";
                    }
                    else
                    {
                        return "Konfucius";
                    }
                case 871:
                    if (Autor == false)
                    {
                        return "Je veľa ľudí, ktorí by sa nikdy nezamilovali, keby o láske nepočuli hovoriť.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 872:
                    if (Autor == false)
                    {
                        return "Je ľahšie byť múdrym pred ostatnými ako pred sebou.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 873:
                    if (Autor == false)
                    {
                        return "Je ťažké vyriešiť veľké úlohy ku spokojnosti všetkých.";
                    }
                    else
                    {
                        return "Solón";
                    }
                case 874:
                    if (Autor == false)
                    {
                        return "Je to často len otázka nábytku. Pre ženu je ťažšie ostať vernou v izbe s gaučom, ako v miestnosti, kde sú len kreslá.";
                    }
                    else
                    {
                        return "Rey";
                    }
                case 875:
                    if (Autor == false)
                    {
                        return "Je to vzácna zhovievavosť prírody, že nás tak dlho necháva nažive.";
                    }
                    else
                    {
                        return "Michel de Montaigne";
                    }
                case 876:
                    if (Autor == false)
                    {
                        return "Je vek, v ktorom žena musí byť krásna, aby bola milovaná. A potom príde vek, kedy musí byť milovaná, aby bola krásna.";
                    }
                    else
                    {
                        return "Saganová";
                    }
                case 877:
                    if (Autor == false)
                    {
                        return "Je veľmi málo ľudí, o ktorých by sa dalo povedať, že poznať ich znamená obohatiť život vlastný.";
                    }
                    else
                    {
                        return "John";
                    }
                case 878:
                    if (Autor == false)
                    {
                        return "Je veľmi neľahké nájsť šťastie v sebe. A nájsť ho inde je nemožné.";
                    }
                    else
                    {
                        return "Chamfort";
                    }
                case 879:
                    if (Autor == false)
                    {
                        return "Je veľmi neľahké uvažovať ušľachtilo, keď človek myslí len na to, ako si vyrobiť na chlieb.";
                    }
                    else
                    {
                        return "Jean Jacques Rousseau";
                    }
                case 880:
                    if (Autor == false)
                    {
                        return "Je veľmi prostý recept na to, ako dokázať, aby staré dámy boli roztomilé. Urobte všetko, čo si prajú!";
                    }
                    else
                    {
                        return "Kock";
                    }
                case 881:
                    if (Autor == false)
                    {
                        return "Je vlastné ľudskej povahe nenávidieť toho, koho sme urazili.";
                    }
                    else
                    {
                        return "Tacitus";
                    }
                case 882:
                    if (Autor == false)
                    {
                        return "Je vždy akási známa opice v najkrajšej a najanjelskejšej žene.";
                    }
                    else
                    {
                        return "Honoré de Balzac";
                    }
                case 883:
                    if (Autor == false)
                    {
                        return "Je zaujímavé, koľko mužov s budúcnosťou padne do rúk žien s minulosťou.";
                    }
                    else
                    {
                        return "Antonioni";
                    }
                case 884:
                    if (Autor == false)
                    {
                        return "Aj keď veľa prečítaš, zvoľ si jednu vec, ktorú toho dňa premyslíš.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 885:
                    if (Autor == false)
                    {
                        return "Aj najmúdrejšie sa stávajú obeťou lichotenia.";
                    }
                    else
                    {
                        return "Moliere";
                    }
                case 886:
                    if (Autor == false)
                    {
                        return "Aj ten najväčší filozof sa často neubráni nejakej hlúposti.";
                    }
                    else
                    {
                        return "Jaroslav Hašek";
                    }
                case 887:
                    if (Autor == false)
                    {
                        return "Ja je vrcholom kužeľa, ktorého základňou je vesmír.";
                    }
                    else
                    {
                        return "Christian Morgenstern";
                    }
                case 888:
                    if (Autor == false)
                    {
                        return "Jablko nepadá ďaleko od stromu.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 889:
                    if (Autor == false)
                    {
                        return "Akokoľvek je človek v láske citlivý, odpúšťa jej viac pokleskov ako v priateľstve.";
                    }
                    else
                    {
                        return "Jean De La Bruyére";
                    }
                case 890:
                    if (Autor == false)
                    {
                        return "Jazyk je najlepšia a najhoršia časť tela.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 891:
                    if (Autor == false)
                    {
                        return "Choď do boja veselo, lebo mŕtvi, ktorí sa neusmievajú, sú škaredí.";
                    }
                    else
                    {
                        return "Jack London";
                    }
                case 892:
                    if (Autor == false)
                    {
                        return "Iba raz žiješ - každej chvíle je škoda, ktorej si neužiješ.";
                    }
                    else
                    {
                        return "Wojkiewicz";
                    }
                case 893:
                    if (Autor == false)
                    {
                        return "Iba riadiac sa podľa prírody, môžeme si ju podriadiť.";
                    }
                    else
                    {
                        return "Francis Baconn";
                    }
                case 894:
                    if (Autor == false)
                    {
                        return "Kde sú priatelia, tam je i hojnosť.";
                    }
                    else
                    {
                        return "Plautus";
                    }
                case 895:
                    if (Autor == false)
                    {
                        return "Kde sú priatelia, tam je i pomoc.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 896:
                    if (Autor == false)
                    {
                        return "Kde niet lásky, vynikne každá chyba.";
                    }
                    else
                    {
                        return "Anglické príslovie";
                    }
                case 897:
                    if (Autor == false)
                    {
                        return "Kto číta, ten myslí, kto myslí, ten uvažuje.";
                    }
                    else
                    {
                        return "Victor Hugo";
                    }
                case 898:
                    if (Autor == false)
                    {
                        return "Kto dal život dieťaťu, stáva sa jeho dlžníkom.";
                    }
                    else
                    {
                        return "Fabre";
                    }
                case 899:
                    if (Autor == false)
                    {
                        return "Kto dôveruje sám sebe, predbehne ostatných.";
                    }
                    else
                    {
                        return "Čínske príslovie";
                    }
                case 900:
                    if (Autor == false)
                    {
                        return "Kto hľadá priateľa bez chyby, ostane bez priateľov.";
                    }
                    else
                    {
                        return "Turecké príslovie";
                    }
                case 901:
                    if (Autor == false)
                    {
                        return "Kto naháňa šťastie, sám je štvanec.";
                    }
                    else
                    {
                        return "Alois Jirásek";
                    }
                case 902:
                    if (Autor == false)
                    {
                        return "Kto chce hýbať svetom, nech najprv rozhýbe sám seba.";
                    }
                    else
                    {
                        return "Sokrates";
                    }
                case 903:
                    if (Autor == false)
                    {
                        return "Kto chytí rybu, je rybár.";
                    }
                    else
                    {
                        return "Portugalské príslovie";
                    }
                case 904:
                    if (Autor == false)
                    {
                        return "Kto je zamilovaný do seba, nemá soka.";
                    }
                    else
                    {
                        return "Benjamin Franklin";
                    }
                case 905:
                    if (Autor == false)
                    {
                        return "Kto druhému jamu kope, sám do nej padá.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 906:
                    if (Autor == false)
                    {
                        return "Kto má čas, má život.";
                    }
                    else
                    {
                        return "Florio";
                    }
                case 907:
                    if (Autor == false)
                    {
                        return "Kto má charakter, má i sebe vlastné typické myslenie a cítenie.";
                    }
                    else
                    {
                        return "Friedrich Nietszche";
                    }
                case 908:
                    if (Autor == false)
                    {
                        return "Kto má peniaze, kúpi si auto. Kto ich nemá, zomrie inak.";
                    }
                    else
                    {
                        return "Fernandel";
                    }
                case 909:
                    if (Autor == false)
                    {
                        return "Kto má rád chválu, musí si na ňu zaslúžiť dôvod.";
                    }
                    else
                    {
                        return "Antisthenes";
                    }
                case 910:
                    if (Autor == false)
                    {
                        return "Kto má svoje miesto na vrchole sopky, je vždy v nebezpečenstve.";
                    }
                    else
                    {
                        return "Sienkiewicz";
                    }
                case 911:
                    if (Autor == false)
                    {
                        return "Kto málo myslí, často sa mýli.";
                    }
                    else
                    {
                        return "Leonardo da Vinci";
                    }
                case 912:
                    if (Autor == false)
                    {
                        return "Kto mlčí, ten svedčí.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 913:
                    if (Autor == false)
                    {
                        return "Kto sám sa chváli, rýchlo posmech utŕži.";
                    }
                    else
                    {
                        return "Publius Syrus";
                    }
                case 914:
                    if (Autor == false)
                    {
                        return "Kto sám v seba verí, ten našiel najlepšiu podporu.";
                    }
                    else
                    {
                        return "Karel Havlíček Borovský";
                    }
                case 915:
                    if (Autor == false)
                    {
                        return "Kto sa smeje v piatok, bude plakať v nedeľu.";
                    }
                    else
                    {
                        return "Racine";
                    }
                case 916:
                    if (Autor == false)
                    {
                        return "Kto sa smeje, namiesto toho aby zúril, je vždy silnejší.";
                    }
                    else
                    {
                        return "Japonské príslovie";
                    }
                case 917:
                    if (Autor == false)
                    {
                        return "Kto sa žení pre peniaze, má aspoň rozumný dôvod.";
                    }
                    else
                    {
                        return "Laub";
                    }
                case 918:
                    if (Autor == false)
                    {
                        return "Kto vietor seje, búrku bude žať.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 919:
                    if (Autor == false)
                    {
                        return "Kto váha, hľadá dôvody, prečo nesmie.";
                    }
                    else
                    {
                        return "T. Lessing";
                    }
                case 920:
                    if (Autor == false)
                    {
                        return "Kto vynašiel odev, vynašiel snáď i lásku.";
                    }
                    else
                    {
                        return "Kleist";
                    }
                case 921:
                    if (Autor == false)
                    {
                        return "Kto si zobral bozk a nezoberie si všetko, zaslúži si, aby stratil aj to, čo získal.";
                    }
                    else
                    {
                        return "Ovidius";
                    }
                case 922:
                    if (Autor == false)
                    {
                        return "Kto zíva pomáha zívať aj ostatným.";
                    }
                    else
                    {
                        return "Holandské príslovie";
                    }
                case 923:
                    if (Autor == false)
                    {
                        return "Láska a priateľstvo sa vylučujú.";
                    }
                    else
                    {
                        return "Jean De La Bruyére";
                    }
                case 924:
                    if (Autor == false)
                    {
                        return "Láska hory prenáša, ale s hlúposťou ani nepohne.";
                    }
                    else
                    {
                        return "Jiří Žáček";
                    }
                case 925:
                    if (Autor == false)
                    {
                        return "Láska je ideál. Manželstvo je realita.";
                    }
                    else
                    {
                        return "Lansky";
                    }
                case 926:
                    if (Autor == false)
                    {
                        return "Láska je jediná vášeň, ktorá si platí mincami, ktoré sama vyrazila.";
                    }
                    else
                    {
                        return "Stendhal";
                    }
                case 927:
                    if (Autor == false)
                    {
                        return "Láska je túžba po kráse.";
                    }
                    else
                    {
                        return "Tasso";
                    }
                case 928:
                    if (Autor == false)
                    {
                        return "Láska môže umrieť na pravdu, priateľstvo na lož.";
                    }
                    else
                    {
                        return "P. Bonnard";
                    }
                case 929:
                    if (Autor == false)
                    {
                        return "Láska sa rodí z kombinácie rozumu s nerozumom.";
                    }
                    else
                    {
                        return "Achard";
                    }
                case 930:
                    if (Autor == false)
                    {
                        return "Láska zmyselná je láska, ktorá jedine má zmysel.";
                    }
                    else
                    {
                        return "Oldřich Fišer";
                    }
                case 931:
                    if (Autor == false)
                    {
                        return "Liečba sexu: Najlepšia liečba z aktívneho sexuálneho života je niekoľko rokov manželstva.";
                    }
                    else
                    {
                        return "Lansky";
                    }
                case 932:
                    if (Autor == false)
                    {
                        return "Žiadna lož nezostarne.";
                    }
                    else
                    {
                        return "Euripides";
                    }
                case 933:
                    if (Autor == false)
                    {
                        return "Žiadna pevnosť nie je taká pevná, aby ju peniaze nezdolali.";
                    }
                    else
                    {
                        return "Cicero";
                    }
                case 934:
                    if (Autor == false)
                    {
                        return "Žiadna pieseň nie je taká dlhá, aby jej nebolo konca.";
                    }
                    else
                    {
                        return "České príslovie";
                    }
                case 935:
                    if (Autor == false)
                    {
                        return "Žiadna žena sa nepovažuje za škaredú.";
                    }
                    else
                    {
                        return "Ovidius";
                    }
                case 936:
                    if (Autor == false)
                    {
                        return "Žiadny človek nie je taký múdry, aby vedel o všetkom zle, ktoré koná.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 937:
                    if (Autor == false)
                    {
                        return "Žiadny mladý človek si nepraje byť mladší.";
                    }
                    else
                    {
                        return "Jonathan Swift";
                    }
                case 938:
                    if (Autor == false)
                    {
                        return "Žiadny muž nie je dosť starý, aby na seba dával pozor.";
                    }
                    else
                    {
                        return "Browne";
                    }
                case 939:
                    if (Autor == false)
                    {
                        return "Žiadny muž nikdy presne nevie, prečo ho žena miluje.";
                    }
                    else
                    {
                        return "Erskine";
                    }
                case 940:
                    if (Autor == false)
                    {
                        return "Žiarlivosť je tieň nevery.";
                    }
                    else
                    {
                        return "Holandské príslovie";
                    }
                case 941:
                    if (Autor == false)
                    {
                        return "Žiarlivosť je štekanie psa, ktoré láka zlodeja.";
                    }
                    else
                    {
                        return "Kraus";
                    }
                case 942:
                    if (Autor == false)
                    {
                        return "Žena je budúcnosť muža.";
                    }
                    else
                    {
                        return "Sumerské príslovie";
                    }
                case 943:
                    if (Autor == false)
                    {
                        return "Žena je hádanka a dieťa rozuzlením.";
                    }
                    else
                    {
                        return "Victor Hugo";
                    }
                case 944:
                    if (Autor == false)
                    {
                        return "Žena je hodná milovania, nie lásky.";
                    }
                    else
                    {
                        return "Gaius Julius Caesar";
                    }
                case 945:
                    if (Autor == false)
                    {
                        return "Žena je muž, ktorý bol potrestaný.";
                    }
                    else
                    {
                        return "Platón";
                    }
                case 946:
                    if (Autor == false)
                    {
                        return "Žena je najdokonalejšie zo všetkých stvorení. Je prechodom od človeka k anjelovi.";
                    }
                    else
                    {
                        return "Honoré de Balzac";
                    }
                case 947:
                    if (Autor == false)
                    {
                        return "Žena je najprijateľnejším omylom prírody.";
                    }
                    else
                    {
                        return "John Milton";
                    }
                case 948:
                    if (Autor == false)
                    {
                        return "Idey sú na tom lepšie ako my - môžu vstať z mŕtvych.";
                    }
                    else
                    {
                        return "Kumor";
                    }
                case 949:
                    if (Autor == false)
                    {
                        return "Jediným zlým ťahom sa dá prehrať aj najlepšia partia.";
                    }
                    else
                    {
                        return "Čínske príslovie";
                    }
                case 950:
                    if (Autor == false)
                    {
                        return "Jedno z najväčších nešťastí civilizácie: hlupák - vzdelanec.";
                    }
                    else
                    {
                        return "Karel Čapek";
                    }
                case 951:
                    if (Autor == false)
                    {
                        return "Iba rany dávajú tvar veciam. Aj životu!";
                    }
                    else
                    {
                        return "Schulz";
                    }
                case 952:
                    if (Autor == false)
                    {
                        return "Každá práce celého človeka vyhľadáva.";
                    }
                    else
                    {
                        return "Jan Ámos Komenský";
                    }
                case 953:
                    if (Autor == false)
                    {
                        return "Každá prekážka umožní prejsť ďalší kus cesty.";
                    }
                    else
                    {
                        return "Albert Camus";
                    }
                case 954:
                    if (Autor == false)
                    {
                        return "Každá vojna skončí rokovaním. prečo teda nerokovať ihneď?";
                    }
                    else
                    {
                        return "Džáváharlál Nehrú";
                    }
                case 955:
                    if (Autor == false)
                    {
                        return "Každá žena má slabosť na hlupákov, pretože si myslí, že osprostel z lásky k nej.";
                    }
                    else
                    {
                        return "Jiří Žáček";
                    }
                case 956:
                    if (Autor == false)
                    {
                        return "Každý človek je zrodený pre druhého.";
                    }
                    else
                    {
                        return "Africké príslovie";
                    }
                case 957:
                    if (Autor == false)
                    {
                        return "Každý človek má tri charaktery - jeden, ktorý ukazuje, jeden, ktorý má, a jeden, ktorý si myslí, že má.";
                    }
                    else
                    {
                        return "Alphonsa Karr";
                    }
                case 958:
                    if (Autor == false)
                    {
                        return "Každý človek nosí v sebe hviezdu, a iba na ňom záleží, či bude dobrá alebo zlá.";
                    }
                    else
                    {
                        return "Baudoin";
                    }
                case 959:
                    if (Autor == false)
                    {
                        return "Každý človek viac alebo menej pociťuje potrebu stať sa iným človekom.";
                    }
                    else
                    {
                        return "Antoine de Saint-Exupéry";
                    }
                case 960:
                    if (Autor == false)
                    {
                        return "Každý človek, ktorému záleží len na jednej veci, je nebezpečný.";
                    }
                    else
                    {
                        return "G. K. Chesterton";
                    }
                case 961:
                    if (Autor == false)
                    {
                        return "Každý dar, i seba menší, je v skutočnosti veľký, ak bol daný s láskou.";
                    }
                    else
                    {
                        return "Pindaro";
                    }
                case 962:
                    if (Autor == false)
                    {
                        return "Každý dobre využitý okamih prináša ohromné úroky.";
                    }
                    else
                    {
                        return "Phillip Chesterfield";
                    }
                case 963:
                    if (Autor == false)
                    {
                        return "Iba malou vášňou plápolá, kto vysloviť ju môže.";
                    }
                    else
                    {
                        return "Francesco Petrarca";
                    }
                case 964:
                    if (Autor == false)
                    {
                        return "Každý génius má v sebe trocha šialenstva.";
                    }
                    else
                    {
                        return "Aristoteles";
                    }
                case 965:
                    if (Autor == false)
                    {
                        return "Každý hľadá v tom druhom svoju vlastnú podstatu.";
                    }
                    else
                    {
                        return "Fridrich Engels";
                    }
                case 966:
                    if (Autor == false)
                    {
                        return "Každý chce dlho žiť, ale nikto nechce byť starý.";
                    }
                    else
                    {
                        return "Jonathan Swift";
                    }
                case 967:
                    if (Autor == false)
                    {
                        return "Každý lekár má svoju obľúbenú chorobu.";
                    }
                    else
                    {
                        return "Fielding";
                    }
                case 968:
                    if (Autor == false)
                    {
                        return "Každý si určuje svoju cenu sám.";
                    }
                    else
                    {
                        return "Friedrich Schiller";
                    }
                case 969:
                    if (Autor == false)
                    {
                        return "Každý veľký čin sa zdá byť spočiatku nemožný.";
                    }
                    else
                    {
                        return "Thomas Carlyle";
                    }
                case 970:
                    if (Autor == false)
                    {
                        return "Každý veľký človek má veľa nepriateľov.";
                    }
                    else
                    {
                        return "Francois Villon";
                    }
                case 971:
                    if (Autor == false)
                    {
                        return "Každý z nás má v sebe celé storočia.";
                    }
                    else
                    {
                        return "Gris";
                    }
                case 972:
                    if (Autor == false)
                    {
                        return "Každý začiatok je ťažký.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 973:
                    if (Autor == false)
                    {
                        return "Kde hlupák, tam nie je bezpečne.";
                    }
                    else
                    {
                        return "Jan Werich";
                    }
                case 974:
                    if (Autor == false)
                    {
                        return "Kde by bola moc žien, keby muži neboli vzťahovační?";
                    }
                    else
                    {
                        return "Maria von Ebner-Eschenbachová";
                    }
                case 975:
                    if (Autor == false)
                    {
                        return "Kde človeka nepoznajú, berú ho podľa toho, ako vyzerá.";
                    }
                    else
                    {
                        return "Francúzske príslovie";
                    }
                case 976:
                    if (Autor == false)
                    {
                        return "Kde je málo úsmevu, tam je málo úspechu.";
                    }
                    else
                    {
                        return "Francúzske príslovie";
                    }
                case 977:
                    if (Autor == false)
                    {
                        return "Kde nie je poznanie minulosti, nemôže byť vízia budúcnosti.";
                    }
                    else
                    {
                        return "Sabatini";
                    }
                case 978:
                    if (Autor == false)
                    {
                        return "Chcel by som mať kvapku šťastia, alebo plný sud rozumu.";
                    }
                    else
                    {
                        return "Menandros";
                    }
                case 979:
                    if (Autor == false)
                    {
                        return "Chybu môže urobiť každý, ale len hlupák spraví rovnakú chybu dvakrát.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 980:
                    if (Autor == false)
                    {
                        return "Chyby sa dajú vždy prepáčiť, pokiaľ máš silu sa k nim priznať.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 981:
                    if (Autor == false)
                    {
                        return "Je nutné mať úctu ku slobode človeka, s ktorým žijeme.";
                    }
                    else
                    {
                        return "Černyševskij";
                    }
                case 982:
                    if (Autor == false)
                    {
                        return "Jediné, čoho sa bojím, je ľudská hlúposť a temnota mysle!";
                    }
                    else
                    {
                        return "Hérakles";
                    }
                case 983:
                    if (Autor == false)
                    {
                        return "Jediné, čomu nás naučí žena, je poznanie, akí sme hlúpi.";
                    }
                    else
                    {
                        return "Hruška";
                    }
                case 984:
                    if (Autor == false)
                    {
                        return "Jediné, čomu podľahneme viac ako žene, je únava.";
                    }
                    else
                    {
                        return "Hector Savien de Bergerac Cyrano";
                    }
                case 985:
                    if (Autor == false)
                    {
                        return "Kameň sa dá hodiť do vzduchu, a predsa mu krídla nenarastú.";
                    }
                    else
                    {
                        return "Friedrich Christian Hebbel";
                    }
                case 986:
                    if (Autor == false)
                    {
                        return "Každý si vyberá svoju zlatú strednú cestu.";
                    }
                    else
                    {
                        return "Q. Flaccus Horatius";
                    }
                case 987:
                    if (Autor == false)
                    {
                        return "Kde sa veľa pije, žere, tam otvára choroba dvere.";
                    }
                    else
                    {
                        return "Slovenské príslovie";
                    }
                case 988:
                    if (Autor == false)
                    {
                        return "Kde sa nudíme lepšie ako v kruhu rodiny?";
                    }
                    else
                    {
                        return "Oscar Wilde";
                    }
                case 989:
                    if (Autor == false)
                    {
                        return "Keby Boh neexistoval, musel by sa vymyslieť.";
                    }
                    else
                    {
                        return "Voltaire";
                    }
                case 990:
                    if (Autor == false)
                    {
                        return "Keby hlupákov nebolo, kde by sa brala múdrosť?";
                    }
                    else
                    {
                        return "Jan Ámos Komenský";
                    }
                case 991:
                    if (Autor == false)
                    {
                        return "Keby som si mohol vybrať, dal by som prednosť tichej múdrosti pred utáranou hlúposťou.";
                    }
                    else
                    {
                        return "Cicero";
                    }
                case 992:
                    if (Autor == false)
                    {
                        return "K písaniu sú potrebné tri veci: pero, atrament a rozum.";
                    }
                    else
                    {
                        return "Bengálske príslovie";
                    }
                case 993:
                    if (Autor == false)
                    {
                        return "K všetkému, čo je veľké, je prvým krokom odvaha.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 994:
                    if (Autor == false)
                    {
                        return "Každá myšlienka je pokus o rozlúštenie niektorej záhady.";
                    }
                    else
                    {
                        return "Otto František Babler";
                    }
                case 995:
                    if (Autor == false)
                    {
                        return "Každý človek je staviteľom chrámu, ktorým je jeho telo.";
                    }
                    else
                    {
                        return "H. D. Thoreau";
                    }
                case 996:
                    if (Autor == false)
                    {
                        return "Keby som mal posledných päť dolárov, tak tri z nich dám na reklamu.";
                    }
                    else
                    {
                        return "Henry Ford";
                    }
                case 997:
                    if (Autor == false)
                    {
                        return "Kedykoľvek chceš, si voľný ako vták.";
                    }
                    else
                    {
                        return "Charlie Chaplin";
                    }
                case 998:
                    if (Autor == false)
                    {
                        return "Keď dvaja robia to isté, nie je to to isté.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 999:
                    if (Autor == false)
                    {
                        return "Keď chceme chytiť za srdce, sú povolené všetky hmaty?";
                    }
                    else
                    {
                        return "Stanislav Jerzy Lec";
                    }
                case 1000:
                    if (Autor == false)
                    {
                        return "Keď chceš poznať ľudí, pozri sa na ich prácu.";
                    }
                    else
                    {
                        return "Friedrich Schiller";
                    }
                case 1001:
                    if (Autor == false)
                    {
                        return "Keď ide o peniaze, všetci ľudia sú rovnakého náboženstva.";
                    }
                    else
                    {
                        return "Voltaire";
                    }
                case 1002:
                    if (Autor == false)
                    {
                        return "Keď je konečne náš charakter dotvorený, začínajú nás bohužiaľ opúšťať sily.";
                    }
                    else
                    {
                        return "Seume";
                    }
                case 1003:
                    if (Autor == false)
                    {
                        return "Keď nájdeš cestu bez prekážok, určite nevedie nikam.";
                    }
                    else
                    {
                        return "N. Clark";
                    }
                case 1004:
                    if (Autor == false)
                    {
                        return "Keď nejde o sex, nejde o nič.";
                    }
                    else
                    {
                        return "Jan Werich";
                    }
                case 1005:
                    if (Autor == false)
                    {
                        return "Keď sa nám najviac chce, tak to najmenej ide.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 1006:
                    if (Autor == false)
                    {
                        return "Ak chodíš bez gombíkov na kabáte, musíš sa oženiť alebo rozviesť.";
                    }
                    else
                    {
                        return "Kirk Douglas";
                    }
                case 1007:
                    if (Autor == false)
                    {
                        return "Chovanie je zrkadlo, v ktorom každý ukazuje svoju povahu.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 1008:
                    if (Autor == false)
                    {
                        return "Chovaj sa k osobe druhého ako k účelu, nie ako k prostriedku.";
                    }
                    else
                    {
                        return "Immanuel Kant";
                    }
                case 1009:
                    if (Autor == false)
                    {
                        return "Chovaj sa ku svojim rodičom tak, ako chceš, aby sa k tebe chovali tvoje deti.";
                    }
                    else
                    {
                        return "Isokrates";
                    }
                case 1010:
                    if (Autor == false)
                    {
                        return "Ak chcú mať rodičia čestné deti, musí byť sami čestní.";
                    }
                    else
                    {
                        return "Plautus";
                    }
                case 1011:
                    if (Autor == false)
                    {
                        return "Chcel by som - to neznamená nič, chcem - to robí zázraky.";
                    }
                    else
                    {
                        return "A. Vinet";
                    }
                case 1012:
                    if (Autor == false)
                    {
                        return "Chcel ju vidieť tak, ako ju pánboh stvoril. keď sa mu podvolila, stratil vieru v božiu existenciu.";
                    }
                    else
                    {
                        return "Huptych";
                    }
                case 1013:
                    if (Autor == false)
                    {
                        return "Ideálna žena ostáva svojmu mužovi verná, ale jedná s ním tak nežne, ako keby ho podvádzala.";
                    }
                    else
                    {
                        return "Guitry";
                    }
                case 1014:
                    if (Autor == false)
                    {
                        return "Index životných nákladov: Oddelený život dvoch ľudí je takmer dvakrát drahší ako ich život spoločný.";
                    }
                    else
                    {
                        return "Lansky";
                    }
                case 1015:
                    if (Autor == false)
                    {
                        return "Intuícia je zvláštny inštinkt, ktorý žene hovorí, že má pravdu, či ju už má, alebo nemá.";
                    }
                    else
                    {
                        return "Elbert Hubbard";
                    }
                case 1016:
                    if (Autor == false)
                    {
                        return "Je dôležité nielen hovoriť, ale tiež počúvať. Na to neexistuje žiadne školenie.";
                    }
                    else
                    {
                        return "Iacocca";
                    }
                case 1017:
                    if (Autor == false)
                    {
                        return "Je dôležitejšie, ako človek osud prijíma, ako to, aký ten osud je.";
                    }
                    else
                    {
                        return "Humboldt";
                    }
                case 1018:
                    if (Autor == false)
                    {
                        return "Je možné milovať a nebyť pritom šťastný, je možné byť šťastný a nemilovať, ale milovať a byť pritom šťastný, to by bol zázrak.";
                    }
                    else
                    {
                        return "Honoré de Balzac";
                    }
                case 1019:
                    if (Autor == false)
                    {
                        return "Je nemožné druhý raz milovať to, čo sme milovať prestali.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 1020:
                    if (Autor == false)
                    {
                        return "Je nepredstaviteľné, koľko je nutné na svete vynaložiť dôvtipu, aby sme dokázali hlúposť.";
                    }
                    else
                    {
                        return "Friedrich Christian Hebbel";
                    }
                case 1021:
                    if (Autor == false)
                    {
                        return "Je nutné: povedať, o čom sa bude hovoriť, povedať, čo chcete oznámiť, zhrnúť, čo ste povedali.";
                    }
                    else
                    {
                        return "Iacocca";
                    }
                case 1022:
                    if (Autor == false)
                    {
                        return "Jeme, aby sme žili, nežijeme preto, aby sme jedli.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 1023:
                    if (Autor == false)
                    {
                        return "Je treba byť si trochu podobní, aby sme si rozumeli, ale trochu rozdielni, aby sme sa milovali. Áno, podobní, a predsa rozdielni.";
                    }
                    else
                    {
                        return "Jean Jacques Rousseau";
                    }
                case 1024:
                    if (Autor == false)
                    {
                        return "Treba často viac odvahy na to svoj názor zmeniť, ako za ním pevne stáť.";
                    }
                    else
                    {
                        return "Friedrich Christian Hebbel";
                    }
                case 1025:
                    if (Autor == false)
                    {
                        return "Iba málo slov znie tak pohŕdavo ako slovo manžel.";
                    }
                    else
                    {
                        return "Pitigrilli";
                    }
                case 1026:
                    if (Autor == false)
                    {
                        return "Iba ten je skutočný humanista, kto miluje ľudí aj vtedy, keď sa s nimi stretáva v preplnenej električke alebo autobuse.";
                    }
                    else
                    {
                        return "Krokodil";
                    }
                case 1027:
                    if (Autor == false)
                    {
                        return "Ak žena nemá pravdu, potom prvé, čo musíš urobiť, je okamžite jej odpustiť.";
                    }
                    else
                    {
                        return "Fresney";
                    }
                case 1028:
                    if (Autor == false)
                    {
                        return "Ak ste postavili vzdušný zámok, vaša práca nemusí byť zbytočná. Teraz k nemu urobte základy.";
                    }
                    else
                    {
                        return "H. D. Thoreau";
                    }
                case 1029:
                    if (Autor == false)
                    {
                        return "Chytené motýle a ulovené ryby nie sú dôležité, vzrušenie pramení z motýľov a rýb, ktoré nikdy nechytíme.";
                    }
                    else
                    {
                        return "Rossi";
                    }
                case 1030:
                    if (Autor == false)
                    {
                        return "Zlý človek predpokladá, že všetci ľudia sú mu podobní.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 1031:
                    if (Autor == false)
                    {
                        return "Zlý človek škodí sebe samému viac ako druhým.";
                    }
                    else
                    {
                        return "Svätý Augustín";
                    }
                case 1032:
                    if (Autor == false)
                    {
                        return "Zmeň vzťah k veciam, ktorej ťa znepokojujú, a budeš mať od nich pokoj.";
                    }
                    else
                    {
                        return "Marcus Aurelius";
                    }
                case 1033:
                    if (Autor == false)
                    {
                        return "Zmija vyzlieka kožu, ale srdce si necháva.";
                    }
                    else
                    {
                        return "Ázijské príslovie";
                    }
                case 1034:
                    if (Autor == false)
                    {
                        return "Poznali sa z videnia, ale po prvom dieťati skončilo aj to.";
                    }
                    else
                    {
                        return "Oseka";
                    }
                case 1035:
                    if (Autor == false)
                    {
                        return "Znalosť slov vedie ku znalosti vecí.";
                    }
                    else
                    {
                        return "Platón";
                    }
                case 1036:
                    if (Autor == false)
                    {
                        return "Poznám všetkých, iba seba nie.";
                    }
                    else
                    {
                        return "Francois Villon";
                    }
                case 1037:
                    if (Autor == false)
                    {
                        return "Poznať dokonale ticho znamená poznať hudbu.";
                    }
                    else
                    {
                        return "Sandburg";
                    }
                case 1038:
                    if (Autor == false)
                    {
                        return "Zvyčajne sú pôvabné veci vymyslené, holá pravda je nuda.";
                    }
                    else
                    {
                        return "John";
                    }
                case 1039:
                    if (Autor == false)
                    {
                        return "Ak stratí dievča hlavu, obyčajne sa s ňou opäť stretne v náručí nejakého muža.";
                    }
                    else
                    {
                        return "André Maurois";
                    }
                case 1040:
                    if (Autor == false)
                    {
                        return "Zvelič pravdu - dostaneš hlúposť.";
                    }
                    else
                    {
                        return "Vladimír Iljič Lenin";
                    }
                case 1041:
                    if (Autor == false)
                    {
                        return "Zvyk skrotí aj divokú bolesť.";
                    }
                    else
                    {
                        return "William Shakespeare";
                    }
                case 1042:
                    if (Autor == false)
                    {
                        return "Žiadny omyl nie je tak veľký, aby nemal svojich priaznivcov.";
                    }
                    else
                    {
                        return "Martin Luther";
                    }
                case 1043:
                    if (Autor == false)
                    {
                        return "Žiadny otec a matka nepovažujú svoje deti za škaredé.";
                    }
                    else
                    {
                        return "Miguel de Cervantes";
                    }
                case 1044:
                    if (Autor == false)
                    {
                        return "Žiadny svätý nie je taký malý, aby nechcel sviečku.";
                    }
                    else
                    {
                        return "Dánske príslovie";
                    }
                case 1045:
                    if (Autor == false)
                    {
                        return "Žiadny učenec z neba nespadol, ale hlupákov ako by zhadzovali.";
                    }
                    else
                    {
                        return "Julian Tuwim";
                    }
                case 1046:
                    if (Autor == false)
                    {
                        return "Žiadny veľký duch nie je bez trošky bláznovstva.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 1047:
                    if (Autor == false)
                    {
                        return "Žiadny zlý človek nie je šťastný.";
                    }
                    else
                    {
                        return "Juvenal";
                    }
                case 1048:
                    if (Autor == false)
                    {
                        return "Žiarlivý človek je mučeník, ktorý robí mučeníkov z druhých.";
                    }
                    else
                    {
                        return "C. Diane";
                    }
                case 1049:
                    if (Autor == false)
                    {
                        return "Žena je zázrak boží. Zvlášť, ak má v tele diabla.";
                    }
                    else
                    {
                        return "Allais";
                    }
                case 1050:
                    if (Autor == false)
                    {
                        return "Žena bez poprsia, to je posteľ bez perín.";
                    }
                    else
                    {
                        return "France";
                    }
                case 1051:
                    if (Autor == false)
                    {
                        return "Žena buď miluje, alebo nenávidí, nič iné.";
                    }
                    else
                    {
                        return "Publilius";
                    }
                case 1052:
                    if (Autor == false)
                    {
                        return "Žena miluje na mužovi skôr to, čo nie je, ako to čo je.";
                    }
                    else
                    {
                        return "Asturias";
                    }
                case 1053:
                    if (Autor == false)
                    {
                        return "Žena, ktorá sa oddáva mnohým, sa mnohým nepáči.";
                    }
                    else
                    {
                        return "Publilius";
                    }
                case 1054:
                    if (Autor == false)
                    {
                        return "Žena, ktorá sa zdobí, si plní len svoju povinnosť.";
                    }
                    else
                    {
                        return "E. Renan";
                    }
                case 1055:
                    if (Autor == false)
                    {
                        return "Ženatí muži žijú dlhšie - alebo sa im to aspoň tak zdá.";
                    }
                    else
                    {
                        return "Nestroy";
                    }
                case 1056:
                    if (Autor == false)
                    {
                        return "Ženatý muž môže robiť, čo sa mu zachce, v prípade že jeho manželka nič proti tomu nenamieta. Naproti tomu, vdovec nemôže byť nikdy dosť opatrný.";
                    }
                    else
                    {
                        return "George Bernard Shaw";
                    }
                case 1057:
                    if (Autor == false)
                    {
                        return "Pre ženu je úplne nepochopiteľné, ako ju môže niekto nemilovať.";
                    }
                    else
                    {
                        return "W. S. Maugham";
                    }
                case 1058:
                    if (Autor == false)
                    {
                        return "Ženy nemajú zmysel pre nezmysel.";
                    }
                    else
                    {
                        return "Jan Werich";
                    }
                case 1059:
                    if (Autor == false)
                    {
                        return "Ženský jazyk môže mlčať len o tom, o čom nevie.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 1060:
                    if (Autor == false)
                    {
                        return "Ženy hrajú málo šachy, lebo sa boja že prídu o figúru.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 1061:
                    if (Autor == false)
                    {
                        return "Ženy chcú, aby si mal rozum len preto, aby ťa o neho mohli pripraviť.";
                    }
                    else
                    {
                        return "Jiří Žáček";
                    }
                case 1062:
                    if (Autor == false)
                    {
                        return "Ženy majú radi prosté a jednoduché veci - napríklad mužov.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 1063:
                    if (Autor == false)
                    {
                        return "Ženy nás už donútia, aby sme boli šťastní.";
                    }
                    else
                    {
                        return "Jiří Žáček";
                    }
                case 1064:
                    if (Autor == false)
                    {
                        return "Život je choroba smrteľná a veľmi nákazlivá.";
                    }
                    else
                    {
                        return "Oscar Wilde";
                    }
                case 1065:
                    if (Autor == false)
                    {
                        return "Život sa dá prežiť v jednom dni. Ale čo s tým zvyšným časom?";
                    }
                    else
                    {
                        return "Stanislav Jerzy Lec";
                    }
                case 1066:
                    if (Autor == false)
                    {
                        return "Život meriame skutkami a nie časom.";
                    }
                    else
                    {
                        return "Seneca";
                    }
                case 1067:
                    if (Autor == false)
                    {
                        return "Život nie je to, čo chceme, ale to čo máme.";
                    }
                    else
                    {
                        return "Lustig";
                    }
                case 1068:
                    if (Autor == false)
                    {
                        return "Život si nekúpi nikto, ale užívať si ho môže každý.";
                    }
                    else
                    {
                        return "Lucretius";
                    }
                case 1069:
                    if (Autor == false)
                    {
                        return "Žiť znamená snívať.";
                    }
                    else
                    {
                        return "Friedrich Schiller";
                    }
                case 1070:
                    if (Autor == false)
                    {
                        return "Životom vládne šťastena, nie múdrosť.";
                    }
                    else
                    {
                        return "Cicero";
                    }
                case 1071:
                    if (Autor == false)
                    {
                        return "Je prirodzené, keď syn občas nenávidí otca, matku tiež a niekedy i všetkých ostatných ľudí na celom svete.";
                    }
                    else
                    {
                        return "William Saroyan";
                    }
                case 1072:
                    if (Autor == false)
                    {
                        return "Je určite slabosť ukazovať niekomu, že nás strata bolí.";
                    }
                    else
                    {
                        return "Moliere";
                    }
                case 1073:
                    if (Autor == false)
                    {
                        return "Je potrebné životu viac dávať, ako ho urýchľovať.";
                    }
                    else
                    {
                        return "Mahátma Gándhí";
                    }
                case 1074:
                    if (Autor == false)
                    {
                        return "Jeden blázon je zábava, ale väčšina bláznov príde draho.";
                    }
                    else
                    {
                        return "Pirandello";
                    }
                case 1075:
                    if (Autor == false)
                    {
                        return "Jeden deň učí druhý.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 1076:
                    if (Autor == false)
                    {
                        return "Jediné slovo niekedy stačí na to, aby vybudovalo alebo zničilo šťastie.";
                    }
                    else
                    {
                        return "Sofokles";
                    }
                case 1077:
                    if (Autor == false)
                    {
                        return "Jedinými víťazmi pri rozvode sú advokáti. Dôsledok: Slovo nestojí nič. Ak ho neprednesie tvoj advokát pri rozvode.";
                    }
                    else
                    {
                        return "Lansky";
                    }
                case 1078:
                    if (Autor == false)
                    {
                        return "Jedna hádka so ženou ma stojí viac energie ako päť tlačových konferencií.";
                    }
                    else
                    {
                        return "Charles de Gaulle";
                    }
                case 1079:
                    if (Autor == false)
                    {
                        return "Jedni slúžia sláve a druhí peniazom.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 1080:
                    if (Autor == false)
                    {
                        return "Každá práce, vykonávaná čestne, je užitočná a zasluhuje si preto uznanie.";
                    }
                    else
                    {
                        return "Stendhal";
                    }
                case 1081:
                    if (Autor == false)
                    {
                        return "Každému je daná reč, iba niektorým múdrosť.";
                    }
                    else
                    {
                        return "Cato";
                    }
                case 1082:
                    if (Autor == false)
                    {
                        return "Každý človek má dve výchovy: jednu, ktorú dostáva od iných, a druhú, dôležitejšiu, ktorú si dáva sám.";
                    }
                    else
                    {
                        return "Edward Gibbon";
                    }
                case 1083:
                    if (Autor == false)
                    {
                        return "Každý človek má tri charaktery: ten, ktorý mu pripisujú, ten, ktorý si pripisuje on sám, a konečne ten, ktorý naozaj má.";
                    }
                    else
                    {
                        return "Victor Hugo";
                    }
                case 1084:
                    if (Autor == false)
                    {
                        return "Každý sa sťažuje na svoju pamäť, ale nikto na svoj rozum.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 1085:
                    if (Autor == false)
                    {
                        return "Každý si určuje svoju cenu sám.";
                    }
                    else
                    {
                        return "Friedrich Schiller";
                    }
                case 1086:
                    if (Autor == false)
                    {
                        return "Každý z nás dosť presne vie, čo je to výprask. Ale čo je to láska, to nikto stále nevie.";
                    }
                    else
                    {
                        return "Heinrich Heine";
                    }
                case 1087:
                    if (Autor == false)
                    {
                        return "Kde bol predtým oheň, tam nájdeme žeravé uhlíky.";
                    }
                    else
                    {
                        return "Francúzske príslovie";
                    }
                case 1088:
                    if (Autor == false)
                    {
                        return "Kde je uzatvorené manželstvo bez lásky, vznikne čoskoro láska bez manželstva.";
                    }
                    else
                    {
                        return "Benjamin Franklin";
                    }
                case 1089:
                    if (Autor == false)
                    {
                        return "Kde sa dvaja bijú, tam má tretí šancu byť odsúdený za krivú výpoveď.";
                    }
                    else
                    {
                        return "sir Alfred Hitchcock";
                    }
                case 1090:
                    if (Autor == false)
                    {
                        return "Keby sa múdri nemýlili, boli by hlupáci zúfalí.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 1091:
                    if (Autor == false)
                    {
                        return "Len raz je človek nenahraditeľný - na svojom vlastnom pohrebe.";
                    }
                    else
                    {
                        return "Oldřich Fišer";
                    }
                case 1092:
                    if (Autor == false)
                    {
                        return "Len keď obetujeme hlavu, dobyjeme srdce.";
                    }
                    else
                    {
                        return "Turecké príslovie";
                    }
                case 1093:
                    if (Autor == false)
                    {
                        return "Len muži, ktorí si myslia, že ženy sú rovnaké, sú všetci rovnakí.";
                    }
                    else
                    {
                        return "Pristley";
                    }
                case 1094:
                    if (Autor == false)
                    {
                        return "Len to, čomu sami veríme, nám ostatní uveria.";
                    }
                    else
                    {
                        return "Karl Gutzkow";
                    }
                case 1095:
                    if (Autor == false)
                    {
                        return "Láskavosťou môžeš dokázať to, čo nedokážeš silou.";
                    }
                    else
                    {
                        return "Publius Syrus";
                    }
                case 1096:
                    if (Autor == false)
                    {
                        return "Veľa múdreho pochádza už aj od žien.";
                    }
                    else
                    {
                        return "Euripides";
                    }
                case 1097:
                    if (Autor == false)
                    {
                        return "Ľahko sa mlčí, keď človek nič nevie.";
                    }
                    else
                    {
                        return "Alois Jirásek";
                    }
                case 1098:
                    if (Autor == false)
                    {
                        return "Ľahko je byť otvorený, keď nechceme povedať celú pravdu.";
                    }
                    else
                    {
                        return "Rabíndranáth Thákur";
                    }
                case 1099:
                    if (Autor == false)
                    {
                        return "Lekár musí byť zodpovedný aj za to, čo mu pacient nepovie.";
                    }
                    else
                    {
                        return "Hippokrates";
                    }
                case 1100:
                    if (Autor == false)
                    {
                        return "Lenivec je ten, kto nepredstiera že pracuje.";
                    }
                    else
                    {
                        return "Allais";
                    }
                case 1101:
                    if (Autor == false)
                    {
                        return "Lenivosť je strach pred blížiacou sa prácou.";
                    }
                    else
                    {
                        return "Cicero";
                    }
                case 1102:
                    if (Autor == false)
                    {
                        return "Lenivci chcú stále niečo vykonať.";
                    }
                    else
                    {
                        return "Luc de Vauvenargues";
                    }
                case 1103:
                    if (Autor == false)
                    {
                        return "Lepšie je byť smutný s láskou ako veselý bez nej.";
                    }
                    else
                    {
                        return "Johann Wolfgang von Goethe";
                    }
                case 1104:
                    if (Autor == false)
                    {
                        return "Lepšie je nemať ako stratiť.";
                    }
                    else
                    {
                        return "Friedrich Christian Hebbel";
                    }
                case 1105:
                    if (Autor == false)
                    {
                        return "Lepšie je svoj kríž si niesť, ako ho vliecť po zemi.";
                    }
                    else
                    {
                        return "Bretónske príslovie";
                    }
                case 1106:
                    if (Autor == false)
                    {
                        return "Lepšie neskoro ako nikdy.";
                    }
                    else
                    {
                        return "Príslovie";
                    }
                case 1107:
                    if (Autor == false)
                    {
                        return "Lepši dobrý príklad ako Písma výklad.";
                    }
                    else
                    {
                        return "Slovenské príslovie";
                    }
                case 1108:
                    if (Autor == false)
                    {
                        return "Lepší múdry blázon, ako bláznivý mudrc.";
                    }
                    else
                    {
                        return "William Shakespeare";
                    }
                case 1109:
                    if (Autor == false)
                    {
                        return "Lepší nudný priateľ ako príliš zábavná priateľka.";
                    }
                    else
                    {
                        return "Francois De La Rochefoucauld";
                    }
                case 1110:
                    if (Autor == false)
                    {
                        return "Klamárovi neveríme ani vtedy, keď hovorí pravdu.";
                    }
                    else
                    {
                        return "Cicero";
                    }
                case 1111:
                    if (Autor == false)
                    {
                        return "Liana sa vyšplhá vysoko len s pomocou stromu.";
                    }
                    else
                    {
                        return "Vietnamské príslovie";
                    }
                case 1112:
                    if (Autor == false)
                    {
                        return "Ľudia častejšie lichotia, ako chvália.";
                    }
                    else
                    {
                        return "Jean Paul";
                    }
                case 1113:
                    if (Autor == false)
                    {
                        return "Ľudia, ktorí príliš žijú, netvoria.";
                    }
                    else
                    {
                        return "Thomas Mann";
                    }
                case 1114:
                    if (Autor == false)
                    {
                        return "Ľudia, staňte sa už dospelými.";
                    }
                    else
                    {
                        return "Albert Einstein";
                    }

            }
        }

        public int NahodneCisloVyroku()
        {
            Random random = new Random();
            return random.Next(1, 1114);
        }

        public void ShowMyInfoToolTip(int x, int y, System.Windows.Forms.IWin32Window writethis)
        {
            int i = NahodneCisloVyroku();

           string s = "-- " + Vyrok(i, true) + "\r\n" + Vyrok(i, false) + "\r\n\r\n";
           s += "Štátny geologický ústav Dionýza Štúra, Geoanalytické laboratóriá Spišská Nová Ves\r\n";
	        s += "sampleX - Copyright © 2021 Róbert Repka. Všetky práva vyhradené.";
//            s += "\r\nLicencia pre ";
//            s += RRvar.sRegisteredName + "\r\n";
//            s += "Platí do " + RRcode.LicenceEnd().ToString();
//	      s += "\r\nsampleX - Copyright © 2021 Róbert Repka. Všetky práva vyhradené.";
            ToolTip mytoolTip = new ToolTip();
            mytoolTip.ShowAlways = true; // to force it
            mytoolTip.Show(s, writethis, x, y, 10000);
            Application.DoEvents();
        }

        public void ShowMyInfoToolTipWithMyText(string MyText, int x, int y, System.Windows.Forms.IWin32Window writethis)
        {
            int i = NahodneCisloVyroku();
            string s = MyText;
            ToolTip mytoolTip = new ToolTip();
            mytoolTip.ShowAlways = true; // to force it
            mytoolTip.Show(s, writethis, x, y, 3000);
            Application.DoEvents();
        }

        public string MenoDna(DateTime dt)
        {
            if (dt.DayOfWeek.ToString() == "Monday")
                return "Pon";
            if (dt.DayOfWeek.ToString() == "Tuesday")
                return "Uto";
            if (dt.DayOfWeek.ToString() == "Wednesday")
                return "Str";
            if (dt.DayOfWeek.ToString() == "Thursday")
                return "Štv";
            if (dt.DayOfWeek.ToString() == "Friday")
                return "Pia";
            if (dt.DayOfWeek.ToString() == "Saturday")
                return "Sob";
            if (dt.DayOfWeek.ToString() == "Sunday")
                return "Ned";
            return "";
        }

        public string MenoDnaCele(DateTime dt)
        {
            if (dt.DayOfWeek.ToString() == "Monday")
                return "Pondelok";
            if (dt.DayOfWeek.ToString() == "Tuesday")
                return "Utorok";
            if (dt.DayOfWeek.ToString() == "Wednesday")
                return "Streda";
            if (dt.DayOfWeek.ToString() == "Thursday")
                return "Štvrtok";
            if (dt.DayOfWeek.ToString() == "Friday")
                return "Piatok";
            if (dt.DayOfWeek.ToString() == "Saturday")
                return "Sobota";
            if (dt.DayOfWeek.ToString() == "Sunday")
                return "Nedeľa";
            return "";
        }

        public string MenoMesiaca(DateTime dt)
        {

            if (dt.ToString("MM") == "01")
                return "Jan";
            if (dt.ToString("MM") == "02")
                return "Feb";
            if (dt.ToString("MM") == "03")
                return "Mar";
            if (dt.ToString("MM") == "04")
                return "Apr";
            if (dt.ToString("MM") == "05")
                return "Máj";
            if (dt.ToString("MM") == "06")
                return "Jún";
            if (dt.ToString("MM") == "07")
                return "Júl";
            if (dt.ToString("MM") == "08")
                return "Aug";
            if (dt.ToString("MM") == "09")
                return "Sep";
            if (dt.ToString("MM") == "10")
                return "Okt";
            if (dt.ToString("MM") == "11")
                return "Nov";
            if (dt.ToString("MM") == "12")
                return "Dec";

            return "";
        }

        public string MenoMesiacaCele(DateTime dt)
        {

            if (dt.ToString("MM") == "01")
                return "Január";
            if (dt.ToString("MM") == "02")
                return "Február";
            if (dt.ToString("MM") == "03")
                return "Marec";
            if (dt.ToString("MM") == "04")
                return "Apríl";
            if (dt.ToString("MM") == "05")
                return "Máj";
            if (dt.ToString("MM") == "06")
                return "Jún";
            if (dt.ToString("MM") == "07")
                return "Júl";
            if (dt.ToString("MM") == "08")
                return "August";
            if (dt.ToString("MM") == "09")
                return "September";
            if (dt.ToString("MM") == "10")
                return "Október";
            if (dt.ToString("MM") == "11")
                return "November";
            if (dt.ToString("MM") == "12")
                return "December";

            return "";
        }

        public string MeninyMa(string datumMMDD)
        {
            if (datumMMDD == "0101")
                return "Nový Rok";
            if (datumMMDD == "0102")
                return "Alexandra, Karina";
            if (datumMMDD == "0103")
                return "Daniela";
            if (datumMMDD == "0104")
                return "Drahoslav";
            if (datumMMDD == "0105")
                return "Andrea";
            if (datumMMDD == "0106")
                return "Antónia, 3 králi";
            if (datumMMDD == "0107")
                return "Bohuslava";
            if (datumMMDD == "0108")
                return "Severín";
            if (datumMMDD == "0109")
                return "Alexej";
            if (datumMMDD == "0110")
                return "Dáša";
            if (datumMMDD == "0111")
                return "Malvína";
            if (datumMMDD == "0112")
                return "Ernest";
            if (datumMMDD == "0113")
                return "Rastislav";
            if (datumMMDD == "0114")
                return "Radovan";
            if (datumMMDD == "0115")
                return "Dobroslav";
            if (datumMMDD == "0116")
                return "Kristína";
            if (datumMMDD == "0117")
                return "Nataša";
            if (datumMMDD == "0118")
                return "Bohdana";
            if (datumMMDD == "0119")
                return "Drahomíra, Mário";
            if (datumMMDD == "0120")
                return "Dalibor";
            if (datumMMDD == "0121")
                return "Vincent";
            if (datumMMDD == "0122")
                return "Zora";
            if (datumMMDD == "0123")
                return "Miloš";
            if (datumMMDD == "0124")
                return "Timotej";
            if (datumMMDD == "0125")
                return "Gejza";
            if (datumMMDD == "0126")
                return "Tamara";
            if (datumMMDD == "0127")
                return "Bohuš";
            if (datumMMDD == "0128")
                return "Alfonz";
            if (datumMMDD == "0129")
                return "Gašpar";
            if (datumMMDD == "0130")
                return "Ema";
            if (datumMMDD == "0131")
                return "Emil";
            if (datumMMDD == "0201")
                return "Tatiana";
            if (datumMMDD == "0202")
                return "Erika, Erik";
            if (datumMMDD == "0203")
                return "Blažej";
            if (datumMMDD == "0204")
                return "Veronika";
            if (datumMMDD == "0205")
                return "Agáta";
            if (datumMMDD == "0206")
                return "Dorota";
            if (datumMMDD == "0207")
                return "Vanda";
            if (datumMMDD == "0208")
                return "Zoja";
            if (datumMMDD == "0209")
                return "Zdenko";
            if (datumMMDD == "0210")
                return "Gabriela";
            if (datumMMDD == "0211")
                return "Dezider";
            if (datumMMDD == "0212")
                return "Perla";
            if (datumMMDD == "0213")
                return "Arpád";
            if (datumMMDD == "0214")
                return "Valentín";
            if (datumMMDD == "0215")
                return "Pravoslav";
            if (datumMMDD == "0216")
                return "Ida, Liana";
            if (datumMMDD == "0217")
                return "Miloslava";
            if (datumMMDD == "0218")
                return "Jaromír";
            if (datumMMDD == "0219")
                return "Vlasta";
            if (datumMMDD == "0220")
                return "Lívia";
            if (datumMMDD == "0221")
                return "Eleonóra";
            if (datumMMDD == "0222")
                return "Etela";
            if (datumMMDD == "0223")
                return "Roman, Romana";
            if (datumMMDD == "0224")
                return "Matej";
            if (datumMMDD == "0225")
                return "Frederik, Frederi";
            if (datumMMDD == "0226")
                return "Viktor";
            if (datumMMDD == "0227")
                return "Alexander";
            if (datumMMDD == "0228")
                return "Zlatica";
            if (datumMMDD == "0229")
                return "Radomír";
            if (datumMMDD == "0301")
                return "Albín";
            if (datumMMDD == "0302")
                return "Anežka";
            if (datumMMDD == "0303")
                return "Bohumil, Bohumila";
            if (datumMMDD == "0304")
                return "Kazimír";
            if (datumMMDD == "0305")
                return "Fridrich";
            if (datumMMDD == "0306")
                return "Radoslav, Radoslava";
            if (datumMMDD == "0307")
                return "Tomáš";
            if (datumMMDD == "0308")
                return "Alan, Alana";
            if (datumMMDD == "0309")
                return "Františka";
            if (datumMMDD == "0310")
                return "Branislav, Bruno";
            if (datumMMDD == "0311")
                return "Angela, Angelika";
            if (datumMMDD == "0312")
                return "Gregor";
            if (datumMMDD == "0313")
                return "Vlastimil";
            if (datumMMDD == "0314")
                return "Matilda";
            if (datumMMDD == "0315")
                return "Svetlana";
            if (datumMMDD == "0316")
                return "Boleslav";
            if (datumMMDD == "0317")
                return "Ľubica";
            if (datumMMDD == "0318")
                return "Eduard";
            if (datumMMDD == "0319")
                return "Jozef";
            if (datumMMDD == "0320")
                return "Viťazoslav, Klaudius";
            if (datumMMDD == "0321")
                return "Blahoslav";
            if (datumMMDD == "0322")
                return "Beňadik";
            if (datumMMDD == "0323")
                return "Adrian";
            if (datumMMDD == "0324")
                return "Gabriel";
            if (datumMMDD == "0325")
                return "Marián";
            if (datumMMDD == "0326")
                return "Emanuel";
            if (datumMMDD == "0327")
                return "Alena";
            if (datumMMDD == "0328")
                return "Soňa";
            if (datumMMDD == "0329")
                return "Miroslava";
            if (datumMMDD == "0330")
                return "Vieroslava";
            if (datumMMDD == "0331")
                return "Benjamín";
            if (datumMMDD == "0401")
                return "Hugo";
            if (datumMMDD == "0402")
                return "Zita";
            if (datumMMDD == "0403")
                return "Richard";
            if (datumMMDD == "0404")
                return "Izidor";
            if (datumMMDD == "0405")
                return "Miroslava";
            if (datumMMDD == "0406")
                return "Irena";
            if (datumMMDD == "0407")
                return "Zoltán";
            if (datumMMDD == "0408")
                return "Albert";
            if (datumMMDD == "0409")
                return "Milena";
            if (datumMMDD == "0410")
                return "Igor";
            if (datumMMDD == "0411")
                return "Július";
            if (datumMMDD == "0412")
                return "Estera";
            if (datumMMDD == "0413")
                return "Aleš";
            if (datumMMDD == "0414")
                return "Justína";
            if (datumMMDD == "0415")
                return "Fedor";
            if (datumMMDD == "0416")
                return "Dana, Danica";
            if (datumMMDD == "0417")
                return "Rudolf";
            if (datumMMDD == "0418")
                return "Valér";
            if (datumMMDD == "0419")
                return "Jela";
            if (datumMMDD == "0420")
                return "Marcel";
            if (datumMMDD == "0421")
                return "Ervín";
            if (datumMMDD == "0422")
                return "Slavomír";
            if (datumMMDD == "0423")
                return "Vojtech";
            if (datumMMDD == "0424")
                return "Juraj";
            if (datumMMDD == "0425")
                return "Marek";
            if (datumMMDD == "0426")
                return "Jaroslava";
            if (datumMMDD == "0427")
                return "Jaroslav";
            if (datumMMDD == "0428")
                return "Jarmila";
            if (datumMMDD == "0429")
                return "Lea";
            if (datumMMDD == "0430")
                return "Anastázia";
            if (datumMMDD == "0501")
                return "sviatok práce";
            if (datumMMDD == "0502")
                return "Žigmund";
            if (datumMMDD == "0503")
                return "Galina";
            if (datumMMDD == "0504")
                return "Florián";
            if (datumMMDD == "0505")
                return "Lesana, Lesia";
            if (datumMMDD == "0506")
                return "Hermína";
            if (datumMMDD == "0507")
                return "Monika";
            if (datumMMDD == "0508")
                return "Ingrida";
            if (datumMMDD == "0509")
                return "Roland";
            if (datumMMDD == "0510")
                return "Viktória";
            if (datumMMDD == "0511")
                return "Blažena";
            if (datumMMDD == "0512")
                return "Pankrác";
            if (datumMMDD == "0513")
                return "Servác";
            if (datumMMDD == "0514")
                return "Bonifác";
            if (datumMMDD == "0515")
                return "Žofia";
            if (datumMMDD == "0516")
                return "Svetozár";
            if (datumMMDD == "0517")
                return "Gizela";
            if (datumMMDD == "0518")
                return "Viola";
            if (datumMMDD == "0519")
                return "Gertrúda";
            if (datumMMDD == "0520")
                return "Bernard";
            if (datumMMDD == "0521")
                return "Zina";
            if (datumMMDD == "0522")
                return "Júlia, Juliana";
            if (datumMMDD == "0523")
                return "Želmíra";
            if (datumMMDD == "0524")
                return "Ela";
            if (datumMMDD == "0525")
                return "Urban";
            if (datumMMDD == "0526")
                return "Dušan";
            if (datumMMDD == "0527")
                return "Iveta";
            if (datumMMDD == "0528")
                return "Viliam";
            if (datumMMDD == "0529")
                return "Vilma";
            if (datumMMDD == "0530")
                return "Ferdinand";
            if (datumMMDD == "0531")
                return "Petronela, Petran";
            if (datumMMDD == "0601")
                return "Žaneta";
            if (datumMMDD == "0602")
                return "Xénia, Oxana";
            if (datumMMDD == "0603")
                return "Karolína";
            if (datumMMDD == "0604")
                return "Lenka";
            if (datumMMDD == "0605")
                return "Laura";
            if (datumMMDD == "0606")
                return "Norbert";
            if (datumMMDD == "0607")
                return "Róbert";
            if (datumMMDD == "0608")
                return "Medard";
            if (datumMMDD == "0609")
                return "Stanislava";
            if (datumMMDD == "0610")
                return "Margaréta";
            if (datumMMDD == "0611")
                return "Dobroslava";
            if (datumMMDD == "0612")
                return "Zlatko";
            if (datumMMDD == "0613")
                return "Anton";
            if (datumMMDD == "0614")
                return "Vasil";
            if (datumMMDD == "0615")
                return "Vít";
            if (datumMMDD == "0616")
                return "Blanka, Bianka";
            if (datumMMDD == "0617")
                return "Adolf";
            if (datumMMDD == "0618")
                return "Vratislav";
            if (datumMMDD == "0619")
                return "Alfred";
            if (datumMMDD == "0620")
                return "Valéria";
            if (datumMMDD == "0621")
                return "Alojz";
            if (datumMMDD == "0622")
                return "Paulína";
            if (datumMMDD == "0623")
                return "Sidónia";
            if (datumMMDD == "0624")
                return "Ján";
            if (datumMMDD == "0625")
                return "Tadeáš, Olívia";
            if (datumMMDD == "0626")
                return "Adriana";
            if (datumMMDD == "0627")
                return "Ladislav, Ladisla";
            if (datumMMDD == "0628")
                return "Beáta";
            if (datumMMDD == "0629")
                return "Peter a Pavol, Pe";
            if (datumMMDD == "0630")
                return "Melánia";
            if (datumMMDD == "0701")
                return "Diana";
            if (datumMMDD == "0702")
                return "Berta";
            if (datumMMDD == "0703")
                return "Miloslav";
            if (datumMMDD == "0704")
                return "Prokop";
            if (datumMMDD == "0705")
                return "Cyril a Metod";
            if (datumMMDD == "0706")
                return "Patrícia, Patrik";
            if (datumMMDD == "0707")
                return "Oliver";
            if (datumMMDD == "0708")
                return "Ivan";
            if (datumMMDD == "0709")
                return "Lujza";
            if (datumMMDD == "0710")
                return "Amália";
            if (datumMMDD == "0711")
                return "Milota";
            if (datumMMDD == "0712")
                return "Nina";
            if (datumMMDD == "0713")
                return "Margita";
            if (datumMMDD == "0714")
                return "Kamil";
            if (datumMMDD == "0715")
                return "Henrich";
            if (datumMMDD == "0716")
                return "Drahomir";
            if (datumMMDD == "0717")
                return "Bohuslav";
            if (datumMMDD == "0718")
                return "Kamila";
            if (datumMMDD == "0719")
                return "Dušana";
            if (datumMMDD == "0720")
                return "Iľja, Eliáš";
            if (datumMMDD == "0721")
                return "Daniel";
            if (datumMMDD == "0722")
                return "Magdaléna";
            if (datumMMDD == "0723")
                return "Oľga";
            if (datumMMDD == "0724")
                return "Vladimír";
            if (datumMMDD == "0725")
                return "Jakub";
            if (datumMMDD == "0726")
                return "Anna, Hana";
            if (datumMMDD == "0727")
                return "Božena";
            if (datumMMDD == "0728")
                return "Krištof";
            if (datumMMDD == "0729")
                return "Marta";
            if (datumMMDD == "0730")
                return "Libuša";
            if (datumMMDD == "0731")
                return "Ignác";
            if (datumMMDD == "0801")
                return "Božidara";
            if (datumMMDD == "0802")
                return "Gustáv";
            if (datumMMDD == "0803")
                return "Jerguš";
            if (datumMMDD == "0804")
                return "Dominik, Dominika";
            if (datumMMDD == "0805")
                return "Hortenzia";
            if (datumMMDD == "0806")
                return "Jozefína";
            if (datumMMDD == "0807")
                return "Štefánia";
            if (datumMMDD == "0808")
                return "Oskar";
            if (datumMMDD == "0809")
                return "Ľubomíra";
            if (datumMMDD == "0810")
                return "Vavrinec";
            if (datumMMDD == "0811")
                return "Zuzana";
            if (datumMMDD == "0812")
                return "Darina";
            if (datumMMDD == "0813")
                return "Ľubomir";
            if (datumMMDD == "0814")
                return "Mojmír";
            if (datumMMDD == "0815")
                return "Marcela";
            if (datumMMDD == "0816")
                return "Leonard";
            if (datumMMDD == "0817")
                return "Milica";
            if (datumMMDD == "0818")
                return "Elena, Helena";
            if (datumMMDD == "0819")
                return "Lýdia";
            if (datumMMDD == "0820")
                return "Anabela";
            if (datumMMDD == "0821")
                return "Jana";
            if (datumMMDD == "0822")
                return "Tichomír";
            if (datumMMDD == "0823")
                return "Filip";
            if (datumMMDD == "0824")
                return "Bartolomej";
            if (datumMMDD == "0825")
                return "Ľudovít";
            if (datumMMDD == "0826")
                return "Samuel";
            if (datumMMDD == "0827")
                return "Silvia";
            if (datumMMDD == "0828")
                return "Augustín";
            if (datumMMDD == "0829")
                return "Nikola";
            if (datumMMDD == "0830")
                return "Ružena";
            if (datumMMDD == "0831")
                return "Nora";
            if (datumMMDD == "0901")
                return "Drahoslava";
            if (datumMMDD == "0902")
                return "Linda";
            if (datumMMDD == "0903")
                return "Belo";
            if (datumMMDD == "0904")
                return "Rozália";
            if (datumMMDD == "0905")
                return "Regina";
            if (datumMMDD == "0906")
                return "Alica";
            if (datumMMDD == "0907")
                return "Marianna";
            if (datumMMDD == "0908")
                return "Miriama";
            if (datumMMDD == "0909")
                return "Martina";
            if (datumMMDD == "0910")
                return "Oleg";
            if (datumMMDD == "0911")
                return "Bystrík";
            if (datumMMDD == "0912")
                return "Mária";
            if (datumMMDD == "0913")
                return "Ctibor";
            if (datumMMDD == "0914")
                return "Ľudomil";
            if (datumMMDD == "0915")
                return "Jolana";
            if (datumMMDD == "0916")
                return "Ľudmila";
            if (datumMMDD == "0917")
                return "Olympia";
            if (datumMMDD == "0918")
                return "Eugénia";
            if (datumMMDD == "0919")
                return "Konštantín";
            if (datumMMDD == "0920")
                return "Ľuboslav, Ľubosla";
            if (datumMMDD == "0921")
                return "Matúš";
            if (datumMMDD == "0922")
                return "Móric";
            if (datumMMDD == "0923")
                return "Zdenka";
            if (datumMMDD == "0924")
                return "Ľuboš, Ľubor";
            if (datumMMDD == "0925")
                return "Vladislav";
            if (datumMMDD == "0926")
                return "Edita";
            if (datumMMDD == "0927")
                return "Cyprián";
            if (datumMMDD == "0928")
                return "Václav";
            if (datumMMDD == "0929")
                return "Michal, Michaela";
            if (datumMMDD == "0930")
                return "Jarolím";
            if (datumMMDD == "1001")
                return "Arnold";
            if (datumMMDD == "1002")
                return "Levoslav";
            if (datumMMDD == "1003")
                return "Stela";
            if (datumMMDD == "1004")
                return "František";
            if (datumMMDD == "1005")
                return "Viera";
            if (datumMMDD == "1006")
                return "Natália";
            if (datumMMDD == "1007")
                return "Eliška";
            if (datumMMDD == "1008")
                return "Brigita";
            if (datumMMDD == "1009")
                return "Dionýz";
            if (datumMMDD == "1010")
                return "Slavomíra";
            if (datumMMDD == "1011")
                return "Valentína";
            if (datumMMDD == "1012")
                return "Maximilián";
            if (datumMMDD == "1013")
                return "Koloman";
            if (datumMMDD == "1014")
                return "Boris";
            if (datumMMDD == "1015")
                return "Terézia";
            if (datumMMDD == "1016")
                return "Vladimíra";
            if (datumMMDD == "1017")
                return "Hedviga";
            if (datumMMDD == "1018")
                return "Lukáš";
            if (datumMMDD == "1019")
                return "Kristián";
            if (datumMMDD == "1020")
                return "Vendelín";
            if (datumMMDD == "1021")
                return "Uršuľa";
            if (datumMMDD == "1022")
                return "Sergej";
            if (datumMMDD == "1023")
                return "Alojzia";
            if (datumMMDD == "1024")
                return "Kvetoslava";
            if (datumMMDD == "1025")
                return "Aurel";
            if (datumMMDD == "1026")
                return "Demeter";
            if (datumMMDD == "1027")
                return "Sabina";
            if (datumMMDD == "1028")
                return "Dobromila";
            if (datumMMDD == "1029")
                return "Klára";
            if (datumMMDD == "1030")
                return "Simon, Simona";
            if (datumMMDD == "1031")
                return "Aurélia";
            if (datumMMDD == "1101")
                return "Denisa, Denis";
            if (datumMMDD == "1102")
                return "Všetci svatí";
            if (datumMMDD == "1103")
                return "Hubert";
            if (datumMMDD == "1104")
                return "Karol";
            if (datumMMDD == "1105")
                return "Imrich";
            if (datumMMDD == "1106")
                return "Renáta";
            if (datumMMDD == "1107")
                return "René";
            if (datumMMDD == "1108")
                return "Bohumír";
            if (datumMMDD == "1109")
                return "Teodor";
            if (datumMMDD == "1110")
                return "Tibor";
            if (datumMMDD == "1111")
                return "Martin, Maroš";
            if (datumMMDD == "1112")
                return "Svatopluk";
            if (datumMMDD == "1113")
                return "Stanislav";
            if (datumMMDD == "1114")
                return "Irma";
            if (datumMMDD == "1115")
                return "Leopold";
            if (datumMMDD == "1116")
                return "Agneša";
            if (datumMMDD == "1117")
                return "Klaudia";
            if (datumMMDD == "1118")
                return "Eugen";
            if (datumMMDD == "1119")
                return "Alžbeta";
            if (datumMMDD == "1120")
                return "Félix";
            if (datumMMDD == "1121")
                return "Elvíra";
            if (datumMMDD == "1122")
                return "Cecília";
            if (datumMMDD == "1123")
                return "Klement";
            if (datumMMDD == "1124")
                return "Emília";
            if (datumMMDD == "1125")
                return "Katarína";
            if (datumMMDD == "1126")
                return "Kornel";
            if (datumMMDD == "1127")
                return "Milan";
            if (datumMMDD == "1128")
                return "Henrieta";
            if (datumMMDD == "1129")
                return "Vratko";
            if (datumMMDD == "1130")
                return "Ondrej, Andrej";
            if (datumMMDD == "1201")
                return "Edmund";
            if (datumMMDD == "1202")
                return "Bibiana";
            if (datumMMDD == "1203")
                return "Oldrich";
            if (datumMMDD == "1204")
                return "Barbara, Barbora";
            if (datumMMDD == "1205")
                return "Oto";
            if (datumMMDD == "1206")
                return "Mikuláš";
            if (datumMMDD == "1207")
                return "Ambróz";
            if (datumMMDD == "1208")
                return "Marína";
            if (datumMMDD == "1209")
                return "Izabela";
            if (datumMMDD == "1210")
                return "Radúz";
            if (datumMMDD == "1211")
                return "Hilda";
            if (datumMMDD == "1212")
                return "Otília";
            if (datumMMDD == "1213")
                return "Lucia";
            if (datumMMDD == "1214")
                return "Branislava, Broni";
            if (datumMMDD == "1215")
                return "Ivica";
            if (datumMMDD == "1216")
                return "Albína";
            if (datumMMDD == "1217")
                return "Kornélia";
            if (datumMMDD == "1218")
                return "Sláva, Slávka";
            if (datumMMDD == "1219")
                return "Judita";
            if (datumMMDD == "1220")
                return "Dagmara";
            if (datumMMDD == "1221")
                return "Bohdan";
            if (datumMMDD == "1222")
                return "Adela";
            if (datumMMDD == "1223")
                return "Nadežda";
            if (datumMMDD == "1224")
                return "Adam a Eva";
            if (datumMMDD == "1225")
                return "Vianoce";
            if (datumMMDD == "1226")
                return "Štefan";
            if (datumMMDD == "1227")
                return "Filoména";
            if (datumMMDD == "1228")
                return "Ivana, Ivona";
            if (datumMMDD == "1229")
                return "Milada";
            if (datumMMDD == "1230")
                return "Dávid";
            if (datumMMDD == "1231")
                return "Silvester";
            return "";
        }

        public string DnesJe()
        {
            string strVystup = "";
            int intCisloMesiaca = (int)DateTime.Now.Month;
            string strMesiac;
            switch (intCisloMesiaca)
            {
                case 1:
                    strMesiac = "januára";
                    break;
                case 2:
                    strMesiac = "februára";
                    break;
                case 3:
                    strMesiac = "marca";
                    break;
                case 4:
                    strMesiac = "apríla";
                    break;
                case 5:
                    strMesiac = "mája";
                    break;
                case 6:
                    strMesiac = "júna";
                    break;
                case 7:
                    strMesiac = "júla";
                    break;
                case 8:
                    strMesiac = "augusta";
                    break;
                case 9:
                    strMesiac = "septembra";
                    break;
                case 10:
                    strMesiac = "októbra";
                    break;
                case 11:
                    strMesiac = "novembra";
                    break;
                case 12:
                    strMesiac = "decembra";
                    break;

                default:
                    strMesiac = "";
                    break;
            }

            int intCisloDna = (int)DateTime.UtcNow.DayOfWeek;
            if (intCisloDna == 0)
                intCisloDna = 7;

            switch (intCisloDna)
            {
                case 1:
                    strVystup = "Dnes je pondelok " + DateTime.UtcNow.Day + ". " + strMesiac + " " + DateTime.UtcNow.Year;
                    break;
                case 2:
                    strVystup = "Dnes je utorok " + DateTime.UtcNow.Day + ". " + strMesiac + " " + DateTime.UtcNow.Year;
                    break;
                case 3:
                    strVystup = "Dnes je streda " + DateTime.UtcNow.Day + ". " + strMesiac + " " + DateTime.UtcNow.Year;
                    break;
                case 4:
                    strVystup = "Dnes je štvrtok " + DateTime.UtcNow.Day + ". " + strMesiac + " " + DateTime.UtcNow.Year;
                    break;
                case 5:
                    strVystup = "Dnes je piatok " + DateTime.UtcNow.Day + ". " + strMesiac + " " + DateTime.UtcNow.Year;
                    break;
                case 6:
                    strVystup = "Dnes je sobota " + DateTime.UtcNow.Day + ". " + strMesiac + " " + DateTime.UtcNow.Year;
                    break;
                case 7:
                    strVystup = "Dnes je nedeľa " + DateTime.UtcNow.Day + ". " + strMesiac + " " + DateTime.UtcNow.Year;
                    break;
                default:
                    strVystup = "Dnes je " + DateTime.UtcNow.Day + ". " + strMesiac + " " + DateTime.UtcNow.Year;
                    break;
            }
            return strVystup;
        }

        public string DnesMaSviatok(bool bPridajEnteryMedziSviatky)
        {
            string strEnter = "\r\n";
            if (!bPridajEnteryMedziSviatky)
                strEnter = "";
            string strVystup = "";
            string strDen;
            string strMesiac;
            strDen = DateTime.UtcNow.Day.ToString();
            if (strDen.Length == 1)
            {
                strDen = "0" + strDen;
            }
            strMesiac = DateTime.UtcNow.Month.ToString();
            if (strMesiac.Length == 1)
            {
                strMesiac = "0" + strMesiac;
            }

            strDen = strMesiac + strDen;

            strVystup = "V kalendári je " + MeninyMa(strDen);

            DateTime dateZajtra = DateTime.Today;
            dateZajtra = dateZajtra.AddDays(1);

            strDen = dateZajtra.Day.ToString();
            if (strDen.Length == 1)
            {
                strDen = "0" + strDen;
            }

            strMesiac = dateZajtra.Month.ToString();
            if (strMesiac.Length == 1)
            {
                strMesiac = "0" + strMesiac;
            }

            strDen = strMesiac + strDen;

            strVystup = strVystup + ", " + strEnter + "zajtra bude " + MeninyMa(strDen);

            dateZajtra = DateTime.Today;
            dateZajtra = dateZajtra.AddDays(2);

            strDen = dateZajtra.Day.ToString();
            if (strDen.Length == 1)
            {
                strDen = "0" + strDen;
            }

            strMesiac = dateZajtra.Month.ToString();
            if (strMesiac.Length == 1)
            {
                strMesiac = "0" + strMesiac;
            }

            strDen = strMesiac + strDen;

            strVystup = strVystup + ", " + strEnter + "pozajtra " + MeninyMa(strDen);

            return strVystup;
        }

    }
}
