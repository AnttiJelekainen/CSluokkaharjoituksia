# CSluokkaharjoituksia
Täällä harjoitellaan C# luokkaan liittyviä juttuja.

## Luokkien periytyminen
Luokka voi periä toiselta luokalta kenttiä ja metodeja. Luokkaa, jonka ominaisuuksia peritään (inheritance) kutsutaan yliluokaksi (super class, parent class) ja perivää luokkaa aliluokaksi (sub class, child class).
Perimisen keskeinen idea on se, että yliluokassa määriteltyjä ominaisuuksia (field) ja metodeja ei tarvitse enää määritellä aliluokassa, riittää että kerrotaan niiden periytyvän yliluokasta. Yliluokalla ja aliluokalla voi olla saman nimisiä metodeja, jotka toimivat eri tavalla. Tätä kutsutaan metodien ylikirjoittamiseksi (method overload). Jos aliluokassa metodi on kirjoitettu eri tavalla kuin yliluokassa, yliluokan määritys syrjäytyy.
