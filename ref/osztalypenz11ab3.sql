CREATE TABLE diakok
(
 om              int NOT NULL ,
 nev             varchar(45) NOT NULL ,
 jogviszony      bit NOT NULL ,
 jogviszony_vege date NULL ,
 email           varchar(45) NOT NULL ,
 mobil           varchar(12) NULL ,

PRIMARY KEY (om)
);

CREATE TABLE gondviselok
(
 gond_id int NOT NULL AUTO_INCREMENT ,
 om      int NOT NULL ,
 nev     varchar(45) NOT NULL ,
 email   varchar(45) NULL ,
 tel     varchar(12) NULL ,
 cim     varchar(45) NOT NULL ,

PRIMARY KEY (gond_id),
KEY FK_2 (om),
CONSTRAINT FK_2 FOREIGN KEY FK_2 (om) REFERENCES diakok (om)
);

CREATE TABLE befizetesek
(
 bef_id int NOT NULL AUTO_INCREMENT ,
 om     int NOT NULL ,
 osszeg int NOT NULL ,
 datum  date NOT NULL ,

PRIMARY KEY (bef_id),
KEY FK_2 (om),
CONSTRAINT FK_1 FOREIGN KEY FK_2 (om) REFERENCES diakok (om)
);

CREATE TABLE tetelek
(
 tet_id           int NOT NULL AUTO_INCREMENT ,
 megnevezes       varchar(45) NOT NULL ,
 leiras           text NULL ,
 koltseg_egy_fore int NOT NULL ,
 datum            date NOT NULL ,

PRIMARY KEY (tet_id)
);

CREATE TABLE kiadasok
(
 om     int NOT NULL ,
 tet_id int NOT NULL ,

PRIMARY KEY (om, tet_id),
KEY FK_1 (om),
CONSTRAINT FK_3 FOREIGN KEY FK_1 (om) REFERENCES diakok (om),
KEY FK_2 (tet_id),
CONSTRAINT FK_4 FOREIGN KEY FK_2 (tet_id) REFERENCES tetelek (tet_id)
);
