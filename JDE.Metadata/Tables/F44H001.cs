using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H001 - .
/// </summary>
public class F44H001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HCCO.
        /// </summary>
        public const string HCCO = "HCCO";

        /// <summary>
        /// HCHBRLTPS.
        /// </summary>
        public const string HCHBRLTPS = "HCHBRLTPS";

        /// <summary>
        /// HCHBRLTPC.
        /// </summary>
        public const string HCHBRLTPC = "HCHBRLTPC";

        /// <summary>
        /// HCCLDCT.
        /// </summary>
        public const string HCCLDCT = "HCCLDCT";

        /// <summary>
        /// HCCJSTYL.
        /// </summary>
        public const string HCCJSTYL = "HCCJSTYL";

        /// <summary>
        /// HCLTSTYL.
        /// </summary>
        public const string HCLTSTYL = "HCLTSTYL";

        /// <summary>
        /// HCMJSTYL.
        /// </summary>
        public const string HCMJSTYL = "HCMJSTYL";

        /// <summary>
        /// HCSWME.
        /// </summary>
        public const string HCSWME = "HCSWME";

        /// <summary>
        /// HCSWMAN8.
        /// </summary>
        public const string HCSWMAN8 = "HCSWMAN8";

        /// <summary>
        /// HCSWMDCT.
        /// </summary>
        public const string HCSWMDCT = "HCSWMDCT";

        /// <summary>
        /// HCSWMSCT.
        /// </summary>
        public const string HCSWMSCT = "HCSWMSCT";

        /// <summary>
        /// HCSWMCS.
        /// </summary>
        public const string HCSWMCS = "HCSWMCS";

        /// <summary>
        /// HCOCTO.
        /// </summary>
        public const string HCOCTO = "HCOCTO";

        /// <summary>
        /// HCLNTY.
        /// </summary>
        public const string HCLNTY = "HCLNTY";

        /// <summary>
        /// HCDCTO.
        /// </summary>
        public const string HCDCTO = "HCDCTO";

        /// <summary>
        /// HCHBPFLG1.
        /// </summary>
        public const string HCHBPFLG1 = "HCHBPFLG1";

        /// <summary>
        /// HCNXTR.
        /// </summary>
        public const string HCNXTR = "HCNXTR";

        /// <summary>
        /// HCLTTR.
        /// </summary>
        public const string HCLTTR = "HCLTTR";

        /// <summary>
        /// HCSCHENB.
        /// </summary>
        public const string HCSCHENB = "HCSCHENB";

        /// <summary>
        /// HCCRTU.
        /// </summary>
        public const string HCCRTU = "HCCRTU";

        /// <summary>
        /// HCCRTJ.
        /// </summary>
        public const string HCCRTJ = "HCCRTJ";

        /// <summary>
        /// HCCRTT.
        /// </summary>
        public const string HCCRTT = "HCCRTT";

        /// <summary>
        /// HCWRKSTNID.
        /// </summary>
        public const string HCWRKSTNID = "HCWRKSTNID";

        /// <summary>
        /// HCHBOPID.
        /// </summary>
        public const string HCHBOPID = "HCHBOPID";

        /// <summary>
        /// HCUPMB.
        /// </summary>
        public const string HCUPMB = "HCUPMB";

        /// <summary>
        /// HCUPMJ.
        /// </summary>
        public const string HCUPMJ = "HCUPMJ";

        /// <summary>
        /// HCUPMT.
        /// </summary>
        public const string HCUPMT = "HCUPMT";

        /// <summary>
        /// HCJOBN.
        /// </summary>
        public const string HCJOBN = "HCJOBN";

        /// <summary>
        /// HCPID.
        /// </summary>
        public const string HCPID = "HCPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HCCO", "HCCO", JdeDataType.String, 10, true, true),
        new JdeField("HCHBRLTPS", "HCHBRLTPS", JdeDataType.String, 6),
        new JdeField("HCHBRLTPC", "HCHBRLTPC", JdeDataType.String, 6),
        new JdeField("HCCLDCT", "HCCLDCT", JdeDataType.String, 4),
        new JdeField("HCCJSTYL", "HCCJSTYL", JdeDataType.String, 4),
        new JdeField("HCLTSTYL", "HCLTSTYL", JdeDataType.String, 4),
        new JdeField("HCMJSTYL", "HCMJSTYL", JdeDataType.String, 4),
        new JdeField("HCSWME", "HCSWME", JdeDataType.String, 2),
        new JdeField("HCSWMAN8", "HCSWMAN8", JdeDataType.Numeric),
        new JdeField("HCSWMDCT", "HCSWMDCT", JdeDataType.String, 4),
        new JdeField("HCSWMSCT", "HCSWMSCT", JdeDataType.String, 8),
        new JdeField("HCSWMCS", "HCSWMCS", JdeDataType.String, 4),
        new JdeField("HCOCTO", "HCOCTO", JdeDataType.String, 4),
        new JdeField("HCLNTY", "HCLNTY", JdeDataType.String, 4),
        new JdeField("HCDCTO", "HCDCTO", JdeDataType.String, 4),
        new JdeField("HCHBPFLG1", "HCHBPFLG1", JdeDataType.String, 2),
        new JdeField("HCNXTR", "HCNXTR", JdeDataType.String, 6),
        new JdeField("HCLTTR", "HCLTTR", JdeDataType.String, 6),
        new JdeField("HCSCHENB", "HCSCHENB", JdeDataType.String, 2),
        new JdeField("HCCRTU", "HCCRTU", JdeDataType.String, 20),
        new JdeField("HCCRTJ", "HCCRTJ", JdeDataType.Numeric),
        new JdeField("HCCRTT", "HCCRTT", JdeDataType.Numeric),
        new JdeField("HCWRKSTNID", "HCWRKSTNID", JdeDataType.String, 20),
        new JdeField("HCHBOPID", "HCHBOPID", JdeDataType.String, 20),
        new JdeField("HCUPMB", "HCUPMB", JdeDataType.String, 20),
        new JdeField("HCUPMJ", "HCUPMJ", JdeDataType.Numeric),
        new JdeField("HCUPMT", "HCUPMT", JdeDataType.Numeric),
        new JdeField("HCJOBN", "HCJOBN", JdeDataType.String, 20),
        new JdeField("HCPID", "HCPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H001_0", "Primary Key on HCCO", new[] { "HCCO" }, isUnique: true, isPrimaryKey: true)
    };
}
