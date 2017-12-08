# VS 2017 Enterprise Release version
$csc154 = "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\Roslyn\csc.exe"

# VS 2017 Enterprise Preview version
$csc155 = "C:\Program Files (x86)\Microsoft Visual Studio\Preview\Enterprise\MSBuild\15.0\Bin\Roslyn\csc.exe"

. $csc154 Class1.cs /out:bin/Release/net35/Lib154.dll /unsafe /t:library
. $csc155 Class1.cs /out:bin/Release/net35/Lib155.dll /unsafe /t:library
