create or replace
procedure signupPro
(email in varchar,uname out  varchar )
Is
Begin
select user_name 
into uname
from listener 
where e_mail=email;
end;
