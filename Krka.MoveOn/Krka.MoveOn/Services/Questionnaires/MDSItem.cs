using Krka.MoveOn.Data;
using Krka.MoveOn.Data.Dials;
using Krka.MoveOn.Data.Questionnaires;
using Microsoft.EntityFrameworkCore;

namespace Krka.MoveOn.Services.Questionnaires;

public class MDSItem
{
    public int Value { get; set; }
    public string Fieldname { get; set; }
    public string Number { get; set; }
    public string Name { get; set; }
}
