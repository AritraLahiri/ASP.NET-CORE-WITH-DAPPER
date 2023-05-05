if not exists (select 1 from dbo.[Product])
begin
insert into dbo.[Product] (Price, Name , Description) VALUES (100000,'Apple MacBook Prp','One of a kind');
end