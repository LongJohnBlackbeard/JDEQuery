using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3440 - .
/// </summary>
public class F3440 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MHITM.
        /// </summary>
        public const string MHITM = "MHITM";

        /// <summary>
        /// MHMCU.
        /// </summary>
        public const string MHMCU = "MHMCU";

        /// <summary>
        /// MHDOCO.
        /// </summary>
        public const string MHDOCO = "MHDOCO";

        /// <summary>
        /// MHDCTO.
        /// </summary>
        public const string MHDCTO = "MHDCTO";

        /// <summary>
        /// MHKCOO.
        /// </summary>
        public const string MHKCOO = "MHKCOO";

        /// <summary>
        /// MHSFXO.
        /// </summary>
        public const string MHSFXO = "MHSFXO";

        /// <summary>
        /// MHLNID.
        /// </summary>
        public const string MHLNID = "MHLNID";

        /// <summary>
        /// MHSTRT.
        /// </summary>
        public const string MHSTRT = "MHSTRT";

        /// <summary>
        /// MHIDGEN.
        /// </summary>
        public const string MHIDGEN = "MHIDGEN";

        /// <summary>
        /// MHLHIST.
        /// </summary>
        public const string MHLHIST = "MHLHIST";

        /// <summary>
        /// MHAN8.
        /// </summary>
        public const string MHAN8 = "MHAN8";

        /// <summary>
        /// MHPLQT.
        /// </summary>
        public const string MHPLQT = "MHPLQT";

        /// <summary>
        /// MHCMQTY.
        /// </summary>
        public const string MHCMQTY = "MHCMQTY";

        /// <summary>
        /// MHRLQT.
        /// </summary>
        public const string MHRLQT = "MHRLQT";

        /// <summary>
        /// MHALQC.
        /// </summary>
        public const string MHALQC = "MHALQC";

        /// <summary>
        /// MHGENQJ.
        /// </summary>
        public const string MHGENQJ = "MHGENQJ";

        /// <summary>
        /// MHURC1.
        /// </summary>
        public const string MHURC1 = "MHURC1";

        /// <summary>
        /// MHURDT.
        /// </summary>
        public const string MHURDT = "MHURDT";

        /// <summary>
        /// MHURAB.
        /// </summary>
        public const string MHURAB = "MHURAB";

        /// <summary>
        /// MHURAT.
        /// </summary>
        public const string MHURAT = "MHURAT";

        /// <summary>
        /// MHURRF.
        /// </summary>
        public const string MHURRF = "MHURRF";

        /// <summary>
        /// MHUSER.
        /// </summary>
        public const string MHUSER = "MHUSER";

        /// <summary>
        /// MHPID.
        /// </summary>
        public const string MHPID = "MHPID";

        /// <summary>
        /// MHWRKSTNID.
        /// </summary>
        public const string MHWRKSTNID = "MHWRKSTNID";

        /// <summary>
        /// MHUPMJ.
        /// </summary>
        public const string MHUPMJ = "MHUPMJ";

        /// <summary>
        /// MHTDAY.
        /// </summary>
        public const string MHTDAY = "MHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3440";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MHITM", "MHITM", JdeDataType.Numeric),
        new JdeField("MHMCU", "MHMCU", JdeDataType.String, 24),
        new JdeField("MHDOCO", "MHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("MHDCTO", "MHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("MHKCOO", "MHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("MHSFXO", "MHSFXO", JdeDataType.String, 6, true, true),
        new JdeField("MHLNID", "MHLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("MHSTRT", "MHSTRT", JdeDataType.Numeric, null, true, true),
        new JdeField("MHIDGEN", "MHIDGEN", JdeDataType.Numeric, null, true, true),
        new JdeField("MHLHIST", "MHLHIST", JdeDataType.String, 2),
        new JdeField("MHAN8", "MHAN8", JdeDataType.Numeric),
        new JdeField("MHPLQT", "MHPLQT", JdeDataType.Numeric),
        new JdeField("MHCMQTY", "MHCMQTY", JdeDataType.Numeric),
        new JdeField("MHRLQT", "MHRLQT", JdeDataType.Numeric),
        new JdeField("MHALQC", "MHALQC", JdeDataType.String, 2),
        new JdeField("MHGENQJ", "MHGENQJ", JdeDataType.Numeric),
        new JdeField("MHURC1", "MHURC1", JdeDataType.String, 6),
        new JdeField("MHURDT", "MHURDT", JdeDataType.Numeric),
        new JdeField("MHURAB", "MHURAB", JdeDataType.Numeric),
        new JdeField("MHURAT", "MHURAT", JdeDataType.Numeric),
        new JdeField("MHURRF", "MHURRF", JdeDataType.String, 30),
        new JdeField("MHUSER", "MHUSER", JdeDataType.String, 20),
        new JdeField("MHPID", "MHPID", JdeDataType.String, 20),
        new JdeField("MHWRKSTNID", "MHWRKSTNID", JdeDataType.String, 20),
        new JdeField("MHUPMJ", "MHUPMJ", JdeDataType.Numeric),
        new JdeField("MHTDAY", "MHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3440_0", "Primary Key on MHDOCO, MHDCTO, MHKCOO, MHSFXO, MHLNID, MHSTRT, MHIDGEN", new[] { "MHDOCO", "MHDCTO", "MHKCOO", "MHSFXO", "MHLNID", "MHSTRT", "MHIDGEN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3440_2", "Index on MHITM, MHMCU, MHDOCO, MHDCTO, MHKCOO, MHSFXO, MHLNID, MHSTRT, SYS_NC00027$", new[] { "MHITM", "MHMCU", "MHDOCO", "MHDCTO", "MHKCOO", "MHSFXO", "MHLNID", "MHSTRT", "SYS_NC00027$" })
    };
}
