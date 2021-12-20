# ** THE POWERSHELL VERSION ** 
# E-Mail Sender with powershell 
Send e-mails to one recipient with many attachments 

Imagine you have to send many attachments (i.o.c. pdf documents) to only one recipient, but your e-mail can only send 20 MB. This script helps you to do it faster.

# Usage

 - Open PowerShell ISE and paste the script in
 - Change folderpath recipient, subject and body
 - press RUN or "F5"
Thats all

# ** THE PYTHON VERSION **

# Buld the App 
with following code:
```python
import sys
from cx_Freeze import setup, Executable

build_exe_options = {'packages': ['os'], 'excludes':['tkinter']}
base = None
if sys.platform == 'win32':
    base = "Win32GUI"

setup(name = 'MailSender',
      version = '0.1',
      description = 'Tool to send E-Mails with many attachments',
      options = {'build_exe': build_exe_options},
      executables = [Executable('main.py', base=base)])
```
and the UI is self explanatory
