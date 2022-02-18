**Name: Iterator Design Pattern**

**Problem som behöver lösas:**

Att enumerera över en collection utan att exponera underliggande struktur, 
som du kanske vill dölja av säkerhets- eller bekvämlighetsskäl.

**Lösning:**

Utöver att implementera algoritmen i sig självt, så inkapslas alla detaljer om hur man ska traversera i samlingen i iteratorn. 
Som t.ex den nuvarande positionen i samlingen, hur många element som är kvar före vi når slutet etc.
Pga detta kan flera iteratorer arbeta samtidigt i samma samling, obereoende av varandra.
Vanligtvis ser man till att alla iteratorer måste använda sig utav samma interface, så att koden kan ta sig igenom vilken sorts samling som helst.
Så länge man har en iterator anpassad för ändamålet.
Om du behöver ett speciellt sätt att ta sig igenom en samling, skapar du en ny iterator utan att behöva ändra samlingen.


**Konsekvenser**
*bra* 
    Följer single responsibility genom att inte tynga ner collections men tunga algoritmer för att stega igenom data 
    Följer Open/closed för att man kan skapa nya iterators till dina collections utan att ändra mycket kod.
    Man kan iterera över en collection parallelt för att varje iterator har sin egen state
*dåligt*
    Att använda möstret kan vara en överdrift om dina klasser bara har enkla sammlingar
    Användningen av en iterator kan vara mindre effektivt än att gå igenom en collection direkt.