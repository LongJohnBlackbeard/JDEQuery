using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48229 - .
/// </summary>
public class F48229 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W8DOCZ.
        /// </summary>
        public const string W8DOCZ = "W8DOCZ";

        /// <summary>
        /// W8DCTI.
        /// </summary>
        public const string W8DCTI = "W8DCTI";

        /// <summary>
        /// W8KCOI.
        /// </summary>
        public const string W8KCOI = "W8KCOI";

        /// <summary>
        /// W8ICU.
        /// </summary>
        public const string W8ICU = "W8ICU";

        /// <summary>
        /// W8DOCO.
        /// </summary>
        public const string W8DOCO = "W8DOCO";

        /// <summary>
        /// W8DCTO.
        /// </summary>
        public const string W8DCTO = "W8DCTO";

        /// <summary>
        /// W8KCOO.
        /// </summary>
        public const string W8KCOO = "W8KCOO";

        /// <summary>
        /// W8APPL.
        /// </summary>
        public const string W8APPL = "W8APPL";

        /// <summary>
        /// W8ADJN.
        /// </summary>
        public const string W8ADJN = "W8ADJN";

        /// <summary>
        /// W8APDT.
        /// </summary>
        public const string W8APDT = "W8APDT";

        /// <summary>
        /// W8DGL.
        /// </summary>
        public const string W8DGL = "W8DGL";

        /// <summary>
        /// W8PID.
        /// </summary>
        public const string W8PID = "W8PID";

        /// <summary>
        /// W8USER.
        /// </summary>
        public const string W8USER = "W8USER";

        /// <summary>
        /// W8JOBN.
        /// </summary>
        public const string W8JOBN = "W8JOBN";

        /// <summary>
        /// W8UPMJ.
        /// </summary>
        public const string W8UPMJ = "W8UPMJ";

        /// <summary>
        /// W8UPMT.
        /// </summary>
        public const string W8UPMT = "W8UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48229";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W8DOCZ", "W8DOCZ", JdeDataType.Numeric, null, true, true),
        new JdeField("W8DCTI", "W8DCTI", JdeDataType.String, 4, true, true),
        new JdeField("W8KCOI", "W8KCOI", JdeDataType.String, 10, true, true),
        new JdeField("W8ICU", "W8ICU", JdeDataType.Numeric, null, true, true),
        new JdeField("W8DOCO", "W8DOCO", JdeDataType.Numeric),
        new JdeField("W8DCTO", "W8DCTO", JdeDataType.String, 4),
        new JdeField("W8KCOO", "W8KCOO", JdeDataType.String, 10),
        new JdeField("W8APPL", "W8APPL", JdeDataType.Numeric),
        new JdeField("W8ADJN", "W8ADJN", JdeDataType.Numeric),
        new JdeField("W8APDT", "W8APDT", JdeDataType.Numeric),
        new JdeField("W8DGL", "W8DGL", JdeDataType.Numeric),
        new JdeField("W8PID", "W8PID", JdeDataType.String, 20),
        new JdeField("W8USER", "W8USER", JdeDataType.String, 20),
        new JdeField("W8JOBN", "W8JOBN", JdeDataType.String, 20),
        new JdeField("W8UPMJ", "W8UPMJ", JdeDataType.Numeric),
        new JdeField("W8UPMT", "W8UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48229_0", "Primary Key on W8DOCZ, W8DCTI, W8KCOI, W8ICU", new[] { "W8DOCZ", "W8DCTI", "W8KCOI", "W8ICU" }, isUnique: true, isPrimaryKey: true)
    };
}
