CREATE DATABASE [dbo.CRUD];

CREATE TABLE tb_users(
    u_cpf           NVARCHAR(11) NOT NULL,
    u_name          NVARCHAR(60) NOT NULL,
    u_birth_date    DATE NOT NULL,
    u_email         NVARCHAR(60) NOT NULL,
    u_password      NVARCHAR(30) NOT NULL,
    PRIMARY KEY(u_cpf)
);

CREATE TABLE tb_products(
    pd_id            INT IDENTITY(1, 1),
    pd_name          NVARCHAR(60) NOT NULL,
    pd_desc          NVARCHAR(120) NOT NULL,
    pd_weight        FLOAT NOT NULL,
    PRIMARY KEY(pd_id)
);

CREATE TABLE tb_providers(
    pv_cnpj          NVARCHAR(14) NOT NULL,
    pv_name          NVARCHAR(60) NOT NULL,
    pv_reg_date      DATE NOT NULL,
    PRIMARY KEY(pv_cnpj)
);