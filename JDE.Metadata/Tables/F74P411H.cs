using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P411H - .
/// </summary>
public class F74P411H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P4KCO.
        /// </summary>
        public const string P4KCO = "P4KCO";

        /// <summary>
        /// P4DCT.
        /// </summary>
        public const string P4DCT = "P4DCT";

        /// <summary>
        /// P4DOC.
        /// </summary>
        public const string P4DOC = "P4DOC";

        /// <summary>
        /// P4OKC.
        /// </summary>
        public const string P4OKC = "P4OKC";

        /// <summary>
        /// P4ODOC.
        /// </summary>
        public const string P4ODOC = "P4ODOC";

        /// <summary>
        /// P4ODCT.
        /// </summary>
        public const string P4ODCT = "P4ODCT";

        /// <summary>
        /// P4AN8R.
        /// </summary>
        public const string P4AN8R = "P4AN8R";

        /// <summary>
        /// P4IVD.
        /// </summary>
        public const string P4IVD = "P4IVD";

        /// <summary>
        /// P4URCD.
        /// </summary>
        public const string P4URCD = "P4URCD";

        /// <summary>
        /// P4URDT.
        /// </summary>
        public const string P4URDT = "P4URDT";

        /// <summary>
        /// P4URAB.
        /// </summary>
        public const string P4URAB = "P4URAB";

        /// <summary>
        /// P4URAT.
        /// </summary>
        public const string P4URAT = "P4URAT";

        /// <summary>
        /// P4URRF.
        /// </summary>
        public const string P4URRF = "P4URRF";

        /// <summary>
        /// P4USER.
        /// </summary>
        public const string P4USER = "P4USER";

        /// <summary>
        /// P4PID.
        /// </summary>
        public const string P4PID = "P4PID";

        /// <summary>
        /// P4JOBN.
        /// </summary>
        public const string P4JOBN = "P4JOBN";

        /// <summary>
        /// P4UPMJ.
        /// </summary>
        public const string P4UPMJ = "P4UPMJ";

        /// <summary>
        /// P4UPMT.
        /// </summary>
        public const string P4UPMT = "P4UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74P411H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P4KCO", "P4KCO", JdeDataType.String, 10, true, true),
        new JdeField("P4DCT", "P4DCT", JdeDataType.String, 4, true, true),
        new JdeField("P4DOC", "P4DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("P4OKC", "P4OKC", JdeDataType.String, 10),
        new JdeField("P4ODOC", "P4ODOC", JdeDataType.Numeric),
        new JdeField("P4ODCT", "P4ODCT", JdeDataType.String, 4),
        new JdeField("P4AN8R", "P4AN8R", JdeDataType.Numeric),
        new JdeField("P4IVD", "P4IVD", JdeDataType.Numeric),
        new JdeField("P4URCD", "P4URCD", JdeDataType.String, 4),
        new JdeField("P4URDT", "P4URDT", JdeDataType.Numeric),
        new JdeField("P4URAB", "P4URAB", JdeDataType.Numeric),
        new JdeField("P4URAT", "P4URAT", JdeDataType.Numeric),
        new JdeField("P4URRF", "P4URRF", JdeDataType.String, 30),
        new JdeField("P4USER", "P4USER", JdeDataType.String, 20),
        new JdeField("P4PID", "P4PID", JdeDataType.String, 20),
        new JdeField("P4JOBN", "P4JOBN", JdeDataType.String, 20),
        new JdeField("P4UPMJ", "P4UPMJ", JdeDataType.Numeric),
        new JdeField("P4UPMT", "P4UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P411H_0", "Primary Key on P4KCO, P4DCT, P4DOC", new[] { "P4KCO", "P4DCT", "P4DOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74P411H_2", "Index on P4OKC, P4ODOC, P4ODCT", new[] { "P4OKC", "P4ODOC", "P4ODCT" })
    };
}
