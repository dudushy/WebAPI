CREATE DATABASE CRUD;

CREATE TABLE tb_users(
    u_cpf           NVARCHAR(11),
    u_name          NVARCHAR(30),
    u_birth_date    NVARCHAR(30),
    u_email         NVARCHAR(30),
    u_password      NVARCHAR(30),
    PRIMARY KEY(u_cpf)
);

CREATE TABLE tb_products(
    pd_id            INTEGER,
    pd_name          NVARCHAR(30),
    pd_desc          NVARCHAR(120),
    pd_weight        FLOAT,
    PRIMARY KEY(pd_id)
);

CREATE TABLE tb_providers(
    pv_cnpj          NVARCHAR(14),
    pv_name          NVARCHAR(30),
    pv_reg_date      NVARCHAR(30),
    PRIMARY KEY(pv_cnpj)
);
