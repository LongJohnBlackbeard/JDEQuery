using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F065016T - .
/// </summary>
public class F065016T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YGAN8.
        /// </summary>
        public const string YGAN8 = "YGAN8";

        /// <summary>
        /// YGSEQ.
        /// </summary>
        public const string YGSEQ = "YGSEQ";

        /// <summary>
        /// YGFOA#.
        /// </summary>
        public const string YGFOA_ = "YGFOA#";

        /// <summary>
        /// YGBDM.
        /// </summary>
        public const string YGBDM = "YGBDM";

        /// <summary>
        /// YGNQUAL.
        /// </summary>
        public const string YGNQUAL = "YGNQUAL";

        /// <summary>
        /// YGFDFI.
        /// </summary>
        public const string YGFDFI = "YGFDFI";

        /// <summary>
        /// YGIDCC.
        /// </summary>
        public const string YGIDCC = "YGIDCC";

        /// <summary>
        /// YGIAT01.
        /// </summary>
        public const string YGIAT01 = "YGIAT01";

        /// <summary>
        /// YGIAT02.
        /// </summary>
        public const string YGIAT02 = "YGIAT02";

        /// <summary>
        /// YGIAT03.
        /// </summary>
        public const string YGIAT03 = "YGIAT03";

        /// <summary>
        /// YGIAT04.
        /// </summary>
        public const string YGIAT04 = "YGIAT04";

        /// <summary>
        /// YGIAT05.
        /// </summary>
        public const string YGIAT05 = "YGIAT05";

        /// <summary>
        /// YGIAT06.
        /// </summary>
        public const string YGIAT06 = "YGIAT06";

        /// <summary>
        /// YGIAT07.
        /// </summary>
        public const string YGIAT07 = "YGIAT07";

        /// <summary>
        /// YGIAT08.
        /// </summary>
        public const string YGIAT08 = "YGIAT08";

        /// <summary>
        /// YGIAT09.
        /// </summary>
        public const string YGIAT09 = "YGIAT09";

        /// <summary>
        /// YGIAT10.
        /// </summary>
        public const string YGIAT10 = "YGIAT10";

        /// <summary>
        /// YGIAT11.
        /// </summary>
        public const string YGIAT11 = "YGIAT11";

        /// <summary>
        /// YGIAT12.
        /// </summary>
        public const string YGIAT12 = "YGIAT12";

        /// <summary>
        /// YGUPMJ.
        /// </summary>
        public const string YGUPMJ = "YGUPMJ";

        /// <summary>
        /// YGUPMT.
        /// </summary>
        public const string YGUPMT = "YGUPMT";

        /// <summary>
        /// YGPID.
        /// </summary>
        public const string YGPID = "YGPID";

        /// <summary>
        /// YGJOBN.
        /// </summary>
        public const string YGJOBN = "YGJOBN";

        /// <summary>
        /// YGUSER.
        /// </summary>
        public const string YGUSER = "YGUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F065016T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YGAN8", "YGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YGSEQ", "YGSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("YGFOA#", "YGFOA#", JdeDataType.String, 34, true, true),
        new JdeField("YGBDM", "YGBDM", JdeDataType.String, 2, true, true),
        new JdeField("YGNQUAL", "YGNQUAL", JdeDataType.String, 4),
        new JdeField("YGFDFI", "YGFDFI", JdeDataType.String, 68),
        new JdeField("YGIDCC", "YGIDCC", JdeDataType.String, 6),
        new JdeField("YGIAT01", "YGIAT01", JdeDataType.Numeric),
        new JdeField("YGIAT02", "YGIAT02", JdeDataType.Numeric),
        new JdeField("YGIAT03", "YGIAT03", JdeDataType.Numeric),
        new JdeField("YGIAT04", "YGIAT04", JdeDataType.String, 70),
        new JdeField("YGIAT05", "YGIAT05", JdeDataType.String, 70),
        new JdeField("YGIAT06", "YGIAT06", JdeDataType.String, 70),
        new JdeField("YGIAT07", "YGIAT07", JdeDataType.Numeric),
        new JdeField("YGIAT08", "YGIAT08", JdeDataType.Numeric),
        new JdeField("YGIAT09", "YGIAT09", JdeDataType.Numeric),
        new JdeField("YGIAT10", "YGIAT10", JdeDataType.String, 2),
        new JdeField("YGIAT11", "YGIAT11", JdeDataType.String, 2),
        new JdeField("YGIAT12", "YGIAT12", JdeDataType.String, 2),
        new JdeField("YGUPMJ", "YGUPMJ", JdeDataType.Numeric),
        new JdeField("YGUPMT", "YGUPMT", JdeDataType.Numeric),
        new JdeField("YGPID", "YGPID", JdeDataType.String, 20),
        new JdeField("YGJOBN", "YGJOBN", JdeDataType.String, 20),
        new JdeField("YGUSER", "YGUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F065016T_0", "Primary Key on YGAN8, YGSEQ, YGBDM, YGFOA#", new[] { "YGAN8", "YGSEQ", "YGBDM", "YGFOA#" }, isUnique: true, isPrimaryKey: true)
    };
}
