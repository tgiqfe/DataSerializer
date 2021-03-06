@echo off
pushd %~dp0

rem # プロジェクト名
set ProjectName=<Project Name>

rem # Code for DataSerializer
echo DataSerializer Code Update

set DataSerializerCS=%ProjectName%\Serialize\DataSerializer.cs
set DataTypeCS=%ProjectName%\Serialize\DataType.cs
set DictionaryExtensionsCS=%ProjectName%\Serialize\DictionaryExtensions.cs
set SerializableDictionaryCS=%ProjectName%\Serialize\SerializableDictionary.cs
set JsonCS=%ProjectName%\Serialize\JSON.cs
set XmlCS=%ProjectName%\Serialize\XML.cs
set YmlCS=%ProjectName%\Serialize\YML.cs
set IniFile=%ProjectName%\Serialize\IniFile.cs

set beforeNamespace=namespace DataSerializer
set afterNamespace=namespace %ProjectName%.Serialize

powershell -Command "Invoke-WebRequest -Uri \"https://raw.githubusercontent.com/tgiqfe/DataSerializer/master/DataSerializer/Serialize/DataSerializer.cs\" -OutFile \".\%DataSerializerCS%\""
powershell -Command "Invoke-WebRequest -Uri \"https://raw.githubusercontent.com/tgiqfe/DataSerializer/master/DataSerializer/Serialize/DataType.cs\" -OutFile \".\%DataTypeCS%\""
powershell -Command "Invoke-WebRequest -Uri \"https://raw.githubusercontent.com/tgiqfe/DataSerializer/master/DataSerializer/Serialize/DictionaryExtensions.cs\" -OutFile \".\%DictionaryExtensionsCS%\""
powershell -Command "Invoke-WebRequest -Uri \"https://raw.githubusercontent.com/tgiqfe/DataSerializer/master/DataSerializer/Serialize/SerializableDictionary.cs\" -OutFile \".\%SerializableDictionaryCS%\""
powershell -Command "Invoke-WebRequest -Uri \"https://raw.githubusercontent.com/tgiqfe/DataSerializer/master/DataSerializer/Serialize/JSON.cs\" -OutFile \".\%JsonCS%\""
powershell -Command "Invoke-WebRequest -Uri \"https://raw.githubusercontent.com/tgiqfe/DataSerializer/master/DataSerializer/Serialize/XML.cs\" -OutFile \".\%XmlCS%\""
powershell -Command "Invoke-WebRequest -Uri \"https://raw.githubusercontent.com/tgiqfe/DataSerializer/master/DataSerializer/Serialize/YML.cs\" -OutFile \".\%YmlCS%\""
powershell -Command "Invoke-WebRequest -Uri \"https://raw.githubusercontent.com/tgiqfe/DataSerializer/master/DataSerializer/Serialize/IniFile.cs\" -OutFile \".\%IniFile%\""

powershell -Command "(Get-Content \".\%DataSerializerCS%\") -replace \"`n\",\"`r`n\" | Out-File \".\%DataSerializerCS%\" -Encoding UTF8"
powershell -Command "(Get-Content \".\%DataTypeCS%\") -replace \"`n\",\"`r`n\" | Out-File \".\%DataTypeCS%\" -Encoding UTF8"
powershell -Command "(Get-Content \".\%DictionaryExtensionsCS%\") -replace \"`n\",\"`r`n\" | Out-File \".\%DictionaryExtensionsCS%\" -Encoding UTF8"
powershell -Command "(Get-Content \".\%SerializableDictionaryCS%\") -replace \"`n\",\"`r`n\" | Out-File \".\%SerializableDictionaryCS%\" -Encoding UTF8"
powershell -Command "(Get-Content \".\%JsonCS%\") -replace \"`n\",\"`r`n\" | Out-File \".\%JsonCS%\" -Encoding UTF8"
powershell -Command "(Get-Content \".\%XmlCS%\") -replace \"`n\",\"`r`n\" | Out-File \".\%XmlCS%\" -Encoding UTF8"
powershell -Command "(Get-Content \".\%YmlCS%\") -replace \"`n\",\"`r`n\" | Out-File \".\%YmlCS%\" -Encoding UTF8"
powershell -Command "(Get-Content \".\%IniFile%\") -replace \"`n\",\"`r`n\" | Out-File \".\%IniFile%\" -Encoding UTF8"

powershell -Command "(Get-Content \".\%DataSerializerCS%\") -replace \"%beforeNamespace%\",\"%afterNamespace%\" | Out-File \".\%DataSerializerCS%\" -Encoding UTF8"
powershell -Command "(Get-Content \".\%DataTypeCS%\") -replace \"%beforeNamespace%\",\"%afterNamespace%\" | Out-File \".\%DataTypeCS%\" -Encoding UTF8"
powershell -Command "(Get-Content \".\%DictionaryExtensionsCS%\") -replace \"%beforeNamespace%\",\"%afterNamespace%\" | Out-File \".\%DictionaryExtensionsCS%\" -Encoding UTF8"
powershell -Command "(Get-Content \".\%SerializableDictionaryCS%\") -replace \"%beforeNamespace%\",\"%afterNamespace%\" | Out-File \".\%SerializableDictionaryCS%\" -Encoding UTF8"
powershell -Command "(Get-Content \".\%JsonCS%\") -replace \"%beforeNamespace%\",\"%afterNamespace%\" | Out-File \".\%JsonCS%\" -Encoding UTF8"
powershell -Command "(Get-Content \".\%XmlCS%\") -replace \"%beforeNamespace%\",\"%afterNamespace%\" | Out-File \".\%XmlCS%\" -Encoding UTF8"
powershell -Command "(Get-Content \".\%YmlCS%\") -replace \"%beforeNamespace%\",\"%afterNamespace%\" | Out-File \".\%YmlCS%\" -Encoding UTF8"
powershell -Command "(Get-Content \".\%IniFile%\") -replace \"%beforeNamespace%\",\"%afterNamespace%\" | Out-File \".\%IniFile%\" -Encoding UTF8"
