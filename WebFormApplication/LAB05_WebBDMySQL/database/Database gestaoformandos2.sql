DROP DATABASE IF EXISTS gestaoformandos2;

CREATE DATABASE gestaoformandos2;

USE gestaoformandos2;

CREATE TABLE formando (
id_formando   	INT AUTO_INCREMENT,
nome 			VARCHAR(100) NOT NULL,		
genero			CHAR(1) NOT NULL,
idade			TINYINT NULL,
PRIMARY KEY (id_formando)
);

INSERT INTO formando VALUES(0, 'Miguel', 'M', 25);

SELECT AVG(idade) FROM formando;

INSERT INTO formando VALUES(0, 'Pedro', 'M', 28);
INSERT INTO formando VALUES(0, 'Francisco', 'M', 24);


CREATE TABLE users (
uName VARCHAR(15) PRIMARY KEY,
pwd VARCHAR(25) NOT NULL,
userRole VARCHAR(25) NOT NULL
);

INSERT INTO users (uName, pwd, userRole) VALUES
('user1', 'user1', 'Manager'),
('user2', 'user3', 'Admin'),
('user3', 'user3', 'User');

select uName, pwd, sha2(pwd,512) from users;

alter table users modify column pwd varchar(128);

update users set pwd = sha2(pwd, 512);

select * from users where binary uName = 'user1';

create table utilizador (
	id_utilizador int auto_increment primary key,
    nome_utilizador varchar(15) not null unique,
    palavra_passe varchar(128) not null,
    falhas tinyint default 0,
    estado enum('A', 'I') default 'A'
);

insert into utilizador (nome_utilizador, palavra_passe) values
('user1', sha2('user1', 512)),
('user2', sha2('user2', 512)),
('user3', sha2('user3', 512));


delimiter //
create procedure pUSuccesLogin (userName varchar(15), result char(1))
begin 
	if (result = 'S') then
		update utilizador set falhas = 0 where nome_utilizador = userName;
	else
		update utilizador set falhas = falhas + 1 where nome_utilizador = username;
	end if;
end // 
delimiter ;

select * from utilizador;

call pUSuccesLogin('user1', 'U');
call pUSuccesLogin('user1', 'U');
call pUSuccesLogin('user1', 'U');

call pUSuccesLogin('user1', 'S');

delimiter //
create trigger tLogin before update on utilizador
for each row
begin
	if(new.falhas = 5) then 
		set new.estado = 'I';
        end if;
end //
delimiter ;


update utilizador set estado = 'A' where id_utilizador = 1;
