using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C0411 - .
/// </summary>
public class F76C0411 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RPKCO.
        /// </summary>
        public const string RPKCO = "RPKCO";

        /// <summary>
        /// RPDOC.
        /// </summary>
        public const string RPDOC = "RPDOC";

        /// <summary>
        /// RPDCT.
        /// </summary>
        public const string RPDCT = "RPDCT";

        /// <summary>
        /// RPSFX.
        /// </summary>
        public const string RPSFX = "RPSFX";

        /// <summary>
        /// RPSFXE.
        /// </summary>
        public const string RPSFXE = "RPSFXE";

        /// <summary>
        /// RPAN8.
        /// </summary>
        public const string RPAN8 = "RPAN8";

        /// <summary>
        /// RPDGJ.
        /// </summary>
        public const string RPDGJ = "RPDGJ";

        /// <summary>
        /// RPMCU.
        /// </summary>
        public const string RPMCU = "RPMCU";

        /// <summary>
        /// RPTXA1.
        /// </summary>
        public const string RPTXA1 = "RPTXA1";

        /// <summary>
        /// RPEXR1.
        /// </summary>
        public const string RPEXR1 = "RPEXR1";

        /// <summary>
        /// RP76CAEC.
        /// </summary>
        public const string RP76CAEC = "RP76CAEC";

        /// <summary>
        /// RP76CCIIU.
        /// </summary>
        public const string RP76CCIIU = "RP76CCIIU";

        /// <summary>
        /// RP76CAC01.
        /// </summary>
        public const string RP76CAC01 = "RP76CAC01";

        /// <summary>
        /// RP76CAC02.
        /// </summary>
        public const string RP76CAC02 = "RP76CAC02";

        /// <summary>
        /// RP76CAC03.
        /// </summary>
        public const string RP76CAC03 = "RP76CAC03";

        /// <summary>
        /// RPURAB.
        /// </summary>
        public const string RPURAB = "RPURAB";

        /// <summary>
        /// RPURDT.
        /// </summary>
        public const string RPURDT = "RPURDT";

        /// <summary>
        /// RPURC1.
        /// </summary>
        public const string RPURC1 = "RPURC1";

        /// <summary>
        /// RPURRF.
        /// </summary>
        public const string RPURRF = "RPURRF";

        /// <summary>
        /// RPUSER.
        /// </summary>
        public const string RPUSER = "RPUSER";

        /// <summary>
        /// RPPID.
        /// </summary>
        public const string RPPID = "RPPID";

        /// <summary>
        /// RPJOBN.
        /// </summary>
        public const string RPJOBN = "RPJOBN";

        /// <summary>
        /// RPUPMJ.
        /// </summary>
        public const string RPUPMJ = "RPUPMJ";

        /// <summary>
        /// RPUPMT.
        /// </summary>
        public const string RPUPMT = "RPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76C0411";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RPKCO", "RPKCO", JdeDataType.String, 10, true, true),
        new JdeField("RPDOC", "RPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RPDCT", "RPDCT", JdeDataType.String, 4, true, true),
        new JdeField("RPSFX", "RPSFX", JdeDataType.String, 6, true, true),
        new JdeField("RPSFXE", "RPSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("RPAN8", "RPAN8", JdeDataType.Numeric),
        new JdeField("RPDGJ", "RPDGJ", JdeDataType.Numeric),
        new JdeField("RPMCU", "RPMCU", JdeDataType.String, 24),
        new JdeField("RPTXA1", "RPTXA1", JdeDataType.String, 20),
        new JdeField("RPEXR1", "RPEXR1", JdeDataType.String, 4),
        new JdeField("RP76CAEC", "RP76CAEC", JdeDataType.String, 6),
        new JdeField("RP76CCIIU", "RP76CCIIU", JdeDataType.String, 20),
        new JdeField("RP76CAC01", "RP76CAC01", JdeDataType.String, 6),
        new JdeField("RP76CAC02", "RP76CAC02", JdeDataType.String, 10),
        new JdeField("RP76CAC03", "RP76CAC03", JdeDataType.String, 16),
        new JdeField("RPURAB", "RPURAB", JdeDataType.Numeric),
        new JdeField("RPURDT", "RPURDT", JdeDataType.Numeric),
        new JdeField("RPURC1", "RPURC1", JdeDataType.String, 6),
        new JdeField("RPURRF", "RPURRF", JdeDataType.String, 30),
        new JdeField("RPUSER", "RPUSER", JdeDataType.String, 20),
        new JdeField("RPPID", "RPPID", JdeDataType.String, 20),
        new JdeField("RPJOBN", "RPJOBN", JdeDataType.String, 20),
        new JdeField("RPUPMJ", "RPUPMJ", JdeDataType.Numeric),
        new JdeField("RPUPMT", "RPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C0411_0", "Primary Key on RPDOC, RPDCT, RPKCO, RPSFX, RPSFXE", new[] { "RPDOC", "RPDCT", "RPKCO", "RPSFX", "RPSFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
