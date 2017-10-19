$ildasm = "C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.1 Tools\ildasm.exe"
#. $ildasm 15.4/net35/GeneratedCommon.dll /out:154.il
#. $ildasm 15.5/net35/GeneratedCommon.dll /out:155.il
#diff (Get-Content 154.il) (Get-Content 155.il)

# VS 2017 15.4 Enterprise
$csc154 = "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\Roslyn\csc.exe"

# VS 2017 15.5 Enterprise Preview
$csc155 = "C:\Program Files (x86)\Microsoft Visual Studio\Preview\Enterprise\MSBuild\15.0\Bin\Roslyn\csc.exe"

. $csc154 Class1.cs /out:Lib154.dll /unsafe /t:library
. $csc155 Class1.cs /out:Lib155.dll /unsafe /t:library

. $ildasm Lib154.dll /out:154.il
. $ildasm Lib155.dll /out:155.il
