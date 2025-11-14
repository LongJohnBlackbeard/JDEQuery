using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E093 - .
/// </summary>
public class F43E093 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AUMCU.
        /// </summary>
        public const string AUMCU = "AUMCU";

        /// <summary>
        /// AUALIM.
        /// </summary>
        public const string AUALIM = "AUALIM";

        /// <summary>
        /// AUYN.
        /// </summary>
        public const string AUYN = "AUYN";

        /// <summary>
        /// AUAPSD.
        /// </summary>
        public const string AUAPSD = "AUAPSD";

        /// <summary>
        /// AURPER.
        /// </summary>
        public const string AURPER = "AURPER";

        /// <summary>
        /// AUOSTP.
        /// </summary>
        public const string AUOSTP = "AUOSTP";

        /// <summary>
        /// AUUSER.
        /// </summary>
        public const string AUUSER = "AUUSER";

        /// <summary>
        /// AUPID.
        /// </summary>
        public const string AUPID = "AUPID";

        /// <summary>
        /// AUJOBN.
        /// </summary>
        public const string AUJOBN = "AUJOBN";

        /// <summary>
        /// AUUPMJ.
        /// </summary>
        public const string AUUPMJ = "AUUPMJ";

        /// <summary>
        /// AUTDAY.
        /// </summary>
        public const string AUTDAY = "AUTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43E093";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AUMCU", "AUMCU", JdeDataType.String, 24, true, true),
        new JdeField("AUALIM", "AUALIM", JdeDataType.Numeric),
        new JdeField("AUYN", "AUYN", JdeDataType.String, 2),
        new JdeField("AUAPSD", "AUAPSD", JdeDataType.String, 2),
        new JdeField("AURPER", "AURPER", JdeDataType.Numeric),
        new JdeField("AUOSTP", "AUOSTP", JdeDataType.String, 6),
        new JdeField("AUUSER", "AUUSER", JdeDataType.String, 20),
        new JdeField("AUPID", "AUPID", JdeDataType.String, 20),
        new JdeField("AUJOBN", "AUJOBN", JdeDataType.String, 20),
        new JdeField("AUUPMJ", "AUUPMJ", JdeDataType.Numeric),
        new JdeField("AUTDAY", "AUTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E093_0", "Primary Key on AUMCU", new[] { "AUMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
