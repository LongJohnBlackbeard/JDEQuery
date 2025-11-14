using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49592 - .
/// </summary>
public class F49592 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DHBN01.
        /// </summary>
        public const string DHBN01 = "DHBN01";

        /// <summary>
        /// DHSEQ.
        /// </summary>
        public const string DHSEQ = "DHSEQ";

        /// <summary>
        /// DHDCCD.
        /// </summary>
        public const string DHDCCD = "DHDCCD";

        /// <summary>
        /// DHDPCR.
        /// </summary>
        public const string DHDPCR = "DHDPCR";

        /// <summary>
        /// DHPGM.
        /// </summary>
        public const string DHPGM = "DHPGM";

        /// <summary>
        /// DHVERS.
        /// </summary>
        public const string DHVERS = "DHVERS";

        /// <summary>
        /// DHDTDO.
        /// </summary>
        public const string DHDTDO = "DHDTDO";

        /// <summary>
        /// DHDCT.
        /// </summary>
        public const string DHDCT = "DHDCT";

        /// <summary>
        /// DHDCNS.
        /// </summary>
        public const string DHDCNS = "DHDCNS";

        /// <summary>
        /// DHCO.
        /// </summary>
        public const string DHCO = "DHCO";

        /// <summary>
        /// DHEMCU.
        /// </summary>
        public const string DHEMCU = "DHEMCU";

        /// <summary>
        /// DHMCU.
        /// </summary>
        public const string DHMCU = "DHMCU";

        /// <summary>
        /// DHDPCA.
        /// </summary>
        public const string DHDPCA = "DHDPCA";

        /// <summary>
        /// DHOUT1.
        /// </summary>
        public const string DHOUT1 = "DHOUT1";

        /// <summary>
        /// DHOUT2.
        /// </summary>
        public const string DHOUT2 = "DHOUT2";

        /// <summary>
        /// DHFID.
        /// </summary>
        public const string DHFID = "DHFID";

        /// <summary>
        /// DHFID2.
        /// </summary>
        public const string DHFID2 = "DHFID2";

        /// <summary>
        /// DHSDPC.
        /// </summary>
        public const string DHSDPC = "DHSDPC";

        /// <summary>
        /// DHSEQN.
        /// </summary>
        public const string DHSEQN = "DHSEQN";

        /// <summary>
        /// DHMCUZ.
        /// </summary>
        public const string DHMCUZ = "DHMCUZ";

        /// <summary>
        /// DHDRCF.
        /// </summary>
        public const string DHDRCF = "DHDRCF";

        /// <summary>
        /// DHDRGF.
        /// </summary>
        public const string DHDRGF = "DHDRGF";

        /// <summary>
        /// DHPIDN.
        /// </summary>
        public const string DHPIDN = "DHPIDN";

        /// <summary>
        /// DHREFQ.
        /// </summary>
        public const string DHREFQ = "DHREFQ";

        /// <summary>
        /// DHPIDU.
        /// </summary>
        public const string DHPIDU = "DHPIDU";

        /// <summary>
        /// DHPDDU.
        /// </summary>
        public const string DHPDDU = "DHPDDU";

        /// <summary>
        /// DHMSG1.
        /// </summary>
        public const string DHMSG1 = "DHMSG1";

        /// <summary>
        /// DHURCD.
        /// </summary>
        public const string DHURCD = "DHURCD";

        /// <summary>
        /// DHURDT.
        /// </summary>
        public const string DHURDT = "DHURDT";

        /// <summary>
        /// DHURAT.
        /// </summary>
        public const string DHURAT = "DHURAT";

        /// <summary>
        /// DHURAB.
        /// </summary>
        public const string DHURAB = "DHURAB";

        /// <summary>
        /// DHURRF.
        /// </summary>
        public const string DHURRF = "DHURRF";

        /// <summary>
        /// DHUSER.
        /// </summary>
        public const string DHUSER = "DHUSER";

        /// <summary>
        /// DHPID.
        /// </summary>
        public const string DHPID = "DHPID";

        /// <summary>
        /// DHJOBN.
        /// </summary>
        public const string DHJOBN = "DHJOBN";

        /// <summary>
        /// DHUPMJ.
        /// </summary>
        public const string DHUPMJ = "DHUPMJ";

        /// <summary>
        /// DHTDAY.
        /// </summary>
        public const string DHTDAY = "DHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49592";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DHBN01", "DHBN01", JdeDataType.Numeric, null, true, true),
        new JdeField("DHSEQ", "DHSEQ", JdeDataType.Numeric),
        new JdeField("DHDCCD", "DHDCCD", JdeDataType.String, 8, true, true),
        new JdeField("DHDPCR", "DHDPCR", JdeDataType.String, 2),
        new JdeField("DHPGM", "DHPGM", JdeDataType.String, 20),
        new JdeField("DHVERS", "DHVERS", JdeDataType.String, 20),
        new JdeField("DHDTDO", "DHDTDO", JdeDataType.Numeric),
        new JdeField("DHDCT", "DHDCT", JdeDataType.String, 4),
        new JdeField("DHDCNS", "DHDCNS", JdeDataType.String, 2),
        new JdeField("DHCO", "DHCO", JdeDataType.String, 10),
        new JdeField("DHEMCU", "DHEMCU", JdeDataType.String, 24),
        new JdeField("DHMCU", "DHMCU", JdeDataType.String, 24),
        new JdeField("DHDPCA", "DHDPCA", JdeDataType.Numeric),
        new JdeField("DHOUT1", "DHOUT1", JdeDataType.String, 20),
        new JdeField("DHOUT2", "DHOUT2", JdeDataType.String, 20),
        new JdeField("DHFID", "DHFID", JdeDataType.String, 20),
        new JdeField("DHFID2", "DHFID2", JdeDataType.String, 20),
        new JdeField("DHSDPC", "DHSDPC", JdeDataType.String, 2),
        new JdeField("DHSEQN", "DHSEQN", JdeDataType.Numeric),
        new JdeField("DHMCUZ", "DHMCUZ", JdeDataType.String, 24, true, true),
        new JdeField("DHDRCF", "DHDRCF", JdeDataType.String, 2),
        new JdeField("DHDRGF", "DHDRGF", JdeDataType.String, 2),
        new JdeField("DHPIDN", "DHPIDN", JdeDataType.String, 64),
        new JdeField("DHREFQ", "DHREFQ", JdeDataType.String, 4),
        new JdeField("DHPIDU", "DHPIDU", JdeDataType.String, 2),
        new JdeField("DHPDDU", "DHPDDU", JdeDataType.String, 2),
        new JdeField("DHMSG1", "DHMSG1", JdeDataType.Numeric),
        new JdeField("DHURCD", "DHURCD", JdeDataType.String, 4),
        new JdeField("DHURDT", "DHURDT", JdeDataType.Numeric),
        new JdeField("DHURAT", "DHURAT", JdeDataType.Numeric),
        new JdeField("DHURAB", "DHURAB", JdeDataType.Numeric),
        new JdeField("DHURRF", "DHURRF", JdeDataType.String, 30),
        new JdeField("DHUSER", "DHUSER", JdeDataType.String, 20),
        new JdeField("DHPID", "DHPID", JdeDataType.String, 20),
        new JdeField("DHJOBN", "DHJOBN", JdeDataType.String, 20),
        new JdeField("DHUPMJ", "DHUPMJ", JdeDataType.Numeric),
        new JdeField("DHTDAY", "DHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49592_0", "Primary Key on DHBN01, DHMCUZ, DHDCCD", new[] { "DHBN01", "DHMCUZ", "DHDCCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49592_2", "Index on DHBN01, DHMCUZ, DHSEQ, DHDCCD", new[] { "DHBN01", "DHMCUZ", "DHSEQ", "DHDCCD" })
    };
}
