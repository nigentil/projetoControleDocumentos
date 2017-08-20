create table usuario
(
	codigo_usuario varchar(20) not null,
	nome_usuario varchar(50) not null,
	senha_usuario varchar(20) not null,
	email_usuario varchar(100) null,
	tipo_usuario tinyint,
	usuario_ativo bit
	Constraint pk_usuario Primary key(codigo_usuario)
	-- Tipo_Usuario
	-- 1 = usuario
	-- 2 = Aprovador

	-- usuario_ativo
	-- 0 = Não
	-- 1 = sim
)
go

insert into usuario Values('admin', 'administrador', 'admin','teste@teste.com.br', 1, 1)
insert into usuario Values('nival', 'administrador Nival', '123','nival@teste.com.br', 1, 1)
go

create table empresa
(
	codigo_empresa int not null,
	razao_social varchar(50) not null,
	protocolo_envio int,
	protocolo_autorizacao int,
	Constraint pk_empresa Primary key(codigo_empresa)
)
go

insert into Empresa Values(1, 'FATEC', 0,0)
go

create table tipo_documento
(
	codigo_tipo int identity(1,1) not null,
	descricao_tipo varchar(100) not null,
	Constraint pk_tipo_arquivo Primary key(codigo_tipo)
)
go

insert into tipo_documento Values('Comprovante de Atividades Academico Culturais')
go

create table arquivo_enviado
(
	codigo_envio int identity(1,1) not null,
	descricao_arquivo varchar(255) not null,
	nome_Arquivo varchar(255),
	tamanho_arquivo smallint,
	Arquivo image,
	codigo_usuario_envio varchar(20),
	data_envio datetime not null,
	codigo_usuario_aprov varchar(20),
	data_aprov datetime null,
	codigo_usuario_reprov varchar(20),
	data_reprov datetime null,
	motivo_reprov text,
	Constraint pk_arquivo_enviado Primary key(codigo_envio)
)
go

insert into arquivo_enviado (descricao_arquivo,codigo_usuario_envio, data_envio ) Values('CCXP','admin',getdate())
go







