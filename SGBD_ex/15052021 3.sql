--Exceptii:
---predefinite
---nonpredefinite
---definite de utilizator

set serveroutput on
declare
    v_pret number;
begin
    SELECT pret_lista into v_pret from produse where id_produs>=23780;
    dbms_output.put_line('Pret= '||v_pret);
    dbms_output.put_line('S-au gasit: '||SQL%ROWCOUNT);
    
    exception
        when VALUE_ERROR then
            dbms_output.put_line('A aparut o exceptie');
            dbms_output.put_line(SQLERRM);
            dbms_output.put_line(SQLCODE);
        when TOO_MANY_ROWS then
            dbms_output.put_line('S-au returnat prea multe randuri');
            dbms_output.put_line(SQLERRM);
            dbms_output.put_line(SQLCODE);
        when NO_DATA_FOUND then
            dbms_output.put_line('Nu s-au gasit date');
            dbms_output.put_line(SQLERRM);
            dbms_output.put_line(SQLCODE);
end;
