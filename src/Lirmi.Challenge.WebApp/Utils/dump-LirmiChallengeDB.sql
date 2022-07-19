--
-- PostgreSQL database dump
--

-- Dumped from database version 14.4
-- Dumped by pg_dump version 14.2

-- Started on 2022-07-18 20:22:52

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 5 (class 2615 OID 16395)
-- Name: Main; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA "Main";


ALTER SCHEMA "Main" OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 213 (class 1259 OID 16421)
-- Name: Grade; Type: TABLE; Schema: Main; Owner: postgres
--

CREATE TABLE "Main"."Grade" (
    "GradeId" integer NOT NULL,
    "Name" character varying(250) NOT NULL,
    "Code" character varying(250),
    "YearNumber" integer NOT NULL,
    "Type" character varying(250),
    "SchoolId" integer NOT NULL,
    "IsActive" boolean DEFAULT true NOT NULL,
    "CreatedDate" timestamp without time zone DEFAULT timezone('utc'::text, now()) NOT NULL,
    "CreatedUserId" integer,
    "UpdatedDate" timestamp without time zone DEFAULT timezone('utc'::text, now()) NOT NULL,
    "UpdatedUserId" integer
);


ALTER TABLE "Main"."Grade" OWNER TO postgres;

--
-- TOC entry 212 (class 1259 OID 16420)
-- Name: Grade_GradeId_seq; Type: SEQUENCE; Schema: Main; Owner: postgres
--

CREATE SEQUENCE "Main"."Grade_GradeId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "Main"."Grade_GradeId_seq" OWNER TO postgres;

--
-- TOC entry 3345 (class 0 OID 0)
-- Dependencies: 212
-- Name: Grade_GradeId_seq; Type: SEQUENCE OWNED BY; Schema: Main; Owner: postgres
--

ALTER SEQUENCE "Main"."Grade_GradeId_seq" OWNED BY "Main"."Grade"."GradeId";


--
-- TOC entry 211 (class 1259 OID 16409)
-- Name: School; Type: TABLE; Schema: Main; Owner: postgres
--

CREATE TABLE "Main"."School" (
    "SchoolId" integer NOT NULL,
    "Name" character varying(250) NOT NULL,
    "ShortName" character varying(250),
    "Code" character varying(250),
    "TypeDescription" character varying(250),
    "IsActive" boolean DEFAULT true NOT NULL,
    "CreatedDate" timestamp without time zone DEFAULT timezone('utc'::text, now()) NOT NULL,
    "CreatedUserId" integer,
    "UpdatedDate" timestamp without time zone DEFAULT timezone('utc'::text, now()) NOT NULL,
    "UpdatedUserId" integer
);


ALTER TABLE "Main"."School" OWNER TO postgres;

--
-- TOC entry 210 (class 1259 OID 16408)
-- Name: School_SchoolId_seq; Type: SEQUENCE; Schema: Main; Owner: postgres
--

CREATE SEQUENCE "Main"."School_SchoolId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "Main"."School_SchoolId_seq" OWNER TO postgres;

--
-- TOC entry 3346 (class 0 OID 0)
-- Dependencies: 210
-- Name: School_SchoolId_seq; Type: SEQUENCE OWNED BY; Schema: Main; Owner: postgres
--

ALTER SEQUENCE "Main"."School_SchoolId_seq" OWNED BY "Main"."School"."SchoolId";


--
-- TOC entry 215 (class 1259 OID 16438)
-- Name: Subject; Type: TABLE; Schema: Main; Owner: postgres
--

CREATE TABLE "Main"."Subject" (
    "SubjectId" integer NOT NULL,
    "Name" character varying(250) NOT NULL,
    "ShortName" character varying(250),
    "Code" character varying(250),
    "GradeId" integer NOT NULL,
    "IsActive" boolean DEFAULT true NOT NULL,
    "CreatedDate" timestamp without time zone DEFAULT timezone('utc'::text, now()) NOT NULL,
    "CreatedUserId" integer,
    "UpdatedDate" timestamp without time zone DEFAULT timezone('utc'::text, now()) NOT NULL,
    "UpdatedUserId" integer
);


ALTER TABLE "Main"."Subject" OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 16437)
-- Name: Subject_SubjectId_seq; Type: SEQUENCE; Schema: Main; Owner: postgres
--

CREATE SEQUENCE "Main"."Subject_SubjectId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "Main"."Subject_SubjectId_seq" OWNER TO postgres;

--
-- TOC entry 3347 (class 0 OID 0)
-- Dependencies: 214
-- Name: Subject_SubjectId_seq; Type: SEQUENCE OWNED BY; Schema: Main; Owner: postgres
--

ALTER SEQUENCE "Main"."Subject_SubjectId_seq" OWNED BY "Main"."Subject"."SubjectId";


--
-- TOC entry 3179 (class 2604 OID 16424)
-- Name: Grade GradeId; Type: DEFAULT; Schema: Main; Owner: postgres
--

ALTER TABLE ONLY "Main"."Grade" ALTER COLUMN "GradeId" SET DEFAULT nextval('"Main"."Grade_GradeId_seq"'::regclass);


--
-- TOC entry 3175 (class 2604 OID 16412)
-- Name: School SchoolId; Type: DEFAULT; Schema: Main; Owner: postgres
--

ALTER TABLE ONLY "Main"."School" ALTER COLUMN "SchoolId" SET DEFAULT nextval('"Main"."School_SchoolId_seq"'::regclass);


--
-- TOC entry 3183 (class 2604 OID 16441)
-- Name: Subject SubjectId; Type: DEFAULT; Schema: Main; Owner: postgres
--

ALTER TABLE ONLY "Main"."Subject" ALTER COLUMN "SubjectId" SET DEFAULT nextval('"Main"."Subject_SubjectId_seq"'::regclass);


--
-- TOC entry 3337 (class 0 OID 16421)
-- Dependencies: 213
-- Data for Name: Grade; Type: TABLE DATA; Schema: Main; Owner: postgres
--



--
-- TOC entry 3335 (class 0 OID 16409)
-- Dependencies: 211
-- Data for Name: School; Type: TABLE DATA; Schema: Main; Owner: postgres
--

INSERT INTO "Main"."School" VALUES (1, 'Institución Académica Nacional', 'I.A.N', 'IAN', 'Intituto', true, '2022-07-18 21:53:36.472377', NULL, '2022-07-18 21:53:36.472377', NULL);
INSERT INTO "Main"."School" VALUES (2, 'Colegio Educativo Particular', 'C.E.P', 'CEP', 'Colegio', true, '2022-07-19 01:16:12.62405', NULL, '2022-07-19 01:16:12.62405', NULL);


--
-- TOC entry 3339 (class 0 OID 16438)
-- Dependencies: 215
-- Data for Name: Subject; Type: TABLE DATA; Schema: Main; Owner: postgres
--



--
-- TOC entry 3348 (class 0 OID 0)
-- Dependencies: 212
-- Name: Grade_GradeId_seq; Type: SEQUENCE SET; Schema: Main; Owner: postgres
--

SELECT pg_catalog.setval('"Main"."Grade_GradeId_seq"', 1, false);


--
-- TOC entry 3349 (class 0 OID 0)
-- Dependencies: 210
-- Name: School_SchoolId_seq; Type: SEQUENCE SET; Schema: Main; Owner: postgres
--

SELECT pg_catalog.setval('"Main"."School_SchoolId_seq"', 2, true);


--
-- TOC entry 3350 (class 0 OID 0)
-- Dependencies: 214
-- Name: Subject_SubjectId_seq; Type: SEQUENCE SET; Schema: Main; Owner: postgres
--

SELECT pg_catalog.setval('"Main"."Subject_SubjectId_seq"', 1, false);


--
-- TOC entry 3190 (class 2606 OID 16431)
-- Name: Grade PK_Grade; Type: CONSTRAINT; Schema: Main; Owner: postgres
--

ALTER TABLE ONLY "Main"."Grade"
    ADD CONSTRAINT "PK_Grade" PRIMARY KEY ("GradeId");


--
-- TOC entry 3188 (class 2606 OID 16419)
-- Name: School PK_School; Type: CONSTRAINT; Schema: Main; Owner: postgres
--

ALTER TABLE ONLY "Main"."School"
    ADD CONSTRAINT "PK_School" PRIMARY KEY ("SchoolId");


--
-- TOC entry 3192 (class 2606 OID 16448)
-- Name: Subject PK_Subject; Type: CONSTRAINT; Schema: Main; Owner: postgres
--

ALTER TABLE ONLY "Main"."Subject"
    ADD CONSTRAINT "PK_Subject" PRIMARY KEY ("SubjectId");


--
-- TOC entry 3193 (class 2606 OID 16432)
-- Name: Grade FK_Grade_School; Type: FK CONSTRAINT; Schema: Main; Owner: postgres
--

ALTER TABLE ONLY "Main"."Grade"
    ADD CONSTRAINT "FK_Grade_School" FOREIGN KEY ("SchoolId") REFERENCES "Main"."School"("SchoolId");


--
-- TOC entry 3194 (class 2606 OID 16449)
-- Name: Subject FK_Subject_Grade; Type: FK CONSTRAINT; Schema: Main; Owner: postgres
--

ALTER TABLE ONLY "Main"."Subject"
    ADD CONSTRAINT "FK_Subject_Grade" FOREIGN KEY ("GradeId") REFERENCES "Main"."Grade"("GradeId");


-- Completed on 2022-07-18 20:22:52

--
-- PostgreSQL database dump complete
--

