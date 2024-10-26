-- CREATE DATABASE TiendaSara;

USE TiendaSara;

	DROP TABLE IF EXISTS Productos;
		CREATE TABLE Productos (
		id INT DEFAULT NULL,
		descripcion VARCHAR(100) DEFAULT NULL,
		precio DECIMAL(33,2) DEFAULT 0.00,
		cantidad BIGINT DEFAULT NULL,
		idCategoria INT DEFAULT NULL UNIQUE,
		idMarca INT DEFAULT NULL UNIQUE,
		Primary Key (id)
	);

	DROP TABLE IF EXISTS Categorias;
	CREATE TABLE Categorias (
		id INT DEFAULT NULL,
		descripcion VARCHAR(100) DEFAULT NULL
		PRIMARY KEY (id)
	);

	DROP TABLE IF EXISTS Marcas;
	CREATE TABLE Marcas (
		id INT DEFAULT NULL,
		descripcion VARCHAR(100) DEFAULT NULL
		PRIMARY KEY (id)
	);

	DROP TABLE IF EXISTS Carrito;
	CREATE TABLE Carrito (
		id INT DEFAULT NULL,
		folioVenta BIGINT DEFAULT NULL,
		totalCompra DECIMAL(33,2) DEFAULT 0.00,
		estatus VARCHAR(50) DEFAULT NULL,
		fecha DATE,
		PRIMARY KEY (id)
	);

	DROP TABLE IF EXISTS CarritoDetalle;
	CREATE TABLE CarritoDetalle (
		id INT DEFAULT NULL,
		idCarrito INT DEFAULT NULL,
		idProducto INT DEFAULT NULL,
		Cantidad BIGINT DEFAULT NULL,
		subTotal DECIMAL(33,2) DEFAULT 0.00
		PRIMARY KEY (id)
	);

	INSERT INTO Productos (id, descripcion, precio, cantidad, idCategoria, idMarca)
		VALUES 
		(1, 'Camiseta básica', 199.90, 50, 1, 101),
		(2, 'Pantalón de mezclilla', 599.50, 30, 2, 102),
		(3, 'Blazer clásico', 899.99, 20, 3, 103),
		(4, 'Vestido midi', 749.00, 25, 4, 104),
		(5, 'Sudadera con capucha', 399.99, 40, 5, 105),
		(6, 'Chaqueta de cuero', 1299.50, 10, 6, 106),
		(7, 'Falda plisada', 399.99, 15, 7, 107),
		(8, 'Camisa formal', 499.90, 35, 8, 108),
		(9, 'Shorts de mezclilla', 299.50, 50, 9, 109),
		(10, 'Abrigo largo', 1499.99, 8, 10, 110);

	INSERT INTO Categorias (id, descripcion)
		VALUES 
		(1, 'Camisetas'),
		(2, 'Pantalones'),
		(3, 'Blazers'),
		(4, 'Vestidos'),
		(5, 'Sudaderas'),
		(6, 'Chaquetas'),
		(7, 'Faldas'),
		(8, 'Camisas'),
		(9, 'Shorts'),
		(10, 'Abrigos');


	INSERT INTO Marcas (id, descripcion)
		VALUES 
		(101, 'Zara Basic'),
		(102, 'Zara Denim'),
		(103, 'Zara Formal'),
		(104, 'Zara Dresses'),
		(105, 'Zara Sport'),
		(106, 'Zara Leather'),
		(107, 'Zara Skirts'),
		(108, 'Zara Shirts'),
		(109, 'Zara Shorts'),
		(110, 'Zara Coats');


	SELECT
		a.descripcion,
		a.precio,
		b.descripcion,
		c.descripcion
	FROM Productos a 
	INNER JOIN Categorias b ON (a.idCategoria=b.id)
	INNER JOIN Marcas c ON (a.idMarca=c.id);


	EXEC sp_helpindex Productos;