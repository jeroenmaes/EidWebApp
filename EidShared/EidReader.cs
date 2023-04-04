using Egelke.Eid.Client;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace EidShared
{
    public class EidReader
    {
        public EidResult Read()
        {
            using (Readers readers = new Readers(ReaderScope.User))
            {
                EidCard eid = (EidCard)readers.ListCards().Where(c => c is EidCard).FirstOrDefault();
                using (eid)
                {
                    eid.Open();

                    var eidResult = new EidResult
                    {
                        Identity = eid.Identity,
                        Address = eid.Address
                    };

                    return eidResult;
                }
            }
        }
    }
}
