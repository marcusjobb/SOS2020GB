# Bankkonton

Lite förklaringar till projektet.

Med classerna från Consoleprojektet som grund fick Windows forms projektet bli användargränssnitt

Skillnader med Consoleversionen är att **Balance** i **Iaccount** är inte längre skrivskyddad, för att det blev problem när det lästes in från JSON.

Programmet kan nu spara konton i Json. Fick göra en speciallösning där för att JSON ville inte hantera Interfacet vid läsning av sparade filer.
Så jag gjorde en generisk class som läser och sparar JSON objekt. Orsaken till att den blev generisk var för att den skulle kunna hantera olika typer av classer, 
då JSON bråkade med Interfacet (den kan spara, men den kan inte läsa in det).

Namnen på kontotyperna har ersatts med ett Enum istället för strängar, för att slippa felstavningar eller Case Sensitive problem.



