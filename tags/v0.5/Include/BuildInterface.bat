SET SWIGPATH=..\..\swigwin-1.3.40

erase /s /q ..\StarcraftBot\monobridgeai-interop\swig-classes\*.*

%SWIGPATH%\swig.exe -csharp -c++ -outdir ..\StarcraftBot\monobridgeai-interop\swig-classes -namespace BWAPI -dllimport __Internal bwapi-bridge.i
pause
