-- public."Customers" definition

-- Drop table

-- DROP TABLE public."Customers";

CREATE TABLE public."Customers" (
	"Id" uuid NOT NULL,
	"Name" text NULL,
	"Telephone" text NULL,
	"IsActive" bool NOT NULL,
	CONSTRAINT "PK_Customers" PRIMARY KEY ("Id")
);



-- public."Accounts" definition

-- Drop table

-- DROP TABLE public."Accounts";

CREATE TABLE public."Accounts" (
	"Id" uuid NOT NULL,
	"CustomerId" uuid NOT NULL,
	"CustomerName" text NULL,
	"Balance" numeric NOT NULL,
	"IsActive" bool NOT NULL,
	CONSTRAINT "PK_Accounts" PRIMARY KEY ("Id")
);
CREATE INDEX "IX_Accounts_CustomerId" ON public."Accounts" USING btree ("CustomerId");


-- public."Accounts" foreign keys

ALTER TABLE public."Accounts" ADD CONSTRAINT "FK_Accounts_Customers_CustomerId" FOREIGN KEY ("CustomerId") REFERENCES public."Customers"("Id") ON DELETE CASCADE;




-- public."AccountOperations" definition

-- Drop table

-- DROP TABLE public."AccountOperations";

CREATE TABLE public."AccountOperations" (
	"Id" uuid NOT NULL,
	"AccountOrigin" uuid NOT NULL,
	"AccountRecipient" uuid NOT NULL,
	"Date" timestamp NOT NULL,
	"Value" numeric NOT NULL,
	"IsActive" bool NOT NULL,
	CONSTRAINT "PK_AccountTransactions" PRIMARY KEY ("Id")
);