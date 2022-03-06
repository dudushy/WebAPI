--tests
INSERT INTO tb_users(u_cpf, u_name, u_birth_date, u_email, u_password)
VALUES ('12345678901', 'Test Dummy', '2000-10-02', 'test@dummy.com', '123');
SELECT * FROM tb_users;

INSERT INTO tb_products(pd_name, pd_desc, pd_weight)
VALUES ('Test Dummy', 'A really cool description', 13.37);
SELECT * FROM tb_products;

INSERT INTO tb_providers(pv_cnpj, pv_name)
VALUES ('12345678901234', 'Test Dummy');
SELECT * FROM tb_providers;