SET SWIGPATH=..\..\..\swigwin-1.3.40

erase /s /q SwigOutput\*.*

%SWIGPATH%\swig.exe -csharp -c++ -outdir ..\StarcraftBot\monobridgeai-interop\swig-classes -namespace BWAPI -dllimport __Internal bwapi-bridge.i
