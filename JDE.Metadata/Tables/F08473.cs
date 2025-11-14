using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08473 - .
/// </summary>
public class F08473 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JWPSTDEE.
        /// </summary>
        public const string JWPSTDEE = "JWPSTDEE";

        /// <summary>
        /// JWPSTDEI.
        /// </summary>
        public const string JWPSTDEI = "JWPSTDEI";

        /// <summary>
        /// JWPSTDE.
        /// </summary>
        public const string JWPSTDE = "JWPSTDE";

        /// <summary>
        /// JWPSTDI.
        /// </summary>
        public const string JWPSTDI = "JWPSTDI";

        /// <summary>
        /// JWLNGP.
        /// </summary>
        public const string JWLNGP = "JWLNGP";

        /// <summary>
        /// JWPSTCAT.
        /// </summary>
        public const string JWPSTCAT = "JWPSTCAT";

        /// <summary>
        /// JWPSTCATDS.
        /// </summary>
        public const string JWPSTCATDS = "JWPSTCATDS";

        /// <summary>
        /// JWPSTDSC.
        /// </summary>
        public const string JWPSTDSC = "JWPSTDSC";

        /// <summary>
        /// JWPSTLOC.
        /// </summary>
        public const string JWPSTLOC = "JWPSTLOC";

        /// <summary>
        /// JWPSTLOCDS.
        /// </summary>
        public const string JWPSTLOCDS = "JWPSTLOCDS";

        /// <summary>
        /// JWPSTNO.
        /// </summary>
        public const string JWPSTNO = "JWPSTNO";

        /// <summary>
        /// JWPSTSTS.
        /// </summary>
        public const string JWPSTSTS = "JWPSTSTS";

        /// <summary>
        /// JWAEMAL.
        /// </summary>
        public const string JWAEMAL = "JWAEMAL";

        /// <summary>
        /// JWKEYWRD.
        /// </summary>
        public const string JWKEYWRD = "JWKEYWRD";

        /// <summary>
        /// JWPID.
        /// </summary>
        public const string JWPID = "JWPID";

        /// <summary>
        /// JWUSER.
        /// </summary>
        public const string JWUSER = "JWUSER";

        /// <summary>
        /// JWMKEY.
        /// </summary>
        public const string JWMKEY = "JWMKEY";

        /// <summary>
        /// JWUPMJ.
        /// </summary>
        public const string JWUPMJ = "JWUPMJ";

        /// <summary>
        /// JWUPMT.
        /// </summary>
        public const string JWUPMT = "JWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08473";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JWPSTDEE", "JWPSTDEE", JdeDataType.Numeric),
        new JdeField("JWPSTDEI", "JWPSTDEI", JdeDataType.Numeric),
        new JdeField("JWPSTDE", "JWPSTDE", JdeDataType.Numeric),
        new JdeField("JWPSTDI", "JWPSTDI", JdeDataType.Numeric),
        new JdeField("JWLNGP", "JWLNGP", JdeDataType.String, 4, true, true),
        new JdeField("JWPSTCAT", "JWPSTCAT", JdeDataType.String, 20),
        new JdeField("JWPSTCATDS", "JWPSTCATDS", JdeDataType.String, 160),
        new JdeField("JWPSTDSC", "JWPSTDSC", JdeDataType.String, 160),
        new JdeField("JWPSTLOC", "JWPSTLOC", JdeDataType.String, 6, true, true),
        new JdeField("JWPSTLOCDS", "JWPSTLOCDS", JdeDataType.String, 160),
        new JdeField("JWPSTNO", "JWPSTNO", JdeDataType.Numeric, null, true, true),
        new JdeField("JWPSTSTS", "JWPSTSTS", JdeDataType.String, 2),
        new JdeField("JWAEMAL", "JWAEMAL", JdeDataType.String, 512),
        new JdeField("JWKEYWRD", "JWKEYWRD", JdeDataType.String, 1000),
        new JdeField("JWPID", "JWPID", JdeDataType.String, 20),
        new JdeField("JWUSER", "JWUSER", JdeDataType.String, 20),
        new JdeField("JWMKEY", "JWMKEY", JdeDataType.String, 30),
        new JdeField("JWUPMJ", "JWUPMJ", JdeDataType.Numeric),
        new JdeField("JWUPMT", "JWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08473_0", "Primary Key on JWPSTNO, JWPSTLOC, JWLNGP", new[] { "JWPSTNO", "JWPSTLOC", "JWLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
