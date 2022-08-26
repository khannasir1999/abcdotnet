using abc.CommonLayer.Model;

using System.Threading.Tasks;

namespace abc.RepositoryLayer
{
    public interface ICrudOperationRL
    {
        public Task<CreateRecordResponse> CreateRecord(CreateRecordRequest request);
        public Task<ReadRecordResponse> ReadRecord();

        public Task<UpdateRecordResponse> UpdateRecord(UpdateRecordRequest request);
        public Task<DeleteRecordResponse> DeleteRecord(DeleteRecordRequest request);
    }
}
