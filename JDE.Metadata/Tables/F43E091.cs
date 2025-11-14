using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E091 - .
/// </summary>
public class F43E091 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AEAN8.
        /// </summary>
        public const string AEAN8 = "AEAN8";

        /// <summary>
        /// AEALIM.
        /// </summary>
        public const string AEALIM = "AEALIM";

        /// <summary>
        /// AEYN.
        /// </summary>
        public const string AEYN = "AEYN";

        /// <summary>
        /// AEAPSD.
        /// </summary>
        public const string AEAPSD = "AEAPSD";

        /// <summary>
        /// AERPER.
        /// </summary>
        public const string AERPER = "AERPER";

        /// <summary>
        /// AEOSTP.
        /// </summary>
        public const string AEOSTP = "AEOSTP";

        /// <summary>
        /// AEUSER.
        /// </summary>
        public const string AEUSER = "AEUSER";

        /// <summary>
        /// AEPID.
        /// </summary>
        public const string AEPID = "AEPID";

        /// <summary>
        /// AEJOBN.
        /// </summary>
        public const string AEJOBN = "AEJOBN";

        /// <summary>
        /// AEUPMJ.
        /// </summary>
        public const string AEUPMJ = "AEUPMJ";

        /// <summary>
        /// AETDAY.
        /// </summary>
        public const string AETDAY = "AETDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43E091";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AEAN8", "AEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AEALIM", "AEALIM", JdeDataType.Numeric),
        new JdeField("AEYN", "AEYN", JdeDataType.String, 2),
        new JdeField("AEAPSD", "AEAPSD", JdeDataType.String, 2),
        new JdeField("AERPER", "AERPER", JdeDataType.Numeric),
        new JdeField("AEOSTP", "AEOSTP", JdeDataType.String, 6),
        new JdeField("AEUSER", "AEUSER", JdeDataType.String, 20),
        new JdeField("AEPID", "AEPID", JdeDataType.String, 20),
        new JdeField("AEJOBN", "AEJOBN", JdeDataType.String, 20),
        new JdeField("AEUPMJ", "AEUPMJ", JdeDataType.Numeric),
        new JdeField("AETDAY", "AETDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E091_0", "Primary Key on AEAN8", new[] { "AEAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
