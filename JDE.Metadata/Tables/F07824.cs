using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07824 - .
/// </summary>
public class F07824 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JDIDYE.
        /// </summary>
        public const string JDIDYE = "JDIDYE";

        /// <summary>
        /// JDDTEY.
        /// </summary>
        public const string JDDTEY = "JDDTEY";

        /// <summary>
        /// JDHMCO.
        /// </summary>
        public const string JDHMCO = "JDHMCO";

        /// <summary>
        /// JDTAXX.
        /// </summary>
        public const string JDTAXX = "JDTAXX";

        /// <summary>
        /// JDW2RT.
        /// </summary>
        public const string JDW2RT = "JDW2RT";

        /// <summary>
        /// JDTFYE.
        /// </summary>
        public const string JDTFYE = "JDTFYE";

        /// <summary>
        /// JDTWYE.
        /// </summary>
        public const string JDTWYE = "JDTWYE";

        /// <summary>
        /// JDDTCF.
        /// </summary>
        public const string JDDTCF = "JDDTCF";

        /// <summary>
        /// JDTAXS.
        /// </summary>
        public const string JDTAXS = "JDTAXS";

        /// <summary>
        /// JDPTAX.
        /// </summary>
        public const string JDPTAX = "JDPTAX";

        /// <summary>
        /// JDSCOD.
        /// </summary>
        public const string JDSCOD = "JDSCOD";

        /// <summary>
        /// JDWST.
        /// </summary>
        public const string JDWST = "JDWST";

        /// <summary>
        /// JDWCNT.
        /// </summary>
        public const string JDWCNT = "JDWCNT";

        /// <summary>
        /// JDWCTY.
        /// </summary>
        public const string JDWCTY = "JDWCTY";

        /// <summary>
        /// JDSTWG.
        /// </summary>
        public const string JDSTWG = "JDSTWG";

        /// <summary>
        /// JDSTAJ.
        /// </summary>
        public const string JDSTAJ = "JDSTAJ";

        /// <summary>
        /// JDSTTX.
        /// </summary>
        public const string JDSTTX = "JDSTTX";

        /// <summary>
        /// JDW2SU.
        /// </summary>
        public const string JDW2SU = "JDW2SU";

        /// <summary>
        /// JDW2SD.
        /// </summary>
        public const string JDW2SD = "JDW2SD";

        /// <summary>
        /// JDUPMJ.
        /// </summary>
        public const string JDUPMJ = "JDUPMJ";

        /// <summary>
        /// JDUPMT.
        /// </summary>
        public const string JDUPMT = "JDUPMT";

        /// <summary>
        /// JDPID.
        /// </summary>
        public const string JDPID = "JDPID";

        /// <summary>
        /// JDJOBN.
        /// </summary>
        public const string JDJOBN = "JDJOBN";

        /// <summary>
        /// JDUSER.
        /// </summary>
        public const string JDUSER = "JDUSER";

        /// <summary>
        /// JDSEIC.
        /// </summary>
        public const string JDSEIC = "JDSEIC";
    }

    /// <inheritdoc />
    public override string TableName => "F07824";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JDIDYE", "JDIDYE", JdeDataType.String, 20, true, true),
        new JdeField("JDDTEY", "JDDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JDHMCO", "JDHMCO", JdeDataType.String, 10, true, true),
        new JdeField("JDTAXX", "JDTAXX", JdeDataType.String, 40, true, true),
        new JdeField("JDW2RT", "JDW2RT", JdeDataType.String, 2, true, true),
        new JdeField("JDTFYE", "JDTFYE", JdeDataType.String, 2, true, true),
        new JdeField("JDTWYE", "JDTWYE", JdeDataType.String, 2, true, true),
        new JdeField("JDDTCF", "JDDTCF", JdeDataType.Numeric, null, true, true),
        new JdeField("JDTAXS", "JDTAXS", JdeDataType.String, 40, true, true),
        new JdeField("JDPTAX", "JDPTAX", JdeDataType.String, 4, true, true),
        new JdeField("JDSCOD", "JDSCOD", JdeDataType.String, 6),
        new JdeField("JDWST", "JDWST", JdeDataType.Numeric, null, true, true),
        new JdeField("JDWCNT", "JDWCNT", JdeDataType.Numeric, null, true, true),
        new JdeField("JDWCTY", "JDWCTY", JdeDataType.Numeric, null, true, true),
        new JdeField("JDSTWG", "JDSTWG", JdeDataType.Numeric),
        new JdeField("JDSTAJ", "JDSTAJ", JdeDataType.Numeric),
        new JdeField("JDSTTX", "JDSTTX", JdeDataType.Numeric),
        new JdeField("JDW2SU", "JDW2SU", JdeDataType.Numeric),
        new JdeField("JDW2SD", "JDW2SD", JdeDataType.Numeric),
        new JdeField("JDUPMJ", "JDUPMJ", JdeDataType.Numeric),
        new JdeField("JDUPMT", "JDUPMT", JdeDataType.Numeric),
        new JdeField("JDPID", "JDPID", JdeDataType.String, 20),
        new JdeField("JDJOBN", "JDJOBN", JdeDataType.String, 20),
        new JdeField("JDUSER", "JDUSER", JdeDataType.String, 20),
        new JdeField("JDSEIC", "JDSEIC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07824_0", "Primary Key on JDIDYE, JDDTEY, JDHMCO, JDWST, JDWCNT, JDWCTY, JDPTAX, JDTAXX, JDTFYE, JDTWYE, JDDTCF, JDTAXS, JDW2RT", new[] { "JDIDYE", "JDDTEY", "JDHMCO", "JDWST", "JDWCNT", "JDWCTY", "JDPTAX", "JDTAXX", "JDTFYE", "JDTWYE", "JDDTCF", "JDTAXS", "JDW2RT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07824_2", "Index on JDIDYE, JDDTEY, JDHMCO, JDTAXX, JDTFYE", new[] { "JDIDYE", "JDDTEY", "JDHMCO", "JDTAXX", "JDTFYE" }),
        new JdeIndex("F07824_3", "Index on JDIDYE, JDDTEY, JDHMCO, JDTAXX, JDTFYE, JDTWYE, JDPTAX, JDWST", new[] { "JDIDYE", "JDDTEY", "JDHMCO", "JDTAXX", "JDTFYE", "JDTWYE", "JDPTAX", "JDWST" })
    };
}
