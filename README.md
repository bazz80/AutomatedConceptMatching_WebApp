# AutomatedConceptMatching_WebApp

This is the GUI front-end to the AutomatedConceptMatching python application.
AutomatedConceptMatching is a script that automates the comparison of concepts found in the 
MIMOSA Standard and ISO 10303-239 PLCS Standard. The script delivers the matches score, their 
description, name and relationships through the use of FuzzyWuzzy, to a database store.

This front-end application provides the end-user with an interface to the concept matching database,
with the ability to search concepts, and compare between similiar concepts from both Mimosa and PLCS.

<h2>Deployment and Configuration</h2>
This Web Application is easily deployed as code into an Azure Web App.
This does require that an "Azure Database for MySQL flexible server" has been deployed as per the guide in
the AutomatedConceptMatching readme. Credentials will need to be configured as per the MySQL database.
<br>
Parameters used in Azure:<br>
Azure Web App.<br>
Basics:<br>
Publish: Code<br>
Runtime Stack: .net 6.0 (LTS)<br>
Operating System: Windows<br>
<br>
Deployment:<br>
Configure to be a cloned source of thie Git repository.<br>
edit the appsettings.json file in your Git repository to be configured with credentials for your
MySQL server.<br>
  <br>
Done. :)
  <br>
<h2>Interface</h2>
The GUI Web interface has 3 sections, along with a main landing page.
Matching Concepts - Main search page for concept comparison.
Mimosa Concepts - reference page for the Mimosa Standard.
PLCS Concepts - reference page for PCLS Standard.
