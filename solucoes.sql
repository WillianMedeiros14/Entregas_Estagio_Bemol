-- Criação da tabela de Clientes

CREATE TABLE clientes (
	ID SERIAL PRIMARY KEY,
	Nome TEXT NOT NULL,
	Email TEXT NOT NULL UNIQUE,
	DataNascimento DATE NOT NULL,
	Cidade TEXT NOT NULL
);

SELECT * FROM clientes;

DELETE FROM clientes
WHERE ID = 6;


-- Adição de dados na tabela de Clientes

INSERT INTO clientes (Nome, Email, DataNascimento, Cidade)
VALUES ('Willian Medeiros','mdeiros@gmail.com','2000-05-14',
		'Itacoatiara-Am');

INSERT INTO clientes (Nome, Email, DataNascimento, Cidade)
VALUES ('Bruna','bruna@gmail.com','2000-05-14',
		'Itacoatiara-Am');

INSERT INTO clientes (Nome, Email, DataNascimento, Cidade)
VALUES ('Lucas','lucas@gmail.com','2000-05-14',
		'Itacoatiara-Am');
		

INSERT INTO clientes (Nome, Email, DataNascimento, Cidade)
VALUES ('Pedro','pedro@gmail.com','2000-05-14',
		'Itacoatiara-Am');
		
		
-- Criação da tabela de Pedidos
		
CREATE TABLE pedidos (
	PedidoID SERIAL PRIMARY KEY,
	DataPedido DATE NOT NULL,
	ValorTotal REAL NOT NULL,
	ClienteID INT,
 	CONSTRAINT ClienteID FOREIGN KEY (ClienteID) REFERENCES clientes(ID) ON DELETE SET NULL
);

SELECT * FROM pedidos;


-- Adição de dados na tabela de Pedidos

INSERT INTO pedidos (DataPedido, ValorTotal, ClienteID)
VALUES ('2024-08-19', 50.5, 3);

INSERT INTO pedidos (DataPedido, ValorTotal, ClienteID)
VALUES ('2024-08-19', 30, 3);

INSERT INTO pedidos (DataPedido, ValorTotal, ClienteID)
VALUES ('2024-08-19', 100, 6);


-- Consultas com SELECT

SELECT * FROM clientes;

SELECT nome, email FROM clientes;


-- Atualização de Deleção de dados com UPDATE E DELETE

UPDATE clientes
SET email = 'medeiros@gmail.com' 
WHERE id = 1;

UPDATE pedidos
SET ValorTotal = 60
WHERE PedidoID = 6;

DELETE FROM pedidos
WHERE PedidoID = 5;


-- Filtros com WHERE

WHERE Cidade = 'Itacoatiara-Am';

SELECT  * FROM pedidos
WHERE ValorTotal > 35;

-- Ordenação com ORDER BY

SELECT * FROM clientes
ORDER BY nome;

SELECT * FROM pedidos
ORDER BY ValorTotal DESC;

-- Junte Registros de Tabelas com JOIN
SELECT nome, ValorTotal
FROM clientes
INNER JOIN pedidos ON clientes.id = pedidos.clienteid;

SELECT * FROM clientes
LEFT JOIN pedidos ON clientes.id = pedidos.clienteid;






