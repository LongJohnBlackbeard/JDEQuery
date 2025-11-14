using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I407 - .
/// </summary>
public class F75I407 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ICITM.
        /// </summary>
        public const string ICITM = "ICITM";

        /// <summary>
        /// ICLITM.
        /// </summary>
        public const string ICLITM = "ICLITM";

        /// <summary>
        /// ICAITM.
        /// </summary>
        public const string ICAITM = "ICAITM";

        /// <summary>
        /// ICMCU.
        /// </summary>
        public const string ICMCU = "ICMCU";

        /// <summary>
        /// ICSRP1.
        /// </summary>
        public const string ICSRP1 = "ICSRP1";

        /// <summary>
        /// ICDL01.
        /// </summary>
        public const string ICDL01 = "ICDL01";

        /// <summary>
        /// ICDL02.
        /// </summary>
        public const string ICDL02 = "ICDL02";

        /// <summary>
        /// ICDL03.
        /// </summary>
        public const string ICDL03 = "ICDL03";

        /// <summary>
        /// ICDL04.
        /// </summary>
        public const string ICDL04 = "ICDL04";

        /// <summary>
        /// ICDL05.
        /// </summary>
        public const string ICDL05 = "ICDL05";

        /// <summary>
        /// ICDATE01.
        /// </summary>
        public const string ICDATE01 = "ICDATE01";

        /// <summary>
        /// ICDATE02.
        /// </summary>
        public const string ICDATE02 = "ICDATE02";

        /// <summary>
        /// ICDATE03.
        /// </summary>
        public const string ICDATE03 = "ICDATE03";

        /// <summary>
        /// ICDATE04.
        /// </summary>
        public const string ICDATE04 = "ICDATE04";

        /// <summary>
        /// ICDATE05.
        /// </summary>
        public const string ICDATE05 = "ICDATE05";

        /// <summary>
        /// ICFL01.
        /// </summary>
        public const string ICFL01 = "ICFL01";

        /// <summary>
        /// ICFL02.
        /// </summary>
        public const string ICFL02 = "ICFL02";

        /// <summary>
        /// ICFL03.
        /// </summary>
        public const string ICFL03 = "ICFL03";

        /// <summary>
        /// ICFL04.
        /// </summary>
        public const string ICFL04 = "ICFL04";

        /// <summary>
        /// ICFL05.
        /// </summary>
        public const string ICFL05 = "ICFL05";

        /// <summary>
        /// ICAIS1.
        /// </summary>
        public const string ICAIS1 = "ICAIS1";

        /// <summary>
        /// ICAIS2.
        /// </summary>
        public const string ICAIS2 = "ICAIS2";

        /// <summary>
        /// ICAIS3.
        /// </summary>
        public const string ICAIS3 = "ICAIS3";

        /// <summary>
        /// ICAIS4.
        /// </summary>
        public const string ICAIS4 = "ICAIS4";

        /// <summary>
        /// ICAIS5.
        /// </summary>
        public const string ICAIS5 = "ICAIS5";

        /// <summary>
        /// ICUKID.
        /// </summary>
        public const string ICUKID = "ICUKID";

        /// <summary>
        /// ICPID.
        /// </summary>
        public const string ICPID = "ICPID";

        /// <summary>
        /// ICUSER.
        /// </summary>
        public const string ICUSER = "ICUSER";

        /// <summary>
        /// ICJOBN.
        /// </summary>
        public const string ICJOBN = "ICJOBN";

        /// <summary>
        /// ICUPMJ.
        /// </summary>
        public const string ICUPMJ = "ICUPMJ";

        /// <summary>
        /// ICUPMT.
        /// </summary>
        public const string ICUPMT = "ICUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I407";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ICITM", "ICITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ICLITM", "ICLITM", JdeDataType.String, 50),
        new JdeField("ICAITM", "ICAITM", JdeDataType.String, 50),
        new JdeField("ICMCU", "ICMCU", JdeDataType.String, 24, true, true),
        new JdeField("ICSRP1", "ICSRP1", JdeDataType.String, 6),
        new JdeField("ICDL01", "ICDL01", JdeDataType.String, 60),
        new JdeField("ICDL02", "ICDL02", JdeDataType.String, 60),
        new JdeField("ICDL03", "ICDL03", JdeDataType.String, 60),
        new JdeField("ICDL04", "ICDL04", JdeDataType.String, 60),
        new JdeField("ICDL05", "ICDL05", JdeDataType.String, 60),
        new JdeField("ICDATE01", "ICDATE01", JdeDataType.Numeric),
        new JdeField("ICDATE02", "ICDATE02", JdeDataType.Numeric),
        new JdeField("ICDATE03", "ICDATE03", JdeDataType.Numeric),
        new JdeField("ICDATE04", "ICDATE04", JdeDataType.Numeric),
        new JdeField("ICDATE05", "ICDATE05", JdeDataType.Numeric),
        new JdeField("ICFL01", "ICFL01", JdeDataType.String, 2),
        new JdeField("ICFL02", "ICFL02", JdeDataType.String, 2),
        new JdeField("ICFL03", "ICFL03", JdeDataType.String, 2),
        new JdeField("ICFL04", "ICFL04", JdeDataType.String, 2),
        new JdeField("ICFL05", "ICFL05", JdeDataType.String, 2),
        new JdeField("ICAIS1", "ICAIS1", JdeDataType.Numeric),
        new JdeField("ICAIS2", "ICAIS2", JdeDataType.Numeric),
        new JdeField("ICAIS3", "ICAIS3", JdeDataType.Numeric),
        new JdeField("ICAIS4", "ICAIS4", JdeDataType.Numeric),
        new JdeField("ICAIS5", "ICAIS5", JdeDataType.Numeric),
        new JdeField("ICUKID", "ICUKID", JdeDataType.Numeric),
        new JdeField("ICPID", "ICPID", JdeDataType.String, 20),
        new JdeField("ICUSER", "ICUSER", JdeDataType.String, 20),
        new JdeField("ICJOBN", "ICJOBN", JdeDataType.String, 20),
        new JdeField("ICUPMJ", "ICUPMJ", JdeDataType.Numeric),
        new JdeField("ICUPMT", "ICUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I407_0", "Primary Key on ICITM, ICMCU", new[] { "ICITM", "ICMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
