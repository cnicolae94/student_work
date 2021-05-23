/*
Cursorul explicit este folosit pt a parcurge rand cu rand rezultatul unei interogari

atribute: C%ISOPEN
        C%FOUND
        C%NOTFOUND
        C%ROWCOUNT

*/

set serveroutput on

declare
    cursor c is 
    select id_angajat,nume,prenume from angajati where id_departament=50 order by salariul desc;
        --fetch first 5 rows with ties;
    r c%rowtype;
--        v_id_angajat angajati.id_angajat%type;
--        v_nume varchar2(50);
--        v_prenume varchar2(50);
begin
    if not C%ISOPEN then
        open c;
    end if;
    
    loop
        fetch c into r  --v_id_angajat, v_nume, v_prenume;
        exit when C%NOTFOUND or C%ROWCOUNT = 6; -- cand fetchul nu mai gaseste nimic
        dbms_output.put_line(r.id_angajat||'->'||r.nume||' '||r.prenume);
    end loop;
    close c;
end;
