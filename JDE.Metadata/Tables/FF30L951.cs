using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L951 - .
/// </summary>
public class FF30L951 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OMLNDSID.
        /// </summary>
        public const string OMLNDSID = "OMLNDSID";

        /// <summary>
        /// OMPROID.
        /// </summary>
        public const string OMPROID = "OMPROID";

        /// <summary>
        /// OMCELLID.
        /// </summary>
        public const string OMCELLID = "OMCELLID";

        /// <summary>
        /// OMDFMCU.
        /// </summary>
        public const string OMDFMCU = "OMDFMCU";

        /// <summary>
        /// OMDFITM.
        /// </summary>
        public const string OMDFITM = "OMDFITM";

        /// <summary>
        /// OMRC15.
        /// </summary>
        public const string OMRC15 = "OMRC15";

        /// <summary>
        /// OMFSCID.
        /// </summary>
        public const string OMFSCID = "OMFSCID";

        /// <summary>
        /// OMODIPK.
        /// </summary>
        public const string OMODIPK = "OMODIPK";

        /// <summary>
        /// OMODOPNO.
        /// </summary>
        public const string OMODOPNO = "OMODOPNO";

        /// <summary>
        /// OMODOPNA.
        /// </summary>
        public const string OMODOPNA = "OMODOPNA";

        /// <summary>
        /// OMODPONO.
        /// </summary>
        public const string OMODPONO = "OMODPONO";

        /// <summary>
        /// OMODPONA.
        /// </summary>
        public const string OMODPONA = "OMODPONA";

        /// <summary>
        /// OMRSRCID.
        /// </summary>
        public const string OMRSRCID = "OMRSRCID";

        /// <summary>
        /// OMDFRT.
        /// </summary>
        public const string OMDFRT = "OMDFRT";

        /// <summary>
        /// OMODTSKGP.
        /// </summary>
        public const string OMODTSKGP = "OMODTSKGP";

        /// <summary>
        /// OMOPSP.
        /// </summary>
        public const string OMOPSP = "OMOPSP";

        /// <summary>
        /// OMDFSEQ.
        /// </summary>
        public const string OMDFSEQ = "OMDFSEQ";

        /// <summary>
        /// OMSTSKID.
        /// </summary>
        public const string OMSTSKID = "OMSTSKID";

        /// <summary>
        /// OMDESC.
        /// </summary>
        public const string OMDESC = "OMDESC";

        /// <summary>
        /// OMVALADD.
        /// </summary>
        public const string OMVALADD = "OMVALADD";

        /// <summary>
        /// OMTIMEUOM.
        /// </summary>
        public const string OMTIMEUOM = "OMTIMEUOM";

        /// <summary>
        /// OMODSEQTM.
        /// </summary>
        public const string OMODSEQTM = "OMODSEQTM";

        /// <summary>
        /// OMODCUMTM.
        /// </summary>
        public const string OMODCUMTM = "OMODCUMTM";

        /// <summary>
        /// OMRPQTY.
        /// </summary>
        public const string OMRPQTY = "OMRPQTY";

        /// <summary>
        /// OMSTQTY.
        /// </summary>
        public const string OMSTQTY = "OMSTQTY";

        /// <summary>
        /// OMMDSTID.
        /// </summary>
        public const string OMMDSTID = "OMMDSTID";

        /// <summary>
        /// OMURCD.
        /// </summary>
        public const string OMURCD = "OMURCD";

        /// <summary>
        /// OMURDT.
        /// </summary>
        public const string OMURDT = "OMURDT";

        /// <summary>
        /// OMURAT.
        /// </summary>
        public const string OMURAT = "OMURAT";

        /// <summary>
        /// OMURAB.
        /// </summary>
        public const string OMURAB = "OMURAB";

        /// <summary>
        /// OMURRF.
        /// </summary>
        public const string OMURRF = "OMURRF";

        /// <summary>
        /// OMTORG.
        /// </summary>
        public const string OMTORG = "OMTORG";

        /// <summary>
        /// OMUSER.
        /// </summary>
        public const string OMUSER = "OMUSER";

        /// <summary>
        /// OMPID.
        /// </summary>
        public const string OMPID = "OMPID";

        /// <summary>
        /// OMMKEY.
        /// </summary>
        public const string OMMKEY = "OMMKEY";

        /// <summary>
        /// OMUUPMJ.
        /// </summary>
        public const string OMUUPMJ = "OMUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L951";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OMLNDSID", "OMLNDSID", JdeDataType.Numeric, null, true, true),
        new JdeField("OMPROID", "OMPROID", JdeDataType.Numeric, null, true, true),
        new JdeField("OMCELLID", "OMCELLID", JdeDataType.Numeric, null, true, true),
        new JdeField("OMDFMCU", "OMDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("OMDFITM", "OMDFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("OMRC15", "OMRC15", JdeDataType.Numeric, null, true, true),
        new JdeField("OMFSCID", "OMFSCID", JdeDataType.Numeric),
        new JdeField("OMODIPK", "OMODIPK", JdeDataType.Numeric),
        new JdeField("OMODOPNO", "OMODOPNO", JdeDataType.Numeric),
        new JdeField("OMODOPNA", "OMODOPNA", JdeDataType.String, 60),
        new JdeField("OMODPONO", "OMODPONO", JdeDataType.Numeric),
        new JdeField("OMODPONA", "OMODPONA", JdeDataType.String, 60),
        new JdeField("OMRSRCID", "OMRSRCID", JdeDataType.Numeric),
        new JdeField("OMDFRT", "OMDFRT", JdeDataType.String, 4),
        new JdeField("OMODTSKGP", "OMODTSKGP", JdeDataType.Numeric),
        new JdeField("OMOPSP", "OMOPSP", JdeDataType.String, 4),
        new JdeField("OMDFSEQ", "OMDFSEQ", JdeDataType.Numeric),
        new JdeField("OMSTSKID", "OMSTSKID", JdeDataType.Numeric),
        new JdeField("OMDESC", "OMDESC", JdeDataType.String, 60),
        new JdeField("OMVALADD", "OMVALADD", JdeDataType.String, 4),
        new JdeField("OMTIMEUOM", "OMTIMEUOM", JdeDataType.String, 2),
        new JdeField("OMODSEQTM", "OMODSEQTM", JdeDataType.Numeric),
        new JdeField("OMODCUMTM", "OMODCUMTM", JdeDataType.Numeric),
        new JdeField("OMRPQTY", "OMRPQTY", JdeDataType.Numeric),
        new JdeField("OMSTQTY", "OMSTQTY", JdeDataType.Numeric),
        new JdeField("OMMDSTID", "OMMDSTID", JdeDataType.Numeric),
        new JdeField("OMURCD", "OMURCD", JdeDataType.String, 4),
        new JdeField("OMURDT", "OMURDT", JdeDataType.Numeric),
        new JdeField("OMURAT", "OMURAT", JdeDataType.Numeric),
        new JdeField("OMURAB", "OMURAB", JdeDataType.Numeric),
        new JdeField("OMURRF", "OMURRF", JdeDataType.String, 30),
        new JdeField("OMTORG", "OMTORG", JdeDataType.String, 20),
        new JdeField("OMUSER", "OMUSER", JdeDataType.String, 20),
        new JdeField("OMPID", "OMPID", JdeDataType.String, 20),
        new JdeField("OMMKEY", "OMMKEY", JdeDataType.String, 30),
        new JdeField("OMUUPMJ", "OMUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L951_0", "Primary Key on OMLNDSID, OMPROID, OMCELLID, OMDFMCU, OMDFITM, OMRC15", new[] { "OMLNDSID", "OMPROID", "OMCELLID", "OMDFMCU", "OMDFITM", "OMRC15" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L951_2", "Index on OMFSCID", new[] { "OMFSCID" }),
        new JdeIndex("FF30L951_3", "Index on OMLNDSID, OMPROID, OMCELLID, OMDFITM", new[] { "OMLNDSID", "OMPROID", "OMCELLID", "OMDFITM" })
    };
}
