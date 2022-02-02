[ENG]
<br>
<h3> Description of the task: </h3>

1)  User should indicate a desired number of threads (number between 2 and 15, not more or less) in the Form.

2)  Upon choosing the number, and pressing "Start" button, every thread should generate a sequence of 5-10 (random selection) symbols in a random period of time (between 0.5-2 seconds).

3)  The 20 most recently generated lines of data should be displayed in the ListView control. The following columns are present in the ListView: Thread ID (the number of a thread, that starts from 1), the generated sequence of symbols.

4)  Each data sequence should be written into an access data file (mdb) (it is also allowed to use a SQL server) table, where the columns are: ID (autonumber), ThreadID, Time Of Generation, Data.

5)  Upon pressing the "Stop" button, the application stops running and threads are disabled. 

<br>
<br>
[LT]
<br>
<h3> Užduoties aprašymas: </h3>

1)  Formoje vartotojas gali nurodyti kintamą kiekį thread (atšakos) (Nuo 2 iki 15, kiekis negali būti didesnis ar mažesnis).

2)  Išrinkus kiekį ir paspaudus start mygtuką, kiekvienas thread turi atsitiktiniu laiko intervalu (0,5-2 sekundžių) generuoti 5-10 (atsitiktinai) simbolių ilgio eilutę.

3)  Turi būti įsimenamos/rodomos 20 paskutinių sugeneruotų duomenų, kurie išvedami į formos ListView kontrolą. ListView turi tokias kolonas – Thread ID(numeris atšakos, kur numeruojama nuo 1), sugeneruota eilutė.

4)  Visi atšakos generuoti duomenis rašomi į access duomenų failą(mdb) (galite naudoti ir SQL serverį, jie turite tokią galimybę), lentelę - kur laukai yra ID(autonumber), ThreadID, Time(laikas sugeneravimo), Data(eilutė).
 
5)  Paspaudus Stop mygtuką darbas stabdomas ir thread išjungiamos.
