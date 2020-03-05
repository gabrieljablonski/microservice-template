using FluentValidation;
using Liquid.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tasks.ViewModels
{
    public class TaskVM : LightViewModel<TaskVM>
    {
        /// <summary>
        /// Task id
        /// </summary>
        public string Id { get; set; }

        public override void Validate()
        {
            RuleFor(i => i.Id).NotEmpty().WithErrorCode("ID_MUSTNOT_BE_EMPTY");
        }
    }
}
