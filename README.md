
# INFO --- This is outdated. Use the Repo below!
This is currently configured to work only for my Personalausweis. If you want to use this for your Personalausweis as well, than use https://github.com/echtlersebastian/MunichPersoChecker

# PersoChecker 
This is a bot that checks if my Personalausweis is ready to get picked up at the Bürgerbüro in Munich. I will (hopefully) get notfied by an Email.

current Status of my Personalausweis:
[![Do i need to wait longer?](https://github.com/echtlersebastian/PersoChecker/actions/workflows/dotnet.yml/badge.svg)](https://github.com/echtlersebastian/PersoChecker/actions/workflows/dotnet.yml)

(Green means, that i need to wait longer. As soon, as it turns red, i will be able to create an appointment and pick up my new Personalausweis!) 

(edit: Look, its red! I was able to pick up my Personalausweiß at Bürgerbüro! My Bot worked!!! 😍)

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
