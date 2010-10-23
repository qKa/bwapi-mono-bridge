REM
REM  Builds the cs files and the cxx file from the BWAPI  and BWTA headers for the bwapi-clr-client implementation.
REM



:start
SET SWIGPATH=..\..\..\..\swigwin-2.0.1

erase /s /q ..\..\..\bwapi-clr-client\bwapi-clr\swig-classes\*.*

%SWIGPATH%\swig.exe -csharp -c++ -outdir ..\..\..\bwapi-clr-client\bwapi-clr\swig-classes\BWAPI -namespace BWAPI -DINCLUDE_CLIENT -dllimport bwapi-native.dll bwapi-bridge.i

%SWIGPATH%\swig.exe -csharp -c++ -outdir ..\..\..\bwapi-clr-client\bwapi-clr\swig-classes\BWTA -namespace BWTA -dllimport bwapi-native.dll bwta-bridge.i

erase /q ..\..\..\bwapi-clr-client\bwapi-native\bwapi-bridge_wrap.cxx
erase /q ..\..\..\bwapi-clr-client\bwapi-native\bwta-bridge_wrap.cxx

copy bwapi-bridge_wrap.cxx ..\..\..\bwapi-clr-client\bwapi-native\bwapi-bridge_wrap.cxx
copy bwta-bridge_wrap.cxx ..\..\..\bwapi-clr-client\bwapi-native\bwta-bridge_wrap.cxx

pause

