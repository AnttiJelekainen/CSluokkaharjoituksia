# CSluokkaharjoituksia
Täällä harjoitellaan C# luokkaan liittyviä juttuja.

## Luokkien periytyminen
Luokka voi periä toiselta luokalta kenttiä ja metodeja. Luokkaa, jonka ominaisuuksia peritään (inheritance) kutsutaan yliluokaksi (super class, parent class) ja perivää luokkaa aliluokaksi (sub class, child class).
Perimisen keskeinen idea on se, että yliluokassa määriteltyjä ominaisuuksia (field) ja metodeja ei tarvitse enää määritellä aliluokassa, riittää että kerrotaan niiden periytyvän yliluokasta. Yliluokalla ja aliluokalla voi olla saman nimisiä metodeja, jotka toimivat eri tavalla. Tätä kutsutaan metodien ylikirjoittamiseksi (method overload). Jos aliluokassa metodi on kirjoitettu eri tavalla kuin yliluokassa, yliluokan määritys syrjäyttää aliluokan saman nimisen metodin. Aliluokan metodi voi myös syrjäyttää yliluokan metodin silloin, kun yliluokan metodi on määritetty virtuaaliseksi (virtual) ja aliluokassa metodi on määritelty syrjäytettäväksi (override). Toinen vaihtoehto on käyttää aliluokan metodin määrityksessä `new` -komentoa yliluokan metodin syrjäyttämiseksi.  Jos `new` jätetään pois, aliluokka syrjäyttää edelleen yliluokan (toisin kuin dokumentaatiossa lukee). Seuraavassa esimerkissä on kolme luokkaa: yliluokka lemmikinomistajalle sekä kaksi aliluokkaa kissanomistajalle ja koiranomistajalle.

```csharp
    // Super/Base/Parent class definition
    class Hooman
    {
        // Define properties of Hooman ie. fields
        public string name = "Essi Esimerkki";
        public int age = 30;
        public string gender = "Emäntä";

        // Default constructor w/o arguments
        // No need to define, will be created automatically
        public Hooman()
        {

        }

        public void SayOpinion()
        {
        Console.WriteLine("Lemmikit ovat elämän suola");
        }
    }
        // Sub/Derived/Child class inherits Hooman class
        class CatOwner : Hooman
        {
        public new void SayOpinion()
        {
        Console.WriteLine("Kissat ovat itsenäisiä ja pitävät hiiret loitolla");
        }
    } 
```
## Tehtävä1
Rakenna koiranomistajalle perivä luokka ja sille ylikirjoittava `SayOpinion` -metodi
```csharp

    // Create a new dog owner and call SayOpinion method
     DogOwner dogOwner = new DogOwner();
    
     dogOwner.SayOpinion();   
```

Perinteisesti metodin ylikirjoittaminen aliluokassa on määritelty käyttämällä komentoja `virtual` ja `override`:

## Tehtävä2
Tee yliluokka `Pet` ja sille aliluokka `Hare`. Määrittele metodi `Eats`, joka tulostaa ruudulle eläimen ruokavalion. `Pet` -luokassa tyyliin "Syö ruokaa" ja aliluokassa "Syö porkkanoita" .Käytä perinteistä määrittelyä virtuaaliseksi metodiksi ja ylikirjoitettavaksi metodiksi. 

## Tehtävä 3
Luo uusi sovellus (solution) ja projekti. Asetukset `C#`, `Windows` -alustalle ja `Console` -sovellustyypiksi.
Sovelluksen avulla kerätään tietoa tietoteknisistä laitteista. Kaikille laitteille yhteisiä ominaisuuksia ovat:

1. Hankintapäivä (string)
2. Hankintahinta (double)
3. Takuuaika kuukausina (int)

Kiinnostuksen kohteena ovat tietokoneet, puhelimet ja tabletit. Rakenna näille luokkamääritykset ja periytä yhteiset ominaisuudet yliluokasta. Muista kommentoida koodia.
