$ildasm = "C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.1 Tools\ildasm.exe"

if (-not (Test-Path out)) { mkdir out }

. $ildasm bin/Release/net35/Lib154.dll /out:out/154.il
. $ildasm bin/Release/net35/Lib155.dll /out:out/155.il
. $ildasm bin/Release/net35/Lib155-240.dll /out:out/155-240.il
