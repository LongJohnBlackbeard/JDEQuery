using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75012 - .
/// </summary>
public class F75012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J2JPBK.
        /// </summary>
        public const string J2JPBK = "J2JPBK";

        /// <summary>
        /// J2PAAP.
        /// </summary>
        public const string J2PAAP = "J2PAAP";

        /// <summary>
        /// J2JPIC.
        /// </summary>
        public const string J2JPIC = "J2JPIC";

        /// <summary>
        /// J2JPIT.
        /// </summary>
        public const string J2JPIT = "J2JPIT";

        /// <summary>
        /// J2JPXC.
        /// </summary>
        public const string J2JPXC = "J2JPXC";

        /// <summary>
        /// J2JPXT.
        /// </summary>
        public const string J2JPXT = "J2JPXT";

        /// <summary>
        /// J2JPEC.
        /// </summary>
        public const string J2JPEC = "J2JPEC";

        /// <summary>
        /// J2JPET.
        /// </summary>
        public const string J2JPET = "J2JPET";

        /// <summary>
        /// J2JPLC.
        /// </summary>
        public const string J2JPLC = "J2JPLC";

        /// <summary>
        /// J2JPLT.
        /// </summary>
        public const string J2JPLT = "J2JPLT";

        /// <summary>
        /// J2CRCD.
        /// </summary>
        public const string J2CRCD = "J2CRCD";
    }

    /// <inheritdoc />
    public override string TableName => "F75012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J2JPBK", "J2JPBK", JdeDataType.String, 8, true, true),
        new JdeField("J2PAAP", "J2PAAP", JdeDataType.Numeric, null, true, true),
        new JdeField("J2JPIC", "J2JPIC", JdeDataType.Numeric),
        new JdeField("J2JPIT", "J2JPIT", JdeDataType.Numeric),
        new JdeField("J2JPXC", "J2JPXC", JdeDataType.Numeric),
        new JdeField("J2JPXT", "J2JPXT", JdeDataType.Numeric),
        new JdeField("J2JPEC", "J2JPEC", JdeDataType.Numeric),
        new JdeField("J2JPET", "J2JPET", JdeDataType.Numeric),
        new JdeField("J2JPLC", "J2JPLC", JdeDataType.Numeric),
        new JdeField("J2JPLT", "J2JPLT", JdeDataType.Numeric),
        new JdeField("J2CRCD", "J2CRCD", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75012_0", "Primary Key on J2JPBK, J2PAAP", new[] { "J2JPBK", "J2PAAP" }, isUnique: true, isPrimaryKey: true)
    };
}
