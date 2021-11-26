import os

import win32com.client as win32
from tkinter import *
def close():
    ws.destroy()
    exit()
def send():
        directory = txt_path.get()
        subject = txt_sub.get()
        email = txt_mail.get()
        body = txt_body.get("1.0", "end-1c")

        outlook = win32.Dispatch('outlook.application')
        olFormatHTML = 2
        olFormatPlain = 1
        olFormatRichText = 3
        olFormatUnspecified = 0
        olMailItem = 0x0

        for item in os.listdir(directory):
            newMail = outlook.CreateItem(olMailItem)
            par = subject + item.split('.')[0]
            newMail.Subject = par
            newMail.BodyFormat = olFormatHTML  # or olFormatRichText or olFormatPlain
            newMail.HTMLBody = body
            newMail.To = email
            attachment = os.path.join(directory, item)
            newMail.Attachments.Add(attachment)
            newMail.Send()

ws = Tk()
ws.title("Mail Bomber")
ws.geometry("500x400")

lbl_select = Label(ws, text="Ordner Pfad")
lbl_sendto = Label(ws, text="E-Mail Adresse")
lbl_subject = Label(ws, text="Betreff")
lbl_body = LabelFrame(ws, text="Nachricht")
sendbtn = Button(ws, text="Send", padx=20, pady=10, command=send)
Closebtn = Button(ws, text="Close", padx=20, pady=10, command=close)

txt_path = Entry(ws, width=50)
txt_mail = Entry(ws, width=50)
txt_sub = Entry(ws, width=50)
txt_body = Text(lbl_body, width=50)

lbl_select.place(x=50, y=20, anchor=CENTER)
lbl_sendto.place(x=50, y=60, anchor=CENTER)
lbl_subject.place(x=50, y=100, anchor=CENTER)
lbl_body.place(x=230, y=230, height=200, width=350, anchor=CENTER)

sendbtn.place(x=230, y=360, anchor=CENTER)
Closebtn.place(x=330, y=360, anchor=CENTER)

txt_path.place(x=250, y=20, anchor=CENTER)
txt_mail.place(x=250, y=60, anchor=CENTER)
txt_sub.place(x=250, y=100, anchor=CENTER)
txt_body.pack()

    # infinite loop
ws.mainloop()



errormsg = 'Please start Outlook'

def main():
    send()
    close()
if __name__ == '__main__':
    main()