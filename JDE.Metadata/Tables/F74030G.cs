using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74030G - .
/// </summary>
public class F74030G : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AYBKTP.
        /// </summary>
        public const string AYBKTP = "AYBKTP";

        /// <summary>
        /// AYTNST.
        /// </summary>
        public const string AYTNST = "AYTNST";

        /// <summary>
        /// AYCBNK.
        /// </summary>
        public const string AYCBNK = "AYCBNK";

        /// <summary>
        /// AYAN8.
        /// </summary>
        public const string AYAN8 = "AYAN8";

        /// <summary>
        /// AYZT16.
        /// </summary>
        public const string AYZT16 = "AYZT16";

        /// <summary>
        /// AYZT17.
        /// </summary>
        public const string AYZT17 = "AYZT17";

        /// <summary>
        /// AYZT18.
        /// </summary>
        public const string AYZT18 = "AYZT18";

        /// <summary>
        /// AYZT19.
        /// </summary>
        public const string AYZT19 = "AYZT19";

        /// <summary>
        /// AYZT21.
        /// </summary>
        public const string AYZT21 = "AYZT21";

        /// <summary>
        /// AYZT22.
        /// </summary>
        public const string AYZT22 = "AYZT22";

        /// <summary>
        /// AYZW03.
        /// </summary>
        public const string AYZW03 = "AYZW03";

        /// <summary>
        /// AYZW04.
        /// </summary>
        public const string AYZW04 = "AYZW04";

        /// <summary>
        /// AYAN8P.
        /// </summary>
        public const string AYAN8P = "AYAN8P";

        /// <summary>
        /// AYZAIC.
        /// </summary>
        public const string AYZAIC = "AYZAIC";

        /// <summary>
        /// AYZIPB.
        /// </summary>
        public const string AYZIPB = "AYZIPB";

        /// <summary>
        /// AYZCNT.
        /// </summary>
        public const string AYZCNT = "AYZCNT";

        /// <summary>
        /// AYZRC.
        /// </summary>
        public const string AYZRC = "AYZRC";
    }

    /// <inheritdoc />
    public override string TableName => "F74030G";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AYBKTP", "AYBKTP", JdeDataType.String, 2, true, true),
        new JdeField("AYTNST", "AYTNST", JdeDataType.String, 40, true, true),
        new JdeField("AYCBNK", "AYCBNK", JdeDataType.String, 40, true, true),
        new JdeField("AYAN8", "AYAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AYZT16", "AYZT16", JdeDataType.Numeric),
        new JdeField("AYZT17", "AYZT17", JdeDataType.Numeric),
        new JdeField("AYZT18", "AYZT18", JdeDataType.Numeric),
        new JdeField("AYZT19", "AYZT19", JdeDataType.Numeric),
        new JdeField("AYZT21", "AYZT21", JdeDataType.Numeric),
        new JdeField("AYZT22", "AYZT22", JdeDataType.Numeric),
        new JdeField("AYZW03", "AYZW03", JdeDataType.Numeric),
        new JdeField("AYZW04", "AYZW04", JdeDataType.Numeric),
        new JdeField("AYAN8P", "AYAN8P", JdeDataType.Numeric),
        new JdeField("AYZAIC", "AYZAIC", JdeDataType.String, 50),
        new JdeField("AYZIPB", "AYZIPB", JdeDataType.String, 54),
        new JdeField("AYZCNT", "AYZCNT", JdeDataType.String, 70),
        new JdeField("AYZRC", "AYZRC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74030G_0", "Primary Key on AYAN8, AYBKTP, AYTNST, AYCBNK", new[] { "AYAN8", "AYBKTP", "AYTNST", "AYCBNK" }, isUnique: true, isPrimaryKey: true)
    };
}
