# ** THE POWERSHELL VERSION ** 
```powershell
$foldercontent = get-childitem "path_to_your_data";
	ForEach($item in $foldercontent){
	$ol = New-Object -comObject Outlook.Application;
	$mail = $ol.CreateItem(0);
	$Mail.Recipients.Add("enter@email.address");
	$Mail.Subject = "Subject with name of the document"+$item.Name;
	$Mail.Body = get-content  -Path "path_to_your_body_text\body.txt" | Out-String;
	$Mail.Attachments.Add($item.fullname);
	$Mail.send();                
	}
```

Imagine you have to send many attachments (i.o.c. pdf documents) to only one recipient, but your e-mail can only send 20 MB. This script helps you to do it faster.

# Usage

 - Open PowerShell ISE and paste the script in
 - Change folderpath recipient, subject and body
 - press RUN or "F5"
Thats all

# ** THE PYTHON VERSION **

# Buld the App 
with following code:
 Create new file named setup.py
 
```python
import sys
from cx_Freeze import setup, Executable

build_exe_options = {'packages': ['os'], 'excludes':['none']}
base = None
if sys.platform == 'win32':
    base = "Win32GUI"

setup(name = 'MailSender',
      version = '0.1',
      description = 'Tool to send E-Mails with many attachments',
      options = {'build_exe': build_exe_options},
      executables = [Executable('main.py', base=base)])

#$> setup.py build
```
and the UI is self explanatory
