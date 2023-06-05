; Script generated with the Venis Install Wizard

; Define your application name
!define APPNAME "Mikki Book"
!define APPNAMEANDVERSION "Mikki Book 0.1"

; Main Install settings
Name "${APPNAMEANDVERSION}"
InstallDir "$PROFILE\Mikki Book"
InstallDirRegKey HKLM "Software\${APPNAME}" ""
OutFile "MikkiBookWF\bin\Release\publish\MikkiBookWF.exe"

; Modern interface settings
!include "MUI.nsh"

!define MUI_ABORTWARNING
!define MUI_FINISHPAGE_RUN "$INSTDIR\MikkiBookWF.exe"

!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH

!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES

; Set languages (first is default language)
!insertmacro MUI_LANGUAGE "English"
!insertmacro MUI_RESERVEFILE_LANGDLL

Section "Mikki Book" Section1

	; Set Section properties
	SetOverwrite on

	; Set Section Files and Shortcuts
	SetOutPath "$INSTDIR\"
	File "MikkiBookWF\bin\Release\publish\Microsoft.Data.Sqlite.dll"
	File "MikkiBookWF\bin\Release\publish\Microsoft.EntityFrameworkCore.Abstractions.dll"
	File "MikkiBookWF\bin\Release\publish\Microsoft.EntityFrameworkCore.dll"
	File "MikkiBookWF\bin\Release\publish\Microsoft.EntityFrameworkCore.Relational.dll"
	File "MikkiBookWF\bin\Release\publish\Microsoft.EntityFrameworkCore.Sqlite.dll"
	File "MikkiBookWF\bin\Release\publish\Microsoft.Extensions.Caching.Abstractions.dll"
	File "MikkiBookWF\bin\Release\publish\Microsoft.Extensions.Caching.Memory.dll"
	File "MikkiBookWF\bin\Release\publish\Microsoft.Extensions.Configuration.Abstractions.dll"
	File "MikkiBookWF\bin\Release\publish\Microsoft.Extensions.DependencyInjection.Abstractions.dll"
	File "MikkiBookWF\bin\Release\publish\Microsoft.Extensions.DependencyInjection.dll"
	File "MikkiBookWF\bin\Release\publish\Microsoft.Extensions.DependencyModel.dll"
	File "MikkiBookWF\bin\Release\publish\Microsoft.Extensions.Logging.Abstractions.dll"
	File "MikkiBookWF\bin\Release\publish\Microsoft.Extensions.Logging.dll"
	File "MikkiBookWF\bin\Release\publish\Microsoft.Extensions.Options.dll"
	File "MikkiBookWF\bin\Release\publish\Microsoft.Extensions.Primitives.dll"
	File "MikkiBookWF\bin\Release\publish\MikkiBookWF.deps.json"
	File "MikkiBookWF\bin\Release\publish\MikkiBookWF.dll"
	File "MikkiBookWF\bin\Release\publish\MikkiBookWF.exe"
	File "MikkiBookWF\bin\Release\publish\MikkiBookWF.pdb"
	File "MikkiBookWF\bin\Release\publish\MikkiBookWF.runtimeconfig.json"
	File "MikkiBookWF\bin\Release\publish\SQLitePCLRaw.batteries_v2.dll"
	File "MikkiBookWF\bin\Release\publish\SQLitePCLRaw.core.dll"
	File "MikkiBookWF\bin\Release\publish\SQLitePCLRaw.provider.e_sqlite3.dll"
	File "MikkiBookWF\bin\Release\publish\System.Text.Encodings.Web.dll"
	File "MikkiBookWF\bin\Release\publish\System.Text.Json.dll"
	SetOutPath "$INSTDIR\runtimes\alpine-arm\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\alpine-arm\native\libe_sqlite3.so"
	SetOutPath "$INSTDIR\runtimes\alpine-arm64\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\alpine-arm64\native\libe_sqlite3.so"
	SetOutPath "$INSTDIR\runtimes\alpine-x64\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\alpine-x64\native\libe_sqlite3.so"
	SetOutPath "$INSTDIR\runtimes\browser\lib\net6.0\"
	File "MikkiBookWF\bin\Release\publish\runtimes\browser\lib\net6.0\System.Text.Encodings.Web.dll"
	SetOutPath "$INSTDIR\runtimes\browser-wasm\nativeassets\net6.0\"
	File "MikkiBookWF\bin\Release\publish\runtimes\browser-wasm\nativeassets\net6.0\e_sqlite3.a"
	SetOutPath "$INSTDIR\runtimes\linux-arm\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\linux-arm\native\libe_sqlite3.so"
	SetOutPath "$INSTDIR\runtimes\linux-arm64\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\linux-arm64\native\libe_sqlite3.so"
	SetOutPath "$INSTDIR\runtimes\linux-armel\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\linux-armel\native\libe_sqlite3.so"
	SetOutPath "$INSTDIR\runtimes\linux-mips64\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\linux-mips64\native\libe_sqlite3.so"
	SetOutPath "$INSTDIR\runtimes\linux-musl-arm\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\linux-musl-arm\native\libe_sqlite3.so"
	SetOutPath "$INSTDIR\runtimes\linux-musl-arm64\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\linux-musl-arm64\native\libe_sqlite3.so"
	SetOutPath "$INSTDIR\runtimes\linux-musl-x64\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\linux-musl-x64\native\libe_sqlite3.so"
	SetOutPath "$INSTDIR\runtimes\linux-ppc64le\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\linux-ppc64le\native\libe_sqlite3.so"
	SetOutPath "$INSTDIR\runtimes\linux-s390x\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\linux-s390x\native\libe_sqlite3.so"
	SetOutPath "$INSTDIR\runtimes\linux-x64\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\linux-x64\native\libe_sqlite3.so"
	SetOutPath "$INSTDIR\runtimes\linux-x86\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\linux-x86\native\libe_sqlite3.so"
	SetOutPath "$INSTDIR\runtimes\maccatalyst-arm64\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\maccatalyst-arm64\native\libe_sqlite3.dylib"
	SetOutPath "$INSTDIR\runtimes\maccatalyst-x64\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\maccatalyst-x64\native\libe_sqlite3.dylib"
	SetOutPath "$INSTDIR\runtimes\osx-arm64\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\osx-arm64\native\libe_sqlite3.dylib"
	SetOutPath "$INSTDIR\runtimes\osx-x64\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\osx-x64\native\libe_sqlite3.dylib"
	SetOutPath "$INSTDIR\runtimes\win-arm\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\win-arm\native\e_sqlite3.dll"
	SetOutPath "$INSTDIR\runtimes\win-arm64\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\win-arm64\native\e_sqlite3.dll"
	SetOutPath "$INSTDIR\runtimes\win-x64\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\win-x64\native\e_sqlite3.dll"
	SetOutPath "$INSTDIR\runtimes\win-x86\native\"
	File "MikkiBookWF\bin\Release\publish\runtimes\win-x86\native\e_sqlite3.dll"
	CreateShortCut "$DESKTOP\Mikki Book.lnk" "$INSTDIR\MikkiBookWF.exe"
	CreateDirectory "$SMPROGRAMS\Mikki Book"
	CreateShortCut "$SMPROGRAMS\Mikki Book\Mikki Book.lnk" "$INSTDIR\MikkiBookWF.exe"
	CreateShortCut "$SMPROGRAMS\Mikki Book\Uninstall.lnk" "$INSTDIR\uninstall.exe"

SectionEnd

Section -FinishSection

	WriteRegStr HKLM "Software\${APPNAME}" "" "$INSTDIR"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}" "DisplayName" "${APPNAME}"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}" "UninstallString" "$INSTDIR\uninstall.exe"
	WriteUninstaller "$INSTDIR\uninstall.exe"

SectionEnd

; Modern install component descriptions
!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
	!insertmacro MUI_DESCRIPTION_TEXT ${Section1} ""
!insertmacro MUI_FUNCTION_DESCRIPTION_END

;Uninstall section
Section Uninstall

	;Remove from registry...
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APPNAME}"
	DeleteRegKey HKLM "SOFTWARE\${APPNAME}"

	; Delete self
	Delete "$INSTDIR\uninstall.exe"

	; Delete Shortcuts
	Delete "$DESKTOP\Mikki Book.lnk"
	Delete "$SMPROGRAMS\Mikki Book\Mikki Book.lnk"
	Delete "$SMPROGRAMS\Mikki Book\Uninstall.lnk"

	; Clean up Mikki Book
	Delete "$INSTDIR\Microsoft.Data.Sqlite.dll"
	Delete "$INSTDIR\Microsoft.EntityFrameworkCore.Abstractions.dll"
	Delete "$INSTDIR\Microsoft.EntityFrameworkCore.dll"
	Delete "$INSTDIR\Microsoft.EntityFrameworkCore.Relational.dll"
	Delete "$INSTDIR\Microsoft.EntityFrameworkCore.Sqlite.dll"
	Delete "$INSTDIR\Microsoft.Extensions.Caching.Abstractions.dll"
	Delete "$INSTDIR\Microsoft.Extensions.Caching.Memory.dll"
	Delete "$INSTDIR\Microsoft.Extensions.Configuration.Abstractions.dll"
	Delete "$INSTDIR\Microsoft.Extensions.DependencyInjection.Abstractions.dll"
	Delete "$INSTDIR\Microsoft.Extensions.DependencyInjection.dll"
	Delete "$INSTDIR\Microsoft.Extensions.DependencyModel.dll"
	Delete "$INSTDIR\Microsoft.Extensions.Logging.Abstractions.dll"
	Delete "$INSTDIR\Microsoft.Extensions.Logging.dll"
	Delete "$INSTDIR\Microsoft.Extensions.Options.dll"
	Delete "$INSTDIR\Microsoft.Extensions.Primitives.dll"
	Delete "$INSTDIR\MikkiBookWF.deps.json"
	Delete "$INSTDIR\MikkiBookWF.dll"
	Delete "$INSTDIR\MikkiBookWF.exe"
	Delete "$INSTDIR\MikkiBookWF.pdb"
	Delete "$INSTDIR\MikkiBookWF.runtimeconfig.json"
	Delete "$INSTDIR\SQLitePCLRaw.batteries_v2.dll"
	Delete "$INSTDIR\SQLitePCLRaw.core.dll"
	Delete "$INSTDIR\SQLitePCLRaw.provider.e_sqlite3.dll"
	Delete "$INSTDIR\System.Text.Encodings.Web.dll"
	Delete "$INSTDIR\System.Text.Json.dll"
	Delete "$INSTDIR\runtimes\alpine-arm\native\libe_sqlite3.so"
	Delete "$INSTDIR\runtimes\alpine-arm64\native\libe_sqlite3.so"
	Delete "$INSTDIR\runtimes\alpine-x64\native\libe_sqlite3.so"
	Delete "$INSTDIR\runtimes\browser\lib\net6.0\System.Text.Encodings.Web.dll"
	Delete "$INSTDIR\runtimes\browser-wasm\nativeassets\net6.0\e_sqlite3.a"
	Delete "$INSTDIR\runtimes\linux-arm\native\libe_sqlite3.so"
	Delete "$INSTDIR\runtimes\linux-arm64\native\libe_sqlite3.so"
	Delete "$INSTDIR\runtimes\linux-armel\native\libe_sqlite3.so"
	Delete "$INSTDIR\runtimes\linux-mips64\native\libe_sqlite3.so"
	Delete "$INSTDIR\runtimes\linux-musl-arm\native\libe_sqlite3.so"
	Delete "$INSTDIR\runtimes\linux-musl-arm64\native\libe_sqlite3.so"
	Delete "$INSTDIR\runtimes\linux-musl-x64\native\libe_sqlite3.so"
	Delete "$INSTDIR\runtimes\linux-ppc64le\native\libe_sqlite3.so"
	Delete "$INSTDIR\runtimes\linux-s390x\native\libe_sqlite3.so"
	Delete "$INSTDIR\runtimes\linux-x64\native\libe_sqlite3.so"
	Delete "$INSTDIR\runtimes\linux-x86\native\libe_sqlite3.so"
	Delete "$INSTDIR\runtimes\maccatalyst-arm64\native\libe_sqlite3.dylib"
	Delete "$INSTDIR\runtimes\maccatalyst-x64\native\libe_sqlite3.dylib"
	Delete "$INSTDIR\runtimes\osx-arm64\native\libe_sqlite3.dylib"
	Delete "$INSTDIR\runtimes\osx-x64\native\libe_sqlite3.dylib"
	Delete "$INSTDIR\runtimes\win-arm\native\e_sqlite3.dll"
	Delete "$INSTDIR\runtimes\win-arm64\native\e_sqlite3.dll"
	Delete "$INSTDIR\runtimes\win-x64\native\e_sqlite3.dll"
	Delete "$INSTDIR\runtimes\win-x86\native\e_sqlite3.dll"

	; Remove remaining directories
	RMDir "$SMPROGRAMS\Mikki Book"
	RMDir "$INSTDIR\runtimes\win-x86\native\"
	RMDir "$INSTDIR\runtimes\win-x86\"
	RMDir "$INSTDIR\runtimes\win-x64\native\"
	RMDir "$INSTDIR\runtimes\win-x64\"
	RMDir "$INSTDIR\runtimes\win-arm\native\"
	RMDir "$INSTDIR\runtimes\win-arm\"
	RMDir "$INSTDIR\runtimes\win-arm64\native\"
	RMDir "$INSTDIR\runtimes\win-arm64\"
	RMDir "$INSTDIR\runtimes\osx-x64\native\"
	RMDir "$INSTDIR\runtimes\osx-x64\"
	RMDir "$INSTDIR\runtimes\osx-arm64\native\"
	RMDir "$INSTDIR\runtimes\osx-arm64\"
	RMDir "$INSTDIR\runtimes\maccatalyst-x64\native\"
	RMDir "$INSTDIR\runtimes\maccatalyst-x64\"
	RMDir "$INSTDIR\runtimes\maccatalyst-arm64\native\"
	RMDir "$INSTDIR\runtimes\maccatalyst-arm64\"
	RMDir "$INSTDIR\runtimes\linux-x86\native\"
	RMDir "$INSTDIR\runtimes\linux-x86\"
	RMDir "$INSTDIR\runtimes\linux-x64\native\"
	RMDir "$INSTDIR\runtimes\linux-x64\"
	RMDir "$INSTDIR\runtimes\linux-s390x\native\"
	RMDir "$INSTDIR\runtimes\linux-s390x\"
	RMDir "$INSTDIR\runtimes\linux-ppc64le\native\"
	RMDir "$INSTDIR\runtimes\linux-ppc64le\"
	RMDir "$INSTDIR\runtimes\linux-musl-x64\native\"
	RMDir "$INSTDIR\runtimes\linux-musl-x64\"
	RMDir "$INSTDIR\runtimes\linux-musl-arm\native\"
	RMDir "$INSTDIR\runtimes\linux-musl-arm\"
	RMDir "$INSTDIR\runtimes\linux-musl-arm64\native\"
	RMDir "$INSTDIR\runtimes\linux-musl-arm64\"
	RMDir "$INSTDIR\runtimes\linux-mips64\native\"
	RMDir "$INSTDIR\runtimes\linux-mips64\"
	RMDir "$INSTDIR\runtimes\linux-armel\native\"
	RMDir "$INSTDIR\runtimes\linux-armel\"
	RMDir "$INSTDIR\runtimes\linux-arm\native\"
	RMDir "$INSTDIR\runtimes\linux-arm\"
	RMDir "$INSTDIR\runtimes\linux-arm64\native\"
	RMDir "$INSTDIR\runtimes\linux-arm64\"
	RMDir "$INSTDIR\runtimes\browser\lib\net6.0\"
	RMDir "$INSTDIR\runtimes\browser\lib\"
	RMDir "$INSTDIR\runtimes\browser\"
	RMDir "$INSTDIR\runtimes\browser-wasm\nativeassets\net6.0\"
	RMDir "$INSTDIR\runtimes\browser-wasm\nativeassets\"
	RMDir "$INSTDIR\runtimes\browser-wasm\"
	RMDir "$INSTDIR\runtimes\alpine-x64\native\"
	RMDir "$INSTDIR\runtimes\alpine-x64\"
	RMDir "$INSTDIR\runtimes\alpine-arm\native\"
	RMDir "$INSTDIR\runtimes\alpine-arm\"
	RMDir "$INSTDIR\runtimes\alpine-arm64\native\"
	RMDir "$INSTDIR\runtimes\alpine-arm64\"
	RMDir "$INSTDIR\runtimes\"
	RMDir "$INSTDIR\"

SectionEnd

; eof