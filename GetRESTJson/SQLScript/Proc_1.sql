use  [BIWORK_SSIS]
go
create procedure proc_1
@id int
as
begin
select * from [dbo].[DEMO_LK_Customer]  where CustomerID = @id
end
go