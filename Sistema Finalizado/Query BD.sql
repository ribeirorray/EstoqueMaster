use sistemavb

--criar as tabelas

CREATE TABLE funcionarios(
id_func int PRIMARY KEY NOT NULL Identity,
nome VARCHAR(60) NOT NULL, 
sexo VARCHAR(20) NOT NULL,
cpf VARCHAR (30) NOT NULL,
endereco VARCHAR (100),
telefone VARCHAR (30),
email VARCHAR (30),
turno VARCHAR (30),
data_contratado DATETIME 
)
GO



CREATE TABLE clientes(
id_cliente int PRIMARY KEY NOT NULL Identity,
nome VARCHAR(60) NOT NULL, 
sexo VARCHAR(20) NOT NULL,
cpf VARCHAR (30) NOT NULL,
endereco VARCHAR (100),
telefone VARCHAR (30),
email VARCHAR (30),
data_cadastro DATETIME 
)
GO



CREATE TABLE produtos
(
id_produto int PRIMARY KEY NOT NULL Identity,
nome VARCHAR(50) NOT NULL,
descricao VARCHAR(50) NOT NULL,
quantidade int NOT NULL,
valor decimal(10,2),
data_cadastro DATETIME,
imagem image,
nivel_minimo int,
quant_vendida int default 0,
codigo_barras varchar(100)
)
GO


create table vendas (
id_vendas int PRIMARY KEY NOT NULL Identity,
num_vendas int NOT NULL,
id_produto int NOT NULL,
id_cliente int NOT NULL,
quantidade int NOT NULL,
valor decimal(18,2),
funcionario VARCHAR(50),
data_venda DateTime
FOREIGN KEY (id_produto) REFERENCES produtos (id_produto),
FOREIGN KEY (id_cliente) REFERENCES clientes (id_cliente)
)
GO



create table caixa (
id_caixa int PRIMARY KEY NOT NULL Identity,
data_ab Date NOT NULL,
hora_ab Time NOT NULL,
funcionario VARCHAR(50) NOT NULL,
valor_ab decimal(18,2) NOT NULL,
valor_sangria decimal(18,2),
hora_sangria Time,
quant_vendas int,
prod_vendidos int,
total_vendido decimal(18,2),
total_caixa decimal(18,2),
saldo_total decimal(18,2),
valor_quebra decimal(18,2),
hora_fecha Time

)
GO



CREATE TABLE estoque
(
id_estoque int PRIMARY KEY NOT NULL Identity,
descricao VARCHAR(50) NOT NULL,
quantidade int NOT NULL,
data_alteracao DATETIME NOT NULL,
id_produto int NOT NULL,
funcionario VARCHAR(50) NOT NULL,
motivo VARCHAR(50) NOT NULL
FOREIGN KEY (id_produto) REFERENCES produtos (id_produto)
)
GO


--criar os procedimentos

--PROCEDIMENTOS DOS FUNCIONÁRIOS
CREATE PROCEDURE sp_salvarfunc
@nome VARCHAR(60),
@sexo VARCHAR(20),
@cpf VARCHAR (30),
@endereco VARCHAR (100),
@telefone VARCHAR (30),
@email VARCHAR (30),
@turno VARCHAR (30),
@data_contratado DATETIME,
@mensagem VARCHAR(100) OUTPUT
AS
BEGIN
IF(EXISTS(SELECT * FROM funcionarios WHERE cpf=@cpf))
SET @mensagem='Número do CPF: '+@cpf + ' já está registrado'
ELSE
BEGIN
INSERT INTO funcionarios VALUES(@nome, @sexo, @cpf, @endereco, @telefone, @email, @turno, @data_contratado)
SET @mensagem='Funcionário registrado com sucesso!'
END
END
GO

CREATE PROCEDURE sp_editarfunc
@nome VARCHAR(60),
@sexo VARCHAR(20),
@cpf VARCHAR (30),
@endereco VARCHAR (100),
@telefone VARCHAR (30),
@email VARCHAR (30),
@turno VARCHAR (30),
@data_contratado DATETIME,
@mensagem VARCHAR(100) OUTPUT
AS
BEGIN

UPDATE funcionarios SET nome = @nome, sexo = @sexo, endereco = @endereco, telefone = @telefone, email = @email, turno = @turno, data_contratado = @data_contratado where cpf = @cpf
SET @mensagem='Dados Alterados!'
END

GO



CREATE PROC sp_buscarFuncNome
@nome VARCHAR(60)
as 
BEGIN
SELECT * FROM funcionarios WHERE nome LIKE @nome+'%'
end 
go


CREATE PROC sp_buscarFuncCpf
@cpf VARCHAR (30)
as 
BEGIN
SELECT * FROM funcionarios WHERE cpf LIKE @cpf+'%'
end 
go


CREATE PROC sp_excluirFunc
@cpf VARCHAR (30),
@mensagem VARCHAR(100) OUTPUT
as 
BEGIN
DELETE funcionarios WHERE cpf = @cpf
SET @mensagem='Excluido com Sucesso!'
end 
go




--PROCEDIMENTOS DOS CLIENTES
CREATE PROCEDURE sp_salvarcli
@nome VARCHAR(60),
@sexo VARCHAR(20),
@cpf VARCHAR (30),
@endereco VARCHAR (100),
@telefone VARCHAR (30),
@email VARCHAR (30),

@data_cadastro DATETIME,
@mensagem VARCHAR(100) OUTPUT
AS
BEGIN
IF(EXISTS(SELECT * FROM clientes WHERE cpf=@cpf))
SET @mensagem='Número do CPF: '+@cpf + ' já está registrado'
ELSE
BEGIN
INSERT INTO clientes VALUES(@nome, @sexo, @cpf, @endereco, @telefone, @email,  @data_cadastro)
SET @mensagem='Registrado com sucesso!'
END
END
GO

CREATE PROCEDURE sp_editarcli
@nome VARCHAR(60),
@sexo VARCHAR(20),
@cpf VARCHAR (30),
@endereco VARCHAR (100),
@telefone VARCHAR (30),
@email VARCHAR (30),


@mensagem VARCHAR(100) OUTPUT
AS
BEGIN

UPDATE clientes SET nome = @nome, sexo = @sexo, endereco = @endereco, telefone = @telefone, email = @email where cpf = @cpf
SET @mensagem='Dados Alterados!'
END

GO



CREATE PROC sp_buscarCliNome
@nome VARCHAR(60)
as 
BEGIN
SELECT * FROM clientes WHERE nome LIKE @nome+'%'
end 
go


CREATE PROC sp_buscarCliCpf
@cpf VARCHAR (30)
as 
BEGIN
SELECT * FROM clientes WHERE cpf LIKE @cpf+'%'
end 
go


CREATE PROC sp_excluirCli
@cpf VARCHAR (30),
@mensagem VARCHAR(100) OUTPUT
as 
BEGIN
DELETE clientes WHERE cpf = @cpf
SET @mensagem='Excluido com Sucesso!'
end 
go



--PROCEDIMENTOS DOS PRODUTOS
CREATE PROCEDURE sp_salvarpro
@nome VARCHAR(60),
@descricao VARCHAR(50),
@quantidade int,
@valor decimal(10,2),
@data_cadastro DATETIME,
@imagem image,
@nivel int,
@quant_vendida int,
@codigo_barras varchar(100),
@mensagem VARCHAR(100) OUTPUT
AS
BEGIN
IF(EXISTS(SELECT * FROM produtos WHERE codigo_barras=@codigo_barras))
SET @mensagem='Código de Barras: '+@codigo_barras + ' já está registrado'
ELSE

BEGIN
INSERT INTO produtos VALUES(@nome, @descricao, @quantidade, @valor, @data_cadastro, @imagem, @nivel, @quant_vendida, @codigo_barras)
SET @mensagem='Registrado com sucesso!'
END
END
GO

CREATE PROCEDURE sp_editarpro
@id_produto int,
@nome VARCHAR(60),
@descricao VARCHAR(50),
@quantidade int,
@valor decimal(10,2),
@imagem image,
@nivel int,

@mensagem VARCHAR(100) OUTPUT
AS
BEGIN

UPDATE produtos SET nome = @nome, descricao = @descricao, quantidade = @quantidade, valor = @valor, imagem = @imagem, nivel_minimo = @nivel where id_produto = @id_produto
SET @mensagem='Dados Alterados!'
END

GO



CREATE PROCEDURE sp_editarEstoquepro
@id_produto int,
@quantidade int
AS
BEGIN
UPDATE produtos SET quantidade = @quantidade where id_produto = @id_produto
END
GO


CREATE PROCEDURE sp_editarQuantidadeVendida
@id_produto int,
@quant_vendida int
AS
BEGIN
UPDATE produtos SET quant_vendida = @quant_vendida where id_produto = @id_produto
END
GO


CREATE PROC sp_buscarProNome
@nome VARCHAR(60),
@codigo_barras VARCHAR(100)
as 
BEGIN
SELECT * FROM produtos WHERE nome LIKE @nome+'%' or codigo_barras LIKE @codigo_barras+'%'
end 
go




CREATE PROC sp_excluirPro
@id_produto int,
@mensagem VARCHAR(100) OUTPUT
as 
BEGIN
DELETE produtos WHERE id_produto = @id_produto
SET @mensagem='Excluido com Sucesso!'
end 
go





--PROCEDIMENTO DO LOGIN

create proc login(
@nome varchar(30),
@cpf varchar(50),
@msg varchar(100)output
)
as
begin
if(not exists(select * from funcionarios where nome = @nome and cpf = @cpf))
set
@msg = 'Dados Incorretos'
else
begin
set
@msg = 'Bem Vindo Sr(a): ' + @nome
end
end
go


--PROCEDIMENTOS DAS VENDAS

--PROCEDIMENTO PARA BUSCAR VALOR DO PRODUTO
create proc buscarValorProd(
@id_produto int,
@valor decimal output,
@quant int output,
@quant_vendida int output,
@codigo_barras varchar(100) output
)
as
begin
set @quant=(select quantidade
from  produtos where id_produto = @id_produto)
set @valor=(select valor
from  produtos where id_produto = @id_produto)
set @quant_vendida=(select quant_vendida
from  produtos where id_produto = @id_produto)
set @codigo_barras=(select codigo_barras
from  produtos where id_produto = @id_produto)
end
go


create proc buscarCodBarras(
@codigo_barras varchar(100),
@id_produto int output

)
as
begin
set @id_produto=(select id_produto
from  produtos where codigo_barras = @codigo_barras)

end
go

create proc buscarNumVenda(

@num_venda int output

)
as
begin
IF(not EXISTS(SELECT * FROM vendas))
set @num_venda=0
else
begin
set @num_venda=(select max(num_vendas) from vendas)
end
end
go


CREATE PROCEDURE sp_salvarvenda
@num_vendas int,
@id_produto int,
@id_cliente int,
@quantidade int,
@valor decimal(10,2),
@funcionario varchar(50),
@data_venda DATETIME,
@mensagem VARCHAR(100) OUTPUT
AS
BEGIN
INSERT INTO vendas VALUES(@num_vendas, @id_produto, @id_cliente, @quantidade, @valor, @funcionario, @data_venda)
SET @mensagem='Registrado com sucesso!'
END
GO




CREATE PROCEDURE sp_editarvenda
@id_vendas int,
@num_vendas int,
@id_produto int,
@quantidade int,
@valor decimal(10,2),

@mensagem VARCHAR(100) OUTPUT
AS
BEGIN

UPDATE vendas SET num_vendas = @num_vendas, id_produto = @id_produto, quantidade = @quantidade, valor = @valor where id_vendas = @id_vendas
SET @mensagem='Dados Alterados!'
END

GO



CREATE PROC sp_buscarVenda
@num_vendas VARCHAR(60)
as 
BEGIN
SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor, ven.quantidade, ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM vendas as ven INNER JOIN produtos as pro on ven.id_produto = pro.id_produto INNER JOIN clientes as cli on ven.id_cliente = cli.id_cliente WHERE num_vendas LIKE @num_vendas+'%'
end 
go




CREATE PROC sp_excluirVenda
@id_vendas int,
@mensagem VARCHAR(100) OUTPUT
as 
BEGIN
DELETE vendas WHERE id_vendas = @id_vendas
SET @mensagem='Excluido com Sucesso!'
end 
go




--PROCEDIMENTO DO CAIXA

create proc sp_verificar_abertura(
@data date,
@funcionario varchar(50),
@msg varchar(100)output
)
as
begin
if(not exists(select * from caixa where data_ab = @data and funcionario = @funcionario))
set
@msg = 'Abra primeiro o Caixa'
else
begin
set
@msg = ''
end
end
GO






CREATE PROCEDURE sp_abertura_caixa
@data_ab Date,
@hora_ab Time ,
@funcionario VARCHAR(50),
@valor_ab decimal(18,2),
@valor_sangria decimal(18,2),
@hora_sangria Time,
@quant_vendas int,
@prod_vendidos int,
@total_vendido decimal(18,2),
@total_caixa decimal(18,2),
@saldo_total decimal(18,2),
@valor_quebra decimal(18,2),
@hora_fecha Time,
@mensagem VARCHAR(100) OUTPUT

AS
BEGIN
INSERT INTO caixa VALUES(
@data_ab,
@hora_ab,
@funcionario,
@valor_ab,
@valor_sangria,
@hora_sangria,
@quant_vendas,
@prod_vendidos,
@total_vendido,
@total_caixa,
@saldo_total,
@valor_quebra,
@hora_fecha
)
SET @mensagem='Registrado com sucesso!'
END
GO



create proc sp_buscarDadosCaixa(
@data_ab Date,
@funcionario varchar(50),

@hora_ab Time output,
@hora_sangria Time output,
@valor_ab decimal output,
@valor_sangria decimal output,
@total_caixa decimal output
)
as
begin

set @hora_ab=(select hora_ab
from caixa where data_ab = @data_ab and funcionario = @funcionario)
set @hora_sangria=(select hora_sangria
from caixa where data_ab = @data_ab and funcionario = @funcionario)
set @valor_ab=(select valor_ab
from caixa where data_ab = @data_ab and funcionario = @funcionario)
set @valor_sangria=(select valor_sangria
from caixa where data_ab = @data_ab and funcionario = @funcionario)
set @total_caixa=(select total_caixa
from caixa where data_ab = @data_ab and funcionario = @funcionario)
end
go




CREATE PROCEDURE sp_editarSangria

@data_ab date,
@funcionario varchar(50),
@valor_sangria decimal(10,2),

@mensagem VARCHAR(100) OUTPUT
AS
BEGIN

UPDATE caixa SET valor_sangria = @valor_sangria where data_ab = @data_ab and funcionario = @funcionario
SET @mensagem='Dados Alterados!'
END

GO





CREATE PROCEDURE sp_fechar_caixa

@data_ab date,
@funcionario varchar(50),

@valor_ab decimal(18,2),

@quant_vendas int,
@prod_vendidos int,
@total_vendido decimal(18,2),
@total_caixa decimal(18,2),
@saldo_total decimal(18,2),
@valor_quebra decimal(18,2),
@hora_fecha Time,

@mensagem VARCHAR(100) OUTPUT
AS
BEGIN

UPDATE caixa SET valor_ab = @valor_ab,  quant_vendas = @quant_vendas, prod_vendidos = @prod_vendidos, total_vendido = @total_vendido, total_caixa = @total_caixa, saldo_total = @saldo_total, valor_quebra = @valor_quebra, hora_fecha = @hora_fecha where data_ab = @data_ab and funcionario = @funcionario
SET @mensagem='Caixa Fechado!'
END

GO




--PROCEDIMENTOS DO ESTOQUE


CREATE PROCEDURE sp_salvarEstoque

@descricao VARCHAR(50),
@quantidade int,
@data_alteracao DATETIME,
@id_produto int,
@funcionario VARCHAR(50),
@motivo VARCHAR(50),
@mensagem VARCHAR(100) OUTPUT
AS
BEGIN
INSERT INTO estoque VALUES(@descricao, @quantidade, @data_alteracao, @id_produto, @funcionario, @motivo)
SET @mensagem='Registrado com sucesso!'
END
GO




CREATE PROC sp_excluirEstoque
@codigo VARCHAR (30),
@mensagem VARCHAR(100) OUTPUT
as 
BEGIN
DELETE estoque WHERE id_estoque = @codigo
SET @mensagem='Excluido com Sucesso!'
end 
go



CREATE PROC sp_buscarEstoque
@id_produto VARCHAR(60)
as 
BEGIN
SELECT est.id_estoque, pro.nome, est.descricao, est.quantidade, est.data_alteracao, est.id_produto, est.funcionario from estoque as est INNER JOIN produtos as pro on est.id_produto = pro.id_produto WHERE est.id_produto = @id_produto order by est.id_estoque desc
end 
go


CREATE PROC sp_buscarEstoqueEntrada
@descricao VARCHAR(60)
as 
BEGIN
SELECT est.id_estoque, pro.nome, est.descricao, est.quantidade, est.data_alteracao, est.id_produto, est.funcionario from estoque as est INNER JOIN produtos as pro on est.id_produto = pro.id_produto WHERE est.descricao = @descricao order by est.id_estoque desc
end 
go



CREATE PROC sp_buscarEntreDatas
@data_inicial DateTime,
@data_final DateTime
as 
BEGIN
SELECT est.id_estoque, pro.nome, est.descricao, est.quantidade, est.data_alteracao, est.id_produto, est.funcionario from estoque as est INNER JOIN produtos as pro on est.id_produto = pro.id_produto WHERE est.data_alteracao >= @data_inicial and est.data_alteracao <= @data_final order by est.id_estoque desc
end 
go




create proc sp_verificar_nivel(

@msg varchar(100)output
)
as
begin
if(not exists(SELECT * FROM produtos where quantidade < nivel_minimo))
set
@msg = 'Nivel Bom'
else
begin
set
@msg = 'Estoque Baixo'
end
end
go


--INSERÇÃO DE DADOS NAS TABELAS
INSERT INTO funcionarios VALUES ('Admin', 'Masculino', '000.000.000-00', 'Rua X', '(00)00000-0000', 'admin@hotmail.com', 'Manhã', getDate());