using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F054111W - .
/// </summary>
public class F054111W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ECAN8.
        /// </summary>
        public const string ECAN8 = "ECAN8";

        /// <summary>
        /// ECIDLN.
        /// </summary>
        public const string ECIDLN = "ECIDLN";

        /// <summary>
        /// ECSLNM.
        /// </summary>
        public const string ECSLNM = "ECSLNM";

        /// <summary>
        /// ECMLNM.
        /// </summary>
        public const string ECMLNM = "ECMLNM";

        /// <summary>
        /// ECGNNM.
        /// </summary>
        public const string ECGNNM = "ECGNNM";

        /// <summary>
        /// ECIMN.
        /// </summary>
        public const string ECIMN = "ECIMN";

        /// <summary>
        /// ECSRNM.
        /// </summary>
        public const string ECSRNM = "ECSRNM";

        /// <summary>
        /// ECADD1.
        /// </summary>
        public const string ECADD1 = "ECADD1";

        /// <summary>
        /// ECCTY1.
        /// </summary>
        public const string ECCTY1 = "ECCTY1";

        /// <summary>
        /// ECADDS.
        /// </summary>
        public const string ECADDS = "ECADDS";

        /// <summary>
        /// ECADDZ.
        /// </summary>
        public const string ECADDZ = "ECADDZ";

        /// <summary>
        /// ECCTR.
        /// </summary>
        public const string ECCTR = "ECCTR";

        /// <summary>
        /// ECTYC.
        /// </summary>
        public const string ECTYC = "ECTYC";

        /// <summary>
        /// ECATTL.
        /// </summary>
        public const string ECATTL = "ECATTL";

        /// <summary>
        /// ECDSS5.
        /// </summary>
        public const string ECDSS5 = "ECDSS5";

        /// <summary>
        /// ECREM1.
        /// </summary>
        public const string ECREM1 = "ECREM1";

        /// <summary>
        /// ECACFL.
        /// </summary>
        public const string ECACFL = "ECACFL";

        /// <summary>
        /// ECUSER.
        /// </summary>
        public const string ECUSER = "ECUSER";

        /// <summary>
        /// ECPID.
        /// </summary>
        public const string ECPID = "ECPID";

        /// <summary>
        /// ECJOBN.
        /// </summary>
        public const string ECJOBN = "ECJOBN";

        /// <summary>
        /// ECUPMJ.
        /// </summary>
        public const string ECUPMJ = "ECUPMJ";

        /// <summary>
        /// ECUPMT.
        /// </summary>
        public const string ECUPMT = "ECUPMT";

        /// <summary>
        /// ECESIGN.
        /// </summary>
        public const string ECESIGN = "ECESIGN";

        /// <summary>
        /// ECMUMJ.
        /// </summary>
        public const string ECMUMJ = "ECMUMJ";

        /// <summary>
        /// ECMUMT.
        /// </summary>
        public const string ECMUMT = "ECMUMT";

        /// <summary>
        /// ECUPID.
        /// </summary>
        public const string ECUPID = "ECUPID";
    }

    /// <inheritdoc />
    public override string TableName => "F054111W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ECAN8", "ECAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ECIDLN", "ECIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ECSLNM", "ECSLNM", JdeDataType.String, 80),
        new JdeField("ECMLNM", "ECMLNM", JdeDataType.String, 80),
        new JdeField("ECGNNM", "ECGNNM", JdeDataType.String, 50),
        new JdeField("ECIMN", "ECIMN", JdeDataType.String, 2),
        new JdeField("ECSRNM", "ECSRNM", JdeDataType.String, 50),
        new JdeField("ECADD1", "ECADD1", JdeDataType.String, 80),
        new JdeField("ECCTY1", "ECCTY1", JdeDataType.String, 50),
        new JdeField("ECADDS", "ECADDS", JdeDataType.String, 6),
        new JdeField("ECADDZ", "ECADDZ", JdeDataType.String, 24),
        new JdeField("ECCTR", "ECCTR", JdeDataType.String, 6),
        new JdeField("ECTYC", "ECTYC", JdeDataType.String, 2),
        new JdeField("ECATTL", "ECATTL", JdeDataType.String, 80),
        new JdeField("ECDSS5", "ECDSS5", JdeDataType.Numeric),
        new JdeField("ECREM1", "ECREM1", JdeDataType.String, 80),
        new JdeField("ECACFL", "ECACFL", JdeDataType.String, 2),
        new JdeField("ECUSER", "ECUSER", JdeDataType.String, 20),
        new JdeField("ECPID", "ECPID", JdeDataType.String, 20),
        new JdeField("ECJOBN", "ECJOBN", JdeDataType.String, 20),
        new JdeField("ECUPMJ", "ECUPMJ", JdeDataType.Numeric),
        new JdeField("ECUPMT", "ECUPMT", JdeDataType.Numeric),
        new JdeField("ECESIGN", "ECESIGN", JdeDataType.String, 32),
        new JdeField("ECMUMJ", "ECMUMJ", JdeDataType.Numeric),
        new JdeField("ECMUMT", "ECMUMT", JdeDataType.Numeric),
        new JdeField("ECUPID", "ECUPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F054111W_0", "Primary Key on ECAN8, ECIDLN", new[] { "ECAN8", "ECIDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F054111W_2", "Index on ECAN8, SYS_NC00027$", new[] { "ECAN8", "SYS_NC00027$" }),
        new JdeIndex("F054111W_3", "Index on ECAN8, ECACFL", new[] { "ECAN8", "ECACFL" }),
        new JdeIndex("F054111W_4", "Index on ECAN8, ECESIGN", new[] { "ECAN8", "ECESIGN" })
    };
}
