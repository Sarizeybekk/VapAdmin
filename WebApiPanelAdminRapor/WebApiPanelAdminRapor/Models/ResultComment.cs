using System;
using System.Collections.Generic;
using NpgsqlTypes;

namespace WebApiPanelAdminRapor.Models;

public partial class ResultComment
{
    public int Id { get; set; }

    public Guid ResultFk { get; set; }

    public string? UserId { get; set; }

    public DateTime DateTimeUtc { get; set; }

    public string? CommentText { get; set; }

    public string? CommentTags { get; set; }

    public NpgsqlTsVector? CommentSearchVector { get; set; }

    public virtual DeviceResult ResultFkNavigation { get; set; } = null!;
}
