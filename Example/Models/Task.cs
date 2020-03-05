using FluentValidation;
using Liquid.Repository;

namespace Tasks.Models
{
    public class Task : LightModel<Task>
    {
        public string Id { get; set; }

        public override void Validate()
        {
            RuleFor(i => i.Id).NotEmpty().WithErrorCode("ID_MUSTNOT_BE_EMPTY");
        }
    }
}
