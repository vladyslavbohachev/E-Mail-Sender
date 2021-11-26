import os
import psutil
def check_con():
    for proc in psutil.process_iter():
        if proc.name() == 'OUTLOOK.EXE':
            flag = 1
            print(proc.name())
            break
        else:
            flag = 0

    if flag == 1:
        send()
        return True
    else:
        print(errormsg)
        return False