create or replace
PROCEDURE DELETE_ACCOUNT
  (
    e_mail IN VARCHAR)
AS
BEGIN
  DELETE FROM listener WHERE e_mail = e_mail;
END;
