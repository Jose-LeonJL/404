using DVStudio.SDK;

SDK_ SDK1 = new SDK_();
SDK1.inventario.create_Inventario(new DVStudio.SDK.Estructuras.Struct_Inventario {Codigo= "1",Nombre = "David", Categoria = "Jefe",Marca = "404", Precio = 21312, Stock = 2}).Wait();

