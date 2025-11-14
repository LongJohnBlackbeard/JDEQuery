using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J41 - .
/// </summary>
public class F09J41 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JLJVCCID.
        /// </summary>
        public const string JLJVCCID = "JLJVCCID";

        /// <summary>
        /// JLJLDOC.
        /// </summary>
        public const string JLJLDOC = "JLJLDOC";

        /// <summary>
        /// JLJLDCT.
        /// </summary>
        public const string JLJLDCT = "JLJLDCT";

        /// <summary>
        /// JLJLKCO.
        /// </summary>
        public const string JLJLKCO = "JLJLKCO";

        /// <summary>
        /// JLJLDGJ.
        /// </summary>
        public const string JLJLDGJ = "JLJLDGJ";

        /// <summary>
        /// JLJLLT.
        /// </summary>
        public const string JLJLLT = "JLJLLT";

        /// <summary>
        /// JLJLDTT.
        /// </summary>
        public const string JLJLDTT = "JLJLDTT";

        /// <summary>
        /// JLJVAN8.
        /// </summary>
        public const string JLJVAN8 = "JLJVAN8";

        /// <summary>
        /// JLJVIBU.
        /// </summary>
        public const string JLJVIBU = "JLJVIBU";

        /// <summary>
        /// JLJVNAME.
        /// </summary>
        public const string JLJVNAME = "JLJVNAME";

        /// <summary>
        /// JLEFTB.
        /// </summary>
        public const string JLEFTB = "JLEFTB";

        /// <summary>
        /// JLMCUS.
        /// </summary>
        public const string JLMCUS = "JLMCUS";

        /// <summary>
        /// JLMCU.
        /// </summary>
        public const string JLMCU = "JLMCU";

        /// <summary>
        /// JLJVAGN.
        /// </summary>
        public const string JLJVAGN = "JLJVAGN";

        /// <summary>
        /// JLJVVOD.
        /// </summary>
        public const string JLJVVOD = "JLJVVOD";

        /// <summary>
        /// JLVDGJ.
        /// </summary>
        public const string JLVDGJ = "JLVDGJ";

        /// <summary>
        /// JLURAB.
        /// </summary>
        public const string JLURAB = "JLURAB";

        /// <summary>
        /// JLURCD.
        /// </summary>
        public const string JLURCD = "JLURCD";

        /// <summary>
        /// JLURAT.
        /// </summary>
        public const string JLURAT = "JLURAT";

        /// <summary>
        /// JLURDT.
        /// </summary>
        public const string JLURDT = "JLURDT";

        /// <summary>
        /// JLURRF.
        /// </summary>
        public const string JLURRF = "JLURRF";

        /// <summary>
        /// JLJVYNU1.
        /// </summary>
        public const string JLJVYNU1 = "JLJVYNU1";

        /// <summary>
        /// JLJVYNU2.
        /// </summary>
        public const string JLJVYNU2 = "JLJVYNU2";

        /// <summary>
        /// JLJVYNU3.
        /// </summary>
        public const string JLJVYNU3 = "JLJVYNU3";

        /// <summary>
        /// JLJVYST1.
        /// </summary>
        public const string JLJVYST1 = "JLJVYST1";

        /// <summary>
        /// JLJVYST2.
        /// </summary>
        public const string JLJVYST2 = "JLJVYST2";

        /// <summary>
        /// JLJVYST3.
        /// </summary>
        public const string JLJVYST3 = "JLJVYST3";

        /// <summary>
        /// JLJVYCH1.
        /// </summary>
        public const string JLJVYCH1 = "JLJVYCH1";

        /// <summary>
        /// JLJVYCH2.
        /// </summary>
        public const string JLJVYCH2 = "JLJVYCH2";

        /// <summary>
        /// JLJVYCH3.
        /// </summary>
        public const string JLJVYCH3 = "JLJVYCH3";

        /// <summary>
        /// JLJVYDT1.
        /// </summary>
        public const string JLJVYDT1 = "JLJVYDT1";

        /// <summary>
        /// JLJVYDT2.
        /// </summary>
        public const string JLJVYDT2 = "JLJVYDT2";

        /// <summary>
        /// JLJVYDT3.
        /// </summary>
        public const string JLJVYDT3 = "JLJVYDT3";

        /// <summary>
        /// JLTORG.
        /// </summary>
        public const string JLTORG = "JLTORG";

        /// <summary>
        /// JLENTJ.
        /// </summary>
        public const string JLENTJ = "JLENTJ";

        /// <summary>
        /// JLUSER.
        /// </summary>
        public const string JLUSER = "JLUSER";

        /// <summary>
        /// JLUPMJ.
        /// </summary>
        public const string JLUPMJ = "JLUPMJ";

        /// <summary>
        /// JLUPMT.
        /// </summary>
        public const string JLUPMT = "JLUPMT";

        /// <summary>
        /// JLPID.
        /// </summary>
        public const string JLPID = "JLPID";

        /// <summary>
        /// JLMKEY.
        /// </summary>
        public const string JLMKEY = "JLMKEY";

        /// <summary>
        /// JLJVTDA.
        /// </summary>
        public const string JLJVTDA = "JLJVTDA";

        /// <summary>
        /// JLJVRCCI.
        /// </summary>
        public const string JLJVRCCI = "JLJVRCCI";

        /// <summary>
        /// JLJVMCO.
        /// </summary>
        public const string JLJVMCO = "JLJVMCO";
    }

    /// <inheritdoc />
    public override string TableName => "F09J41";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JLJVCCID", "JLJVCCID", JdeDataType.Numeric, null, true, true),
        new JdeField("JLJLDOC", "JLJLDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("JLJLDCT", "JLJLDCT", JdeDataType.String, 4, true, true),
        new JdeField("JLJLKCO", "JLJLKCO", JdeDataType.String, 10, true, true),
        new JdeField("JLJLDGJ", "JLJLDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("JLJLLT", "JLJLLT", JdeDataType.String, 4, true, true),
        new JdeField("JLJLDTT", "JLJLDTT", JdeDataType.String, 4),
        new JdeField("JLJVAN8", "JLJVAN8", JdeDataType.Numeric),
        new JdeField("JLJVIBU", "JLJVIBU", JdeDataType.String, 24),
        new JdeField("JLJVNAME", "JLJVNAME", JdeDataType.String, 40),
        new JdeField("JLEFTB", "JLEFTB", JdeDataType.Numeric),
        new JdeField("JLMCUS", "JLMCUS", JdeDataType.String, 24),
        new JdeField("JLMCU", "JLMCU", JdeDataType.String, 24),
        new JdeField("JLJVAGN", "JLJVAGN", JdeDataType.String, 40),
        new JdeField("JLJVVOD", "JLJVVOD", JdeDataType.String, 2),
        new JdeField("JLVDGJ", "JLVDGJ", JdeDataType.Numeric),
        new JdeField("JLURAB", "JLURAB", JdeDataType.Numeric),
        new JdeField("JLURCD", "JLURCD", JdeDataType.String, 4),
        new JdeField("JLURAT", "JLURAT", JdeDataType.Numeric),
        new JdeField("JLURDT", "JLURDT", JdeDataType.Numeric),
        new JdeField("JLURRF", "JLURRF", JdeDataType.String, 30),
        new JdeField("JLJVYNU1", "JLJVYNU1", JdeDataType.Numeric),
        new JdeField("JLJVYNU2", "JLJVYNU2", JdeDataType.Numeric),
        new JdeField("JLJVYNU3", "JLJVYNU3", JdeDataType.Numeric),
        new JdeField("JLJVYST1", "JLJVYST1", JdeDataType.String, 160),
        new JdeField("JLJVYST2", "JLJVYST2", JdeDataType.String, 160),
        new JdeField("JLJVYST3", "JLJVYST3", JdeDataType.String, 160),
        new JdeField("JLJVYCH1", "JLJVYCH1", JdeDataType.String, 2),
        new JdeField("JLJVYCH2", "JLJVYCH2", JdeDataType.String, 2),
        new JdeField("JLJVYCH3", "JLJVYCH3", JdeDataType.String, 2),
        new JdeField("JLJVYDT1", "JLJVYDT1", JdeDataType.Numeric),
        new JdeField("JLJVYDT2", "JLJVYDT2", JdeDataType.Numeric),
        new JdeField("JLJVYDT3", "JLJVYDT3", JdeDataType.Numeric),
        new JdeField("JLTORG", "JLTORG", JdeDataType.String, 20),
        new JdeField("JLENTJ", "JLENTJ", JdeDataType.Numeric),
        new JdeField("JLUSER", "JLUSER", JdeDataType.String, 20),
        new JdeField("JLUPMJ", "JLUPMJ", JdeDataType.Numeric),
        new JdeField("JLUPMT", "JLUPMT", JdeDataType.Numeric),
        new JdeField("JLPID", "JLPID", JdeDataType.String, 20),
        new JdeField("JLMKEY", "JLMKEY", JdeDataType.String, 30),
        new JdeField("JLJVTDA", "JLJVTDA", JdeDataType.Numeric),
        new JdeField("JLJVRCCI", "JLJVRCCI", JdeDataType.Numeric),
        new JdeField("JLJVMCO", "JLJVMCO", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J41_0", "Primary Key on JLJVCCID, JLJLDOC, JLJLDCT, JLJLKCO, JLJLDGJ, JLJLLT", new[] { "JLJVCCID", "JLJLDOC", "JLJLDCT", "JLJLKCO", "JLJLDGJ", "JLJLLT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J41_2", "Index on JLJVCCID, JLJLDTT", new[] { "JLJVCCID", "JLJLDTT" }),
        new JdeIndex("F09J41_3", "Index on JLJLDOC, JLJLDCT, JLJLKCO, JLJLDGJ, JLJLLT", new[] { "JLJLDOC", "JLJLDCT", "JLJLKCO", "JLJLDGJ", "JLJLLT" })
    };
}
