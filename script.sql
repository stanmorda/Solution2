﻿CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;

CREATE TABLE "Clients" (
    "PersonID" integer GENERATED BY DEFAULT AS IDENTITY,
    "FirstName" text NOT NULL,
    "LastName" text NULL,
    "Gender" character(1) NOT NULL,
    CONSTRAINT "PK_Clients" PRIMARY KEY ("PersonID")
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20230721114730_Initial', '7.0.3');

COMMIT;

START TRANSACTION;

ALTER TABLE "Clients" ADD "City" text NOT NULL DEFAULT '';

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20230721115140_AddCityColumn', '7.0.3');

COMMIT;

START TRANSACTION;

ALTER TABLE "Clients" ADD "Blablabla" text NOT NULL DEFAULT '';

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20230721115242_AddBlablabla', '7.0.3');

COMMIT;

