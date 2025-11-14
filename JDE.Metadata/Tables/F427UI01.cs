using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F427UI01 - .
/// </summary>
public class F427UI01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RFJOBS.
        /// </summary>
        public const string RFJOBS = "RFJOBS";

        /// <summary>
        /// RFGPBT.
        /// </summary>
        public const string RFGPBT = "RFGPBT";

        /// <summary>
        /// RFSEQLN.
        /// </summary>
        public const string RFSEQLN = "RFSEQLN";

        /// <summary>
        /// RFDOCO.
        /// </summary>
        public const string RFDOCO = "RFDOCO";

        /// <summary>
        /// RFDCTO.
        /// </summary>
        public const string RFDCTO = "RFDCTO";

        /// <summary>
        /// RFKCOO.
        /// </summary>
        public const string RFKCOO = "RFKCOO";

        /// <summary>
        /// RFLNID.
        /// </summary>
        public const string RFLNID = "RFLNID";

        /// <summary>
        /// RFSONE.
        /// </summary>
        public const string RFSONE = "RFSONE";

        /// <summary>
        /// RFSOQS.
        /// </summary>
        public const string RFSOQS = "RFSOQS";

        /// <summary>
        /// RFALLOC.
        /// </summary>
        public const string RFALLOC = "RFALLOC";

        /// <summary>
        /// RFALLSTS.
        /// </summary>
        public const string RFALLSTS = "RFALLSTS";

        /// <summary>
        /// RFCOMM.
        /// </summary>
        public const string RFCOMM = "RFCOMM";

        /// <summary>
        /// RFSHAN.
        /// </summary>
        public const string RFSHAN = "RFSHAN";

        /// <summary>
        /// RFLITM.
        /// </summary>
        public const string RFLITM = "RFLITM";

        /// <summary>
        /// RFUOM.
        /// </summary>
        public const string RFUOM = "RFUOM";

        /// <summary>
        /// RFNXTR.
        /// </summary>
        public const string RFNXTR = "RFNXTR";

        /// <summary>
        /// RFRKIT.
        /// </summary>
        public const string RFRKIT = "RFRKIT";

        /// <summary>
        /// RFKTLN.
        /// </summary>
        public const string RFKTLN = "RFKTLN";

        /// <summary>
        /// RFMCU.
        /// </summary>
        public const string RFMCU = "RFMCU";

        /// <summary>
        /// RFAITM.
        /// </summary>
        public const string RFAITM = "RFAITM";

        /// <summary>
        /// RFITM.
        /// </summary>
        public const string RFITM = "RFITM";

        /// <summary>
        /// RFDVAN.
        /// </summary>
        public const string RFDVAN = "RFDVAN";

        /// <summary>
        /// RFUORG.
        /// </summary>
        public const string RFUORG = "RFUORG";

        /// <summary>
        /// RFLNTY.
        /// </summary>
        public const string RFLNTY = "RFLNTY";

        /// <summary>
        /// RFLTTR.
        /// </summary>
        public const string RFLTTR = "RFLTTR";

        /// <summary>
        /// RFAN8.
        /// </summary>
        public const string RFAN8 = "RFAN8";

        /// <summary>
        /// RFDRQJ.
        /// </summary>
        public const string RFDRQJ = "RFDRQJ";

        /// <summary>
        /// RFUSER.
        /// </summary>
        public const string RFUSER = "RFUSER";

        /// <summary>
        /// RFPID.
        /// </summary>
        public const string RFPID = "RFPID";

        /// <summary>
        /// RFJOBN.
        /// </summary>
        public const string RFJOBN = "RFJOBN";

        /// <summary>
        /// RFUPMJ.
        /// </summary>
        public const string RFUPMJ = "RFUPMJ";

        /// <summary>
        /// RFTDAY.
        /// </summary>
        public const string RFTDAY = "RFTDAY";

        /// <summary>
        /// RFURCD.
        /// </summary>
        public const string RFURCD = "RFURCD";

        /// <summary>
        /// RFURDT.
        /// </summary>
        public const string RFURDT = "RFURDT";

        /// <summary>
        /// RFURRF.
        /// </summary>
        public const string RFURRF = "RFURRF";

        /// <summary>
        /// RFURAT.
        /// </summary>
        public const string RFURAT = "RFURAT";

        /// <summary>
        /// RFURAB.
        /// </summary>
        public const string RFURAB = "RFURAB";

        /// <summary>
        /// RFUTIME.
        /// </summary>
        public const string RFUTIME = "RFUTIME";

        /// <summary>
        /// RFAPTS.
        /// </summary>
        public const string RFAPTS = "RFAPTS";

        /// <summary>
        /// RFOSCOREO.
        /// </summary>
        public const string RFOSCOREO = "RFOSCOREO";

        /// <summary>
        /// RFPRGR.
        /// </summary>
        public const string RFPRGR = "RFPRGR";

        /// <summary>
        /// RFPRGP.
        /// </summary>
        public const string RFPRGP = "RFPRGP";

        /// <summary>
        /// RFRLIT.
        /// </summary>
        public const string RFRLIT = "RFRLIT";

        /// <summary>
        /// RFLOCN.
        /// </summary>
        public const string RFLOCN = "RFLOCN";

        /// <summary>
        /// RFLOTN.
        /// </summary>
        public const string RFLOTN = "RFLOTN";

        /// <summary>
        /// RFUOM1.
        /// </summary>
        public const string RFUOM1 = "RFUOM1";

        /// <summary>
        /// RFSHPN.
        /// </summary>
        public const string RFSHPN = "RFSHPN";

        /// <summary>
        /// RFRFFC01.
        /// </summary>
        public const string RFRFFC01 = "RFRFFC01";

        /// <summary>
        /// RFRFFC02.
        /// </summary>
        public const string RFRFFC02 = "RFRFFC02";

        /// <summary>
        /// RFRFFS01.
        /// </summary>
        public const string RFRFFS01 = "RFRFFS01";

        /// <summary>
        /// RFRFFS02.
        /// </summary>
        public const string RFRFFS02 = "RFRFFS02";

        /// <summary>
        /// RFRFFD01.
        /// </summary>
        public const string RFRFFD01 = "RFRFFD01";

        /// <summary>
        /// RFRFFD02.
        /// </summary>
        public const string RFRFFD02 = "RFRFFD02";

        /// <summary>
        /// RFRFFN01.
        /// </summary>
        public const string RFRFFN01 = "RFRFFN01";

        /// <summary>
        /// RFRFFN02.
        /// </summary>
        public const string RFRFFN02 = "RFRFFN02";

        /// <summary>
        /// RFRFFA01.
        /// </summary>
        public const string RFRFFA01 = "RFRFFA01";

        /// <summary>
        /// RFRFFA02.
        /// </summary>
        public const string RFRFFA02 = "RFRFFA02";
    }

    /// <inheritdoc />
    public override string TableName => "F427UI01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RFJOBS", "RFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("RFGPBT", "RFGPBT", JdeDataType.Numeric, null, true, true),
        new JdeField("RFSEQLN", "RFSEQLN", JdeDataType.Numeric, null, true, true),
        new JdeField("RFDOCO", "RFDOCO", JdeDataType.Numeric),
        new JdeField("RFDCTO", "RFDCTO", JdeDataType.String, 4),
        new JdeField("RFKCOO", "RFKCOO", JdeDataType.String, 10),
        new JdeField("RFLNID", "RFLNID", JdeDataType.Numeric),
        new JdeField("RFSONE", "RFSONE", JdeDataType.Numeric),
        new JdeField("RFSOQS", "RFSOQS", JdeDataType.Numeric),
        new JdeField("RFALLOC", "RFALLOC", JdeDataType.String, 2),
        new JdeField("RFALLSTS", "RFALLSTS", JdeDataType.String, 60),
        new JdeField("RFCOMM", "RFCOMM", JdeDataType.String, 2),
        new JdeField("RFSHAN", "RFSHAN", JdeDataType.Numeric),
        new JdeField("RFLITM", "RFLITM", JdeDataType.String, 50),
        new JdeField("RFUOM", "RFUOM", JdeDataType.String, 4),
        new JdeField("RFNXTR", "RFNXTR", JdeDataType.String, 6),
        new JdeField("RFRKIT", "RFRKIT", JdeDataType.Numeric),
        new JdeField("RFKTLN", "RFKTLN", JdeDataType.Numeric),
        new JdeField("RFMCU", "RFMCU", JdeDataType.String, 24),
        new JdeField("RFAITM", "RFAITM", JdeDataType.String, 50),
        new JdeField("RFITM", "RFITM", JdeDataType.Numeric),
        new JdeField("RFDVAN", "RFDVAN", JdeDataType.Numeric),
        new JdeField("RFUORG", "RFUORG", JdeDataType.Numeric),
        new JdeField("RFLNTY", "RFLNTY", JdeDataType.String, 4),
        new JdeField("RFLTTR", "RFLTTR", JdeDataType.String, 6),
        new JdeField("RFAN8", "RFAN8", JdeDataType.Numeric),
        new JdeField("RFDRQJ", "RFDRQJ", JdeDataType.Numeric),
        new JdeField("RFUSER", "RFUSER", JdeDataType.String, 20),
        new JdeField("RFPID", "RFPID", JdeDataType.String, 20),
        new JdeField("RFJOBN", "RFJOBN", JdeDataType.String, 20),
        new JdeField("RFUPMJ", "RFUPMJ", JdeDataType.Numeric),
        new JdeField("RFTDAY", "RFTDAY", JdeDataType.Numeric),
        new JdeField("RFURCD", "RFURCD", JdeDataType.String, 4),
        new JdeField("RFURDT", "RFURDT", JdeDataType.Numeric),
        new JdeField("RFURRF", "RFURRF", JdeDataType.String, 30),
        new JdeField("RFURAT", "RFURAT", JdeDataType.Numeric),
        new JdeField("RFURAB", "RFURAB", JdeDataType.Numeric),
        new JdeField("RFUTIME", "RFUTIME", JdeDataType.Date),
        new JdeField("RFAPTS", "RFAPTS", JdeDataType.String, 2),
        new JdeField("RFOSCOREO", "RFOSCOREO", JdeDataType.String, 2),
        new JdeField("RFPRGR", "RFPRGR", JdeDataType.String, 16),
        new JdeField("RFPRGP", "RFPRGP", JdeDataType.String, 16),
        new JdeField("RFRLIT", "RFRLIT", JdeDataType.String, 16),
        new JdeField("RFLOCN", "RFLOCN", JdeDataType.String, 40),
        new JdeField("RFLOTN", "RFLOTN", JdeDataType.String, 60),
        new JdeField("RFUOM1", "RFUOM1", JdeDataType.String, 4),
        new JdeField("RFSHPN", "RFSHPN", JdeDataType.Numeric),
        new JdeField("RFRFFC01", "RFRFFC01", JdeDataType.String, 2),
        new JdeField("RFRFFC02", "RFRFFC02", JdeDataType.String, 2),
        new JdeField("RFRFFS01", "RFRFFS01", JdeDataType.String, 4),
        new JdeField("RFRFFS02", "RFRFFS02", JdeDataType.String, 4),
        new JdeField("RFRFFD01", "RFRFFD01", JdeDataType.Numeric),
        new JdeField("RFRFFD02", "RFRFFD02", JdeDataType.Numeric),
        new JdeField("RFRFFN01", "RFRFFN01", JdeDataType.Numeric),
        new JdeField("RFRFFN02", "RFRFFN02", JdeDataType.Numeric),
        new JdeField("RFRFFA01", "RFRFFA01", JdeDataType.Numeric),
        new JdeField("RFRFFA02", "RFRFFA02", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F427UI01_0", "Primary Key on RFJOBS, RFGPBT, RFSEQLN", new[] { "RFJOBS", "RFGPBT", "RFSEQLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F427UI01_2", "Index on RFGPBT, RFSEQLN", new[] { "RFGPBT", "RFSEQLN" })
    };
}
