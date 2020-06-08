create table Livros
(
	LivroId	INT NOT NULL Primary Key,
	Titulo	VARCHAR(255),
	Autor	VARCHAR(255),
	Editora	VARCHAR(255),
	Isbn	VARCHAR(255),
	NumeroEdicao INT,
	AnoEdicao	 INT
)


--insert into Livros values (1, 'Dom Casmurro', 'Machado de Assis', 'Abril', '987-123-654', 1, 2010)
--insert into Livros values (2, 'Quincas Borba', 'Machado de Assis', 'Abril', '789-123-654', 1, 2010)
--insert into Livros values (3, 'O Ateneu', 'Raul Pomp�ia', 'Abril', '987-321-654', 1, 2010)
--insert into Livros values (4, 'C�u e Carne no Casamento', 'Jo�o Mohana', 'Cleofas', '987-123-456', 1, 2010)

create table LogOperacao
(
	DataLog			DATETIME,
	Operacao		VARCHAR(255),	--Consulta / Insert / Update / Delete
	ChaveObjeto		INT,			--Chave da Estrutura envolvida na opera��o
	NomeObjeto		VARCHAR(255),	--Estrutura envolvida na opera��o
	Dados			VARCHAR(4000)	--	
)

select * from Livros
select * from LogOperacao

            
