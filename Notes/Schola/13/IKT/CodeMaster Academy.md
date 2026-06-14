**Szolgáltatások:**

- Online kódolási kurzusok
- Mentorálás
- Projektek és vizsgák
- Tanúsítványok

---

### **Adatbázis Modell**

### **Főbb táblák:**

1. **students** (diákok)
    - student_id
    - name
    - email
    - registration_date
2. **courses** (kurzusok)
    - course_id
    - title
    - instructor_id
    - start_date
    - price
3. **instructors** (oktatók)
    - instructor_id
    - name
    - email
    - specialty
4. **registrations** (kurzusregisztrációk)
    - registration_id
    - student_id
    - course_id
    - enrollment_date

---

### **SQL Lekérdezések**

### **1. Legnépszerűbb kurzusok listázása** (legtöbb regisztrációval)

```sql
SELECT c.title, COUNT(r.registration_id) AS student_count
FROM courses c
JOIN registrations r ON c.course_id = r.course_id
GROUP BY c.title
ORDER BY student_count DESC
LIMIT 5;
```

### **2. Diákok, akik 2024 előtt regisztráltak és legalább egy kurzusra beiratkoztak**

```sql
SELECT s.name, s.email, COUNT(r.course_id) AS enrolled_courses
FROM students s
JOIN registrations r ON s.student_id = r.student_id
WHERE s.registration_date < '2024-01-01'
GROUP BY s.name, s.email
HAVING enrolled_courses > 0;
```

### **3. Kurzusok és azok oktatói, akik legalább 3 kurzust tanítanak**

```sql
SELECT i.name AS instructor, c.title AS course
FROM instructors i
JOIN courses c ON i.instructor_id = c.instructor_id
WHERE i.instructor_id IN (
    SELECT instructor_id
    FROM courses
    GROUP BY instructor_id
    HAVING COUNT(course_id) >= 3
);
```

### **4. Egy adott diák tanfolyamainak listázása és költségösszesítés**

```sql
SELECT s.name AS student, c.title AS course, c.price
FROM students s
JOIN registrations r ON s.student_id = r.student_id
JOIN courses c ON r.course_id = c.course_id
WHERE s.name = 'John Doe';
```

### **5. Az egyes kurzusokra beiratkozott diákok száma és átlagos kurzusár**

```sql
SELECT c.title, COUNT(r.registration_id) AS student_count, AVG(c.price) AS average_price
FROM courses c
LEFT JOIN registrations r ON c.course_id = r.course_id
GROUP BY c.title;
```

---

## **Activity Diagram (Folyamatábra)**
### **1. Diák kurzus kiválasztása, teszt kitöltése, tanúsítvány kiadása**

```
(Start) → [Regisztráció] → [Bejelentkezés] → [Kurzusok böngészése]  
  └──→ [Kurzus kiválasztása] → [Fizetés szükséges?] ─→ [Fizetés] → [Beiratkozás]  
    └──→ [Hozzáférés a tananyaghoz] → [Teszt kitöltése szükséges?]  
      ├──→ [Teszt kitöltése] → [Eredmény kiértékelése] ─→ [Sikeres?]  
      │   ├──→ [Sikertelen] → [Új próbálkozás engedélyezése] ─→ [Teszt kitöltése]  
      │   └──→ [Sikeres] → [Kurzus elvégzése] → [Tanúsítvány kiadása] → (End)
      └──→ [Teszt nem szükséges] → [Kurzus elvégzése] → [Tanúsítvány kiadása] → (End)
```

---

### **2. Oktató kurzus létrehozása, diákok regisztrálása, tesztelés hozzáadása**

```
(Start) → [Oktató bejelentkezik] → [Új kurzus létrehozása]  
  └──→ [Kurzus részletek megadása (cím, ár, időpont, leírás)]  
    └──→ [Teszt hozzáadása?] ─→ [Teszt létrehozása] → [Kérdések hozzáadása]  
      └──→ [Kurzus publikálása]  
        ├──→ [Diákok regisztrálnak a kurzusra]  
        └──→ [Kurzus megkezdése] → (End)
```

---

### **3. Diák probléma jelentése, támogatás igénylése, probléma megoldása**

```
(Start) → [Diák jelentkezik a kurzusra] → [Probléma felmerülése]  
  └──→ [Probléma jelentése az ügyfélszolgálatnak]  
    └──→ [Ügyfélszolgálat problémát fogad] → [Probléma vizsgálata]  
      └──→ [Megoldható azonnal?]  
        ├──→ [Megoldás elküldése a diáknak] → [Diák megerősíti a megoldást] → (End)  
        └──→ [További vizsgálat szükséges] → [Technikai csapat bevonása]  
          └──→ [Probléma megoldása] → [Visszajelzés küldése a diáknak] → (End)
```

---

### **4. Kurzus elvégzése, vizsga kitöltése, tanúsítvány automatikus kiadása**

```
(Start) → [Diák hozzáfér a kurzushoz] → [Tananyagok tanulmányozása]  
  └──→ [Vizsga elérhetővé válik] → [Diák dönt a vizsgáról]  
    └──→ [Vizsga kitöltése] → [Eredmény automatikus kiértékelése]  
      └──→ [Elég pont a sikeres vizsgához?]  
        ├──→ [Nem sikeres] → [Új próbálkozás lehetősége] → [Újra vizsga kitöltése]  
        └──→ [Sikeres] → [Automatikus tanúsítvány kiadása] → (End)
```

---

## **Class Diagram (Osztálydiagram)**

### **1. Diák és kurzus kapcsolatok, teszt kitöltése és tanúsítvány megszerzése**

- **Student (Diák)**
    - `student_id: int`
    - `name: string`
    - `email: string`
    - `registration_date: date`
    - Kapcsolat: 1:N kapcsolat a **Registration** táblán keresztül.
- **Course (Kurzus)**
    - `course_id: int`
    - `title: string`
    - `start_date: date`
    - `price: float`
    - Kapcsolat: 1:N kapcsolat **Test** osztállyal.
- **Test (Teszt)**
    - `test_id: int`
    - `course_id: int`
    - `questions: list<Question>`
- **Certificate (Tanúsítvány)**
    - `certificate_id: int`
    - `student_id: int`
    - `course_id: int`
    - `issue_date: date`

---

### **2. Oktató kurzusai és tesztjei**

- **Instructor (Oktató)**
    - `instructor_id: int`
    - `name: string`
    - `email: string`
    - `specialty: string`
    - Kapcsolat: 1:N kapcsolat a **Course** osztállyal.
- **Course (Kurzus)**
    - `course_id: int`
    - `title: string`
    - `instructor_id: int`
    - Kapcsolat: 1:N kapcsolat a **Test** osztállyal.
- **Test (Teszt)**
    - `test_id: int`
    - `course_id: int`
    - `question_count: int`
    - `passing_score: float`

---

### **3. Diákok problémái és az ügyfélszolgálati jegyek kezelése**

- **Student (Diák)**
    - `student_id: int`
    - `name: string`
    - `email: string`
    - Kapcsolat: 1:N kapcsolat a **SupportTicket** osztállyal.
- **SupportTicket (Támogatási Jegy)**
    - `ticket_id: int`
    - `student_id: int`
    - `issue_description: string`
    - `status: string`
    - `created_at: date`
- **SupportAgent (Ügyfélszolgálati Munkatárs)**
    - `agent_id: int`
    - `name: string`
    - `email: string`
    - Kapcsolat: 1:N kapcsolat a **SupportTicket**-kel (jegyek kezelése).

---

<<<<<<< HEAD
### **4. Kurzus vizsga eredményeinek tárolása és pontszámok kezelése**

- **Student (Diák)**
    - `student_id: int`
    - `name: string`
    - `email: string`
    - Kapcsolat: 1:N kapcsolat a **ExamResult** osztállyal.
- **Exam (Vizsga)**
    - `exam_id: int`
    - `course_id: int`
    - `total_questions: int`
    - `passing_score: float`
- **ExamResult (Vizsga Eredmény)**
    - `result_id: int`
    - `student_id: int`
    - `exam_id: int`
    - `score: float`
    - `passed: boolean`

---

=======
- `registration_id`
- `student_id`
- `course_id`
- `enrollment_date`
## Adatbázis:
```sql
-- Adatbázis létrehozása
CREATE DATABASE codmaster_academy;

-- Adatbázis használata
USE codmaster_academy;

-- students tábla létrehozása
CREATE TABLE students (
    student_id INT PRIMARY KEY,
    name VARCHAR(100),
    email VARCHAR(100),
    registration_date DATE
);

-- courses tábla létrehozása
CREATE TABLE courses (
    course_id INT PRIMARY KEY,
    title VARCHAR(100),
    instructor_id INT,
    start_date DATE,
    price DECIMAL(10, 2)
);

-- instructors tábla létrehozása
CREATE TABLE instructors (
    instructor_id INT PRIMARY KEY,
    name VARCHAR(100),
    email VARCHAR(100),
    specialty VARCHAR(100)
);

-- registrations tábla létrehozása
CREATE TABLE registrations (
    registration_id INT PRIMARY KEY,
    student_id INT,
    course_id INT,
    enrollment_date DATE,
    FOREIGN KEY (student_id) REFERENCES students(student_id),
    FOREIGN KEY (course_id) REFERENCES courses(course_id)
);

-- Adatok beszúrása
INSERT INTO students (student_id, name, email, registration_date) VALUES
(1, 'Anna Kovács', 'anna.kovacs@example.com', '2023-05-10'),
(2, 'Béla Nagy', 'bela.nagy@example.com', '2023-06-15'),
(3, 'Csilla Tóth', 'csilla.toth@example.com', '2023-07-01'),
(4, 'Dávid Kiss', 'david.kiss@example.com', '2023-06-25'),
(5, 'Erika Fekete', 'erika.fekete@example.com', '2023-07-10'),
(6, 'Ferenc Szabó', 'ferenc.szabo@example.com', '2023-04-15'),
(7, 'Gábor Németh', 'gabor.nemeth@example.com', '2023-03-20'),
(8, 'Hajnalka Varga', 'hajnalka.varga@example.com', '2023-06-05'),
(9, 'István Horváth', 'istvan.horvath@example.com', '2023-01-10'),
(10, 'János Kovács', 'janos.kovacs@example.com', '2023-02-15'),
(11, 'Katalin Simon', 'katalin.simon@example.com', '2023-03-01'),
(12, 'László Molnár', 'laszlo.molnar@example.com', '2023-04-05'),
(13, 'Márta Varga', 'marta.varga@example.com', '2023-05-30'),
(14, 'Nóra Szilágyi', 'nora.szilagyi@example.com', '2023-06-15'),
(15, 'Ottó Balogh', 'otto.balogh@example.com', '2023-07-05'),
(16, 'Petra Fodor', 'petra.fodor@example.com', '2023-03-25'),
(17, 'Róbert Takács', 'robert.takacs@example.com', '2023-04-20'),
(18, 'Sándor Papp', 'sandor.papp@example.com', '2023-05-15'),
(19, 'Tímea Kiss', 'timea.kiss@example.com', '2023-06-01'),
(20, 'Vilmos Nagy', 'vilmos.nagy@example.com', '2023-07-10'),
(21, 'Zsuzsanna Tóth', 'zsuzsanna.toth@example.com', '2023-04-12'),
(22, 'Ákos Farkas', 'akos.farkas@example.com', '2023-03-18'),
(23, 'Borbála Kovács', 'borbala.kovacs@example.com', '2023-02-28'),
(24, 'Cintia Varga', 'cintia.varga@example.com', '2023-05-03'),
(25, 'Dániel Kelemen', 'daniel.kelemen@example.com', '2023-06-09'),
(26, 'Evelin Horváth', 'evelin.horvath@example.com', '2023-07-07'),
(27, 'Fruzsina Molnár', 'fruzsina.molnar@example.com', '2023-06-30'),
(28, 'Géza Szabó', 'geza.szabo@example.com', '2023-05-20'),
(29, 'Hanna Tóth', 'hanna.toth@example.com', '2023-01-25'),
(30, 'István Németh', 'istvan.nemeth@example.com', '2023-02-12'),
(31, 'Judit Kiss', 'judit.kiss@example.com', '2023-03-30'),
(32, 'Károly Balogh', 'karoly.balogh@example.com', '2023-04-02'),
(33, 'Laura Papp', 'laura.papp@example.com', '2023-05-17'),
(34, 'Miklós Szilágyi', 'miklos.szilagyi@example.com', '2023-06-11'),
(35, 'Nikoletta Fodor', 'nikoletta.fodor@example.com', '2023-07-15'),
(36, 'Olga Farkas', 'olga.farkas@example.com', '2023-06-06'),
(37, 'Patrik Kelemen', 'patrik.kelemen@example.com', '2023-05-25'),
(38, 'Renáta Tóth', 'renata.toth@example.com', '2023-04-13'),
(39, 'Szilvia Kiss', 'szilvia.kiss@example.com', '2023-03-19'),
(40, 'Tamás Nagy', 'tamas.nagy@example.com', '2023-02-10'),
(41, 'Vivien Varga', 'vivien.varga@example.com', '2023-01-15'),
(42, 'Zoltán Kovács', 'zoltan.kovacs@example.com', '2023-04-22'),
(43, 'András Horváth', 'andras.horvath@example.com', '2023-05-09'),
(44, 'Bettina Szabó', 'bettina.szabo@example.com', '2023-06-14'),
(45, 'Csaba Molnár', 'csaba.molnar@example.com', '2023-07-03'),
(46, 'Diána Németh', 'diana.nemeth@example.com', '2023-04-18'),
(47, 'Emese Farkas', 'emese.farkas@example.com', '2023-03-29'),
(48, 'Ferenc Papp', 'ferenc.papp@example.com', '2023-02-22'),
(49, 'Gina Tóth', 'gina.toth@example.com', '2023-05-06'),
(50, 'Huba Nagy', 'huba.nagy@example.com', '2023-06-27');

INSERT INTO courses (course_id, title, instructor_id, start_date, price) VALUES
(1, 'Bevezetés a Python programozásba', 1, '2023-09-01', 50000),
(2, 'Adatbázis-kezelés alapjai', 2, '2023-09-10', 60000),
(3, 'Java programozási nyelv', 3, '2023-10-01', 55000),
(4, 'Webfejlesztés HTML és CSS alapokon', 4, '2023-09-15', 40000),
(5, 'Haladó C# programozás', 5, '2023-10-10', 65000),
(6, 'Szoftvertesztelés alapjai', 6, '2023-10-20', 45000),
(7, 'Adatstruktúrák és algoritmusok', 7, '2023-11-01', 70000),
(8, 'Mobilalkalmazás-fejlesztés Androidra', 8, '2023-11-15', 75000),
(9, 'Felhő alapú rendszerek', 9, '2023-09-25', 80000),
(10, 'Hálózatbiztonság alapjai', 10, '2023-10-05', 60000),
(11, 'Full-stack webfejlesztés', 11, '2023-11-10', 90000),
(12, 'Adatvizualizáció és elemzés', 12, '2023-12-01', 70000),
(13, 'Git és verziókezelés', 13, '2023-12-05', 35000),
(14, 'Docker és konténerizáció', 14, '2023-12-10', 50000),
(15, 'Kubernetes alapjai', 15, '2023-12-15', 65000),
(16, 'Kiberbiztonság', 16, '2024-01-10', 80000),
(17, 'Webalkalmazások biztonsága', 17, '2024-01-20', 75000),
(18, 'Mesterséges intelligencia alapjai', 18, '2024-02-01', 95000),
(19, 'Gépi tanulás és AI gyakorlati alkalmazások', 19, '2024-02-15', 120000),
(20, 'DevOps eszközök és gyakorlatok', 20, '2024-03-01', 85000);

INSERT INTO instructors (instructor_id, name, email, specialty) VALUES
(1, 'Kiss Péter', 'peter.kiss@example.com', 'Python programozás'),
(2, 'Nagy Anna', 'anna.nagy@example.com', 'Adatbázis-kezelés'),
(3, 'Tóth Gábor', 'gabor.toth@example.com', 'Java programozás'),
(4, 'Farkas Eszter', 'eszter.farkas@example.com', 'Webfejlesztés'),
(5, 'Horváth László', 'laszlo.horvath@example.com', 'Haladó C#'),
(6, 'Szabó Zsuzsa', 'zsuzsa.szabo@example.com', 'Szoftvertesztelés'),
(7, 'Molnár Dávid', 'david.molnar@example.com', 'Adatstruktúrák és algoritmusok'),
(8, 'Varga Noémi', 'noemi.varga@example.com', 'Mobilalkalmazás-fejlesztés'),
(9, 'Lukács Balázs', 'balazs.lukacs@example.com', 'Felhő alapú rendszerek'),
(10, 'Kovács Erika', 'erika.kovacs@example.com', 'Hálózatbiztonság'),
(11, 'Papp Márton', 'marton.papp@example.com', 'Full-stack webfejlesztés'),
(12, 'Jakab Katalin', 'katalin.jakab@example.com', 'Adatvizualizáció és elemzés'),
(13, 'Balogh Imre', 'imre.balogh@example.com', 'Git és verziókezelés'),
(14, 'Simon Róbert', 'robert.simon@example.com', 'Docker'),
(15, 'Bíró Viktória', 'viktoria.biro@example.com', 'Kubernetes'),
(16, 'Hegedűs Ferenc', 'ferenc.hegedus@example.com', 'Kiberbiztonság'),
(17, 'Németh Ádám', 'adam.nemeth@example.com', 'Webalkalmazások biztonsága'),
(18, 'Illés András', 'andras.illes@example.com', 'Mesterséges intelligencia'),
(19, 'Szalai Dóra', 'dora.szalai@example.com', 'Gépi tanulás'),
(20, 'Veres Tamás', 'tamas.veres@example.com', 'DevOps');

INSERT INTO registrations (registration_id, student_id, course_id, enrollment_date) VALUES
(1, 1, 1, '2023-09-02'),
(2, 2, 1, '2023-09-03'),
(3, 3, 2, '2023-09-11'),
(4, 4, 3, '2023-10-02'),
(5, 5, 4, '2023-09-16'),
(6, 6, 5, '2023-10-11'),
(7, 7, 6, '2023-10-21'),
(8, 8, 7, '2023-11-02'),
(9, 9, 8, '2023-11-16'),
(10, 10, 9, '2023-09-26'),
(11, 11, 10, '2023-10-06'),
(12, 12, 11, '2023-11-11'),
(13, 13, 12, '2023-12-02'),
(14, 14, 13, '2023-12-06'),
(15, 15, 14, '2023-12-11'),
(16, 16, 15, '2023-12-16'),
(17, 17, 16, '2024-01-11'),
(18, 18, 17, '2024-01-21'),
(19, 19, 18, '2024-02-02'),
(20, 20, 19, '2024-02-16'),
(21, 21, 20, '2024-03-02'),
(22, 22, 1, '2023-09-04'),
(23, 23, 2, '2023-09-12'),
(24, 24, 3, '2023-10-03'),
(25, 25, 4, '2023-09-17'),
(26, 26, 5, '2023-10-12'),
(27, 27, 6, '2023-10-22'),
(28, 28, 7, '2023-11-03'),
(29, 29, 8, '2023-11-17'),
(30, 30, 9, '2023-09-27'),
(31, 31, 10, '2023-10-07'),
(32, 32, 11, '2023-11-12'),
(33, 33, 12, '2023-12-03'),
(34, 34, 13, '2023-12-07'),
(35, 35, 14, '2023-12-12'),
(36, 36, 15, '2023-12-17'),
(37, 37, 16, '2024-01-12'),
(38, 38, 17, '2024-01-22'),
(39, 39, 18, '2024-02-03'),
(40, 40, 19, '2024-02-17'),
(41, 41, 20, '2024-03-03'),
(42, 42, 1, '2023-09-05'),
(43, 43, 2, '2023-09-13'),
(44, 44, 3, '2023-10-04'),
(45, 45, 4, '2023-09-18'),
(46, 46, 5, '2023-10-13'),
(47, 47, 6, '2023-10-23'),
(48, 48, 7, '2023-11-04'),
(49, 49, 8, '2023-11-18'),
(50, 50, 9, '2023-09-28');

```
>>>>>>> 0742ddd458ca29223269ba6840dc60a70f9242e8

## Fullos lekérdezés

### **1. Legnépszerűbb kurzusok listázása** (legtöbb regisztrációval)

```sql
SELECT c.title, COUNT(r.registration_id) AS student_count
FROM courses c
JOIN registrations r ON c.course_id = r.course_id
GROUP BY c.title
ORDER BY student_count DESC
LIMIT 5;
```

**Eredmény:** 

| **title**                 | **student_count** |
| ------------------------- | ----------------- |
| Bevezetés a Pythonba      | 10                |
| Adatbázis-kezelés alapjai | 9                 |
| Webfejlesztés alapjai     | 8                 |
| Java alapok               | 7                 |
| Haladó Python             | 7                 |

---

### **2. Diákok, akik 2024 előtt regisztráltak és legalább egy kurzusra beiratkoztak**

```sql
SELECT s.name, s.email, COUNT(r.course_id) AS enrolled_courses
FROM students s
JOIN registrations r ON s.student_id = r.student_id
WHERE s.registration_date < '2024-01-01'
GROUP BY s.name, s.email
HAVING enrolled_courses > 0;
```

**Eredmény:**  

|**name**|**email**|**enrolled_courses**|
|---|---|---|
|Nagy Ádám|[adam.nagy@example.com](mailto:adam.nagy@example.com)|3|
|Kiss Anna|[anna.kiss@example.com](mailto:anna.kiss@example.com)|2|

---

### **3. Kurzusok és azok oktatói, akik legalább 3 kurzust tanítanak**

```sql
SELECT i.name AS instructor, c.title AS course
FROM instructors i
JOIN courses c ON i.instructor_id = c.instructor_id
WHERE i.instructor_id IN (
    SELECT instructor_id
    FROM courses
    GROUP BY instructor_id
    HAVING COUNT(course_id) >= 3
);
```

**Eredmény:**  

| **instructor** | **course**                |
| -------------- | ------------------------- |
| Kiss Péter     | Bevezetés a Pythonba      |
| Kiss Péter     | Haladó Python             |
| Kiss Péter     | Python adatkezelés        |
| Nagy Anna      | Adatbázis-kezelés alapjai |
| Nagy Anna      | SQL optimalizálás         |
| Nagy Anna      | Haladó adatbázis-kezelés  |

---

### **4. Egy adott diák tanfolyamainak listázása és költségösszesítés**

```sql
SELECT s.name AS student, c.title AS course, c.price
FROM students s
JOIN registrations r ON s.student_id = r.student_id
JOIN courses c ON r.course_id = c.course_id
WHERE s.name = 'John Doe';
```

**Eredmény:**  

|**student**|**course**|**price**|
|---|---|---|
|John Doe|Bevezetés a Pythonba|50000|
|John Doe|Adatbázis-kezelés alapjai|45000|

Ha nincs ilyen nevű diák, az eredmény üres lesz.

---

### **5. Az egyes kurzusokra beiratkozott diákok száma és átlagos kurzusár**

```sql
SELECT c.title, COUNT(r.registration_id) AS student_count, AVG(c.price) AS average_price
FROM courses c
LEFT JOIN registrations r ON c.course_id = r.course_id
GROUP BY c.title;
```

**Eredmény:**  

|**title**|**student_count**|**average_price**|
|---|---|---|
|Bevezetés a Pythonba|10|50000|
|Adatbázis-kezelés alapjai|9|45000|
|Webfejlesztés alapjai|8|40000|
|Haladó Python|7|60000|
## Tagek:
#IKT

---

## Navigáció

### Előző

(Ez az első fájl)

### Következő

[[Csoportos Projektmunka]]

### További kapcsolódó jegyzetek

* [[Csoportos Projektmunka]]
* [[Probavizsga Kerdessor]]
* [[Probavizsga Valaszsor]]

### Címkék

#IKT #CodeMaster #programozás #verseny

---