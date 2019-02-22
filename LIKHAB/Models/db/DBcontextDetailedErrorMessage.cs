using System.Data;
using System.Data.Entity.Validation;
using System.Linq;

namespace LIKHAB.Models.db
{
    public partial class LIHKAB_dbEntities
    {
        public override int SaveChanges()
        {

            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                dynamic errorMessages = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage);

                // Join the list to a single string.
                dynamic fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                dynamic exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }

        }
    }
}