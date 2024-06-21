using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class FileStorage
{
    public Guid Id { get; set; }

    public string? FileName { get; set; }

    public byte[]? FileContent { get; set; }

    public string? ContentType { get; set; }

    public DateTime UploadDate { get; set; }

    public Guid PlayerId { get; set; }

    public int OrgId { get; set; }

    public string? Etag { get; set; }

    public Guid UserId { get; set; }
}
