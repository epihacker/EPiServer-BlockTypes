using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace BlockTypesLibrary.Models
{
    [ContentType(DisplayName = "Greet Block", GUID = "bde4f4ee-e876-42c1-b446-528f6b95461f", Description = "Say Hi!")]
    //TODO:  How to render our own image?
    [ImageUrl("~/btl/resource/BlockTypesLibrary.Static.img.Block.png")]
    public class GreetBlock : BtlBlockType
    {
        [CultureSpecific]
        [Required]
        [Display(
            Name = "Greeting",
            Description = "The Greeting!",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual String Greeting { get; set; }
    }
}
