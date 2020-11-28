create or replace
procedure signincheck
(email in VARCHAR2, userpass out VARCHAR  )
is
begin 
select pass  into userpass
from listener
where e_mail= email;
end;
