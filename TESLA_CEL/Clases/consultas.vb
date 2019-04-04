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
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT pr.name, pr.description, pr.price, pr.bar_code, pr.quantity, pr.min, pr.date,pr.category, prov.provider, prov.contact, prov.address, prov.phone FROM products pr JOIN providers prov"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    ' Public Shared Function getProductosByCategory(pcat) As DataTable
    '  Dim con As MySqlConnection = conexion.conection
    '  Dim dt As New DataTable
    '  Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products WHERE category='{0}'", pcat), con)
    '  Dim adap As New MySqlDataAdapter(cmd)
    ' adap.Fill(dt)
    '  con.Close()
    'Return dt
    Public Shared Function getProductosByDate(pdate1, pdate2) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT pr.name, pr.description, pr.price, pr.bar_code, pr.quantity, pr.min, pr.date,pr.category, prov.provider, prov.contact, prov.address, prov.phone FROM products pr JOIN providers prov WHERE pr.date >='{0}' AND pr.date <='{1}'", pdate1, pdate2), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    ' Public Shared Function getCategoria() As DataTable
    'Dim con As MySqlConnection = conexion.conection
    'Dim dt As New DataTable
    'Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT category FROM products"), con)
    'Dim adap As New MySqlDataAdapter(cmd)
    '   adap.Fill(dt)
    '  con.Close()
    'Return dt
    'End Function
    Public Shared Function getProveedor() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT provider FROM providers"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function

    Public Shared Function getProductosByProductos(pproducto) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT pr.name, pr.description, pr.price, pr.bar_code, pr.quantity, pr.min, pr.date,pr.category, prov.provider, prov.contact, prov.address, prov.phone FROM products  pr JOIN providers prov WHERE pr.name='{0}'", pproducto), con)
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
    Public Shared Function getIDByProducto(pproduct) As String
        Dim con As MySqlConnection = conexion.conection
        Dim id As String = 0
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT id_product FROM products  WHERE name = '{0}'", pproduct), con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            id = reader(0).ToString
        End If
        con.Close()
        Return id
    End Function
    Public Shared Sub insSale(pid_pro, pquantity, pdate, ptipo, ptotal)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO sales(id_product,quantity,date,type, total) VALUES('{0}','{1}','{2}','{3}','{4}')", pid_pro, pquantity, pdate, ptipo, ptotal), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Function getReportsAll() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT pr.name, sl.quantity, sl.date, sl.type, sl.total FROM sales sl JOIN products pr WHERE sl.id_product = pr.id_product"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getDayliReport(pdate) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT pr.name, sl.quantity, sl.date, sl.type, sl.total FROM sales sl JOIN products pr WHERE sl.id_product = pr.id_product AND sl.date='{0}' ", pdate), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getDateReport(pdate1, pdate2) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT pr.name, sl.quantity, sl.date, sl.type, sl.total FROM sales sl JOIN products pr WHERE sl.id_product = pr.id_product AND sl.date >='{0}' AND sl.date <='{1}' ", pdate1, pdate2), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductReport(pproduct) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT pr.name, sl.quantity, sl.date, sl.type, sl.total FROM sales sl JOIN products pr WHERE sl.id_product = pr.id_product AND pr.name = '{0}'", pproduct), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductosByProveedor(pproveedor) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT pr.name, pr.description, pr.price, pr.bar_code, pr.quantity, pr.min, pr.date,pr.category, prov.provider, prov.contact, prov.address, prov.phone FROM products pr JOIN providers prov WHERE pr.id_provider = prov.id_provider AND prov.provider = '{0}'", pproveedor), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getDateTypeReport(pdate1, pdate2, ptipo) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT pr.name, sl.quantity, sl.date, sl.type, sl.total FROM sales sl JOIN products pr WHERE  sl.id_product = pr.id_product AND sl.date >='{0}' AND sl.date <='{1}' AND sl.type= '{2}'", pdate1, pdate2, ptipo), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getContador() As String
        Dim con As MySqlConnection = conexion.conection
        Dim cont As String = 0
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT id_contador FROM contador ORDER BY id_contador DESC LIMIT 1"), con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            cont = reader(0).ToString
        End If
        con.Close()
        Return cont
    End Function
    Public Shared Sub insContador()
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO contador() VALUES()"), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Sub insOrden(ptype, pdescription, pissue, ppayment, ptotal, pcode)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO support(type,description,issue,advance_payment,total,code) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", ptype, pdescription, pissue, ppayment, ptotal, pcode), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Function getOrden(pcode) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM support WHERE code = '{0}'", pcode), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Sub updInventario(cantidad, pname)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("UPDATE products SET quantity='{0}' WHERE id_product='{1}'", cantidad, pname), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Sub updInventarioAll(pname, pdescription, pprice, pbarcode, pqueantity, pmin, pdate, pcategory, pid_provider, pid_product)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("UPDATE products SET name='{0}',description='{1}',price='{2}', bar_code='{3}', quantity='{4}', min='{5}',date='{6}', category='{7}', id_provider='{8}'  WHERE id_product='{9}'", pname, pdescription, pprice, pbarcode, pqueantity, pmin, pdate, pcategory, pid_provider, pid_product), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Function getIDProvideer(pprovider) As String
        Dim con As MySqlConnection = conexion.conection
        Dim id As String = 0
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT id_provider FROM providers  WHERE provider = '{0}'", pprovider), con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            id = reader(0).ToString
        End If
        con.Close()
        Return id
    End Function
    Public Shared Sub insProvider(pprovider, pcontact, paddress, pphone)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO providers(provider,contact,address,phone) VALUES('{0}','{1}','{2}','{3}')", pprovider, pcontact, paddress, pphone), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
End Class
