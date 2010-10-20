erase /q .\Release\*.*
copy ..\starcraftbot\output\*.* .\Release
xcopy /c /h /e /k libs\*.* .\release
