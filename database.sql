CREATE DATABASE CRUD;

CREATE TABLE tb_users(
    u_cpf           NVARCHAR(450),
    u_name          NVARCHAR(MAX),
    u_birth_date    NVARCHAR(MAX),
    u_email         NVARCHAR(MAX),
    u_password      NVARCHAR(MAX),
    PRIMARY KEY(u_cpf)
);

CREATE TABLE tb_products(
    pd_id            BIGINT,
    pd_name          NVARCHAR(MAX),
    pd_desc          NVARCHAR(MAX),
    pd_weight        FLOAT,
    PRIMARY KEY(pd_id)
);

CREATE TABLE tb_providers(
    pv_cnpj          NVARCHAR(450),
    pv_name          NVARCHAR(MAX),
    pv_reg_date      NVARCHAR(MAX),
    PRIMARY KEY(pv_cnpj)
);
