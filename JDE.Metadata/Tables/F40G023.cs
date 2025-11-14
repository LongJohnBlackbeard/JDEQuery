using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G023 - .
/// </summary>
public class F40G023 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCBLUID.
        /// </summary>
        public const string BCBLUID = "BCBLUID";

        /// <summary>
        /// BCLNID.
        /// </summary>
        public const string BCLNID = "BCLNID";

        /// <summary>
        /// BCSEQ.
        /// </summary>
        public const string BCSEQ = "BCSEQ";

        /// <summary>
        /// BCDESC.
        /// </summary>
        public const string BCDESC = "BCDESC";

        /// <summary>
        /// BCGPSUTM.
        /// </summary>
        public const string BCGPSUTM = "BCGPSUTM";

        /// <summary>
        /// BCGPSD1.
        /// </summary>
        public const string BCGPSD1 = "BCGPSD1";

        /// <summary>
        /// BCGPS1.
        /// </summary>
        public const string BCGPS1 = "BCGPS1";

        /// <summary>
        /// BCGPS2.
        /// </summary>
        public const string BCGPS2 = "BCGPS2";

        /// <summary>
        /// BCGPS3.
        /// </summary>
        public const string BCGPS3 = "BCGPS3";

        /// <summary>
        /// BCGPSD2.
        /// </summary>
        public const string BCGPSD2 = "BCGPSD2";

        /// <summary>
        /// BCGPS4.
        /// </summary>
        public const string BCGPS4 = "BCGPS4";

        /// <summary>
        /// BCGPS5.
        /// </summary>
        public const string BCGPS5 = "BCGPS5";

        /// <summary>
        /// BCGPS6.
        /// </summary>
        public const string BCGPS6 = "BCGPS6";

        /// <summary>
        /// BCUTM1.
        /// </summary>
        public const string BCUTM1 = "BCUTM1";

        /// <summary>
        /// BCUTM2.
        /// </summary>
        public const string BCUTM2 = "BCUTM2";

        /// <summary>
        /// BCUTM3.
        /// </summary>
        public const string BCUTM3 = "BCUTM3";

        /// <summary>
        /// BCUTM4.
        /// </summary>
        public const string BCUTM4 = "BCUTM4";

        /// <summary>
        /// BCELEVATIO.
        /// </summary>
        public const string BCELEVATIO = "BCELEVATIO";

        /// <summary>
        /// BCELEVUOM.
        /// </summary>
        public const string BCELEVUOM = "BCELEVUOM";

        /// <summary>
        /// BCURCD.
        /// </summary>
        public const string BCURCD = "BCURCD";

        /// <summary>
        /// BCURDT.
        /// </summary>
        public const string BCURDT = "BCURDT";

        /// <summary>
        /// BCURRF.
        /// </summary>
        public const string BCURRF = "BCURRF";

        /// <summary>
        /// BCURAT.
        /// </summary>
        public const string BCURAT = "BCURAT";

        /// <summary>
        /// BCURAB.
        /// </summary>
        public const string BCURAB = "BCURAB";

        /// <summary>
        /// BCPID.
        /// </summary>
        public const string BCPID = "BCPID";

        /// <summary>
        /// BCTORG.
        /// </summary>
        public const string BCTORG = "BCTORG";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCJOBN.
        /// </summary>
        public const string BCJOBN = "BCJOBN";

        /// <summary>
        /// BCUUPMJ.
        /// </summary>
        public const string BCUUPMJ = "BCUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G023";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCBLUID", "BCBLUID", JdeDataType.Numeric, null, true, true),
        new JdeField("BCLNID", "BCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("BCSEQ", "BCSEQ", JdeDataType.Numeric),
        new JdeField("BCDESC", "BCDESC", JdeDataType.String, 60),
        new JdeField("BCGPSUTM", "BCGPSUTM", JdeDataType.String, 2),
        new JdeField("BCGPSD1", "BCGPSD1", JdeDataType.String, 2),
        new JdeField("BCGPS1", "BCGPS1", JdeDataType.Numeric),
        new JdeField("BCGPS2", "BCGPS2", JdeDataType.Numeric),
        new JdeField("BCGPS3", "BCGPS3", JdeDataType.Numeric),
        new JdeField("BCGPSD2", "BCGPSD2", JdeDataType.String, 2),
        new JdeField("BCGPS4", "BCGPS4", JdeDataType.Numeric),
        new JdeField("BCGPS5", "BCGPS5", JdeDataType.Numeric),
        new JdeField("BCGPS6", "BCGPS6", JdeDataType.Numeric),
        new JdeField("BCUTM1", "BCUTM1", JdeDataType.String, 6),
        new JdeField("BCUTM2", "BCUTM2", JdeDataType.Numeric),
        new JdeField("BCUTM3", "BCUTM3", JdeDataType.Numeric),
        new JdeField("BCUTM4", "BCUTM4", JdeDataType.String, 4),
        new JdeField("BCELEVATIO", "BCELEVATIO", JdeDataType.Numeric),
        new JdeField("BCELEVUOM", "BCELEVUOM", JdeDataType.String, 4),
        new JdeField("BCURCD", "BCURCD", JdeDataType.String, 4),
        new JdeField("BCURDT", "BCURDT", JdeDataType.Numeric),
        new JdeField("BCURRF", "BCURRF", JdeDataType.String, 30),
        new JdeField("BCURAT", "BCURAT", JdeDataType.Numeric),
        new JdeField("BCURAB", "BCURAB", JdeDataType.Numeric),
        new JdeField("BCPID", "BCPID", JdeDataType.String, 20),
        new JdeField("BCTORG", "BCTORG", JdeDataType.String, 20),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20),
        new JdeField("BCJOBN", "BCJOBN", JdeDataType.String, 20),
        new JdeField("BCUUPMJ", "BCUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G023_0", "Primary Key on BCBLUID, BCLNID", new[] { "BCBLUID", "BCLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40G023_2", "Index on BCBLUID, BCSEQ", new[] { "BCBLUID", "BCSEQ" })
    };
}
