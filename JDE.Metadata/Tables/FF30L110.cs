using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L110 - .
/// </summary>
public class FF30L110 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SSSSOEID.
        /// </summary>
        public const string SSSSOEID = "SSSSOEID";

        /// <summary>
        /// SSSOELID.
        /// </summary>
        public const string SSSOELID = "SSSOELID";

        /// <summary>
        /// SSDFSEQ.
        /// </summary>
        public const string SSDFSEQ = "SSDFSEQ";

        /// <summary>
        /// SSOPSP.
        /// </summary>
        public const string SSOPSP = "SSOPSP";

        /// <summary>
        /// SSFSCID.
        /// </summary>
        public const string SSFSCID = "SSFSCID";

        /// <summary>
        /// SSSSOEN.
        /// </summary>
        public const string SSSSOEN = "SSSSOEN";

        /// <summary>
        /// SSSSOEDESC.
        /// </summary>
        public const string SSSSOEDESC = "SSSSOEDESC";

        /// <summary>
        /// SSSTSKID.
        /// </summary>
        public const string SSSTSKID = "SSSTSKID";

        /// <summary>
        /// SSRPQTY.
        /// </summary>
        public const string SSRPQTY = "SSRPQTY";

        /// <summary>
        /// SSINTEXT.
        /// </summary>
        public const string SSINTEXT = "SSINTEXT";

        /// <summary>
        /// SSFEFG.
        /// </summary>
        public const string SSFEFG = "SSFEFG";

        /// <summary>
        /// SSFDPID.
        /// </summary>
        public const string SSFDPID = "SSFDPID";

        /// <summary>
        /// SSFDITM.
        /// </summary>
        public const string SSFDITM = "SSFDITM";

        /// <summary>
        /// SSFDMCU.
        /// </summary>
        public const string SSFDMCU = "SSFDMCU";

        /// <summary>
        /// SSURCD.
        /// </summary>
        public const string SSURCD = "SSURCD";

        /// <summary>
        /// SSURDT.
        /// </summary>
        public const string SSURDT = "SSURDT";

        /// <summary>
        /// SSURAT.
        /// </summary>
        public const string SSURAT = "SSURAT";

        /// <summary>
        /// SSURAB.
        /// </summary>
        public const string SSURAB = "SSURAB";

        /// <summary>
        /// SSURRF.
        /// </summary>
        public const string SSURRF = "SSURRF";

        /// <summary>
        /// SSTORG.
        /// </summary>
        public const string SSTORG = "SSTORG";

        /// <summary>
        /// SSUSER.
        /// </summary>
        public const string SSUSER = "SSUSER";

        /// <summary>
        /// SSPID.
        /// </summary>
        public const string SSPID = "SSPID";

        /// <summary>
        /// SSMKEY.
        /// </summary>
        public const string SSMKEY = "SSMKEY";

        /// <summary>
        /// SSUUPMJ.
        /// </summary>
        public const string SSUUPMJ = "SSUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L110";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SSSSOEID", "SSSSOEID", JdeDataType.Numeric, null, true, true),
        new JdeField("SSSOELID", "SSSOELID", JdeDataType.Numeric, null, true, true),
        new JdeField("SSDFSEQ", "SSDFSEQ", JdeDataType.Numeric),
        new JdeField("SSOPSP", "SSOPSP", JdeDataType.String, 4),
        new JdeField("SSFSCID", "SSFSCID", JdeDataType.Numeric),
        new JdeField("SSSSOEN", "SSSSOEN", JdeDataType.String, 60),
        new JdeField("SSSSOEDESC", "SSSSOEDESC", JdeDataType.String, 60),
        new JdeField("SSSTSKID", "SSSTSKID", JdeDataType.Numeric),
        new JdeField("SSRPQTY", "SSRPQTY", JdeDataType.Numeric),
        new JdeField("SSINTEXT", "SSINTEXT", JdeDataType.String, 4),
        new JdeField("SSFEFG", "SSFEFG", JdeDataType.String, 20),
        new JdeField("SSFDPID", "SSFDPID", JdeDataType.Numeric),
        new JdeField("SSFDITM", "SSFDITM", JdeDataType.Numeric),
        new JdeField("SSFDMCU", "SSFDMCU", JdeDataType.String, 24),
        new JdeField("SSURCD", "SSURCD", JdeDataType.String, 4),
        new JdeField("SSURDT", "SSURDT", JdeDataType.Numeric),
        new JdeField("SSURAT", "SSURAT", JdeDataType.Numeric),
        new JdeField("SSURAB", "SSURAB", JdeDataType.Numeric),
        new JdeField("SSURRF", "SSURRF", JdeDataType.String, 30),
        new JdeField("SSTORG", "SSTORG", JdeDataType.String, 20),
        new JdeField("SSUSER", "SSUSER", JdeDataType.String, 20),
        new JdeField("SSPID", "SSPID", JdeDataType.String, 20),
        new JdeField("SSMKEY", "SSMKEY", JdeDataType.String, 30),
        new JdeField("SSUUPMJ", "SSUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L110_0", "Primary Key on SSSSOEID, SSSOELID", new[] { "SSSSOEID", "SSSOELID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L110_2", "Index on SSFSCID, SSSSOEN, SSDFSEQ", new[] { "SSFSCID", "SSSSOEN", "SSDFSEQ" }),
        new JdeIndex("FF30L110_3", "Index on SSSTSKID", new[] { "SSSTSKID" })
    };
}
