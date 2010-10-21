SET SWIGPATH=..\..\..\..\..\swigwin-2.0.1

erase /s /q ..\..\..\..\MonoBridgeAI\monobridgeai-interop\swig-classes\*.*

%SWIGPATH%\swig.exe -csharp -c++ -outdir ..\..\..\..\MonoBridgeAI\monobridgeai-interop\swig-classes -namespace BWAPI -dllimport __Internal bwapi-bridge.i
pause
