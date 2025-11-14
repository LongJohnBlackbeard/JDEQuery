using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B19 - .
/// </summary>
public class F76B19 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFBCLF.
        /// </summary>
        public const string TFBCLF = "TFBCLF";

        /// <summary>
        /// TFB76TIPI.
        /// </summary>
        public const string TFB76TIPI = "TFB76TIPI";

        /// <summary>
        /// TFB76EFDA.
        /// </summary>
        public const string TFB76EFDA = "TFB76EFDA";

        /// <summary>
        /// TFADDS.
        /// </summary>
        public const string TFADDS = "TFADDS";

        /// <summary>
        /// TFB76TBLE.
        /// </summary>
        public const string TFB76TBLE = "TFB76TBLE";

        /// <summary>
        /// TFB76DIBP.
        /// </summary>
        public const string TFB76DIBP = "TFB76DIBP";

        /// <summary>
        /// TFB76RDGS.
        /// </summary>
        public const string TFB76RDGS = "TFB76RDGS";

        /// <summary>
        /// TFB76RIGS.
        /// </summary>
        public const string TFB76RIGS = "TFB76RIGS";

        /// <summary>
        /// TFB76SRCE.
        /// </summary>
        public const string TFB76SRCE = "TFB76SRCE";

        /// <summary>
        /// TFB76VER.
        /// </summary>
        public const string TFB76VER = "TFB76VER";

        /// <summary>
        /// TFB76NUM.
        /// </summary>
        public const string TFB76NUM = "TFB76NUM";

        /// <summary>
        /// TFB76AA.
        /// </summary>
        public const string TFB76AA = "TFB76AA";

        /// <summary>
        /// TFB76REF.
        /// </summary>
        public const string TFB76REF = "TFB76REF";

        /// <summary>
        /// TFB76COD.
        /// </summary>
        public const string TFB76COD = "TFB76COD";

        /// <summary>
        /// TFB76DATE.
        /// </summary>
        public const string TFB76DATE = "TFB76DATE";

        /// <summary>
        /// TFUSER.
        /// </summary>
        public const string TFUSER = "TFUSER";

        /// <summary>
        /// TFPID.
        /// </summary>
        public const string TFPID = "TFPID";

        /// <summary>
        /// TFJOBN.
        /// </summary>
        public const string TFJOBN = "TFJOBN";

        /// <summary>
        /// TFUPMJ.
        /// </summary>
        public const string TFUPMJ = "TFUPMJ";

        /// <summary>
        /// TFUPMT.
        /// </summary>
        public const string TFUPMT = "TFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B19";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFBCLF", "TFBCLF", JdeDataType.String, 20, true, true),
        new JdeField("TFB76TIPI", "TFB76TIPI", JdeDataType.String, 6, true, true),
        new JdeField("TFB76EFDA", "TFB76EFDA", JdeDataType.Numeric, null, true, true),
        new JdeField("TFADDS", "TFADDS", JdeDataType.String, 6, true, true),
        new JdeField("TFB76TBLE", "TFB76TBLE", JdeDataType.String, 4, true, true),
        new JdeField("TFB76DIBP", "TFB76DIBP", JdeDataType.String, 1000),
        new JdeField("TFB76RDGS", "TFB76RDGS", JdeDataType.Numeric),
        new JdeField("TFB76RIGS", "TFB76RIGS", JdeDataType.Numeric),
        new JdeField("TFB76SRCE", "TFB76SRCE", JdeDataType.String, 200),
        new JdeField("TFB76VER", "TFB76VER", JdeDataType.String, 20),
        new JdeField("TFB76NUM", "TFB76NUM", JdeDataType.Numeric),
        new JdeField("TFB76AA", "TFB76AA", JdeDataType.Numeric),
        new JdeField("TFB76REF", "TFB76REF", JdeDataType.String, 30),
        new JdeField("TFB76COD", "TFB76COD", JdeDataType.String, 4),
        new JdeField("TFB76DATE", "TFB76DATE", JdeDataType.Numeric),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFJOBN", "TFJOBN", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B19_0", "Primary Key on TFBCLF, TFB76TIPI, TFB76EFDA, TFADDS, TFB76TBLE", new[] { "TFBCLF", "TFB76TIPI", "TFB76EFDA", "TFADDS", "TFB76TBLE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B19_2", "Index on TFBCLF, TFB76TIPI, SYS_NC00021$, TFADDS, TFB76TBLE", new[] { "TFBCLF", "TFB76TIPI", "SYS_NC00021$", "TFADDS", "TFB76TBLE" })
    };
}
