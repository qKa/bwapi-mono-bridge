REM
REM  Builds the cs files and the cxx file from the BWAPI  and BWTA headers for the bwapi-clr-client implementation.
REM



:start
SET SWIGPATH=..\..\..\..\swigwin-2.0.1

erase /s /q ..\..\..\bwapi-clr-client\bwapi-clr\swig-classes\*.*

%SWIGPATH%\swig.exe -csharp -c++ -outdir ..\..\..\bwapi-clr-client\bwapi-clr\swig-classes\BWAPI -namespace SWIG.BWAPI -dllimport bwapi-native.dll bwapi-bridge.i

%SWIGPATH%\swig.exe -csharp -c++ -outdir ..\..\..\bwapi-clr-client\bwapi-clr\swig-classes\BWTA -namespace SWIG.BWTA -dllimport bwapi-native.dll bwta-bridge.i

%SWIGPATH%\swig.exe -csharp -c++ -outdir ..\..\..\bwapi-clr-client\bwapi-clr\swig-classes\BWAPIClient -namespace SWIG.BWAPIC -dllimport bwapi-native.dll bwapiclient-bridge.i


erase /q ..\..\..\bwapi-clr-client\bwapi-native\bwapi-bridge_wrap.cxx
erase /q ..\..\..\bwapi-clr-client\bwapi-native\bwta-bridge_wrap.cxx
erase /q ..\..\..\bwapi-clr-client\bwapi-native\bwapiclient-bridge_wrap.cxx


copy bwapi-bridge_wrap.cxx ..\..\..\bwapi-clr-client\bwapi-native\bwapi-bridge_wrap.cxx
copy bwta-bridge_wrap.cxx ..\..\..\bwapi-clr-client\bwapi-native\bwta-bridge_wrap.cxx
copy bwapiclient-bridge_wrap.cxx ..\..\..\bwapi-clr-client\bwapi-native\bwapiclient-bridge_wrap.cxx

pause
goto start

