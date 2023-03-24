Option Strict On
Option Explicit On

'
'   INIReader class
'     written in VB.NET                          Version: 1.0
'     by The KPD-Team                            Date: 2002/01/16
'     Copyright © 2002                           Comments to: KPDTeam@allapi.net
'                                                URL: http://www.allapi.net/
'
'
'  You are free to use this class file in your own applications,
'  but you are expressly forbidden from selling or otherwise
'  distributing this code as source without prior written consent.
'  This includes both posting samples on a web site or otherwise
'  reproducing it in text or html format.
'
'  Although much care has gone into the programming of this class
'  file, The KPD-Team does not accept any responsibility for damage
'  caused by possible errors in this class and/or by misuse of this
'  class.
'

Imports System
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Collections
Imports Microsoft.VisualBasic

'/// <summary>
'/// The INIReader class can read keys from and write keys to an INI file.
'/// </summary>
'/// <remarks>
'/// This class uses several Win32 API functions to read from and write to INI files. Therefore, it requires at least Windows95 or WindowsNT3.1
'/// </remarks>
Public Class clsArquivoIni
  'Private variables and constants
  Private m_Filename As String
  Private m_Section As String
  Private Const MAX_ENTRY As Integer = 32768

  ' <API-DECLARES>
  <DllImport("KERNEL32.DLL", EntryPoint:="GetPrivateProfileIntA", SetLastError:=False, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
  Private Shared Function GetPrivateProfileInt(ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal nDefault As Integer, ByVal lpFileName As String) As Integer
  End Function

  <DllImport("KERNEL32.DLL", EntryPoint:="WritePrivateProfileStringA", SetLastError:=False, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
 Private Shared Function WritePrivateProfileString(ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
  End Function

  <DllImport("KERNEL32.DLL", EntryPoint:="GetPrivateProfileStringA", SetLastError:=False, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
 Private Shared Function GetPrivateProfileString(ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
  End Function

  <DllImport("KERNEL32.DLL", EntryPoint:="WritePrivateProfileStructA", SetLastError:=False, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
 Private Shared Function WritePrivateProfileStruct(ByVal lpszSection As String, ByVal lpszKey As String, ByVal lpStruct() As Byte, ByVal uSizeStruct As Integer, ByVal szFile As String) As Integer
  End Function

  <DllImport("KERNEL32.DLL", EntryPoint:="GetPrivateProfileStructA", SetLastError:=False, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
 Private Shared Function GetPrivateProfileStruct(ByVal lpszSection As String, ByVal lpszKey As String, ByVal lpStruct() As Byte, ByVal uSizeStruct As Integer, ByVal szFile As String) As Integer
  End Function

  <DllImport("KERNEL32.DLL", EntryPoint:="GetPrivateProfileSectionNamesA", SetLastError:=False, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
 Private Shared Function GetPrivateProfileSectionNames(ByVal lpszReturnBuffer() As Byte, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
  End Function

  <DllImport("KERNEL32.DLL", EntryPoint:="WritePrivateProfileSectionA", SetLastError:=False, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
 Private Shared Function WritePrivateProfileSection(ByVal lpAppName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
  End Function
  ' </API-DECLARES>

  '/// <summary>Constructs a new INIReader object.</summary>
  '/// <param name="File">Specifies the INI file to use.</param>
  'Public Sub New(ByVal File As String)
  '	Filename = File
  'End Sub

  '/// <summary>Specifies the INI file to use.</summary>
  '/// <value>A <see cref="String">String</see> representing the full path of the INI file.</value>
  Public Property FileName() As String
    Get
      Return m_Filename
    End Get

    Set(ByVal Value As String)
      m_Filename = Value
    End Set
  End Property

  '/// <summary>Specifies the section you're working in. (aka 'the active section')</summary>
  '/// <value>A <see cref="String">String</see> representing the section you're working in.</value>
  Public Property Section() As String
    Get
      Return m_Section
    End Get

    Set(ByVal Value As String)
      m_Section = Value
    End Set
  End Property

  '/// <summary>Reads an <see cref="Int32">Integer</see> from the specified key of the specified section.</summary>
  '/// <param name="Section">Specifies the section to search in.</param>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <param name="DefVal">Specifies the value to return if the specified key isn't found.</param>
  '/// <returns>Returns the value of the specified Section/Key pair, or returns the default value if the specified Section/Key pair isn't found in the INI file.</returns>
  Public Overloads Function ReadInteger(ByVal Section As String, ByVal Key As String, ByVal DefVal As Integer) As Integer
    Try
      Return GetPrivateProfileInt(Section, Key, DefVal, FileName)
    Catch
      Return DefVal
    End Try
  End Function
  '/// <summary>Reads an <see cref="Int32">Integer</see> from the specified key of the specified section.</summary>
  '/// <param name="Section">Specifies the section to search in.</param>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <returns>Returns the value of the specified Section/Key pair, or returns 0 if the specified Section/Key pair isn't found in the INI file.</returns>
  Public Overloads Function ReadInteger(ByVal Section As String, ByVal Key As String) As Integer
    Return ReadInteger(Section, Key, 0)
  End Function
  '/// <summary>Reads an <see cref="Int32">Integer</see> from the specified key of the active section.</summary>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <param name="DefVal">Specifies the section to search in.</param>
  '/// <returns>Returns the value of the specified Key, or returns the default value if the specified Key isn't found in the active section of the INI file.</returns>
  Public Overloads Function ReadInteger(ByVal Key As String, ByVal DefVal As Integer) As Integer
    Return ReadInteger(Section, Key, DefVal)
  End Function
  '/// <summary>Reads an <see cref="Int32">Integer</see> from the specified key of the active section.</summary>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <returns>Returns the value of the specified Key, or returns 0 if the specified Key isn't found in the active section of the INI file.</returns>
  Public Overloads Function ReadInteger(ByVal Key As String) As Integer
    Return ReadInteger(Key, 0)
  End Function

  '/// <summary>Reads a <see cref="String">String</see> from the specified key of the specified section.</summary>
  '/// <param name="Section">Specifies the section to search in.</param>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <param name="DefVal">Specifies the value to return if the specified key isn't found.</param>
  '/// <returns>Returns the value of the specified Section/Key pair, or returns the default value if the specified Section/Key pair isn't found in the INI file.</returns>
  Public Overloads Function ReadString(ByVal Section As String, ByVal Key As String, ByVal DefVal As String) As String
    Try
      Dim sb As New StringBuilder(MAX_ENTRY)
      Dim Ret As Integer = GetPrivateProfileString(Section, Key, DefVal, sb, MAX_ENTRY, FileName)
      Return sb.ToString
    Catch
      Write(Section, Key, DefVal)
      Return DefVal
    End Try
  End Function
  '/// <summary>Reads a <see cref="String">String</see> from the specified key of the specified section.</summary>
  '/// <param name="Section">Specifies the section to search in.</param>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <returns>Returns the value of the specified Section/Key pair, or returns an empty String if the specified Section/Key pair isn't found in the INI file.</returns>
  Public Overloads Function ReadString(ByVal Section As String, ByVal Key As String) As String
    Return ReadString(Section, Key, "")
  End Function
  '/// <summary>Reads a <see cref="String">String</see> from the specified key of the active section.</summary>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <returns>Returns the value of the specified Key, or returns an empty String if the specified Key isn't found in the active section of the INI file.</returns>
  Public Overloads Function ReadString(ByVal Key As String) As String
    Return ReadString(Section, Key)
  End Function

  '/// <summary>Reads a <see cref="Int64">Long</see> from the specified key of the specified section.</summary>
  '/// <param name="Section">Specifies the section to search in.</param>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <param name="DefVal">Specifies the value to return if the specified key isn't found.</param>
  '/// <returns>Returns the value of the specified Section/Key pair, or returns the default value if the specified Section/Key pair isn't found in the INI file.</returns>
  Public Overloads Function ReadLong(ByVal Section As String, ByVal Key As String, ByVal DefVal As Long) As Long
    Return Long.Parse(ReadString(Section, Key, DefVal.ToString))
  End Function
  '/// <summary>Reads a <see cref="Int64">Long</see> from the specified key of the specified section.</summary>
  '/// <param name="Section">Specifies the section to search in.</param>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <returns>Returns the value of the specified Section/Key pair, or returns 0 if the specified Section/Key pair isn't found in the INI file.</returns>
  Public Overloads Function ReadLong(ByVal Section As String, ByVal Key As String) As Long
    Return ReadLong(Section, Key, 0)
  End Function
  '/// <summary>Reads a <see cref="Int64">Long</see> from the specified key of the active section.</summary>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <param name="DefVal">Specifies the section to search in.</param>
  '/// <returns>Returns the value of the specified Key, or returns the default value if the specified Key isn't found in the active section of the INI file.</returns>
  Public Overloads Function ReadLong(ByVal Key As String, ByVal DefVal As Long) As Long
    Return ReadLong(Section, Key, DefVal)
  End Function
  '/// <summary>Reads a <see cref="Int64">Long</see> from the specified key of the active section.</summary>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <returns>Returns the value of the specified Key, or returns 0 if the specified Key isn't found in the active section of the INI file.</returns>
  Public Overloads Function ReadLong(ByVal Key As String) As Long
    Return ReadLong(Key, 0)
  End Function

  '/// <summary>Reads a <see cref="Byte">Byte</see> array from the specified key of the specified section.</summary>
  '/// <param name="Section">Specifies the section to search in.</param>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <param name="Length">Specifies the value to return if the specified key isn't found.</param>
  '/// <returns>Returns the value of the specified Section/Key pair, or returns Nothing (Null in C#, C++.NET) if the specified Section/Key pair isn't found in the INI file.</returns>
  Public Function ReadByteArray(ByVal Section As String, ByVal Key As String, ByVal Length As Integer) As Byte()
    If Length > 0 Then
      Try
        Dim Buffer(Length - 1) As Byte
        If GetPrivateProfileStruct(Section, Key, Buffer, Buffer.Length, FileName) = 0 Then
          Return Nothing
        Else
          Return Buffer
        End If
      Catch
        Return Nothing
      End Try
    Else
      Return Nothing
    End If
  End Function
  '/// <summary>Reads a <see cref="Byte">Byte</see> array from the specified key of the active section.</summary>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <param name="Length">Specifies the value to return if the specified key isn't found.</param>
  '/// <returns>Returns the value of the specified Key, or returns Nothing (Null in C#, C++.NET) if the specified Key pair isn't found in the active section of the INI file.</returns>
  Public Function ReadByteArray(ByVal Key As String, ByVal Length As Integer) As Byte()
    Return ReadByteArray(Section, Key, Length)
  End Function

  '/// <summary>Reads a <see cref="Boolean">Boolean</see> from the specified key of the specified section.</summary>
  '/// <param name="Section">Specifies the section to search in.</param>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <param name="DefVal">Specifies the value to return if the specified key isn't found.</param>
  '/// <returns>Returns the value of the specified Section/Key pair, or returns the default value if the specified Section/Key pair isn't found in the INI file.</returns>
  Public Overloads Function ReadBoolean(ByVal Section As String, ByVal Key As String, ByVal DefVal As Boolean) As Boolean
    Return Boolean.Parse(ReadString(Section, Key, DefVal.ToString))
  End Function
  '/// <summary>Reads a <see cref="Boolean">Boolean</see> from the specified key of the specified section.</summary>
  '/// <param name="Section">Specifies the section to search in.</param>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <returns>Returns the value of the specified Section/Key pair, or returns False if the specified Section/Key pair isn't found in the INI file.</returns>
  Public Overloads Function ReadBoolean(ByVal Section As String, ByVal Key As String) As Boolean
    Return ReadBoolean(Section, Key, False)
  End Function
  '/// <summary>Reads a <see cref="Boolean">Boolean</see> from the specified key of the specified section.</summary>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <param name="DefVal">Specifies the value to return if the specified key isn't found.</param>
  '/// <returns>Returns the value of the specified Key pair, or returns the default value if the specified Key isn't found in the active section of the INI file.</returns>
  Public Overloads Function ReadBoolean(ByVal Key As String, ByVal DefVal As Boolean) As Boolean
    Return ReadBoolean(Section, Key, DefVal)
  End Function
  '/// <summary>Reads a <see cref="Boolean">Boolean</see> from the specified key of the specified section.</summary>
  '/// <param name="Key">Specifies the key from which to return the value.</param>
  '/// <returns>Returns the value of the specified Key, or returns False if the specified Key isn't found in the active section of the INI file.</returns>
  Public Overloads Function ReadBoolean(ByVal Key As String) As Boolean
    Return ReadBoolean(Section, Key)
  End Function

  '/// <summary>Writes an <see cref="Integer">Integer</see> to the specified key in the specified section.</summary>
  '/// <param name="Section">Specifies the section to write in.</param>
  '/// <param name="Key">Specifies the key to write to.</param>
  '/// <param name="Value">Specifies the value to write.</param>
  '/// <returns>Returns True if the function succeeds, False otherwise.</returns>
  Public Overloads Function Write(ByVal Section As String, ByVal Key As String, ByVal Value As Integer) As Boolean
    Try
      Return (WritePrivateProfileString(Section, Key, Value.ToString, FileName) <> 0)
    Catch
      Return False
    End Try
  End Function
  '/// <summary>Writes an <see cref="Integer">Integer</see> to the specified key in the active section.</summary>
  '/// <param name="Key">Specifies the key to write to.</param>
  '/// <param name="Value">Specifies the value to write.</param>
  '/// <returns>Returns True if the function succeeds, False otherwise.</returns>
  Public Overloads Function Write(ByVal Key As String, ByVal Value As Integer) As Boolean
    Return Write(Section, Key, Value)
  End Function
  '/// <summary>Writes a <see cref="String">String</see> to the specified key in the specified section.</summary>
  '/// <param name="Section">Specifies the section to write in.</param>
  '/// <param name="Key">Specifies the key to write to.</param>
  '/// <param name="Value">Specifies the value to write.</param>
  '/// <returns>Returns True if the function succeeds, False otherwise.</returns>
  Public Overloads Function Write(ByVal Section As String, ByVal Key As String, ByVal Value As String) As Boolean
    Try
      Return (WritePrivateProfileString(Section, Key, Value, FileName) <> 0)
    Catch
      Return False
    End Try
  End Function
  '/// <summary>Writes a <see cref="String">String</see> to the specified key in the active section.</summary>
  '/// <param name="Key">Specifies the key to write to.</param>
  '/// <param name="Value">Specifies the value to write.</param>
  '/// <returns>Returns True if the function succeeds, False otherwise.</returns>
  Public Overloads Function Write(ByVal Key As String, ByVal Value As String) As Boolean
    Return Write(Section, Key, Value)
  End Function
  '/// <summary>Writes a <see cref="Long">Long</see> to the specified key in the specified section.</summary>
  '/// <param name="Section">Specifies the section to write in.</param>
  '/// <param name="Key">Specifies the key to write to.</param>
  '/// <param name="Value">Specifies the value to write.</param>
  '/// <returns>Returns True if the function succeeds, False otherwise.</returns>
  Public Overloads Function Write(ByVal Section As String, ByVal Key As String, ByVal Value As Long) As Boolean
    Return Write(Section, Key, Value.ToString)
  End Function
  '/// <summary>Writes a <see cref="Long">Long</see> to the specified key in the active section.</summary>
  '/// <param name="Key">Specifies the key to write to.</param>
  '/// <param name="Value">Specifies the value to write.</param>
  '/// <returns>Returns True if the function succeeds, False otherwise.</returns>
  Public Overloads Function Write(ByVal Key As String, ByVal Value As Long) As Boolean
    Return Write(Section, Key, Value)
  End Function
  '/// <summary>Writes a <see cref="Byte">Byte</see> array to the specified key in the specified section.</summary>
  '/// <param name="Section">Specifies the section to write in.</param>
  '/// <param name="Key">Specifies the key to write to.</param>
  '/// <param name="Value">Specifies the value to write.</param>
  '/// <returns>Returns True if the function succeeds, False otherwise.</returns>
  Public Overloads Function Write(ByVal Section As String, ByVal Key As String, ByVal Value() As Byte) As Boolean
    Try
      Return (WritePrivateProfileStruct(Section, Key, Value, Value.Length, FileName) <> 0)
    Catch
      Return False
    End Try
  End Function
  '/// <summary>Writes a <see cref="Byte">Byte</see> array to the specified key in the active section.</summary>
  '/// <param name="Key">Specifies the key to write to.</param>
  '/// <param name="Value">Specifies the value to write.</param>
  '/// <returns>Returns True if the function succeeds, False otherwise.</returns>
  Public Overloads Function Write(ByVal Key As String, ByVal Value() As Byte) As Boolean
    Return Write(Section, Key, Value)
  End Function
  '/// <summary>Writes a <see cref="Boolean">Boolean</see> to the specified key in the specified section.</summary>
  '/// <param name="Section">Specifies the section to write in.</param>
  '/// <param name="Key">Specifies the key to write to.</param>
  '/// <param name="Value">Specifies the value to write.</param>
  '/// <returns>Returns True if the function succeeds, False otherwise.</returns>
  Public Overloads Function Write(ByVal Section As String, ByVal Key As String, ByVal Value As Boolean) As Boolean
    Return Write(Section, Key, Value.ToString)
  End Function
  '/// <summary>Writes a <see cref="Boolean">Boolean</see> to the specified key in the active section.</summary>
  '/// <param name="Key">Specifies the key to write to.</param>
  '/// <param name="Value">Specifies the value to write.</param>
  '/// <returns>Returns True if the function succeeds, False otherwise.</returns>
  Public Overloads Function Write(ByVal Key As String, ByVal Value As Boolean) As Boolean
    Return Write(Section, Key, Value)
  End Function

  '/// <summary>Deletes a key from the specified section.</summary>
  '/// <param name="Section">Specifies the section to delete from.</param>
  '/// <param name="Key">Specifies the key to delete.</param>
  '/// <returns>Returns True if the function succeeds, False otherwise.</returns>
  Public Function DeleteKey(ByVal Section As String, ByVal Key As String) As Boolean
    Try
      Return (WritePrivateProfileString(Section, Key, Nothing, FileName) <> 0)
    Catch
      Return False
    End Try
  End Function
  '/// <summary>Deletes a key from the active section.</summary>
  '/// <param name="Key">Specifies the key to delete.</param>
  '/// <returns>Returns True if the function succeeds, False otherwise.</returns>
  Public Function DeleteKey(ByVal Key As String) As Boolean
    Try
      Return (WritePrivateProfileString(Section, Key, Nothing, FileName) <> 0)
    Catch
      Return False
    End Try
  End Function

  '/// <summary>Deletes a section from an INI file.</summary>
  '/// <param name="Section">Specifies the section to delete.</param>
  '/// <returns>Returns True if the function succeeds, False otherwise.</returns>
  Public Function DeleteSection(ByVal Section As String) As Boolean
    Try
      Return WritePrivateProfileSection(Section, Nothing, FileName) <> 0
    Catch
      Return False
    End Try
  End Function

  '/// <summary>Retrieves a list of all available sections in the INI file.</summary>
  '/// <returns>Returns an <see cref="ArrayList">ArrayList</see> with all available sections.</returns>
  Public Function GetSectionNames() As ArrayList
    GetSectionNames = New ArrayList()
    Dim Buffer(MAX_ENTRY) As Byte
    Dim BuffStr As String
    Dim PrevPos As Integer = 0
    Dim Length As Integer
    Try
      Length = GetPrivateProfileSectionNames(Buffer, MAX_ENTRY, FileName)
    Catch
      Exit Function
    End Try
    Dim ASCII As New ASCIIEncoding()
    If Length > 0 Then
      BuffStr = ASCII.GetString(Buffer)
      Length = 0
      PrevPos = -1
      Do
        Length = BuffStr.IndexOf(ControlChars.NullChar, PrevPos + 1)
        If Length - PrevPos = 1 OrElse Length = -1 Then Exit Do
        Try
          GetSectionNames.Add(BuffStr.Substring(PrevPos + 1, Length - PrevPos))
        Catch
        End Try
        PrevPos = Length
      Loop
    End If
  End Function

  Public Sub Dispose()
    GC.Collect()
  End Sub
End Class

