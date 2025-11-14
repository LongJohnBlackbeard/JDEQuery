using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B031 - .
/// </summary>
public class F76B031 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCBNNF.
        /// </summary>
        public const string PCBNNF = "PCBNNF";

        /// <summary>
        /// PCBSER.
        /// </summary>
        public const string PCBSER = "PCBSER";

        /// <summary>
        /// PCN001.
        /// </summary>
        public const string PCN001 = "PCN001";

        /// <summary>
        /// PCDCT.
        /// </summary>
        public const string PCDCT = "PCDCT";

        /// <summary>
        /// PCUKID.
        /// </summary>
        public const string PCUKID = "PCUKID";

        /// <summary>
        /// PCB76PSR.
        /// </summary>
        public const string PCB76PSR = "PCB76PSR";

        /// <summary>
        /// PCB76PSB.
        /// </summary>
        public const string PCB76PSB = "PCB76PSB";

        /// <summary>
        /// PCB76PSA.
        /// </summary>
        public const string PCB76PSA = "PCB76PSA";

        /// <summary>
        /// PCB76CSR.
        /// </summary>
        public const string PCB76CSR = "PCB76CSR";

        /// <summary>
        /// PCB76CSB.
        /// </summary>
        public const string PCB76CSB = "PCB76CSB";

        /// <summary>
        /// PCB76CSA.
        /// </summary>
        public const string PCB76CSA = "PCB76CSA";

        /// <summary>
        /// PCB76PSE.
        /// </summary>
        public const string PCB76PSE = "PCB76PSE";

        /// <summary>
        /// PCB76URAB.
        /// </summary>
        public const string PCB76URAB = "PCB76URAB";

        /// <summary>
        /// PCB76URAT.
        /// </summary>
        public const string PCB76URAT = "PCB76URAT";

        /// <summary>
        /// PCB76URRF.
        /// </summary>
        public const string PCB76URRF = "PCB76URRF";

        /// <summary>
        /// PCB76URDT.
        /// </summary>
        public const string PCB76URDT = "PCB76URDT";

        /// <summary>
        /// PCB76URCD.
        /// </summary>
        public const string PCB76URCD = "PCB76URCD";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCUPMT.
        /// </summary>
        public const string PCUPMT = "PCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B031";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCBNNF", "PCBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("PCBSER", "PCBSER", JdeDataType.String, 4, true, true),
        new JdeField("PCN001", "PCN001", JdeDataType.Numeric, null, true, true),
        new JdeField("PCDCT", "PCDCT", JdeDataType.String, 4, true, true),
        new JdeField("PCUKID", "PCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PCB76PSR", "PCB76PSR", JdeDataType.Numeric),
        new JdeField("PCB76PSB", "PCB76PSB", JdeDataType.Numeric),
        new JdeField("PCB76PSA", "PCB76PSA", JdeDataType.Numeric),
        new JdeField("PCB76CSR", "PCB76CSR", JdeDataType.Numeric),
        new JdeField("PCB76CSB", "PCB76CSB", JdeDataType.Numeric),
        new JdeField("PCB76CSA", "PCB76CSA", JdeDataType.Numeric),
        new JdeField("PCB76PSE", "PCB76PSE", JdeDataType.Numeric),
        new JdeField("PCB76URAB", "PCB76URAB", JdeDataType.Numeric),
        new JdeField("PCB76URAT", "PCB76URAT", JdeDataType.Numeric),
        new JdeField("PCB76URRF", "PCB76URRF", JdeDataType.String, 30),
        new JdeField("PCB76URDT", "PCB76URDT", JdeDataType.Numeric),
        new JdeField("PCB76URCD", "PCB76URCD", JdeDataType.String, 4),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCUPMT", "PCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B031_0", "Primary Key on PCBNNF, PCBSER, PCN001, PCDCT, PCUKID", new[] { "PCBNNF", "PCBSER", "PCN001", "PCDCT", "PCUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
