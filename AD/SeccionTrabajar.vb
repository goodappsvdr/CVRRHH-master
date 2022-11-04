Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO
Public Class SeccionTrabajar
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn2")
    End Sub

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SeccionTrabajar_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorId(ID_SeccionTrabajar As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SeccionTrabajar_BuscarPorId", ID_SeccionTrabajar)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorId_Legajo(ID_PersonalLegajo As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SeccionTrabajar_BuscarPorId_Legajo", ID_PersonalLegajo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ID_PersonalLegajo As Integer, Descripcion As String) As Double
        Try
            Return oDatabase.ExecuteScalar("SeccionTrabajar_Agregar", ID_PersonalLegajo, Descripcion)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ID_SeccionTrabajar As Integer, Descripcion As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SeccionTrabajar_Modificar", ID_SeccionTrabajar, Descripcion)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class
