# NetFlex

En enkel film/serie lista för att hålla koll på vilka serier man har sett, enligt kodövningen "Netflex".

## Innehållsförteckning
- [NetFlex](#netflex)
  * [Kodstruktur](#kodstruktur)
  * [Kodflöde](#kodfl-de)
  * [Sammanfattning](#sammanfattning)
  * [Disclaimer](#disclaimer)


## Kodstruktur
Koden är uppdelad i mappar för att det ska se snyggare ut i Solution Explorer

I Mappen Helpers finns classer som enbart innehåller hjälpmetoder
- FileHandler läser in och sparar Json 
- InputHandler frågar användaren om information
- MenuHelper genererar menyer och frågar om input

I mappen Models finns classerna som hanterar datastrukturen
- Show är classen som är grunden till de andra classerna
- Serie är classen som innehåller data om specifika tv-serier
- Movie är classen som innehåller data om soecifika filmer

Seeder classen skapar JSON strängar om det inte finns några datafiler att läsa in


## Kodflöde
Vid start körs main()
- Det första som sker är att FileHandler classen anropas för att läsa in datafilerna
  - GetData() anropas för att läsa in JSON filen
  - Om GetData returnerar en tom sträng (filen finns inte eller är skadad) så anropas Seedern för att skapa en ny fil med demodata
  - Omvandla JSON strängen till en lista och returnera den
- MenuHelper anropas för att visa fram huvudmenyn
- Beroende på valet får man mata in
  - TV-serie information
    - Fråga efter information och spara det i serie-listan
  - Film information
    - Fråga efter information och spara det i film-listan
  - Välja om man vill mata in något mer (metoden KeepGoing() fixar det)
- När man inte längre vill mata in data visas menyn för att visa data (MenuHelper)
  - Om man väljer TV-serier (MenuHelper)
    - Visa en lista på serier (MenuHelper)
      - Använd menyväljaren för att välja serie
    - MenuHelpern visar information om vald serie
  - Om man väljer Filmer (MenuHelper)
    - Visa en lista på filmer (MenuHelper)
      - Använd menyväljaren för att välja film
    - MenuHelpern visar information om vald film
  - MenuHelpern frågar om man vill se en till
- Om användaren inte vill göra något mer så sparas listorna
- och programmer avslutas.


## Sammanfattning
- Inputs och outputs har lagts i egna classer för att slippa rörig kod
- Menyer har en tendens att ta upp en massa plats, alltså fick menyerna hamna i en egen class.
- Listor på filmer och information om filmer finns också i MenuHandler classen då de mer eller mindr beter sig som menyer
- I största mån har jag använt refactoring för att splittre koden i metoder, på så sätt kan jag återanvända metoderna så mycket som möjligt
- Även om classerna ärver Show classen så fanns det inte möjlighet till att använda polymorfism, men jag hittade några tillfällen då det gick att använda
  - Filmtitel och år slås ihop till en titel, fungerar både för Serier och filmer
  - Skriva ut titeln i en söt liten box, fungerar både för Serier och filmer


## Disclaimer
Jag använde mig av NewtonSoft JSON Nuget för att kunna spara informationen jag matar in i programmet, av den denkla orsaken att det är så trist att göra ett program som bara håller kvar informationen medan den körs, och nästa gång man kör den måste man börja om. Detta ingick inte i uppgiften men jag tyckte ändå det kunde vara roligt att få den att spara information.

*That's all for now*
