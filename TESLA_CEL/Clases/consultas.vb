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

    Public Shared Function getProductosToUpdate(pproducto, ptype) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products WHERE name = '{0}' AND type = '{1}'", pproducto, ptype), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function

    Public Shared Sub insProducto(ptype, pname, pbrand, pmodel, pcolor, pprice, pbarcode, pquantity, pmin, pdate)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO products(type,name,brand,model,color,price,barcode,quantity,min,date) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", ptype, pname, pbrand, pmodel, pcolor, pprice, pbarcode, pquantity, pmin, pdate), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Public Shared Sub delProducto(ptype, pname, pmodel, pcolor)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("DELETE FROM products WHERE type='{0}' AND name='{1}' AND model='{2}' AND color='{3}'", ptype, pname, pmodel, pcolor), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Function getProductoByBarCode(pbarcode) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT name,price,model,color,barcode FROM products  WHERE barcode = '{0}'", pbarcode), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductosByProduct(pid) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT name,price,model,color FROM products  WHERE id_product = '{0}'", pid), con)
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
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT pr.name, sl.quantity, sl.date, sl.type, sl.total FROM sales sl JOIN products pr WHERE sl.id_product = pr.id_product AND pr.name like '{0}%'", pproduct), con)
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
    Public Shared Function getLaastOrder() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM support ORDER BY id_support DESC LIMIT 1"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        con.Close()
        Return dt
    End Function
    Public Shared Sub insContador()
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO contador() VALUES()"), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Sub insOrden(fecha, cliente, telefono, equipo, marca, modelo, color, estado, chip, memoria, pila, cargador, falla, imei, microfono, altavoz, cc, camaras, wifi, señal, buzzer, sensor, costoestimado, anticipo, garantia, fechaentrega, horaentrega, code)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO support(fecha, cliente, telefono, equipo, marca, modelo, color, estado, chip, memoria, pila, cargador, falla, imei, microfono, altavoz, cc, camaras, wifi, señal, buzzer, sensor, costoestimado, anticipo, garantia, fechaentrega, horaentrega, code) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}')", fecha, cliente, telefono, equipo, marca, modelo, color, estado, chip, memoria, pila, cargador, falla, imei, microfono, altavoz, cc, camaras, wifi, señal, buzzer, sensor, costoestimado, anticipo, garantia, fechaentrega, horaentrega, code), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    'Public Shared Function getOrden(pcode) As DataTable
    'Dim con As MySqlConnection = conexion.conection
    'Dim dt As New DataTable
    'Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM support WHERE code = '{0}'", pcode), con)
    'Dim adap As New MySqlDataAdapter(cmd)
    '   adap.Fill(dt)
    '  con.Close()
    'Return dt
    'End Function
    Public Shared Sub updInventario(cantidad, pname)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("UPDATE products SET quantity='{0}' WHERE id_product='{1}'", cantidad, pname), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Sub updInventarioAll(ptype, pname, pbrand, pmodel, pcolor, pprice, pbarcode, pquantity, pmin, pdate, pid)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("UPDATE products SET type='{0}', name='{1}', brand='{2}', model='{3}', color='{4}', price='{5}', barcode='{6}', quantity='{7}', min='{8}', date='{9}'  WHERE id_product='{10}'", ptype, pname, pbrand, pmodel, pcolor, pprice, pbarcode, pquantity, pmin, pdate, pid), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub


    Public Shared Sub delProductoType(type)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("DELETE FROM producttype WHERE type='{0}'", type), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Public Shared Function checkRepetitionsmal(pname, pdes, pcat) As Boolean
        Dim con As MySqlConnection = conexion.conection
        Dim bool As Boolean = False
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT name, description, category FROM products where name = '{0}' AND description='{1}' AND category='{2}'", pname, pdes, pcat), con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            If reader.HasRows = True Then
                bool = True
            End If
        End If
        con.Close()
        Return bool
    End Function
    Public Shared Function getProducType() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT type FROM producttype "), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Sub insProductTyper(type)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO producttype(type) VALUES('{0}')", type), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Function getCantidadInventario(barcode) As String
        Dim con As MySqlConnection = conexion.conection
        Dim cant As String = 0
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT quantity FROM products WHERE barcode=" + barcode + " "), con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            cant = reader(0).ToString
        End If
        con.Close()
        Return cant
    End Function
    Public Shared Function getProductosByCategoria(ptype) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT name FROM products  WHERE type = '{0}'", ptype), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductosByCategoriaModelo(ptype, pname) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT model FROM products  WHERE type = '{0}' AND name='{1}'", ptype, pname), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductosByCategoriaModeloNombre(ptype, pname, pmodel) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT color FROM products  WHERE type = '{0}' AND name='{1}' AND model = '{2}'", ptype, pname, pmodel), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductosAll() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products  "), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductosByProductosParaInv(pnombre) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products WHERE name = '{0}'", pnombre), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductosByDate(pdateInicio, pdateFinal) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT type,name,brand,model,color,price,barcode,quantity,min,date FROM products WHERE date >= '{0}' AND date= <= '{1}'", pdateInicio, pdateFinal), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getOrdenAll(pnumero) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM support WHERE code = '{0}'", pnumero), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
End Class
