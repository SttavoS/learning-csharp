using System.ComponentModel.DataAnnotations;

namespace DemoAspNet.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title { get; set; }
    }
}