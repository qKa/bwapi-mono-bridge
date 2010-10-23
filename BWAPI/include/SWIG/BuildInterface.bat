REM
REM  Builds the cs files and the cxx file from the BWAPI  and BWTA headers for the monobridge implementation.
REM


SET SWIGPATH=..\..\..\..\swigwin-2.0.1

erase /s /q ..\..\..\MonoBridgeAI\monobridgeai-interop\swig-classes\*.*

%SWIGPATH%\swig.exe -csharp -c++ -outdir ..\..\..\MonoBridgeAI\monobridgeai-interop\swig-classes\BWAPI -namespace BWAPI -dllimport __Internal bwapi-bridge.i

%SWIGPATH%\swig.exe -csharp -c++ -outdir ..\..\..\MonoBridgeAI\monobridgeai-interop\swig-classes\BWTA -namespace BWTA -dllimport __Internal bwta-bridge.i

erase /q ..\..\..\MonoBridgeAI\MonoBridge\bwapi-bridge_wrap.cxx
erase /q ..\..\..\MonoBridgeAI\MonoBridge\bwta-bridge_wrap.cxx

copy bwta-bridge_wrap.cxx ..\..\..\MonoBridgeAI\MonoBridge\bwta-bridge_wrap.cxx
copy bwapi-bridge_wrap.cxx ..\..\..\MonoBridgeAI\MonoBridge\bwapi-bridge_wrap.cxx

pause
