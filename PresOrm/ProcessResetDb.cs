using PresOrm.Data;
using PresOrm.Data.Services;

namespace PresOrm
{
    internal class ProcessResetDb : AProcess
    {
        protected override string Message => "Reset DB";
        protected override string EndMessage => "Data reset !";

        protected override void Process(ContextPresOrm context)
        {
            new ServiceOldSchool().ResetDB();
        }
    }
}
