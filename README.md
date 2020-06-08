# Rubrica-CodeFirstEFCORE

Questa applicazione è la parte BackEnd di una rubrica. E' stata costruita attraverso l'approccio Code-First di efCore, per il quale è stata prima 
definita la tabella **Contatto** e poi il modello **DbContext**.
La stringa di connessione di quest'ultimo è stata spostata nell'**appsettings.json** (in precedenza si trovava nell'override del metodo **OnConfiguring** della stessa classe),
di conseguenza la stringa viene passata attraverso la dependency injection definita nella classe **Startup**.
Infine l'**ApiController Home** si occupa di gestire la richiesta di invio dei dati attraverso un Json.
