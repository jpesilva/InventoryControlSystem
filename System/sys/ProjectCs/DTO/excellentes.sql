create database excellentes;
create table dtoitems (
    AMOUNT int(4) NOT NULL,
    ID_PATRIMONY int(20) NOT NULL,
    NAME_ITEM varchar(255) NOT NULL,
    LOCATION varchar(255),
    INVOICE varchar(20),
    DATE_ACQUISITION varchar(10),
	PROVIDER varchar(255),
    VALUE varchar(255) NOT NULL,
    DEGREE_DEPRECIATION varchar(255) NOT NULL,
    PRIMARY KEY (ID_PATRIMONY)
);

create table dtodiapers(
	AMOUNT int(4) NOT NULL,
	NAME_ITEM varchar(255) NOT NULL,
	SIZE varchar(255) NOT NULL,
	CHILD_SIZE varchar(255) NOT NULL,
	EXPIRATION_DATE varchar(255) NOT NULL
);

create table dtoclients (
    REGISTER int NOT NULL AUTO_INCREMENT,
    FULL_NAME varchar(255) NOT NULL,
    AGE int(3) NOT NULL,
    RG_CPF varchar(255) NOT NULL,
    TELEPHONE int(20),
    CELL_PHONE int(20),
    EMAIL varchar(255),
    ADDRESS varchar(255) NOT NULL,
    NEIGHBORHOOD varchar(255) NOT NULL,
    CITY varchar(255) NOT NULL,
    LOAN_DATE varchar(10),
    ID_LOAN int(20),
    PRIMARY KEY (REGISTER)
);

create table dtousers (
	ID int(1),
    FULL_NAME varchar(255) NOT NULL,
    FUNCTIONN varchar(255) NOT NULL,
    LOGIN varchar(255) NOT NULL,
    PASSWORDD varchar(255) NOT NULL
);

create table dtoloans (
	ID_LOAN int NOT NULL AUTO_INCREMENT,
    REGISTER_CLIENT int(6) NOT NULL,
    FULL_NAME varchar(255) NOT NULL,
    ID_PATRIMONY int(20) NOT NULL,
    NAME_ITEM varchar(255) NOT NULL,
    VALUE varchar(255) NOT NULL,
    DEGREE_DEPRECIATION varchar(255) NOT NULL,
    PRIMARY KEY (ID_LOAN)
);