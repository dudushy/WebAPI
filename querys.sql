--tests
INSERT INTO tb_users(u_cpf, u_birth_date, u_email,u_name, u_password)
VALUES
('12345678901', '28/12/2022', 'test@123.com', 'Test Dummy', '123'),
('08855672901', '02/11/2002', 'dummy@123.com', 'Dummy Test', '1234');
SELECT * FROM tb_users;

INSERT INTO tb_products(pd_id, pd_name, pd_desc, pd_weight)
VALUES
(1, 'Banana', 'This is a really yellow banana.', 13.37),
(2, 'Orange', 'This is a really orange orange.', 0.07);
SELECT * FROM tb_products;

INSERT INTO tb_providers(pv_cnpj, pv_name, pv_reg_date)
VALUES
('12345678901234', 'Dummy Test', GETDATE()),
('12040578701624', 'Wasd Uldr', GETDATE());
SELECT * FROM tb_providers;
