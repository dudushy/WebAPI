CREATE DATABASE 'CRUD';

CREATE TABLE tb_users(
    u_cpf           VARCHAR(11) NOT NULL,
    u_name          VARCHAR(60) NOT NULL,
    u_birth_date    DATE NOT NULL,
    u_email         VARCHAR(60) NOT NULL,
    u_password      VARCHAR(30) NOT NULL,
    PRIMARY KEY(u_cpf)
);

SELECT * FROM tb_users;

CREATE TABLE tb_products(
    pd_id            INTEGER NOT NULL,
    pd_name          VARCHAR(60) NOT NULL,
    pd_desc          VARCHAR(120) NOT NULL,
    pd_weight        FLOAT NOT NULL,
    PRIMARY KEY(pd_id)
);

SELECT * FROM tb_products;

CREATE TABLE tb_providers(
    pv_cnpj          VARCHAR(14) NOT NULL,
    pv_name          VARCHAR(60) NOT NULL,
    pv_reg_date      DATE NOT NULL,
    PRIMARY KEY(pv_cnpj)
);

SELECT * FROM tb_providers;