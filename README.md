## Il fortune di numerone

Il fortune teller che parla italiano

:it: La prima incarnazione seria di un fortune teller in lingua non americana. Il primo prodotto commerciale pubblicato per android che usa le api mysql invece delle api rest.


![Napoli-Logo](https://github.com/user-attachments/assets/485755c8-376c-4778-b9ba-80f6cb204142)

![made in parco grifeo](https://github.com/user-attachments/assets/8f3e561e-6002-4dd8-bc50-888c14a1dfe3)

## Introduzione

Circa 15 anni fa era in voga in Italia una newsletter chiamata "Una barzelletta al giorno" della società buongiorno.
All'inizio pubblicavano citazioni, ma poi si sono messi a pubblicare citazioni non più coperte dal diritto d'autore.
Io me le sono conservate con lo specifico intento di creare il fortune coi cookie italiani.

## Il server

E' liberamente accessibile all'indirizzo numeronesoft.ddns.net porta 3306, con attualmente circa 500 massime, è mariadb.
IL server è stato ispezionato dalla FIMI e non presenta particolari problemi, per cui potete realizzare il vostro fortune personale, connettendovi con le librerie mysql in qualsiasi linguaggio vogliate, basta usare come user guest e come password nessuna.

## Le ultime modifiche al mio software

Il mio software, a partire dal 02-03-2025 include una label per indicare quante massime sono presenti nel database. L'ultima versione del c# permette di eseguire un random senza avere doppioni, per cui se le massime sono circa 500 occorre chiudere e riaprire il software oppure premere 500 volte sul tasto di caricamento della massima per ottenere un doppione.

## Come scaricare

## Per android

[![google](https://play.google.com/intl/it_it/badges/static/images/badges/it_badge_web_generic.png)](https://play.google.com/store/apps/details?id=org.altervista.numerone.fortune)

## Per windows

[![winget](https://user-images.githubusercontent.com/49786146/159123313-3bdafdd3-5130-4b0d-9003-40618390943a.png)](https://marticliment.com/wingetui/share?pid=GiulioSorrentino.IlFortunedinumerone.&pname=IlFortunedinumerone&psource=Winget:%20winget)

## Client testuali (fonti NON verificate ufficialmente)

**https://giulianospaghetti.altervista.org/Downloads/fortune/Il_fortune_di_numerone-1.0-cui-amd64.msi** (CUI in dotnet per amd64 spulcia un cookie per volta, sono garantiti gli accenti)

**https://giulianospaghetti.altervista.org/Downloads/fortune/Il_fortune_di_numerone-1.0-cui-arm64.msi** (CUI in dotnet per arm64 spulcia un cookie per volta, sono garantuti gli accenti)

**https://giulianospaghetti.altervista.org/Downloads/fortune/il-fortune-di-numerone-1.0.rar** (CUI in c per amd64 compilato su debian, spulcia un cookie per volta non sono garantiti gli accenti)

## Client testuali per debian
Tramite repository

Seguite le istruzioni all'indirizzo http://numeronesoft.ddns.net:8080 e scaricate il fortune di numerone cui o il fortune di numerone cui c (sono garantiti gli accenti)
