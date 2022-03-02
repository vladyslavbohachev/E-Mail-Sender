import os
import win32com.client as win32
from tkinter import *
from tkinter import filedialog
import tkinter as tk

def close():
    MsgBox = tk.messagebox.askquestion('Exit App', 'Möchten Sie die App wirklich beenden ? ', icon='error')
    if MsgBox == 'yes':
        m.destroy()
        exit(0)
    else:
        tk.messagebox.showinfo('Welcome Back', 'Willkommen zurück :)')
def get_file():
    global path_to_file
    path_to_file = StringVar()
    file_path = filedialog.askdirectory(title="Choose directory", initialdir="/home", mustexist=True)
    Attch.set(file_path)
    path_to_file.text = file_path
def send():
    outlook = win32.Dispatch('outlook.application')
    olFormatHTML = 2
    olMailItem = 0x0
    directory = path_to_file.text
    subject = Subject.get()
    email = To.get()
    body = txtBody.get(1.0,END)
    try:
        for item in os.listdir(directory):
            newMail = outlook.CreateItem(olMailItem)
            par = subject +' '+ item.split('.')[0]
            newMail.Subject = par
            newMail.BodyFormat = 2  # olFormatHTML https://msdn.microsoft.com/en-us/library/office/aa219371(v=office.11).aspx
            newMail.Body = body
            newMail.To = email
            attachment = os.path.join(directory, item)
            newMail.Attachments.Add(attachment)
            newMail.Send()
        tk.messagebox.showinfo('Erledigt', 'Email(s) wurde(n) versendet, Aufgabe erfolgreich abgeschlossen')
    except:
        tk.messagebox.showerror('Fehler', 'voll der Fehler', icon='error')
m = Tk()
m.geometry("800x550+300+100")
m.title('Mail Bomber 2.0')

To = StringVar()
Cc = StringVar()
Subject = StringVar()
Attch = StringVar()
mainbody = StringVar()

lblHeader1 = Label(m, text="CompanyName", fg='blue', font='Verdana 18 bold', bg='#ade9ff').place(x=10, y=15)
lblHeader = Label(m, text="Mail Bomber", font='Verdana 13', bg='#ade9ff').place(x=300, y=50)
lblHeader = Label(m, text="(zwei punkt null)", font='Verdana 6', bg='#ade9ff').place(x=410, y=58)

lblTo = Label(m, text="Empfänger:", bg='#ade9ff', font='Verdana 11', relief='flat', highlightthickness=0).place(x=15, y=90)
txtTo = Entry(m, width=60, textvariable=To, relief='flat', font='Verdana', highlightthickness=0).place(x=110, y=90)

lblSubject = Label(m, text="Betreff:", bg='#ade9ff', font='Verdana 11', relief='flat', highlightthickness=0).place(x=15, y=120)
txtSubject = Entry(m, width=60, textvariable=Subject, font='Verdana', relief='flat', highlightthickness=0).place(x=110, y=120)

lblAttch = Label(m, text="Anhang:", bg='#ade9ff', font='Verdana 11', relief='flat', highlightthickness=0).place(x=15, y=150)
txtAttch = Entry(m, width=50, textvariable=Attch, font='Verdana', relief='flat', highlightthickness=0, state="disabled").place(x=110, y=150)
btnAttch = Button(m, text="Attach", fg="dark blue", font='Verdana', width=8, command=get_file).place(x=625, y=145)

lblBody = Label(m, text="E-Mail:", bg='#ade9ff', font='Verdana 11', relief='flat', highlightthickness=0).place(x=15, y=180)
txtBody = Text(m, width=60, height=15, relief='flat', font='Verdana', highlightthickness=0)
txtBody.place(x=110, y=180)

btnSend = Button(m, text="Send", fg="black", bg='light green', width=10, command=send, font='Verdana', relief='flat', highlightthickness=0).place(x=110, y=460)
btnClose = Button(m, text="Beenden", fg="black",bg='#ff7369', width=10, command=close, font='Verdana', relief='flat', highlightthickness=0).place(x=607, y=460)
m.configure(background='#ade9ff')
m.mainloop()


