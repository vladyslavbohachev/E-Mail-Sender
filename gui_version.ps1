
[void][System.Reflection.Assembly]::LoadWithPartialName( “System.Windows.Forms”)
[void][System.Reflection.Assembly]::LoadWithPartialName( “Microsoft.VisualBasic”)

#####Define the form size & placement

$form = New-Object “System.Windows.Forms.Form”;
$form.Width = 640;
$form.Height = 420;
$form.Text = $title;
$form.StartPosition = [System.Windows.Forms.FormStartPosition]::CenterScreen;

##############Define text label1
$lblSelectPdf = New-Object “System.Windows.Forms.Label”;
$lblSelectPdf.Left = 25;
$lblSelectPdf.Top = 25;
$lblSelectPdf.Width = 150;
$lblSelectPdf.Text = "PDF Datei auswählen";

############Define text box1 for input
$txtSelectPdf = New-Object “System.Windows.Forms.TextBox”;
$txtSelectPdf.Left = 25;
$txtSelectPdf.Top = 50;
$txtSelectPdf.width = 200;
$txtSelectPdf.Text = "Ordner Auswählen"  

#############define select cmdSelectPdf
$cmdSelectPdf = New-Object “System.Windows.Forms.Button”;
$cmdSelectPdf.Left = 230;
$cmdSelectPdf.Top = 50;
$cmdSelectPdf.Width = 100;
$cmdSelectPdf.Text = “Suchen”;

############# the output of calling the get-Folder Location function must be shown in the txtSelectPdf

$cmdSelectPdf.Add_Click({(Get-Variable -Name txtSelectPdf -Scope 1).Value.Text = Get-Folderlocation}) ;

$selectedDirectory
$pdfString = $txtSelectPdf.Text;


function get-Folderlocation([string]$Message, [string]$InitialDirectory, [switch]$NoNewFoldercmdSelectPdf)
{
    $browseForFolderOptions = 0
    if ($NoNewFoldercmdSelectPdf) { $browseForFolderOptions += 512 }

    $app = New-Object -ComObject Shell.Application
    $folder = $app.BrowseForFolder(0, $Message, $browseForFolderOptions, $InitialDirectory)
    if ($folder) { $selectedDirectory = $folder.Self.Path } else { $selectedDirectory = '' }
    [System.Runtime.Interopservices.Marshal]::ReleaseComObject($app) > $null
    return $selectedDirectory
}



$lblchoEmail = New-Object “System.Windows.Forms.Label”;
$lblchoEmail.Left = 25;
$lblchoEmail.Top = 75;
$lblchoEmail.Width = 100;
$lblchoEmail.Text = "E-Mail An:";

############Define Email to
$txtchoEmail = New-Object “System.Windows.Forms.TextBox”;
$txtchoEmail.Left = 130;
$txtchoEmail.Top = 75;
$txtchoEmail.width = 200;
$txtchoEmail.Text = "E-Mail Adresse eingeben"

$selectedEmailAdress = $txtchoEmail.Text;


#############define send Button
$cmdSend = New-Object “System.Windows.Forms.Button”;
$cmdSend.Left = 25;
$cmdSend.Top = 300;
$cmdSend.Width = 100;
$cmdSend.Text = “Senden”;

############# Send Mail 

$cmdSend.Add_Click({sendmail});


function sendmail(){

    $foldercontent = get-childitem "$pdfString";
            ForEach($item in $foldercontent){
                $ol = New-Object -comObject Outlook.Application;
                $mail = $ol.CreateItem(0);
                $Mail.Recipients.Add($selectedEmailAdress);
                $Mail.Recipients.Add("###");
                $Mail.Subject = "Lieferschein Nr:"+$item.Name;
                $Mail.Body = get-content  -Path "$select_body" | Out-String;
                $Mail.Attachments.Add($item.fullname);
                $Mail.send();
                echo "$selectedDirectory"
            }
}



$cmdCancel = New-Object “System.Windows.Forms.Button”;
$cmdCancel.Left = 150;
$cmdCancel.Top = 300;
$cmdCancel.Width = 100;
$cmdCancel.Text = “Abbrechen”;
$cmdCancel.Add_Click({
     $form.Dispose()
  })


#############Add controls to all the above objects defined
$form.Controls.Add($cmdSelectPdf);
$form.Controls.Add($lblSelectPdf);
$form.Controls.Add($txtSelectPdf);
$form.Controls.Add($cmdSend);
$form.Controls.Add($cmdCancel);
$form.Controls.Add($lblchoEmail);
$form.Controls.Add($txtchoEmail);


$form.ShowDialog();
$txtSelectPdf.Text



$form.ShowDialog();
$txtSelectPdf.Text
