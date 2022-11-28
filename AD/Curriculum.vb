Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO
Public Class Curriculum
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn2")
    End Sub

    Public Function BuscarPorID(ByVal ID_Curriculum As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Curriculum_BuscarPorId", ID_Curriculum)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorId_PL(ByVal ID_PersonalLegajo As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Curriculum_BuscarPorId_PL", ID_PersonalLegajo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorEmail(ByVal Email As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Curriculum_BuscarPorEmail", Email)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ID_PersonalLegajo As Integer, Email As String, Archivo As String) As Double
        Try
            Return oDatabase.ExecuteScalar("Curriculum_Agregar", ID_PersonalLegajo, Email, Archivo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ID_Curriculum As Integer, ID_PersonalLegajo As Integer, Email As String, Archivo As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Curriculum_Modificar", ID_Curriculum, ID_PersonalLegajo, Email, Archivo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class
