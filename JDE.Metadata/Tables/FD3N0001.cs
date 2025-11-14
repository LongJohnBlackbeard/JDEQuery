using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N0001 - .
/// </summary>
public class FD3N0001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZZAN8.
        /// </summary>
        public const string ZZAN8 = "ZZAN8";

        /// <summary>
        /// ZZDOCO.
        /// </summary>
        public const string ZZDOCO = "ZZDOCO";

        /// <summary>
        /// ZZDCTO.
        /// </summary>
        public const string ZZDCTO = "ZZDCTO";

        /// <summary>
        /// ZZPTSK.
        /// </summary>
        public const string ZZPTSK = "ZZPTSK";

        /// <summary>
        /// ZZTRIP.
        /// </summary>
        public const string ZZTRIP = "ZZTRIP";

        /// <summary>
        /// ZZNUMB.
        /// </summary>
        public const string ZZNUMB = "ZZNUMB";

        /// <summary>
        /// ZZAPID.
        /// </summary>
        public const string ZZAPID = "ZZAPID";

        /// <summary>
        /// ZZSHPN.
        /// </summary>
        public const string ZZSHPN = "ZZSHPN";

        /// <summary>
        /// ZZLDNM.
        /// </summary>
        public const string ZZLDNM = "ZZLDNM";

        /// <summary>
        /// ZZCYNO.
        /// </summary>
        public const string ZZCYNO = "ZZCYNO";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N0001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZZAN8", "ZZAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ZZDOCO", "ZZDOCO", JdeDataType.Numeric),
        new JdeField("ZZDCTO", "ZZDCTO", JdeDataType.String, 4),
        new JdeField("ZZPTSK", "ZZPTSK", JdeDataType.Numeric),
        new JdeField("ZZTRIP", "ZZTRIP", JdeDataType.Numeric),
        new JdeField("ZZNUMB", "ZZNUMB", JdeDataType.Numeric),
        new JdeField("ZZAPID", "ZZAPID", JdeDataType.String, 24),
        new JdeField("ZZSHPN", "ZZSHPN", JdeDataType.Numeric),
        new JdeField("ZZLDNM", "ZZLDNM", JdeDataType.Numeric),
        new JdeField("ZZCYNO", "ZZCYNO", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N0001_0", "Primary Key on ZZAN8", new[] { "ZZAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FD3N0001_2", "Index on ZZDOCO, ZZDCTO, ZZPTSK, ZZTRIP, ZZNUMB, ZZAPID, ZZSHPN, ZZLDNM, ZZCYNO", new[] { "ZZDOCO", "ZZDCTO", "ZZPTSK", "ZZTRIP", "ZZNUMB", "ZZAPID", "ZZSHPN", "ZZLDNM", "ZZCYNO" })
    };
}
