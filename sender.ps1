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