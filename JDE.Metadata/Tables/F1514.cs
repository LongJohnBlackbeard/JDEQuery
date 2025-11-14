using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1514 - .
/// </summary>
public class F1514 : JdeTable
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
        /// NWUNIT.
        /// </summary>
        public const string NWUNIT = "NWUNIT";

        /// <summary>
        /// NWARTY.
        /// </summary>
        public const string NWARTY = "NWARTY";

        /// <summary>
        /// NWARGC.
        /// </summary>
        public const string NWARGC = "NWARGC";

        /// <summary>
        /// NWARGV.
        /// </summary>
        public const string NWARGV = "NWARGV";

        /// <summary>
        /// NWDL01.
        /// </summary>
        public const string NWDL01 = "NWDL01";

        /// <summary>
        /// NWARLL.
        /// </summary>
        public const string NWARLL = "NWARLL";

        /// <summary>
        /// NWSEQ.
        /// </summary>
        public const string NWSEQ = "NWSEQ";

        /// <summary>
        /// NWPMU1.
        /// </summary>
        public const string NWPMU1 = "NWPMU1";

        /// <summary>
        /// NWUM.
        /// </summary>
        public const string NWUM = "NWUM";

        /// <summary>
        /// NWEFTB.
        /// </summary>
        public const string NWEFTB = "NWEFTB";

        /// <summary>
        /// NWEFTE.
        /// </summary>
        public const string NWEFTE = "NWEFTE";

        /// <summary>
        /// NWURCD.
        /// </summary>
        public const string NWURCD = "NWURCD";

        /// <summary>
        /// NWURDT.
        /// </summary>
        public const string NWURDT = "NWURDT";

        /// <summary>
        /// NWURAT.
        /// </summary>
        public const string NWURAT = "NWURAT";

        /// <summary>
        /// NWURAB.
        /// </summary>
        public const string NWURAB = "NWURAB";

        /// <summary>
        /// NWURRF.
        /// </summary>
        public const string NWURRF = "NWURRF";

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
        /// NWENTJ.
        /// </summary>
        public const string NWENTJ = "NWENTJ";

        /// <summary>
        /// NWTORG.
        /// </summary>
        public const string NWTORG = "NWTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F1514";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NWMCU", "NWMCU", JdeDataType.String, 24, true, true),
        new JdeField("NWFLOR", "NWFLOR", JdeDataType.String, 8, true, true),
        new JdeField("NWUNIT", "NWUNIT", JdeDataType.String, 16, true, true),
        new JdeField("NWARTY", "NWARTY", JdeDataType.String, 6),
        new JdeField("NWARGC", "NWARGC", JdeDataType.String, 8, true, true),
        new JdeField("NWARGV", "NWARGV", JdeDataType.String, 10, true, true),
        new JdeField("NWDL01", "NWDL01", JdeDataType.String, 60),
        new JdeField("NWARLL", "NWARLL", JdeDataType.String, 2, true, true),
        new JdeField("NWSEQ", "NWSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("NWPMU1", "NWPMU1", JdeDataType.Numeric),
        new JdeField("NWUM", "NWUM", JdeDataType.String, 4),
        new JdeField("NWEFTB", "NWEFTB", JdeDataType.Numeric),
        new JdeField("NWEFTE", "NWEFTE", JdeDataType.Numeric),
        new JdeField("NWURCD", "NWURCD", JdeDataType.String, 4),
        new JdeField("NWURDT", "NWURDT", JdeDataType.Numeric),
        new JdeField("NWURAT", "NWURAT", JdeDataType.Numeric),
        new JdeField("NWURAB", "NWURAB", JdeDataType.Numeric),
        new JdeField("NWURRF", "NWURRF", JdeDataType.String, 30),
        new JdeField("NWUSER", "NWUSER", JdeDataType.String, 20),
        new JdeField("NWPID", "NWPID", JdeDataType.String, 20),
        new JdeField("NWUPMJ", "NWUPMJ", JdeDataType.Numeric),
        new JdeField("NWUPMT", "NWUPMT", JdeDataType.Numeric),
        new JdeField("NWJOBN", "NWJOBN", JdeDataType.String, 20),
        new JdeField("NWENTJ", "NWENTJ", JdeDataType.Numeric),
        new JdeField("NWTORG", "NWTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1514_0", "Primary Key on NWMCU, NWFLOR, NWARGC, NWARGV, NWUNIT, NWARLL, NWSEQ", new[] { "NWMCU", "NWFLOR", "NWARGC", "NWARGV", "NWUNIT", "NWARLL", "NWSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1514_2", "Index on NWMCU, NWFLOR, NWARGC, NWARGV, NWUNIT, NWARLL, SYS_NC00026$", new[] { "NWMCU", "NWFLOR", "NWARGC", "NWARGV", "NWUNIT", "NWARLL", "SYS_NC00026$" }),
        new JdeIndex("F1514_3", "Index on NWMCU, NWFLOR, NWUNIT, NWEFTB", new[] { "NWMCU", "NWFLOR", "NWUNIT", "NWEFTB" }),
        new JdeIndex("F1514_4", "Index on NWMCU, NWARTY, NWARLL, NWEFTB", new[] { "NWMCU", "NWARTY", "NWARLL", "NWEFTB" }),
        new JdeIndex("F1514_5", "Index on NWMCU, NWEFTB, NWEFTE", new[] { "NWMCU", "NWEFTB", "NWEFTE" })
    };
}
