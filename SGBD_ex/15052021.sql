/* Cursorul
implicit: 
    SQL%FOUND = true
    SQL%NOTFOUND = false
    SQL%ROWCOUNT = 100
    
    SQL%FOUND = false
    SQL%NOTFOUND = true
    SQL%ROWCOUNT = 0
Ne arata rezultatul rularii instructiunii LMD anterioare(insert, update, delete, select(*))
explicit:
*/
set serveroutput on
declare
    n number;
begin
    update angajati set salariul=salariul+100 where id_departament=1000;
    if SQL%NOTFOUND then
        dbms_output.put_line('Nu s-a modificat niciun salariu');
    elsif SQL%ROWCOUNT = 1 then
        dbms_output.put_line('S-a modificat un singur salariu');
    else
        dbms_output.put_line('S-au modificat '||SQL%ROWCOUNT||' de salarii');
    end if;
    rollback;
end;
/
--neaparat cu / la sfarsit ca sa definim blocurile

--insert

select * from produse;

begin
    delete from produse where id_produs not in (select id_produs from rand_comenzi);
    dbms_output.put_line('S-au sters '||SQL%ROWCOUNT||' produse');
    rollback;
end;
/

select * from produse;

declare 
    v_pret number;
begin
    select pret_lista into v_pret from produse where id_produs>=23780;
    ---daca selectul cu into a rulat cu succes, SQL%rowcount=1 
    dbms_output.put_line('Pret = '||v_pret);
    dbms_output.put_line('S-au regasit: '||SQL%ROWCOUNT);
end;
/



