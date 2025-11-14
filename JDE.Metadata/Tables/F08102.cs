using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08102 - .
/// </summary>
public class F08102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HNREQN.
        /// </summary>
        public const string HNREQN = "HNREQN";

        /// <summary>
        /// HNMCU.
        /// </summary>
        public const string HNMCU = "HNMCU";

        /// <summary>
        /// HNPOS.
        /// </summary>
        public const string HNPOS = "HNPOS";

        /// <summary>
        /// HNDL01.
        /// </summary>
        public const string HNDL01 = "HNDL01";

        /// <summary>
        /// HNFY.
        /// </summary>
        public const string HNFY = "HNFY";

        /// <summary>
        /// HNREQD.
        /// </summary>
        public const string HNREQD = "HNREQD";

        /// <summary>
        /// HNREQ.
        /// </summary>
        public const string HNREQ = "HNREQ";

        /// <summary>
        /// HNREQS.
        /// </summary>
        public const string HNREQS = "HNREQS";

        /// <summary>
        /// HNREQT.
        /// </summary>
        public const string HNREQT = "HNREQT";

        /// <summary>
        /// HNEXS.
        /// </summary>
        public const string HNEXS = "HNEXS";

        /// <summary>
        /// HNBFTE.
        /// </summary>
        public const string HNBFTE = "HNBFTE";

        /// <summary>
        /// HNHRB.
        /// </summary>
        public const string HNHRB = "HNHRB";

        /// <summary>
        /// HNJBCD.
        /// </summary>
        public const string HNJBCD = "HNJBCD";

        /// <summary>
        /// HNJBST.
        /// </summary>
        public const string HNJBST = "HNJBST";

        /// <summary>
        /// HNPGRD.
        /// </summary>
        public const string HNPGRD = "HNPGRD";

        /// <summary>
        /// HNPGRS.
        /// </summary>
        public const string HNPGRS = "HNPGRS";

        /// <summary>
        /// HNSLOC.
        /// </summary>
        public const string HNSLOC = "HNSLOC";

        /// <summary>
        /// HNSALY.
        /// </summary>
        public const string HNSALY = "HNSALY";

        /// <summary>
        /// HNEFTS.
        /// </summary>
        public const string HNEFTS = "HNEFTS";

        /// <summary>
        /// HNEFST.
        /// </summary>
        public const string HNEFST = "HNEFST";

        /// <summary>
        /// HNEFTB.
        /// </summary>
        public const string HNEFTB = "HNEFTB";

        /// <summary>
        /// HNFLSA.
        /// </summary>
        public const string HNFLSA = "HNFLSA";

        /// <summary>
        /// HNAPRV.
        /// </summary>
        public const string HNAPRV = "HNAPRV";

        /// <summary>
        /// HNAN8.
        /// </summary>
        public const string HNAN8 = "HNAN8";

        /// <summary>
        /// HNAPRD.
        /// </summary>
        public const string HNAPRD = "HNAPRD";

        /// <summary>
        /// HNDL02.
        /// </summary>
        public const string HNDL02 = "HNDL02";

        /// <summary>
        /// HND240.
        /// </summary>
        public const string HND240 = "HND240";

        /// <summary>
        /// HNRX01.
        /// </summary>
        public const string HNRX01 = "HNRX01";

        /// <summary>
        /// HNRX02.
        /// </summary>
        public const string HNRX02 = "HNRX02";

        /// <summary>
        /// HNRX03.
        /// </summary>
        public const string HNRX03 = "HNRX03";

        /// <summary>
        /// HNRX04.
        /// </summary>
        public const string HNRX04 = "HNRX04";

        /// <summary>
        /// HNRX05.
        /// </summary>
        public const string HNRX05 = "HNRX05";

        /// <summary>
        /// HNUSER.
        /// </summary>
        public const string HNUSER = "HNUSER";

        /// <summary>
        /// HNPID.
        /// </summary>
        public const string HNPID = "HNPID";

        /// <summary>
        /// HNUPMJ.
        /// </summary>
        public const string HNUPMJ = "HNUPMJ";

        /// <summary>
        /// HNJOBN.
        /// </summary>
        public const string HNJOBN = "HNJOBN";

        /// <summary>
        /// HNHMCU.
        /// </summary>
        public const string HNHMCU = "HNHMCU";

        /// <summary>
        /// HNRX06.
        /// </summary>
        public const string HNRX06 = "HNRX06";

        /// <summary>
        /// HNRX07.
        /// </summary>
        public const string HNRX07 = "HNRX07";

        /// <summary>
        /// HNRX08.
        /// </summary>
        public const string HNRX08 = "HNRX08";

        /// <summary>
        /// HNRX09.
        /// </summary>
        public const string HNRX09 = "HNRX09";

        /// <summary>
        /// HNRX10.
        /// </summary>
        public const string HNRX10 = "HNRX10";

        /// <summary>
        /// HNEXS2.
        /// </summary>
        public const string HNEXS2 = "HNEXS2";

        /// <summary>
        /// HNHDCT.
        /// </summary>
        public const string HNHDCT = "HNHDCT";

        /// <summary>
        /// HNDTPF.
        /// </summary>
        public const string HNDTPF = "HNDTPF";

        /// <summary>
        /// HNPSTP.
        /// </summary>
        public const string HNPSTP = "HNPSTP";

        /// <summary>
        /// HNFBDT.
        /// </summary>
        public const string HNFBDT = "HNFBDT";
    }

    /// <inheritdoc />
    public override string TableName => "F08102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HNREQN", "HNREQN", JdeDataType.Numeric, null, true, true),
        new JdeField("HNMCU", "HNMCU", JdeDataType.String, 24),
        new JdeField("HNPOS", "HNPOS", JdeDataType.String, 16),
        new JdeField("HNDL01", "HNDL01", JdeDataType.String, 60),
        new JdeField("HNFY", "HNFY", JdeDataType.Numeric),
        new JdeField("HNREQD", "HNREQD", JdeDataType.Numeric),
        new JdeField("HNREQ", "HNREQ", JdeDataType.Numeric),
        new JdeField("HNREQS", "HNREQS", JdeDataType.String, 4),
        new JdeField("HNREQT", "HNREQT", JdeDataType.String, 2),
        new JdeField("HNEXS", "HNEXS", JdeDataType.Numeric),
        new JdeField("HNBFTE", "HNBFTE", JdeDataType.Numeric),
        new JdeField("HNHRB", "HNHRB", JdeDataType.Numeric),
        new JdeField("HNJBCD", "HNJBCD", JdeDataType.String, 12),
        new JdeField("HNJBST", "HNJBST", JdeDataType.String, 8),
        new JdeField("HNPGRD", "HNPGRD", JdeDataType.String, 12),
        new JdeField("HNPGRS", "HNPGRS", JdeDataType.String, 8),
        new JdeField("HNSLOC", "HNSLOC", JdeDataType.String, 16),
        new JdeField("HNSALY", "HNSALY", JdeDataType.String, 2),
        new JdeField("HNEFTS", "HNEFTS", JdeDataType.Numeric),
        new JdeField("HNEFST", "HNEFST", JdeDataType.Numeric),
        new JdeField("HNEFTB", "HNEFTB", JdeDataType.Numeric),
        new JdeField("HNFLSA", "HNFLSA", JdeDataType.String, 2),
        new JdeField("HNAPRV", "HNAPRV", JdeDataType.Numeric),
        new JdeField("HNAN8", "HNAN8", JdeDataType.Numeric),
        new JdeField("HNAPRD", "HNAPRD", JdeDataType.Numeric),
        new JdeField("HNDL02", "HNDL02", JdeDataType.String, 60),
        new JdeField("HND240", "HND240", JdeDataType.String, 480),
        new JdeField("HNRX01", "HNRX01", JdeDataType.String, 6),
        new JdeField("HNRX02", "HNRX02", JdeDataType.String, 6),
        new JdeField("HNRX03", "HNRX03", JdeDataType.String, 6),
        new JdeField("HNRX04", "HNRX04", JdeDataType.String, 6),
        new JdeField("HNRX05", "HNRX05", JdeDataType.String, 6),
        new JdeField("HNUSER", "HNUSER", JdeDataType.String, 20),
        new JdeField("HNPID", "HNPID", JdeDataType.String, 20),
        new JdeField("HNUPMJ", "HNUPMJ", JdeDataType.Numeric),
        new JdeField("HNJOBN", "HNJOBN", JdeDataType.String, 20),
        new JdeField("HNHMCU", "HNHMCU", JdeDataType.String, 24),
        new JdeField("HNRX06", "HNRX06", JdeDataType.String, 6),
        new JdeField("HNRX07", "HNRX07", JdeDataType.String, 6),
        new JdeField("HNRX08", "HNRX08", JdeDataType.String, 6),
        new JdeField("HNRX09", "HNRX09", JdeDataType.String, 6),
        new JdeField("HNRX10", "HNRX10", JdeDataType.String, 6),
        new JdeField("HNEXS2", "HNEXS2", JdeDataType.Numeric),
        new JdeField("HNHDCT", "HNHDCT", JdeDataType.Numeric),
        new JdeField("HNDTPF", "HNDTPF", JdeDataType.Numeric),
        new JdeField("HNPSTP", "HNPSTP", JdeDataType.String, 8),
        new JdeField("HNFBDT", "HNFBDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08102_0", "Primary Key on HNREQN", new[] { "HNREQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08102_2", "Index on HNMCU, HNREQN", new[] { "HNMCU", "HNREQN" }),
        new JdeIndex("F08102_3", "Index on HNJBCD, HNJBST", new[] { "HNJBCD", "HNJBST" }),
        new JdeIndex("F08102_4", "Index on HNFY, HNHMCU, HNPOS", new[] { "HNFY", "HNHMCU", "HNPOS" }),
        new JdeIndex("F08102_5", "Index on HNREQ", new[] { "HNREQ" })
    };
}
