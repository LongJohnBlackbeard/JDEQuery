using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B25 - .
/// </summary>
public class F03B25 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RFPLY.
        /// </summary>
        public const string RFPLY = "RFPLY";

        /// <summary>
        /// RFCO.
        /// </summary>
        public const string RFCO = "RFCO";

        /// <summary>
        /// RFPLYN.
        /// </summary>
        public const string RFPLYN = "RFPLYN";

        /// <summary>
        /// RFPLYD.
        /// </summary>
        public const string RFPLYD = "RFPLYD";

        /// <summary>
        /// RFRTCM.
        /// </summary>
        public const string RFRTCM = "RFRTCM";

        /// <summary>
        /// RFUSER.
        /// </summary>
        public const string RFUSER = "RFUSER";

        /// <summary>
        /// RFPID.
        /// </summary>
        public const string RFPID = "RFPID";

        /// <summary>
        /// RFJOBN.
        /// </summary>
        public const string RFJOBN = "RFJOBN";

        /// <summary>
        /// RFUPMJ.
        /// </summary>
        public const string RFUPMJ = "RFUPMJ";

        /// <summary>
        /// RFUPMT.
        /// </summary>
        public const string RFUPMT = "RFUPMT";

        /// <summary>
        /// RFNDEF.
        /// </summary>
        public const string RFNDEF = "RFNDEF";

        /// <summary>
        /// RFFDEF.
        /// </summary>
        public const string RFFDEF = "RFFDEF";
    }

    /// <inheritdoc />
    public override string TableName => "F03B25";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RFPLY", "RFPLY", JdeDataType.Numeric, null, true, true),
        new JdeField("RFCO", "RFCO", JdeDataType.String, 10),
        new JdeField("RFPLYN", "RFPLYN", JdeDataType.String, 20),
        new JdeField("RFPLYD", "RFPLYD", JdeDataType.String, 80),
        new JdeField("RFRTCM", "RFRTCM", JdeDataType.String, 2),
        new JdeField("RFUSER", "RFUSER", JdeDataType.String, 20),
        new JdeField("RFPID", "RFPID", JdeDataType.String, 20),
        new JdeField("RFJOBN", "RFJOBN", JdeDataType.String, 20),
        new JdeField("RFUPMJ", "RFUPMJ", JdeDataType.Numeric),
        new JdeField("RFUPMT", "RFUPMT", JdeDataType.Numeric),
        new JdeField("RFNDEF", "RFNDEF", JdeDataType.String, 2),
        new JdeField("RFFDEF", "RFFDEF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B25_0", "Primary Key on RFPLY", new[] { "RFPLY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B25_2", "Index on RFPLYN, RFCO", new[] { "RFPLYN", "RFCO" })
    };
}
