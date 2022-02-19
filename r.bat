@echo off
.\ver.exe
.\winrar\winrar.exe a -afzip -s -ag -tk -c- -r -m5 -v -y -x*.exe -xWinRaR\ -xHeidi\ -xfiles\test\ -x*\obj\ -x*\bin\ -x.* -x*.msi -x*.suo -x*.application -x*.pdb -x*.tmp -xbackup .\backup\b 
