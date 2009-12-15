del *.dll
copy monobridgeai\bin\debug\*.dll .
erase /q output\*.*
monolinker -c link -l none -a monobridgeai.dll
