


# PersoChecker 
This is a bot that checks if my Personalausweis is ready to get picked up at the Bürgerbüro in Munich. I will (hopefully) get notfied by an Email.

current Status of my Personalausweis:
[![Do i need to wait longer?](https://github.com/echtlersebastian/PersoChecker/actions/workflows/dotnet.yml/badge.svg)](https://github.com/echtlersebastian/PersoChecker/actions/workflows/dotnet.yml)

(Green means, that i need to wait longer. As soon, as it turns red, i will be able to create an appointment and pick up my new Personalausweis!)

# Why do we need something like this?
The Guy at the counter in 🤡Bürgerbüro🤡 was telling me, that i will not get any notification about the status of my personalausweis. He said: "just check the website
mentioned on the printed Abholschein and type in your Ausweisnummer. It is working like the Package Tracking at DHL". But it does not work like DHL. Because i get 
notified about my packages at DHL. And i am that kind of guy, that forgets about an Personalausweis and will never Pick it up from the 🤡Bürgerbüro🤡. Thats why i wrote 
a bot to Notify me. Ten Lines of Code written by me, so not that complicated. If 🤡Bürgerbüro🤡 want to offer an Notificationservice about the Personalausweises to
everybody, just send me a 🕊Brieftaube🕊 or whatever kind of Communication tool you use, i will provide you a basic Solution, that does the job for free. Thats not Rocketscience. 🚀🚀🚀🚀🚀🚀🚀🚀


# What it does:
 - Selenium Test opening the Website muenchen.de/pass and entering my Abholcode.
 - Checks if the status is "kann noch nicht abgeholt werden". 
 - If yes, the test is green. 
 - If no, the Status has changed and i will get an Email about the failed Test.
 
# How it runs:
 - Github Action running on a scedule builds and executes the NUnit Tests. 
 - The Check runs every 60 minutes (i think, that higher frequent executions will just break the Internet at Bürgerbüro 🤡)
 
# How to use:
 - fork the Repo, change the Abholnummer to your Abholnummer and create a Github Action (just copy my dotnet.yml File in the Workflow folder and you are good to go). :)
 
 Have fun waiting on your new Perso!
