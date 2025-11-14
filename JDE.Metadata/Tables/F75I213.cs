using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I213 - .
/// </summary>
public class F75I213 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRAN8.
        /// </summary>
        public const string TRAN8 = "TRAN8";

        /// <summary>
        /// TRI75LTU.
        /// </summary>
        public const string TRI75LTU = "TRI75LTU";

        /// <summary>
        /// TRI75LTUN.
        /// </summary>
        public const string TRI75LTUN = "TRI75LTUN";

        /// <summary>
        /// TRI75PRMC.
        /// </summary>
        public const string TRI75PRMC = "TRI75PRMC";

        /// <summary>
        /// TRYNUM1.
        /// </summary>
        public const string TRYNUM1 = "TRYNUM1";

        /// <summary>
        /// TRYNUM2.
        /// </summary>
        public const string TRYNUM2 = "TRYNUM2";

        /// <summary>
        /// TRYFUSTR1.
        /// </summary>
        public const string TRYFUSTR1 = "TRYFUSTR1";

        /// <summary>
        /// TRYFUSTR2.
        /// </summary>
        public const string TRYFUSTR2 = "TRYFUSTR2";

        /// <summary>
        /// TRYFUSTR3.
        /// </summary>
        public const string TRYFUSTR3 = "TRYFUSTR3";

        /// <summary>
        /// TRUSER.
        /// </summary>
        public const string TRUSER = "TRUSER";

        /// <summary>
        /// TRPID.
        /// </summary>
        public const string TRPID = "TRPID";

        /// <summary>
        /// TRJOBN.
        /// </summary>
        public const string TRJOBN = "TRJOBN";

        /// <summary>
        /// TRUPMJ.
        /// </summary>
        public const string TRUPMJ = "TRUPMJ";

        /// <summary>
        /// TRUPMT.
        /// </summary>
        public const string TRUPMT = "TRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I213";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRAN8", "TRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TRI75LTU", "TRI75LTU", JdeDataType.String, 2),
        new JdeField("TRI75LTUN", "TRI75LTUN", JdeDataType.String, 60),
        new JdeField("TRI75PRMC", "TRI75PRMC", JdeDataType.String, 60),
        new JdeField("TRYNUM1", "TRYNUM1", JdeDataType.Numeric),
        new JdeField("TRYNUM2", "TRYNUM2", JdeDataType.Numeric),
        new JdeField("TRYFUSTR1", "TRYFUSTR1", JdeDataType.String, 60),
        new JdeField("TRYFUSTR2", "TRYFUSTR2", JdeDataType.String, 60),
        new JdeField("TRYFUSTR3", "TRYFUSTR3", JdeDataType.String, 60),
        new JdeField("TRUSER", "TRUSER", JdeDataType.String, 20),
        new JdeField("TRPID", "TRPID", JdeDataType.String, 20),
        new JdeField("TRJOBN", "TRJOBN", JdeDataType.String, 20),
        new JdeField("TRUPMJ", "TRUPMJ", JdeDataType.Numeric),
        new JdeField("TRUPMT", "TRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I213_0", "Primary Key on TRAN8", new[] { "TRAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
