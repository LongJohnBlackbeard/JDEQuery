using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H604Z - .
/// </summary>
public class F44H604Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZHBAREA.
        /// </summary>
        public const string SZHBAREA = "SZHBAREA";

        /// <summary>
        /// SZR001.
        /// </summary>
        public const string SZR001 = "SZR001";

        /// <summary>
        /// SZHBMCUS.
        /// </summary>
        public const string SZHBMCUS = "SZHBMCUS";

        /// <summary>
        /// SZCPHASE.
        /// </summary>
        public const string SZCPHASE = "SZCPHASE";

        /// <summary>
        /// SZHBLOT.
        /// </summary>
        public const string SZHBLOT = "SZHBLOT";

        /// <summary>
        /// SZOPTION.
        /// </summary>
        public const string SZOPTION = "SZOPTION";

        /// <summary>
        /// SZEFFF.
        /// </summary>
        public const string SZEFFF = "SZEFFF";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZASNSTS.
        /// </summary>
        public const string SZASNSTS = "SZASNSTS";

        /// <summary>
        /// SZEXPR.
        /// </summary>
        public const string SZEXPR = "SZEXPR";

        /// <summary>
        /// SZDOCO.
        /// </summary>
        public const string SZDOCO = "SZDOCO";

        /// <summary>
        /// SZDCTO.
        /// </summary>
        public const string SZDCTO = "SZDCTO";

        /// <summary>
        /// SZTRDJ.
        /// </summary>
        public const string SZTRDJ = "SZTRDJ";

        /// <summary>
        /// SZAVEL.
        /// </summary>
        public const string SZAVEL = "SZAVEL";

        /// <summary>
        /// SZHBST1.
        /// </summary>
        public const string SZHBST1 = "SZHBST1";

        /// <summary>
        /// SZHBST2.
        /// </summary>
        public const string SZHBST2 = "SZHBST2";

        /// <summary>
        /// SZHBST3.
        /// </summary>
        public const string SZHBST3 = "SZHBST3";

        /// <summary>
        /// SZHBST4.
        /// </summary>
        public const string SZHBST4 = "SZHBST4";

        /// <summary>
        /// SZHBST5.
        /// </summary>
        public const string SZHBST5 = "SZHBST5";

        /// <summary>
        /// SZCRTU.
        /// </summary>
        public const string SZCRTU = "SZCRTU";

        /// <summary>
        /// SZCRTJ.
        /// </summary>
        public const string SZCRTJ = "SZCRTJ";

        /// <summary>
        /// SZCRTT.
        /// </summary>
        public const string SZCRTT = "SZCRTT";

        /// <summary>
        /// SZWRKSTNID.
        /// </summary>
        public const string SZWRKSTNID = "SZWRKSTNID";

        /// <summary>
        /// SZHBOPID.
        /// </summary>
        public const string SZHBOPID = "SZHBOPID";

        /// <summary>
        /// SZUPMB.
        /// </summary>
        public const string SZUPMB = "SZUPMB";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZUPMT.
        /// </summary>
        public const string SZUPMT = "SZUPMT";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZASNRPR.
        /// </summary>
        public const string SZASNRPR = "SZASNRPR";

        /// <summary>
        /// SZNPAREA.
        /// </summary>
        public const string SZNPAREA = "SZNPAREA";

        /// <summary>
        /// SZNPMCUS.
        /// </summary>
        public const string SZNPMCUS = "SZNPMCUS";

        /// <summary>
        /// SZNPHASE.
        /// </summary>
        public const string SZNPHASE = "SZNPHASE";
    }

    /// <inheritdoc />
    public override string TableName => "F44H604Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZHBAREA", "SZHBAREA", JdeDataType.String, 6),
        new JdeField("SZR001", "SZR001", JdeDataType.String, 6),
        new JdeField("SZHBMCUS", "SZHBMCUS", JdeDataType.String, 24),
        new JdeField("SZCPHASE", "SZCPHASE", JdeDataType.String, 6),
        new JdeField("SZHBLOT", "SZHBLOT", JdeDataType.String, 8),
        new JdeField("SZOPTION", "SZOPTION", JdeDataType.String, 16),
        new JdeField("SZEFFF", "SZEFFF", JdeDataType.Numeric),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZASNSTS", "SZASNSTS", JdeDataType.String, 2),
        new JdeField("SZEXPR", "SZEXPR", JdeDataType.Numeric),
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4),
        new JdeField("SZTRDJ", "SZTRDJ", JdeDataType.Numeric),
        new JdeField("SZAVEL", "SZAVEL", JdeDataType.String, 2),
        new JdeField("SZHBST1", "SZHBST1", JdeDataType.String, 2),
        new JdeField("SZHBST2", "SZHBST2", JdeDataType.String, 2),
        new JdeField("SZHBST3", "SZHBST3", JdeDataType.String, 2),
        new JdeField("SZHBST4", "SZHBST4", JdeDataType.String, 2),
        new JdeField("SZHBST5", "SZHBST5", JdeDataType.String, 2),
        new JdeField("SZCRTU", "SZCRTU", JdeDataType.String, 20),
        new JdeField("SZCRTJ", "SZCRTJ", JdeDataType.Numeric),
        new JdeField("SZCRTT", "SZCRTT", JdeDataType.Numeric),
        new JdeField("SZWRKSTNID", "SZWRKSTNID", JdeDataType.String, 20),
        new JdeField("SZHBOPID", "SZHBOPID", JdeDataType.String, 20),
        new JdeField("SZUPMB", "SZUPMB", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZUPMT", "SZUPMT", JdeDataType.Numeric),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZASNRPR", "SZASNRPR", JdeDataType.String, 2),
        new JdeField("SZNPAREA", "SZNPAREA", JdeDataType.String, 6),
        new JdeField("SZNPMCUS", "SZNPMCUS", JdeDataType.String, 24),
        new JdeField("SZNPHASE", "SZNPHASE", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H604Z_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H604Z_3", "Index on SZHBAREA, SZR001, SZHBMCUS, SZCPHASE, SZHBLOT, SZOPTION, SZEFFF", new[] { "SZHBAREA", "SZR001", "SZHBMCUS", "SZCPHASE", "SZHBLOT", "SZOPTION", "SZEFFF" })
    };
}
