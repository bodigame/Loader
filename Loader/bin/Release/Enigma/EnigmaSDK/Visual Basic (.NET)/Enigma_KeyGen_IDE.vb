'Enigma API implementation
Imports System.Runtime.InteropServices

''' <summary>
''' Summary description for Enigma_Keygen_IDE
''' </summary>
''' 

Public Class Enigma_KeyGen_IDE

    Public Const NUMBER_OF_CRYPTED_SECTIONS As Integer = 16

    'Key generation/verification results
    Public Const EP_NO_ERROR As Integer = 0
    Public Const EP_ERROR_UNKNOWN As Integer = 1
    Public Const EP_ERROR_KEYBUFFEREMPTY As Integer = 2
    Public Const EP_ERROR_KEYBUFFERISLESS As Integer = 3
    Public Const EP_ERROR_REGINFOEMPTY As Integer = 4
    Public Const EP_ERROR_REGINFOTOOLARGE As Integer = 5
    Public Const EP_ERROR_PRIVATEKEYISNOTSET As Integer = 6
    Public Const EP_ERROR_PUBLICKEYISNOTSET As Integer = 7
    Public Const EP_ERROR_PRIVATEKEYISINVALID As Integer = 8
    Public Const EP_ERROR_PUBLICKEYISINVALID As Integer = 9
    Public Const EP_ERROR_KEYMODEISINVALID As Integer = 10
    Public Const EP_ERROR_KEYBASEISINVALID As Integer = 11
    Public Const EP_ERROR_CURRENTDATEISINVALID As Integer = 12
    Public Const EP_ERROR_EXPIRATIONDATEISINVALID As Integer = 13
    Public Const EP_ERROR_KEYISINVALID As Integer = 14
    Public Const EP_ERROR_HARDWAREID As Integer = 15
    Public Const EP_ERROR_HARDWAREBUFFEREMPTY As Integer = 16
    Public Const EP_ERROR_HARDWAREIDINVALIDFORKEY As Integer = 17
    Public Const EP_ERROR_PROJECTFILENOTFOUND As Integer = 18
    Public Const EP_ERROR_INVALIDPROJECTFILE As Integer = 19
    Public Const EP_ERROR_EXECUTIONSNUMBERINVALID As Integer = 20
    Public Const EP_ERROR_DAYSNUMBERINVALID As Integer = 21
    Public Const EP_ERROR_COUNTRYCODEINVALID As Integer = 22
    Public Const EP_ERROR_RUNTIMEINVALID As Integer = 23
    Public Const EP_ERROR_GLOBALTIMEINVALID As Integer = 24
    Public Const EP_ERROR_INSTALLBEFOREINVALID As Integer = 25
    Public Const EP_ERROR_INSTALLAFTERINVALID As Integer = 26

    ' Registartion mode types
    Public Const RM_512 As Integer = 0
    Public Const RM_768 As Integer = 1
    Public Const RM_1024 As Integer = 2
    Public Const RM_2048 As Integer = 3
    Public Const RM_3072 As Integer = 4
    Public Const RM_4096 As Integer = 5

    ' Registration Base types
    Public Const RB_2 As Integer = 0
    Public Const RB_8 As Integer = 1
    Public Const RB_16 As Integer = 2
    Public Const RB_32 As Integer = 3
    Public Const RB_64 As Integer = 4

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
    Public KEY_COUNTRIES As TKeyCountries() = New TKeyCountries(126) {New TKeyCountries("Afghanistan", CN_AFGHANISTAN), New TKeyCountries("Albania", CN_ALBANIA), New TKeyCountries("Algeria", CN_ALGERIA), New TKeyCountries("Argentina", CN_ARGENTINA), New TKeyCountries("Armenia", CN_ARMENIA), New TKeyCountries("Australia", CN_AUSTRALIA), _
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

    Public Structure TKeyVerifyParams
        Public RegInfo As String
        ' {in} registration info/name
        Public RegInfoLen As Int32
        ' {in} registration info/name size
        Public KeyMode As Int32
        ' {in} key generation mode (~RSA ???)
        Public KeyBase As Int32
        ' {in} key output base (Base ???)
        Public Key As String
        ' {in} buffer for registration key
        Public KeyLen As Int32
        ' {in} registration key size
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
        ' {in} hardware locked key
        Public HardwareID As String
        ' {in} pointer to null terminated hardware string
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
        Public EncryptedConstant As Int32
        ' {in} Encryption Constant - should be extracted from project file
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=NUMBER_OF_CRYPTED_SECTIONS)> _
        Public EncryptedSections As Byte()
        ' {out} Crypted sections        
        Public PublicKey As String
        ' {in} Public Key - should be extracted from project file
    End Structure

    Public Structure TKeyVerifyParamsA
        Public RegInfo As String
        ' {in} registration info/name
        Public KeyMode As Int32
        ' {in} key generation mode (~RSA ???)
        Public KeyBase As Int32
        ' {in} key output base (Base ???)
        Public Key As String
        ' {in} buffer for registration key
        Public KeyLen As Int32
        ' {in} registration key size
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
        ' {in} hardware locked key
        Public HardwareID As String
        ' {in} pointer to null terminated hardware string
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
        Public EncryptedConstant As Int32
        ' {in} Encryption Constant - should be extracted from project file
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=NUMBER_OF_CRYPTED_SECTIONS)> _
        Public EncryptedSections As Byte()
        ' {out} Crypted sections        
        Public PublicKey As String
        ' {in} Public Key - should be extracted from project file
    End Structure

    Public Structure TKeyVerifyParamsW
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public RegInfo As String
        ' {in} registration info/name
        Public KeyMode As Int32
        ' {in} key generation mode (~RSA ???)
        Public KeyBase As Int32
        ' {in} key output base (Base ???)
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public Key As String
        ' {in} buffer for registration key
        Public KeyLen As Int32
        ' {in} registration key size
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
        ' {in} hardware locked key
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public HardwareID As String
        ' {in} pointer to null terminated hardware string
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
        Public EncryptedConstant As Int32
        ' {in} Encryption Constant - should be extracted from project file
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=NUMBER_OF_CRYPTED_SECTIONS)> _
        Public EncryptedSections As Byte()
        ' {out} Crypted sections        
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public PublicKey As String
        ' {in} Public Key - should be extracted from project file
    End Structure

    Public Structure TKeyGenParams
        Public KeyMode As Int32
        ' {in} key generation mode (~RSA ???)
        Public KeyBase As Int32
        ' {in} key output base (Base ???)
        Public KeyWithHyphens As Boolean
        ' {in} add hyphens to the key?
        Public Key As String
        ' {in} buffer for registration key
        Public KeyLen As Int32
        ' {in} registration key buffer size
        Public RegInfo As String
        ' {in} registration info/name
        Public RegInfoLen As Int32
        ' {in} registration info/name size
        Public UseKeyExpiration As Boolean
        ' {in} use key expiration?
        Public ExpirationYear As Int32
        ' {in} key expiration year
        Public ExpirationMonth As Int32
        ' {in} key expiration month
        Public ExpirationDay As Int32
        ' {in} key expiration day
        Public UseHardwareLocking As Boolean
        ' {in} is key hardware locked?
        Public HardwareID As String
        ' {in} pointer to null terminated hardware string
        Public UseExecutionsLimit As Boolean
        ' {in} limit key by executions?
        Public ExecutionsCount As Int32
        ' {in} number of executions
        Public UseDaysLimit As Boolean
        ' {in} limit key by days?
        Public DaysCount As Int32
        ' {in} number of days
        Public UseRunTimeLimit As Boolean
        ' {in} limit key by run time?
        Public RunTimeMinutes As Int32
        ' {in} run time minutes
        Public UseGlobalTimeLimit As Boolean
        ' {in} limit key by global time?
        Public GlobalTimeMinutes As Int32
        ' {in} global time minutes
        Public UseCountyLimit As Boolean
        ' {in} limit key by country?
        Public CountryCode As Int32
        ' {in} country code
        Public UseRegisterAfter As Boolean
        ' {in} register key after date?
        Public RegisterAfterYear As Int32
        ' {in} register after year
        Public RegisterAfterMonth As Int32
        ' {in} register after month
        Public RegisterAfterDay As Int32
        ' {in} register after day
        Public UseRegisterBefore As Boolean
        ' {in} register key before date?
        Public RegisterBeforeYear As Int32
        ' {in} register before year
        Public RegisterBeforeMonth As Int32
        ' {in} register before month
        Public RegisterBeforeDay As Int32
        ' {in} register before day
        Public EncryptedConstant As Int32
        ' {in} Encryption Constant - should be extracted from project file
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=NUMBER_OF_CRYPTED_SECTIONS)> _
        Public EncryptedSections As Byte()
        ' {in} Crypted sections
        Public PrivateKey As String
        ' {in} Private Key - should be extracted from project file
        Public PublicKey As String
        ' {in} Public Key - should be extracted from project file
    End Structure
    Public Structure TKeyGenParamsA
        Public KeyMode As Int32
        ' {in} key generation mode (~RSA ???)
        Public KeyBase As Int32
        ' {in} key output base (Base ???)
        Public KeyWithHyphens As Boolean
        ' {in} add hyphens to the key?
        Public Key As String
        ' {in} buffer for registration key
        Public KeyLen As Int32
        ' {in} registration key buffer size
        Public RegInfo As String
        ' {in} registration info/name
        Public UseKeyExpiration As Boolean
        ' {in} use key expiration?
        Public ExpirationYear As Int32
        ' {in} key expiration year
        Public ExpirationMonth As Int32
        ' {in} key expiration month
        Public ExpirationDay As Int32
        ' {in} key expiration day
        Public UseHardwareLocking As Boolean
        ' {in} is key hardware locked?
        Public HardwareID As String
        ' {in} pointer to null terminated hardware string
        Public UseExecutionsLimit As Boolean
        ' {in} limit key by executions?
        Public ExecutionsCount As Int32
        ' {in} number of executions
        Public UseDaysLimit As Boolean
        ' {in} limit key by days?
        Public DaysCount As Int32
        ' {in} number of days
        Public UseRunTimeLimit As Boolean
        ' {in} limit key by run time?
        Public RunTimeMinutes As Int32
        ' {in} run time minutes
        Public UseGlobalTimeLimit As Boolean
        ' {in} limit key by global time?
        Public GlobalTimeMinutes As Int32
        ' {in} global time minutes
        Public UseCountyLimit As Boolean
        ' {in} limit key by country?
        Public CountryCode As Int32
        ' {in} country code
        Public UseRegisterAfter As Boolean
        ' {in} register key after date?
        Public RegisterAfterYear As Int32
        ' {in} register after year
        Public RegisterAfterMonth As Int32
        ' {in} register after month
        Public RegisterAfterDay As Int32
        ' {in} register after day
        Public UseRegisterBefore As Boolean
        ' {in} register key before date?
        Public RegisterBeforeYear As Int32
        ' {in} register before year
        Public RegisterBeforeMonth As Int32
        ' {in} register before month
        Public RegisterBeforeDay As Int32
        ' {in} register before day
        Public EncryptedConstant As Int32
        ' {in} Encryption Constant - should be extracted from project file
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=NUMBER_OF_CRYPTED_SECTIONS)> _
        Public EncryptedSections As Byte()
        ' {in} Crypted sections
        Public PrivateKey As String
        ' {in} Private Key - should be extracted from project file
        Public PublicKey As String
        ' {in} Public Key - should be extracted from project file
    End Structure
    Public Structure TKeyGenParamsW
        Public KeyMode As Int32
        ' {in} key generation mode (~RSA ???)
        Public KeyBase As Int32
        ' {in} key output base (Base ???)
        Public KeyWithHyphens As Boolean
        ' {in} add hyphens to the key?
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public Key As String
        ' {in} buffer for registration key
        Public KeyLen As Int32
        ' {in} registration key buffer size
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public RegInfo As String
        ' {in} registration info/name
        Public UseKeyExpiration As Boolean
        ' {in} use key expiration?
        Public ExpirationYear As Int32
        ' {in} key expiration year
        Public ExpirationMonth As Int32
        ' {in} key expiration month
        Public ExpirationDay As Int32
        ' {in} key expiration day
        Public UseHardwareLocking As Boolean
        ' {in} is key hardware locked?
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public HardwareID As String
        ' {in} pointer to null terminated hardware string
        Public UseExecutionsLimit As Boolean
        ' {in} limit key by executions?
        Public ExecutionsCount As Int32
        ' {in} number of executions
        Public UseDaysLimit As Boolean
        ' {in} limit key by days?
        Public DaysCount As Int32
        ' {in} number of days
        Public UseRunTimeLimit As Boolean
        ' {in} limit key by run time?
        Public RunTimeMinutes As Int32
        ' {in} run time minutes
        Public UseGlobalTimeLimit As Boolean
        ' {in} limit key by global time?
        Public GlobalTimeMinutes As Int32
        ' {in} global time minutes
        Public UseCountyLimit As Boolean
        ' {in} limit key by country?
        Public CountryCode As Int32
        ' {in} country code
        Public UseRegisterAfter As Boolean
        ' {in} register key after date?
        Public RegisterAfterYear As Int32
        ' {in} register after year
        Public RegisterAfterMonth As Int32
        ' {in} register after month
        Public RegisterAfterDay As Int32
        ' {in} register after day
        Public UseRegisterBefore As Boolean
        ' {in} register key before date?
        Public RegisterBeforeYear As Int32
        ' {in} register before year
        Public RegisterBeforeMonth As Int32
        ' {in} register before month
        Public RegisterBeforeDay As Int32
        ' {in} register before day
        Public EncryptedConstant As Int32
        ' {in} Encryption Constant - should be extracted from project file
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=NUMBER_OF_CRYPTED_SECTIONS)> _
        Public EncryptedSections As Byte()
        ' {in} Crypted sections
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public PrivateKey As String
        ' {in} Private Key - should be extracted from project file
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public PublicKey As String
        ' {in} Public Key - should be extracted from project file
    End Structure

    ' Enigma keygen API
    <DllImport("keygen.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function KG_GenerateRegistrationKey(ByRef kg As TKeyGenParams) As UInteger
    End Function
    <DllImport("keygen.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function KG_GenerateRegistrationKeyA(ByRef kg As TKeyGenParamsA) As UInteger
    End Function
    <DllImport("keygen.dll", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function KG_GenerateRegistrationKeyW(ByRef kg As TKeyGenParamsW) As UInteger
    End Function

    <DllImport("keygen.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function KG_GenerateRegistrationKeyFromProject(FileName As String, ByRef kg As TKeyGenParams) As UInteger
    End Function
    <DllImport("keygen.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function KG_GenerateRegistrationKeyFromProjectA(FileName As String, ByRef kg As TKeyGenParamsA) As UInteger
    End Function
    <DllImport("keygen.dll", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function KG_GenerateRegistrationKeyFromProjectW(FileName As String, ByRef kg As TKeyGenParamsW) As UInteger
    End Function

    <DllImport("keygen.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function KG_VerifyRegistrationInfo(ByRef kv As TKeyVerifyParams) As UInteger
    End Function
    <DllImport("keygen.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function KG_VerifyRegistrationInfoA(ByRef kv As TKeyVerifyParamsA) As UInteger
    End Function
    <DllImport("keygen.dll", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function KG_VerifyRegistrationInfoW(ByRef kv As TKeyVerifyParamsW) As UInteger
    End Function

    <DllImport("keygen.dll", CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function KG_VerifyRegistrationInfoFromProject(FileName As String, ByRef kv As TKeyVerifyParams) As UInteger
    End Function
    <DllImport("keygen.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function KG_VerifyRegistrationInfoFromProjectA(FileName As String, ByRef kv As TKeyVerifyParamsA) As UInteger
    End Function
    <DllImport("keygen.dll", CharSet:=CharSet.Unicode, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function KG_VerifyRegistrationInfoFromProjectW(FileName As String, ByRef kv As TKeyVerifyParamsW) As UInteger
    End Function
End Class
