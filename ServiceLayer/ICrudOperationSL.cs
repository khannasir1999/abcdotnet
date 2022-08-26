using System.Threading.Tasks;
using abc.CommonLayer.Model;


namespace abc.ServiceLayer
{
    public interface ICrudOperationSL
    {
        Task<CreateRecordResponse> CreateRecord(CreateRecordRequest request);
        Task<ReadRecordResponse> ReadRecord();
        Task<UpdateRecordResponse> UpdateRecord(UpdateRecordRequest request);
        Task<DeleteRecordResponse> DeleteRecord(DeleteRecordRequest request);

    }
}
