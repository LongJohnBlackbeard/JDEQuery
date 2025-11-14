using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4321 - .
/// </summary>
public class F4321 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PBKCOO.
        /// </summary>
        public const string PBKCOO = "PBKCOO";

        /// <summary>
        /// PBDOCO.
        /// </summary>
        public const string PBDOCO = "PBDOCO";

        /// <summary>
        /// PBDCTO.
        /// </summary>
        public const string PBDCTO = "PBDCTO";

        /// <summary>
        /// PBSFXO.
        /// </summary>
        public const string PBSFXO = "PBSFXO";

        /// <summary>
        /// PBLNID.
        /// </summary>
        public const string PBLNID = "PBLNID";

        /// <summary>
        /// PBDLAN.
        /// </summary>
        public const string PBDLAN = "PBDLAN";

        /// <summary>
        /// PBCDF1.
        /// </summary>
        public const string PBCDF1 = "PBCDF1";

        /// <summary>
        /// PBCDF2.
        /// </summary>
        public const string PBCDF2 = "PBCDF2";

        /// <summary>
        /// PBCDF3.
        /// </summary>
        public const string PBCDF3 = "PBCDF3";

        /// <summary>
        /// PBCDF4.
        /// </summary>
        public const string PBCDF4 = "PBCDF4";

        /// <summary>
        /// PBVSD.
        /// </summary>
        public const string PBVSD = "PBVSD";

        /// <summary>
        /// PBVSW.
        /// </summary>
        public const string PBVSW = "PBVSW";

        /// <summary>
        /// PBVSM.
        /// </summary>
        public const string PBVSM = "PBVSM";

        /// <summary>
        /// PBCREC.
        /// </summary>
        public const string PBCREC = "PBCREC";

        /// <summary>
        /// PBCFRO.
        /// </summary>
        public const string PBCFRO = "PBCFRO";

        /// <summary>
        /// PBCFAB.
        /// </summary>
        public const string PBCFAB = "PBCFAB";

        /// <summary>
        /// PBCRAW.
        /// </summary>
        public const string PBCRAW = "PBCRAW";

        /// <summary>
        /// PBDRQJ.
        /// </summary>
        public const string PBDRQJ = "PBDRQJ";

        /// <summary>
        /// PBFRDJ.
        /// </summary>
        public const string PBFRDJ = "PBFRDJ";

        /// <summary>
        /// PBLRDJ.
        /// </summary>
        public const string PBLRDJ = "PBLRDJ";

        /// <summary>
        /// PBDOC.
        /// </summary>
        public const string PBDOC = "PBDOC";

        /// <summary>
        /// PBDCT.
        /// </summary>
        public const string PBDCT = "PBDCT";

        /// <summary>
        /// PBVRN.
        /// </summary>
        public const string PBVRN = "PBVRN";

        /// <summary>
        /// PBVSST.
        /// </summary>
        public const string PBVSST = "PBVSST";

        /// <summary>
        /// PBRJYN.
        /// </summary>
        public const string PBRJYN = "PBRJYN";

        /// <summary>
        /// PBORFD.
        /// </summary>
        public const string PBORFD = "PBORFD";

        /// <summary>
        /// PBLRCJ.
        /// </summary>
        public const string PBLRCJ = "PBLRCJ";

        /// <summary>
        /// PBLRQT.
        /// </summary>
        public const string PBLRQT = "PBLRQT";

        /// <summary>
        /// PBUOPN.
        /// </summary>
        public const string PBUOPN = "PBUOPN";

        /// <summary>
        /// PBUREC.
        /// </summary>
        public const string PBUREC = "PBUREC";

        /// <summary>
        /// PBVSSP.
        /// </summary>
        public const string PBVSSP = "PBVSSP";

        /// <summary>
        /// PBSHLT.
        /// </summary>
        public const string PBSHLT = "PBSHLT";

        /// <summary>
        /// PBSHQT.
        /// </summary>
        public const string PBSHQT = "PBSHQT";

        /// <summary>
        /// PBUPC.
        /// </summary>
        public const string PBUPC = "PBUPC";

        /// <summary>
        /// PBURCD.
        /// </summary>
        public const string PBURCD = "PBURCD";

        /// <summary>
        /// PBURDT.
        /// </summary>
        public const string PBURDT = "PBURDT";

        /// <summary>
        /// PBURAT.
        /// </summary>
        public const string PBURAT = "PBURAT";

        /// <summary>
        /// PBURAB.
        /// </summary>
        public const string PBURAB = "PBURAB";

        /// <summary>
        /// PBURRF.
        /// </summary>
        public const string PBURRF = "PBURRF";

        /// <summary>
        /// PBUSER.
        /// </summary>
        public const string PBUSER = "PBUSER";

        /// <summary>
        /// PBPID.
        /// </summary>
        public const string PBPID = "PBPID";

        /// <summary>
        /// PBJOBN.
        /// </summary>
        public const string PBJOBN = "PBJOBN";

        /// <summary>
        /// PBUPMJ.
        /// </summary>
        public const string PBUPMJ = "PBUPMJ";

        /// <summary>
        /// PBTDAY.
        /// </summary>
        public const string PBTDAY = "PBTDAY";

        /// <summary>
        /// PBVLOT.
        /// </summary>
        public const string PBVLOT = "PBVLOT";

        /// <summary>
        /// PBRCPD.
        /// </summary>
        public const string PBRCPD = "PBRCPD";

        /// <summary>
        /// PBMXQT.
        /// </summary>
        public const string PBMXQT = "PBMXQT";

        /// <summary>
        /// PBMWDH.
        /// </summary>
        public const string PBMWDH = "PBMWDH";

        /// <summary>
        /// PBLTLV.
        /// </summary>
        public const string PBLTLV = "PBLTLV";

        /// <summary>
        /// PBDCAP.
        /// </summary>
        public const string PBDCAP = "PBDCAP";

        /// <summary>
        /// PBDA08.
        /// </summary>
        public const string PBDA08 = "PBDA08";
    }

    /// <inheritdoc />
    public override string TableName => "F4321";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PBKCOO", "PBKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PBDOCO", "PBDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PBDCTO", "PBDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PBSFXO", "PBSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PBLNID", "PBLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PBDLAN", "PBDLAN", JdeDataType.String, 24),
        new JdeField("PBCDF1", "PBCDF1", JdeDataType.Numeric),
        new JdeField("PBCDF2", "PBCDF2", JdeDataType.Numeric),
        new JdeField("PBCDF3", "PBCDF3", JdeDataType.Numeric),
        new JdeField("PBCDF4", "PBCDF4", JdeDataType.Numeric),
        new JdeField("PBVSD", "PBVSD", JdeDataType.Numeric),
        new JdeField("PBVSW", "PBVSW", JdeDataType.Numeric),
        new JdeField("PBVSM", "PBVSM", JdeDataType.Numeric),
        new JdeField("PBCREC", "PBCREC", JdeDataType.Numeric),
        new JdeField("PBCFRO", "PBCFRO", JdeDataType.Numeric),
        new JdeField("PBCFAB", "PBCFAB", JdeDataType.Numeric),
        new JdeField("PBCRAW", "PBCRAW", JdeDataType.Numeric),
        new JdeField("PBDRQJ", "PBDRQJ", JdeDataType.Numeric),
        new JdeField("PBFRDJ", "PBFRDJ", JdeDataType.Numeric),
        new JdeField("PBLRDJ", "PBLRDJ", JdeDataType.Numeric),
        new JdeField("PBDOC", "PBDOC", JdeDataType.Numeric),
        new JdeField("PBDCT", "PBDCT", JdeDataType.String, 4),
        new JdeField("PBVRN", "PBVRN", JdeDataType.String, 16),
        new JdeField("PBVSST", "PBVSST", JdeDataType.String, 4),
        new JdeField("PBRJYN", "PBRJYN", JdeDataType.String, 2),
        new JdeField("PBORFD", "PBORFD", JdeDataType.String, 2),
        new JdeField("PBLRCJ", "PBLRCJ", JdeDataType.Numeric),
        new JdeField("PBLRQT", "PBLRQT", JdeDataType.Numeric),
        new JdeField("PBUOPN", "PBUOPN", JdeDataType.Numeric),
        new JdeField("PBUREC", "PBUREC", JdeDataType.Numeric),
        new JdeField("PBVSSP", "PBVSSP", JdeDataType.String, 4),
        new JdeField("PBSHLT", "PBSHLT", JdeDataType.Numeric),
        new JdeField("PBSHQT", "PBSHQT", JdeDataType.Numeric),
        new JdeField("PBUPC", "PBUPC", JdeDataType.Numeric),
        new JdeField("PBURCD", "PBURCD", JdeDataType.String, 4),
        new JdeField("PBURDT", "PBURDT", JdeDataType.Numeric),
        new JdeField("PBURAT", "PBURAT", JdeDataType.Numeric),
        new JdeField("PBURAB", "PBURAB", JdeDataType.Numeric),
        new JdeField("PBURRF", "PBURRF", JdeDataType.String, 30),
        new JdeField("PBUSER", "PBUSER", JdeDataType.String, 20),
        new JdeField("PBPID", "PBPID", JdeDataType.String, 20),
        new JdeField("PBJOBN", "PBJOBN", JdeDataType.String, 20),
        new JdeField("PBUPMJ", "PBUPMJ", JdeDataType.Numeric),
        new JdeField("PBTDAY", "PBTDAY", JdeDataType.Numeric),
        new JdeField("PBVLOT", "PBVLOT", JdeDataType.Numeric),
        new JdeField("PBRCPD", "PBRCPD", JdeDataType.Numeric),
        new JdeField("PBMXQT", "PBMXQT", JdeDataType.Numeric),
        new JdeField("PBMWDH", "PBMWDH", JdeDataType.String, 2),
        new JdeField("PBLTLV", "PBLTLV", JdeDataType.Numeric),
        new JdeField("PBDCAP", "PBDCAP", JdeDataType.Numeric),
        new JdeField("PBDA08", "PBDA08", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4321_0", "Primary Key on PBDOCO, PBDCTO, PBKCOO, PBSFXO, PBLNID", new[] { "PBDOCO", "PBDCTO", "PBKCOO", "PBSFXO", "PBLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
