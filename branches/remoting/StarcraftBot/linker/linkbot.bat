REM
REM Copies all needed assemblies to the output folder to execute the AI. It also strips out unused functions from the assembly reducing its size.
REM


REM Set the following mono variable to your mono bin path
set monopath=K:\program files\Mono-2.4.2.2\bin

del *.dll
copy ..\monobridgeai\bin\debug\*.dll .
erase /q output\*.*
call "%monopath%\monolinker.bat" -c link -l none -a monobridgeai.dll
del *.dll