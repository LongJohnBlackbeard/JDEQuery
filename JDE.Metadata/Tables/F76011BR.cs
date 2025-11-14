using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76011BR - .
/// </summary>
public class F76011BR : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ANAN8.
        /// </summary>
        public const string ANAN8 = "ANAN8";

        /// <summary>
        /// ANFFU2.
        /// </summary>
        public const string ANFFU2 = "ANFFU2";

        /// <summary>
        /// ANMLNM.
        /// </summary>
        public const string ANMLNM = "ANMLNM";

        /// <summary>
        /// ANADD1.
        /// </summary>
        public const string ANADD1 = "ANADD1";

        /// <summary>
        /// ANADD2.
        /// </summary>
        public const string ANADD2 = "ANADD2";

        /// <summary>
        /// ANADD3.
        /// </summary>
        public const string ANADD3 = "ANADD3";

        /// <summary>
        /// ANADD4.
        /// </summary>
        public const string ANADD4 = "ANADD4";

        /// <summary>
        /// ANADDS.
        /// </summary>
        public const string ANADDS = "ANADDS";

        /// <summary>
        /// ANADDZ.
        /// </summary>
        public const string ANADDZ = "ANADDZ";

        /// <summary>
        /// ANCTR.
        /// </summary>
        public const string ANCTR = "ANCTR";

        /// <summary>
        /// ANDL01.
        /// </summary>
        public const string ANDL01 = "ANDL01";

        /// <summary>
        /// ANURCD.
        /// </summary>
        public const string ANURCD = "ANURCD";

        /// <summary>
        /// ANURDT.
        /// </summary>
        public const string ANURDT = "ANURDT";

        /// <summary>
        /// ANURAT.
        /// </summary>
        public const string ANURAT = "ANURAT";

        /// <summary>
        /// ANURAB.
        /// </summary>
        public const string ANURAB = "ANURAB";

        /// <summary>
        /// ANURRF.
        /// </summary>
        public const string ANURRF = "ANURRF";

        /// <summary>
        /// ANUSER.
        /// </summary>
        public const string ANUSER = "ANUSER";

        /// <summary>
        /// ANPID.
        /// </summary>
        public const string ANPID = "ANPID";

        /// <summary>
        /// ANJOBN.
        /// </summary>
        public const string ANJOBN = "ANJOBN";

        /// <summary>
        /// ANUPMJ.
        /// </summary>
        public const string ANUPMJ = "ANUPMJ";

        /// <summary>
        /// ANUPMT.
        /// </summary>
        public const string ANUPMT = "ANUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76011BR";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ANAN8", "ANAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ANFFU2", "ANFFU2", JdeDataType.String, 2),
        new JdeField("ANMLNM", "ANMLNM", JdeDataType.String, 80),
        new JdeField("ANADD1", "ANADD1", JdeDataType.String, 80),
        new JdeField("ANADD2", "ANADD2", JdeDataType.String, 80),
        new JdeField("ANADD3", "ANADD3", JdeDataType.String, 80),
        new JdeField("ANADD4", "ANADD4", JdeDataType.String, 80),
        new JdeField("ANADDS", "ANADDS", JdeDataType.String, 6),
        new JdeField("ANADDZ", "ANADDZ", JdeDataType.String, 24),
        new JdeField("ANCTR", "ANCTR", JdeDataType.String, 6),
        new JdeField("ANDL01", "ANDL01", JdeDataType.String, 60),
        new JdeField("ANURCD", "ANURCD", JdeDataType.String, 4),
        new JdeField("ANURDT", "ANURDT", JdeDataType.Numeric),
        new JdeField("ANURAT", "ANURAT", JdeDataType.Numeric),
        new JdeField("ANURAB", "ANURAB", JdeDataType.Numeric),
        new JdeField("ANURRF", "ANURRF", JdeDataType.String, 30),
        new JdeField("ANUSER", "ANUSER", JdeDataType.String, 20),
        new JdeField("ANPID", "ANPID", JdeDataType.String, 20),
        new JdeField("ANJOBN", "ANJOBN", JdeDataType.String, 20),
        new JdeField("ANUPMJ", "ANUPMJ", JdeDataType.Numeric),
        new JdeField("ANUPMT", "ANUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76011BR_0", "Primary Key on ANAN8", new[] { "ANAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
