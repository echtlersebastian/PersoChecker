# PersoChecker
In this Repo i build a bot that checks, if my Personalausweis is ready to get picked up at the Bürgerbüro in Munich

# What it does:
 - Selenium Test opening the Website muenchen.de/pass and entering my Abholcode.
 - Checks if the status is "kann noch nicht abgeholt werden". 
 - If yes, the test is green. 
 - If no, the Status has changed and i will get an Email about the failed Test.
 
#How it runs:
 - Github Action running on a scedule builds and executes the NUnit Tests. 
 
#How to use it:
 - fork the Repo, change the Abholnummer to your Abholnummer and create a Github Action (just copy my dotnet.yml File in the Workflow folder and you are good to go). :)
 
 Have fun waiting on your new Perso!
