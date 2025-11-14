using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1514D - .
/// </summary>
public class F1514D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NWMCU.
        /// </summary>
        public const string NWMCU = "NWMCU";

        /// <summary>
        /// NWFLOR.
        /// </summary>
        public const string NWFLOR = "NWFLOR";

        /// <summary>
        /// NWARGC.
        /// </summary>
        public const string NWARGC = "NWARGC";

        /// <summary>
        /// NWARGV.
        /// </summary>
        public const string NWARGV = "NWARGV";

        /// <summary>
        /// NWUNIT.
        /// </summary>
        public const string NWUNIT = "NWUNIT";

        /// <summary>
        /// NWARLL.
        /// </summary>
        public const string NWARLL = "NWARLL";

        /// <summary>
        /// NWSEQ.
        /// </summary>
        public const string NWSEQ = "NWSEQ";

        /// <summary>
        /// NWLNGP.
        /// </summary>
        public const string NWLNGP = "NWLNGP";

        /// <summary>
        /// NWDL01.
        /// </summary>
        public const string NWDL01 = "NWDL01";

        /// <summary>
        /// NWUSER.
        /// </summary>
        public const string NWUSER = "NWUSER";

        /// <summary>
        /// NWPID.
        /// </summary>
        public const string NWPID = "NWPID";

        /// <summary>
        /// NWUPMJ.
        /// </summary>
        public const string NWUPMJ = "NWUPMJ";

        /// <summary>
        /// NWUPMT.
        /// </summary>
        public const string NWUPMT = "NWUPMT";

        /// <summary>
        /// NWJOBN.
        /// </summary>
        public const string NWJOBN = "NWJOBN";

        /// <summary>
        /// NWTORG.
        /// </summary>
        public const string NWTORG = "NWTORG";

        /// <summary>
        /// NWENTJ.
        /// </summary>
        public const string NWENTJ = "NWENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1514D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NWMCU", "NWMCU", JdeDataType.String, 24, true, true),
        new JdeField("NWFLOR", "NWFLOR", JdeDataType.String, 8, true, true),
        new JdeField("NWARGC", "NWARGC", JdeDataType.String, 8, true, true),
        new JdeField("NWARGV", "NWARGV", JdeDataType.String, 10, true, true),
        new JdeField("NWUNIT", "NWUNIT", JdeDataType.String, 16, true, true),
        new JdeField("NWARLL", "NWARLL", JdeDataType.String, 2, true, true),
        new JdeField("NWSEQ", "NWSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("NWLNGP", "NWLNGP", JdeDataType.String, 4, true, true),
        new JdeField("NWDL01", "NWDL01", JdeDataType.String, 60),
        new JdeField("NWUSER", "NWUSER", JdeDataType.String, 20),
        new JdeField("NWPID", "NWPID", JdeDataType.String, 20),
        new JdeField("NWUPMJ", "NWUPMJ", JdeDataType.Numeric),
        new JdeField("NWUPMT", "NWUPMT", JdeDataType.Numeric),
        new JdeField("NWJOBN", "NWJOBN", JdeDataType.String, 20),
        new JdeField("NWTORG", "NWTORG", JdeDataType.String, 20),
        new JdeField("NWENTJ", "NWENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1514D_0", "Primary Key on NWMCU, NWFLOR, NWARGC, NWARGV, NWUNIT, NWARLL, NWSEQ, NWLNGP", new[] { "NWMCU", "NWFLOR", "NWARGC", "NWARGV", "NWUNIT", "NWARLL", "NWSEQ", "NWLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
