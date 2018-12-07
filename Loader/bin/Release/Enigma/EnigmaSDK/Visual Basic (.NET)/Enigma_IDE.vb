Imports System.Text
Imports System.Runtime.InteropServices

''' <summary>
''' Summary description for Enigma_IDE
''' </summary>
Public Class Enigma_IDE

    Public Const WM_PUBLIC As Integer = 1
    Public Const WM_PRIVATE As Integer = 2

    ' Number of crypted sections
    Public Const NUMBER_OF_CRYPTED_SECTIONS As Integer = 16

    ' Ctypt hash types, possible hash values for functions:
    ' EP_CryptHashBuffer
    ' EP_CryptHashStringA
    ' EP_CryptHashStringW
    ' EP_CryptHashFileA
    ' EP_CryptHashFileW
    Public Const HASH_XOR32 As Integer = 0
    Public Const HASH_MD2 As Integer = 1
    Public Const HASH_MD5 As Integer = 2
    Public Const HASH_RipeMD160 As Integer = 3
    Public Const HASH_SH1 As Integer = 4
    Public Const HASH_SHA224 As Integer = 5
    Public Const HASH_SHA256 As Integer = 6
    Public Const HASH_SHA384 As Integer = 7
    Public Const HASH_SHA512 As Integer = 8

    ' Return values of EP_RegLoadKey
    Public Const LOADKEY_SUCCEEDED As Integer = 0
    Public Const LOADKEY_REGINFONOTFOUND As Integer = 1
    Public Const LOADKEY_NAMEBUFFERTOOSMALL As Integer = 2
    Public Const LOADKEY_KEYBUFFERTOOSMALL As Integer = 3

    ' Return values of EP_RegKeyStatus
    Public Const KEY_STATUS_DOESNOTEXIST As Integer = 0
    Public Const KEY_STATUS_VALID As Integer = 1
    Public Const KEY_STATUS_INVALID As Integer = 2
    Public Const KEY_STATUS_STOLEN As Integer = 3
    Public Const KEY_STATUS_DATEEXPIRED As Integer = 4
    Public Const KEY_STATUS_WITHOUTHARDWARELOCK As Integer = 5
    Public Const KEY_STATUS_WITHOUTEXPIRATIONDATE As Integer = 6
    Public Const KEY_STATUS_WITHOUTREGISTERAFTERDATE As Integer = 7
    Public Const KEY_STATUS_WITHOUTREGISTERBEFOREDATE As Integer = 8
    Public Const KEY_STATUS_WITHOUTEXECUTIONSLIMIT As Integer = 9
    Public Const KEY_STATUS_WITHOUTDAYSLIMIT As Integer = 10
    Public Const KEY_STATUS_WITHOUTRUNTIMELIMIT As Integer = 11
    Public Const KEY_STATUS_WITHOUTGLOBALTIMELIMIT As Integer = 12
    Public Const KEY_STATUS_WITHOUTCOUNTRYLOCK As Integer = 13
    Public Const KEY_STATUS_COUNTRYINVALID As Integer = 14
    Public Const KEY_STATUS_REGISTERAFTERFAILED As Integer = 15
    Public Const KEY_STATUS_REGISTERBEFOREFAILED As Integer = 16
    Public Const KEY_STATUS_EXECUTIONSEXPIRED As Integer = 17
    Public Const KEY_STATUS_DAYSEXPIRED As Integer = 18
    Public Const KEY_STATUS_RUNTIMEEXPIRED As Integer = 19
    Public Const KEY_STATUS_GLOBALTIMEEXPIRED As Integer = 20
    Public Const KEY_STATUS_HARDWARECHANGESEXCEEDED_VOLUMESERIAL As Integer = 21
    Public Const KEY_STATUS_HARDWARECHANGESEXCEEDED_VOLUMENAME As Integer = 22
    Public Const KEY_STATUS_HARDWARECHANGESEXCEEDED_COMPUTERNAME As Integer = 23
    Public Const KEY_STATUS_HARDWARECHANGESEXCEEDED_CPU As Integer = 24
    Public Const KEY_STATUS_HARDWARECHANGESEXCEEDED_MOTHERBOARD As Integer = 25
    Public Const KEY_STATUS_HARDWARECHANGESEXCEEDED_WINDOWSKEY As Integer = 26
    Public Const KEY_STATUS_HARDWARECHANGESEXCEEDED_HDDSERIAL As Integer = 27
    Public Const KEY_STATUS_HARDWARECHANGESEXCEEDED_USERNAME As Integer = 28
    Public Const KEY_STATUS_HARDWAREINVALID As Integer = 29

    ' Counties code
    Public Const CN_AFGHANISTAN As Integer = 114
    Public Const CN_ALBANIA As Integer = 1
    Public Const CN_ALGERIA As Integer = 2
    Public Const CN_ARGENTINA As Integer = 3
    Public Const CN_ARMENIA As Integer = 4
    Public Const CN_AUSTRALIA As Integer = 5
    Public Const CN_AUSTRIA As Integer = 6
    Public Const CN_AZERBAIJAN As Integer = 7
    Public Const CN_BAHRAIN As Integer = 8
    Public Const CN_BANGLADESH As Integer = 115
    Public Const CN_BELARUS As Integer = 9
    Public Const CN_BELGIUM As Integer = 10
    Public Const CN_BELIZE As Integer = 11
    Public Const CN_BOLIVIA As Integer = 116
    Public Const CN_BOSNIA As Integer = 117
    Public Const CN_BRAZIL As Integer = 13
    Public Const CN_BRUNEI As Integer = 14
    Public Const CN_BULGARIA As Integer = 15
    Public Const CN_CAMBODIA As Integer = 16
    Public Const CN_CANADA As Integer = 17
    Public Const CN_CARRIBEAN As Integer = 118
    Public Const CN_CHILE As Integer = 20
    Public Const CN_CHINA As Integer = 21
    Public Const CN_COLOMBIA As Integer = 22
    Public Const CN_COSTARICA As Integer = 23
    Public Const CN_CROATIA As Integer = 24
    Public Const CN_CZECH As Integer = 25
    Public Const CN_DENMARK As Integer = 26
    Public Const CN_DOMINICAN As Integer = 27
    Public Const CN_ECUADOR As Integer = 28
    Public Const CN_EGYPT As Integer = 29
    Public Const CN_ELSALVADOR As Integer = 30
    Public Const CN_ESTONIA As Integer = 31
    Public Const CN_ETHIOPIA As Integer = 119
    Public Const CN_FAROE As Integer = 32
    Public Const CN_FINLAND As Integer = 33
    Public Const CN_FRANCE As Integer = 34
    Public Const CN_GEORGIA As Integer = 35
    Public Const CN_GERMANY As Integer = 36
    Public Const CN_GREECE As Integer = 37
    Public Const CN_GREENLAND As Integer = 120
    Public Const CN_GUATEMALA As Integer = 38
    Public Const CN_HONDURAS As Integer = 39
    Public Const CN_HONGKONG As Integer = 40
    Public Const CN_HUNGARU As Integer = 41
    Public Const CN_ICELAND As Integer = 42
    Public Const CN_INDIA As Integer = 43
    Public Const CN_INDONESIA As Integer = 44
    Public Const CN_IRAN As Integer = 45
    Public Const CN_IRAQ As Integer = 46
    Public Const CN_IRELAND As Integer = 47
    Public Const CN_ISRAEL As Integer = 48
    Public Const CN_ITALY As Integer = 49
    Public Const CN_JAMAICA As Integer = 50
    Public Const CN_JAPAN As Integer = 51
    Public Const CN_JORDAN As Integer = 52
    Public Const CN_KAZAKHSTAN As Integer = 53
    Public Const CN_KENYA As Integer = 54
    Public Const CN_KOREA As Integer = 56
    Public Const CN_KUWAIT As Integer = 57
    Public Const CN_KYRGYZSTAN As Integer = 58
    Public Const CN_LAOS As Integer = 121
    Public Const CN_LATVIA As Integer = 59
    Public Const CN_LEBANON As Integer = 60
    Public Const CN_LIBYAN As Integer = 122
    Public Const CN_LIECHTENSTEIN As Integer = 62
    Public Const CN_LITHUANIA As Integer = 63
    Public Const CN_LUXEMBOURG As Integer = 64
    Public Const CN_MACAO As Integer = 65
    Public Const CN_MACEDONIA As Integer = 66
    Public Const CN_MALAYSIA As Integer = 67
    Public Const CN_MALDIVES As Integer = 123
    Public Const CN_MALTA As Integer = 124
    Public Const CN_MEXOCI As Integer = 68
    Public Const CN_MONACO As Integer = 70
    Public Const CN_MONGOLIA As Integer = 71
    Public Const CN_MONTENEGRO As Integer = 125
    Public Const CN_MOROCCO As Integer = 72
    Public Const CN_NEPAL As Integer = 126
    Public Const CN_NETHERLANDS As Integer = 73
    Public Const CN_NEWZEALAND As Integer = 74
    Public Const CN_NICARAGUA As Integer = 75
    Public Const CN_NIGERIA As Integer = 127
    Public Const CN_NORWAY As Integer = 76
    Public Const CN_OMAN As Integer = 77
    Public Const CN_PAKISTAN As Integer = 78
    Public Const CN_PANAMA As Integer = 79
    Public Const CN_PARAGUAY As Integer = 80
    Public Const CN_PERY As Integer = 81
    Public Const CN_PHILIPPINES As Integer = 82
    Public Const CN_POLAND As Integer = 83
    Public Const CN_PORTUGAL As Integer = 84
    Public Const CN_PUERTORICO As Integer = 85
    Public Const CN_QATAR As Integer = 86
    Public Const CN_ROMANIA As Integer = 87
    Public Const CN_RUSSIA As Integer = 88
    Public Const CN_RWANDA As Integer = 128
    Public Const CN_SAUDIARABIA As Integer = 89
    Public Const CN_SENEGAL As Integer = 129
    Public Const CN_SERBIA As Integer = 130
    Public Const CN_SERBIAMONTENEGRO As Integer = 90
    Public Const CN_SINGAROPE As Integer = 91
    Public Const CN_SLOVAKIA As Integer = 92
    Public Const CN_SLOVENIA As Integer = 93
    Public Const CN_SOUTHAFRICA As Integer = 94
    Public Const CN_SPAIN As Integer = 95
    Public Const CN_SRILANKA As Integer = 131
    Public Const CN_SWEDEN As Integer = 96
    Public Const CN_SWITZERLAND As Integer = 97
    Public Const CN_SYRIAN As Integer = 132
    Public Const CN_TAIWAN As Integer = 98
    Public Const CN_TAJIKISTAN As Integer = 99
    Public Const CN_THAILAND As Integer = 100
    Public Const CN_TRINIDADTOBAGO As Integer = 101
    Public Const CN_TUNISIA As Integer = 102
    Public Const CN_TURKEY As Integer = 103
    Public Const CN_TURKMENISTAN As Integer = 133
    Public Const CN_UKRAINE As Integer = 104
    Public Const CN_UAE As Integer = 105
    Public Const CN_UNITEDKINGDOM As Integer = 106
    Public Const CN_USA As Integer = 107
    Public Const CN_URUGUAY As Integer = 108
    Public Const CN_UZBEKISTAN As Integer = 109
    Public Const CN_VENEZUELA As Integer = 110
    Public Const CN_VIETNAM As Integer = 111
    Public Const CN_YEMEN As Integer = 112
    Public Const CN_ZIMBABWE As Integer = 113

    Public Structure TKeyCountries
        Public Name As String
        Public Code As Integer
        Public Sub New(_Name As String, _Code As Integer)
            Name = _Name
            Code = _Code
        End Sub
    End Structure

    Public Shared KEY_COUNTRIES As TKeyCountries() = New TKeyCountries(126) {New TKeyCountries("Afghanistan", CN_AFGHANISTAN), New TKeyCountries("Albania", CN_ALBANIA), New TKeyCountries("Algeria", CN_ALGERIA), New TKeyCountries("Argentina", CN_ARGENTINA), New TKeyCountries("Armenia", CN_ARMENIA), New TKeyCountries("Australia", CN_AUSTRALIA), _
        New TKeyCountries("Austria", CN_AUSTRIA), New TKeyCountries("Azerbaijan", CN_AZERBAIJAN), New TKeyCountries("Bahrain", CN_BAHRAIN), New TKeyCountries("Bangladesh", CN_BANGLADESH), New TKeyCountries("Belarus", CN_BELARUS), New TKeyCountries("Belgium", CN_BELGIUM), _
        New TKeyCountries("Belize", CN_BELIZE), New TKeyCountries("Bolivia", CN_BOLIVIA), New TKeyCountries("Bosnia and Herzegovina", CN_BOSNIA), New TKeyCountries("Brazil", CN_BRAZIL), New TKeyCountries("Brunei Darussalam", CN_BRUNEI), New TKeyCountries("Bulgaria", CN_BULGARIA), _
        New TKeyCountries("Cambodia", CN_CAMBODIA), New TKeyCountries("Canada", CN_CANADA), New TKeyCountries("Caribbean", CN_CARRIBEAN), New TKeyCountries("Chile", CN_CHILE), New TKeyCountries("China", CN_CHINA), New TKeyCountries("Colombia", CN_COLOMBIA), _
        New TKeyCountries("Costa Rica", CN_COSTARICA), New TKeyCountries("Croatia", CN_CROATIA), New TKeyCountries("Czech Republic", CN_CZECH), New TKeyCountries("Denmark", CN_DENMARK), New TKeyCountries("Dominican Republic", CN_DOMINICAN), New TKeyCountries("Ecuador", CN_ECUADOR), _
        New TKeyCountries("Egypt", CN_EGYPT), New TKeyCountries("El Salvador", CN_ELSALVADOR), New TKeyCountries("Estonia", CN_ESTONIA), New TKeyCountries("Ethiopia", CN_ETHIOPIA), New TKeyCountries("Faroe Islands", CN_FAROE), New TKeyCountries("Finland", CN_FINLAND), _
        New TKeyCountries("France", CN_FRANCE), New TKeyCountries("Georgia", CN_GEORGIA), New TKeyCountries("Germany", CN_GERMANY), New TKeyCountries("Greece", CN_GREECE), New TKeyCountries("Greenland", CN_GREENLAND), New TKeyCountries("Guatemala", CN_GUATEMALA), _
        New TKeyCountries("Honduras", CN_HONDURAS), New TKeyCountries("Hong Kong", CN_HONGKONG), New TKeyCountries("Hungary", CN_HUNGARU), New TKeyCountries("Iceland", CN_ICELAND), New TKeyCountries("India", CN_INDIA), New TKeyCountries("Indonesia", CN_INDONESIA), _
        New TKeyCountries("Iran", CN_IRAN), New TKeyCountries("Iraq", CN_IRAQ), New TKeyCountries("Ireland", CN_IRELAND), New TKeyCountries("Israel", CN_ISRAEL), New TKeyCountries("Italy", CN_ITALY), New TKeyCountries("Jamaica", CN_JAMAICA), _
        New TKeyCountries("Japan", CN_JAPAN), New TKeyCountries("Jordan", CN_JORDAN), New TKeyCountries("Kazakhstan", CN_KAZAKHSTAN), New TKeyCountries("Kenya", CN_KENYA), New TKeyCountries("Korea", CN_KOREA), New TKeyCountries("Kuwait", CN_KUWAIT), _
        New TKeyCountries("Kyrgyzstan", CN_KYRGYZSTAN), New TKeyCountries("Laos", CN_LAOS), New TKeyCountries("Latvia", CN_LATVIA), New TKeyCountries("Lebanon", CN_LEBANON), New TKeyCountries("Libyan", CN_LIBYAN), New TKeyCountries("Liechtenstein", CN_LIECHTENSTEIN), _
        New TKeyCountries("Lithuania", CN_LITHUANIA), New TKeyCountries("Luxembourg", CN_LUXEMBOURG), New TKeyCountries("Macao", CN_MACAO), New TKeyCountries("Macedonia", CN_MACEDONIA), New TKeyCountries("Malaysia", CN_MALAYSIA), New TKeyCountries("Maldives", CN_MALDIVES), _
        New TKeyCountries("Malta", CN_MALTA), New TKeyCountries("Mexico", CN_MEXOCI), New TKeyCountries("Monaco", CN_MONACO), New TKeyCountries("Mongolia", CN_MONGOLIA), New TKeyCountries("Montenegro", CN_MONTENEGRO), New TKeyCountries("Morocco", CN_MOROCCO), _
        New TKeyCountries("Nepal", CN_NEPAL), New TKeyCountries("Netherlands", CN_NETHERLANDS), New TKeyCountries("New Zealand", CN_NEWZEALAND), New TKeyCountries("Nicaragua", CN_NICARAGUA), New TKeyCountries("Nigeria", CN_NIGERIA), New TKeyCountries("Norway", CN_NORWAY), _
        New TKeyCountries("Oman", CN_OMAN), New TKeyCountries("Pakistan", CN_PAKISTAN), New TKeyCountries("Panama", CN_PANAMA), New TKeyCountries("Paraguay", CN_PARAGUAY), New TKeyCountries("Peru", CN_PERY), New TKeyCountries("Philippines", CN_PHILIPPINES), _
        New TKeyCountries("Poland", CN_POLAND), New TKeyCountries("Portugal", CN_PORTUGAL), New TKeyCountries("Puerto Rico", CN_PUERTORICO), New TKeyCountries("Qatar", CN_QATAR), New TKeyCountries("Romania", CN_ROMANIA), New TKeyCountries("Russia", CN_RUSSIA), _
        New TKeyCountries("Rwanda", CN_RWANDA), New TKeyCountries("Saudi Arabia", CN_SAUDIARABIA), New TKeyCountries("Senegal", CN_SENEGAL), New TKeyCountries("Serbia", CN_SERBIA), New TKeyCountries("Serbia and Montenegro", CN_SERBIAMONTENEGRO), New TKeyCountries("Singapore", CN_SINGAROPE), _
        New TKeyCountries("Slovakia", CN_SLOVAKIA), New TKeyCountries("Slovenia", CN_SLOVENIA), New TKeyCountries("South Africa", CN_SOUTHAFRICA), New TKeyCountries("Spain", CN_SPAIN), New TKeyCountries("Sri Lanka", CN_SRILANKA), New TKeyCountries("Sweden", CN_SWEDEN), _
        New TKeyCountries("Switzerland", CN_SWITZERLAND), New TKeyCountries("Syrian", CN_SYRIAN), New TKeyCountries("Taiwan", CN_TAIWAN), New TKeyCountries("Tajikistan", CN_TAJIKISTAN), New TKeyCountries("Thailand", CN_THAILAND), New TKeyCountries("Trinidad and Tobago", CN_TRINIDADTOBAGO), _
        New TKeyCountries("Tunisia", CN_TUNISIA), New TKeyCountries("Turkey", CN_TURKEY), New TKeyCountries("Turkmenistan", CN_TURKMENISTAN), New TKeyCountries("Ukraine", CN_UKRAINE), New TKeyCountries("United Arab Emirates", CN_UAE), New TKeyCountries("United Kingdom", CN_UNITEDKINGDOM), _
        New TKeyCountries("United States", CN_USA), New TKeyCountries("Uruguay", CN_URUGUAY), New TKeyCountries("Uzbekistan", CN_UZBEKISTAN), New TKeyCountries("Venezuela", CN_VENEZUELA), New TKeyCountries("Viet Nam", CN_VIETNAM), New TKeyCountries("Yemen", CN_YEMEN), _
        New TKeyCountries("Zimbabwe", CN_ZIMBABWE)}

    ' Type for watermark content for EP_MiscGetWatermark
    Public Structure TWMContent
        Public WMType As Int32
        Public Name As String
        Public NameLen As Int32
        Public Text As String
        Public TextLen As Int32
        Public FileName As String
        Public FileNameLen As Int32
        Public AFile As String
        Public AFileLen As Int32
    End Structure

    Public Structure TKeyInformation
        Public Stolen As Boolean
        ' {out} is key stolen
        Public CreationYear As Int32
        ' {out} key creation year
        Public CreationMonth As Int32
        ' {out} key creation month
        Public CreationDay As Int32
        ' {out} key creation day
        Public UseKeyExpiration As Boolean
        ' {out} has key expiration date?
        Public ExpirationYear As Int32
        ' {out} key expiration year
        Public ExpirationMonth As Int32
        ' {out} key expiration month
        Public ExpirationDay As Int32
        ' {out} key expiration day
        Public UseHardwareLocking As Boolean
        ' {out} hardware locked key
        Public UseExecutionsLimit As Boolean
        ' {out} limit key by executions?
        Public ExecutionsCount As Int32
        ' {out} number of executions
        Public UseDaysLimit As Boolean
        ' {out} limit key by days?
        Public DaysCount As Int32
        ' {out} number of days
        Public UseRunTimeLimit As Boolean
        ' {out} limit key by run time?
        Public RunTimeMinutes As Int32
        ' {out} run time minutes
        Public UseGlobalTimeLimit As Boolean
        ' {out} limit key by global time?
        Public GlobalTimeMinutes As Int32
        ' {out} global time minutes
        Public UseCountyLimit As Boolean
        ' {out} limit key by country?
        Public CountryCode As Int32
        ' {out} country code
        Public UseRegisterAfter As Boolean
        ' {out} register key after date?
        Public RegisterAfterYear As Int32
        ' {out} register after year
        Public RegisterAfterMonth As Int32
        ' {out} register after month
        Public RegisterAfterDay As Int32
        ' {out} register after day
        Public UseRegisterBefore As Boolean
        ' {out} register key before date?
        Public RegisterBeforeYear As Int32
        ' {out} register before year
        Public RegisterBeforeMonth As Int32
        ' {out} register before month
        Public RegisterBeforeDay As Int32
        ' {out} register before day
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=NUMBER_OF_CRYPTED_SECTIONS)> _
        Public EncryptedSections As Boolean()
        ' {out} Crypted sections     
    End Structure

    ' Enigma API for registration
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegSaveKey(Name As String, Key As String) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegSaveKeyA(Name As String, Key As String) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegSaveKeyW(Name As String, Key As String) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegLoadKey(ByRef Name As String, ByRef Key As String) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegLoadKeyA(ByRef Name As String, ByRef Key As String) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegLoadKeyW(ByRef Name As String, ByRef Key As String) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegLoadKeyEx(Name As IntPtr, ByRef NameLen As Integer, Key As IntPtr, ByRef KeyLen As Integer) As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegCheckKey(Name As String, Key As String) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegCheckKeyA(Name As String, Key As String) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegCheckKeyW(Name As String, Key As String) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegDeleteKey() As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegLoadAndCheckKey() As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegCheckAndSaveKey(Name As String, Key As String) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegCheckAndSaveKeyA(Name As String, Key As String) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegCheckAndSaveKeyW(Name As String, Key As String) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegHardwareID() As IntPtr
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegHardwareIDA() As IntPtr
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegHardwareIDW() As IntPtr
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyCreationDate(ByRef Year As Int32, ByRef Month As Int32, ByRef Day As Int32) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyCreationDateEx() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyExpirationDate(ByRef Year As Int32, ByRef Month As Int32, ByRef Day As Int32) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyExpirationDateEx() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyExecutions(ByRef Total As Int32, ByRef Left As Int32) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyExecutionsTotal() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyExecutionsLeft() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyDays(ByRef Total As Int32, ByRef Left As Int32) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyDaysTotal() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyDaysLeft() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyRuntime(ByRef Total As Int32, ByRef Left As Int32) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyRuntimeTotal() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyRuntimeLeft() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyGlobalTime(ByRef Total As Int32, ByRef Left As Int32) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyGlobalTimeTotal() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyGlobalTimeLeft() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyRegisterAfterDate(ByRef Year As Int32, ByRef Month As Int32, ByRef Day As Int32) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyRegisterAfterDateEx() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyRegisterBeforeDate(ByRef Year As Int32, ByRef Month As Int32, ByRef Day As Int32) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyRegisterBeforeDateEx() As Integer
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyInformation(AName As String, AKey As String, ByRef AKeyInfo As TKeyInformation) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyInformationA(AName As String, AKey As String, ByRef AKeyInfo As TKeyInformation) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyInformationW(AName As String, AKey As String, ByRef AKeyInfo As TKeyInformation) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_RegKeyStatus() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Sub EP_RegShowDialog()
    End Sub

    ' Enigma API for online activation
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Sub EP_ActivationShowDialog()
    End Sub

    ' Enigma API for trial
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_TrialExecutions(ByRef Total As Int32, ByRef Left As Int32) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_TrialExecutionsTotal() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_TrialExecutionsLeft() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_TrialDays(ByRef Total As Int32, ByRef Left As Int32) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_TrialDaysTotal() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_TrialDaysLeft() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_TrialExpirationDate(ByRef Year As Int32, ByRef Month As Int32, ByRef Day As Int32) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_TrialExpirationDateEx() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_TrialDateTillDate(ByRef StartYear As Int32, ByRef StartMonth As Int32, ByRef StartDay As Int32, ByRef EndYear As Int32, ByRef EndMonth As Int32, ByRef EndDay As Int32) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_TrialDateTillDateStartEx() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_TrialDateTillDateEndEx() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_TrialExecutionTime(ByRef Total As Int32, ByRef Left As Int32) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_TrialExecutionTimeTotal() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_TrialExecutionTimeLeft() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_TrialClockReversedDays() As Integer
    End Function

    ' Misc API
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_MiscGetWatermark(ID As Int32, WM As TWMContent) As Int32
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_MiscCountryCode() As Integer
    End Function

    ' Protection API
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_ProtectedStringByID(ID As Int32, Buffer As IntPtr, Len As Int32) As Int32
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_ProtectedStringByKey(Key As String, Buffer As IntPtr, Len As Int32) As Int32
    End Function

    ' Crypt API
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_CryptHashBuffer(Hash As Integer, Buffer As IntPtr, Size As Integer, Digest As IntPtr) As Integer
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_CryptHashFileA(Hash As Integer, FileName As String, Digest As IntPtr) As Integer
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_CryptHashFileW(Hash As Integer, FileName As String, Digest As IntPtr) As Integer
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_CryptHashStringA(Hash As Integer, Str As String, Digest As IntPtr) As Integer
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_CryptHashStringW(Hash As Integer, Str As String, Digest As IntPtr) As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Sub EP_CryptEncryptBuffer(Buffer As IntPtr, Size As Integer, Key As String)
    End Sub
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Sub EP_CryptEncryptBufferEx(InBuffer As IntPtr, OutBuffer As IntPtr, Size As Integer, Key As IntPtr, KeySize As Integer)
    End Sub
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Sub EP_CryptDecryptBuffer(Buffer As IntPtr, Size As Integer, Key As String)
    End Sub
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Sub EP_CryptDecryptBufferEx(InBuffer As IntPtr, OutBuffer As IntPtr, Size As Integer, Key As IntPtr, KeySize As Integer)
    End Sub

    ' Checkup API
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_CheckupCopies(ByRef Total As Int32, ByRef Current As Int32) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_CheckupCopiesTotal() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_CheckupCopiesCurrent() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_CheckupIsProtected() As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_CheckupIsEnigmaOk() As Boolean
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_CheckupVirtualizationTools() As Boolean
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_CheckupFindProcess(FileName As String, WindowText As String, WindowClass As String) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_CheckupFindProcessA(FileName As String, WindowText As String, WindowClass As String) As Boolean
    End Function
    <DllImport("enigma_ide.dll", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_CheckupFindProcessW(FileName As String, WindowText As String, WindowClass As String) As Boolean
    End Function

    ' Enigma API
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_EnigmaVersion() As Integer
    End Function

    ' Splash Screen API
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function EP_SplashScreenShow() As Integer
    End Function
    <DllImport("enigma_ide.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Sub EP_SplashScreenHide()
    End Sub

    Public Shared Function EP_RegistrationLoadKeyA(ByRef Name As String, ByRef Key As String) As Boolean
        Name = InlineAssignHelper(Key, String.Empty)
        Dim namelen As Integer = 0, keylen As Integer = 0
        If EP_RegLoadKeyEx(IntPtr.Zero, namelen, IntPtr.Zero, keylen) <> LOADKEY_REGINFONOTFOUND Then
            Dim namebuf As Byte() = New Byte(namelen - 1) {}
            Dim keybuf As Byte() = New Byte(keylen - 1) {}
            If EP_RegLoadKeyEx(Marshal.UnsafeAddrOfPinnedArrayElement(namebuf, 0), namelen, Marshal.UnsafeAddrOfPinnedArrayElement(keybuf, 0), keylen) = LOADKEY_SUCCEEDED Then
                Name = Encoding.ASCII.GetString(namebuf)
                Key = Encoding.ASCII.GetString(keybuf)
                Return True
            End If
        End If
        Return False
    End Function

    Public Shared Function EP_RegistrationLoadKeyW(ByRef Name As String, ByRef Key As String) As Boolean
        Name = InlineAssignHelper(Key, String.Empty)
        Dim namelen As Integer = 0, keylen As Integer = 0
        If EP_RegLoadKeyEx(IntPtr.Zero, namelen, IntPtr.Zero, keylen) <> LOADKEY_REGINFONOTFOUND Then
            Dim namebuf As Byte() = New Byte(namelen - 1) {}
            Dim keybuf As Byte() = New Byte(keylen - 1) {}
            If EP_RegLoadKeyEx(Marshal.UnsafeAddrOfPinnedArrayElement(namebuf, 0), namelen, Marshal.UnsafeAddrOfPinnedArrayElement(keybuf, 0), keylen) = LOADKEY_SUCCEEDED Then
                Name = Encoding.Unicode.GetString(namebuf)
                Key = Encoding.Unicode.GetString(keybuf)
                Return True
            End If
        End If
        Return False
    End Function

    Public Shared Function EP_RegistrationHardwareID() As String
        Return Marshal.PtrToStringAnsi(EP_RegHardwareID())
    End Function

    Public Shared Function EP_ProtectedStringByIDAsAnsiString(ID As Integer) As String
        Dim len As Int32 = EP_ProtectedStringByID(ID, IntPtr.Zero, 0)
        If len > 0 Then
            Dim buffer As Byte() = New Byte(len - 1) {}
            If EP_ProtectedStringByID(ID, Marshal.UnsafeAddrOfPinnedArrayElement(buffer, 0), len) > 0 Then
                Return Encoding.ASCII.GetString(buffer)
            End If
        End If
        Return String.Empty
    End Function

    Public Shared Function EP_ProtectedStringByIDAsWideString(ID As Integer) As String
        Dim len As Int32 = EP_ProtectedStringByID(ID, IntPtr.Zero, 0)
        If len > 0 Then
            Dim buffer As Byte() = New Byte(len - 1) {}
            If EP_ProtectedStringByID(ID, Marshal.UnsafeAddrOfPinnedArrayElement(buffer, 0), len) > 0 Then
                Return Encoding.Unicode.GetString(buffer)
            End If
        End If
        Return String.Empty
    End Function
    Public Shared Function EP_ProtectedStringByKeyAsAnsiString(Key As String) As String
        Dim len As Int32 = EP_ProtectedStringByKey(Key, IntPtr.Zero, 0)
        If len > 0 Then
            Dim buffer As Byte() = New Byte(len - 1) {}
            If EP_ProtectedStringByKey(Key, Marshal.UnsafeAddrOfPinnedArrayElement(buffer, 0), len) > 0 Then
                Return Encoding.ASCII.GetString(buffer)
            End If
        End If
        Return String.Empty
    End Function
    Public Shared Function EP_ProtectedStringByKeyAsWideString(Key As String) As String
        Dim len As Int32 = EP_ProtectedStringByKey(Key, IntPtr.Zero, 0)
        If len > 0 Then
            Dim buffer As Byte() = New Byte(len - 1) {}
            If EP_ProtectedStringByKey(Key, Marshal.UnsafeAddrOfPinnedArrayElement(buffer, 0), len) > 0 Then
                Return Encoding.Unicode.GetString(buffer)
            End If
        End If
        Return String.Empty
    End Function
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function
End Class