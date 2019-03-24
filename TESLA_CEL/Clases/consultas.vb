Imports MySql.Data.MySqlClient
Public Class consultas
    Public Shared Function login(puser, ppass) As Boolean
        Dim con As MySqlConnection = conexion.conection
        Dim log As Boolean = False
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT us.user, us.password, lvl.id_level FROM users us JOIN levels lvl WHERE us.id_level = lvl.id_level AND us.user = '{0}' AND us.password='{1}'", puser, ppass), con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            If reader.HasRows = True Then
                log = True
                Principal.userLevel = reader(2).ToString
                Principal.username = reader(0).ToString
            End If
        End If
        con.Close()
        Return log
    End Function
    Public Shared Function getUsuarios() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM users"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getUsuarios2(pusuario) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT id_user,user,password FROM users where user='{0}'", pusuario), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getLevel() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT id_level, identifier FROM levels"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Sub updUser(pid, puser, ppass, plevel)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("UPDATE users SET user= '{0}', password='{1}', id_level='{2}' where id_user = '{3}'", puser, ppass, plevel, pid), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Sub insUser(puser, ppass, plevel)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO users(user,password,id_level) VALUES('{0}','{1}','{2}')", puser, ppass, plevel), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Function getProductos() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductosByCategory(pcat) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products WHERE category='{0}'", pcat), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getCategoria() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT category FROM products"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductosByProductos(pproducto) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products WHERE name='{0}'", pproducto), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Sub insProducto(pname, pdescription, pprice, pbarcode, pquantity, pmin, pdate, pcategory, pidprovee)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO products(name,description,price,bar_code,quantity,min,date,category,id_provider) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", pname, pdescription, pprice, pbarcode, pquantity, pmin, pdate, pcategory, pidprovee), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Function getProovedor() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM providers"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductoByProveedor(pid) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT name FROM products  WHERE id_provider = '{0}'", pid), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Sub delProducto(pname)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("DELETE FROM products WHERE name='{0}'", pname), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Function getProductoByBarCode(pbarcode) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT name,price FROM products  WHERE bar_code = '{0}'", pbarcode), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductosByProduct(pproduct) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT name,price FROM products  WHERE name = '{0}'", pproduct), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function

End Class
