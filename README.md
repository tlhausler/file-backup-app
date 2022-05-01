# File Backup App

## Context

This was a project I did in my free time to continue to learn about windows forms applications.  I also wanted more practice with file backup code and decided to combine the two into a single project.  I wanted an application that would let me choose a file from anywhere to copy, and let me choose any destination folder to copy that file to.  

## Action

I first set up the layout of the windows form.  It's a simple layout with two text fields and three buttons.  The two browse buttons pair with their respective text fields.  I created an async background worker that would do the copy work in the background once the back up button had been clicked.  I implemented the use of File IO methods for reading and writing desired file from and to desired location.  This work is handed to the background worker.  

## Result and Reflection

The application works exactly as intended.  I wouldn't see a need to explain its functionality.  The intent was to learn more about windows forms and file operations.  This project served to give me a useful context in which to apply file operations.  I got to learn a bit about the use of background workers and practice more with filestream operations. 
