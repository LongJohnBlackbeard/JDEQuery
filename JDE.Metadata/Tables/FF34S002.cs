using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF34S002 - .
/// </summary>
public class FF34S002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DPPLNID.
        /// </summary>
        public const string DPPLNID = "DPPLNID";

        /// <summary>
        /// DPFSCID.
        /// </summary>
        public const string DPFSCID = "DPFSCID";

        /// <summary>
        /// DPPRODF31.
        /// </summary>
        public const string DPPRODF31 = "DPPRODF31";

        /// <summary>
        /// DPDFLNID.
        /// </summary>
        public const string DPDFLNID = "DPDFLNID";

        /// <summary>
        /// DPDFLNIDP.
        /// </summary>
        public const string DPDFLNIDP = "DPDFLNIDP";

        /// <summary>
        /// DPDFITM.
        /// </summary>
        public const string DPDFITM = "DPDFITM";

        /// <summary>
        /// DPDFLITM.
        /// </summary>
        public const string DPDFLITM = "DPDFLITM";

        /// <summary>
        /// DPDFAITM.
        /// </summary>
        public const string DPDFAITM = "DPDFAITM";

        /// <summary>
        /// DPDFMCU.
        /// </summary>
        public const string DPDFMCU = "DPDFMCU";

        /// <summary>
        /// DPSHFT.
        /// </summary>
        public const string DPSHFT = "DPSHFT";

        /// <summary>
        /// DPDPLNST.
        /// </summary>
        public const string DPDPLNST = "DPDPLNST";

        /// <summary>
        /// DPDFDOCO.
        /// </summary>
        public const string DPDFDOCO = "DPDFDOCO";

        /// <summary>
        /// DPDCTO.
        /// </summary>
        public const string DPDCTO = "DPDCTO";

        /// <summary>
        /// DPDFKCOO.
        /// </summary>
        public const string DPDFKCOO = "DPDFKCOO";

        /// <summary>
        /// DPLNID.
        /// </summary>
        public const string DPLNID = "DPLNID";

        /// <summary>
        /// DPDPLNQT.
        /// </summary>
        public const string DPDPLNQT = "DPDPLNQT";

        /// <summary>
        /// DPSEQQTY.
        /// </summary>
        public const string DPSEQQTY = "DPSEQQTY";

        /// <summary>
        /// DPDSCPQT.
        /// </summary>
        public const string DPDSCPQT = "DPDSCPQT";

        /// <summary>
        /// DPDCMPQT.
        /// </summary>
        public const string DPDCMPQT = "DPDCMPQT";

        /// <summary>
        /// DPUM.
        /// </summary>
        public const string DPUM = "DPUM";

        /// <summary>
        /// DPDFPRIO.
        /// </summary>
        public const string DPDFPRIO = "DPDFPRIO";

        /// <summary>
        /// DPDPLNSD.
        /// </summary>
        public const string DPDPLNSD = "DPDPLNSD";

        /// <summary>
        /// DPDPLNCD.
        /// </summary>
        public const string DPDPLNCD = "DPDPLNCD";

        /// <summary>
        /// DPDPLNTD.
        /// </summary>
        public const string DPDPLNTD = "DPDPLNTD";

        /// <summary>
        /// DPDPLNOC.
        /// </summary>
        public const string DPDPLNOC = "DPDPLNOC";

        /// <summary>
        /// DPDPLNPR.
        /// </summary>
        public const string DPDPLNPR = "DPDPLNPR";

        /// <summary>
        /// DPLORG.
        /// </summary>
        public const string DPLORG = "DPLORG";

        /// <summary>
        /// DPURCD.
        /// </summary>
        public const string DPURCD = "DPURCD";

        /// <summary>
        /// DPUURDT.
        /// </summary>
        public const string DPUURDT = "DPUURDT";

        /// <summary>
        /// DPURAT.
        /// </summary>
        public const string DPURAT = "DPURAT";

        /// <summary>
        /// DPURAB.
        /// </summary>
        public const string DPURAB = "DPURAB";

        /// <summary>
        /// DPURRF.
        /// </summary>
        public const string DPURRF = "DPURRF";

        /// <summary>
        /// DPPID.
        /// </summary>
        public const string DPPID = "DPPID";

        /// <summary>
        /// DPUUPMJ.
        /// </summary>
        public const string DPUUPMJ = "DPUUPMJ";

        /// <summary>
        /// DPMKEY.
        /// </summary>
        public const string DPMKEY = "DPMKEY";

        /// <summary>
        /// DPUSER.
        /// </summary>
        public const string DPUSER = "DPUSER";
    }

    /// <inheritdoc />
    public override string TableName => "FF34S002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DPPLNID", "DPPLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DPFSCID", "DPFSCID", JdeDataType.Numeric),
        new JdeField("DPPRODF31", "DPPRODF31", JdeDataType.Numeric),
        new JdeField("DPDFLNID", "DPDFLNID", JdeDataType.Numeric),
        new JdeField("DPDFLNIDP", "DPDFLNIDP", JdeDataType.Numeric),
        new JdeField("DPDFITM", "DPDFITM", JdeDataType.Numeric),
        new JdeField("DPDFLITM", "DPDFLITM", JdeDataType.String, 50),
        new JdeField("DPDFAITM", "DPDFAITM", JdeDataType.String, 50),
        new JdeField("DPDFMCU", "DPDFMCU", JdeDataType.String, 24),
        new JdeField("DPSHFT", "DPSHFT", JdeDataType.String, 2),
        new JdeField("DPDPLNST", "DPDPLNST", JdeDataType.String, 2),
        new JdeField("DPDFDOCO", "DPDFDOCO", JdeDataType.Numeric),
        new JdeField("DPDCTO", "DPDCTO", JdeDataType.String, 4),
        new JdeField("DPDFKCOO", "DPDFKCOO", JdeDataType.String, 10),
        new JdeField("DPLNID", "DPLNID", JdeDataType.Numeric),
        new JdeField("DPDPLNQT", "DPDPLNQT", JdeDataType.Numeric),
        new JdeField("DPSEQQTY", "DPSEQQTY", JdeDataType.Numeric),
        new JdeField("DPDSCPQT", "DPDSCPQT", JdeDataType.Numeric),
        new JdeField("DPDCMPQT", "DPDCMPQT", JdeDataType.Numeric),
        new JdeField("DPUM", "DPUM", JdeDataType.String, 4),
        new JdeField("DPDFPRIO", "DPDFPRIO", JdeDataType.String, 2),
        new JdeField("DPDPLNSD", "DPDPLNSD", JdeDataType.Date),
        new JdeField("DPDPLNCD", "DPDPLNCD", JdeDataType.Date),
        new JdeField("DPDPLNTD", "DPDPLNTD", JdeDataType.Date),
        new JdeField("DPDPLNOC", "DPDPLNOC", JdeDataType.String, 2),
        new JdeField("DPDPLNPR", "DPDPLNPR", JdeDataType.String, 6),
        new JdeField("DPLORG", "DPLORG", JdeDataType.String, 2),
        new JdeField("DPURCD", "DPURCD", JdeDataType.String, 4),
        new JdeField("DPUURDT", "DPUURDT", JdeDataType.Date),
        new JdeField("DPURAT", "DPURAT", JdeDataType.Numeric),
        new JdeField("DPURAB", "DPURAB", JdeDataType.Numeric),
        new JdeField("DPURRF", "DPURRF", JdeDataType.String, 30),
        new JdeField("DPPID", "DPPID", JdeDataType.String, 20),
        new JdeField("DPUUPMJ", "DPUUPMJ", JdeDataType.Date),
        new JdeField("DPMKEY", "DPMKEY", JdeDataType.String, 30),
        new JdeField("DPUSER", "DPUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF34S002_0", "Primary Key on DPPLNID", new[] { "DPPLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF34S002_2", "Index on DPFSCID, DPDFLNID, DPDPLNSD", new[] { "DPFSCID", "DPDFLNID", "DPDPLNSD" }),
        new JdeIndex("FF34S002_3", "Index on DPFSCID, DPDFDOCO, DPDCTO, DPDFKCOO, DPLNID", new[] { "DPFSCID", "DPDFDOCO", "DPDCTO", "DPDFKCOO", "DPLNID" }),
        new JdeIndex("FF34S002_4", "Index on DPFSCID, DPDFLNID, DPDFITM, DPDPLNSD, DPSHFT", new[] { "DPFSCID", "DPDFLNID", "DPDFITM", "DPDPLNSD", "DPSHFT" }),
        new JdeIndex("FF34S002_5", "Index on DPPRODF31", new[] { "DPPRODF31" })
    };
}
